using CoreGraphics;
using Foundation;
using MapboxMapsObjC;
using MapboxCoreMaps;
using MapboxMaps;

namespace MapboxMapsObjC
{
	// @interface MapInitOptionsFactory : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC21MapInitOptionsFactory")]
	interface MapInitOptionsFactory
	{
		// +(MapInitOptions * _Nonnull)createWithResourceOptions:(MBMResourceOptions * _Nullable)resourceOptions mapOptions:(MBMMapOptions * _Nullable)mapOptions cameraOptions:(MBMCameraOptions * _Nullable)cameraOptions stylePath:(NSString * _Nullable)stylePath __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithResourceOptions:mapOptions:cameraOptions:stylePath:")]
		MapInitOptions CreateWithResourceOptions ([NullAllowed] MBMResourceOptions resourceOptions, [NullAllowed] MBMMapOptions mapOptions, [NullAllowed] MBMCameraOptions cameraOptions, [NullAllowed] string stylePath);

		// +(MapInitOptions * _Nonnull)createWithResourceOptions:(MBMResourceOptions * _Nullable)resourceOptions mapOptions:(MBMMapOptions * _Nullable)mapOptions cameraOptions:(MBMCameraOptions * _Nullable)cameraOptions styleURI:(NSUrl * _Nullable)styleURI __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithResourceOptions:mapOptions:cameraOptions:styleURI:")]
		MapInitOptions CreateWithResourceOptions ([NullAllowed] MBMResourceOptions resourceOptions, [NullAllowed] MBMMapOptions mapOptions, [NullAllowed] MBMCameraOptions cameraOptions, [NullAllowed] NSUrl styleURI);
	}

	// @interface MapViewFactory : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC13MapboxMapObjC14MapViewFactory")]
	interface MapViewFactory
	{
		// +(MapView * _Nonnull)createWithFrame:(CGRect)frame options:(MapInitOptions * _Nonnull)options __attribute__((warn_unused_result("")));
		[Static]
		[Export ("createWithFrame:options:")]
		MapView CreateWithFrame (CGRect frame, MapInitOptions options);
	}
}
