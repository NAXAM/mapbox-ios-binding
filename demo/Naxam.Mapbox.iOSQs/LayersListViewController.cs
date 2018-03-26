using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using Mapbox;
using Masonry;
using Naxam.Mapbox.Common;
using Newtonsoft.Json.Linq;
using UIKit;

namespace Naxam.Mapbox.iOSQs
{
    class DisplayedLayer
    {
        public string Id
        {
            get;
            set;
        }


        public nfloat Opacity
        {
            get;
            set;
        }
    }

    class ImageLayer : DisplayedLayer
    {
        public UIImage Image
        {
            get;
            set;
        }
    }

    class LineLayer : DisplayedLayer
    {
        public UIColor LineColor
        {
            get;
            set;
        }

        public double[] Dashes
        {
            get;
            set;
        }
    }

    class FillLayer : DisplayedLayer
    {
        public UIColor FillColor
        {
            get; set;
        }
    }

    class CircleLayer : DisplayedLayer
    {
        public UIColor FillColor
        {
            get; set;
        }
    }


    class LayerGroup
    {
        public MapboxGroup Info
        {
            get;
            set;
        }
        public DisplayedLayer[] Layers
        {
            get;
            set;
        }
    }
    public class LayersListViewController : UIViewController, IUITableViewDelegate, IUITableViewDataSource
    {
        private readonly UITableView tableView;
        public MGLStyle Style { get; private set; }
        private RemoteStyle remoteStyle;
        private LayerGroup[] groups;
        private readonly IMapboxService mbService;
        private readonly string styleOwner;
        private readonly string styleId;
        public double ZoomLevel;

        public LayersListViewController(MGLStyle style, string styleOwner, string styleId) : base(null, null)
        {
            tableView = new UITableView()
            {
                DataSource = this,
                Delegate = this,
                TranslatesAutoresizingMaskIntoConstraints = false
            };
            tableView.RegisterClassForCellReuse(typeof(UITableViewCell), "ImageCell");
            tableView.RegisterClassForCellReuse(typeof(UITableViewCell), "FillCell");
            tableView.RegisterClassForCellReuse(typeof(UITableViewCell), "CircleCell");
            tableView.RegisterClassForCellReuse(typeof(UITableViewCell), "LineCell");

            Style = style;
            mbService = new MapboxService();
            this.styleOwner = styleOwner;
            this.styleId = styleId;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.AddSubview(tableView);
            tableView.MakeConstraints((mk) =>
            {
                mk.Edges.EqualTo(View);
            });
            var groupsDict = new Dictionary<string, List<DisplayedLayer>>();

            foreach (MGLStyleLayer layer in Style.Layers)
            {
                DisplayedLayer newLayer = null;

                var gn = "No group";

                if (layer is MGLVectorStyleLayer vl)
                {
                    if (vl is MGLSymbolStyleLayer sl && sl.IconImageName != null)
                    {
                        newLayer = new ImageLayer()
                        {
                            Id = layer.Identifier
                        };
                        if (sl.IconImageName is MGLCameraStyleFunction csFunc)
                        {
                            var imgName = GetValueFromCameraStyleFunction(csFunc);
                            if (imgName != null)
                            {
                                (newLayer as ImageLayer).Image = Style.ImageForName(imgName.ToString());
                            }
                        }
                        else
                        {
                            var imgName = GetObjectFromStyleValue(sl.IconImageName);
                            if (imgName != null)
                            {
                                (newLayer as ImageLayer).Image = Style.ImageForName(imgName.ToString());
                            }
                        }
                    }
                    else if (vl is MGLLineStyleLayer ll)
                    {
                        newLayer = new LineLayer()
                        {
                            Id = layer.Identifier,
                            LineColor = GetObjectFromStyleValue(ll.LineColor) as UIColor
                        };

                        if (ll.LineDashPattern != null)
                        {

                            if (GetObjectFromStyleValue(ll.LineDashPattern) is NSArray arr && arr.Count != 0)
                            {
                                var dash = new List<double>();
                                for (nuint i = 0; i < arr.Count; i++)
                                {
                                    var obj = arr.GetItem<NSNumber>(i);
                                    dash.Add(obj.DoubleValue);
                                }
                                (newLayer as LineLayer).Dashes = dash.ToArray();
                            }
                            else
                            {

                            }
                        }
                    }
                    else if (vl is MGLCircleStyleLayer cl)
                    {
                        newLayer = new CircleLayer()
                        {
                            Id = layer.Identifier,
                            FillColor = GetObjectFromStyleValue(cl.CircleColor) as UIColor
                        };
                    }
                    else if (vl is MGLFillStyleLayer fl)
                    {
                        newLayer = new FillLayer()
                        {
                            Id = layer.Identifier,
                            FillColor = GetObjectFromStyleValue(fl.FillColor) as UIColor
                        };
                    }
                    if (!string.IsNullOrEmpty(vl.SourceLayerIdentifier))
                    {
                        gn = vl.SourceLayerIdentifier;
                    }

                }
                if (newLayer != null)
                {
                    if (groupsDict.ContainsKey(gn))
                    {
                        groupsDict[gn].Add(newLayer);
                    }
                    else
                    {
                        var lst = new List<DisplayedLayer>() { newLayer };
                        groupsDict.Add(gn, lst);
                    }
                }
            }
            var groupList = new List<LayerGroup>();
            foreach (string gn in groupsDict.Keys)
            {
                groupList.Add(new LayerGroup()
                {
                    Info = new MapboxGroup()
                    {
                        Name = gn
                    },
                    Layers = groupsDict[gn].ToArray()
                });
            }
            groups = groupList.ToArray();
        }

