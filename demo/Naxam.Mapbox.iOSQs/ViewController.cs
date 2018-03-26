using System;
using CoreLocation;
using Foundation;
using Mapbox;
using UIKit;

namespace Naxam.Mapbox.iOSQs
{
    public partial class ViewController : UIViewController, IMGLMapViewDelegate
    {

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var mapView = new MGLMapView(
                View.Bounds,
                new NSUrl("mapbox://styles/naxamtest/cj5kin5x21li42soxdx3mb1yt")
            );
            this.View.AddSubview(mapView);
            mapView.WeakDelegate = this;

            mapView.SetCenterCoordinate(new CLLocationCoordinate2D(21.028511, 105.804817), 11, false);

            var temple = new MGLPointAnnotation()
            {
                Title = "Temple of literature",
                Subtitle = "Van Mieu - Quoc Tu Giam",
                Coordinate = new CLLocationCoordinate2D(21.0276, 105.8355)
            };
            mapView.AddAnnotation(temple);

        }

        [Export("mapViewDidFinishLoadingMap:")]
        public void MapViewDidFinishLoadingMap(MGLMapView mapView)
        {
            var coordinates = new CLLocationCoordinate2D[] {
                new CLLocationCoordinate2D(latitude: mapView.CenterCoordinate.Latitude + 0.03, longitude: mapView.CenterCoordinate.Longitude - 0.02),
                new CLLocationCoordinate2D(latitude: mapView.CenterCoordinate.Latitude + 0.02, longitude: mapView.CenterCoordinate.Longitude - 0.03),
                new CLLocationCoordinate2D(latitude: mapView.CenterCoordinate.Latitude, longitude: mapView.CenterCoordinate.Longitude - 0.02),
                new CLLocationCoordinate2D(latitude: mapView.CenterCoordinate.Latitude -0.01, longitude: mapView.CenterCoordinate.Longitude),
                new CLLocationCoordinate2D(latitude: mapView.CenterCoordinate.Latitude -0.04, longitude: mapView.CenterCoordinate.Longitude + 0.01),
                new CLLocationCoordinate2D(latitude: mapView.CenterCoordinate.Latitude -0.04, longitude: mapView.CenterCoordinate.Longitude + 0.04)
            };
            var polyline = MGLPolyline.PolylineWithCoordinates(ref coordinates[0], (nuint)coordinates.Length);
            mapView.AddAnnotation(polyline);

        }

        [Export("mapView:strokeColorForShapeAnnotation:")]
        public UIColor MapView_StrokeColorForShapeAnnotation(MGLMapView mapView, MGLShape annotation)
        {
            return UIColor.Blue;
        }

        [Export("mapView:lineWidthForPolylineAnnotation:")]
        public nfloat MapView_LineWidthForPolylineAnnotation(MGLMapView mapView, MGLPolyline annotation)
        {
            return 2.0f;
        }

        //private void ShowLayers(object sender, EventArgs e)
        //{
        //    if (mapView.Style == null) return;
        //    var styleId = mapView.StyleURL.LastPathComponent;
        //    var owner = mapView.StyleURL.RemoveLastPathComponent().LastPathComponent;
        //    var vc = new LayersListViewController(mapView.Style, owner, styleId);
        //    PresentViewController(vc, true, null);
        //}

        [Export("mapView:annotationCanShowCallout:")]
        public bool MapView_AnnotationCanShowCallout(MGLMapView mapView, IMGLAnnotation annotation)
        {
            return true;
        }

        [Export("mapView:imageForAnnotation:")]
        public MGLAnnotationImage MapView_ImageForAnnotation(MGLMapView mapView, IMGLAnnotation annotation)
        {
            var annotationImage = mapView.DequeueReusableAnnotationImageWithIdentifier("temple");
            if (annotationImage == null) {
                var image = UIImage.FromBundle("temple");
                image = image.ImageWithAlignmentRectInsets(new UIEdgeInsets(0, 0, image.Size.Height / 2, 0));
                annotationImage = MGLAnnotationImage.AnnotationImageWithImage(image, "temple");
            }
            return annotationImage;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
