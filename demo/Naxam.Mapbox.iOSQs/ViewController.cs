using System;
using CoreLocation;
using Mapbox;
using UIKit;

namespace Naxam.Mapbox.iOSQs
{
	public partial class ViewController : UIViewController, IMGLMapViewDelegate
	{
		MGLMapView mapView;

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			// Create a MapView and set the coordinates/zoom
			mapView = new MGLMapView(View.Bounds);
			mapView.SetCenterCoordinate(new CLLocationCoordinate2D(40.7326808, -73.9843407), false);
			mapView.SetZoomLevel(11, false);

			View.AddSubview(mapView);

			//mapView.Delegate = this;

			// Add new annotation
			mapView.AddAnnotation(new MGLPointAnnotation
			{
				Coordinate = new CLLocationCoordinate2D(40.7326808, -73.9843407),
				Title = "Sample Marker",
				Subtitle = "This is the subtitle"
			});
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