        private NSObject GetValueFromCameraStyleFunction(MGLCameraStyleFunction csFunc)
        {
            if (csFunc.Stops == null || csFunc.Stops.Count == 0) return null;
            MGLStyleValue output = null;
            switch (csFunc.InterpolationMode)
            {
                case MGLInterpolationMode.Identity:
                    nuint i = 0;
                    while (i < csFunc.Stops.Count)
                    {
                        var key = csFunc.Stops.Keys[i];
                        var zoomLevel = (key as NSNumber).DoubleValue;
                        if (zoomLevel < ZoomLevel)
                        {
                            output = csFunc.Stops[key];
                        }
                        else
                        {
                            break;
                        }
                        i++;
                    }
                    break;
                default: break;
            }
            if (output == null)
            {
                output = csFunc.Stops.Values[0];
            }
            return GetObjectFromStyleValue(output);
        }

        private NSObject GetObjectFromStyleValue(MGLStyleValue value)
        {
            if (value is MGLConstantStyleValue cValue)
            {
                return cValue.RawValue;
            }
            if (value is MGLCameraStyleFunction csFunc)
            {
                return GetValueFromCameraStyleFunction(csFunc);
            }
            if (value != null && value.RespondsToSelector(new ObjCRuntime.Selector("rawValue"))) {
                return value.ValueForKey((NSString)"rawValue");
            }
            return value;
        }


        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            //InvokeInBackground(async () =>
            //{
            //remoteStyle = await mbService.GetStyleDetails(styleOwner, styleId, MGLAccountManager.AccessToken);
            //if (remoteStyle != null)
            //{
            //    var gList = new List<LayerGroup>();
            //    foreach (string groupId in remoteStyle.Metadata.Groups.Keys)
            //    {
            //        gList.Add(new LayerGroup()
            //        {
            //            Info = remoteStyle.Metadata.Groups[groupId],
            //            Layers = remoteStyle.Layers
            //                                .Where((arg) => arg.Metadata?.GroupId == groupId)
            //                                .Select((arg) => new DisplayedLayer()
            //                                {
            //                                    Id = arg.Id,
            //                                    Image = GetImageFromLayer(arg)
            //                                })
            //                                .ToArray()

            //        });
            //    }
            //    gList.Add(new LayerGroup()
            //    {
            //        Info = new MapboxGroup()
            //        {
            //            Name = "No group"
            //        },
            //        Layers = remoteStyle.Layers
            //                            .Where((arg) => string.IsNullOrEmpty(arg.Metadata?.GroupId))
            //                                .Select((arg) => new DisplayedLayer()
            //                                {
            //                                    Id = arg.Id,
            //                                    Image = GetImageFromLayer(arg)
            //                                })
            //                                .ToArray()

            //    });
            //    groups = gList.ToArray();
            //}
            //InvokeOnMainThread(() =>
            //{
            //    tableView.ReloadData();
            //});
            //});
        }

