using System;
using CoreGraphics;
using CoreLocation;
using Foundation;
using Metal;
using MapboxCoreMaps;
using MapboxCommon;
using ObjCRuntime;
using UIKit;

namespace MapboxCoreMaps
{
	// @interface MBMEdgeInsets : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMEdgeInsets
	{
		// -(instancetype _Nonnull)initWithTop:(double)top left:(double)left bottom:(double)bottom right:(double)right;
		[Export ("initWithTop:left:bottom:right:")]
		IntPtr Constructor (double top, double left, double bottom, double right);

		// @property (readonly, nonatomic) double top;
		[Export ("top")]
		double Top { get; }

		// @property (readonly, nonatomic) double left;
		[Export ("left")]
		double Left { get; }

		// @property (readonly, nonatomic) double bottom;
		[Export ("bottom")]
		double Bottom { get; }

		// @property (readonly, nonatomic) double right;
		[Export ("right")]
		double Right { get; }

		// -(BOOL)isEqualToEdgeInsets:(MBMEdgeInsets * _Nonnull)other;
		[Export ("isEqualToEdgeInsets:")]
		bool IsEqualToEdgeInsets (MBMEdgeInsets other);
	}

	// @interface MBMCameraOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMCameraOptions
	{
		// -(instancetype _Nonnull)initWithCenter:(CLLocation * _Nullable)center padding:(MBMEdgeInsets * _Nullable)padding anchor:(MBMScreenCoordinate * _Nullable)anchor zoom:(NSNumber * _Nullable)zoom bearing:(NSNumber * _Nullable)bearing pitch:(NSNumber * _Nullable)pitch __attribute__((swift_private));
		[Export ("initWithCenter:padding:anchor:zoom:bearing:pitch:")]
		IntPtr Constructor ([NullAllowed] CLLocation center, [NullAllowed] MBMEdgeInsets padding, [NullAllowed] MBMScreenCoordinate anchor, [NullAllowed] NSNumber zoom, [NullAllowed] NSNumber bearing, [NullAllowed] NSNumber pitch);

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT CLLocation * center __attribute__((swift_private));
		[Export ("center")]
		CLLocation Center { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT MBMEdgeInsets * padding __attribute__((swift_private));
		[Export ("padding")]
		MBMEdgeInsets Padding { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT MBMScreenCoordinate * anchor __attribute__((swift_private));
		[Export ("anchor")]
		MBMScreenCoordinate Anchor { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * zoom __attribute__((swift_private));
		[Export ("zoom")]
		NSNumber Zoom { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * bearing __attribute__((swift_private));
		[Export ("bearing")]
		NSNumber Bearing { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * pitch __attribute__((swift_private));
		[Export ("pitch")]
		NSNumber Pitch { get; }
	}

	// @interface MBMCameraState : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMCameraState
	{
		// -(instancetype _Nonnull)initWithCenter:(CLLocationCoordinate2D)center padding:(MBMEdgeInsets * _Nonnull)padding zoom:(double)zoom bearing:(double)bearing pitch:(double)pitch;
		[Export ("initWithCenter:padding:zoom:bearing:pitch:")]
		IntPtr Constructor (CLLocationCoordinate2D center, MBMEdgeInsets padding, double zoom, double bearing, double pitch);

		// @property (readonly, nonatomic) CLLocationCoordinate2D center;
		[Export ("center")]
		CLLocationCoordinate2D Center { get; }

		// @property (readonly, nonatomic) MBMEdgeInsets * _Nonnull padding;
		[Export ("padding")]
		MBMEdgeInsets Padding { get; }

		// @property (readonly, nonatomic) double zoom;
		[Export ("zoom")]
		double Zoom { get; }

		// @property (readonly, nonatomic) double bearing;
		[Export ("bearing")]
		double Bearing { get; }

		// @property (readonly, nonatomic) double pitch;
		[Export ("pitch")]
		double Pitch { get; }
	}

	// @interface MBMCameraBoundsOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMCameraBoundsOptions
	{
		// -(instancetype _Nonnull)initWithBounds:(MBMCoordinateBounds * _Nullable)bounds maxZoom:(NSNumber * _Nullable)maxZoom minZoom:(NSNumber * _Nullable)minZoom maxPitch:(NSNumber * _Nullable)maxPitch minPitch:(NSNumber * _Nullable)minPitch __attribute__((swift_private));
		[Export ("initWithBounds:maxZoom:minZoom:maxPitch:minPitch:")]
		IntPtr Constructor ([NullAllowed] MBMCoordinateBounds bounds, [NullAllowed] NSNumber maxZoom, [NullAllowed] NSNumber minZoom, [NullAllowed] NSNumber maxPitch, [NullAllowed] NSNumber minPitch);

		// @property (readonly, nonatomic) MBMCoordinateBounds * _Nullable bounds;
		[NullAllowed, Export ("bounds")]
		MBMCoordinateBounds Bounds { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * maxZoom __attribute__((swift_private));
		[Export ("maxZoom")]
		NSNumber MaxZoom { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * minZoom __attribute__((swift_private));
		[Export ("minZoom")]
		NSNumber MinZoom { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * maxPitch __attribute__((swift_private));
		[Export ("maxPitch")]
		NSNumber MaxPitch { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * minPitch __attribute__((swift_private));
		[Export ("minPitch")]
		NSNumber MinPitch { get; }
	}

	// @interface MBMCameraBounds : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMCameraBounds
	{
		// -(instancetype _Nonnull)initWithBounds:(MBMCoordinateBounds * _Nonnull)bounds maxZoom:(double)maxZoom minZoom:(double)minZoom maxPitch:(double)maxPitch minPitch:(double)minPitch;
		[Export ("initWithBounds:maxZoom:minZoom:maxPitch:minPitch:")]
		IntPtr Constructor (MBMCoordinateBounds bounds, double maxZoom, double minZoom, double maxPitch, double minPitch);

		// @property (readonly, nonatomic) MBMCoordinateBounds * _Nonnull bounds;
		[Export ("bounds")]
		MBMCoordinateBounds Bounds { get; }

		// @property (readonly, nonatomic) double maxZoom;
		[Export ("maxZoom")]
		double MaxZoom { get; }

		// @property (readonly, nonatomic) double minZoom;
		[Export ("minZoom")]
		double MinZoom { get; }

		// @property (readonly, nonatomic) double maxPitch;
		[Export ("maxPitch")]
		double MaxPitch { get; }

		// @property (readonly, nonatomic) double minPitch;
		[Export ("minPitch")]
		double MinPitch { get; }
	}

	// @interface MBMObservable : NSObject
	[BaseType (typeof(NSObject))]
	interface MBMObservable
	{
		// -(void)subscribeForObserver:(id<MBMObserver> _Nonnull)observer events:(NSArray<NSString *> * _Nonnull)events;
		[Export ("subscribeForObserver:events:")]
		void SubscribeForObserver (IMBMObserver observer, string[] events);

		// -(void)unsubscribeForObserver:(id<MBMObserver> _Nonnull)observer events:(NSArray<NSString *> * _Nonnull)events;
		[Export ("unsubscribeForObserver:events:")]
		void UnsubscribeForObserver (IMBMObserver observer, string[] events);

		// -(void)unsubscribeForObserver:(id<MBMObserver> _Nonnull)observer;
		[Export ("unsubscribeForObserver:")]
		void UnsubscribeForObserver (IMBMObserver observer);
	}

	// @interface MBMStyleManager : MBMObservable
	[BaseType (typeof(MBMObservable))]
	interface MBMStyleManager
	{
		// -(NSString * _Nonnull)getStyleURI __attribute__((ns_returns_retained));
		[Export ("getStyleURI")]
		string StyleURI { get; }

		// -(void)setStyleURIForUri:(NSString * _Nonnull)uri;
		[Export ("setStyleURIForUri:")]
		void SetStyleURIForUri (string uri);

		// -(NSString * _Nonnull)getStyleJSON __attribute__((ns_returns_retained));
		[Export ("getStyleJSON")]
		string StyleJSON { get; }

		// -(void)setStyleJSONForJson:(NSString * _Nonnull)json;
		[Export ("setStyleJSONForJson:")]
		void SetStyleJSONForJson (string json);

		// -(MBMCameraOptions * _Nonnull)getStyleDefaultCamera __attribute__((ns_returns_retained));
		[Export ("getStyleDefaultCamera")]
		MBMCameraOptions StyleDefaultCamera { get; }

		// -(MBMTransitionOptions * _Nonnull)getStyleTransition __attribute__((ns_returns_retained));
		[Export ("getStyleTransition")]
		MBMTransitionOptions StyleTransition { get; }

		// -(void)setStyleTransitionForTransitionOptions:(MBMTransitionOptions * _Nonnull)transitionOptions;
		[Export ("setStyleTransitionForTransitionOptions:")]
		void SetStyleTransitionForTransitionOptions (MBMTransitionOptions transitionOptions);

		// -(BOOL)styleLayerExistsForLayerId:(NSString * _Nonnull)layerId;
		[Export ("styleLayerExistsForLayerId:")]
		bool StyleLayerExistsForLayerId (string layerId);

		// -(NSArray<MBMStyleObjectInfo *> * _Nonnull)getStyleLayers __attribute__((ns_returns_retained));
		[Export ("getStyleLayers")]
		MBMStyleObjectInfo[] StyleLayers { get; }

		// -(MBMStylePropertyValue * _Nonnull)getStyleLayerPropertyForLayerId:(NSString * _Nonnull)layerId property:(NSString * _Nonnull)property __attribute__((ns_returns_retained));
		[Export ("getStyleLayerPropertyForLayerId:property:")]
		MBMStylePropertyValue GetStyleLayerPropertyForLayerId (string layerId, string property);

		// +(MBMStylePropertyValue * _Nonnull)getStyleLayerPropertyDefaultValueForLayerType:(NSString * _Nonnull)layerType property:(NSString * _Nonnull)property __attribute__((ns_returns_retained));
		[Static]
		[Export ("getStyleLayerPropertyDefaultValueForLayerType:property:")]
		MBMStylePropertyValue GetStyleLayerPropertyDefaultValueForLayerType (string layerType, string property);

		// -(MBMStylePropertyValue * _Nonnull)getStyleSourcePropertyForSourceId:(NSString * _Nonnull)sourceId property:(NSString * _Nonnull)property __attribute__((ns_returns_retained));
		[Export ("getStyleSourcePropertyForSourceId:property:")]
		MBMStylePropertyValue GetStyleSourcePropertyForSourceId (string sourceId, string property);

		// +(MBMStylePropertyValue * _Nonnull)getStyleSourcePropertyDefaultValueForSourceType:(NSString * _Nonnull)sourceType property:(NSString * _Nonnull)property __attribute__((ns_returns_retained));
		[Static]
		[Export ("getStyleSourcePropertyDefaultValueForSourceType:property:")]
		MBMStylePropertyValue GetStyleSourcePropertyDefaultValueForSourceType (string sourceType, string property);

		// -(BOOL)styleSourceExistsForSourceId:(NSString * _Nonnull)sourceId;
		[Export ("styleSourceExistsForSourceId:")]
		bool StyleSourceExistsForSourceId (string sourceId);

		// -(NSArray<MBMStyleObjectInfo *> * _Nonnull)getStyleSources __attribute__((ns_returns_retained));
		[Export ("getStyleSources")]
        MBMStyleObjectInfo[] GetStyleSources();

		// -(MBMStylePropertyValue * _Nonnull)getStyleLightPropertyForProperty:(NSString * _Nonnull)property __attribute__((ns_returns_retained));
		[Export ("getStyleLightPropertyForProperty:")]
		MBMStylePropertyValue GetStyleLightPropertyForProperty (string property);

		// -(MBMStylePropertyValue * _Nonnull)getStyleTerrainPropertyForProperty:(NSString * _Nonnull)property __attribute__((ns_returns_retained));
		[Export ("getStyleTerrainPropertyForProperty:")]
		MBMStylePropertyValue GetStyleTerrainPropertyForProperty (string property);

		// -(MBMStylePropertyValue * _Nonnull)getStyleProjectionPropertyForProperty:(NSString * _Nonnull)property __attribute__((ns_returns_retained));
		[Export ("getStyleProjectionPropertyForProperty:")]
		MBMStylePropertyValue GetStyleProjectionPropertyForProperty (string property);

		// -(MBMImage * _Nullable)getStyleImageForImageId:(NSString * _Nonnull)imageId __attribute__((ns_returns_retained));
		[Export ("getStyleImageForImageId:")]
		[return: NullAllowed]
		MBMImage GetStyleImageForImageId (string imageId);

		// -(BOOL)hasStyleImageForImageId:(NSString * _Nonnull)imageId;
		[Export ("hasStyleImageForImageId:")]
		bool HasStyleImageForImageId (string imageId);

		// -(BOOL)isStyleLoaded;
		[Export ("isStyleLoaded")]
		bool IsStyleLoaded { get; }
	}

	// @interface MBMCameraManager : MBMStyleManager
	[BaseType (typeof(MBMStyleManager))]
	interface MBMCameraManager
	{
		// -(MBMCameraOptions * _Nonnull)cameraForCoordinateBoundsForBounds:(MBMCoordinateBounds * _Nonnull)bounds padding:(MBMEdgeInsets * _Nonnull)padding bearing:(NSNumber * _Nullable)bearing pitch:(NSNumber * _Nullable)pitch __attribute__((ns_returns_retained));
		[Export ("cameraForCoordinateBoundsForBounds:padding:bearing:pitch:")]
		MBMCameraOptions CameraForCoordinateBoundsForBounds (MBMCoordinateBounds bounds, MBMEdgeInsets padding, [NullAllowed] NSNumber bearing, [NullAllowed] NSNumber pitch);

		// -(MBMCameraOptions * _Nonnull)cameraForCoordinatesForCoordinates:(NSArray<CLLocation *> * _Nonnull)coordinates padding:(MBMEdgeInsets * _Nonnull)padding bearing:(NSNumber * _Nullable)bearing pitch:(NSNumber * _Nullable)pitch __attribute__((ns_returns_retained));
		[Export ("cameraForCoordinatesForCoordinates:padding:bearing:pitch:")]
		MBMCameraOptions CameraForCoordinatesForCoordinates (CLLocation[] coordinates, MBMEdgeInsets padding, [NullAllowed] NSNumber bearing, [NullAllowed] NSNumber pitch);

		// -(MBMCameraOptions * _Nonnull)cameraForCoordinatesForCoordinates:(NSArray<CLLocation *> * _Nonnull)coordinates camera:(MBMCameraOptions * _Nonnull)camera box:(MBMScreenBox * _Nonnull)box __attribute__((ns_returns_retained));
		[Export ("cameraForCoordinatesForCoordinates:camera:box:")]
		MBMCameraOptions CameraForCoordinatesForCoordinates (CLLocation[] coordinates, MBMCameraOptions camera, MBMScreenBox box);

		// -(MBMCameraOptions * _Nonnull)cameraForGeometryForGeometry:(MBXGeometry * _Nonnull)geometry padding:(MBMEdgeInsets * _Nonnull)padding bearing:(NSNumber * _Nullable)bearing pitch:(NSNumber * _Nullable)pitch __attribute__((ns_returns_retained));
		[Export ("cameraForGeometryForGeometry:padding:bearing:pitch:")]
		MBMCameraOptions CameraForGeometryForGeometry (MBXGeometry geometry, MBMEdgeInsets padding, [NullAllowed] NSNumber bearing, [NullAllowed] NSNumber pitch);

		// -(MBMCoordinateBounds * _Nonnull)coordinateBoundsForCameraForCamera:(MBMCameraOptions * _Nonnull)camera __attribute__((ns_returns_retained));
		[Export ("coordinateBoundsForCameraForCamera:")]
		MBMCoordinateBounds CoordinateBoundsForCameraForCamera (MBMCameraOptions camera);

		// -(MBMCoordinateBounds * _Nonnull)coordinateBoundsForCameraUnwrappedForCamera:(MBMCameraOptions * _Nonnull)camera __attribute__((ns_returns_retained));
		[Export ("coordinateBoundsForCameraUnwrappedForCamera:")]
		MBMCoordinateBounds CoordinateBoundsForCameraUnwrappedForCamera (MBMCameraOptions camera);

		// -(MBMCoordinateBoundsZoom * _Nonnull)coordinateBoundsZoomForCameraForCamera:(MBMCameraOptions * _Nonnull)camera __attribute__((ns_returns_retained));
		[Export ("coordinateBoundsZoomForCameraForCamera:")]
		MBMCoordinateBoundsZoom CoordinateBoundsZoomForCameraForCamera (MBMCameraOptions camera);

		// -(MBMCoordinateBoundsZoom * _Nonnull)coordinateBoundsZoomForCameraUnwrappedForCamera:(MBMCameraOptions * _Nonnull)camera __attribute__((ns_returns_retained));
		[Export ("coordinateBoundsZoomForCameraUnwrappedForCamera:")]
		MBMCoordinateBoundsZoom CoordinateBoundsZoomForCameraUnwrappedForCamera (MBMCameraOptions camera);

		// -(MBMScreenCoordinate * _Nonnull)pixelForCoordinateForCoordinate:(CLLocationCoordinate2D)coordinate __attribute__((ns_returns_retained));
		[Export ("pixelForCoordinateForCoordinate:")]
		MBMScreenCoordinate PixelForCoordinateForCoordinate (CLLocationCoordinate2D coordinate);

		// -(CLLocationCoordinate2D)coordinateForPixelForPixel:(MBMScreenCoordinate * _Nonnull)pixel;
		[Export ("coordinateForPixelForPixel:")]
		CLLocationCoordinate2D CoordinateForPixelForPixel (MBMScreenCoordinate pixel);

		// -(NSArray<MBMScreenCoordinate *> * _Nonnull)pixelsForCoordinatesForCoordinates:(NSArray<CLLocation *> * _Nonnull)coordinates __attribute__((ns_returns_retained));
		[Export ("pixelsForCoordinatesForCoordinates:")]
		MBMScreenCoordinate[] PixelsForCoordinatesForCoordinates (CLLocation[] coordinates);

		// -(NSArray<CLLocation *> * _Nonnull)coordinatesForPixelsForPixels:(NSArray<MBMScreenCoordinate *> * _Nonnull)pixels __attribute__((ns_returns_retained));
		[Export ("coordinatesForPixelsForPixels:")]
		CLLocation[] CoordinatesForPixelsForPixels (MBMScreenCoordinate[] pixels);

		// -(void)setCameraForCameraOptions:(MBMCameraOptions * _Nonnull)cameraOptions;
		[Export ("setCameraForCameraOptions:")]
		void SetCameraForCameraOptions (MBMCameraOptions cameraOptions);

		// -(MBMCameraState * _Nonnull)getCameraState __attribute__((ns_returns_retained));
		[Export ("getCameraState")]
        MBMCameraState GetCameraState();

		// -(void)setCameraForFreeCameraOptions:(MBMFreeCameraOptions * _Nonnull)freeCameraOptions;
		[Export ("setCameraForFreeCameraOptions:")]
		void SetCameraForFreeCameraOptions (MBMFreeCameraOptions freeCameraOptions);

		// -(MBMFreeCameraOptions * _Nonnull)getFreeCameraOptions __attribute__((ns_returns_retained));
		[Export ("getFreeCameraOptions")]
        MBMFreeCameraOptions GetFreeCameraOptions();

		// -(MBMCameraBounds * _Nonnull)getBounds __attribute__((ns_returns_retained));
		[Export ("getBounds")]
        MBMCameraBounds GetBounds();

		// -(void)dragStartForPoint:(MBMScreenCoordinate * _Nonnull)point;
		[Export ("dragStartForPoint:")]
		void DragStartForPoint (MBMScreenCoordinate point);

		// -(MBMCameraOptions * _Nonnull)getDragCameraOptionsForFromPoint:(MBMScreenCoordinate * _Nonnull)fromPoint toPoint:(MBMScreenCoordinate * _Nonnull)toPoint __attribute__((ns_returns_retained));
		[Export ("getDragCameraOptionsForFromPoint:toPoint:")]
		MBMCameraOptions GetDragCameraOptionsForFromPoint (MBMScreenCoordinate fromPoint, MBMScreenCoordinate toPoint);

		// -(void)dragEnd;
		[Export ("dragEnd")]
		void DragEnd ();
	}

	// @interface MBMCoordinateBounds : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMCoordinateBounds
	{
		// -(instancetype _Nonnull)initWithSouthwest:(CLLocationCoordinate2D)southwest northeast:(CLLocationCoordinate2D)northeast;
		[Export ("initWithSouthwest:northeast:")]
		IntPtr Constructor (CLLocationCoordinate2D southwest, CLLocationCoordinate2D northeast);

		// -(instancetype _Nonnull)initWithSouthwest:(CLLocationCoordinate2D)southwest northeast:(CLLocationCoordinate2D)northeast infiniteBounds:(BOOL)infiniteBounds;
		[Export ("initWithSouthwest:northeast:infiniteBounds:")]
		IntPtr Constructor (CLLocationCoordinate2D southwest, CLLocationCoordinate2D northeast, bool infiniteBounds);

		// +(MBMCoordinateBounds * _Nonnull)world __attribute__((ns_returns_retained)) __attribute__((swift_private));
		[Static]
		[Export ("world")]
		MBMCoordinateBounds World { get; }

		// +(MBMCoordinateBounds * _Nonnull)singletonForPoint:(CLLocationCoordinate2D)point __attribute__((ns_returns_retained)) __attribute__((swift_private));
		[Static]
		[Export ("singletonForPoint:")]
		MBMCoordinateBounds SingletonForPoint (CLLocationCoordinate2D point);

		// +(MBMCoordinateBounds * _Nonnull)hullForA:(CLLocationCoordinate2D)a b:(CLLocationCoordinate2D)b __attribute__((ns_returns_retained)) __attribute__((swift_private));
		[Static]
		[Export ("hullForA:b:")]
		MBMCoordinateBounds HullForA (CLLocationCoordinate2D a, CLLocationCoordinate2D b);

		// -(BOOL)isValid __attribute__((swift_private));
		[Export ("isValid")]
		bool IsValid { get; }

		// -(double)south __attribute__((swift_private));
		[Export ("south")]
		double South { get; }

		// -(double)west __attribute__((swift_private));
		[Export ("west")]
		double West { get; }

		// -(double)north __attribute__((swift_private));
		[Export ("north")]
		double North { get; }

		// -(double)east __attribute__((swift_private));
		[Export ("east")]
		double East { get; }

		// -(CLLocationCoordinate2D)southeast __attribute__((swift_private));
		[Export ("southeast")]
		CLLocationCoordinate2D Southeast { get; }

		// -(CLLocationCoordinate2D)northwest __attribute__((swift_private));
		[Export ("northwest")]
		CLLocationCoordinate2D Northwest { get; }

		// -(CLLocationCoordinate2D)center __attribute__((swift_private));
		[Export ("center")]
		CLLocationCoordinate2D Center { get; }

		// -(CLLocationCoordinate2D)constrainForPoint:(CLLocationCoordinate2D)point;
		[Export ("constrainForPoint:")]
		CLLocationCoordinate2D ConstrainForPoint (CLLocationCoordinate2D point);

		// -(BOOL)isEmpty __attribute__((swift_private));
		[Export ("isEmpty")]
		bool IsEmpty { get; }

		// -(BOOL)isBounded __attribute__((swift_private));
		[Export ("isBounded")]
		bool IsBounded { get; }

		// -(BOOL)crossesAntimeridian __attribute__((swift_private));
		[Export ("crossesAntimeridian")]
		bool CrossesAntimeridian { get; }

		// -(BOOL)containsForPoint:(CLLocationCoordinate2D)point wrappedCoordinates:(BOOL)wrappedCoordinates;
		[Export ("containsForPoint:wrappedCoordinates:")]
		bool ContainsForPoint (CLLocationCoordinate2D point, bool wrappedCoordinates);

		// -(BOOL)containsForArea:(MBMCoordinateBounds * _Nonnull)area wrappedCoordinates:(BOOL)wrappedCoordinates;
		[Export ("containsForArea:wrappedCoordinates:")]
		bool ContainsForArea (MBMCoordinateBounds area, bool wrappedCoordinates);

		// -(BOOL)containsLatitudeForLatitude:(double)latitude;
		[Export ("containsLatitudeForLatitude:")]
		bool ContainsLatitudeForLatitude (double latitude);

		// -(BOOL)containsLongitudeForLongitude:(double)longitude;
		[Export ("containsLongitudeForLongitude:")]
		bool ContainsLongitudeForLongitude (double longitude);

		// -(double)latitudeSpan __attribute__((swift_private));
		[Export ("latitudeSpan")]
		double LatitudeSpan { get; }

		// -(double)longitudeSpan __attribute__((swift_private));
		[Export ("longitudeSpan")]
		double LongitudeSpan { get; }

		// -(BOOL)intersectsForArea:(MBMCoordinateBounds * _Nonnull)area wrappedCoordinates:(BOOL)wrappedCoordinates;
		[Export ("intersectsForArea:wrappedCoordinates:")]
		bool IntersectsForArea (MBMCoordinateBounds area, bool wrappedCoordinates);

		// -(MBMCoordinateBounds * _Nonnull)extendForPoint:(CLLocationCoordinate2D)point __attribute__((ns_returns_retained));
		[Export ("extendForPoint:")]
		MBMCoordinateBounds ExtendForPoint (CLLocationCoordinate2D point);

		// -(MBMCoordinateBounds * _Nonnull)extendForArea:(MBMCoordinateBounds * _Nonnull)area __attribute__((ns_returns_retained));
		[Export ("extendForArea:")]
		MBMCoordinateBounds ExtendForArea (MBMCoordinateBounds area);

		// @property (readonly, nonatomic) CLLocationCoordinate2D southwest;
		[Export ("southwest")]
		CLLocationCoordinate2D Southwest { get; }

		// @property (readonly, nonatomic) CLLocationCoordinate2D northeast;
		[Export ("northeast")]
		CLLocationCoordinate2D Northeast { get; }

		// @property (readonly, getter = isInfiniteBounds, nonatomic) BOOL infiniteBounds;
		[Export ("infiniteBounds")]
		bool InfiniteBounds { [Bind ("isInfiniteBounds")] get; }
	}

	// @interface MBMFreeCameraOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMFreeCameraOptions
	{
		// -(MBMVec3 * _Nullable)getPosition __attribute__((ns_returns_retained));
		[NullAllowed, Export ("getPosition")]
        MBMVec3 GetPosition();

		// -(void)setPositionForPosition:(MBMVec3 * _Nullable)position;
		[Export ("setPositionForPosition:")]
		void SetPositionForPosition ([NullAllowed] MBMVec3 position);

		// -(MBMVec4 * _Nullable)getOrientation __attribute__((ns_returns_retained));
		[NullAllowed, Export ("getOrientation")]
        MBMVec4 GetOrientation();

		// -(void)setOrientationForOrientation:(MBMVec4 * _Nullable)orientation;
		[Export ("setOrientationForOrientation:")]
		void SetOrientationForOrientation ([NullAllowed] MBMVec4 orientation);

		// -(void)setLocationForLocation:(CLLocationCoordinate2D)location altitude:(double)altitude;
		[Export ("setLocationForLocation:altitude:")]
		void SetLocationForLocation (CLLocationCoordinate2D location, double altitude);

		// -(void)lookAtPointForLocation:(CLLocationCoordinate2D)location;
		[Export ("lookAtPointForLocation:")]
		void LookAtPointForLocation (CLLocationCoordinate2D location);

		// -(void)lookAtPointForLocation:(CLLocationCoordinate2D)location altitude:(double)altitude;
		[Export ("lookAtPointForLocation:altitude:")]
		void LookAtPointForLocation (CLLocationCoordinate2D location, double altitude);

		// -(void)lookAtPointForLocation:(CLLocationCoordinate2D)location altitude:(double)altitude upVector:(MBMVec3 * _Nonnull)upVector;
		[Export ("lookAtPointForLocation:altitude:upVector:")]
		void LookAtPointForLocation (CLLocationCoordinate2D location, double altitude, MBMVec3 upVector);

		// -(void)setPitchBearingForPitch:(double)pitch bearing:(double)bearing;
		[Export ("setPitchBearingForPitch:bearing:")]
		void SetPitchBearingForPitch (double pitch, double bearing);
	}

	// @interface MBMImage : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMImage
	{
		// -(instancetype _Nonnull)initWithWidth:(uint32_t)width height:(uint32_t)height data:(NSData * _Nonnull)data;
		[Export ("initWithWidth:height:data:")]
		IntPtr Constructor (uint width, uint height, NSData data);

		// @property (readonly, nonatomic) uint32_t width;
		[Export ("width")]
		uint Width { get; }

		// @property (readonly, nonatomic) uint32_t height;
		[Export ("height")]
		uint Height { get; }

		// @property (readonly, nonatomic) NSData * _Nonnull data;
		[Export ("data")]
		NSData Data { get; }
	}

	// @interface Additions (MBMImage)
	[Category]
	[BaseType (typeof(MBMImage))]
	interface MBMImage_Additions
	{
		// +(instancetype _Nullable)imageWithUIImage:(UIImage * _Nonnull)uiImage;
		[Static]
		[Export ("imageWithUIImage:")]
		[return: NullAllowed]
		MBMImage ImageWithUIImage (UIImage uiImage);

		// -(CGImageRef _Nonnull)cgImage;
		[Static]
		[Export ("cgImage")]
        CGImage GetCgImage();
	}

	// @interface MBMGlyphsRasterizationOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMGlyphsRasterizationOptions
	{
		// -(instancetype _Nonnull)initWithRasterizationMode:(MBMGlyphsRasterizationMode)rasterizationMode fontFamily:(NSString * _Nullable)fontFamily;
		[Export ("initWithRasterizationMode:fontFamily:")]
		IntPtr Constructor (MBMGlyphsRasterizationMode rasterizationMode, [NullAllowed] string fontFamily);

		// @property (readonly, nonatomic) MBMGlyphsRasterizationMode rasterizationMode;
		[Export ("rasterizationMode")]
		MBMGlyphsRasterizationMode RasterizationMode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable fontFamily;
		[NullAllowed, Export ("fontFamily")]
		string FontFamily { get; }
	}

	// @interface MBMMapMemoryBudgetInMegabytes : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMMapMemoryBudgetInMegabytes
	{
		// -(instancetype _Nonnull)initWithSize:(uint64_t)size;
		[Export ("initWithSize:")]
		IntPtr Constructor (ulong size);

		// @property (readonly, nonatomic) uint64_t size;
		[Export ("size")]
		ulong Size { get; }

		// -(BOOL)isEqualToMapMemoryBudgetInMegabytes:(MBMMapMemoryBudgetInMegabytes * _Nonnull)other;
		[Export ("isEqualToMapMemoryBudgetInMegabytes:")]
		bool IsEqualToMapMemoryBudgetInMegabytes (MBMMapMemoryBudgetInMegabytes other);
	}

	// @interface MBMMapMemoryBudgetInTiles : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMMapMemoryBudgetInTiles
	{
		// -(instancetype _Nonnull)initWithSize:(uint64_t)size;
		[Export ("initWithSize:")]
		IntPtr Constructor (ulong size);

		// @property (readonly, nonatomic) uint64_t size;
		[Export ("size")]
		ulong Size { get; }

		// -(BOOL)isEqualToMapMemoryBudgetInTiles:(MBMMapMemoryBudgetInTiles * _Nonnull)other;
		[Export ("isEqualToMapMemoryBudgetInTiles:")]
		bool IsEqualToMapMemoryBudgetInTiles (MBMMapMemoryBudgetInTiles other);
	}

	// @interface MBMMapOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMMapOptions
	{
		// -(instancetype _Nonnull)initWithContextMode:(NSNumber * _Nullable)contextMode constrainMode:(NSNumber * _Nullable)constrainMode viewportMode:(NSNumber * _Nullable)viewportMode orientation:(NSNumber * _Nullable)orientation crossSourceCollisions:(NSNumber * _Nullable)crossSourceCollisions optimizeForTerrain:(NSNumber * _Nullable)optimizeForTerrain size:(MBMSize * _Nullable)size glyphsRasterizationOptions:(MBMGlyphsRasterizationOptions * _Nullable)glyphsRasterizationOptions __attribute__((swift_private));
		[Export ("initWithContextMode:constrainMode:viewportMode:orientation:crossSourceCollisions:optimizeForTerrain:size:glyphsRasterizationOptions:")]
		IntPtr Constructor ([NullAllowed] NSNumber contextMode, [NullAllowed] NSNumber constrainMode, [NullAllowed] NSNumber viewportMode, [NullAllowed] NSNumber orientation, [NullAllowed] NSNumber crossSourceCollisions, [NullAllowed] NSNumber optimizeForTerrain, [NullAllowed] MBMSize size, [NullAllowed] MBMGlyphsRasterizationOptions glyphsRasterizationOptions);

		// -(instancetype _Nonnull)initWithContextMode:(NSNumber * _Nullable)contextMode constrainMode:(NSNumber * _Nullable)constrainMode viewportMode:(NSNumber * _Nullable)viewportMode orientation:(NSNumber * _Nullable)orientation crossSourceCollisions:(NSNumber * _Nullable)crossSourceCollisions optimizeForTerrain:(NSNumber * _Nullable)optimizeForTerrain size:(MBMSize * _Nullable)size pixelRatio:(float)pixelRatio glyphsRasterizationOptions:(MBMGlyphsRasterizationOptions * _Nullable)glyphsRasterizationOptions __attribute__((swift_private));
		[Export ("initWithContextMode:constrainMode:viewportMode:orientation:crossSourceCollisions:optimizeForTerrain:size:pixelRatio:glyphsRasterizationOptions:")]
		IntPtr Constructor ([NullAllowed] NSNumber contextMode, [NullAllowed] NSNumber constrainMode, [NullAllowed] NSNumber viewportMode, [NullAllowed] NSNumber orientation, [NullAllowed] NSNumber crossSourceCollisions, [NullAllowed] NSNumber optimizeForTerrain, [NullAllowed] MBMSize size, float pixelRatio, [NullAllowed] MBMGlyphsRasterizationOptions glyphsRasterizationOptions);

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * contextMode __attribute__((swift_private));
		[Export ("contextMode")]
		NSNumber ContextMode { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * constrainMode __attribute__((swift_private));
		[Export ("constrainMode")]
		NSNumber ConstrainMode { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * viewportMode __attribute__((swift_private));
		[Export ("viewportMode")]
		NSNumber ViewportMode { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * orientation __attribute__((swift_private));
		[Export ("orientation")]
		NSNumber Orientation { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * crossSourceCollisions __attribute__((swift_private));
		[Export ("crossSourceCollisions")]
		NSNumber CrossSourceCollisions { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * optimizeForTerrain __attribute__((swift_private));
		[Export ("optimizeForTerrain")]
		NSNumber OptimizeForTerrain { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT MBMSize * size __attribute__((swift_private));
		[Export ("size")]
		MBMSize Size { get; }

		// @property (readonly, nonatomic) float pixelRatio;
		[Export ("pixelRatio")]
		float PixelRatio { get; }

		// @property (readonly, nonatomic) MBMGlyphsRasterizationOptions * _Nullable glyphsRasterizationOptions;
		[NullAllowed, Export ("glyphsRasterizationOptions")]
		MBMGlyphsRasterizationOptions GlyphsRasterizationOptions { get; }
	}

	// @interface MBMScreenCoordinate : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMScreenCoordinate
	{
		// -(instancetype _Nonnull)initWithX:(double)x y:(double)y;
		[Export ("initWithX:y:")]
		IntPtr Constructor (double x, double y);

		// @property (readonly, nonatomic) double x;
		[Export ("x")]
		double X { get; }

		// @property (readonly, nonatomic) double y;
		[Export ("y")]
		double Y { get; }

		// -(BOOL)isEqualToScreenCoordinate:(MBMScreenCoordinate * _Nonnull)other;
		[Export ("isEqualToScreenCoordinate:")]
		bool IsEqualToScreenCoordinate (MBMScreenCoordinate other);
	}

	// @interface MBMScreenBox : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMScreenBox
	{
		// -(instancetype _Nonnull)initWithMin:(MBMScreenCoordinate * _Nonnull)min max:(MBMScreenCoordinate * _Nonnull)max;
		[Export ("initWithMin:max:")]
		IntPtr Constructor (MBMScreenCoordinate min, MBMScreenCoordinate max);

		// @property (readonly, nonatomic) MBMScreenCoordinate * _Nonnull min;
		[Export ("min")]
		MBMScreenCoordinate Min { get; }

		// @property (readonly, nonatomic) MBMScreenCoordinate * _Nonnull max;
		[Export ("max")]
		MBMScreenCoordinate Max { get; }

		// -(BOOL)isEqualToScreenBox:(MBMScreenBox * _Nonnull)other;
		[Export ("isEqualToScreenBox:")]
		bool IsEqualToScreenBox (MBMScreenBox other);
	}

	// @interface MBMCoordinateBoundsZoom : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMCoordinateBoundsZoom
	{
		// -(instancetype _Nonnull)initWithBounds:(MBMCoordinateBounds * _Nonnull)bounds zoom:(double)zoom;
		[Export ("initWithBounds:zoom:")]
		IntPtr Constructor (MBMCoordinateBounds bounds, double zoom);

		// @property (readonly, nonatomic) MBMCoordinateBounds * _Nonnull bounds;
		[Export ("bounds")]
		MBMCoordinateBounds Bounds { get; }

		// @property (readonly, nonatomic) double zoom;
		[Export ("zoom")]
		double Zoom { get; }
	}

	// @interface MBMSize : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMSize
	{
		// -(instancetype _Nonnull)initWithWidth:(float)width height:(float)height;
		[Export ("initWithWidth:height:")]
		IntPtr Constructor (float width, float height);

		// @property (readonly, nonatomic) float width;
		[Export ("width")]
		float Width { get; }

		// @property (readonly, nonatomic) float height;
		[Export ("height")]
		float Height { get; }

		// -(BOOL)isEqualToSize:(MBMSize * _Nonnull)other;
		[Export ("isEqualToSize:")]
		bool IsEqualToSize (MBMSize other);
	}

	// @interface MBMRenderedQueryOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMRenderedQueryOptions
	{
		// -(instancetype _Nonnull)initWithLayerIds:(NSArray<NSString *> * _Nullable)layerIds filter:(id _Nullable)filter __attribute__((swift_private));
		[Export ("initWithLayerIds:filter:")]
		IntPtr Constructor ([NullAllowed] string[] layerIds, [NullAllowed] NSObject filter);

		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable layerIds;
		[NullAllowed, Export ("layerIds", ArgumentSemantic.Copy)]
		string[] LayerIds { get; }

		// @property (readonly, copy, nonatomic) NS_REFINED_FOR_SWIFT id filter __attribute__((swift_private));
		[Export ("filter", ArgumentSemantic.Copy)]
		NSObject Filter { get; }
	}

	// @interface MBMSourceQueryOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMSourceQueryOptions
	{
		// -(instancetype _Nonnull)initWithSourceLayerIds:(NSArray<NSString *> * _Nullable)sourceLayerIds filter:(id _Nonnull)filter;
		[Export ("initWithSourceLayerIds:filter:")]
		IntPtr Constructor ([NullAllowed] string[] sourceLayerIds, NSObject filter);

		// @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nullable sourceLayerIds;
		[NullAllowed, Export ("sourceLayerIds", ArgumentSemantic.Copy)]
		string[] SourceLayerIds { get; }

		// @property (readonly, copy, nonatomic) id _Nonnull filter;
		[Export ("filter", ArgumentSemantic.Copy)]
		NSObject Filter { get; }
	}

	// @interface MBMFeatureExtensionValue : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMFeatureExtensionValue
	{
		// -(instancetype _Nonnull)initWithValue:(id _Nullable)value featureCollection:(NSArray<MBXFeature *> * _Nullable)featureCollection __attribute__((swift_private));
		[Export ("initWithValue:featureCollection:")]
		IntPtr Constructor ([NullAllowed] NSObject value, [NullAllowed] MBXFeature[] featureCollection);

		// @property (readonly, copy, nonatomic) id _Nullable value;
		[NullAllowed, Export ("value", ArgumentSemantic.Copy)]
		NSObject Value { get; }

		// @property (readonly, copy, nonatomic) NS_REFINED_FOR_SWIFT NSArray<MBXFeature *> * featureCollection __attribute__((swift_private));
		[Export ("featureCollection", ArgumentSemantic.Copy)]
		MBXFeature[] FeatureCollection { get; }
	}

	// @interface MBMLayerPosition : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMLayerPosition
	{
		// -(instancetype _Nonnull)initWithAbove:(NSString * _Nullable)above below:(NSString * _Nullable)below at:(NSNumber * _Nullable)at __attribute__((swift_private));
		[Export ("initWithAbove:below:at:")]
		IntPtr Constructor ([NullAllowed] string above, [NullAllowed] string below, [NullAllowed] NSNumber at);

		// @property (readonly, copy, nonatomic) NSString * _Nullable above;
		[NullAllowed, Export ("above")]
		string Above { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable below;
		[NullAllowed, Export ("below")]
		string Below { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * at __attribute__((swift_private));
		[Export ("at")]
		NSNumber At { get; }
	}

	// @interface MBMQueriedFeature : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMQueriedFeature
	{
		// -(instancetype _Nonnull)initWithFeature:(MBXFeature * _Nonnull)feature source:(NSString * _Nonnull)source sourceLayer:(NSString * _Nullable)sourceLayer state:(id _Nonnull)state __attribute__((swift_private));
		[Export ("initWithFeature:source:sourceLayer:state:")]
		IntPtr Constructor (MBXFeature feature, string source, [NullAllowed] string sourceLayer, NSObject state);

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT MBXFeature * feature __attribute__((swift_private));
		[Export ("feature")]
		MBXFeature Feature { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull source;
		[Export ("source")]
		string Source { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sourceLayer;
		[NullAllowed, Export ("sourceLayer")]
		string SourceLayer { get; }

		// @property (readonly, copy, nonatomic) id _Nonnull state;
		[Export ("state", ArgumentSemantic.Copy)]
		NSObject State { get; }
	}

	// @interface MBMRenderCacheOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMRenderCacheOptions
	{
		// -(instancetype _Nonnull)initWithSize:(NSNumber * _Nullable)size __attribute__((swift_private));
		[Export ("initWithSize:")]
		IntPtr Constructor ([NullAllowed] NSNumber size);

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * size __attribute__((swift_private));
		[Export ("size")]
		NSNumber Size { get; }
	}

	// @interface MBMViewAnnotationOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMViewAnnotationOptions
	{
		// -(instancetype _Nonnull)initWithGeometry:(MBXGeometry * _Nullable)geometry associatedFeatureId:(NSString * _Nullable)associatedFeatureId width:(NSNumber * _Nullable)width height:(NSNumber * _Nullable)height allowOverlap:(NSNumber * _Nullable)allowOverlap visible:(NSNumber * _Nullable)visible anchor:(NSNumber * _Nullable)anchor offsetX:(NSNumber * _Nullable)offsetX offsetY:(NSNumber * _Nullable)offsetY selected:(NSNumber * _Nullable)selected __attribute__((swift_private));
		[Export ("initWithGeometry:associatedFeatureId:width:height:allowOverlap:visible:anchor:offsetX:offsetY:selected:")]
		IntPtr Constructor ([NullAllowed] MBXGeometry geometry, [NullAllowed] string associatedFeatureId, [NullAllowed] NSNumber width, [NullAllowed] NSNumber height, [NullAllowed] NSNumber allowOverlap, [NullAllowed] NSNumber visible, [NullAllowed] NSNumber anchor, [NullAllowed] NSNumber offsetX, [NullAllowed] NSNumber offsetY, [NullAllowed] NSNumber selected);

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT MBXGeometry * geometry __attribute__((swift_private));
		[Export ("geometry")]
		MBXGeometry Geometry { get; }

		// @property (readonly, copy, nonatomic) NS_REFINED_FOR_SWIFT NSString * associatedFeatureId __attribute__((swift_private));
		[Export ("associatedFeatureId")]
		string AssociatedFeatureId { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * width __attribute__((swift_private));
		[Export ("width")]
		NSNumber Width { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * height __attribute__((swift_private));
		[Export ("height")]
		NSNumber Height { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * allowOverlap __attribute__((swift_private));
		[Export ("allowOverlap")]
		NSNumber AllowOverlap { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * visible __attribute__((swift_private));
		[Export ("visible")]
		NSNumber Visible { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * anchor __attribute__((swift_private));
		[Export ("anchor")]
		NSNumber Anchor { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * offsetX __attribute__((swift_private));
		[Export ("offsetX")]
		NSNumber OffsetX { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * offsetY __attribute__((swift_private));
		[Export ("offsetY")]
		NSNumber OffsetY { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * selected __attribute__((swift_private));
		[Export ("selected")]
		NSNumber Selected { get; }
	}

	// @interface MBMMap : MBMCameraManager
	[BaseType (typeof(MBMCameraManager))]
	[DisableDefaultCtor]
	interface MBMMap
	{
		// -(void)createRenderer;
		[Export ("createRenderer")]
		void CreateRenderer ();

		// -(void)destroyRenderer;
		[Export ("destroyRenderer")]
		void DestroyRenderer ();

		// -(void)render;
		[Export ("render")]
		void Render ();

		// -(void)setSizeForSize:(MBMSize * _Nonnull)size;
		[Export ("setSizeForSize:")]
		void SetSizeForSize (MBMSize size);

		// -(MBMSize * _Nonnull)getSize __attribute__((ns_returns_retained));
		[Export ("getSize")]
        MBMSize GetSize();

		// -(void)triggerRepaint;
		[Export ("triggerRepaint")]
		void TriggerRepaint ();

		// -(void)setGestureInProgressForInProgress:(BOOL)inProgress;
		[Export ("setGestureInProgressForInProgress:")]
		void SetGestureInProgressForInProgress (bool inProgress);

		// -(BOOL)isGestureInProgress;
		[Export ("isGestureInProgress")]
		bool IsGestureInProgress { get; }

		// -(void)setUserAnimationInProgressForInProgress:(BOOL)inProgress;
		[Export ("setUserAnimationInProgressForInProgress:")]
		void SetUserAnimationInProgressForInProgress (bool inProgress);

		// -(BOOL)isUserAnimationInProgress;
		[Export ("isUserAnimationInProgress")]
		bool IsUserAnimationInProgress { get; }

		// -(void)setPrefetchZoomDeltaForDelta:(uint8_t)delta;
		[Export ("setPrefetchZoomDeltaForDelta:")]
		void SetPrefetchZoomDeltaForDelta (byte delta);

		// -(uint8_t)getPrefetchZoomDelta;
		[Export ("getPrefetchZoomDelta")]
        byte GetPrefetchZoomDelta();

		// -(void)setNorthOrientationForOrientation:(MBMNorthOrientation)orientation;
		[Export ("setNorthOrientationForOrientation:")]
		void SetNorthOrientationForOrientation (MBMNorthOrientation orientation);

		// -(void)setConstrainModeForMode:(MBMConstrainMode)mode;
		[Export ("setConstrainModeForMode:")]
		void SetConstrainModeForMode (MBMConstrainMode mode);

		// -(void)setViewportModeForMode:(MBMViewportMode)mode;
		[Export ("setViewportModeForMode:")]
		void SetViewportModeForMode (MBMViewportMode mode);

		// -(MBMMapOptions * _Nonnull)getMapOptions __attribute__((ns_returns_retained));
		[Export ("getMapOptions")]
        MBMMapOptions GetMapOptions();

		// -(NSArray<NSNumber *> * _Nonnull)getDebug __attribute__((ns_returns_retained));
		[Export ("getDebug")]
        NSNumber[] GetDebug();

		// -(void)setDebugForDebugOptions:(NSArray<NSNumber *> * _Nonnull)debugOptions value:(BOOL)value;
		[Export ("setDebugForDebugOptions:value:")]
		void SetDebugForDebugOptions (NSNumber[] debugOptions, bool value);

		// -(BOOL)isMapLoaded;
		[Export ("isMapLoaded")]
		bool IsMapLoaded { get; }

		// -(void)setFeatureStateForSourceId:(NSString * _Nonnull)sourceId sourceLayerId:(NSString * _Nullable)sourceLayerId featureId:(NSString * _Nonnull)featureId state:(id _Nonnull)state;
		[Export ("setFeatureStateForSourceId:sourceLayerId:featureId:state:")]
		void SetFeatureStateForSourceId (string sourceId, [NullAllowed] string sourceLayerId, string featureId, NSObject state);

		// -(void)removeFeatureStateForSourceId:(NSString * _Nonnull)sourceId sourceLayerId:(NSString * _Nullable)sourceLayerId featureId:(NSString * _Nonnull)featureId stateKey:(NSString * _Nullable)stateKey;
		[Export ("removeFeatureStateForSourceId:sourceLayerId:featureId:stateKey:")]
		void RemoveFeatureStateForSourceId (string sourceId, [NullAllowed] string sourceLayerId, string featureId, [NullAllowed] string stateKey);

		// -(void)reduceMemoryUse;
		[Export ("reduceMemoryUse")]
		void ReduceMemoryUse ();

		// -(MBMResourceOptions * _Nonnull)getResourceOptions __attribute__((ns_returns_retained));
		[Export ("getResourceOptions")]
        MBMResourceOptions GetResourceOptions();

		// -(NSNumber * _Nullable)getElevationForCoordinate:(CLLocationCoordinate2D)coordinate __attribute__((ns_returns_retained));
		[Export ("getElevationForCoordinate:")]
		[return: NullAllowed]
		NSNumber GetElevationForCoordinate (CLLocationCoordinate2D coordinate);

		// -(void)setRenderCacheOptionsForOptions:(MBMRenderCacheOptions * _Nonnull)options;
		[Export ("setRenderCacheOptionsForOptions:")]
		void SetRenderCacheOptionsForOptions (MBMRenderCacheOptions options);

		// -(MBMRenderCacheOptions * _Nonnull)getRenderCacheOptions __attribute__((ns_returns_retained));
		[Export ("getRenderCacheOptions")]
        MBMRenderCacheOptions GetRenderCacheOptions();
	}

	// @interface MBMMapMemoryBudget : NSObject
	[BaseType (typeof(NSObject))]
	interface MBMMapMemoryBudget
	{
		// -(instancetype _Nonnull)initWithValue:(id _Nonnull)value;
		[Export ("initWithValue:")]
		IntPtr Constructor (NSObject value);

		// +(instancetype _Nonnull)fromMapMemoryBudgetInMegabytes:(MBMMapMemoryBudgetInMegabytes * _Nonnull)value;
		[Static]
		[Export ("fromMapMemoryBudgetInMegabytes:")]
		MBMMapMemoryBudget FromMapMemoryBudgetInMegabytes (MBMMapMemoryBudgetInMegabytes value);

		// +(instancetype _Nonnull)fromMapMemoryBudgetInTiles:(MBMMapMemoryBudgetInTiles * _Nonnull)value;
		[Static]
		[Export ("fromMapMemoryBudgetInTiles:")]
		MBMMapMemoryBudget FromMapMemoryBudgetInTiles (MBMMapMemoryBudgetInTiles value);

		// -(BOOL)isMapMemoryBudgetInMegabytes;
		[Export ("isMapMemoryBudgetInMegabytes")]
		bool IsMapMemoryBudgetInMegabytes { get; }

		// -(BOOL)isMapMemoryBudgetInTiles;
		[Export ("isMapMemoryBudgetInTiles")]
		bool IsMapMemoryBudgetInTiles { get; }

		// -(MBMMapMemoryBudgetInMegabytes * _Nonnull)getMapMemoryBudgetInMegabytes __attribute__((ns_returns_retained));
		[Export ("getMapMemoryBudgetInMegabytes")]
        MBMMapMemoryBudgetInMegabytes GetMapMemoryBudgetInMegabytes();

		// -(MBMMapMemoryBudgetInTiles * _Nonnull)getMapMemoryBudgetInTiles __attribute__((ns_returns_retained));
		[Export ("getMapMemoryBudgetInTiles")]
        MBMMapMemoryBudgetInTiles GetMapMemoryBudgetInTiles();

		// @property (nonatomic) id _Nonnull value;
		[Export ("value", ArgumentSemantic.Assign)]
		NSObject Value { get; set; }

		// @property (readonly, nonatomic) MBMMapMemoryBudgetType type;
		[Export ("type")]
		MBMMapMemoryBudgetType Type { get; }
	}

	// @interface MBMRenderedQueryGeometry : NSObject
	[BaseType (typeof(NSObject))]
	interface MBMRenderedQueryGeometry
	{
		// -(instancetype _Nonnull)initWithValue:(id _Nonnull)value;
		[Export ("initWithValue:")]
		IntPtr Constructor (NSObject value);

		// +(instancetype _Nonnull)fromScreenBox:(MBMScreenBox * _Nonnull)value;
		[Static]
		[Export ("fromScreenBox:")]
		MBMRenderedQueryGeometry FromScreenBox (MBMScreenBox value);

		// +(instancetype _Nonnull)fromScreenCoordinate:(MBMScreenCoordinate * _Nonnull)value;
		[Static]
		[Export ("fromScreenCoordinate:")]
		MBMRenderedQueryGeometry FromScreenCoordinate (MBMScreenCoordinate value);

		// +(instancetype _Nonnull)fromNSArray:(NSArray<MBMScreenCoordinate *> * _Nonnull)value;
		[Static]
		[Export ("fromNSArray:")]
		MBMRenderedQueryGeometry FromNSArray (NSArray value);

		// -(BOOL)isScreenBox;
		[Export ("isScreenBox")]
		bool IsScreenBox { get; }

		// -(BOOL)isScreenCoordinate;
		[Export ("isScreenCoordinate")]
		bool IsScreenCoordinate { get; }

		// -(BOOL)isNSArray;
		[Export ("isNSArray")]
		bool IsNSArray { get; }

		// -(MBMScreenBox * _Nonnull)getScreenBox __attribute__((ns_returns_retained));
		[Export ("getScreenBox")]
		MBMScreenBox ScreenBox { get; }

		// -(MBMScreenCoordinate * _Nonnull)getScreenCoordinate __attribute__((ns_returns_retained));
		[Export ("getScreenCoordinate")]
		MBMScreenCoordinate ScreenCoordinate { get; }

		// -(NSArray<MBMScreenCoordinate *> * _Nonnull)getNSArray __attribute__((ns_returns_retained));
		[Export ("getNSArray")]
		MBMScreenCoordinate[] NSArray { get; }

		// @property (nonatomic) id _Nonnull value;
		[Export ("value", ArgumentSemantic.Assign)]
		NSObject Value { get; set; }

		// @property (readonly, nonatomic) MBMRenderedQueryGeometryType type;
		[Export ("type")]
		MBMRenderedQueryGeometryType Type { get; }
	}

	// @interface MBMMapConstants : NSObject
	[BaseType (typeof(NSObject))]
	interface MBMMapConstants
	{
		// @property (readonly, nonatomic, class) double MinPitch;
		[Static]
		[Export ("MinPitch")]
		double MinPitch { get; }

		// @property (readonly, nonatomic, class) double MaxPitch;
		[Static]
		[Export ("MaxPitch")]
		double MaxPitch { get; }

		// @property (readonly, nonatomic, class) double MinZoom;
		[Static]
		[Export ("MinZoom")]
		double MinZoom { get; }

		// @property (readonly, nonatomic, class) double MaxZoom;
		[Static]
		[Export ("MaxZoom")]
		double MaxZoom { get; }

		// @property (readonly, nonatomic, class) uint64_t DefaultTransitionDuration;
		[Static]
		[Export ("DefaultTransitionDuration")]
		ulong DefaultTransitionDuration { get; }
	}

	// @interface MBMEvent : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMEvent
	{
		// -(instancetype _Nonnull)initWithType:(NSString * _Nonnull)type data:(id _Nonnull)data;
		[Export ("initWithType:data:")]
		IntPtr Constructor (string type, NSObject data);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export ("type")]
		string Type { get; }

		// @property (readonly, copy, nonatomic) id _Nonnull data;
		[Export ("data", ArgumentSemantic.Copy)]
		NSObject Data { get; }
	}

	// @protocol MBMObserver
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/

    partial interface IMBMObserver { }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
	interface MBMObserver
	{
		// @required -(void)notifyForEvent:(MBMEvent * _Nonnull)event;
		[Abstract]
		[Export ("notifyForEvent:")]
		void NotifyForEvent (MBMEvent @event);
	}

	// @interface MBMMapEvents : NSObject
	[BaseType (typeof(NSObject))]
	interface MBMMapEvents
	{
		// @property (readonly, nonatomic, class) NSString * MapLoaded;
		[Static]
		[Export ("MapLoaded")]
		string MapLoaded { get; }

		// @property (readonly, nonatomic, class) NSString * MapLoadingError;
		[Static]
		[Export ("MapLoadingError")]
		string MapLoadingError { get; }

		// @property (readonly, nonatomic, class) NSString * MapIdle;
		[Static]
		[Export ("MapIdle")]
		string MapIdle { get; }

		// @property (readonly, nonatomic, class) NSString * StyleDataLoaded;
		[Static]
		[Export ("StyleDataLoaded")]
		string StyleDataLoaded { get; }

		// @property (readonly, nonatomic, class) NSString * StyleLoaded;
		[Static]
		[Export ("StyleLoaded")]
		string StyleLoaded { get; }

		// @property (readonly, nonatomic, class) NSString * StyleImageMissing;
		[Static]
		[Export ("StyleImageMissing")]
		string StyleImageMissing { get; }

		// @property (readonly, nonatomic, class) NSString * StyleImageRemoveUnused;
		[Static]
		[Export ("StyleImageRemoveUnused")]
		string StyleImageRemoveUnused { get; }

		// @property (readonly, nonatomic, class) NSString * SourceDataLoaded;
		[Static]
		[Export ("SourceDataLoaded")]
		string SourceDataLoaded { get; }

		// @property (readonly, nonatomic, class) NSString * SourceAdded;
		[Static]
		[Export ("SourceAdded")]
		string SourceAdded { get; }

		// @property (readonly, nonatomic, class) NSString * SourceRemoved;
		[Static]
		[Export ("SourceRemoved")]
		string SourceRemoved { get; }

		// @property (readonly, nonatomic, class) NSString * RenderFrameStarted;
		[Static]
		[Export ("RenderFrameStarted")]
		string RenderFrameStarted { get; }

		// @property (readonly, nonatomic, class) NSString * RenderFrameFinished;
		[Static]
		[Export ("RenderFrameFinished")]
		string RenderFrameFinished { get; }

		// @property (readonly, nonatomic, class) NSString * CameraChanged;
		[Static]
		[Export ("CameraChanged")]
		string CameraChanged { get; }

		// @property (readonly, nonatomic, class) NSString * ResourceRequest;
		[Static]
		[Export ("ResourceRequest")]
		string ResourceRequest { get; }
	}

	// @interface MBMStylePack : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMStylePack
	{
		// -(instancetype _Nonnull)initWithStyleURI:(NSString * _Nonnull)styleURI glyphsRasterizationMode:(MBMGlyphsRasterizationMode)glyphsRasterizationMode requiredResourceCount:(uint64_t)requiredResourceCount completedResourceCount:(uint64_t)completedResourceCount completedResourceSize:(uint64_t)completedResourceSize expires:(NSDate * _Nullable)expires;
		[Export ("initWithStyleURI:glyphsRasterizationMode:requiredResourceCount:completedResourceCount:completedResourceSize:expires:")]
		IntPtr Constructor (string styleURI, MBMGlyphsRasterizationMode glyphsRasterizationMode, ulong requiredResourceCount, ulong completedResourceCount, ulong completedResourceSize, [NullAllowed] NSDate expires);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull styleURI;
		[Export ("styleURI")]
		string StyleURI { get; }

		// @property (readonly, nonatomic) MBMGlyphsRasterizationMode glyphsRasterizationMode;
		[Export ("glyphsRasterizationMode")]
		MBMGlyphsRasterizationMode GlyphsRasterizationMode { get; }

		// @property (readonly, nonatomic) uint64_t requiredResourceCount;
		[Export ("requiredResourceCount")]
		ulong RequiredResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t completedResourceCount;
		[Export ("completedResourceCount")]
		ulong CompletedResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t completedResourceSize;
		[Export ("completedResourceSize")]
		ulong CompletedResourceSize { get; }

		// @property (readonly, nonatomic) NSDate * _Nullable expires;
		[NullAllowed, Export ("expires")]
		NSDate Expires { get; }
	}

	// @interface MBMStylePackLoadProgress : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMStylePackLoadProgress
	{
		// -(instancetype _Nonnull)initWithCompletedResourceCount:(uint64_t)completedResourceCount completedResourceSize:(uint64_t)completedResourceSize erroredResourceCount:(uint64_t)erroredResourceCount requiredResourceCount:(uint64_t)requiredResourceCount loadedResourceCount:(uint64_t)loadedResourceCount loadedResourceSize:(uint64_t)loadedResourceSize;
		[Export ("initWithCompletedResourceCount:completedResourceSize:erroredResourceCount:requiredResourceCount:loadedResourceCount:loadedResourceSize:")]
		IntPtr Constructor (ulong completedResourceCount, ulong completedResourceSize, ulong erroredResourceCount, ulong requiredResourceCount, ulong loadedResourceCount, ulong loadedResourceSize);

		// @property (readonly, nonatomic) uint64_t completedResourceCount;
		[Export ("completedResourceCount")]
		ulong CompletedResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t completedResourceSize;
		[Export ("completedResourceSize")]
		ulong CompletedResourceSize { get; }

		// @property (readonly, nonatomic) uint64_t erroredResourceCount;
		[Export ("erroredResourceCount")]
		ulong ErroredResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t requiredResourceCount;
		[Export ("requiredResourceCount")]
		ulong RequiredResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t loadedResourceCount;
		[Export ("loadedResourceCount")]
		ulong LoadedResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t loadedResourceSize;
		[Export ("loadedResourceSize")]
		ulong LoadedResourceSize { get; }
	}

	// @interface MBMStylePackError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMStylePackError
	{
		// -(instancetype _Nonnull)initWithType:(MBMStylePackErrorType)type message:(NSString * _Nonnull)message;
		[Export ("initWithType:message:")]
		IntPtr Constructor (MBMStylePackErrorType type, string message);

		// @property (readonly, nonatomic) MBMStylePackErrorType type;
		[Export ("type")]
		MBMStylePackErrorType Type { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull message;
		[Export ("message")]
		string Message { get; }
	}

	// @interface MBMStylePackLoadOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMStylePackLoadOptions
	{
		// -(instancetype _Nonnull)initWithGlyphsRasterizationMode:(NSNumber * _Nullable)glyphsRasterizationMode metadata:(id _Nullable)metadata __attribute__((swift_private));
		[Export ("initWithGlyphsRasterizationMode:metadata:")]
		IntPtr Constructor ([NullAllowed] NSNumber glyphsRasterizationMode, [NullAllowed] NSObject metadata);

		// -(instancetype _Nonnull)initWithGlyphsRasterizationMode:(NSNumber * _Nullable)glyphsRasterizationMode metadata:(id _Nullable)metadata acceptExpired:(BOOL)acceptExpired __attribute__((swift_private));
		[Export ("initWithGlyphsRasterizationMode:metadata:acceptExpired:")]
		IntPtr Constructor ([NullAllowed] NSNumber glyphsRasterizationMode, [NullAllowed] NSObject metadata, bool acceptExpired);

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * glyphsRasterizationMode __attribute__((swift_private));
		[Export ("glyphsRasterizationMode")]
		NSNumber GlyphsRasterizationMode { get; }

		// @property (readonly, copy, nonatomic) id _Nullable metadata;
		[NullAllowed, Export ("metadata", ArgumentSemantic.Copy)]
		NSObject Metadata { get; }

		// @property (readonly, getter = isAcceptExpired, nonatomic) BOOL acceptExpired;
		[Export ("acceptExpired")]
		bool AcceptExpired { [Bind ("isAcceptExpired")] get; }
	}

	// @interface MBMTilesetDescriptorOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMTilesetDescriptorOptions
	{
		// -(instancetype _Nonnull)initWithStyleURI:(NSString * _Nonnull)styleURI minZoom:(uint8_t)minZoom maxZoom:(uint8_t)maxZoom stylePackOptions:(MBMStylePackLoadOptions * _Nullable)stylePackOptions;
		[Export ("initWithStyleURI:minZoom:maxZoom:stylePackOptions:")]
		IntPtr Constructor (string styleURI, byte minZoom, byte maxZoom, [NullAllowed] MBMStylePackLoadOptions stylePackOptions);

		// -(instancetype _Nonnull)initWithStyleURI:(NSString * _Nonnull)styleURI minZoom:(uint8_t)minZoom maxZoom:(uint8_t)maxZoom pixelRatio:(float)pixelRatio stylePackOptions:(MBMStylePackLoadOptions * _Nullable)stylePackOptions;
		[Export ("initWithStyleURI:minZoom:maxZoom:pixelRatio:stylePackOptions:")]
		IntPtr Constructor (string styleURI, byte minZoom, byte maxZoom, float pixelRatio, [NullAllowed] MBMStylePackLoadOptions stylePackOptions);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull styleURI;
		[Export ("styleURI")]
		string StyleURI { get; }

		// @property (readonly, nonatomic) uint8_t minZoom;
		[Export ("minZoom")]
		byte MinZoom { get; }

		// @property (readonly, nonatomic) uint8_t maxZoom;
		[Export ("maxZoom")]
		byte MaxZoom { get; }

		// @property (readonly, nonatomic) float pixelRatio;
		[Export ("pixelRatio")]
		float PixelRatio { get; }

		// @property (readonly, nonatomic) MBMStylePackLoadOptions * _Nullable stylePackOptions;
		[NullAllowed, Export ("stylePackOptions")]
		MBMStylePackLoadOptions StylePackOptions { get; }
	}

	// typedef void (^MBMStylePackLoadProgressCallback)(MBMStylePackLoadProgress * _Nonnull);
	delegate void MBMStylePackLoadProgressCallback (MBMStylePackLoadProgress arg0);

	// @interface MBMOfflineManager : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMOfflineManager
	{
		// -(instancetype _Nonnull)initWithResourceOptions:(MBMResourceOptions * _Nonnull)resourceOptions;
		[Export ("initWithResourceOptions:")]
		IntPtr Constructor (MBMResourceOptions resourceOptions);

		// -(MBXTilesetDescriptor * _Nonnull)createTilesetDescriptorForTilesetDescriptorOptions:(MBMTilesetDescriptorOptions * _Nonnull)tilesetDescriptorOptions __attribute__((ns_returns_retained));
		[Export ("createTilesetDescriptorForTilesetDescriptorOptions:")]
		MBXTilesetDescriptor CreateTilesetDescriptorForTilesetDescriptorOptions (MBMTilesetDescriptorOptions tilesetDescriptorOptions);

		// -(void)removeStylePackForStyleURI:(NSString * _Nonnull)styleURI;
		[Export ("removeStylePackForStyleURI:")]
		void RemoveStylePackForStyleURI (string styleURI);
	}

	// @interface MBMResponseError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMResponseError
	{
		// -(instancetype _Nonnull)initWithReason:(MBMResponseErrorReason)reason message:(NSString * _Nonnull)message retryAfter:(NSDate * _Nullable)retryAfter;
		[Export ("initWithReason:message:retryAfter:")]
		IntPtr Constructor (MBMResponseErrorReason reason, string message, [NullAllowed] NSDate retryAfter);

		// @property (readonly, nonatomic) MBMResponseErrorReason reason;
		[Export ("reason")]
		MBMResponseErrorReason Reason { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull message;
		[Export ("message")]
		string Message { get; }

		// @property (readonly, nonatomic) NSDate * _Nullable retryAfter;
		[NullAllowed, Export ("retryAfter")]
		NSDate RetryAfter { get; }
	}

	// @interface MBMOfflineRegionStatus : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMOfflineRegionStatus
	{
		// -(instancetype _Nonnull)initWithDownloadState:(MBMOfflineRegionDownloadState)downloadState completedResourceCount:(uint64_t)completedResourceCount completedResourceSize:(uint64_t)completedResourceSize completedTileCount:(uint64_t)completedTileCount requiredTileCount:(uint64_t)requiredTileCount completedTileSize:(uint64_t)completedTileSize requiredResourceCount:(uint64_t)requiredResourceCount requiredResourceCountIsPrecise:(BOOL)requiredResourceCountIsPrecise;
		[Export ("initWithDownloadState:completedResourceCount:completedResourceSize:completedTileCount:requiredTileCount:completedTileSize:requiredResourceCount:requiredResourceCountIsPrecise:")]
		IntPtr Constructor (MBMOfflineRegionDownloadState downloadState, ulong completedResourceCount, ulong completedResourceSize, ulong completedTileCount, ulong requiredTileCount, ulong completedTileSize, ulong requiredResourceCount, bool requiredResourceCountIsPrecise);

		// @property (readonly, nonatomic) MBMOfflineRegionDownloadState downloadState;
		[Export ("downloadState")]
		MBMOfflineRegionDownloadState DownloadState { get; }

		// @property (readonly, nonatomic) uint64_t completedResourceCount;
		[Export ("completedResourceCount")]
		ulong CompletedResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t completedResourceSize;
		[Export ("completedResourceSize")]
		ulong CompletedResourceSize { get; }

		// @property (readonly, nonatomic) uint64_t completedTileCount;
		[Export ("completedTileCount")]
		ulong CompletedTileCount { get; }

		// @property (readonly, nonatomic) uint64_t requiredTileCount;
		[Export ("requiredTileCount")]
		ulong RequiredTileCount { get; }

		// @property (readonly, nonatomic) uint64_t completedTileSize;
		[Export ("completedTileSize")]
		ulong CompletedTileSize { get; }

		// @property (readonly, nonatomic) uint64_t requiredResourceCount;
		[Export ("requiredResourceCount")]
		ulong RequiredResourceCount { get; }

		// @property (readonly, getter = isRequiredResourceCountIsPrecise, nonatomic) BOOL requiredResourceCountIsPrecise;
		[Export ("requiredResourceCountIsPrecise")]
		bool RequiredResourceCountIsPrecise { [Bind ("isRequiredResourceCountIsPrecise")] get; }
	}

	// @interface MBMOfflineRegionGeometryDefinition : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMOfflineRegionGeometryDefinition
	{
		// -(instancetype _Nonnull)initWithStyleURL:(NSString * _Nonnull)styleURL geometry:(MBXGeometry * _Nonnull)geometry minZoom:(double)minZoom maxZoom:(double)maxZoom pixelRatio:(float)pixelRatio glyphsRasterizationMode:(MBMGlyphsRasterizationMode)glyphsRasterizationMode __attribute__((swift_private));
		[Export ("initWithStyleURL:geometry:minZoom:maxZoom:pixelRatio:glyphsRasterizationMode:")]
		IntPtr Constructor (string styleURL, MBXGeometry geometry, double minZoom, double maxZoom, float pixelRatio, MBMGlyphsRasterizationMode glyphsRasterizationMode);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull styleURL;
		[Export ("styleURL")]
		string StyleURL { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT MBXGeometry * geometry __attribute__((swift_private));
		[Export ("geometry")]
		MBXGeometry Geometry { get; }

		// @property (readonly, nonatomic) double minZoom;
		[Export ("minZoom")]
		double MinZoom { get; }

		// @property (readonly, nonatomic) double maxZoom;
		[Export ("maxZoom")]
		double MaxZoom { get; }

		// @property (readonly, nonatomic) float pixelRatio;
		[Export ("pixelRatio")]
		float PixelRatio { get; }

		// @property (readonly, nonatomic) MBMGlyphsRasterizationMode glyphsRasterizationMode;
		[Export ("glyphsRasterizationMode")]
		MBMGlyphsRasterizationMode GlyphsRasterizationMode { get; }
	}

	// @interface MBMOfflineRegionTilePyramidDefinition : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMOfflineRegionTilePyramidDefinition
	{
		// -(instancetype _Nonnull)initWithStyleURL:(NSString * _Nonnull)styleURL bounds:(MBMCoordinateBounds * _Nonnull)bounds minZoom:(double)minZoom maxZoom:(double)maxZoom pixelRatio:(float)pixelRatio glyphsRasterizationMode:(MBMGlyphsRasterizationMode)glyphsRasterizationMode;
		[Export ("initWithStyleURL:bounds:minZoom:maxZoom:pixelRatio:glyphsRasterizationMode:")]
		IntPtr Constructor (string styleURL, MBMCoordinateBounds bounds, double minZoom, double maxZoom, float pixelRatio, MBMGlyphsRasterizationMode glyphsRasterizationMode);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull styleURL;
		[Export ("styleURL")]
		string StyleURL { get; }

		// @property (readonly, nonatomic) MBMCoordinateBounds * _Nonnull bounds;
		[Export ("bounds")]
		MBMCoordinateBounds Bounds { get; }

		// @property (readonly, nonatomic) double minZoom;
		[Export ("minZoom")]
		double MinZoom { get; }

		// @property (readonly, nonatomic) double maxZoom;
		[Export ("maxZoom")]
		double MaxZoom { get; }

		// @property (readonly, nonatomic) float pixelRatio;
		[Export ("pixelRatio")]
		float PixelRatio { get; }

		// @property (readonly, nonatomic) MBMGlyphsRasterizationMode glyphsRasterizationMode;
		[Export ("glyphsRasterizationMode")]
		MBMGlyphsRasterizationMode GlyphsRasterizationMode { get; }
	}

	// @interface MBMOfflineRegion : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMOfflineRegion
	{
		// -(int64_t)getIdentifier;
		[Export ("getIdentifier")]
        long GetIdentifier();

		// -(MBMOfflineRegionTilePyramidDefinition * _Nullable)getTilePyramidDefinition __attribute__((ns_returns_retained));
		[NullAllowed, Export ("getTilePyramidDefinition")]
        MBMOfflineRegionTilePyramidDefinition GetTilePyramidDefinition();

		// -(MBMOfflineRegionGeometryDefinition * _Nullable)getGeometryDefinition __attribute__((ns_returns_retained));
		[NullAllowed, Export ("getGeometryDefinition")]
        MBMOfflineRegionGeometryDefinition GetGeometryDefinition();

		// -(NSData * _Nonnull)getMetadata __attribute__((ns_returns_retained));
		[Export ("getMetadata")]
        NSData GetMetadata();

		// -(void)setOfflineRegionDownloadStateForState:(MBMOfflineRegionDownloadState)state;
		[Export ("setOfflineRegionDownloadStateForState:")]
		void SetOfflineRegionDownloadStateForState (MBMOfflineRegionDownloadState state);

		// -(void)setOfflineRegionObserverForObserver:(id<MBMOfflineRegionObserver> _Nonnull)observer;
		[Export ("setOfflineRegionObserverForObserver:")]
		void SetOfflineRegionObserverForObserver (IMBMOfflineRegionObserver observer);
	}

	// @interface MBMOfflineRegionManager : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMOfflineRegionManager
	{
		// -(instancetype _Nonnull)initWithResourceOptions:(MBMResourceOptions * _Nonnull)resourceOptions;
		[Export ("initWithResourceOptions:")]
		IntPtr Constructor (MBMResourceOptions resourceOptions);

		// -(void)setOfflineMapboxTileCountLimitForLimit:(uint64_t)limit;
		[Export ("setOfflineMapboxTileCountLimitForLimit:")]
		void SetOfflineMapboxTileCountLimitForLimit (ulong limit);
	}

	// @protocol MBMOfflineRegionObserver
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    partial interface IMBMOfflineRegionObserver { }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
	interface MBMOfflineRegionObserver
	{
		// @required -(void)statusChangedForStatus:(MBMOfflineRegionStatus * _Nonnull)status;
		[Abstract]
		[Export ("statusChangedForStatus:")]
		void StatusChangedForStatus (MBMOfflineRegionStatus status);

		// @required -(void)responseErrorForError:(MBMResponseError * _Nonnull)error;
		[Abstract]
		[Export ("responseErrorForError:")]
		void ResponseErrorForError (MBMResponseError error);

		// @required -(void)mapboxTileCountLimitExceededForLimit:(uint64_t)limit;
		[Abstract]
		[Export ("mapboxTileCountLimitExceededForLimit:")]
		void MapboxTileCountLimitExceededForLimit (ulong limit);
	}

	// @interface MBMProjectedMeters : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMProjectedMeters
	{
		// -(instancetype _Nonnull)initWithNorthing:(double)northing easting:(double)easting;
		[Export ("initWithNorthing:easting:")]
		IntPtr Constructor (double northing, double easting);

		// @property (readonly, nonatomic) double northing;
		[Export ("northing")]
		double Northing { get; }

		// @property (readonly, nonatomic) double easting;
		[Export ("easting")]
		double Easting { get; }
	}

	// @interface MBMMercatorCoordinate : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMMercatorCoordinate
	{
		// -(instancetype _Nonnull)initWithX:(double)x y:(double)y;
		[Export ("initWithX:y:")]
		IntPtr Constructor (double x, double y);

		// @property (readonly, nonatomic) double x;
		[Export ("x")]
		double X { get; }

		// @property (readonly, nonatomic) double y;
		[Export ("y")]
		double Y { get; }

		// -(BOOL)isEqualToMercatorCoordinate:(MBMMercatorCoordinate * _Nonnull)other;
		[Export ("isEqualToMercatorCoordinate:")]
		bool IsEqualToMercatorCoordinate (MBMMercatorCoordinate other);
	}

	// @interface MBMProjection : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMProjection
	{
		// +(double)getMetersPerPixelAtLatitudeForLatitude:(double)latitude zoom:(double)zoom;
		[Static]
		[Export ("getMetersPerPixelAtLatitudeForLatitude:zoom:")]
		double GetMetersPerPixelAtLatitudeForLatitude (double latitude, double zoom);

		// +(MBMProjectedMeters * _Nonnull)projectedMetersForCoordinateForCoordinate:(CLLocationCoordinate2D)coordinate __attribute__((ns_returns_retained));
		[Static]
		[Export ("projectedMetersForCoordinateForCoordinate:")]
		MBMProjectedMeters ProjectedMetersForCoordinateForCoordinate (CLLocationCoordinate2D coordinate);

		// +(CLLocationCoordinate2D)coordinateForProjectedMetersForProjectedMeters:(MBMProjectedMeters * _Nonnull)projectedMeters;
		[Static]
		[Export ("coordinateForProjectedMetersForProjectedMeters:")]
		CLLocationCoordinate2D CoordinateForProjectedMetersForProjectedMeters (MBMProjectedMeters projectedMeters);

		// +(MBMMercatorCoordinate * _Nonnull)projectForCoordinate:(CLLocationCoordinate2D)coordinate zoomScale:(double)zoomScale __attribute__((ns_returns_retained));
		[Static]
		[Export ("projectForCoordinate:zoomScale:")]
		MBMMercatorCoordinate ProjectForCoordinate (CLLocationCoordinate2D coordinate, double zoomScale);

		// +(CLLocationCoordinate2D)unprojectForCoordinate:(MBMMercatorCoordinate * _Nonnull)coordinate zoomScale:(double)zoomScale;
		[Static]
		[Export ("unprojectForCoordinate:zoomScale:")]
		CLLocationCoordinate2D UnprojectForCoordinate (MBMMercatorCoordinate coordinate, double zoomScale);
	}

	// @interface MBMResourceOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMResourceOptions
	{
		// -(instancetype _Nonnull)initWithAccessToken:(NSString * _Nonnull)accessToken baseURL:(NSString * _Nullable)baseURL dataPath:(NSString * _Nullable)dataPath assetPath:(NSString * _Nullable)assetPath tileStore:(MBXTileStore * _Nullable)tileStore;
		[Export ("initWithAccessToken:baseURL:dataPath:assetPath:tileStore:")]
		IntPtr Constructor (string accessToken, [NullAllowed] string baseURL, [NullAllowed] string dataPath, [NullAllowed] string assetPath, [NullAllowed] MBXTileStore tileStore);

		// -(instancetype _Nonnull)initWithAccessToken:(NSString * _Nonnull)accessToken baseURL:(NSString * _Nullable)baseURL dataPath:(NSString * _Nullable)dataPath assetPath:(NSString * _Nullable)assetPath tileStore:(MBXTileStore * _Nullable)tileStore tileStoreUsageMode:(MBMTileStoreUsageMode)tileStoreUsageMode;
		[Export ("initWithAccessToken:baseURL:dataPath:assetPath:tileStore:tileStoreUsageMode:")]
		IntPtr Constructor (string accessToken, [NullAllowed] string baseURL, [NullAllowed] string dataPath, [NullAllowed] string assetPath, [NullAllowed] MBXTileStore tileStore, MBMTileStoreUsageMode tileStoreUsageMode);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull accessToken;
		[Export ("accessToken")]
		string AccessToken { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable baseURL;
		[NullAllowed, Export ("baseURL")]
		string BaseURL { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable dataPath;
		[NullAllowed, Export ("dataPath")]
		string DataPath { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable assetPath;
		[NullAllowed, Export ("assetPath")]
		string AssetPath { get; }

		// @property (readonly, nonatomic) MBXTileStore * _Nullable tileStore;
		[NullAllowed, Export ("tileStore")]
		MBXTileStore TileStore { get; }

		// @property (readonly, nonatomic) MBMTileStoreUsageMode tileStoreUsageMode;
		[Export ("tileStoreUsageMode")]
		MBMTileStoreUsageMode TileStoreUsageMode { get; }
	}

	// @interface MBMSettings : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMSettings
	{
		// +(void)setForKey:(NSString * _Nonnull)key value:(id _Nonnull)value;
		[Static]
		[Export ("setForKey:value:")]
		void SetForKey (string key, NSObject value);

		// +(id _Nonnull)getForKey:(NSString * _Nonnull)key __attribute__((ns_returns_retained));
		[Static]
		[Export ("getForKey:")]
		NSObject GetForKey (string key);
	}

	// @interface MBMMapSnapshotOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMMapSnapshotOptions
	{
		// -(instancetype _Nonnull)initWithSize:(MBMSize * _Nonnull)size glyphsRasterizationOptions:(MBMGlyphsRasterizationOptions * _Nullable)glyphsRasterizationOptions resourceOptions:(MBMResourceOptions * _Nonnull)resourceOptions __attribute__((swift_private));
		[Export ("initWithSize:glyphsRasterizationOptions:resourceOptions:")]
		IntPtr Constructor (MBMSize size, [NullAllowed] MBMGlyphsRasterizationOptions glyphsRasterizationOptions, MBMResourceOptions resourceOptions);

		// -(instancetype _Nonnull)initWithSize:(MBMSize * _Nonnull)size pixelRatio:(float)pixelRatio glyphsRasterizationOptions:(MBMGlyphsRasterizationOptions * _Nullable)glyphsRasterizationOptions resourceOptions:(MBMResourceOptions * _Nonnull)resourceOptions __attribute__((swift_private));
		[Export ("initWithSize:pixelRatio:glyphsRasterizationOptions:resourceOptions:")]
		IntPtr Constructor (MBMSize size, float pixelRatio, [NullAllowed] MBMGlyphsRasterizationOptions glyphsRasterizationOptions, MBMResourceOptions resourceOptions);

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT MBMSize * size __attribute__((swift_private));
		[Export ("size")]
		MBMSize Size { get; }

		// @property (readonly, nonatomic) float pixelRatio;
		[Export ("pixelRatio")]
		float PixelRatio { get; }

		// @property (readonly, nonatomic) MBMGlyphsRasterizationOptions * _Nullable glyphsRasterizationOptions;
		[NullAllowed, Export ("glyphsRasterizationOptions")]
		MBMGlyphsRasterizationOptions GlyphsRasterizationOptions { get; }

		// @property (readonly, nonatomic) MBMResourceOptions * _Nonnull resourceOptions;
		[Export ("resourceOptions")]
		MBMResourceOptions ResourceOptions { get; }
	}

	// @interface MBMMapSnapshot : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMMapSnapshot
	{
		// -(MBMScreenCoordinate * _Nonnull)screenCoordinateForCoordinate:(CLLocationCoordinate2D)coordinate __attribute__((ns_returns_retained));
		[Export ("screenCoordinateForCoordinate:")]
		MBMScreenCoordinate ScreenCoordinateForCoordinate (CLLocationCoordinate2D coordinate);

		// -(CLLocationCoordinate2D)coordinateForScreenCoordinate:(MBMScreenCoordinate * _Nonnull)screenCoordinate;
		[Export ("coordinateForScreenCoordinate:")]
		CLLocationCoordinate2D CoordinateForScreenCoordinate (MBMScreenCoordinate screenCoordinate);

		// -(NSArray<NSString *> * _Nonnull)attributions __attribute__((ns_returns_retained));
		[Export ("attributions")]
		string[] Attributions { get; }

		// -(MBMImage * _Nonnull)image __attribute__((ns_returns_retained));
		[Export ("image")]
		MBMImage Image { get; }
	}

	// @interface MBMMapSnapshotter : MBMCameraManager
	[BaseType (typeof(MBMCameraManager))]
	[DisableDefaultCtor]
	interface MBMMapSnapshotter
	{
		// -(instancetype _Nonnull)initWithOptions:(MBMMapSnapshotOptions * _Nonnull)options;
		[Export ("initWithOptions:")]
		IntPtr Constructor (MBMMapSnapshotOptions options);

		// -(void)setSizeForSize:(MBMSize * _Nonnull)size;
		[Export ("setSizeForSize:")]
		void SetSizeForSize (MBMSize size);

		// -(MBMSize * _Nonnull)getSize __attribute__((ns_returns_retained));
		[Export ("getSize")]
        MBMSize GetSize();

		// -(BOOL)isInTileMode;
		[Export ("isInTileMode")]
		bool IsInTileMode { get; }

		// -(void)setTileModeForSet:(BOOL)set;
		[Export ("setTileModeForSet:")]
		void SetTileModeForSet (bool set);

		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();

		// -(NSNumber * _Nullable)getElevationForCoordinate:(CLLocationCoordinate2D)coordinate __attribute__((ns_returns_retained));
		[Export ("getElevationForCoordinate:")]
		[return: NullAllowed]
		NSNumber GetElevationForCoordinate (CLLocationCoordinate2D coordinate);
	}

	// @interface MBMStyleObjectInfo : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMStyleObjectInfo
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id type:(NSString * _Nonnull)type;
		[Export ("initWithId:type:")]
		IntPtr Constructor (string id, string type);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull type;
		[Export ("type")]
		string Type { get; }
	}

	// @interface MBMImageStretches : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMImageStretches
	{
		// -(instancetype _Nonnull)initWithFirst:(float)first second:(float)second;
		[Export ("initWithFirst:second:")]
		IntPtr Constructor (float first, float second);

		// @property (readonly, nonatomic) float first;
		[Export ("first")]
		float First { get; }

		// @property (readonly, nonatomic) float second;
		[Export ("second")]
		float Second { get; }

		// -(BOOL)isEqualToImageStretches:(MBMImageStretches * _Nonnull)other;
		[Export ("isEqualToImageStretches:")]
		bool IsEqualToImageStretches (MBMImageStretches other);
	}

	// @interface MBMImageContent : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMImageContent
	{
		// -(instancetype _Nonnull)initWithLeft:(float)left top:(float)top right:(float)right bottom:(float)bottom;
		[Export ("initWithLeft:top:right:bottom:")]
		IntPtr Constructor (float left, float top, float right, float bottom);

		// @property (readonly, nonatomic) float left;
		[Export ("left")]
		float Left { get; }

		// @property (readonly, nonatomic) float top;
		[Export ("top")]
		float Top { get; }

		// @property (readonly, nonatomic) float right;
		[Export ("right")]
		float Right { get; }

		// @property (readonly, nonatomic) float bottom;
		[Export ("bottom")]
		float Bottom { get; }

		// -(BOOL)isEqualToImageContent:(MBMImageContent * _Nonnull)other;
		[Export ("isEqualToImageContent:")]
		bool IsEqualToImageContent (MBMImageContent other);
	}

	// @interface MBMTransitionOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMTransitionOptions
	{
		// -(instancetype _Nonnull)initWithDuration:(NSNumber * _Nullable)duration delay:(NSNumber * _Nullable)delay enablePlacementTransitions:(NSNumber * _Nullable)enablePlacementTransitions __attribute__((swift_private));
		[Export ("initWithDuration:delay:enablePlacementTransitions:")]
		IntPtr Constructor ([NullAllowed] NSNumber duration, [NullAllowed] NSNumber delay, [NullAllowed] NSNumber enablePlacementTransitions);

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * duration __attribute__((swift_private));
		[Export ("duration")]
		NSNumber Duration { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * delay __attribute__((swift_private));
		[Export ("delay")]
		NSNumber Delay { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * enablePlacementTransitions __attribute__((swift_private));
		[Export ("enablePlacementTransitions")]
		NSNumber EnablePlacementTransitions { get; }
	}

	// @interface MBMCanonicalTileID : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMCanonicalTileID
	{
		// -(instancetype _Nonnull)initWithZ:(uint8_t)z x:(uint32_t)x y:(uint32_t)y;
		[Export ("initWithZ:x:y:")]
		IntPtr Constructor (byte z, uint x, uint y);

		// @property (readonly, nonatomic) uint8_t z;
		[Export ("z")]
		byte Z { get; }

		// @property (readonly, nonatomic) uint32_t x;
		[Export ("x")]
		uint X { get; }

		// @property (readonly, nonatomic) uint32_t y;
		[Export ("y")]
		uint Y { get; }
	}

	// @interface MBMTileOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface MBMTileOptions
	{
		// -(instancetype _Nonnull)initWithTolerance:(double)tolerance tileSize:(uint16_t)tileSize buffer:(uint16_t)buffer clip:(BOOL)clip wrap:(BOOL)wrap;
		[Export ("initWithTolerance:tileSize:buffer:clip:wrap:")]
		IntPtr Constructor (double tolerance, ushort tileSize, ushort buffer, bool clip, bool wrap);

		// @property (readonly, nonatomic) double tolerance;
		[Export ("tolerance")]
		double Tolerance { get; }

		// @property (readonly, nonatomic) uint16_t tileSize;
		[Export ("tileSize")]
		ushort TileSize { get; }

		// @property (readonly, nonatomic) uint16_t buffer;
		[Export ("buffer")]
		ushort Buffer { get; }

		// @property (readonly, getter = isClip, nonatomic) BOOL clip;
		[Export ("clip")]
		bool Clip { [Bind ("isClip")] get; }

		// @property (readonly, getter = isWrap, nonatomic) BOOL wrap;
		[Export ("wrap")]
		bool Wrap { [Bind ("isWrap")] get; }
	}

	// typedef void (^MBMCancelTileFunctionCallback)(MBMCanonicalTileID * _Nonnull);
	delegate void MBMCancelTileFunctionCallback (MBMCanonicalTileID arg0);

	// typedef void (^MBMFetchTileFunctionCallback)(MBMCanonicalTileID * _Nonnull);
	delegate void MBMFetchTileFunctionCallback (MBMCanonicalTileID arg0);

	// @interface MBMCustomGeometrySourceOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMCustomGeometrySourceOptions
	{
		// -(instancetype _Nonnull)initWithFetchTileFunction:(MBMFetchTileFunctionCallback _Nonnull)fetchTileFunction cancelTileFunction:(MBMCancelTileFunctionCallback _Nonnull)cancelTileFunction tileOptions:(MBMTileOptions * _Nonnull)tileOptions;
		[Export ("initWithFetchTileFunction:cancelTileFunction:tileOptions:")]
		IntPtr Constructor (MBMFetchTileFunctionCallback fetchTileFunction, MBMCancelTileFunctionCallback cancelTileFunction, MBMTileOptions tileOptions);

		// -(instancetype _Nonnull)initWithFetchTileFunction:(MBMFetchTileFunctionCallback _Nonnull)fetchTileFunction cancelTileFunction:(MBMCancelTileFunctionCallback _Nonnull)cancelTileFunction minZoom:(uint8_t)minZoom maxZoom:(uint8_t)maxZoom tileOptions:(MBMTileOptions * _Nonnull)tileOptions;
		[Export ("initWithFetchTileFunction:cancelTileFunction:minZoom:maxZoom:tileOptions:")]
		IntPtr Constructor (MBMFetchTileFunctionCallback fetchTileFunction, MBMCancelTileFunctionCallback cancelTileFunction, byte minZoom, byte maxZoom, MBMTileOptions tileOptions);

		// @property (readonly, nonatomic) MBMFetchTileFunctionCallback _Nonnull fetchTileFunction;
		[Export ("fetchTileFunction")]
		MBMFetchTileFunctionCallback FetchTileFunction { get; }

		// @property (readonly, nonatomic) MBMCancelTileFunctionCallback _Nonnull cancelTileFunction;
		[Export ("cancelTileFunction")]
		MBMCancelTileFunctionCallback CancelTileFunction { get; }

		// @property (readonly, nonatomic) uint8_t minZoom;
		[Export ("minZoom")]
		byte MinZoom { get; }

		// @property (readonly, nonatomic) uint8_t maxZoom;
		[Export ("maxZoom")]
		byte MaxZoom { get; }

		// @property (readonly, nonatomic) MBMTileOptions * _Nonnull tileOptions;
		[Export ("tileOptions")]
		MBMTileOptions TileOptions { get; }
	}

	// @interface MBMStylePropertyValue : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMStylePropertyValue
	{
		// -(instancetype _Nonnull)initWithValue:(id _Nonnull)value kind:(MBMStylePropertyValueKind)kind;
		[Export ("initWithValue:kind:")]
		IntPtr Constructor (NSObject value, MBMStylePropertyValueKind kind);

		// @property (readonly, copy, nonatomic) id _Nonnull value;
		[Export ("value", ArgumentSemantic.Copy)]
		NSObject Value { get; }

		// @property (readonly, nonatomic) MBMStylePropertyValueKind kind;
		[Export ("kind")]
		MBMStylePropertyValueKind Kind { get; }
	}

	// @interface MBMCustomLayerRenderParameters : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMCustomLayerRenderParameters
	{
		// -(instancetype _Nonnull)initWithWidth:(double)width height:(double)height latitude:(double)latitude longitude:(double)longitude zoom:(double)zoom bearing:(double)bearing pitch:(double)pitch fieldOfView:(double)fieldOfView projectionMatrix:(NSArray<NSNumber *> * _Nonnull)projectionMatrix elevationData:(id<MBMElevationData> _Nullable)elevationData;
		[Export ("initWithWidth:height:latitude:longitude:zoom:bearing:pitch:fieldOfView:projectionMatrix:elevationData:")]
		IntPtr Constructor (double width, double height, double latitude, double longitude, double zoom, double bearing, double pitch, double fieldOfView, NSNumber[] projectionMatrix, [NullAllowed] IMBMElevationData elevationData);

		// @property (readonly, nonatomic) double width;
		[Export ("width")]
		double Width { get; }

		// @property (readonly, nonatomic) double height;
		[Export ("height")]
		double Height { get; }

		// @property (readonly, nonatomic) double latitude;
		[Export ("latitude")]
		double Latitude { get; }

		// @property (readonly, nonatomic) double longitude;
		[Export ("longitude")]
		double Longitude { get; }

		// @property (readonly, nonatomic) double zoom;
		[Export ("zoom")]
		double Zoom { get; }

		// @property (readonly, nonatomic) double bearing;
		[Export ("bearing")]
		double Bearing { get; }

		// @property (readonly, nonatomic) double pitch;
		[Export ("pitch")]
		double Pitch { get; }

		// @property (readonly, nonatomic) double fieldOfView;
		[Export ("fieldOfView")]
		double FieldOfView { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull projectionMatrix;
		[Export ("projectionMatrix", ArgumentSemantic.Copy)]
		NSNumber[] ProjectionMatrix { get; }

		// @property (readonly, nonatomic) id<MBMElevationData> _Nullable elevationData;
		[NullAllowed, Export ("elevationData")]
		IMBMElevationData ElevationData { get; }
	}

	// @protocol MBMElevationData
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    partial interface IMBMElevationData { }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
	interface MBMElevationData
	{
		// @required -(NSNumber * _Nullable)getElevationForCoordinate:(CLLocationCoordinate2D)coordinate;
		[Abstract]
		[Export ("getElevationForCoordinate:")]
		[return: NullAllowed]
		NSNumber GetElevationForCoordinate (CLLocationCoordinate2D coordinate);

		// @required -(double)getTerrainExaggeration;
		[Abstract]
		[Export ("getTerrainExaggeration")]
		double TerrainExaggeration { get; }
	}

	// @protocol MBMCustomLayerHost <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	partial interface IMBMCustomLayerHost {}

	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MBMCustomLayerHost
	{
		// @required -(void)renderingWillStart:(id<MTLDevice> _Nonnull)metalDevice colorPixelFormat:(NSUInteger)colorPixelFormat depthStencilPixelFormat:(NSUInteger)depthStencilPixelFormat;
		[Abstract]
		[Export ("renderingWillStart:colorPixelFormat:depthStencilPixelFormat:")]
		void RenderingWillStart (IMTLDevice metalDevice, nuint colorPixelFormat, nuint depthStencilPixelFormat);

		// @required -(void)render:(MBMCustomLayerRenderParameters * _Nonnull)parameters mtlCommandBuffer:(id<MTLCommandBuffer> _Nonnull)mtlCommandBuffer mtlRenderPassDescriptor:(MTLRenderPassDescriptor * _Nonnull)mtlRenderPassDescriptor;
		[Abstract]
		[Export ("render:mtlCommandBuffer:mtlRenderPassDescriptor:")]
		void Render (MBMCustomLayerRenderParameters parameters, IMTLCommandBuffer mtlCommandBuffer, MTLRenderPassDescriptor mtlRenderPassDescriptor);

		// @required -(void)renderingWillEnd;
		[Abstract]
		[Export ("renderingWillEnd")]
		void RenderingWillEnd ();

		// @optional -(void)renderingWillStartOpenGL;
		[Export ("renderingWillStartOpenGL")]
		void RenderingWillStartOpenGL ();

		// @optional -(void)renderOpenGL:(MBMCustomLayerRenderParameters * _Nonnull)parameters;
		[Export ("renderOpenGL:")]
		void RenderOpenGL (MBMCustomLayerRenderParameters parameters);

		// @optional -(void)openGLContextLost;
		[Export ("openGLContextLost")]
		void OpenGLContextLost ();
	}

	// @interface MBMVec3 : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMVec3
	{
		// -(instancetype _Nonnull)initWithX:(double)x y:(double)y z:(double)z;
		[Export ("initWithX:y:z:")]
		IntPtr Constructor (double x, double y, double z);

		// @property (readonly, nonatomic) double x;
		[Export ("x")]
		double X { get; }

		// @property (readonly, nonatomic) double y;
		[Export ("y")]
		double Y { get; }

		// @property (readonly, nonatomic) double z;
		[Export ("z")]
		double Z { get; }
	}

	// @interface MBMVec4 : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMVec4
	{
		// -(instancetype _Nonnull)initWithX:(double)x y:(double)y z:(double)z w:(double)w;
		[Export ("initWithX:y:z:w:")]
		IntPtr Constructor (double x, double y, double z, double w);

		// @property (readonly, nonatomic) double x;
		[Export ("x")]
		double X { get; }

		// @property (readonly, nonatomic) double y;
		[Export ("y")]
		double Y { get; }

		// @property (readonly, nonatomic) double z;
		[Export ("z")]
		double Z { get; }

		// @property (readonly, nonatomic) double w;
		[Export ("w")]
		double W { get; }
	}

	// @interface MBMViewAnnotationPositionDescriptor : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBMViewAnnotationPositionDescriptor
	{
		// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier width:(uint32_t)width height:(uint32_t)height leftTopCoordinate:(MBMScreenCoordinate * _Nonnull)leftTopCoordinate __attribute__((swift_private));
		[Export ("initWithIdentifier:width:height:leftTopCoordinate:")]
		IntPtr Constructor (string identifier, uint width, uint height, MBMScreenCoordinate leftTopCoordinate);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
		[Export ("identifier")]
		string Identifier { get; }

		// @property (readonly, nonatomic) uint32_t width;
		[Export ("width")]
		uint Width { get; }

		// @property (readonly, nonatomic) uint32_t height;
		[Export ("height")]
		uint Height { get; }

		// @property (readonly, nonatomic) MBMScreenCoordinate * _Nonnull leftTopCoordinate;
		[Export ("leftTopCoordinate")]
		MBMScreenCoordinate LeftTopCoordinate { get; }
	}
}
