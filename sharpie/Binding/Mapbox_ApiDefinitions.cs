using System;
using CoreAnimation;
using CoreGraphics;
using CoreLocation;
using Foundation;
using Mapbox;
using ObjCRuntime;
using UIKit;

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern double MapboxVersionNumber __attribute__((visibility("default")));
	[Field ("MapboxVersionNumber", "__Internal")]
	double MapboxVersionNumber { get; }

	// extern const unsigned char [] MapboxVersionString __attribute__((visibility("default")));
	[Field ("MapboxVersionString", "__Internal")]
	byte[] MapboxVersionString { get; }
}

// @interface MGLAnnotationView : UIView <NSSecureCoding>
[BaseType (typeof(UIView))]
interface MGLAnnotationView : INSSecureCoding
{
	// -(instancetype _Nonnull)initWithReuseIdentifier:(NSString * _Nullable)reuseIdentifier;
	[Export ("initWithReuseIdentifier:")]
	IntPtr Constructor ([NullAllowed] string reuseIdentifier);

	// -(void)prepareForReuse;
	[Export ("prepareForReuse")]
	void PrepareForReuse ();

	// @property (nonatomic) id<MGLAnnotation> _Nullable annotation;
	[NullAllowed, Export ("annotation", ArgumentSemantic.Assign)]
	MGLAnnotation Annotation { get; set; }

	// @property (readonly, nonatomic) NSString * _Nullable reuseIdentifier;
	[NullAllowed, Export ("reuseIdentifier")]
	string ReuseIdentifier { get; }

	// @property (nonatomic) CGVector centerOffset;
	[Export ("centerOffset", ArgumentSemantic.Assign)]
	CGVector CenterOffset { get; set; }

	// @property (assign, nonatomic) BOOL scalesWithViewingDistance;
	[Export ("scalesWithViewingDistance")]
	bool ScalesWithViewingDistance { get; set; }

	// @property (getter = isSelected, assign, nonatomic) BOOL selected;
	[Export ("selected")]
	bool Selected { [Bind ("isSelected")] get; set; }

	// -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
	[Export ("setSelected:animated:")]
	void SetSelected (bool selected, bool animated);

	// @property (getter = isEnabled, assign, nonatomic) BOOL enabled;
	[Export ("enabled")]
	bool Enabled { [Bind ("isEnabled")] get; set; }

	// @property (getter = isDraggable, assign, nonatomic) BOOL draggable;
	[Export ("draggable")]
	bool Draggable { [Bind ("isDraggable")] get; set; }

	// @property (readonly, nonatomic) MGLAnnotationViewDragState dragState;
	[Export ("dragState")]
	MGLAnnotationViewDragState DragState { get; }

	// -(void)setDragState:(MGLAnnotationViewDragState)dragState animated:(BOOL)animated __attribute__((objc_requires_super));
	[Export ("setDragState:animated:")]
	[RequiresSuper]
	void SetDragState (MGLAnnotationViewDragState dragState, bool animated);
}

// @interface MGLAccountManager : NSObject
[BaseType (typeof(NSObject))]
interface MGLAccountManager
{
	// +(NSString * _Nullable)accessToken;
	// +(void)setAccessToken:(NSString * _Nullable)accessToken;
	[Static]
	[NullAllowed, Export ("accessToken")]
	[Verify (MethodToProperty)]
	string AccessToken { get; set; }

	// +(BOOL)mapboxMetricsEnabledSettingShownInApp __attribute__((deprecated("Telemetry settings are now always shown in the ℹ️ menu.")));
	[Static]
	[Export ("mapboxMetricsEnabledSettingShownInApp")]
	[Verify (MethodToProperty)]
	bool MapboxMetricsEnabledSettingShownInApp { get; }
}

// @protocol MGLAnnotation <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MGLAnnotation
{
	// @required @property (readonly, nonatomic) CLLocationCoordinate2D coordinate;
	[Abstract]
	[Export ("coordinate")]
	CLLocationCoordinate2D Coordinate { get; }

	// @optional @property (readonly, copy, nonatomic) NSString * _Nullable title;
	[NullAllowed, Export ("title")]
	string Title { get; }

	// @optional @property (readonly, copy, nonatomic) NSString * _Nullable subtitle;
	[NullAllowed, Export ("subtitle")]
	string Subtitle { get; }
}

// @interface MGLAnnotationImage : NSObject <NSSecureCoding>
[BaseType (typeof(NSObject))]
interface MGLAnnotationImage : INSSecureCoding
{
	// +(instancetype _Nonnull)annotationImageWithImage:(UIImage * _Nonnull)image reuseIdentifier:(NSString * _Nonnull)reuseIdentifier;
	[Static]
	[Export ("annotationImageWithImage:reuseIdentifier:")]
	MGLAnnotationImage AnnotationImageWithImage (UIImage image, string reuseIdentifier);

	// @property (nonatomic, strong) UIImage * _Nullable image;
	[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
	UIImage Image { get; set; }

	// @property (readonly, nonatomic) NSString * _Nonnull reuseIdentifier;
	[Export ("reuseIdentifier")]
	string ReuseIdentifier { get; }

	// @property (getter = isEnabled, nonatomic) BOOL enabled;
	[Export ("enabled")]
	bool Enabled { [Bind ("isEnabled")] get; set; }
}

// @protocol MGLCalloutView <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MGLCalloutView
{
	// @required @property (nonatomic, strong) id<MGLAnnotation> _Nonnull representedObject;
	[Abstract]
	[Export ("representedObject", ArgumentSemantic.Strong)]
	MGLAnnotation RepresentedObject { get; set; }

	// @required @property (nonatomic, strong) UIView * _Nonnull leftAccessoryView;
	[Abstract]
	[Export ("leftAccessoryView", ArgumentSemantic.Strong)]
	UIView LeftAccessoryView { get; set; }

	// @required @property (nonatomic, strong) UIView * _Nonnull rightAccessoryView;
	[Abstract]
	[Export ("rightAccessoryView", ArgumentSemantic.Strong)]
	UIView RightAccessoryView { get; set; }

	[Wrap ("WeakDelegate"), Abstract]
	[NullAllowed]
	MGLCalloutViewDelegate Delegate { get; set; }

	// @required @property (nonatomic, weak) id<MGLCalloutViewDelegate> _Nullable delegate;
	[Abstract]
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// @required -(void)presentCalloutFromRect:(CGRect)rect inView:(UIView * _Nonnull)view constrainedToView:(UIView * _Nonnull)constrainedView animated:(BOOL)animated;
	[Abstract]
	[Export ("presentCalloutFromRect:inView:constrainedToView:animated:")]
	void PresentCalloutFromRect (CGRect rect, UIView view, UIView constrainedView, bool animated);

	// @required -(void)dismissCalloutAnimated:(BOOL)animated;
	[Abstract]
	[Export ("dismissCalloutAnimated:")]
	void DismissCalloutAnimated (bool animated);

	// @optional @property (readonly, getter = isAnchoredToAnnotation, assign, nonatomic) BOOL anchoredToAnnotation;
	[Export ("anchoredToAnnotation")]
	bool AnchoredToAnnotation { [Bind ("isAnchoredToAnnotation")] get; }

	// @optional @property (readonly, assign, nonatomic) BOOL dismissesAutomatically;
	[Export ("dismissesAutomatically")]
	bool DismissesAutomatically { get; }
}

// @protocol MGLCalloutViewDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MGLCalloutViewDelegate
{
	// @optional -(BOOL)calloutViewShouldHighlight:(UIView<MGLCalloutView> * _Nonnull)calloutView;
	[Export ("calloutViewShouldHighlight:")]
	bool CalloutViewShouldHighlight (MGLCalloutView calloutView);

	// @optional -(void)calloutViewTapped:(UIView<MGLCalloutView> * _Nonnull)calloutView;
	[Export ("calloutViewTapped:")]
	void CalloutViewTapped (MGLCalloutView calloutView);

	// @optional -(void)calloutViewWillAppear:(UIView<MGLCalloutView> * _Nonnull)calloutView;
	[Export ("calloutViewWillAppear:")]
	void CalloutViewWillAppear (MGLCalloutView calloutView);

	// @optional -(void)calloutViewDidAppear:(UIView<MGLCalloutView> * _Nonnull)calloutView;
	[Export ("calloutViewDidAppear:")]
	void CalloutViewDidAppear (MGLCalloutView calloutView);
}

// @interface MGLClockDirectionFormatter : NSFormatter
[BaseType (typeof(NSFormatter))]
interface MGLClockDirectionFormatter
{
	// @property (nonatomic) NSFormattingUnitStyle unitStyle;
	[Export ("unitStyle", ArgumentSemantic.Assign)]
	NSFormattingUnitStyle UnitStyle { get; set; }

	// -(NSString * _Nonnull)stringFromDirection:(CLLocationDirection)direction;
	[Export ("stringFromDirection:")]
	string StringFromDirection (double direction);

	// -(BOOL)getObjectValue:(id  _Nullable * _Nullable)obj forString:(NSString * _Nonnull)string errorDescription:(NSString * _Nullable * _Nullable)error;
	[Export ("getObjectValue:forString:errorDescription:")]
	bool GetObjectValue ([NullAllowed] out NSObject obj, string @string, [NullAllowed] out string error);
}

// @interface MGLCompassDirectionFormatter : NSFormatter
[BaseType (typeof(NSFormatter))]
interface MGLCompassDirectionFormatter
{
	// @property (nonatomic) NSFormattingUnitStyle unitStyle;
	[Export ("unitStyle", ArgumentSemantic.Assign)]
	NSFormattingUnitStyle UnitStyle { get; set; }

	// -(NSString * _Nonnull)stringFromDirection:(CLLocationDirection)direction;
	[Export ("stringFromDirection:")]
	string StringFromDirection (double direction);

	// -(BOOL)getObjectValue:(id  _Nullable * _Nullable)obj forString:(NSString * _Nonnull)string errorDescription:(NSString * _Nullable * _Nullable)error;
	[Export ("getObjectValue:forString:errorDescription:")]
	bool GetObjectValue ([NullAllowed] out NSObject obj, string @string, [NullAllowed] out string error);
}

// @interface MGLCoordinateFormatter : NSFormatter
[BaseType (typeof(NSFormatter))]
interface MGLCoordinateFormatter
{
	// @property (nonatomic) BOOL allowsMinutes;
	[Export ("allowsMinutes")]
	bool AllowsMinutes { get; set; }

	// @property (nonatomic) BOOL allowsSeconds;
	[Export ("allowsSeconds")]
	bool AllowsSeconds { get; set; }

	// @property (nonatomic) NSFormattingUnitStyle unitStyle;
	[Export ("unitStyle", ArgumentSemantic.Assign)]
	NSFormattingUnitStyle UnitStyle { get; set; }

	// -(NSString * _Nonnull)stringFromCoordinate:(CLLocationCoordinate2D)coordinate;
	[Export ("stringFromCoordinate:")]
	string StringFromCoordinate (CLLocationCoordinate2D coordinate);

	// -(BOOL)getObjectValue:(id  _Nullable * _Nullable)obj forString:(NSString * _Nonnull)string errorDescription:(NSString * _Nullable * _Nullable)error;
	[Export ("getObjectValue:forString:errorDescription:")]
	bool GetObjectValue ([NullAllowed] out NSObject obj, string @string, [NullAllowed] out string error);
}

// @interface MGLDistanceFormatter : NSLengthFormatter
[BaseType (typeof(NSLengthFormatter))]
interface MGLDistanceFormatter
{
	// -(NSString * _Nonnull)stringFromDistance:(CLLocationDistance)distance;
	[Export ("stringFromDistance:")]
	string StringFromDistance (double distance);
}

// @interface MGLShape : NSObject <MGLAnnotation, NSSecureCoding>
[BaseType (typeof(NSObject))]
interface MGLShape : IMGLAnnotation, INSSecureCoding
{
	// +(MGLShape * _Nullable)shapeWithData:(NSData * _Nonnull)data encoding:(NSStringEncoding)encoding error:(NSError * _Nullable * _Nullable)outError;
	[Static]
	[Export ("shapeWithData:encoding:error:")]
	[return: NullAllowed]
	MGLShape ShapeWithData (NSData data, nuint encoding, [NullAllowed] out NSError outError);

	// @property (copy, nonatomic) NSString * _Nullable title;
	[NullAllowed, Export ("title")]
	string Title { get; set; }

	// @property (copy, nonatomic) NSString * _Nullable subtitle;
	[NullAllowed, Export ("subtitle")]
	string Subtitle { get; set; }

	// -(NSData * _Nonnull)geoJSONDataUsingEncoding:(NSStringEncoding)encoding;
	[Export ("geoJSONDataUsingEncoding:")]
	NSData GeoJSONDataUsingEncoding (nuint encoding);
}

// @interface MGLMultiPoint : MGLShape
[BaseType (typeof(MGLShape))]
interface MGLMultiPoint
{
	// @property (readonly, nonatomic) CLLocationCoordinate2D * _Nonnull coordinates __attribute__((objc_returns_inner_pointer));
	[Export ("coordinates")]
	unsafe CLLocationCoordinate2D* Coordinates { get; }

	// @property (readonly, nonatomic) NSUInteger pointCount;
	[Export ("pointCount")]
	nuint PointCount { get; }

	// -(void)getCoordinates:(CLLocationCoordinate2D * _Nonnull)coords range:(NSRange)range;
	[Export ("getCoordinates:range:")]
	unsafe void GetCoordinates (CLLocationCoordinate2D* coords, NSRange range);

	// -(void)setCoordinates:(CLLocationCoordinate2D * _Nonnull)coords count:(NSUInteger)count;
	[Export ("setCoordinates:count:")]
	unsafe void SetCoordinates (CLLocationCoordinate2D* coords, nuint count);

	// -(void)insertCoordinates:(const CLLocationCoordinate2D * _Nonnull)coords count:(NSUInteger)count atIndex:(NSUInteger)index;
	[Export ("insertCoordinates:count:atIndex:")]
	unsafe void InsertCoordinates (CLLocationCoordinate2D* coords, nuint count, nuint index);

	// -(void)appendCoordinates:(const CLLocationCoordinate2D * _Nonnull)coords count:(NSUInteger)count;
	[Export ("appendCoordinates:count:")]
	unsafe void AppendCoordinates (CLLocationCoordinate2D* coords, nuint count);

	// -(void)replaceCoordinatesInRange:(NSRange)range withCoordinates:(const CLLocationCoordinate2D * _Nonnull)coords;
	[Export ("replaceCoordinatesInRange:withCoordinates:")]
	unsafe void ReplaceCoordinatesInRange (NSRange range, CLLocationCoordinate2D* coords);

	// -(void)replaceCoordinatesInRange:(NSRange)range withCoordinates:(const CLLocationCoordinate2D * _Nonnull)coords count:(NSUInteger)count;
	[Export ("replaceCoordinatesInRange:withCoordinates:count:")]
	unsafe void ReplaceCoordinatesInRange (NSRange range, CLLocationCoordinate2D* coords, nuint count);

	// -(void)removeCoordinatesInRange:(NSRange)range;
	[Export ("removeCoordinatesInRange:")]
	void RemoveCoordinatesInRange (NSRange range);
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const MGLCoordinateSpan MGLCoordinateSpanZero __attribute__((visibility("default")));
	[Field ("MGLCoordinateSpanZero", "__Internal")]
	MGLCoordinateSpan MGLCoordinateSpanZero { get; }
}

// @protocol MGLOverlay <MGLAnnotation>
[Protocol, Model]
interface MGLOverlay : IMGLAnnotation
{
	// @required @property (readonly, nonatomic) CLLocationCoordinate2D coordinate;
	[Abstract]
	[Export ("coordinate")]
	CLLocationCoordinate2D Coordinate { get; }

	// @required @property (readonly, nonatomic) MGLCoordinateBounds overlayBounds;
	[Abstract]
	[Export ("overlayBounds")]
	MGLCoordinateBounds OverlayBounds { get; }

	// @required -(BOOL)intersectsOverlayBounds:(MGLCoordinateBounds)overlayBounds;
	[Abstract]
	[Export ("intersectsOverlayBounds:")]
	bool IntersectsOverlayBounds (MGLCoordinateBounds overlayBounds);
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const NSErrorDomain _Nonnull MGLErrorDomain __attribute__((visibility("default")));
	[Field ("MGLErrorDomain", "__Internal")]
	NSString MGLErrorDomain { get; }
}

// @interface MGLPolyline : MGLMultiPoint <MGLOverlay>
[BaseType (typeof(MGLMultiPoint))]
interface MGLPolyline : IMGLOverlay
{
	// +(instancetype _Nonnull)polylineWithCoordinates:(const CLLocationCoordinate2D * _Nonnull)coords count:(NSUInteger)count;
	[Static]
	[Export ("polylineWithCoordinates:count:")]
	unsafe MGLPolyline PolylineWithCoordinates (CLLocationCoordinate2D* coords, nuint count);
}

// @interface MGLMultiPolyline : MGLShape <MGLOverlay>
[BaseType (typeof(MGLShape))]
interface MGLMultiPolyline : IMGLOverlay
{
	// @property (readonly, copy, nonatomic) NSArray<MGLPolyline *> * _Nonnull polylines;
	[Export ("polylines", ArgumentSemantic.Copy)]
	MGLPolyline[] Polylines { get; }