        private UIImage GetImageFromLayer(RemoteLayer layer)
        {
            var iconImg = layer.Layout?.IconImage;
            if (iconImg == null && remoteStyle?.Layers?.FirstOrDefault((arg) => arg.Id == layer.SourceLayer) is RemoteLayer sourceLayer)
            {
                iconImg = sourceLayer.Layout?.IconImage;
            }

            if (iconImg is JObject jo)
            {
                if (jo.Property("stops") != null)
                {
                    var imgWithStops = jo.ToObject<IconImageWithStops>();
                    if (imgWithStops != null && imgWithStops.Stops != null && imgWithStops.Stops.Length != 0)
                    {
                        var first = imgWithStops.Stops.First();
                        if (first.Length > 1)
                        {
                            iconImg = first[1] as string;
                        }
                    }
                }
            }
            if (iconImg is string imgName)
            {
                return Style.ImageForName(imgName);
            }
            return null;
        }

        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var layer = groups[indexPath.Section].Layers[indexPath.Row];
            UITableViewCell cell = null;
            var str = new NSMutableAttributedString(layer.Id);

            if (layer is ImageLayer il)
            {
                cell = tableView.DequeueReusableCell("ImageCell");
                cell.ImageView.Image = il.Image;
            }
            else if (layer is LineLayer ll)
            {
                cell = tableView.DequeueReusableCell("LineCell");
                str.Append(new NSAttributedString(" (line)", new UIStringAttributes()
                {
                    ForegroundColor = ll.LineColor
                }));
                if (ll.Dashes != null)
                {
                    str.Append(new NSAttributedString(" (" + string.Join(",", ll.Dashes) + ")", new UIStringAttributes()
                    {
                        ForegroundColor = ll.LineColor
                    }));
                }
            }
            else if (layer is FillLayer fl)
            {
                cell = tableView.DequeueReusableCell("FillCell");
                cell.BackgroundColor = fl.FillColor;
            }
            else if (layer is CircleLayer cl)
            {
                cell = tableView.DequeueReusableCell("CircleCell");
                cell.BackgroundColor = cl.FillColor;
                cell.ContentView.Layer.CornerRadius = 20;
                cell.ContentView.Layer.MasksToBounds = true;
            }
            cell.TextLabel.AttributedText = str;
            return cell;
            //var cell = tableView.DequeueReusableCell("Cell");
            //cell.TextLabel.Text = layer.Id;
            //cell.ImageView.Image = layer.Image;
            //cell.TextLabel.TextColor = layer.LineColor;
            //if (layer.Dashes != null)
            //{
            //    cell.TextLabel.Text += " " + string.Join(",", layer.Dashes);
            //}
            //        var layer = Style.Layers[indexPath.Row];
            //        cell.TextLabel.Text = layer.Identifier;
            //        if (remoteLayers?.FirstOrDefault( (arg) => arg.Id == layer.Identifier) is RemoteLayer rl)
            //           {
            //            var iconImg = rl.Layout?.IconImage;
            //            if (iconImg == null && remoteLayers?.FirstOrDefault((arg) => arg.Id == rl.SourceLayer) is RemoteLayer sourceLayer)
            //            {
            //                iconImg = sourceLayer.Layout?.IconImage;
            //            }

            //            if (iconImg is JObject jo) {
            //                if (jo.Property("stops") != null) {
            //      var imgWithStops = jo.ToObject<IconImageWithStops>();
            //                    if (imgWithStops != null && imgWithStops.Stops != null && imgWithStops.Stops.Length != 0) {
            //                        var first = imgWithStops.Stops.First();
            //                        if (first.Length > 1) {
            //                            iconImg = first[1] as string;
            //                        }
            //                    }
            //                }
            //            }
            //if (iconImg is string imgName)
            //{
            //  cell.ImageView.Image = Style.ImageForName(imgName);
            //}
            //    else if (iconImg != null) {

            //    }
            //}
            //else {
            //    cell.ImageView.Image = null;
            //}
            //return cell;
        }

        public nint RowsInSection(UITableView tableView, nint section)
        {
            if (groups[section].Layers == null) return 0;
            return groups[section].Layers.Length;
        }

        [Export("numberOfSectionsInTableView:")]
        public nint NumberOfSections(UITableView tableView)
        {
            return groups == null ? 0 : groups.Length;
        }

        [Export("tableView:titleForHeaderInSection:")]
        public string TitleForHeader(UITableView tableView, nint section)
        {
            return groups[section].Info.Name;
        }
    }
}
