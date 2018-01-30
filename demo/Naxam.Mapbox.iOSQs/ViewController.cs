using System;
using System.Collections.Generic;
using CoreLocation;
using Mapbox;
using UIKit;
using Masonry;
using Foundation;
using CoreGraphics;

namespace Naxam.Mapbox.iOSQs
{
    public class MyMapView : MGLMapView
    {
        public MyMapView(CGRect rect) : base(rect)
        {

        }
    }

	public partial class ViewController : UIViewController, IMGLMapViewDelegate
	{
        MyMapView mapView;

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            // Create a MapView and set the coordinates/zoom
            mapView = new MyMapView(View.Bounds)
            {
                TranslatesAutoresizingMaskIntoConstraints = false   
            };
			mapView.SetCenterCoordinate(new CLLocationCoordinate2D(40.7326808, -73.9843407), false);
			mapView.SetZoomLevel(11, false);
            mapView.ScaleBar.Hidden = false;
            var tapGest = new UITapGestureRecognizer((UITapGestureRecognizer sender) => {
                if (sender.State == UIGestureRecognizerState.Ended) {
                    var touchedPoint = sender.LocationOfTouch(0, mapView);
                    var coords = mapView.ConvertPoint(touchedPoint, mapView);
                    var reversePoint = mapView.ConvertCoordinate(coords, mapView);

                    var alert = UIAlertController.Create("Mapbox", $"Coords: { coords.Latitude},{ coords.Longitude}", UIAlertControllerStyle.Alert);
                    alert.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, delegate {
                        alert.DismissViewController(true, null);
                    }));

                    PresentViewController(alert, true, null);
                }   
            });
            mapView.AddGestureRecognizer(tapGest);
			View.AddSubview(mapView);

            //mapView.Delegate = this;

            //// Add new annotation
            //mapView.AddAnnotation(new MGLPointAnnotation
            //{
            //	Coordinate = new CLLocationCoordinate2D(40.7326808, -73.9843407),
            //	Title = "Sample Marker",
            //	Subtitle = "This is the subtitle"
            //});
            mapView.StyleURL = new NSUrl("mapbox://styles/naxamtest/cj5kin5x21li42soxdx3mb1yt");

            //System.Diagnostics.Debug.WriteLine($"Mapbox-Version:: {Constants.MapboxVersionNumber} :: {Constants.MapboxVersionString}");
            var toolbar = new UIToolbar()
            {
                Translucent = false,
                TranslatesAutoresizingMaskIntoConstraints = false,
            };
            var items = new List<UIBarButtonItem>();
            {
                var item = new UIBarButtonItem(title: "Layers", style: UIBarButtonItemStyle.Plain, handler: ShowLayers);
                items.Add(item);
            }
            var itemsArr = items.ToArray();
            toolbar.SetItems(itemsArr, false);
            View.AddSubview(toolbar);

            toolbar.MakeConstraints( (mk) => {
                mk.Left.Right.Bottom.EqualTo(View);
                mk.Height.EqualTo(NSNumber.FromNFloat(44.0f));
            });
            mapView.MakeConstraints( (mk) => {
                mk.Left.Right.Top.EqualTo(View);
                mk.Bottom.EqualTo(mk.Top);
            });
		}

        private void ShowLayers(object sender, EventArgs e)
        {
            if (mapView.Style == null) return;
            var styleId = mapView.StyleURL.LastPathComponent;
            var owner = mapView.StyleURL.RemoveLastPathComponent().LastPathComponent;
            var vc = new LayersListViewController(mapView.Style, owner, styleId);
            PresentViewController(vc, true, null);
        }

        public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