	// +(instancetype _Nonnull)multiPolylineWithPolylines:(NSArray<MGLPolyline *> * _Nonnull)polylines;
	[Static]
	[Export ("multiPolylineWithPolylines:")]
	MGLMultiPolyline MultiPolylineWithPolylines (MGLPolyline[] polylines);
}

// @interface MGLPolygon : MGLMultiPoint <MGLOverlay>
[BaseType (typeof(MGLMultiPoint))]
interface MGLPolygon : IMGLOverlay
{
	// @property (readonly, nonatomic) NSArray<MGLPolygon *> * _Nullable interiorPolygons;
	[NullAllowed, Export ("interiorPolygons")]
	MGLPolygon[] InteriorPolygons { get; }

	// +(instancetype _Nonnull)polygonWithCoordinates:(const CLLocationCoordinate2D * _Nonnull)coords count:(NSUInteger)count;
	[Static]
	[Export ("polygonWithCoordinates:count:")]
	unsafe MGLPolygon PolygonWithCoordinates (CLLocationCoordinate2D* coords, nuint count);

	// +(instancetype _Nonnull)polygonWithCoordinates:(const CLLocationCoordinate2D * _Nonnull)coords count:(NSUInteger)count interiorPolygons:(NSArray<MGLPolygon *> * _Nullable)interiorPolygons;
	[Static]
	[Export ("polygonWithCoordinates:count:interiorPolygons:")]
	unsafe MGLPolygon PolygonWithCoordinates (CLLocationCoordinate2D* coords, nuint count, [NullAllowed] MGLPolygon[] interiorPolygons);
}

// @interface MGLMultiPolygon : MGLShape <MGLOverlay>
[BaseType (typeof(MGLShape))]
interface MGLMultiPolygon : IMGLOverlay
{
	// @property (readonly, copy, nonatomic) NSArray<MGLPolygon *> * _Nonnull polygons;
	[Export ("polygons", ArgumentSemantic.Copy)]
	MGLPolygon[] Polygons { get; }

	// +(instancetype _Nonnull)multiPolygonWithPolygons:(NSArray<MGLPolygon *> * _Nonnull)polygons;
	[Static]
	[Export ("multiPolygonWithPolygons:")]
	MGLMultiPolygon MultiPolygonWithPolygons (MGLPolygon[] polygons);
}

// @interface MGLPointAnnotation : MGLShape
[BaseType (typeof(MGLShape))]
interface MGLPointAnnotation
{
	// @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
	[Export ("coordinate", ArgumentSemantic.Assign)]
	CLLocationCoordinate2D Coordinate { get; set; }
}

// @interface MGLPointCollection : MGLShape <MGLOverlay>
[BaseType (typeof(MGLShape))]
interface MGLPointCollection : IMGLOverlay
{
	// +(instancetype)pointCollectionWithCoordinates:(const CLLocationCoordinate2D *)coords count:(NSUInteger)count;
	[Static]
	[Export ("pointCollectionWithCoordinates:count:")]
	unsafe MGLPointCollection PointCollectionWithCoordinates (CLLocationCoordinate2D* coords, nuint count);

	// @property (readonly, nonatomic) CLLocationCoordinate2D * coordinates __attribute__((objc_returns_inner_pointer));
	[Export ("coordinates")]
	unsafe CLLocationCoordinate2D* Coordinates { get; }

	// @property (readonly, nonatomic) NSUInteger pointCount;
	[Export ("pointCount")]
	nuint PointCount { get; }

	// -(void)getCoordinates:(CLLocationCoordinate2D *)coords range:(NSRange)range;
	[Export ("getCoordinates:range:")]
	unsafe void GetCoordinates (CLLocationCoordinate2D* coords, NSRange range);
}

// @interface MGLShapeCollection : MGLShape
[BaseType (typeof(MGLShape))]
interface MGLShapeCollection
{
	// @property (readonly, copy, nonatomic) NSArray<MGLShape *> * _Nonnull shapes;
	[Export ("shapes", ArgumentSemantic.Copy)]
	MGLShape[] Shapes { get; }

	// +(instancetype _Nonnull)shapeCollectionWithShapes:(NSArray<MGLShape *> * _Nonnull)shapes;
	[Static]
	[Export ("shapeCollectionWithShapes:")]
	MGLShapeCollection ShapeCollectionWithShapes (MGLShape[] shapes);
}

// @protocol MGLFeature <MGLAnnotation>
[Protocol, Model]
interface MGLFeature : IMGLAnnotation
{
	// @required @property (copy, nonatomic) id _Nullable identifier;
	[Abstract]
	[NullAllowed, Export ("identifier", ArgumentSemantic.Copy)]
	NSObject Identifier { get; set; }

	// @required @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull attributes;
	[Abstract]
	[Export ("attributes", ArgumentSemantic.Copy)]
	NSDictionary<NSString, NSObject> Attributes { get; set; }

	// @required -(id _Nullable)attributeForKey:(NSString * _Nonnull)key;
	[Abstract]
	[Export ("attributeForKey:")]
	[return: NullAllowed]
	NSObject AttributeForKey (string key);

	// @required -(NSDictionary<NSString *,id> * _Nonnull)geoJSONDictionary;
	[Abstract]
	[Export ("geoJSONDictionary")]
	[Verify (MethodToProperty)]
	NSDictionary<NSString, NSObject> GeoJSONDictionary { get; }
}

// @interface MGLPointFeature : MGLPointAnnotation <MGLFeature>
[BaseType (typeof(MGLPointAnnotation))]
interface MGLPointFeature : IMGLFeature
{
}

// @interface MGLPolylineFeature : MGLPolyline <MGLFeature>
[BaseType (typeof(MGLPolyline))]
interface MGLPolylineFeature : IMGLFeature
{
}

// @interface MGLPolygonFeature : MGLPolygon <MGLFeature>
[BaseType (typeof(MGLPolygon))]
interface MGLPolygonFeature : IMGLFeature
{
}

// @interface MGLPointCollectionFeature : MGLPointCollection <MGLFeature>
[BaseType (typeof(MGLPointCollection))]
interface MGLPointCollectionFeature : IMGLFeature
{
}

// @interface MGLMultiPolylineFeature : MGLMultiPolyline <MGLFeature>
[BaseType (typeof(MGLMultiPolyline))]
interface MGLMultiPolylineFeature : IMGLFeature
{
}

// @interface MGLMultiPolygonFeature : MGLMultiPolygon <MGLFeature>
[BaseType (typeof(MGLMultiPolygon))]
interface MGLMultiPolygonFeature : IMGLFeature
{
}

// @interface MGLShapeCollectionFeature : MGLShapeCollection <MGLFeature>
[BaseType (typeof(MGLShapeCollection))]
interface MGLShapeCollectionFeature : IMGLFeature
{
	// @property (readonly, copy, nonatomic) NSArray<MGLShape<MGLFeature> *> * _Nonnull shapes;
	[Export ("shapes", ArgumentSemantic.Copy)]
	MGLFeature[] Shapes { get; }

	// +(instancetype _Nonnull)shapeCollectionWithShapes:(NSArray<MGLShape<MGLFeature> *> * _Nonnull)shapes;
	[Static]
	[Export ("shapeCollectionWithShapes:")]
	MGLShapeCollectionFeature ShapeCollectionWithShapes (MGLFeature[] shapes);
}

// @interface MGLMapCamera : NSObject <NSSecureCoding, NSCopying>
[BaseType (typeof(NSObject))]
interface MGLMapCamera : INSSecureCoding, INSCopying
{
	// @property (nonatomic) CLLocationCoordinate2D centerCoordinate;
	[Export ("centerCoordinate", ArgumentSemantic.Assign)]
	CLLocationCoordinate2D CenterCoordinate { get; set; }

	// @property (nonatomic) CLLocationDirection heading;
	[Export ("heading")]
	double Heading { get; set; }

	// @property (nonatomic) CGFloat pitch;
	[Export ("pitch")]
	nfloat Pitch { get; set; }

	// @property (nonatomic) CLLocationDistance altitude;
	[Export ("altitude")]
	double Altitude { get; set; }

	// +(instancetype _Nonnull)camera;
	[Static]
	[Export ("camera")]
	MGLMapCamera Camera ();

	// +(instancetype _Nonnull)cameraLookingAtCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate fromEyeCoordinate:(CLLocationCoordinate2D)eyeCoordinate eyeAltitude:(CLLocationDistance)eyeAltitude;
	[Static]
	[Export ("cameraLookingAtCenterCoordinate:fromEyeCoordinate:eyeAltitude:")]
	MGLMapCamera CameraLookingAtCenterCoordinate (CLLocationCoordinate2D centerCoordinate, CLLocationCoordinate2D eyeCoordinate, double eyeAltitude);

	// +(instancetype _Nonnull)cameraLookingAtCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate fromDistance:(CLLocationDistance)distance pitch:(CGFloat)pitch heading:(CLLocationDirection)heading;
	[Static]
	[Export ("cameraLookingAtCenterCoordinate:fromDistance:pitch:heading:")]
	MGLMapCamera CameraLookingAtCenterCoordinate (CLLocationCoordinate2D centerCoordinate, double distance, nfloat pitch, double heading);

	// -(BOOL)isEqualToMapCamera:(MGLMapCamera * _Nonnull)otherCamera;
	[Export ("isEqualToMapCamera:")]
	bool IsEqualToMapCamera (MGLMapCamera otherCamera);
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const CGFloat MGLMapViewDecelerationRateNormal;
	[Field ("MGLMapViewDecelerationRateNormal", "__Internal")]
	nfloat MGLMapViewDecelerationRateNormal { get; }

	// extern const CGFloat MGLMapViewDecelerationRateFast;
	[Field ("MGLMapViewDecelerationRateFast", "__Internal")]
	nfloat MGLMapViewDecelerationRateFast { get; }

	// extern const CGFloat MGLMapViewDecelerationRateImmediate;
	[Field ("MGLMapViewDecelerationRateImmediate", "__Internal")]
	nfloat MGLMapViewDecelerationRateImmediate { get; }
}

// @interface MGLMapView : UIView
[BaseType (typeof(UIView))]
interface MGLMapView
{
	// -(instancetype _Nonnull)initWithFrame:(CGRect)frame;
	[Export ("initWithFrame:")]
	IntPtr Constructor (CGRect frame);

	// -(instancetype _Nonnull)initWithFrame:(CGRect)frame styleURL:(NSURL * _Nullable)styleURL;
	[Export ("initWithFrame:styleURL:")]
	IntPtr Constructor (CGRect frame, [NullAllowed] NSUrl styleURL);

	[Wrap ("WeakDelegate")]
	[NullAllowed]
	MGLMapViewDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<MGLMapViewDelegate> _Nullable delegate __attribute__((iboutlet));
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// @property (readonly, nonatomic) MGLStyle * _Nullable style;
	[NullAllowed, Export ("style")]
	MGLStyle Style { get; }

	// @property (readonly, nonatomic) NSArray<NSURL *> * _Nonnull bundledStyleURLs __attribute__((deprecated("Call the relevant class method of MGLStyle for the URL of a particular default style.")));
	[Export ("bundledStyleURLs")]
	NSUrl[] BundledStyleURLs { get; }

	// @property (nonatomic) NSURL * _Null_unspecified styleURL;
	[Export ("styleURL", ArgumentSemantic.Assign)]
	NSUrl StyleURL { get; set; }

	// -(void)reloadStyle:(id _Nonnull)sender __attribute__((ibaction));
	[Export ("reloadStyle:")]
	void ReloadStyle (NSObject sender);

	// @property (readonly, nonatomic) UIImageView * _Nonnull compassView;
	[Export ("compassView")]
	UIImageView CompassView { get; }

	// @property (readonly, nonatomic) UIImageView * _Nonnull logoView;
	[Export ("logoView")]
	UIImageView LogoView { get; }

	// @property (readonly, nonatomic) UIButton * _Nonnull attributionButton;
	[Export ("attributionButton")]
	UIButton AttributionButton { get; }

	// @property (nonatomic) NSArray<NSString *> * _Nonnull styleClasses __attribute__((deprecated("Use style.styleClasses.")));
	[Export ("styleClasses", ArgumentSemantic.Assign)]
	string[] StyleClasses { get; set; }

	// -(BOOL)hasStyleClass:(NSString * _Nonnull)styleClass __attribute__((deprecated("Use style.hasStyleClass:.")));
	[Export ("hasStyleClass:")]
	bool HasStyleClass (string styleClass);

	// -(void)addStyleClass:(NSString * _Nonnull)styleClass __attribute__((deprecated("Use style.addStyleClass:.")));
	[Export ("addStyleClass:")]
	void AddStyleClass (string styleClass);

	// -(void)removeStyleClass:(NSString * _Nonnull)styleClass __attribute__((deprecated("Use style.removeStyleClass:.")));
	[Export ("removeStyleClass:")]
	void RemoveStyleClass (string styleClass);

	// @property (assign, nonatomic) BOOL showsUserLocation;
	[Export ("showsUserLocation")]
	bool ShowsUserLocation { get; set; }

	// @property (readonly, getter = isUserLocationVisible, assign, nonatomic) BOOL userLocationVisible;
	[Export ("userLocationVisible")]
	bool UserLocationVisible { [Bind ("isUserLocationVisible")] get; }

	// @property (readonly, nonatomic) MGLUserLocation * _Nullable userLocation;
	[NullAllowed, Export ("userLocation")]
	MGLUserLocation UserLocation { get; }

	// @property (assign, nonatomic) MGLUserTrackingMode userTrackingMode;
	[Export ("userTrackingMode", ArgumentSemantic.Assign)]
	MGLUserTrackingMode UserTrackingMode { get; set; }

	// -(void)setUserTrackingMode:(MGLUserTrackingMode)mode animated:(BOOL)animated;
	[Export ("setUserTrackingMode:animated:")]
	void SetUserTrackingMode (MGLUserTrackingMode mode, bool animated);

	// @property (assign, nonatomic) MGLAnnotationVerticalAlignment userLocationVerticalAlignment;
	[Export ("userLocationVerticalAlignment", ArgumentSemantic.Assign)]
	MGLAnnotationVerticalAlignment UserLocationVerticalAlignment { get; set; }

	// -(void)setUserLocationVerticalAlignment:(MGLAnnotationVerticalAlignment)alignment animated:(BOOL)animated;
	[Export ("setUserLocationVerticalAlignment:animated:")]
	void SetUserLocationVerticalAlignment (MGLAnnotationVerticalAlignment alignment, bool animated);

	// @property (assign, nonatomic) BOOL displayHeadingCalibration;
	[Export ("displayHeadingCalibration")]
	bool DisplayHeadingCalibration { get; set; }

	// @property (assign, nonatomic) CLLocationCoordinate2D targetCoordinate;
	[Export ("targetCoordinate", ArgumentSemantic.Assign)]
	CLLocationCoordinate2D TargetCoordinate { get; set; }

	// -(void)setTargetCoordinate:(CLLocationCoordinate2D)targetCoordinate animated:(BOOL)animated;
	[Export ("setTargetCoordinate:animated:")]
	void SetTargetCoordinate (CLLocationCoordinate2D targetCoordinate, bool animated);

	// @property (getter = isZoomEnabled, nonatomic) BOOL zoomEnabled;
	[Export ("zoomEnabled")]
	bool ZoomEnabled { [Bind ("isZoomEnabled")] get; set; }

	// @property (getter = isScrollEnabled, nonatomic) BOOL scrollEnabled;
	[Export ("scrollEnabled")]
	bool ScrollEnabled { [Bind ("isScrollEnabled")] get; set; }

	// @property (getter = isRotateEnabled, nonatomic) BOOL rotateEnabled;
	[Export ("rotateEnabled")]
	bool RotateEnabled { [Bind ("isRotateEnabled")] get; set; }

	// @property (getter = isPitchEnabled, nonatomic) BOOL pitchEnabled;
	[Export ("pitchEnabled")]
	bool PitchEnabled { [Bind ("isPitchEnabled")] get; set; }

	// @property (nonatomic) CGFloat decelerationRate;
	[Export ("decelerationRate")]
	nfloat DecelerationRate { get; set; }

	// @property (nonatomic) CLLocationCoordinate2D centerCoordinate;
	[Export ("centerCoordinate", ArgumentSemantic.Assign)]
	CLLocationCoordinate2D CenterCoordinate { get; set; }

	// -(void)setCenterCoordinate:(CLLocationCoordinate2D)coordinate animated:(BOOL)animated;
	[Export ("setCenterCoordinate:animated:")]
	void SetCenterCoordinate (CLLocationCoordinate2D coordinate, bool animated);

	// -(void)setCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate zoomLevel:(double)zoomLevel animated:(BOOL)animated;
	[Export ("setCenterCoordinate:zoomLevel:animated:")]
	void SetCenterCoordinate (CLLocationCoordinate2D centerCoordinate, double zoomLevel, bool animated);

	// -(void)setCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate zoomLevel:(double)zoomLevel direction:(CLLocationDirection)direction animated:(BOOL)animated;
	[Export ("setCenterCoordinate:zoomLevel:direction:animated:")]
	void SetCenterCoordinate (CLLocationCoordinate2D centerCoordinate, double zoomLevel, double direction, bool animated);

