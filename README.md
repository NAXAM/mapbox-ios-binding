# Xamarin Binding - Mapbox iOS SDK

> This binding library is in internal verification and testing. 
> Any forks are warmly welcome to make it quicker and better.

## Mapbox Access Token

An access token is necessary to use Mapbox services and APIs, such as maps, directions, and geocoding. Your access tokens can be managed in your account settings, where you can retrieve current tokens and generate new ones. You should create a new token for each of your apps, which will help you track usage and minimize disruption in the event a token needs to be revoked.

Visit http://mapbox.com to create an account and generate an access token.

### Configure your iOS project

Once you have generated an access token, you need to set it up within your app. There are two ways to provide an access token in your app:

1. In the Info.plist file set MGLMapboxAccessToken with the value of your token.
2. In the AppDelegate.FinishedLaunching method, call AccountManager.AccessToken = "YOUR-TOKEN";

## Metrics Opt-Out

The Mapbox Terms of Service require your app to provide users with a way to individually opt out of Mapbox Metrics. You can provide this opt out in one of two ways:

1. Add a setting to your app’s section in the system Settings app (via a Settings.bundle in your application bundle). You can download a [sample Settings.bundle](https://www.mapbox.com/guides/data/ios/Settings.bundle.zip) file to help you implement this.
2. Integrate the setting directly into your app. Hook the UISwitch control up to the MGLMapboxMetricsEnabled Boolean user default, which should be YES by default. Then set MGLMapboxMetricsEnabledSettingShownInApp to YES in your app’s Info.plist file.

## Location Services

In order to show the user’s position on the map, you must first ask for their permission. In iOS 8 and above, this is accomplished by creating and setting the NSLocationAlwaysUsageDescription key in the Info.plist file.

For developers on the free Starter plan, background location services must also be enabled. You can find instructions on how to do this in our First Steps guide.

## Add Nuget package
```
Install-Package Naxam.Mapbox.iOS
```

## Show it up

Creating a map is very simple using the MapView class:

```c#
// Create a MapView and set the coordinates/zoom
mapView = new MGLMapView (View.Bounds);
mapView.SetCenterCoordinate (new CLLocationCoordinate2D (40.7326808, -73.9843407), false);
mapView.SetZoomLevel (11, false);

View.AddSubview (mapView);
```

You can add annotations to your map like this:

```
// Add new annotation
mapView.AddAnnotation (new MGLPointAnnotation {
    Coordinate = new CLLocationCoordinate2D (40.7326808, -73.9843407),
    Title = "Sample Marker",
    Subtitle = "This is the subtitle"
});
```
