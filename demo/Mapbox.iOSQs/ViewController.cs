using System;
using System.Diagnostics;
using CoreLocation;
using Foundation;
using MapboxCoreMaps;
using MapboxMaps;
using UIKit;
using MapboxMapsObjC;

namespace Mapbox.iOSQs
{
    public partial class ViewController : UIViewController
    {

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

		public T GetValueFromExpression<T>(NSExpression expr) where T : NSObject
        {
            if (expr == null) return default(T);
            switch (expr.ExpressionType)
            {
                case NSExpressionType.ConstantValue:
                    return expr.ConstantValue as T;
                case NSExpressionType.NSAggregate:
                    if (expr.Collection is T)
                        return expr.Collection as T;
                    if (expr.Collection is NSArray array
                        && array.Count != 0)
                    {
                        var first = array.GetItem<T>(0);
                        if (first is NSExpression innerExpr)
                        {
                            return GetValueFromExpression<T>(innerExpr);
                        }
                        return first;
                    }
                    return default(T);
                case NSExpressionType.Function:
                    //TODO
                    var function = expr.Function; //"mgl_interpolate:withCurveType:parameters:stops:"
                    if (expr.Arguments is NSExpression[] args)// $zoomLevel, exponential, 1.299999, {{ 13 = "0.5", 20 = 2;}}
                    {
                        //TODO
                    }
                    return default(T);
                default:
                    return default(T);
            }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var myResourceOptions = new MBMResourceOptions(
                "your access token", null, null, null, null);
            var myMapInitOptions = MapInitOptionsFactory.CreateWithResourceOptions(myResourceOptions, null, null, (string)null);
            // Perform any additional setup after loading the view, typically from a nib.
            var mapView = MapViewFactory.CreateWithFrame(
                View.Bounds,
                myMapInitOptions
            );
            this.View.AddSubview(mapView);

            //         mapView.SetCenterCoordinate(new CLLocationCoordinate2D(21.028511, 105.804817), 11, false);

            //         var temple = new MGLPointAnnotation()
            //         {
            //             Title = "Temple of literature",
            //             Subtitle = "Van Mieu - Quoc Tu Giam",
            //             Coordinate = new CLLocationCoordinate2D(21.0276, 105.8355)
            //         };
            //         mapView.AddAnnotation(temple);

            //var newLayer = new MGLSymbolStyleLayer(Guid.NewGuid().ToString(), new MGLSource("xxx"))
            //         {
            //             IconImageName = NSExpression.FromConstant(new NSString("temple")),
            //             IconOpacity = NSExpression.FromConstant(NSNumber.FromDouble(0.7))
            //         };
            //Debug.WriteLine(newLayer.IconImageName.ToString());
        }

        //[Export("mapViewDidFinishLoadingMap:")]
        //public void MapViewDidFinishLoadingMap(MGLMapView mapView)
        //{
        //    var coordinates = new CLLocationCoordinate2D[] {
        //        new CLLocationCoordinate2D(latitude: mapView.CenterCoordinate.Latitude + 0.03, longitude: mapView.CenterCoordinate.Longitude - 0.02),
        //        new CLLocationCoordinate2D(latitude: mapView.CenterCoordinate.Latitude + 0.02, longitude: mapView.CenterCoordinate.Longitude - 0.03),
        //        new CLLocationCoordinate2D(latitude: mapView.CenterCoordinate.Latitude, longitude: mapView.CenterCoordinate.Longitude - 0.02),
        //        new CLLocationCoordinate2D(latitude: mapView.CenterCoordinate.Latitude -0.01, longitude: mapView.CenterCoordinate.Longitude),
        //        new CLLocationCoordinate2D(latitude: mapView.CenterCoordinate.Latitude -0.04, longitude: mapView.CenterCoordinate.Longitude + 0.01),
        //        new CLLocationCoordinate2D(latitude: mapView.CenterCoordinate.Latitude -0.04, longitude: mapView.CenterCoordinate.Longitude + 0.04)
        //    };
        //    var polyline = MGLPolyline.PolylineWithCoordinates(ref coordinates[0], (nuint)coordinates.Length);
        //    mapView.AddAnnotation(polyline);

        //}

        //[Export("mapView:strokeColorForShapeAnnotation:")]
        //public UIColor MapView_StrokeColorForShapeAnnotation(MGLMapView mapView, MGLShape annotation)
        //{
        //    return UIColor.Blue;
        //}

        //[Export("mapView:lineWidthForPolylineAnnotation:")]
        //public nfloat MapView_LineWidthForPolylineAnnotation(MGLMapView mapView, MGLPolyline annotation)
        //{
        //    return 2.0f;
        //}

        ////private void ShowLayers(object sender, EventArgs e)
        ////{
        ////    if (mapView.Style == null) return;
        ////    var styleId = mapView.StyleURL.LastPathComponent;
        ////    var owner = mapView.StyleURL.RemoveLastPathComponent().LastPathComponent;
        ////    var vc = new LayersListViewController(mapView.Style, owner, styleId);
        ////    PresentViewController(vc, true, null);
        ////}

        //[Export("mapView:annotationCanShowCallout:")]
        //public bool MapView_AnnotationCanShowCallout(MGLMapView mapView, IMGLAnnotation annotation)
        //{
        //    return true;
        //}

        //[Export("mapView:imageForAnnotation:")]
        //public MGLAnnotationImage MapView_ImageForAnnotation(MGLMapView mapView, IMGLAnnotation annotation)
        //{
        //    var annotationImage = mapView.DequeueReusableAnnotationImageWithIdentifier("temple");
        //    if (annotationImage == null) {
        //        var image = UIImage.FromBundle("temple");
        //        image = image.ImageWithAlignmentRectInsets(new UIEdgeInsets(0, 0, image.Size.Height / 2, 0));
        //        annotationImage = MGLAnnotationImage.AnnotationImageWithImage(image, "temple");
        //    }
        //    return annotationImage;
        //}

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