	// -(void)setCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate zoomLevel:(double)zoomLevel direction:(CLLocationDirection)direction animated:(BOOL)animated completionHandler:(void (^ _Nullable)(void))completion;
	[Export ("setCenterCoordinate:zoomLevel:direction:animated:completionHandler:")]
	void SetCenterCoordinate (CLLocationCoordinate2D centerCoordinate, double zoomLevel, double direction, bool animated, [NullAllowed] Action completion);

	// @property (nonatomic) double zoomLevel;
	[Export ("zoomLevel")]
	double ZoomLevel { get; set; }

	// -(void)setZoomLevel:(double)zoomLevel animated:(BOOL)animated;
	[Export ("setZoomLevel:animated:")]
	void SetZoomLevel (double zoomLevel, bool animated);

	// @property (nonatomic) double minimumZoomLevel;
	[Export ("minimumZoomLevel")]
	double MinimumZoomLevel { get; set; }

	// @property (nonatomic) double maximumZoomLevel;
	[Export ("maximumZoomLevel")]
	double MaximumZoomLevel { get; set; }

	// @property (nonatomic) CLLocationDirection direction;
	[Export ("direction")]
	double Direction { get; set; }

	// -(void)setDirection:(CLLocationDirection)direction animated:(BOOL)animated;
	[Export ("setDirection:animated:")]
	void SetDirection (double direction, bool animated);

	// -(void)resetNorth __attribute__((ibaction));
	[Export ("resetNorth")]
	void ResetNorth ();

	// -(void)resetPosition __attribute__((ibaction));
	[Export ("resetPosition")]
	void ResetPosition ();

	// @property (nonatomic) MGLCoordinateBounds visibleCoordinateBounds;
	[Export ("visibleCoordinateBounds", ArgumentSemantic.Assign)]
	MGLCoordinateBounds VisibleCoordinateBounds { get; set; }

	// -(void)setVisibleCoordinateBounds:(MGLCoordinateBounds)bounds animated:(BOOL)animated;
	[Export ("setVisibleCoordinateBounds:animated:")]
	void SetVisibleCoordinateBounds (MGLCoordinateBounds bounds, bool animated);

	// -(void)setVisibleCoordinateBounds:(MGLCoordinateBounds)bounds edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
	[Export ("setVisibleCoordinateBounds:edgePadding:animated:")]
	void SetVisibleCoordinateBounds (MGLCoordinateBounds bounds, UIEdgeInsets insets, bool animated);

	// -(void)setVisibleCoordinates:(const CLLocationCoordinate2D * _Nonnull)coordinates count:(NSUInteger)count edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
	[Export ("setVisibleCoordinates:count:edgePadding:animated:")]
	unsafe void SetVisibleCoordinates (CLLocationCoordinate2D* coordinates, nuint count, UIEdgeInsets insets, bool animated);

	// -(void)setVisibleCoordinates:(const CLLocationCoordinate2D * _Nonnull)coordinates count:(NSUInteger)count edgePadding:(UIEdgeInsets)insets direction:(CLLocationDirection)direction duration:(NSTimeInterval)duration animationTimingFunction:(CAMediaTimingFunction * _Nullable)function completionHandler:(void (^ _Nullable)(void))completion;
	[Export ("setVisibleCoordinates:count:edgePadding:direction:duration:animationTimingFunction:completionHandler:")]
	unsafe void SetVisibleCoordinates (CLLocationCoordinate2D* coordinates, nuint count, UIEdgeInsets insets, double direction, double duration, [NullAllowed] CAMediaTimingFunction function, [NullAllowed] Action completion);

	// -(void)showAnnotations:(NSArray<id<MGLAnnotation>> * _Nonnull)annotations animated:(BOOL)animated;
	[Export ("showAnnotations:animated:")]
	void ShowAnnotations (MGLAnnotation[] annotations, bool animated);

	// -(void)showAnnotations:(NSArray<id<MGLAnnotation>> * _Nonnull)annotations edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
	[Export ("showAnnotations:edgePadding:animated:")]
	void ShowAnnotations (MGLAnnotation[] annotations, UIEdgeInsets insets, bool animated);

	// @property (copy, nonatomic) MGLMapCamera * _Nonnull camera;
	[Export ("camera", ArgumentSemantic.Copy)]
	MGLMapCamera Camera { get; set; }

	// -(void)setCamera:(MGLMapCamera * _Nonnull)camera animated:(BOOL)animated;
	[Export ("setCamera:animated:")]
	void SetCamera (MGLMapCamera camera, bool animated);

	// -(void)setCamera:(MGLMapCamera * _Nonnull)camera withDuration:(NSTimeInterval)duration animationTimingFunction:(CAMediaTimingFunction * _Nullable)function;
	[Export ("setCamera:withDuration:animationTimingFunction:")]
	void SetCamera (MGLMapCamera camera, double duration, [NullAllowed] CAMediaTimingFunction function);

	// -(void)setCamera:(MGLMapCamera * _Nonnull)camera withDuration:(NSTimeInterval)duration animationTimingFunction:(CAMediaTimingFunction * _Nullable)function completionHandler:(void (^ _Nullable)(void))completion;
	[Export ("setCamera:withDuration:animationTimingFunction:completionHandler:")]
	void SetCamera (MGLMapCamera camera, double duration, [NullAllowed] CAMediaTimingFunction function, [NullAllowed] Action completion);

	// -(void)flyToCamera:(MGLMapCamera * _Nonnull)camera completionHandler:(void (^ _Nullable)(void))completion;
	[Export ("flyToCamera:completionHandler:")]
	void FlyToCamera (MGLMapCamera camera, [NullAllowed] Action completion);

	// -(void)flyToCamera:(MGLMapCamera * _Nonnull)camera withDuration:(NSTimeInterval)duration completionHandler:(void (^ _Nullable)(void))completion;
	[Export ("flyToCamera:withDuration:completionHandler:")]
	void FlyToCamera (MGLMapCamera camera, double duration, [NullAllowed] Action completion);

	// -(void)flyToCamera:(MGLMapCamera * _Nonnull)camera withDuration:(NSTimeInterval)duration peakAltitude:(CLLocationDistance)peakAltitude completionHandler:(void (^ _Nullable)(void))completion;
	[Export ("flyToCamera:withDuration:peakAltitude:completionHandler:")]
	void FlyToCamera (MGLMapCamera camera, double duration, double peakAltitude, [NullAllowed] Action completion);

	// -(MGLMapCamera * _Nonnull)cameraThatFitsCoordinateBounds:(MGLCoordinateBounds)bounds;
	[Export ("cameraThatFitsCoordinateBounds:")]
	MGLMapCamera CameraThatFitsCoordinateBounds (MGLCoordinateBounds bounds);

	// -(MGLMapCamera * _Nonnull)cameraThatFitsCoordinateBounds:(MGLCoordinateBounds)bounds edgePadding:(UIEdgeInsets)insets;
	[Export ("cameraThatFitsCoordinateBounds:edgePadding:")]
	MGLMapCamera CameraThatFitsCoordinateBounds (MGLCoordinateBounds bounds, UIEdgeInsets insets);

	// -(CGPoint)anchorPointForGesture:(UIGestureRecognizer * _Nonnull)gesture;
	[Export ("anchorPointForGesture:")]
	CGPoint AnchorPointForGesture (UIGestureRecognizer gesture);

	// @property (assign, nonatomic) UIEdgeInsets contentInset;
	[Export ("contentInset", ArgumentSemantic.Assign)]
	UIEdgeInsets ContentInset { get; set; }

	// -(void)setContentInset:(UIEdgeInsets)contentInset animated:(BOOL)animated;
	[Export ("setContentInset:animated:")]
	void SetContentInset (UIEdgeInsets contentInset, bool animated);

	// -(CLLocationCoordinate2D)convertPoint:(CGPoint)point toCoordinateFromView:(UIView * _Nullable)view;
	[Export ("convertPoint:toCoordinateFromView:")]
	CLLocationCoordinate2D ConvertPoint (CGPoint point, [NullAllowed] UIView view);

	// -(CGPoint)convertCoordinate:(CLLocationCoordinate2D)coordinate toPointToView:(UIView * _Nullable)view;
	[Export ("convertCoordinate:toPointToView:")]
	CGPoint ConvertCoordinate (CLLocationCoordinate2D coordinate, [NullAllowed] UIView view);

	// -(MGLCoordinateBounds)convertRect:(CGRect)rect toCoordinateBoundsFromView:(UIView * _Nullable)view;
	[Export ("convertRect:toCoordinateBoundsFromView:")]
	MGLCoordinateBounds ConvertRect (CGRect rect, [NullAllowed] UIView view);

	// -(CGRect)convertCoordinateBounds:(MGLCoordinateBounds)bounds toRectToView:(UIView * _Nullable)view;
	[Export ("convertCoordinateBounds:toRectToView:")]
	CGRect ConvertCoordinateBounds (MGLCoordinateBounds bounds, [NullAllowed] UIView view);

	// -(CLLocationDistance)metersPerPointAtLatitude:(CLLocationDegrees)latitude;
	[Export ("metersPerPointAtLatitude:")]
	double MetersPerPointAtLatitude (double latitude);

	// -(CLLocationDistance)metersPerPixelAtLatitude:(CLLocationDegrees)latitude __attribute__((deprecated("Use -metersPerPointAtLatitude:.")));
	[Export ("metersPerPixelAtLatitude:")]
	double MetersPerPixelAtLatitude (double latitude);

	// @property (readonly, nonatomic) NSArray<id<MGLAnnotation>> * _Nullable annotations;
	[NullAllowed, Export ("annotations")]
	MGLAnnotation[] Annotations { get; }

	// @property (readonly, nonatomic) NSArray<id<MGLAnnotation>> * _Nullable visibleAnnotations;
	[NullAllowed, Export ("visibleAnnotations")]
	MGLAnnotation[] VisibleAnnotations { get; }

	// -(void)addAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
	[Export ("addAnnotation:")]
	void AddAnnotation (MGLAnnotation annotation);

	// -(void)addAnnotations:(NSArray<id<MGLAnnotation>> * _Nonnull)annotations;
	[Export ("addAnnotations:")]
	void AddAnnotations (MGLAnnotation[] annotations);

	// -(void)removeAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
	[Export ("removeAnnotation:")]
	void RemoveAnnotation (MGLAnnotation annotation);

	// -(void)removeAnnotations:(NSArray<id<MGLAnnotation>> * _Nonnull)annotations;
	[Export ("removeAnnotations:")]
	void RemoveAnnotations (MGLAnnotation[] annotations);

	// -(MGLAnnotationView * _Nullable)viewForAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
	[Export ("viewForAnnotation:")]
	[return: NullAllowed]
	MGLAnnotationView ViewForAnnotation (MGLAnnotation annotation);

	// -(__kindof MGLAnnotationImage * _Nullable)dequeueReusableAnnotationImageWithIdentifier:(NSString * _Nonnull)identifier;
	[Export ("dequeueReusableAnnotationImageWithIdentifier:")]
	MGLAnnotationImage DequeueReusableAnnotationImageWithIdentifier (string identifier);

	// -(__kindof MGLAnnotationView * _Nullable)dequeueReusableAnnotationViewWithIdentifier:(NSString * _Nonnull)identifier;
	[Export ("dequeueReusableAnnotationViewWithIdentifier:")]
	MGLAnnotationView DequeueReusableAnnotationViewWithIdentifier (string identifier);

	// -(NSArray<id<MGLAnnotation>> * _Nullable)visibleAnnotationsInRect:(CGRect)rect;
	[Export ("visibleAnnotationsInRect:")]
	[return: NullAllowed]
	MGLAnnotation[] VisibleAnnotationsInRect (CGRect rect);

	// @property (copy, nonatomic) NSArray<id<MGLAnnotation>> * _Nonnull selectedAnnotations;
	[Export ("selectedAnnotations", ArgumentSemantic.Copy)]
	MGLAnnotation[] SelectedAnnotations { get; set; }

	// -(void)selectAnnotation:(id<MGLAnnotation> _Nonnull)annotation animated:(BOOL)animated;
	[Export ("selectAnnotation:animated:")]
	void SelectAnnotation (MGLAnnotation annotation, bool animated);

	// -(void)deselectAnnotation:(id<MGLAnnotation> _Nullable)annotation animated:(BOOL)animated;
	[Export ("deselectAnnotation:animated:")]
	void DeselectAnnotation ([NullAllowed] MGLAnnotation annotation, bool animated);

	// -(void)addOverlay:(id<MGLOverlay> _Nonnull)overlay;
	[Export ("addOverlay:")]
	void AddOverlay (MGLOverlay overlay);

	// -(void)addOverlays:(NSArray<id<MGLOverlay>> * _Nonnull)overlays;
	[Export ("addOverlays:")]
	void AddOverlays (MGLOverlay[] overlays);

	// -(void)removeOverlay:(id<MGLOverlay> _Nonnull)overlay;
	[Export ("removeOverlay:")]
	void RemoveOverlay (MGLOverlay overlay);

	// -(void)removeOverlays:(NSArray<id<MGLOverlay>> * _Nonnull)overlays;
	[Export ("removeOverlays:")]
	void RemoveOverlays (MGLOverlay[] overlays);

	// -(NSArray<id<MGLFeature>> * _Nonnull)visibleFeaturesAtPoint:(CGPoint)point;
	[Export ("visibleFeaturesAtPoint:")]
	MGLFeature[] VisibleFeaturesAtPoint (CGPoint point);

	// -(NSArray<id<MGLFeature>> * _Nonnull)visibleFeaturesAtPoint:(CGPoint)point inStyleLayersWithIdentifiers:(NSSet<NSString *> * _Nullable)styleLayerIdentifiers;
	[Export ("visibleFeaturesAtPoint:inStyleLayersWithIdentifiers:")]
	MGLFeature[] VisibleFeaturesAtPoint (CGPoint point, [NullAllowed] NSSet<NSString> styleLayerIdentifiers);

	// -(NSArray<id<MGLFeature>> * _Nonnull)visibleFeaturesAtPoint:(CGPoint)point inStyleLayersWithIdentifiers:(NSSet<NSString *> * _Nullable)styleLayerIdentifiers predicate:(NSPredicate * _Nullable)predicate;
	[Export ("visibleFeaturesAtPoint:inStyleLayersWithIdentifiers:predicate:")]
	MGLFeature[] VisibleFeaturesAtPoint (CGPoint point, [NullAllowed] NSSet<NSString> styleLayerIdentifiers, [NullAllowed] NSPredicate predicate);

	// -(NSArray<id<MGLFeature>> * _Nonnull)visibleFeaturesInRect:(CGRect)rect;
	[Export ("visibleFeaturesInRect:")]
	MGLFeature[] VisibleFeaturesInRect (CGRect rect);

	// -(NSArray<id<MGLFeature>> * _Nonnull)visibleFeaturesInRect:(CGRect)rect inStyleLayersWithIdentifiers:(NSSet<NSString *> * _Nullable)styleLayerIdentifiers;
	[Export ("visibleFeaturesInRect:inStyleLayersWithIdentifiers:")]
	MGLFeature[] VisibleFeaturesInRect (CGRect rect, [NullAllowed] NSSet<NSString> styleLayerIdentifiers);

	// -(NSArray<id<MGLFeature>> * _Nonnull)visibleFeaturesInRect:(CGRect)rect inStyleLayersWithIdentifiers:(NSSet<NSString *> * _Nullable)styleLayerIdentifiers predicate:(NSPredicate * _Nullable)predicate;
	[Export ("visibleFeaturesInRect:inStyleLayersWithIdentifiers:predicate:")]
	MGLFeature[] VisibleFeaturesInRect (CGRect rect, [NullAllowed] NSSet<NSString> styleLayerIdentifiers, [NullAllowed] NSPredicate predicate);

	// @property (nonatomic) MGLMapDebugMaskOptions debugMask;
	[Export ("debugMask", ArgumentSemantic.Assign)]
	MGLMapDebugMaskOptions DebugMask { get; set; }

	// @property (getter = isDebugActive, nonatomic) BOOL debugActive __attribute__((deprecated("Use -debugMask and -setDebugMask:.")));
	[Export ("debugActive")]
	bool DebugActive { [Bind ("isDebugActive")] get; set; }

	// -(void)toggleDebug __attribute__((deprecated("Use -setDebugMask:.")));
	[Export ("toggleDebug")]
	void ToggleDebug ();

	// -(void)emptyMemoryCache __attribute__((deprecated("")));
	[Export ("emptyMemoryCache")]
	void EmptyMemoryCache ();
}

// @interface IBAdditions (MGLMapView)
[Category]
[BaseType (typeof(MGLMapView))]
interface MGLMapView_IBAdditions
{
	// @property (nonatomic) double latitude;
	[Export ("latitude")]
	double Latitude { get; set; }

	// @property (nonatomic) double longitude;
	[Export ("longitude")]
	double Longitude { get; set; }

	// @property (nonatomic) double zoomLevel;
	[Export ("zoomLevel")]
	double ZoomLevel { get; set; }

	// @property (nonatomic) BOOL allowsZooming;
	[Export ("allowsZooming")]
	bool AllowsZooming { get; set; }

	// @property (nonatomic) BOOL allowsScrolling;
	[Export ("allowsScrolling")]
	bool AllowsScrolling { get; set; }

	// @property (nonatomic) BOOL allowsRotating;
	[Export ("allowsRotating")]
	bool AllowsRotating { get; set; }

	// @property (nonatomic) BOOL allowsTilting;
	[Export ("allowsTilting")]
	bool AllowsTilting { get; set; }

	// @property (nonatomic) BOOL showsUserLocation;
	[Export ("showsUserLocation")]
	bool ShowsUserLocation { get; set; }
}

// @protocol MGLMapViewDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MGLMapViewDelegate
{
	// @optional -(void)mapView:(MGLMapView * _Nonnull)mapView regionWillChangeAnimated:(BOOL)animated;
	[Export ("mapView:regionWillChangeAnimated:")]
	void MapView (MGLMapView mapView, bool animated);

	// @optional -(void)mapViewRegionIsChanging:(MGLMapView * _Nonnull)mapView;
	[Export ("mapViewRegionIsChanging:")]
	void MapViewRegionIsChanging (MGLMapView mapView);

	// @optional -(void)mapView:(MGLMapView * _Nonnull)mapView regionDidChangeAnimated:(BOOL)animated;
	[Export ("mapView:regionDidChangeAnimated:")]
	void MapView (MGLMapView mapView, bool animated);

	// @optional -(BOOL)mapView:(MGLMapView * _Nonnull)mapView shouldChangeFromCamera:(MGLMapCamera * _Nonnull)oldCamera toCamera:(MGLMapCamera * _Nonnull)newCamera;
	[Export ("mapView:shouldChangeFromCamera:toCamera:")]
	bool MapView (MGLMapView mapView, MGLMapCamera oldCamera, MGLMapCamera newCamera);

	// @optional -(void)mapViewWillStartLoadingMap:(MGLMapView * _Nonnull)mapView;
	[Export ("mapViewWillStartLoadingMap:")]
	void MapViewWillStartLoadingMap (MGLMapView mapView);

	// @optional -(void)mapViewDidFinishLoadingMap:(MGLMapView * _Nonnull)mapView;
	[Export ("mapViewDidFinishLoadingMap:")]
	void MapViewDidFinishLoadingMap (MGLMapView mapView);

	// @optional -(void)mapViewDidFailLoadingMap:(MGLMapView * _Nonnull)mapView withError:(NSError * _Nonnull)error;
	[Export ("mapViewDidFailLoadingMap:withError:")]
	void MapViewDidFailLoadingMap (MGLMapView mapView, NSError error);

	// @optional -(void)mapViewWillStartRenderingMap:(MGLMapView * _Nonnull)mapView;
	[Export ("mapViewWillStartRenderingMap:")]
	void MapViewWillStartRenderingMap (MGLMapView mapView);

	// @optional -(void)mapViewDidFinishRenderingMap:(MGLMapView * _Nonnull)mapView fullyRendered:(BOOL)fullyRendered;
	[Export ("mapViewDidFinishRenderingMap:fullyRendered:")]
	void MapViewDidFinishRenderingMap (MGLMapView mapView, bool fullyRendered);

	// @optional -(void)mapViewWillStartRenderingFrame:(MGLMapView * _Nonnull)mapView;
	[Export ("mapViewWillStartRenderingFrame:")]
	void MapViewWillStartRenderingFrame (MGLMapView mapView);

	// @optional -(void)mapViewDidFinishRenderingFrame:(MGLMapView * _Nonnull)mapView fullyRendered:(BOOL)fullyRendered;
	[Export ("mapViewDidFinishRenderingFrame:fullyRendered:")]
	void MapViewDidFinishRenderingFrame (MGLMapView mapView, bool fullyRendered);

	// @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didFinishLoadingStyle:(MGLStyle * _Nonnull)style;
	[Export ("mapView:didFinishLoadingStyle:")]
	void MapView (MGLMapView mapView, MGLStyle style);

	// @optional -(void)mapViewWillStartLocatingUser:(MGLMapView * _Nonnull)mapView;
	[Export ("mapViewWillStartLocatingUser:")]
	void MapViewWillStartLocatingUser (MGLMapView mapView);

	// @optional -(void)mapViewDidStopLocatingUser:(MGLMapView * _Nonnull)mapView;
	[Export ("mapViewDidStopLocatingUser:")]
	void MapViewDidStopLocatingUser (MGLMapView mapView);

	// @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didUpdateUserLocation:(MGLUserLocation * _Nullable)userLocation;
	[Export ("mapView:didUpdateUserLocation:")]
	void MapView (MGLMapView mapView, [NullAllowed] MGLUserLocation userLocation);

	// @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didFailToLocateUserWithError:(NSError * _Nonnull)error;
	[Export ("mapView:didFailToLocateUserWithError:")]
	void MapView (MGLMapView mapView, NSError error);

	// @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didChangeUserTrackingMode:(MGLUserTrackingMode)mode animated:(BOOL)animated;
	[Export ("mapView:didChangeUserTrackingMode:animated:")]
	void MapView (MGLMapView mapView, MGLUserTrackingMode mode, bool animated);

	// @optional -(MGLAnnotationImage * _Nullable)mapView:(MGLMapView * _Nonnull)mapView imageForAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
	[Export ("mapView:imageForAnnotation:")]
	[return: NullAllowed]
	MGLAnnotationImage MapView (MGLMapView mapView, MGLAnnotation annotation);

	// @optional -(CGFloat)mapView:(MGLMapView * _Nonnull)mapView alphaForShapeAnnotation:(MGLShape * _Nonnull)annotation;
	[Export ("mapView:alphaForShapeAnnotation:")]
	nfloat MapView (MGLMapView mapView, MGLShape annotation);

	// @optional -(UIColor * _Nonnull)mapView:(MGLMapView * _Nonnull)mapView strokeColorForShapeAnnotation:(MGLShape * _Nonnull)annotation;
	[Export ("mapView:strokeColorForShapeAnnotation:")]
	UIColor MapView (MGLMapView mapView, MGLShape annotation);

	// @optional -(UIColor * _Nonnull)mapView:(MGLMapView * _Nonnull)mapView fillColorForPolygonAnnotation:(MGLPolygon * _Nonnull)annotation;
	[Export ("mapView:fillColorForPolygonAnnotation:")]
	UIColor MapView (MGLMapView mapView, MGLPolygon annotation);

	// @optional -(CGFloat)mapView:(MGLMapView * _Nonnull)mapView lineWidthForPolylineAnnotation:(MGLPolyline * _Nonnull)annotation;
	[Export ("mapView:lineWidthForPolylineAnnotation:")]
	nfloat MapView (MGLMapView mapView, MGLPolyline annotation);

	// @optional -(MGLAnnotationView * _Nullable)mapView:(MGLMapView * _Nonnull)mapView viewForAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
	[Export ("mapView:viewForAnnotation:")]
	[return: NullAllowed]
	MGLAnnotationView MapView (MGLMapView mapView, MGLAnnotation annotation);

	// @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didAddAnnotationViews:(NSArray<MGLAnnotationView *> * _Nonnull)annotationViews;
	[Export ("mapView:didAddAnnotationViews:")]
	void MapView (MGLMapView mapView, MGLAnnotationView[] annotationViews);

	// @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didSelectAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
	[Export ("mapView:didSelectAnnotation:")]
	void MapView (MGLMapView mapView, MGLAnnotation annotation);

	// @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didDeselectAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
	[Export ("mapView:didDeselectAnnotation:")]
	void MapView (MGLMapView mapView, MGLAnnotation annotation);

	// @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didSelectAnnotationView:(MGLAnnotationView * _Nonnull)annotationView;
	[Export ("mapView:didSelectAnnotationView:")]
	void MapView (MGLMapView mapView, MGLAnnotationView annotationView);

	// @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didDeselectAnnotationView:(MGLAnnotationView * _Nonnull)annotationView;
	[Export ("mapView:didDeselectAnnotationView:")]
	void MapView (MGLMapView mapView, MGLAnnotationView annotationView);

	// @optional -(BOOL)mapView:(MGLMapView * _Nonnull)mapView annotationCanShowCallout:(id<MGLAnnotation> _Nonnull)annotation;
	[Export ("mapView:annotationCanShowCallout:")]
	bool MapView (MGLMapView mapView, MGLAnnotation annotation);

	// @optional -(id<MGLCalloutView> _Nullable)mapView:(MGLMapView * _Nonnull)mapView calloutViewForAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
	[Export ("mapView:calloutViewForAnnotation:")]
	[return: NullAllowed]
	MGLCalloutView MapView (MGLMapView mapView, MGLAnnotation annotation);

	// @optional -(UIView * _Nullable)mapView:(MGLMapView * _Nonnull)mapView leftCalloutAccessoryViewForAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
	[Export ("mapView:leftCalloutAccessoryViewForAnnotation:")]
	[return: NullAllowed]
	UIView MapView (MGLMapView mapView, MGLAnnotation annotation);

	// @optional -(UIView * _Nullable)mapView:(MGLMapView * _Nonnull)mapView rightCalloutAccessoryViewForAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
	[Export ("mapView:rightCalloutAccessoryViewForAnnotation:")]
	[return: NullAllowed]
	UIView MapView (MGLMapView mapView, MGLAnnotation annotation);

	// @optional -(void)mapView:(MGLMapView * _Nonnull)mapView annotation:(id<MGLAnnotation> _Nonnull)annotation calloutAccessoryControlTapped:(UIControl * _Nonnull)control;
	[Export ("mapView:annotation:calloutAccessoryControlTapped:")]
	void MapView (MGLMapView mapView, MGLAnnotation annotation, UIControl control);

	// @optional -(void)mapView:(MGLMapView * _Nonnull)mapView tapOnCalloutForAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
	[Export ("mapView:tapOnCalloutForAnnotation:")]
	void MapView (MGLMapView mapView, MGLAnnotation annotation);
}

// @protocol MGLOfflineRegion <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MGLOfflineRegion
{
}

// @interface MGLOfflinePack : NSObject
[BaseType (typeof(NSObject))]
interface MGLOfflinePack
{
	// @property (readonly, nonatomic) id<MGLOfflineRegion> _Nonnull region;
	[Export ("region")]
	MGLOfflineRegion Region { get; }

	// @property (readonly, nonatomic) NSData * _Nonnull context;
	[Export ("context")]
	NSData Context { get; }

	// @property (readonly, nonatomic) MGLOfflinePackState state;
	[Export ("state")]
	MGLOfflinePackState State { get; }

	// @property (readonly, nonatomic) MGLOfflinePackProgress progress;
	[Export ("progress")]
	MGLOfflinePackProgress Progress { get; }

	// -(void)resume;
	[Export ("resume")]
	void Resume ();

	// -(void)suspend;
	[Export ("suspend")]
	void Suspend ();

	// -(void)requestProgress;
	[Export ("requestProgress")]
	void RequestProgress ();
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const NSNotificationName _Nonnull MGLOfflinePackProgressChangedNotification __attribute__((visibility("default")));
	[Field ("MGLOfflinePackProgressChangedNotification", "__Internal")]
	NSString MGLOfflinePackProgressChangedNotification { get; }

	// extern const NSNotificationName _Nonnull MGLOfflinePackErrorNotification __attribute__((visibility("default")));
	[Field ("MGLOfflinePackErrorNotification", "__Internal")]
	NSString MGLOfflinePackErrorNotification { get; }

	// extern const NSNotificationName _Nonnull MGLOfflinePackMaximumMapboxTilesReachedNotification __attribute__((visibility("default")));
	[Field ("MGLOfflinePackMaximumMapboxTilesReachedNotification", "__Internal")]
	NSString MGLOfflinePackMaximumMapboxTilesReachedNotification { get; }

	// extern const MGLOfflinePackUserInfoKey _Nonnull MGLOfflinePackUserInfoKeyState __attribute__((visibility("default")));
	[Field ("MGLOfflinePackUserInfoKeyState", "__Internal")]
	NSString MGLOfflinePackUserInfoKeyState { get; }

	// extern NSString *const _Nonnull MGLOfflinePackStateUserInfoKey __attribute__((visibility("default"))) __attribute__((deprecated("Use MGLOfflinePackUserInfoKeyState")));
	[Field ("MGLOfflinePackStateUserInfoKey", "__Internal")]
	NSString MGLOfflinePackStateUserInfoKey { get; }

	// extern const MGLOfflinePackUserInfoKey _Nonnull MGLOfflinePackUserInfoKeyProgress __attribute__((visibility("default")));
	[Field ("MGLOfflinePackUserInfoKeyProgress", "__Internal")]
	NSString MGLOfflinePackUserInfoKeyProgress { get; }

	// extern NSString *const _Nonnull MGLOfflinePackProgressUserInfoKey __attribute__((visibility("default"))) __attribute__((deprecated("Use MGLOfflinePackUserInfoKeyProgress")));
	[Field ("MGLOfflinePackProgressUserInfoKey", "__Internal")]
	NSString MGLOfflinePackProgressUserInfoKey { get; }

	// extern const MGLOfflinePackUserInfoKey _Nonnull MGLOfflinePackUserInfoKeyError __attribute__((visibility("default")));
	[Field ("MGLOfflinePackUserInfoKeyError", "__Internal")]
	NSString MGLOfflinePackUserInfoKeyError { get; }

	// extern NSString *const _Nonnull MGLOfflinePackErrorUserInfoKey __attribute__((visibility("default"))) __attribute__((deprecated("Use MGLOfflinePackUserInfoKeyError")));
	[Field ("MGLOfflinePackErrorUserInfoKey", "__Internal")]
	NSString MGLOfflinePackErrorUserInfoKey { get; }

	// extern const MGLOfflinePackUserInfoKey _Nonnull MGLOfflinePackUserInfoKeyMaximumCount __attribute__((visibility("default")));
	[Field ("MGLOfflinePackUserInfoKeyMaximumCount", "__Internal")]
	NSString MGLOfflinePackUserInfoKeyMaximumCount { get; }

	// extern NSString *const _Nonnull MGLOfflinePackMaximumCountUserInfoKey __attribute__((visibility("default"))) __attribute__((deprecated("Use MGLOfflinePackUserInfoKeyMaximumCount")));
	[Field ("MGLOfflinePackMaximumCountUserInfoKey", "__Internal")]
	NSString MGLOfflinePackMaximumCountUserInfoKey { get; }
}

// typedef void (^MGLOfflinePackAdditionCompletionHandler)(MGLOfflinePack * _Nullable, NSError * _Nullable);
delegate void MGLOfflinePackAdditionCompletionHandler ([NullAllowed] MGLOfflinePack arg0, [NullAllowed] NSError arg1);

// typedef void (^MGLOfflinePackRemovalCompletionHandler)(NSError * _Nullable);
delegate void MGLOfflinePackRemovalCompletionHandler ([NullAllowed] NSError arg0);

// @interface MGLOfflineStorage : NSObject
[BaseType (typeof(NSObject))]
interface MGLOfflineStorage
{
	// +(instancetype _Nonnull)sharedOfflineStorage;
	[Static]
	[Export ("sharedOfflineStorage")]
	MGLOfflineStorage SharedOfflineStorage ();

	[Wrap ("WeakDelegate")]
	[NullAllowed]
	MGLOfflineStorageDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<MGLOfflineStorageDelegate> _Nullable delegate __attribute__((iboutlet));
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// @property (readonly, nonatomic, strong) NSArray<MGLOfflinePack *> * _Nullable packs;
	[NullAllowed, Export ("packs", ArgumentSemantic.Strong)]
	MGLOfflinePack[] Packs { get; }

	// -(void)addPackForRegion:(id<MGLOfflineRegion> _Nonnull)region withContext:(NSData * _Nonnull)context completionHandler:(MGLOfflinePackAdditionCompletionHandler _Nullable)completion;
	[Export ("addPackForRegion:withContext:completionHandler:")]
	void AddPackForRegion (MGLOfflineRegion region, NSData context, [NullAllowed] MGLOfflinePackAdditionCompletionHandler completion);

	// -(void)removePack:(MGLOfflinePack * _Nonnull)pack withCompletionHandler:(MGLOfflinePackRemovalCompletionHandler _Nullable)completion;
	[Export ("removePack:withCompletionHandler:")]
	void RemovePack (MGLOfflinePack pack, [NullAllowed] MGLOfflinePackRemovalCompletionHandler completion);

	// -(void)reloadPacks;
	[Export ("reloadPacks")]
	void ReloadPacks ();

	// -(void)setMaximumAllowedMapboxTiles:(uint64_t)maximumCount;
	[Export ("setMaximumAllowedMapboxTiles:")]
	void SetMaximumAllowedMapboxTiles (ulong maximumCount);

	// @property (readonly, nonatomic) unsigned long long countOfBytesCompleted;
	[Export ("countOfBytesCompleted")]
	ulong CountOfBytesCompleted { get; }
}

// @protocol MGLOfflineStorageDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MGLOfflineStorageDelegate
{
	// @required -(NSURL * _Nonnull)offlineStorage:(MGLOfflineStorage * _Nonnull)storage URLForResourceOfKind:(MGLResourceKind)kind withURL:(NSURL * _Nonnull)url;
	[Abstract]
	[Export ("offlineStorage:URLForResourceOfKind:withURL:")]
	NSUrl URLForResourceOfKind (MGLOfflineStorage storage, MGLResourceKind kind, NSUrl url);
}

// @interface MGLStyleLayer : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface MGLStyleLayer
{
	// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier;
	[Export ("initWithIdentifier:")]
	IntPtr Constructor (string identifier);

	// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
	[Export ("identifier")]
	string Identifier { get; }

	// @property (getter = isVisible, assign, nonatomic) BOOL visible;
	[Export ("visible")]
	bool Visible { [Bind ("isVisible")] get; set; }

	// @property (assign, nonatomic) float maximumZoomLevel;
	[Export ("maximumZoomLevel")]
	float MaximumZoomLevel { get; set; }

	// @property (assign, nonatomic) float minimumZoomLevel;
	[Export ("minimumZoomLevel")]
	float MinimumZoomLevel { get; set; }
}

// @interface MGLStyle : NSObject
[BaseType (typeof(NSObject))]
interface MGLStyle
{
	// +(NSURL * _Nonnull)streetsStyleURL __attribute__((deprecated("Use -streetsStyleURLWithVersion:.")));
	[Static]
	[Export ("streetsStyleURL")]
	[Verify (MethodToProperty)]
	NSUrl StreetsStyleURL { get; }

	// +(NSURL * _Nonnull)streetsStyleURLWithVersion:(NSInteger)version;
	[Static]
	[Export ("streetsStyleURLWithVersion:")]
	NSUrl StreetsStyleURLWithVersion (nint version);

	// +(NSURL * _Nonnull)emeraldStyleURL __attribute__((deprecated("Create an NSURL object with the string “mapbox://styles/mapbox/emerald-v8”.")));
	[Static]
	[Export ("emeraldStyleURL")]
	[Verify (MethodToProperty)]
	NSUrl EmeraldStyleURL { get; }

	// +(NSURL * _Nonnull)outdoorsStyleURLWithVersion:(NSInteger)version;
	[Static]
	[Export ("outdoorsStyleURLWithVersion:")]
	NSUrl OutdoorsStyleURLWithVersion (nint version);

	// +(NSURL * _Nonnull)lightStyleURL __attribute__((deprecated("Use -lightStyleURLWithVersion:.")));
	[Static]
	[Export ("lightStyleURL")]
	[Verify (MethodToProperty)]
	NSUrl LightStyleURL { get; }

	// +(NSURL * _Nonnull)lightStyleURLWithVersion:(NSInteger)version;
	[Static]
	[Export ("lightStyleURLWithVersion:")]
	NSUrl LightStyleURLWithVersion (nint version);

	// +(NSURL * _Nonnull)darkStyleURL __attribute__((deprecated("Use -darkStyleURLWithVersion:.")));
	[Static]
	[Export ("darkStyleURL")]
	[Verify (MethodToProperty)]
	NSUrl DarkStyleURL { get; }

	// +(NSURL * _Nonnull)darkStyleURLWithVersion:(NSInteger)version;
	[Static]
	[Export ("darkStyleURLWithVersion:")]
	NSUrl DarkStyleURLWithVersion (nint version);

	// +(NSURL * _Nonnull)satelliteStyleURL __attribute__((deprecated("Use -satelliteStyleURLWithVersion:.")));
	[Static]
	[Export ("satelliteStyleURL")]
	[Verify (MethodToProperty)]
	NSUrl SatelliteStyleURL { get; }

	// +(NSURL * _Nonnull)satelliteStyleURLWithVersion:(NSInteger)version;
	[Static]
	[Export ("satelliteStyleURLWithVersion:")]
	NSUrl SatelliteStyleURLWithVersion (nint version);

	// +(NSURL * _Nonnull)hybridStyleURL __attribute__((deprecated("Use -satelliteStreetsStyleURLWithVersion:.")));
	[Static]
	[Export ("hybridStyleURL")]
	[Verify (MethodToProperty)]
	NSUrl HybridStyleURL { get; }

	// +(NSURL * _Nonnull)satelliteStreetsStyleURLWithVersion:(NSInteger)version;
	[Static]
	[Export ("satelliteStreetsStyleURLWithVersion:")]
	NSUrl SatelliteStreetsStyleURLWithVersion (nint version);

	// @property (readonly, copy) NSString * _Nullable name;
	[NullAllowed, Export ("name")]
	string Name { get; }

	// @property (nonatomic, strong) NSSet<__kindof MGLSource *> * _Nonnull sources;
	[Export ("sources", ArgumentSemantic.Strong)]
	NSSet<MGLSource> Sources { get; set; }

	// @property (nonatomic) MGLTransition transition;
	[Export ("transition", ArgumentSemantic.Assign)]
	MGLTransition Transition { get; set; }

	// -(MGLSource * _Nullable)sourceWithIdentifier:(NSString * _Nonnull)identifier;
	[Export ("sourceWithIdentifier:")]
	[return: NullAllowed]
	MGLSource SourceWithIdentifier (string identifier);

	// -(void)addSource:(MGLSource * _Nonnull)source;
	[Export ("addSource:")]
	void AddSource (MGLSource source);

	// -(void)removeSource:(MGLSource * _Nonnull)source;
	[Export ("removeSource:")]
	void RemoveSource (MGLSource source);

	// @property (nonatomic, strong) NSArray<__kindof MGLStyleLayer *> * _Nonnull layers;
	[Export ("layers", ArgumentSemantic.Strong)]
	MGLStyleLayer[] Layers { get; set; }

	// -(MGLStyleLayer * _Nullable)layerWithIdentifier:(NSString * _Nonnull)identifier;
	[Export ("layerWithIdentifier:")]
	[return: NullAllowed]
	MGLStyleLayer LayerWithIdentifier (string identifier);

	// -(void)addLayer:(MGLStyleLayer * _Nonnull)layer;
	[Export ("addLayer:")]
	void AddLayer (MGLStyleLayer layer);

	// -(void)insertLayer:(MGLStyleLayer * _Nonnull)layer atIndex:(NSUInteger)index;
	[Export ("insertLayer:atIndex:")]
	void InsertLayer (MGLStyleLayer layer, nuint index);

	// -(void)insertLayer:(MGLStyleLayer * _Nonnull)layer belowLayer:(MGLStyleLayer * _Nonnull)sibling;
	[Export ("insertLayer:belowLayer:")]
	void InsertLayer (MGLStyleLayer layer, MGLStyleLayer sibling);

	// -(void)insertLayer:(MGLStyleLayer * _Nonnull)layer aboveLayer:(MGLStyleLayer * _Nonnull)sibling;
	[Export ("insertLayer:aboveLayer:")]
	void InsertLayer (MGLStyleLayer layer, MGLStyleLayer sibling);

	// -(void)removeLayer:(MGLStyleLayer * _Nonnull)layer;
	[Export ("removeLayer:")]
	void RemoveLayer (MGLStyleLayer layer);

	// @property (nonatomic) NSArray<NSString *> * _Nonnull styleClasses __attribute__((deprecated("This property will be removed in a future release.")));
	[Export ("styleClasses", ArgumentSemantic.Assign)]
	string[] StyleClasses { get; set; }

	// -(BOOL)hasStyleClass:(NSString * _Nonnull)styleClass __attribute__((deprecated("This method will be removed in a future release.")));
	[Export ("hasStyleClass:")]
	bool HasStyleClass (string styleClass);

	// -(void)addStyleClass:(NSString * _Nonnull)styleClass __attribute__((deprecated("This method will be removed in a future release.")));
	[Export ("addStyleClass:")]
	void AddStyleClass (string styleClass);

	// -(void)removeStyleClass:(NSString * _Nonnull)styleClass __attribute__((deprecated("This method will be removed in a future release.")));
	[Export ("removeStyleClass:")]
	void RemoveStyleClass (string styleClass);

	// -(UIImage * _Nullable)imageForName:(NSString * _Nonnull)name;
	[Export ("imageForName:")]
	[return: NullAllowed]
	UIImage ImageForName (string name);

	// -(void)setImage:(UIImage * _Nonnull)image forName:(NSString * _Nonnull)name;
	[Export ("setImage:forName:")]
	void SetImage (UIImage image, string name);

	// -(void)removeImageForName:(NSString * _Nonnull)name;
	[Export ("removeImageForName:")]
	void RemoveImageForName (string name);
}

// @interface MGLForegroundStyleLayer : MGLStyleLayer
[BaseType (typeof(MGLStyleLayer))]
[DisableDefaultCtor]
interface MGLForegroundStyleLayer
{
	// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source __attribute__((objc_designated_initializer));
	[Export ("initWithIdentifier:source:")]
	[DesignatedInitializer]
	IntPtr Constructor (string identifier, MGLSource source);

	// @property (readonly, nonatomic) NSString * _Nullable sourceIdentifier;
	[NullAllowed, Export ("sourceIdentifier")]
	string SourceIdentifier { get; }
}

// @interface MGLVectorStyleLayer : MGLForegroundStyleLayer
[BaseType (typeof(MGLForegroundStyleLayer))]
interface MGLVectorStyleLayer
{
	// @property (nonatomic) NSString * _Nullable sourceLayerIdentifier;
	[NullAllowed, Export ("sourceLayerIdentifier")]
	string SourceLayerIdentifier { get; set; }

	// @property (nonatomic) NSPredicate * _Nullable predicate;
	[NullAllowed, Export ("predicate", ArgumentSemantic.Assign)]
	NSPredicate Predicate { get; set; }
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const MGLStyleFunctionOption _Nonnull MGLStyleFunctionOptionInterpolationBase __attribute__((visibility("default")));
	[Field ("MGLStyleFunctionOptionInterpolationBase", "__Internal")]
	NSString MGLStyleFunctionOptionInterpolationBase { get; }

	// extern const MGLStyleFunctionOption _Nonnull MGLStyleFunctionOptionDefaultValue __attribute__((visibility("default")));
	[Field ("MGLStyleFunctionOptionDefaultValue", "__Internal")]
	NSString MGLStyleFunctionOptionDefaultValue { get; }
}

// audit-objc-generics: @interface MGLStyleValue<T> : NSObject
[BaseType (typeof(NSObject))]
interface MGLStyleValue
{
	// +(instancetype _Nonnull)valueWithRawValue:(T _Nonnull)rawValue;
	[Static]
	[Export ("valueWithRawValue:")]
	MGLStyleValue ValueWithRawValue (NSObject rawValue);

	// +(instancetype _Nonnull)valueWithStops:(NSDictionary<NSNumber *,MGLStyleValue<T> *> * _Nonnull)stops __attribute__((deprecated("Use +[MGLStyleValue valueWithInterpolationMode:cameraStops:options:]")));
	[Static]
	[Export ("valueWithStops:")]
	MGLStyleValue ValueWithStops (NSDictionary<NSNumber, MGLStyleValue<NSObject>> stops);

	// +(instancetype _Nonnull)valueWithInterpolationBase:(CGFloat)interpolationBase stops:(NSDictionary<NSNumber *,MGLStyleValue<T> *> * _Nonnull)stops __attribute__((deprecated("Use +[MGLStyleValue valueWithInterpolationMode:cameraStops:options:]")));
	[Static]
	[Export ("valueWithInterpolationBase:stops:")]
	MGLStyleValue ValueWithInterpolationBase (nfloat interpolationBase, NSDictionary<NSNumber, MGLStyleValue<NSObject>> stops);

	// +(instancetype _Nonnull)valueWithInterpolationMode:(MGLInterpolationMode)interpolationMode cameraStops:(NSDictionary<id,MGLStyleValue<T> *> * _Nonnull)cameraStops options:(NSDictionary<MGLStyleFunctionOption,id> * _Nullable)options;
	[Static]
	[Export ("valueWithInterpolationMode:cameraStops:options:")]
	MGLStyleValue ValueWithInterpolationMode (MGLInterpolationMode interpolationMode, NSDictionary<NSObject, MGLStyleValue<NSObject>> cameraStops, [NullAllowed] NSDictionary<NSString, NSObject> options);

	// +(instancetype _Nonnull)valueWithInterpolationMode:(MGLInterpolationMode)interpolationMode sourceStops:(NSDictionary<id,MGLStyleValue<T> *> * _Nullable)sourceStops attributeName:(NSString * _Nonnull)attributeName options:(NSDictionary<MGLStyleFunctionOption,id> * _Nullable)options;
	[Static]
	[Export ("valueWithInterpolationMode:sourceStops:attributeName:options:")]
	MGLStyleValue ValueWithInterpolationMode (MGLInterpolationMode interpolationMode, [NullAllowed] NSDictionary<NSObject, MGLStyleValue<NSObject>> sourceStops, string attributeName, [NullAllowed] NSDictionary<NSString, NSObject> options);

	// +(instancetype _Nonnull)valueWithInterpolationMode:(MGLInterpolationMode)interpolationMode compositeStops:(NSDictionary<id,NSDictionary<id,MGLStyleValue<T> *> *> * _Nonnull)compositeStops attributeName:(NSString * _Nonnull)attributeName options:(NSDictionary<MGLStyleFunctionOption,id> * _Nullable)options;
	[Static]
	[Export ("valueWithInterpolationMode:compositeStops:attributeName:options:")]
	MGLStyleValue ValueWithInterpolationMode (MGLInterpolationMode interpolationMode, NSDictionary<NSObject, NSDictionary<NSObject, MGLStyleValue<NSObject>>> compositeStops, string attributeName, [NullAllowed] NSDictionary<NSString, NSObject> options);
}

// audit-objc-generics: @interface MGLConstantStyleValue<T> : MGLStyleValue
[BaseType (typeof(MGLStyleValue))]
[DisableDefaultCtor]
interface MGLConstantStyleValue
{
	// +(instancetype _Nonnull)valueWithRawValue:(T _Nonnull)rawValue;
	[Static]
	[Export ("valueWithRawValue:")]
	MGLConstantStyleValue ValueWithRawValue (NSObject rawValue);

	// -(instancetype _Nonnull)initWithRawValue:(T _Nonnull)rawValue __attribute__((objc_designated_initializer));
	[Export ("initWithRawValue:")]
	[DesignatedInitializer]
	IntPtr Constructor (NSObject rawValue);

	// @property (nonatomic) T _Nonnull rawValue;
	[Export ("rawValue", ArgumentSemantic.Assign)]
	NSObject RawValue { get; set; }
}

// audit-objc-generics: @interface MGLStyleFunction<T> : MGLStyleValue
[BaseType (typeof(MGLStyleValue))]
interface MGLStyleFunction
{
	// +(instancetype _Nonnull)functionWithStops:(NSDictionary<NSNumber *,MGLStyleValue<T> *> * _Nonnull)stops __attribute__((deprecated("Use +[MGLStyleValue valueWithInterpolationMode:cameraStops:options:]")));
	[Static]
	[Export ("functionWithStops:")]
	MGLStyleFunction FunctionWithStops (NSDictionary<NSNumber, MGLStyleValue<NSObject>> stops);

	// +(instancetype _Nonnull)functionWithInterpolationBase:(CGFloat)interpolationBase stops:(NSDictionary<NSNumber *,MGLStyleValue<T> *> * _Nonnull)stops __attribute__((deprecated("Use +[MGLStyleValue valueWithInterpolationMode:cameraStops:options:]")));
	[Static]
	[Export ("functionWithInterpolationBase:stops:")]
	MGLStyleFunction FunctionWithInterpolationBase (nfloat interpolationBase, NSDictionary<NSNumber, MGLStyleValue<NSObject>> stops);

	// -(instancetype _Nonnull)initWithInterpolationBase:(CGFloat)interpolationBase stops:(NSDictionary<NSNumber *,MGLStyleValue<T> *> * _Nonnull)stops __attribute__((deprecated("Use +[MGLStyleValue valueWithInterpolationMode:cameraStops:options:]")));
	[Export ("initWithInterpolationBase:stops:")]
	IntPtr Constructor (nfloat interpolationBase, NSDictionary<NSNumber, MGLStyleValue<NSObject>> stops);

	// @property (nonatomic) MGLInterpolationMode interpolationMode;
	[Export ("interpolationMode", ArgumentSemantic.Assign)]
	MGLInterpolationMode InterpolationMode { get; set; }

	// @property (copy, nonatomic) NSDictionary * _Nullable stops;
	[NullAllowed, Export ("stops", ArgumentSemantic.Copy)]
	NSDictionary Stops { get; set; }

	// @property (nonatomic) CGFloat interpolationBase;
	[Export ("interpolationBase")]
	nfloat InterpolationBase { get; set; }
}

// audit-objc-generics: @interface MGLCameraStyleFunction<T> : MGLStyleFunction
[BaseType (typeof(MGLStyleFunction))]
interface MGLCameraStyleFunction
{
	// +(instancetype _Nonnull)functionWithInterpolationMode:(MGLInterpolationMode)interpolationMode stops:(NSDictionary<id,MGLStyleValue<T> *> * _Nonnull)stops options:(NSDictionary<MGLStyleFunctionOption,id> * _Nullable)options;
	[Static]
	[Export ("functionWithInterpolationMode:stops:options:")]
	MGLCameraStyleFunction FunctionWithInterpolationMode (MGLInterpolationMode interpolationMode, NSDictionary<NSObject, MGLStyleValue<NSObject>> stops, [NullAllowed] NSDictionary<NSString, NSObject> options);

	// @property (copy, nonatomic) NSDictionary<id,MGLStyleValue<T> *> * _Nonnull stops;
	[Export ("stops", ArgumentSemantic.Copy)]
	NSDictionary<NSObject, MGLStyleValue<NSObject>> Stops { get; set; }
}

// audit-objc-generics: @interface MGLSourceStyleFunction<T> : MGLStyleFunction
[BaseType (typeof(MGLStyleFunction))]
interface MGLSourceStyleFunction
{
	// +(instancetype _Nonnull)functionWithInterpolationMode:(MGLInterpolationMode)interpolationMode stops:(NSDictionary<id,MGLStyleValue<T> *> * _Nullable)stops attributeName:(NSString * _Nonnull)attributeName options:(NSDictionary<MGLStyleFunctionOption,id> * _Nullable)options;
	[Static]
	[Export ("functionWithInterpolationMode:stops:attributeName:options:")]
	MGLSourceStyleFunction FunctionWithInterpolationMode (MGLInterpolationMode interpolationMode, [NullAllowed] NSDictionary<NSObject, MGLStyleValue<NSObject>> stops, string attributeName, [NullAllowed] NSDictionary<NSString, NSObject> options);

	// @property (copy, nonatomic) NSString * _Nonnull attributeName;
	[Export ("attributeName")]
	string AttributeName { get; set; }

	// @property (copy, nonatomic) NSDictionary<id,MGLStyleValue<T> *> * _Nullable stops;
	[NullAllowed, Export ("stops", ArgumentSemantic.Copy)]
	NSDictionary<NSObject, MGLStyleValue<NSObject>> Stops { get; set; }

	// @property (nonatomic) MGLStyleValue<T> * _Nullable defaultValue;
	[NullAllowed, Export ("defaultValue", ArgumentSemantic.Assign)]
	MGLStyleValue<NSObject> DefaultValue { get; set; }
}

// audit-objc-generics: @interface MGLCompositeStyleFunction<T> : MGLStyleFunction
[BaseType (typeof(MGLStyleFunction))]
interface MGLCompositeStyleFunction
{
	// +(instancetype _Nonnull)functionWithInterpolationMode:(MGLInterpolationMode)interpolationMode stops:(NSDictionary<id,NSDictionary<id,MGLStyleValue<T> *> *> * _Nonnull)stops attributeName:(NSString * _Nonnull)attributeName options:(NSDictionary<MGLStyleFunctionOption,id> * _Nullable)options;
	[Static]
	[Export ("functionWithInterpolationMode:stops:attributeName:options:")]
	MGLCompositeStyleFunction FunctionWithInterpolationMode (MGLInterpolationMode interpolationMode, NSDictionary<NSObject, NSDictionary<NSObject, MGLStyleValue<NSObject>>> stops, string attributeName, [NullAllowed] NSDictionary<NSString, NSObject> options);

	// @property (copy, nonatomic) NSString * _Nonnull attributeName;
	[Export ("attributeName")]
	string AttributeName { get; set; }

	// @property (copy, nonatomic) NSDictionary<id,NSDictionary<id,MGLStyleValue<T> *> *> * _Nonnull stops;
	[Export ("stops", ArgumentSemantic.Copy)]
	NSDictionary<NSObject, NSDictionary<NSObject, MGLStyleValue<NSObject>>> Stops { get; set; }

	// @property (nonatomic) MGLStyleValue<T> * _Nullable defaultValue;
	[NullAllowed, Export ("defaultValue", ArgumentSemantic.Assign)]
	MGLStyleValue<NSObject> DefaultValue { get; set; }
}

// @interface MGLFillStyleLayer : MGLVectorStyleLayer
[BaseType (typeof(MGLVectorStyleLayer))]
interface MGLFillStyleLayer
{
	// @property (getter = isFillAntialiased, nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified fillAntialiased;
	[Export ("fillAntialiased", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> FillAntialiased { [Bind ("isFillAntialiased")] get; set; }

	// @property (nonatomic) MGLStyleValue<UIColor *> * _Null_unspecified fillColor;
	[Export ("fillColor", ArgumentSemantic.Assign)]
	MGLStyleValue<UIColor> FillColor { get; set; }

	// @property (nonatomic) MGLTransition fillColorTransition;
	[Export ("fillColorTransition", ArgumentSemantic.Assign)]
	MGLTransition FillColorTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified fillOpacity;
	[Export ("fillOpacity", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> FillOpacity { get; set; }

	// @property (nonatomic) MGLTransition fillOpacityTransition;
	[Export ("fillOpacityTransition", ArgumentSemantic.Assign)]
	MGLTransition FillOpacityTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<UIColor *> * _Null_unspecified fillOutlineColor;
	[Export ("fillOutlineColor", ArgumentSemantic.Assign)]
	MGLStyleValue<UIColor> FillOutlineColor { get; set; }

	// @property (nonatomic) MGLTransition fillOutlineColorTransition;
	[Export ("fillOutlineColorTransition", ArgumentSemantic.Assign)]
	MGLTransition FillOutlineColorTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSString *> * _Null_unspecified fillPattern;
	[Export ("fillPattern", ArgumentSemantic.Assign)]
	MGLStyleValue<NSString> FillPattern { get; set; }

	// @property (nonatomic) MGLTransition fillPatternTransition;
	[Export ("fillPatternTransition", ArgumentSemantic.Assign)]
	MGLTransition FillPatternTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified fillTranslation;
	[Export ("fillTranslation", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> FillTranslation { get; set; }

	// @property (nonatomic) MGLTransition fillTranslationTransition;
	[Export ("fillTranslationTransition", ArgumentSemantic.Assign)]
	MGLTransition FillTranslationTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified fillTranslationAnchor;
	[Export ("fillTranslationAnchor", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> FillTranslationAnchor { get; set; }
}

// @interface MGLFillStyleLayerAdditions (NSValue)
[Category]
[BaseType (typeof(NSValue))]
interface NSValue_MGLFillStyleLayerAdditions
{
	// +(instancetype _Nonnull)valueWithMGLFillTranslationAnchor:(MGLFillTranslationAnchor)fillTranslationAnchor;
	[Static]
	[Export ("valueWithMGLFillTranslationAnchor:")]
	NSValue ValueWithMGLFillTranslationAnchor (MGLFillTranslationAnchor fillTranslationAnchor);

	// @property (readonly) MGLFillTranslationAnchor MGLFillTranslationAnchorValue;
	[Export ("MGLFillTranslationAnchorValue")]
	MGLFillTranslationAnchor MGLFillTranslationAnchorValue { get; }
}

// @interface MGLLineStyleLayer : MGLVectorStyleLayer
[BaseType (typeof(MGLVectorStyleLayer))]
interface MGLLineStyleLayer
{
	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified lineCap;
	[Export ("lineCap", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> LineCap { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified lineJoin;
	[Export ("lineJoin", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> LineJoin { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified lineMiterLimit;
	[Export ("lineMiterLimit", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> LineMiterLimit { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified lineRoundLimit;
	[Export ("lineRoundLimit", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> LineRoundLimit { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified lineBlur;
	[Export ("lineBlur", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> LineBlur { get; set; }

	// @property (nonatomic) MGLTransition lineBlurTransition;
	[Export ("lineBlurTransition", ArgumentSemantic.Assign)]
	MGLTransition LineBlurTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<UIColor *> * _Null_unspecified lineColor;
	[Export ("lineColor", ArgumentSemantic.Assign)]
	MGLStyleValue<UIColor> LineColor { get; set; }

	// @property (nonatomic) MGLTransition lineColorTransition;
	[Export ("lineColorTransition", ArgumentSemantic.Assign)]
	MGLTransition LineColorTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSArray<NSNumber *> *> * _Null_unspecified lineDashPattern;
	[Export ("lineDashPattern", ArgumentSemantic.Assign)]
	MGLStyleValue<NSArray<NSNumber>> LineDashPattern { get; set; }

	// @property (nonatomic) MGLTransition lineDashPatternTransition;
	[Export ("lineDashPatternTransition", ArgumentSemantic.Assign)]
	MGLTransition LineDashPatternTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified lineGapWidth;
	[Export ("lineGapWidth", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> LineGapWidth { get; set; }

	// @property (nonatomic) MGLTransition lineGapWidthTransition;
	[Export ("lineGapWidthTransition", ArgumentSemantic.Assign)]
	MGLTransition LineGapWidthTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified lineOffset;
	[Export ("lineOffset", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> LineOffset { get; set; }

	// @property (nonatomic) MGLTransition lineOffsetTransition;
	[Export ("lineOffsetTransition", ArgumentSemantic.Assign)]
	MGLTransition LineOffsetTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified lineOpacity;
	[Export ("lineOpacity", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> LineOpacity { get; set; }

	// @property (nonatomic) MGLTransition lineOpacityTransition;
	[Export ("lineOpacityTransition", ArgumentSemantic.Assign)]
	MGLTransition LineOpacityTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSString *> * _Null_unspecified linePattern;
	[Export ("linePattern", ArgumentSemantic.Assign)]
	MGLStyleValue<NSString> LinePattern { get; set; }

	// @property (nonatomic) MGLTransition linePatternTransition;
	[Export ("linePatternTransition", ArgumentSemantic.Assign)]
	MGLTransition LinePatternTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified lineTranslation;
	[Export ("lineTranslation", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> LineTranslation { get; set; }

	// @property (nonatomic) MGLTransition lineTranslationTransition;
	[Export ("lineTranslationTransition", ArgumentSemantic.Assign)]
	MGLTransition LineTranslationTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified lineTranslationAnchor;
	[Export ("lineTranslationAnchor", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> LineTranslationAnchor { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified lineWidth;
	[Export ("lineWidth", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> LineWidth { get; set; }

	// @property (nonatomic) MGLTransition lineWidthTransition;
	[Export ("lineWidthTransition", ArgumentSemantic.Assign)]
	MGLTransition LineWidthTransition { get; set; }
}

// @interface MGLLineStyleLayerAdditions (NSValue)
[Category]
[BaseType (typeof(NSValue))]
interface NSValue_MGLLineStyleLayerAdditions
{
	// +(instancetype _Nonnull)valueWithMGLLineCap:(MGLLineCap)lineCap;
	[Static]
	[Export ("valueWithMGLLineCap:")]
	NSValue ValueWithMGLLineCap (MGLLineCap lineCap);

	// @property (readonly) MGLLineCap MGLLineCapValue;
	[Export ("MGLLineCapValue")]
	MGLLineCap MGLLineCapValue { get; }

	// +(instancetype _Nonnull)valueWithMGLLineJoin:(MGLLineJoin)lineJoin;
	[Static]
	[Export ("valueWithMGLLineJoin:")]
	NSValue ValueWithMGLLineJoin (MGLLineJoin lineJoin);

	// @property (readonly) MGLLineJoin MGLLineJoinValue;
	[Export ("MGLLineJoinValue")]
	MGLLineJoin MGLLineJoinValue { get; }

	// +(instancetype _Nonnull)valueWithMGLLineTranslationAnchor:(MGLLineTranslationAnchor)lineTranslationAnchor;
	[Static]
	[Export ("valueWithMGLLineTranslationAnchor:")]
	NSValue ValueWithMGLLineTranslationAnchor (MGLLineTranslationAnchor lineTranslationAnchor);

	// @property (readonly) MGLLineTranslationAnchor MGLLineTranslationAnchorValue;
	[Export ("MGLLineTranslationAnchorValue")]
	MGLLineTranslationAnchor MGLLineTranslationAnchorValue { get; }
}

// @interface MGLSymbolStyleLayer : MGLVectorStyleLayer
[BaseType (typeof(MGLVectorStyleLayer))]
interface MGLSymbolStyleLayer
{
	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified iconAllowsOverlap;
	[Export ("iconAllowsOverlap", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> IconAllowsOverlap { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified iconIgnoresPlacement;
	[Export ("iconIgnoresPlacement", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> IconIgnoresPlacement { get; set; }

	// @property (nonatomic) MGLStyleValue<NSString *> * _Null_unspecified iconImageName;
	[Export ("iconImageName", ArgumentSemantic.Assign)]
	MGLStyleValue<NSString> IconImageName { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified iconOffset;
	[Export ("iconOffset", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> IconOffset { get; set; }

	// @property (getter = isIconOptional, nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified iconOptional;
	[Export ("iconOptional", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> IconOptional { [Bind ("isIconOptional")] get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified iconPadding;
	[Export ("iconPadding", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> IconPadding { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified iconRotation;
	[Export ("iconRotation", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> IconRotation { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified iconRotationAlignment;
	[Export ("iconRotationAlignment", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> IconRotationAlignment { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified iconScale;
	[Export ("iconScale", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> IconScale { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified iconTextFit;
	[Export ("iconTextFit", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> IconTextFit { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified iconTextFitPadding;
	[Export ("iconTextFitPadding", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> IconTextFitPadding { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified keepsIconUpright;
	[Export ("keepsIconUpright", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> KeepsIconUpright { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified keepsTextUpright;
	[Export ("keepsTextUpright", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> KeepsTextUpright { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified maximumTextAngle;
	[Export ("maximumTextAngle", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> MaximumTextAngle { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified maximumTextWidth;
	[Export ("maximumTextWidth", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> MaximumTextWidth { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified symbolAvoidsEdges;
	[Export ("symbolAvoidsEdges", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> SymbolAvoidsEdges { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified symbolPlacement;
	[Export ("symbolPlacement", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> SymbolPlacement { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified symbolSpacing;
	[Export ("symbolSpacing", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> SymbolSpacing { get; set; }

	// @property (nonatomic) MGLStyleValue<NSString *> * _Null_unspecified text;
	[Export ("text", ArgumentSemantic.Assign)]
	MGLStyleValue<NSString> Text { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified textAllowsOverlap;
	[Export ("textAllowsOverlap", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> TextAllowsOverlap { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified textAnchor;
	[Export ("textAnchor", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> TextAnchor { get; set; }

	// @property (nonatomic) MGLStyleValue<NSArray<NSString *> *> * _Null_unspecified textFontNames;
	[Export ("textFontNames", ArgumentSemantic.Assign)]
	MGLStyleValue<NSArray<NSString>> TextFontNames { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified textFontSize;
	[Export ("textFontSize", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> TextFontSize { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified textIgnoresPlacement;
	[Export ("textIgnoresPlacement", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> TextIgnoresPlacement { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified textJustification;
	[Export ("textJustification", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> TextJustification { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified textLetterSpacing;
	[Export ("textLetterSpacing", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> TextLetterSpacing { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified textLineHeight;
	[Export ("textLineHeight", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> TextLineHeight { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified textOffset;
	[Export ("textOffset", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> TextOffset { get; set; }

	// @property (getter = isTextOptional, nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified textOptional;
	[Export ("textOptional", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> TextOptional { [Bind ("isTextOptional")] get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified textPadding;
	[Export ("textPadding", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> TextPadding { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified textPitchAlignment;
	[Export ("textPitchAlignment", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> TextPitchAlignment { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified textRotation;
	[Export ("textRotation", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> TextRotation { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified textRotationAlignment;
	[Export ("textRotationAlignment", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> TextRotationAlignment { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified textTransform;
	[Export ("textTransform", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> TextTransform { get; set; }

	// @property (nonatomic) MGLStyleValue<UIColor *> * _Null_unspecified iconColor;
	[Export ("iconColor", ArgumentSemantic.Assign)]
	MGLStyleValue<UIColor> IconColor { get; set; }

	// @property (nonatomic) MGLTransition iconColorTransition;
	[Export ("iconColorTransition", ArgumentSemantic.Assign)]
	MGLTransition IconColorTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified iconHaloBlur;
	[Export ("iconHaloBlur", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> IconHaloBlur { get; set; }

	// @property (nonatomic) MGLTransition iconHaloBlurTransition;
	[Export ("iconHaloBlurTransition", ArgumentSemantic.Assign)]
	MGLTransition IconHaloBlurTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<UIColor *> * _Null_unspecified iconHaloColor;
	[Export ("iconHaloColor", ArgumentSemantic.Assign)]
	MGLStyleValue<UIColor> IconHaloColor { get; set; }

	// @property (nonatomic) MGLTransition iconHaloColorTransition;
	[Export ("iconHaloColorTransition", ArgumentSemantic.Assign)]
	MGLTransition IconHaloColorTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified iconHaloWidth;
	[Export ("iconHaloWidth", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> IconHaloWidth { get; set; }

	// @property (nonatomic) MGLTransition iconHaloWidthTransition;
	[Export ("iconHaloWidthTransition", ArgumentSemantic.Assign)]
	MGLTransition IconHaloWidthTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified iconOpacity;
	[Export ("iconOpacity", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> IconOpacity { get; set; }

	// @property (nonatomic) MGLTransition iconOpacityTransition;
	[Export ("iconOpacityTransition", ArgumentSemantic.Assign)]
	MGLTransition IconOpacityTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified iconTranslation;
	[Export ("iconTranslation", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> IconTranslation { get; set; }

	// @property (nonatomic) MGLTransition iconTranslationTransition;
	[Export ("iconTranslationTransition", ArgumentSemantic.Assign)]
	MGLTransition IconTranslationTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified iconTranslationAnchor;
	[Export ("iconTranslationAnchor", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> IconTranslationAnchor { get; set; }

	// @property (nonatomic) MGLStyleValue<UIColor *> * _Null_unspecified textColor;
	[Export ("textColor", ArgumentSemantic.Assign)]
	MGLStyleValue<UIColor> TextColor { get; set; }

	// @property (nonatomic) MGLTransition textColorTransition;
	[Export ("textColorTransition", ArgumentSemantic.Assign)]
	MGLTransition TextColorTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified textHaloBlur;
	[Export ("textHaloBlur", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> TextHaloBlur { get; set; }

	// @property (nonatomic) MGLTransition textHaloBlurTransition;
	[Export ("textHaloBlurTransition", ArgumentSemantic.Assign)]
	MGLTransition TextHaloBlurTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<UIColor *> * _Null_unspecified textHaloColor;
	[Export ("textHaloColor", ArgumentSemantic.Assign)]
	MGLStyleValue<UIColor> TextHaloColor { get; set; }

	// @property (nonatomic) MGLTransition textHaloColorTransition;
	[Export ("textHaloColorTransition", ArgumentSemantic.Assign)]
	MGLTransition TextHaloColorTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified textHaloWidth;
	[Export ("textHaloWidth", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> TextHaloWidth { get; set; }

	// @property (nonatomic) MGLTransition textHaloWidthTransition;
	[Export ("textHaloWidthTransition", ArgumentSemantic.Assign)]
	MGLTransition TextHaloWidthTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified textOpacity;
	[Export ("textOpacity", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> TextOpacity { get; set; }

	// @property (nonatomic) MGLTransition textOpacityTransition;
	[Export ("textOpacityTransition", ArgumentSemantic.Assign)]
	MGLTransition TextOpacityTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified textTranslation;
	[Export ("textTranslation", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> TextTranslation { get; set; }

	// @property (nonatomic) MGLTransition textTranslationTransition;
	[Export ("textTranslationTransition", ArgumentSemantic.Assign)]
	MGLTransition TextTranslationTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified textTranslationAnchor;
	[Export ("textTranslationAnchor", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> TextTranslationAnchor { get; set; }
}

// @interface MGLSymbolStyleLayerAdditions (NSValue)
[Category]
[BaseType (typeof(NSValue))]
interface NSValue_MGLSymbolStyleLayerAdditions
{
	// +(instancetype _Nonnull)valueWithMGLIconRotationAlignment:(MGLIconRotationAlignment)iconRotationAlignment;
	[Static]
	[Export ("valueWithMGLIconRotationAlignment:")]
	NSValue ValueWithMGLIconRotationAlignment (MGLIconRotationAlignment iconRotationAlignment);

	// @property (readonly) MGLIconRotationAlignment MGLIconRotationAlignmentValue;
	[Export ("MGLIconRotationAlignmentValue")]
	MGLIconRotationAlignment MGLIconRotationAlignmentValue { get; }

	// +(instancetype _Nonnull)valueWithMGLIconTextFit:(MGLIconTextFit)iconTextFit;
	[Static]
	[Export ("valueWithMGLIconTextFit:")]
	NSValue ValueWithMGLIconTextFit (MGLIconTextFit iconTextFit);

	// @property (readonly) MGLIconTextFit MGLIconTextFitValue;
	[Export ("MGLIconTextFitValue")]
	MGLIconTextFit MGLIconTextFitValue { get; }

	// +(instancetype _Nonnull)valueWithMGLSymbolPlacement:(MGLSymbolPlacement)symbolPlacement;
	[Static]
	[Export ("valueWithMGLSymbolPlacement:")]
	NSValue ValueWithMGLSymbolPlacement (MGLSymbolPlacement symbolPlacement);

	// @property (readonly) MGLSymbolPlacement MGLSymbolPlacementValue;
	[Export ("MGLSymbolPlacementValue")]
	MGLSymbolPlacement MGLSymbolPlacementValue { get; }

	// +(instancetype _Nonnull)valueWithMGLTextAnchor:(MGLTextAnchor)textAnchor;
	[Static]
	[Export ("valueWithMGLTextAnchor:")]
	NSValue ValueWithMGLTextAnchor (MGLTextAnchor textAnchor);

	// @property (readonly) MGLTextAnchor MGLTextAnchorValue;
	[Export ("MGLTextAnchorValue")]
	MGLTextAnchor MGLTextAnchorValue { get; }

	// +(instancetype _Nonnull)valueWithMGLTextJustification:(MGLTextJustification)textJustification;
	[Static]
	[Export ("valueWithMGLTextJustification:")]
	NSValue ValueWithMGLTextJustification (MGLTextJustification textJustification);

	// @property (readonly) MGLTextJustification MGLTextJustificationValue;
	[Export ("MGLTextJustificationValue")]
	MGLTextJustification MGLTextJustificationValue { get; }

	// +(instancetype _Nonnull)valueWithMGLTextPitchAlignment:(MGLTextPitchAlignment)textPitchAlignment;
	[Static]
	[Export ("valueWithMGLTextPitchAlignment:")]
	NSValue ValueWithMGLTextPitchAlignment (MGLTextPitchAlignment textPitchAlignment);

	// @property (readonly) MGLTextPitchAlignment MGLTextPitchAlignmentValue;
	[Export ("MGLTextPitchAlignmentValue")]
	MGLTextPitchAlignment MGLTextPitchAlignmentValue { get; }

	// +(instancetype _Nonnull)valueWithMGLTextRotationAlignment:(MGLTextRotationAlignment)textRotationAlignment;
	[Static]
	[Export ("valueWithMGLTextRotationAlignment:")]
	NSValue ValueWithMGLTextRotationAlignment (MGLTextRotationAlignment textRotationAlignment);

	// @property (readonly) MGLTextRotationAlignment MGLTextRotationAlignmentValue;
	[Export ("MGLTextRotationAlignmentValue")]
	MGLTextRotationAlignment MGLTextRotationAlignmentValue { get; }

	// +(instancetype _Nonnull)valueWithMGLTextTransform:(MGLTextTransform)textTransform;
	[Static]
	[Export ("valueWithMGLTextTransform:")]
	NSValue ValueWithMGLTextTransform (MGLTextTransform textTransform);

	// @property (readonly) MGLTextTransform MGLTextTransformValue;
	[Export ("MGLTextTransformValue")]
	MGLTextTransform MGLTextTransformValue { get; }

	// +(instancetype _Nonnull)valueWithMGLIconTranslationAnchor:(MGLIconTranslationAnchor)iconTranslationAnchor;
	[Static]
	[Export ("valueWithMGLIconTranslationAnchor:")]
	NSValue ValueWithMGLIconTranslationAnchor (MGLIconTranslationAnchor iconTranslationAnchor);

	// @property (readonly) MGLIconTranslationAnchor MGLIconTranslationAnchorValue;
	[Export ("MGLIconTranslationAnchorValue")]
	MGLIconTranslationAnchor MGLIconTranslationAnchorValue { get; }

	// +(instancetype _Nonnull)valueWithMGLTextTranslationAnchor:(MGLTextTranslationAnchor)textTranslationAnchor;
	[Static]
	[Export ("valueWithMGLTextTranslationAnchor:")]
	NSValue ValueWithMGLTextTranslationAnchor (MGLTextTranslationAnchor textTranslationAnchor);

	// @property (readonly) MGLTextTranslationAnchor MGLTextTranslationAnchorValue;
	[Export ("MGLTextTranslationAnchorValue")]
	MGLTextTranslationAnchor MGLTextTranslationAnchorValue { get; }
}

// @interface MGLRasterStyleLayer : MGLForegroundStyleLayer
[BaseType (typeof(MGLForegroundStyleLayer))]
interface MGLRasterStyleLayer
{
	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified maximumRasterBrightness;
	[Export ("maximumRasterBrightness", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> MaximumRasterBrightness { get; set; }

	// @property (nonatomic) MGLTransition maximumRasterBrightnessTransition;
	[Export ("maximumRasterBrightnessTransition", ArgumentSemantic.Assign)]
	MGLTransition MaximumRasterBrightnessTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified minimumRasterBrightness;
	[Export ("minimumRasterBrightness", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> MinimumRasterBrightness { get; set; }

	// @property (nonatomic) MGLTransition minimumRasterBrightnessTransition;
	[Export ("minimumRasterBrightnessTransition", ArgumentSemantic.Assign)]
	MGLTransition MinimumRasterBrightnessTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified rasterContrast;
	[Export ("rasterContrast", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> RasterContrast { get; set; }

	// @property (nonatomic) MGLTransition rasterContrastTransition;
	[Export ("rasterContrastTransition", ArgumentSemantic.Assign)]
	MGLTransition RasterContrastTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified rasterFadeDuration;
	[Export ("rasterFadeDuration", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> RasterFadeDuration { get; set; }

	// @property (nonatomic) MGLTransition rasterFadeDurationTransition;
	[Export ("rasterFadeDurationTransition", ArgumentSemantic.Assign)]
	MGLTransition RasterFadeDurationTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified rasterHueRotation;
	[Export ("rasterHueRotation", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> RasterHueRotation { get; set; }

	// @property (nonatomic) MGLTransition rasterHueRotationTransition;
	[Export ("rasterHueRotationTransition", ArgumentSemantic.Assign)]
	MGLTransition RasterHueRotationTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified rasterOpacity;
	[Export ("rasterOpacity", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> RasterOpacity { get; set; }

	// @property (nonatomic) MGLTransition rasterOpacityTransition;
	[Export ("rasterOpacityTransition", ArgumentSemantic.Assign)]
	MGLTransition RasterOpacityTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified rasterSaturation;
	[Export ("rasterSaturation", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> RasterSaturation { get; set; }

	// @property (nonatomic) MGLTransition rasterSaturationTransition;
	[Export ("rasterSaturationTransition", ArgumentSemantic.Assign)]
	MGLTransition RasterSaturationTransition { get; set; }
}

// @interface MGLCircleStyleLayer : MGLVectorStyleLayer
[BaseType (typeof(MGLVectorStyleLayer))]
interface MGLCircleStyleLayer
{
	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified circleBlur;
	[Export ("circleBlur", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> CircleBlur { get; set; }

	// @property (nonatomic) MGLTransition circleBlurTransition;
	[Export ("circleBlurTransition", ArgumentSemantic.Assign)]
	MGLTransition CircleBlurTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<UIColor *> * _Null_unspecified circleColor;
	[Export ("circleColor", ArgumentSemantic.Assign)]
	MGLStyleValue<UIColor> CircleColor { get; set; }

	// @property (nonatomic) MGLTransition circleColorTransition;
	[Export ("circleColorTransition", ArgumentSemantic.Assign)]
	MGLTransition CircleColorTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified circleOpacity;
	[Export ("circleOpacity", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> CircleOpacity { get; set; }

	// @property (nonatomic) MGLTransition circleOpacityTransition;
	[Export ("circleOpacityTransition", ArgumentSemantic.Assign)]
	MGLTransition CircleOpacityTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified circleRadius;
	[Export ("circleRadius", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> CircleRadius { get; set; }

	// @property (nonatomic) MGLTransition circleRadiusTransition;
	[Export ("circleRadiusTransition", ArgumentSemantic.Assign)]
	MGLTransition CircleRadiusTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified circleScaleAlignment;
	[Export ("circleScaleAlignment", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> CircleScaleAlignment { get; set; }

	// @property (nonatomic) MGLStyleValue<UIColor *> * _Null_unspecified circleStrokeColor;
	[Export ("circleStrokeColor", ArgumentSemantic.Assign)]
	MGLStyleValue<UIColor> CircleStrokeColor { get; set; }

	// @property (nonatomic) MGLTransition circleStrokeColorTransition;
	[Export ("circleStrokeColorTransition", ArgumentSemantic.Assign)]
	MGLTransition CircleStrokeColorTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified circleStrokeOpacity;
	[Export ("circleStrokeOpacity", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> CircleStrokeOpacity { get; set; }

	// @property (nonatomic) MGLTransition circleStrokeOpacityTransition;
	[Export ("circleStrokeOpacityTransition", ArgumentSemantic.Assign)]
	MGLTransition CircleStrokeOpacityTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified circleStrokeWidth;
	[Export ("circleStrokeWidth", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> CircleStrokeWidth { get; set; }

	// @property (nonatomic) MGLTransition circleStrokeWidthTransition;
	[Export ("circleStrokeWidthTransition", ArgumentSemantic.Assign)]
	MGLTransition CircleStrokeWidthTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified circleTranslation;
	[Export ("circleTranslation", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> CircleTranslation { get; set; }

	// @property (nonatomic) MGLTransition circleTranslationTransition;
	[Export ("circleTranslationTransition", ArgumentSemantic.Assign)]
	MGLTransition CircleTranslationTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSValue *> * _Null_unspecified circleTranslationAnchor;
	[Export ("circleTranslationAnchor", ArgumentSemantic.Assign)]
	MGLStyleValue<NSValue> CircleTranslationAnchor { get; set; }
}

// @interface MGLCircleStyleLayerAdditions (NSValue)
[Category]
[BaseType (typeof(NSValue))]
interface NSValue_MGLCircleStyleLayerAdditions
{
	// +(instancetype _Nonnull)valueWithMGLCircleScaleAlignment:(MGLCircleScaleAlignment)circleScaleAlignment;
	[Static]
	[Export ("valueWithMGLCircleScaleAlignment:")]
	NSValue ValueWithMGLCircleScaleAlignment (MGLCircleScaleAlignment circleScaleAlignment);

	// @property (readonly) MGLCircleScaleAlignment MGLCircleScaleAlignmentValue;
	[Export ("MGLCircleScaleAlignmentValue")]
	MGLCircleScaleAlignment MGLCircleScaleAlignmentValue { get; }

	// +(instancetype _Nonnull)valueWithMGLCircleTranslationAnchor:(MGLCircleTranslationAnchor)circleTranslationAnchor;
	[Static]
	[Export ("valueWithMGLCircleTranslationAnchor:")]
	NSValue ValueWithMGLCircleTranslationAnchor (MGLCircleTranslationAnchor circleTranslationAnchor);

	// @property (readonly) MGLCircleTranslationAnchor MGLCircleTranslationAnchorValue;
	[Export ("MGLCircleTranslationAnchorValue")]
	MGLCircleTranslationAnchor MGLCircleTranslationAnchorValue { get; }
}

// @interface MGLBackgroundStyleLayer : MGLStyleLayer
[BaseType (typeof(MGLStyleLayer))]
interface MGLBackgroundStyleLayer
{
	// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier __attribute__((objc_designated_initializer));
	[Export ("initWithIdentifier:")]
	[DesignatedInitializer]
	IntPtr Constructor (string identifier);

	// @property (nonatomic) MGLStyleValue<UIColor *> * _Null_unspecified backgroundColor;
	[Export ("backgroundColor", ArgumentSemantic.Assign)]
	MGLStyleValue<UIColor> BackgroundColor { get; set; }

	// @property (nonatomic) MGLTransition backgroundColorTransition;
	[Export ("backgroundColorTransition", ArgumentSemantic.Assign)]
	MGLTransition BackgroundColorTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSNumber *> * _Null_unspecified backgroundOpacity;
	[Export ("backgroundOpacity", ArgumentSemantic.Assign)]
	MGLStyleValue<NSNumber> BackgroundOpacity { get; set; }

	// @property (nonatomic) MGLTransition backgroundOpacityTransition;
	[Export ("backgroundOpacityTransition", ArgumentSemantic.Assign)]
	MGLTransition BackgroundOpacityTransition { get; set; }

	// @property (nonatomic) MGLStyleValue<NSString *> * _Null_unspecified backgroundPattern;
	[Export ("backgroundPattern", ArgumentSemantic.Assign)]
	MGLStyleValue<NSString> BackgroundPattern { get; set; }

	// @property (nonatomic) MGLTransition backgroundPatternTransition;
	[Export ("backgroundPatternTransition", ArgumentSemantic.Assign)]
	MGLTransition BackgroundPatternTransition { get; set; }
}

// @interface MGLOpenGLStyleLayer : MGLStyleLayer
[BaseType (typeof(MGLStyleLayer))]
interface MGLOpenGLStyleLayer
{
	// @property (readonly, nonatomic, weak) MGLMapView * _Nullable mapView;
	[NullAllowed, Export ("mapView", ArgumentSemantic.Weak)]
	MGLMapView MapView { get; }

	// -(void)didMoveToMapView:(MGLMapView * _Nonnull)mapView;
	[Export ("didMoveToMapView:")]
	void DidMoveToMapView (MGLMapView mapView);

	// -(void)willMoveFromMapView:(MGLMapView * _Nonnull)mapView;
	[Export ("willMoveFromMapView:")]
	void WillMoveFromMapView (MGLMapView mapView);

	// -(void)drawInMapView:(MGLMapView * _Nonnull)mapView withContext:(MGLStyleLayerDrawingContext)context;
	[Export ("drawInMapView:withContext:")]
	void DrawInMapView (MGLMapView mapView, MGLStyleLayerDrawingContext context);

	// -(void)setNeedsDisplay;
	[Export ("setNeedsDisplay")]
	void SetNeedsDisplay ();
}

// @interface MGLSource : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface MGLSource
{
	// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier;
	[Export ("initWithIdentifier:")]
	IntPtr Constructor (string identifier);

	// @property (copy, nonatomic) NSString * _Nonnull identifier;
	[Export ("identifier")]
	string Identifier { get; set; }
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const MGLTileSourceOption _Nonnull MGLTileSourceOptionMinimumZoomLevel __attribute__((visibility("default")));
	[Field ("MGLTileSourceOptionMinimumZoomLevel", "__Internal")]
	NSString MGLTileSourceOptionMinimumZoomLevel { get; }

	// extern const MGLTileSourceOption _Nonnull MGLTileSourceOptionMaximumZoomLevel __attribute__((visibility("default")));
	[Field ("MGLTileSourceOptionMaximumZoomLevel", "__Internal")]
	NSString MGLTileSourceOptionMaximumZoomLevel { get; }

	// extern const MGLTileSourceOption _Nonnull MGLTileSourceOptionAttributionHTMLString __attribute__((visibility("default")));
	[Field ("MGLTileSourceOptionAttributionHTMLString", "__Internal")]
	NSString MGLTileSourceOptionAttributionHTMLString { get; }

	// extern const MGLTileSourceOption _Nonnull MGLTileSourceOptionAttributionInfos __attribute__((visibility("default")));
	[Field ("MGLTileSourceOptionAttributionInfos", "__Internal")]
	NSString MGLTileSourceOptionAttributionInfos { get; }

	// extern const MGLTileSourceOption _Nonnull MGLTileSourceOptionTileCoordinateSystem __attribute__((visibility("default")));
	[Field ("MGLTileSourceOptionTileCoordinateSystem", "__Internal")]
	NSString MGLTileSourceOptionTileCoordinateSystem { get; }
}

// @interface MGLTileSource : MGLSource
[BaseType (typeof(MGLSource))]
[DisableDefaultCtor]
interface MGLTileSource
{
	// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier configurationURL:(NSURL * _Nonnull)configurationURL;
	[Export ("initWithIdentifier:configurationURL:")]
	IntPtr Constructor (string identifier, NSUrl configurationURL);

	// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier tileURLTemplates:(NSArray<NSString *> * _Nonnull)tileURLTemplates options:(NSDictionary<MGLTileSourceOption,id> * _Nullable)options;
	[Export ("initWithIdentifier:tileURLTemplates:options:")]
	IntPtr Constructor (string identifier, string[] tileURLTemplates, [NullAllowed] NSDictionary<NSString, NSObject> options);

	// @property (readonly, copy, nonatomic) NSURL * _Nullable configurationURL;
	[NullAllowed, Export ("configurationURL", ArgumentSemantic.Copy)]
	NSUrl ConfigurationURL { get; }

	// @property (readonly, copy, nonatomic) NSArray<MGLAttributionInfo *> * _Nonnull attributionInfos;
	[Export ("attributionInfos", ArgumentSemantic.Copy)]
	MGLAttributionInfo[] AttributionInfos { get; }
}

// @interface MGLVectorSource : MGLTileSource
[BaseType (typeof(MGLTileSource))]
interface MGLVectorSource
{
	// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier configurationURL:(NSURL * _Nonnull)configurationURL __attribute__((objc_designated_initializer));
	[Export ("initWithIdentifier:configurationURL:")]
	[DesignatedInitializer]
	IntPtr Constructor (string identifier, NSUrl configurationURL);

	// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier tileURLTemplates:(NSArray<NSString *> * _Nonnull)tileURLTemplates options:(NSDictionary<MGLTileSourceOption,id> * _Nullable)options __attribute__((objc_designated_initializer));
	[Export ("initWithIdentifier:tileURLTemplates:options:")]
	[DesignatedInitializer]
	IntPtr Constructor (string identifier, string[] tileURLTemplates, [NullAllowed] NSDictionary<NSString, NSObject> options);

	// -(NSArray<id<MGLFeature>> * _Nonnull)featuresInSourceLayersWithIdentifiers:(NSSet<NSString *> * _Nonnull)sourceLayerIdentifiers predicate:(NSPredicate * _Nullable)predicate;
	[Export ("featuresInSourceLayersWithIdentifiers:predicate:")]
	MGLFeature[] FeaturesInSourceLayersWithIdentifiers (NSSet<NSString> sourceLayerIdentifiers, [NullAllowed] NSPredicate predicate);
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const MGLShapeSourceOption _Nonnull MGLShapeSourceOptionClustered __attribute__((visibility("default")));
	[Field ("MGLShapeSourceOptionClustered", "__Internal")]
	NSString MGLShapeSourceOptionClustered { get; }

	// extern const MGLShapeSourceOption _Nonnull MGLShapeSourceOptionClusterRadius __attribute__((visibility("default")));
	[Field ("MGLShapeSourceOptionClusterRadius", "__Internal")]
	NSString MGLShapeSourceOptionClusterRadius { get; }

	// extern const MGLShapeSourceOption _Nonnull MGLShapeSourceOptionMaximumZoomLevelForClustering __attribute__((visibility("default")));
	[Field ("MGLShapeSourceOptionMaximumZoomLevelForClustering", "__Internal")]
	NSString MGLShapeSourceOptionMaximumZoomLevelForClustering { get; }

	// extern const MGLShapeSourceOption _Nonnull MGLShapeSourceOptionMaximumZoomLevel __attribute__((visibility("default")));
	[Field ("MGLShapeSourceOptionMaximumZoomLevel", "__Internal")]
	NSString MGLShapeSourceOptionMaximumZoomLevel { get; }

	// extern const MGLShapeSourceOption _Nonnull MGLShapeSourceOptionBuffer __attribute__((visibility("default")));
	[Field ("MGLShapeSourceOptionBuffer", "__Internal")]
	NSString MGLShapeSourceOptionBuffer { get; }

	// extern const MGLShapeSourceOption _Nonnull MGLShapeSourceOptionSimplificationTolerance __attribute__((visibility("default")));
	[Field ("MGLShapeSourceOptionSimplificationTolerance", "__Internal")]
	NSString MGLShapeSourceOptionSimplificationTolerance { get; }
}

// @interface MGLShapeSource : MGLSource
[BaseType (typeof(MGLSource))]
interface MGLShapeSource
{
	// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier URL:(NSURL * _Nonnull)url options:(NSDictionary<MGLShapeSourceOption,id> * _Nullable)options __attribute__((objc_designated_initializer));
	[Export ("initWithIdentifier:URL:options:")]
	[DesignatedInitializer]
	IntPtr Constructor (string identifier, NSUrl url, [NullAllowed] NSDictionary<NSString, NSObject> options);

	// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier shape:(MGLShape * _Nullable)shape options:(NSDictionary<MGLShapeSourceOption,id> * _Nullable)options __attribute__((objc_designated_initializer));
	[Export ("initWithIdentifier:shape:options:")]
	[DesignatedInitializer]
	IntPtr Constructor (string identifier, [NullAllowed] MGLShape shape, [NullAllowed] NSDictionary<NSString, NSObject> options);

	// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier features:(NSArray<MGLShape<MGLFeature> *> * _Nonnull)features options:(NSDictionary<MGLShapeSourceOption,id> * _Nullable)options;
	[Export ("initWithIdentifier:features:options:")]
	IntPtr Constructor (string identifier, MGLFeature[] features, [NullAllowed] NSDictionary<NSString, NSObject> options);

	// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier shapes:(NSArray<MGLShape *> * _Nonnull)shapes options:(NSDictionary<MGLShapeSourceOption,id> * _Nullable)options;
	[Export ("initWithIdentifier:shapes:options:")]
	IntPtr Constructor (string identifier, MGLShape[] shapes, [NullAllowed] NSDictionary<NSString, NSObject> options);

	// @property (copy, nonatomic) MGLShape * _Nullable shape;
	[NullAllowed, Export ("shape", ArgumentSemantic.Copy)]
	MGLShape Shape { get; set; }

	// @property (copy, nonatomic) NSURL * _Nullable URL;
	[NullAllowed, Export ("URL", ArgumentSemantic.Copy)]
	NSUrl URL { get; set; }

	// -(NSArray<id<MGLFeature>> * _Nonnull)featuresMatchingPredicate:(NSPredicate * _Nullable)predicate;
	[Export ("featuresMatchingPredicate:")]
	MGLFeature[] FeaturesMatchingPredicate ([NullAllowed] NSPredicate predicate);
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const MGLTileSourceOption _Nonnull MGLTileSourceOptionTileSize __attribute__((visibility("default")));
	[Field ("MGLTileSourceOptionTileSize", "__Internal")]
	NSString MGLTileSourceOptionTileSize { get; }
}

// @interface MGLRasterSource : MGLTileSource
[BaseType (typeof(MGLTileSource))]
interface MGLRasterSource
{
	// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier configurationURL:(NSURL * _Nonnull)configurationURL;
	[Export ("initWithIdentifier:configurationURL:")]
	IntPtr Constructor (string identifier, NSUrl configurationURL);

	// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier configurationURL:(NSURL * _Nonnull)configurationURL tileSize:(CGFloat)tileSize __attribute__((objc_designated_initializer));
	[Export ("initWithIdentifier:configurationURL:tileSize:")]
	[DesignatedInitializer]
	IntPtr Constructor (string identifier, NSUrl configurationURL, nfloat tileSize);

	// -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier tileURLTemplates:(NSArray<NSString *> * _Nonnull)tileURLTemplates options:(NSDictionary<MGLTileSourceOption,id> * _Nullable)options __attribute__((objc_designated_initializer));
	[Export ("initWithIdentifier:tileURLTemplates:options:")]
	[DesignatedInitializer]
	IntPtr Constructor (string identifier, string[] tileURLTemplates, [NullAllowed] NSDictionary<NSString, NSObject> options);
}

// @interface MGLTilePyramidOfflineRegion : NSObject <MGLOfflineRegion, NSSecureCoding, NSCopying>
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface MGLTilePyramidOfflineRegion : IMGLOfflineRegion, INSSecureCoding, INSCopying
{
	// @property (readonly, nonatomic) NSURL * _Nonnull styleURL;
	[Export ("styleURL")]
	NSUrl StyleURL { get; }

	// @property (readonly, nonatomic) MGLCoordinateBounds bounds;
	[Export ("bounds")]
	MGLCoordinateBounds Bounds { get; }

	// @property (readonly, nonatomic) double minimumZoomLevel;
	[Export ("minimumZoomLevel")]
	double MinimumZoomLevel { get; }

	// @property (readonly, nonatomic) double maximumZoomLevel;
	[Export ("maximumZoomLevel")]
	double MaximumZoomLevel { get; }

	// -(instancetype _Nonnull)initWithStyleURL:(NSURL * _Nullable)styleURL bounds:(MGLCoordinateBounds)bounds fromZoomLevel:(double)minimumZoomLevel toZoomLevel:(double)maximumZoomLevel __attribute__((objc_designated_initializer));
	[Export ("initWithStyleURL:bounds:fromZoomLevel:toZoomLevel:")]
	[DesignatedInitializer]
	IntPtr Constructor ([NullAllowed] NSUrl styleURL, MGLCoordinateBounds bounds, double minimumZoomLevel, double maximumZoomLevel);
}

// @interface MGLUserLocation : NSObject <MGLAnnotation, NSSecureCoding>
[BaseType (typeof(NSObject))]
interface MGLUserLocation : IMGLAnnotation, INSSecureCoding
{
	// @property (readonly, nonatomic) CLLocation * _Nullable location;
	[NullAllowed, Export ("location")]
	CLLocation Location { get; }

	// @property (readonly, getter = isUpdating, nonatomic) BOOL updating;
	[Export ("updating")]
	bool Updating { [Bind ("isUpdating")] get; }

	// @property (readonly, nonatomic) CLHeading * _Nullable heading;
	[NullAllowed, Export ("heading")]
	CLHeading Heading { get; }

	// @property (copy, nonatomic) NSString * _Nonnull title;
	[Export ("title")]
	string Title { get; set; }

	// @property (copy, nonatomic) NSString * _Nullable subtitle;
	[NullAllowed, Export ("subtitle")]
	string Subtitle { get; set; }
}

// @interface MGLUserLocationAnnotationView : MGLAnnotationView
[BaseType (typeof(MGLAnnotationView))]
interface MGLUserLocationAnnotationView
{
	// @property (readonly, nonatomic, weak) MGLMapView * _Nullable mapView;
	[NullAllowed, Export ("mapView", ArgumentSemantic.Weak)]
	MGLMapView MapView { get; }

	// @property (readonly, nonatomic, weak) MGLUserLocation * _Nullable userLocation;
	[NullAllowed, Export ("userLocation", ArgumentSemantic.Weak)]
	MGLUserLocation UserLocation { get; }

	// @property (readonly, nonatomic, weak) CALayer * _Nullable hitTestLayer;
	[NullAllowed, Export ("hitTestLayer", ArgumentSemantic.Weak)]
	CALayer HitTestLayer { get; }

	// -(void)update;
	[Export ("update")]
	void Update ();
}

// @interface MGLAdditions (NSValue)
[Category]
[BaseType (typeof(NSValue))]
interface NSValue_MGLAdditions
{
	// +(instancetype _Nonnull)valueWithMGLCoordinate:(CLLocationCoordinate2D)coordinate;
	[Static]
	[Export ("valueWithMGLCoordinate:")]
	NSValue ValueWithMGLCoordinate (CLLocationCoordinate2D coordinate);

	// @property (readonly) CLLocationCoordinate2D MGLCoordinateValue;
	[Export ("MGLCoordinateValue")]
	CLLocationCoordinate2D MGLCoordinateValue { get; }

	// +(instancetype _Nonnull)valueWithMGLCoordinateSpan:(MGLCoordinateSpan)span;
	[Static]
	[Export ("valueWithMGLCoordinateSpan:")]
	NSValue ValueWithMGLCoordinateSpan (MGLCoordinateSpan span);

	// @property (readonly) MGLCoordinateSpan MGLCoordinateSpanValue;
	[Export ("MGLCoordinateSpanValue")]
	MGLCoordinateSpan MGLCoordinateSpanValue { get; }

	// +(instancetype _Nonnull)valueWithMGLCoordinateBounds:(MGLCoordinateBounds)bounds;
	[Static]
	[Export ("valueWithMGLCoordinateBounds:")]
	NSValue ValueWithMGLCoordinateBounds (MGLCoordinateBounds bounds);

	// @property (readonly) MGLCoordinateBounds MGLCoordinateBoundsValue;
	[Export ("MGLCoordinateBoundsValue")]
	MGLCoordinateBounds MGLCoordinateBoundsValue { get; }

	// +(NSValue * _Nonnull)valueWithMGLOfflinePackProgress:(MGLOfflinePackProgress)progress;
	[Static]
	[Export ("valueWithMGLOfflinePackProgress:")]
	NSValue ValueWithMGLOfflinePackProgress (MGLOfflinePackProgress progress);

	// @property (readonly) MGLOfflinePackProgress MGLOfflinePackProgressValue;
	[Export ("MGLOfflinePackProgressValue")]
	MGLOfflinePackProgress MGLOfflinePackProgressValue { get; }

	// +(NSValue * _Nonnull)valueWithMGLTransition:(MGLTransition)transition;
	[Static]
	[Export ("valueWithMGLTransition:")]
	NSValue ValueWithMGLTransition (MGLTransition transition);

	// @property (readonly) MGLTransition MGLTransitionValue;
	[Export ("MGLTransitionValue")]
	MGLTransition MGLTransitionValue { get; }
}

// @interface MGLAttributionInfo : NSObject
[BaseType (typeof(NSObject))]
interface MGLAttributionInfo
{
	// -(instancetype _Nonnull)initWithTitle:(NSAttributedString * _Nonnull)title URL:(NSURL * _Nullable)URL;
	[Export ("initWithTitle:URL:")]
	IntPtr Constructor (NSAttributedString title, [NullAllowed] NSUrl URL);

	// @property (nonatomic) NSAttributedString * _Nonnull title;
	[Export ("title", ArgumentSemantic.Assign)]
	NSAttributedString Title { get; set; }

	// @property (nonatomic) NSURL * _Nullable URL;
	[NullAllowed, Export ("URL", ArgumentSemantic.Assign)]
	NSUrl URL { get; set; }

	// @property (getter = isFeedbackLink, nonatomic) BOOL feedbackLink;
	[Export ("feedbackLink")]
	bool FeedbackLink { [Bind ("isFeedbackLink")] get; set; }

	// -(NSURL * _Nullable)feedbackURLAtCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate zoomLevel:(double)zoomLevel;
	[Export ("feedbackURLAtCenterCoordinate:zoomLevel:")]
	[return: NullAllowed]
	NSUrl FeedbackURLAtCenterCoordinate (CLLocationCoordinate2D centerCoordinate, double zoomLevel);
}
