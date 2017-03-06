using System;
using CoreAnimation;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Mapbox
{
	//@interface MGLAccountManager : NSObject
	[BaseType(typeof(NSObject))]
	public partial interface MGLAccountManager
	{
		//+ (void)setAccessToken:(nullable NSString *)accessToken;
		[Export("setAccessToken:"), Static]
		void SetAccessToken(NSString accessToken);
		//+ (nullable NSString *)accessToken;
		[Export("accessToken"), Static]
		NSString AccessToken();
		//@end
	}

	[BaseType(typeof(NSObject)), Model, Protocol]
	public partial interface MGLAnnotation
	{
		//@property (nonatomic, readonly) CLLocationCoordinate2D coordinate;
		[Export("coordinate")]
		CLLocationCoordinate2D Coordinate { get; }
		//@optional
		//@property (nonatomic, readonly, copy, nullable) NSString *title;
		[Export("title")]
		string Title { get; }
		//@property (nonatomic, readonly, copy, nullable) NSString *subtitle;
		[Export("subtitle")]
		string Subtitle { get; }
		////#if !TARGET_OS_IPHONE
		////@property (nonatomic, readonly, copy, nullable) NSString *toolTip;
		//[Export("toolTip")]
		//NSString ToolTip { get; }
		////#endif
		////@end
	}
	//@interface MGLAnnotationImage : NSObject <NSSecureCoding>
	[BaseType(typeof(NSObject))]
	public partial interface MGLAnnotationImage : INSSecureCoding
	{
		//+ (instancetype)annotationImageWithImage:(UIImage *)image reuseIdentifier:(NSString *)reuseIdentifier;
		[Export("annotationImageWithImage:reuseIdentifier:"), Static]
		MGLAnnotationImage AnnotationImageWithImage(UIImage image, NSString reuseIdentifier);
		//@property (nonatomic, strong, nullable) UIImage *image;
		[Export("image")]
		UIImage Image { get; set; }
		//@property (nonatomic, readonly) NSString *reuseIdentifier;
		[Export("reuseIdentifier")]
		NSString ReuseIdentifier { get; }
		//@property (nonatomic, getter=isEnabled) BOOL enabled;
		[Export("enabled")]
		bool Enabled { [Export("isEnabled")]get; set; }
		//@end
	}
	//@interface MGLAnnotationView : UIView <NSSecureCoding>
	[BaseType(typeof(UIView))]
	public partial interface MGLAnnotationView : INSSecureCoding
	{
		//- (instancetype)initWithReuseIdentifier:(nullable NSString *)reuseIdentifier;
		[Export("initWithReuseIdentifier:"),]
		IntPtr Constructor(NSString reuseIdentifier);
		//- (void)prepareForReuse;
		[Export("prepareForReuse"),]
		void PrepareForReuse();
		//@property (nonatomic, readonly, nullable) id <MGLAnnotation> annotation;
		[Export("annotation")]
		IMGLAnnotation Annotation { get; }
		//@property (nonatomic, readonly, nullable) NSString *reuseIdentifier;
		[Export("reuseIdentifier")]
		NSString ReuseIdentifier { get; }
		//@property (nonatomic) CGVector centerOffset;
		[Export("centerOffset")]
		CGVector CenterOffset { get; set; }
		//@property (nonatomic, assign) BOOL scalesWithViewingDistance;
		[Export("scalesWithViewingDistance")]
		bool ScalesWithViewingDistance { get; set; }
		//@property (nonatomic, assign, getter=isSelected) BOOL selected;
		[Export("selected")]
		bool Selected { [Export("isSelected")]get; set; }
		//- (void)setSelected:(BOOL)selected animated:(BOOL)animated;
		[Export("setSelected:animated:"),]
		void SetSelected(bool selected, bool animated);
		//@property (nonatomic, assign, getter=isEnabled) BOOL enabled;
		[Export("enabled")]
		bool Enabled { [Export("isEnabled")]get; set; }
		//@property (nonatomic, assign, getter=isDraggable) BOOL draggable;
		[Export("draggable")]
		bool Draggable { [Export("isDraggable")]get; set; }
		//@property (nonatomic, readonly) MGLAnnotationViewDragState dragState;
		[Export("dragState")]
		MGLAnnotationViewDragState DragState { get; }
		//- (void)setDragState:(MGLAnnotationViewDragState)dragState animated:(BOOL)animated NS_REQUIRES_SUPER;
		[Export("setDragState:animated:"),]
		void SetDragState(MGLAnnotationViewDragState dragState, bool animated);
		//@end
	}
	//@interface MGLAttributionInfo : NSObject
	[BaseType(typeof(NSObject))]
	public partial interface MGLAttributionInfo
	{
		//- (instancetype)initWithTitle:(NSAttributedString *)title URL:(nullable NSUrl *)URL;
		[Export("initWithTitle:URL:"),]
		IntPtr Constructor(NSAttributedString title, NSUrl URL);
		//@property (nonatomic) NSAttributedString *title;
		[Export("title")]
		NSAttributedString Title { get; set; }
		//@property (nonatomic, nullable) NSUrl *URL;
		[Export("URL")]
		NSUrl URL { get; set; }
		//@property (nonatomic, getter=isFeedbackLink) BOOL feedbackLink;
		[Export("feedbackLink")]
		bool FeedbackLink { [Export("isFeedbackLink")]get; set; }
		//- (nullable NSUrl *)feedbackURLAtCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate zoomLevel:(double)zoomLevel;
		[Export("feedbackURLAtCenterCoordinate:zoomLevel:"),]
		NSUrl FeedbackURLAtCenterCoordinate(CLLocationCoordinate2D centerCoordinate, double zoomLevel);
		//@end
	}
	//@interface MGLBackgroundStyleLayer : MGLStyleLayer
	[BaseType(typeof(MGLStyleLayer))]
	public partial interface MGLBackgroundStyleLayer
	{
		//- (instancetype)initWithIdentifier:(NSString *)identifier NS_DESIGNATED_INITIALIZER;
		[Export("initWithIdentifier:"),]
		IntPtr Constructor(NSString identifier);
		//#if TARGET_OS_IPHONE
		//@property (nonatomic, null_resettable) MGLStyleValue<UIColor *> *backgroundColor;
		[Export("backgroundColor")]
		MGLStyleValue<UIColor> BackgroundColor { get; set; }
		//#else
		//@property (nonatomic, null_resettable) MGLStyleValue<NSColor *> *backgroundColor;
		//[Export("backgroundColor")]
		//MGLStyleValue<NSColor> BackgroundColor { get; set; }
		//#endif
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *backgroundOpacity;
		[Export("backgroundOpacity")]
		MGLStyleValue<NSNumber> BackgroundOpacity { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSString *> *backgroundPattern;
		[Export("backgroundPattern")]
		MGLStyleValue<NSString> BackgroundPattern { get; set; }
		//@end
	}

	[BaseType(typeof(NSObject)), Model, Protocol]
	public partial interface MGLCalloutView
	{
		//@property (nonatomic, strong) id <MGLAnnotation> representedObject;
		[Export("representedObject")]
		IMGLAnnotation RepresentedObject { get; set; }
		//@property (nonatomic, strong) UIView *leftAccessoryView;
		[Export("leftAccessoryView")]
		UIView LeftAccessoryView { get; set; }
		//@property (nonatomic, strong) UIView *rightAccessoryView;
		[Export("rightAccessoryView")]
		UIView RightAccessoryView { get; set; }
		//@property (nonatomic, weak) id<MGLCalloutViewDelegate> delegate;
		[Export("delegate")]
		IMGLCalloutViewDelegate Delegate { get; set; }
		//- (void)presentCalloutFromRect:(CGRect)rect inView:(UIView *)view constrainedToView:(UIView *)constrainedView animated:(BOOL)animated;
		[Export("presentCalloutFromRect:inView:constrainedToView:animated:"),]
		void PresentCalloutFromRect(CGRect rect, UIView view, UIView constrainedView, bool animated);
		//- (void)dismissCalloutAnimated:(BOOL)animated;
		[Export("dismissCalloutAnimated:"),]
		void DismissCalloutAnimated(bool animated);
		//@optional
		//@property (nonatomic, readonly, assign, getter=isAnchoredToAnnotation) BOOL anchoredToAnnotation;
		[Export("anchoredToAnnotation")]
		bool AnchoredToAnnotation { [Export("isAnchoredToAnnotation")]get; }
		//@property (nonatomic, readonly, assign) BOOL dismissesAutomatically;
		[Export("dismissesAutomatically")]
		bool DismissesAutomatically { get; }
		//@end
	}

	[BaseType(typeof(NSObject)), Model, Protocol]
	public partial interface MGLCalloutViewDelegate
	{
		//@optional
		//- (BOOL)calloutViewShouldHighlight:(UIView<MGLCalloutView> *)calloutView;
		[Export("calloutViewShouldHighlight:"),]
		bool CalloutViewShouldHighlight(UIView calloutView);
		//- (void)calloutViewTapped:(UIView<MGLCalloutView> *)calloutView;
		[Export("calloutViewTapped:"),]
		void CalloutViewTapped(UIView calloutView);
		//- (void)calloutViewWillAppear:(UIView<MGLCalloutView> *)calloutView;
		[Export("calloutViewWillAppear:"),]
		void CalloutViewWillAppear(UIView calloutView);
		//- (void)calloutViewDidAppear:(UIView<MGLCalloutView> *)calloutView;
		[Export("calloutViewDidAppear:"),]
		void CalloutViewDidAppear(UIView calloutView);
		//@end
	}
	//### Example
	//@interface MGLCircleStyleLayer : MGLVectorStyleLayer
	[BaseType(typeof(MGLVectorStyleLayer))]
	public partial interface MGLCircleStyleLayer
	{
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *circleBlur;
		[Export("circleBlur")]
		MGLStyleValue<NSNumber> CircleBlur { get; set; }
		//#if TARGET_OS_IPHONE
		//@property (nonatomic, null_resettable) MGLStyleValue<UIColor *> *circleColor;
		[Export("circleColor")]
		MGLStyleValue<UIColor> CircleColor { get; set; }
		//#else
		//@property (nonatomic, null_resettable) MGLStyleValue<NSColor *> *circleColor;
		//[Export("circleColor")]
		//MGLStyleValue<NSColor> CircleColor { get; set; }
		//#endif
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *circleOpacity;
		[Export("circleOpacity")]
		MGLStyleValue<NSNumber> CircleOpacity { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *circleRadius;
		[Export("circleRadius")]
		MGLStyleValue<NSNumber> CircleRadius { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *circleScaleAlignment;
		[Export("circleScaleAlignment")]
		MGLStyleValue<NSValue> CircleScaleAlignment { get; set; }
		//#if TARGET_OS_IPHONE
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *circleTranslation;
		[Export("circleTranslation")]
		MGLStyleValue<NSValue> CircleTranslation { get; set; }
		//#else
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *circleTranslation;
		//[Export("circleTranslation")]
		//MGLStyleValue<NSValue> CircleTranslation { get; set; }
		//#endif
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *circleTranslationAnchor;
		[Export("circleTranslationAnchor")]
		MGLStyleValue<NSValue> CircleTranslationAnchor { get; set; }
		//@end
	}
	//@interface NSValue (MGLCircleStyleLayerAdditions)
	[BaseType(typeof(NSValue)), Category]
	public partial interface MGLCircleStyleLayerAdditions
	{
		//+ (instancetype)valueWithMGLCircleScaleAlignment:(MGLCircleScaleAlignment)circleScaleAlignment;
		[Export("valueWithMGLCircleScaleAlignment:"), Static]
		NSValue ValueWithMGLCircleScaleAlignment(MGLCircleScaleAlignment circleScaleAlignment);
		//@property (readonly) MGLCircleScaleAlignment MGLCircleScaleAlignmentValue;
		[Export("MGLCircleScaleAlignmentValue"), Static]
		MGLCircleScaleAlignment GetMGLCircleScaleAlignmentValue();
		//+ (instancetype)valueWithMGLCircleTranslationAnchor:(MGLCircleTranslationAnchor)circleTranslationAnchor;
		[Export("valueWithMGLCircleTranslationAnchor:"), Static]
		NSValue ValueWithMGLCircleTranslationAnchor(MGLCircleTranslationAnchor circleTranslationAnchor);
		//@property (readonly) MGLCircleTranslationAnchor MGLCircleTranslationAnchorValue;
		[Export("MGLCircleTranslationAnchorValue"), Static]
		MGLCircleTranslationAnchor GetMGLCircleTranslationAnchorValue();
		//@end
	}
	//@interface MGLClockDirectionFormatter : NSFormatter
	[BaseType(typeof(NSFormatter))]
	public partial interface MGLClockDirectionFormatter
	{
		//@property (nonatomic) NSFormattingUnitStyle unitStyle;
		[Export("unitStyle")]
		NSFormattingUnitStyle UnitStyle { get; set; }
		//- (NSString *)stringFromDirection:(nfloat)direction;
		[Export("stringFromDirection:"),]
		NSString StringFromDirection(nfloat direction);
		//- (BOOL)getObjectValue:(out id __nullable * __nullable)obj forString:(NSString *)string errorDescription:(out NSString * __nullable * __nullable)error;
		[Export("getObjectValue:forString:errorDescription:")]
		bool GetObjectValue(NSNumber MGLMapViewDecelerationRat, NSString @string, out NSString error);
		//@end
	}
	//@interface MGLCompassDirectionFormatter : NSFormatter
	[BaseType(typeof(NSFormatter))]
	public partial interface MGLCompassDirectionFormatter
	{
		//@property (nonatomic) NSFormattingUnitStyle unitStyle;
		[Export("unitStyle")]
		NSFormattingUnitStyle UnitStyle { get; set; }
		//- (NSString *)stringFromDirection:(nfloat)direction;
		[Export("stringFromDirection:"),]
		NSString StringFromDirection(nfloat direction);
		//- (BOOL)getObjectValue:(out id __nullable * __nullable)obj forString:(NSString *)string errorDescription:(out NSString * __nullable * __nullable)error;
		[Export("getObjectValue:forString:errorDescription:")]
		bool GetObjectValue(out NSObject obj, NSString @string, out NSString error);
		//@end
	}
	//@interface MGLCoordinateFormatter : NSFormatter
	[BaseType(typeof(NSFormatter))]
	public partial interface MGLCoordinateFormatter
	{
		//@property (nonatomic) BOOL allowsMinutes;
		[Export("allowsMinutes")]
		bool AllowsMinutes { get; set; }
		//@property (nonatomic) BOOL allowsSeconds;
		[Export("allowsSeconds")]
		bool AllowsSeconds { get; set; }
		//@property (nonatomic) NSFormattingUnitStyle unitStyle;
		[Export("unitStyle")]
		NSFormattingUnitStyle UnitStyle { get; set; }
		//- (NSString *)stringFromCoordinate:(CLLocationCoordinate2D)coordinate;
		[Export("stringFromCoordinate:"),]
		NSString StringFromCoordinate(CLLocationCoordinate2D coordinate);
		//- (BOOL)getObjectValue:(out id __nullable * __nullable)obj forString:(NSString *)string errorDescription:(out NSString * __nullable * __nullable)error;
		[Export("getObjectValue:forString:errorDescription:"),]
		bool GetObjectValue(out NSObject obj, NSString @string, out NSString error);
		//@end
	}

	[BaseType(typeof(NSObject)), Model, Protocol]
	public partial interface MGLFeature : MGLAnnotation
	{
		//@property (nonatomic, copy, nullable) id identifier;
		[Export("identifier")]
		NSObject Identifier { get; set; }
		//@property (nonatomic, copy) NS_DICTIONARY_OF(NSString *, id) *attributes;
		[Export("attributes")]
		NSDictionary<NSString, NSObject> Attributes { get; set; }
		//- (nullable id)attributeForKey:(NSString *)key;
		[Export("attributeForKey:"),]
		NSObject AttributeForKey(NSString key);
		//- (NS_DICTIONARY_OF(NSString *, id) *)geoJSONDictionary;
		[Export("geoJSONDictionary"),]
		NSDictionary<NSString, NSObject> GeoJSONDictionary();
		//@end
	}
	//@interface MGLPointFeature : MGLPointAnnotation <MGLFeature>
	[BaseType(typeof(MGLPointAnnotation))]
	public partial interface MGLPointFeature : MGLFeature
	{
		//@end
	}
	//@interface MGLPolylineFeature : MGLPolyline <MGLFeature>
	[BaseType(typeof(MGLPolyline))]
	public partial interface MGLPolylineFeature : MGLFeature
	{
		//@end
	}
	//@interface MGLPolygonFeature : MGLPolygon <MGLFeature>
	[BaseType(typeof(MGLPolygon))]
	public partial interface MGLPolygonFeature : MGLFeature
	{
		//@end
	}
	//@interface MGLPointCollectionFeature : MGLPointCollection <MGLFeature>
	[BaseType(typeof(MGLPointCollection))]
	public partial interface MGLPointCollectionFeature : MGLFeature
	{
		//@end
	}
	//@compatibility_alias MGLMultiPointFeature MGLPointCollectionFeature;
	//@interface MGLMultiPolylineFeature : MGLMultiPolyline <MGLFeature>
	[BaseType(typeof(MGLMultiPolyline))]
	public partial interface MGLMultiPolylineFeature : MGLFeature
	{
		//@end
	}
	//@interface MGLMultiPolygonFeature : MGLMultiPolygon <MGLFeature>
	[BaseType(typeof(MGLMultiPolygon))]
	public partial interface MGLMultiPolygonFeature : MGLFeature
	{
		//@end
	}
	//@interface MGLShapeCollectionFeature : MGLShapeCollection <MGLFeature>
	[BaseType(typeof(MGLShapeCollection))]
	public partial interface MGLShapeCollectionFeature : MGLFeature
	{
		//@property (nonatomic, copy, readonly) NS_ARRAY_OF(MGLShape<MGLFeature> *) *shapes;
		[Export("shapes")]
		MGLShape[] Shapes { get; }
		//+ (instancetype)shapeCollectionWithShapes:(NS_ARRAY_OF(MGLShape<MGLFeature> *) *)shapes;
		[Export("shapeCollectionWithShapes:"), Static]
		MGLShapeCollectionFeature ShapeCollectionWithShapes(MGLShape[] shapes);
		//@end
	}
	//### Example
	//@interface MGLFillStyleLayer : MGLVectorStyleLayer
	[BaseType(typeof(MGLVectorStyleLayer))]
	public partial interface MGLFillStyleLayer
	{
		//@property (nonatomic, null_resettable, getter=isFillAntialiased) MGLStyleValue<NSNumber *> *fillAntialiased;
		[Export("fillAntialiased")]
		MGLStyleValue<NSNumber> FillAntialiased { [Export("isFillAntialiased")]get; set; }
		//#if TARGET_OS_IPHONE
		//@property (nonatomic, null_resettable) MGLStyleValue<UIColor *> *fillColor;
		[Export("fillColor")]
		MGLStyleValue<UIColor> FillColor { get; set; }
		//#else
		//@property (nonatomic, null_resettable) MGLStyleValue<NSColor *> *fillColor;
		//[Export("fillColor")]
		//MGLStyleValue<NSColor> FillColor { get; set; }
		//#endif
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *fillOpacity;
		[Export("fillOpacity")]
		MGLStyleValue<NSNumber> FillOpacity { get; set; }
		//#if TARGET_OS_IPHONE
		//@property (nonatomic, null_resettable) MGLStyleValue<UIColor *> *fillOutlineColor;
		[Export("fillOutlineColor")]
		MGLStyleValue<UIColor> FillOutlineColor { get; set; }
		//#else
		//@property (nonatomic, null_resettable) MGLStyleValue<NSColor *> *fillOutlineColor;
		//[Export("fillOutlineColor")]
		//MGLStyleValue<NSColor> FillOutlineColor { get; set; }
		//#endif
		//@property (nonatomic, null_resettable) MGLStyleValue<NSString *> *fillPattern;
		[Export("fillPattern")]
		MGLStyleValue<NSString> FillPattern { get; set; }
		//#if TARGET_OS_IPHONE
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *fillTranslation;
		[Export("fillTranslation")]
		MGLStyleValue<NSValue> FillTranslation { get; set; }
		//#else
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *fillTranslation;
		//[Export("fillTranslation")]
		//MGLStyleValue<NSValue> FillTranslation { get; set; }
		//#endif
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *fillTranslationAnchor;
		[Export("fillTranslationAnchor")]
		MGLStyleValue<NSValue> FillTranslationAnchor { get; set; }
		//@end
	}
	//@interface NSValue (MGLFillStyleLayerAdditions)
	[BaseType(typeof(NSValue)), Category]
	public partial interface MGLFillStyleLayerAdditions
	{
		//+ (instancetype)valueWithMGLFillTranslationAnchor:(MGLFillTranslationAnchor)fillTranslationAnchor;
		[Export("valueWithMGLFillTranslationAnchor:"), Static]
		NSValue ValueWithMGLFillTranslationAnchor(MGLFillTranslationAnchor fillTranslationAnchor);
		//@property (readonly) MGLFillTranslationAnchor MGLFillTranslationAnchorValue;
		[Export("MGLFillTranslationAnchorValue"), Static]
		MGLFillTranslationAnchor GetMGLFillTranslationAnchorValue();
		//@end
	}
	//@interface MGLForegroundStyleLayer : MGLStyleLayer
	[BaseType(typeof(MGLStyleLayer))]
	public partial interface MGLForegroundStyleLayer
	{
		//- (instancetype)initWithIdentifier:(NSString *)identifier source:(MGLSource *)source NS_DESIGNATED_INITIALIZER;
		[Export("initWithIdentifier:source:"),]
		IntPtr Constructor(NSString identifier, MGLSource source);
		//@property (nonatomic, readonly, nullable) NSString *sourceIdentifier;
		[Export("sourceIdentifier")]
		NSString SourceIdentifier { get; }
		//@end
	}
	//extern MGLCoordinateSpan MGLCoordinateSpanZero;
	[Static]
	public partial interface Constants
	{
		//[Field("MGLCoordinateSpanZero", "__Internal")]
		//MGLCoordinateSpan MGLCoordinateSpanZero { get; set; }
	}
	//### Example
	//@interface MGLLineStyleLayer : MGLVectorStyleLayer
	[BaseType(typeof(MGLVectorStyleLayer))]
	public partial interface MGLLineStyleLayer
	{
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *lineCap;
		[Export("lineCap")]
		MGLStyleValue<NSValue> LineCap { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *lineJoin;
		[Export("lineJoin")]
		MGLStyleValue<NSValue> LineJoin { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *lineMiterLimit;
		[Export("lineMiterLimit")]
		MGLStyleValue<NSNumber> LineMiterLimit { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *lineRoundLimit;
		[Export("lineRoundLimit")]
		MGLStyleValue<NSNumber> LineRoundLimit { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *lineBlur;
		[Export("lineBlur")]
		MGLStyleValue<NSNumber> LineBlur { get; set; }
		//#if TARGET_OS_IPHONE
		//@property (nonatomic, null_resettable) MGLStyleValue<UIColor *> *lineColor;
		[Export("lineColor")]
		MGLStyleValue<UIColor> LineColor { get; set; }
		//#else
		//@property (nonatomic, null_resettable) MGLStyleValue<NSColor *> *lineColor;
		//[Export("lineColor")]
		//MGLStyleValue<NSColor> LineColor { get; set; }
		//#endif
		//@property (nonatomic, null_resettable) MGLStyleValue<NSArray<NSNumber *> *> *lineDashPattern;
		[Export("lineDashPattern")]
		MGLStyleValue<NSArray<NSNumber>> LineDashPattern { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *lineGapWidth;
		[Export("lineGapWidth")]
		MGLStyleValue<NSNumber> LineGapWidth { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *lineOffset;
		[Export("lineOffset")]
		MGLStyleValue<NSNumber> LineOffset { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *lineOpacity;
		[Export("lineOpacity")]
		MGLStyleValue<NSNumber> LineOpacity { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSString *> *linePattern;
		[Export("linePattern")]
		MGLStyleValue<NSString> LinePattern { get; set; }
		//#if TARGET_OS_IPHONE
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *lineTranslation;
		[Export("lineTranslation")]
		MGLStyleValue<NSValue> LineTranslation { get; set; }
		//#else
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *lineTranslation;
		//[Export("lineTranslation")]
		//MGLStyleValue<NSValue> LineTranslation { get; set; }
		//#endif
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *lineTranslationAnchor;
		[Export("lineTranslationAnchor")]
		MGLStyleValue<NSValue> LineTranslationAnchor { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *lineWidth;
		[Export("lineWidth")]
		MGLStyleValue<NSNumber> LineWidth { get; set; }
		//@end
	}
	//@interface NSValue (MGLLineStyleLayerAdditions)
	[BaseType(typeof(NSValue)), Category]
	public partial interface MGLLineStyleLayerAdditions
	{
		//+ (instancetype)valueWithMGLLineCap:(MGLLineCap)lineCap;
		[Export("valueWithMGLLineCap:"), Static]
		NSValue ValueWithMGLLineCap(MGLLineCap lineCap);
		//@property (readonly) MGLLineCap MGLLineCapValue;
		[Export("MGLLineCapValue"), Static]
		MGLLineCap GetMGLLineCapValue();
		//+ (instancetype)valueWithMGLLineJoin:(MGLLineJoin)lineJoin;
		[Export("valueWithMGLLineJoin:"), Static]
		NSValue ValueWithMGLLineJoin(MGLLineJoin lineJoin);
		//@property (readonly) MGLLineJoin MGLLineJoinValue;
		[Export("MGLLineJoinValue"), Static]
		MGLLineJoin GetMGLLineJoinValue();
		//+ (instancetype)valueWithMGLLineTranslationAnchor:(MGLLineTranslationAnchor)lineTranslationAnchor;
		[Export("valueWithMGLLineTranslationAnchor:"), Static]
		NSValue ValueWithMGLLineTranslationAnchor(MGLLineTranslationAnchor lineTranslationAnchor);
		//@property (readonly) MGLLineTranslationAnchor MGLLineTranslationAnchorValue;
		[Export("MGLLineTranslationAnchorValue"), Static]
		MGLLineTranslationAnchor GetMGLLineTranslationAnchorValue();
		//@end
	}
	//@interface MGLMapCamera : NSObject <NSSecureCoding, NSCopying>
	[BaseType(typeof(NSObject))]
	public partial interface MGLMapCamera : INSSecureCoding, INSCopying
	{
		//@property (nonatomic) CLLocationCoordinate2D centerCoordinate;
		[Export("centerCoordinate")]
		CLLocationCoordinate2D CenterCoordinate { get; set; }
		//@property (nonatomic) nfloat heading;
		[Export("heading")]
		nfloat Heading { get; set; }
		//@property (nonatomic) nfloat pitch;
		[Export("pitch")]
		nfloat Pitch { get; set; }
		//@property (nonatomic) nfloat altitude;
		[Export("altitude")]
		nfloat Altitude { get; set; }
		//+ (instancetype)camera;
		[Export("camera"), Static]
		MGLMapCamera Camera();
		//+ (instancetype)cameraLookingAtCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate
		[Export("cameraLookingAtCenterCoordinate:"), Static]
		MGLMapCamera CameraLookingAtCenterCoordinate(CLLocationCoordinate2D centerCoordinate);
		////+ (instancetype)cameraLookingAtCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate
		//[Export("cameraLookingAtCenterCoordinate:"), Static]
		//MGLMapCamera CameraLookingAtCenterCoordinate(CLLocationCoordinate2D centerCoordinate);
		//@end
	}
	//TODO
	//	//@interface MGLMapView (IBAdditions)
	//	[BaseType(typeof(MGLMapView)), Category]
	//	public partial interface IBAdditions
	//	{
	//		//#if TARGET_INTERFACE_BUILDER
	//		//@property (nonatomic, nullable) IBInspectable NSString *styleURL__;
	//		[Export("styleURL__")]
	//		IBInspectable NSString StyleURL__ { get; set; }
	//	//#endif // TARGET_INTERFACE_BUILDER
	//	//@property (nonatomic) IBInspectable double latitude;
	//	[Export("latitude")]
	//	IBInspectable double Latitude { get; set; }
	//	//@property (nonatomic) IBInspectable double longitude;
	//	[Export("longitude")]
	//	IBInspectable double Longitude { get; set; }
	//	//@property (nonatomic) IBInspectable double zoomLevel;
	//	[Export("zoomLevel")]
	//	IBInspectable double ZoomLevel { get; set; }
	//	//@property (nonatomic) IBInspectable BOOL allowsZooming;
	//	[Export("allowsZooming")]
	//	IBInspectable BOOL AllowsZooming { get; set; }
	////@property (nonatomic) IBInspectable BOOL allowsScrolling;
	//[Export("allowsScrolling")]
	//IBInspectable BOOL AllowsScrolling { get; set; }
	////@property (nonatomic) IBInspectable BOOL allowsRotating;
	//[Export("allowsRotating")]
	//IBInspectable BOOL AllowsRotating { get; set; }
	////@property (nonatomic) IBInspectable BOOL allowsTilting;
	//[Export("allowsTilting")]
	//IBInspectable BOOL AllowsTilting { get; set; }
	////@property (nonatomic) IBInspectable BOOL showsUserLocation;
	//[Export("showsUserLocation")]
	//IBInspectable BOOL ShowsUserLocation { get; set; }
	////@end
	//}
	//extern nfloat MGLMapViewDecelerationRateNormal;
	//[Static]
	public partial interface Constants
	{
		[Field("MGLMapViewDecelerationRateNormal", "__Internal")]
		nfloat MGLMapViewDecelerationRateNormal { get; }
	}
	//extern nfloat MGLMapViewDecelerationRateFast;
	//[Static]
	public partial interface Constants
	{
		[Field("MGLMapViewDecelerationRateFast", "__Internal")]
		nfloat MGLMapViewDecelerationRateFast { get; }
	}
	//extern nfloat MGLMapViewDecelerationRateImmediate;
	//[Static]
	public partial interface Constants
	{
		[Field("MGLMapViewDecelerationRateImmediate", "__Internal")]
		nfloat MGLMapViewDecelerationRateImmediate { get; }
	}
	//@interface MGLMapView : UIView
	[BaseType(typeof(UIView))]
	public partial interface MGLMapView
	{
		//- (instancetype)initWithFrame:(CGRect)frame;
		[Export("initWithFrame:"),]
		IntPtr Constructor(CGRect frame);
		//- (instancetype)initWithFrame:(CGRect)frame styleURL:(nullable NSUrl *)styleURL;
		[Export("initWithFrame:styleURL:"),]
		IntPtr Constructor(CGRect frame, NSUrl styleURL);
		//@property(nonatomic, weak, nullable) IBOutlet id<MGLMapViewDelegate> delegate;
		[Export("delegate")]
		IMGLMapViewDelegate Delegate { get; set; }
		//@property (nonatomic, readonly, nullable) MGLStyle *style;
		[Export("style")]
		MGLStyle Style { get; }
		//@property (nonatomic, null_resettable) NSUrl *styleURL;
		[Export("styleURL")]
		NSUrl StyleURL { get; set; }
		//- (void)reloadStyle:(id)sender;
		[Export("reloadStyle:"),]
		void ReloadStyle(NSObject sender);
		//@property (nonatomic, readonly) UIImageView *compassView;
		[Export("compassView")]
		UIImageView CompassView { get; }
		//@property (nonatomic, readonly) UIImageView *logoView;
		[Export("logoView")]
		UIImageView LogoView { get; }
		//@property (nonatomic, readonly) UIButton *attributionButton;
		[Export("attributionButton")]
		UIButton AttributionButton { get; }
		//@property (nonatomic, assign) BOOL showsUserLocation;
		[Export("showsUserLocation")]
		bool ShowsUserLocation { get; set; }
		//@property (nonatomic, assign, readonly, getter=isUserLocationVisible) BOOL userLocationVisible;
		[Export("userLocationVisible")]
		bool UserLocationVisible { [Export("isUserLocationVisible")]get; }
		//@property (nonatomic, readonly, nullable) MGLUserLocation *userLocation;
		[Export("userLocation")]
		MGLUserLocation UserLocation { get; }
		//@property (nonatomic, assign) MGLUserTrackingMode userTrackingMode;
		[Export("userTrackingMode")]
		MGLUserTrackingMode UserTrackingMode { get; set; }
		//- (void)setUserTrackingMode:(MGLUserTrackingMode)mode animated:(BOOL)animated;
		[Export("setUserTrackingMode:animated:"),]
		void SetUserTrackingMode(MGLUserTrackingMode mode, bool animated);
		//@property (nonatomic, assign) MGLAnnotationVerticalAlignment userLocationVerticalAlignment;
		[Export("userLocationVerticalAlignment")]
		MGLAnnotationVerticalAlignment UserLocationVerticalAlignment { get; set; }
		//- (void)setUserLocationVerticalAlignment:(MGLAnnotationVerticalAlignment)alignment animated:(BOOL)animated;
		[Export("setUserLocationVerticalAlignment:animated:"),]
		void SetUserLocationVerticalAlignment(MGLAnnotationVerticalAlignment alignment, bool animated);
		//@property (nonatomic, assign) BOOL displayHeadingCalibration;
		[Export("displayHeadingCalibration")]
		bool DisplayHeadingCalibration { get; set; }
		//@property (nonatomic, assign) CLLocationCoordinate2D targetCoordinate;
		[Export("targetCoordinate")]
		CLLocationCoordinate2D TargetCoordinate { get; set; }
		//- (void)setTargetCoordinate:(CLLocationCoordinate2D)targetCoordinate animated:(BOOL)animated;
		[Export("setTargetCoordinate:animated:"),]
		void SetTargetCoordinate(CLLocationCoordinate2D targetCoordinate, bool animated);
		//@property(nonatomic, getter=isZoomEnabled) BOOL zoomEnabled;
		[Export("zoomEnabled")]
		bool ZoomEnabled { [Export("isZoomEnabled")]get; set; }
		//@property(nonatomic, getter=isScrollEnabled) BOOL scrollEnabled;
		[Export("scrollEnabled")]
		bool ScrollEnabled { [Export("isScrollEnabled")]get; set; }
		//@property(nonatomic, getter=isRotateEnabled) BOOL rotateEnabled;
		[Export("rotateEnabled")]
		bool RotateEnabled { [Export("isRotateEnabled")]get; set; }
		//@property(nonatomic, getter=isPitchEnabled) BOOL pitchEnabled;
		[Export("pitchEnabled")]
		bool PitchEnabled { [Export("isPitchEnabled")]get; set; }
		//@property(nonatomic) nfloat decelerationRate;
		[Export("decelerationRate")]
		nfloat DecelerationRate { get; set; }
		//@property (nonatomic) CLLocationCoordinate2D centerCoordinate;
		[Export("centerCoordinate")]
		CLLocationCoordinate2D CenterCoordinate { get; set; }
		//- (void)setCenterCoordinate:(CLLocationCoordinate2D)coordinate animated:(BOOL)animated;
		[Export("setCenterCoordinate:animated:"),]
		void SetCenterCoordinate(CLLocationCoordinate2D coordinate, bool animated);
		//- (void)setCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate zoomLevel:(double)zoomLevel animated:(BOOL)animated;
		[Export("setCenterCoordinate:zoomLevel:animated:"),]
		void SetCenterCoordinate(CLLocationCoordinate2D centerCoordinate, double zoomLevel, bool animated);
		//- (void)setCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate zoomLevel:(double)zoomLevel direction:(nfloat)direction animated:(BOOL)animated;
		[Export("setCenterCoordinate:zoomLevel:direction:animated:"),]
		void SetCenterCoordinate(CLLocationCoordinate2D centerCoordinate, double zoomLevel, nfloat direction, bool animated);
		//- (void)setCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate zoomLevel:(double)zoomLevel direction:(nfloat)direction animated:(BOOL)animated completionHandler:(nullable Action)completion;
		[Export("setCenterCoordinate:zoomLevel:direction:animated:completionHandler:"),]
		void SetCenterCoordinate(CLLocationCoordinate2D centerCoordinate, double zoomLevel, nfloat direction, bool animated, Default completion);
		//@property (nonatomic) double zoomLevel;
		[Export("zoomLevel")]
		double ZoomLevel { get; set; }
		//- (void)setZoomLevel:(double)zoomLevel animated:(BOOL)animated;
		[Export("setZoomLevel:animated:"),]
		void SetZoomLevel(double zoomLevel, bool animated);
		//@property (nonatomic) double minimumZoomLevel;
		[Export("minimumZoomLevel")]
		double MinimumZoomLevel { get; set; }
		//@property (nonatomic) double maximumZoomLevel;
		[Export("maximumZoomLevel")]
		double MaximumZoomLevel { get; set; }
		//@property (nonatomic) nfloat direction;
		[Export("direction")]
		nfloat Direction { get; set; }
		//- (void)setDirection:(nfloat)direction animated:(BOOL)animated;
		[Export("setDirection:animated:"),]
		void SetDirection(nfloat direction, bool animated);
		//- (void)resetNorth;
		[Export("resetNorth"),]
		void ResetNorth();
		//- (void)resetPosition;
		[Export("resetPosition"),]
		void ResetPosition();
		//@property (nonatomic) MGLCoordinateBounds visibleCoordinateBounds;
		[Export("visibleCoordinateBounds")]
		MGLCoordinateBounds VisibleCoordinateBounds { get; set; }
		//- (void)setVisibleCoordinateBounds:(MGLCoordinateBounds)bounds animated:(BOOL)animated;
		[Export("setVisibleCoordinateBounds:animated:"),]
		void SetVisibleCoordinateBounds(MGLCoordinateBounds bounds, bool animated);
		//- (void)setVisibleCoordinateBounds:(MGLCoordinateBounds)bounds edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
		[Export("setVisibleCoordinateBounds:edgePadding:animated:"),]
		void SetVisibleCoordinateBounds(MGLCoordinateBounds bounds, UIEdgeInsets insets, bool animated);
		//- (void)setVisibleCoordinates:(CLLocationCoordinate2D *)coordinates count:(nuint)count edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
		[Export("setVisibleCoordinates:count:edgePadding:animated:"),]
		void SetVisibleCoordinates(CLLocationCoordinate2D coordinates, nuint count, UIEdgeInsets insets, bool animated);
		//- (void)setVisibleCoordinates:(CLLocationCoordinate2D *)coordinates count:(nuint)count edgePadding:(UIEdgeInsets)insets direction:(nfloat)direction duration:(nfloat)duration animationTimingFunction:(nullable CAMediaTimingFunction *)function completionHandler:(nullable Action)completion;
		[Export("setVisibleCoordinates:count:edgePadding:direction:duration:animationTimingFunction:completionHandler:"),]
		void SetVisibleCoordinates(CLLocationCoordinate2D coordinates, nuint count, UIEdgeInsets insets, nfloat direction, nfloat duration, CAMediaTimingFunction function, Default completion);
		//- (void)showAnnotations:(NS_ARRAY_OF(id <MGLAnnotation>) *)annotations animated:(BOOL)animated;
		[Export("showAnnotations:animated:"),]
		void ShowAnnotations(IMGLAnnotation[] annotations, bool animated);
		//- (void)showAnnotations:(NS_ARRAY_OF(id <MGLAnnotation>) *)annotations edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
		[Export("showAnnotations:edgePadding:animated:"),]
		void ShowAnnotations(IMGLAnnotation[] annotations, UIEdgeInsets insets, bool animated);
		//@property (nonatomic, copy) MGLMapCamera *camera;
		[Export("camera")]
		MGLMapCamera Camera { get; set; }
		//- (void)setCamera:(MGLMapCamera *)camera animated:(BOOL)animated;
		[Export("setCamera:animated:"),]
		void SetCamera(MGLMapCamera camera, bool animated);
		//- (void)setCamera:(MGLMapCamera *)camera withDuration:(nfloat)duration animationTimingFunction:(nullable CAMediaTimingFunction *)function;
		[Export("setCamera:withDuration:animationTimingFunction:"),]
		void SetCamera(MGLMapCamera camera, nfloat duration, CAMediaTimingFunction function);
		//- (void)setCamera:(MGLMapCamera *)camera withDuration:(nfloat)duration animationTimingFunction:(nullable CAMediaTimingFunction *)function completionHandler:(nullable Action)completion;
		[Export("setCamera:withDuration:animationTimingFunction:completionHandler:"),]
		void SetCamera(MGLMapCamera camera, nfloat duration, CAMediaTimingFunction function, Default completion);
		//- (void)flyToCamera:(MGLMapCamera *)camera completionHandler:(nullable Action)completion;
		[Export("flyToCamera:completionHandler:"),]
		void FlyToCamera(MGLMapCamera camera, Default completion);
		//- (void)flyToCamera:(MGLMapCamera *)camera withDuration:(nfloat)duration completionHandler:(nullable Action)completion;
		[Export("flyToCamera:withDuration:completionHandler:"),]
		void FlyToCamera(MGLMapCamera camera, nfloat duration, Default completion);
		//- (void)flyToCamera:(MGLMapCamera *)camera withDuration:(nfloat)duration peakAltitude:(nfloat)peakAltitude completionHandler:(nullable Action)completion;
		[Export("flyToCamera:withDuration:peakAltitude:completionHandler:"),]
		void FlyToCamera(MGLMapCamera camera, nfloat duration, nfloat peakAltitude, Default completion);
		//- (MGLMapCamera *)cameraThatFitsCoordinateBounds:(MGLCoordinateBounds)bounds;
		[Export("cameraThatFitsCoordinateBounds:"),]
		MGLMapCamera CameraThatFitsCoordinateBounds(MGLCoordinateBounds bounds);
		//- (MGLMapCamera *)cameraThatFitsCoordinateBounds:(MGLCoordinateBounds)bounds edgePadding:(UIEdgeInsets)insets;
		[Export("cameraThatFitsCoordinateBounds:edgePadding:"),]
		MGLMapCamera CameraThatFitsCoordinateBounds(MGLCoordinateBounds bounds, UIEdgeInsets insets);
		//- (CGPoint)anchorPointForGesture:(UIGestureRecognizer *)gesture;
		[Export("anchorPointForGesture:"),]
		CGPoint AnchorPointForGesture(UIGestureRecognizer gesture);
		//@property (nonatomic, assign) UIEdgeInsets contentInset;
		[Export("contentInset")]
		UIEdgeInsets ContentInset { get; set; }
		//- (void)setContentInset:(UIEdgeInsets)contentInset animated:(BOOL)animated;
		[Export("setContentInset:animated:"),]
		void SetContentInset(UIEdgeInsets contentInset, bool animated);
		//- (CLLocationCoordinate2D)convertPoint:(CGPoint)point toCoordinateFromView:(nullable UIView *)view;
		[Export("convertPoint:toCoordinateFromView:"),]
		CLLocationCoordinate2D ConvertPoint(CGPoint point, UIView view);
		//- (CGPoint)convertCoordinate:(CLLocationCoordinate2D)coordinate toPointToView:(nullable UIView *)view;
		[Export("convertCoordinate:toPointToView:"),]
		CGPoint ConvertCoordinate(CLLocationCoordinate2D coordinate, UIView view);
		//- (MGLCoordinateBounds)convertRect:(CGRect)rect toCoordinateBoundsFromView:(nullable UIView *)view;
		[Export("convertRect:toCoordinateBoundsFromView:"),]
		MGLCoordinateBounds ConvertRect(CGRect rect, UIView view);
		//- (CGRect)convertCoordinateBounds:(MGLCoordinateBounds)bounds toRectToView:(nullable UIView *)view;
		[Export("convertCoordinateBounds:toRectToView:"),]
		CGRect ConvertCoordinateBounds(MGLCoordinateBounds bounds, UIView view);
		//- (nfloat)metersPerPointAtLatitude:(nfloat)latitude;
		[Export("metersPerPointAtLatitude:"),]
		nfloat MetersPerPointAtLatitude(nfloat latitude);
		//@property (nonatomic, readonly, nullable) NS_ARRAY_OF(id <MGLAnnotation>) *annotations;
		[Export("annotations")]
		NSObject[] Annotations { get; }
		//@property (nonatomic, readonly, nullable) NS_ARRAY_OF(id <MGLAnnotation>) *visibleAnnotations;
		[Export("visibleAnnotations")]
		IMGLAnnotation[] VisibleAnnotations { get; }
		//- (void)addAnnotation:(id <MGLAnnotation>)annotation;
		[Export("addAnnotation:"),]
		void AddAnnotation(IMGLAnnotation annotation);
		//- (void)addAnnotations:(NS_ARRAY_OF(id <MGLAnnotation>) *)annotations;
		[Export("addAnnotations:"),]
		void AddAnnotations(IMGLAnnotation[] annotations);
		//- (void)removeAnnotation:(id <MGLAnnotation>)annotation;
		[Export("removeAnnotation:"),]
		void RemoveAnnotation(IMGLAnnotation annotation);
		//- (void)removeAnnotations:(NS_ARRAY_OF(id <MGLAnnotation>) *)annotations;
		[Export("removeAnnotations:"),]
		void RemoveAnnotations(NSObject[] annotations);
		//- (nullable MGLAnnotationView *)viewForAnnotation:(id <MGLAnnotation>)annotation;
		[Export("viewForAnnotation:"),]
		MGLAnnotationView ViewForAnnotation(NSObject annotation);
		//- (nullable __kindof MGLAnnotationImage *)dequeueReusableAnnotationImageWithIdentifier:(NSString *)identifier;
		[Export("dequeueReusableAnnotationImageWithIdentifier:"),]
		MGLAnnotationImage DequeueReusableAnnotationImageWithIdentifier(NSString identifier);
		//- (nullable __kindof MGLAnnotationView *)dequeueReusableAnnotationViewWithIdentifier:(NSString *)identifier;
		[Export("dequeueReusableAnnotationViewWithIdentifier:"),]
		MGLAnnotationView DequeueReusableAnnotationViewWithIdentifier(NSString identifier);
		//- (nullable NS_ARRAY_OF(id <MGLAnnotation>) *)visibleAnnotationsInRect:(CGRect)rect;
		[Export("visibleAnnotationsInRect:"),]
		IMGLAnnotation[] VisibleAnnotationsInRect(CGRect rect);
		//@property (nonatomic, copy) NS_ARRAY_OF(id <MGLAnnotation>) *selectedAnnotations;
		[Export("selectedAnnotations")]
		IMGLAnnotation[] SelectedAnnotations { get; set; }
		//- (void)selectAnnotation:(id <MGLAnnotation>)annotation animated:(BOOL)animated;
		[Export("selectAnnotation:animated:"),]
		void SelectAnnotation(IMGLAnnotation annotation, bool animated);
		//- (void)deselectAnnotation:(nullable id <MGLAnnotation>)annotation animated:(BOOL)animated;
		[Export("deselectAnnotation:animated:"),]
		void DeselectAnnotation(IMGLAnnotation annotation, bool animated);
		//- (void)addOverlay:(id <MGLOverlay>)overlay;
		[Export("addOverlay:"),]
		void AddOverlay(IMGLOverlay overlay);
		//- (void)addOverlays:(NS_ARRAY_OF(id <MGLOverlay>) *)overlays;
		[Export("addOverlays:"),]
		void AddOverlays(IMGLOverlay[] overlays);
		//- (void)removeOverlay:(id <MGLOverlay>)overlay;
		[Export("removeOverlay:"),]
		void RemoveOverlay(IMGLOverlay overlay);
		//- (void)removeOverlays:(NS_ARRAY_OF(id <MGLOverlay>) *)overlays;
		[Export("removeOverlays:"),]
		void RemoveOverlays(IMGLOverlay[] overlays);
		//- (NS_ARRAY_OF(id <MGLFeature>) *)visibleFeaturesAtPoint:(CGPoint)point NS_SWIFT_NAME(visibleFeatures(at:));
		[Export("visibleFeaturesAtPoint:"),]
		IMGLFeature[] VisibleFeaturesAtPoint(CGPoint point);
		//- (NS_ARRAY_OF(id <MGLFeature>) *)visibleFeaturesAtPoint:(CGPoint)point inStyleLayersWithIdentifiers:(nullable NS_SET_OF(NSString *) *)styleLayerIdentifiers NS_SWIFT_NAME(visibleFeatures(at:styleLayerIdentifiers:));
		[Export("visibleFeaturesAtPoint:inStyleLayersWithIdentifiers:"),]
		IMGLFeature[] VisibleFeaturesAtPoint(CGPoint point, NSSet styleLayerIdentifiers);
		//- (NS_ARRAY_OF(id <MGLFeature>) *)visibleFeaturesInRect:(CGRect)rect NS_SWIFT_NAME(visibleFeatures(in:));
		[Export("visibleFeaturesInRect:"),]
		NSObject[] VisibleFeaturesInRect(CGRect rect);
		//- (NS_ARRAY_OF(id <MGLFeature>) *)visibleFeaturesInRect:(CGRect)rect inStyleLayersWithIdentifiers:(nullable NS_SET_OF(NSString *) *)styleLayerIdentifiers NS_SWIFT_NAME(visibleFeatures(in:styleLayerIdentifiers:));
		[Export("visibleFeaturesInRect:inStyleLayersWithIdentifiers:"),]
		NSObject[] VisibleFeaturesInRect(CGRect rect, NSSet styleLayerIdentifiers);
		//@property (nonatomic) MGLMapDebugMaskOptions debugMask;
		[Export("debugMask")]
		MGLMapDebugMaskOptions DebugMask { get; set; }
		//- (void)emptyMemoryCache __attribute__((deprecated));
		[Export("emptyMemoryCache"),]
		void EmptyMemoryCache();
		//@end
	}

	[BaseType(typeof(NSObject)), Model, Protocol]
	public partial interface MGLMapViewDelegate
	{
		//@optional
		//- (void)mapView:(MGLMapView *)mapView regionWillChangeAnimated:(BOOL)animated;
		[Export("mapView:regionWillChangeAnimated:"),]
		void RegionWillChangeAnimated(MGLMapView mapView, bool animated);
		//- (void)mapViewRegionIsChanging:(MGLMapView *)mapView;
		[Export("mapViewRegionIsChanging:"),]
		void RegionIsChanging(MGLMapView mapView);
		//- (void)mapView:(MGLMapView *)mapView regionDidChangeAnimated:(BOOL)animated;
		[Export("mapView:regionDidChangeAnimated:"),]
		void RegionDidChangeAnimated(MGLMapView mapView, bool animated);
		//- (void)mapViewWillStartLoadingMap:(MGLMapView *)mapView;
		[Export("mapViewWillStartLoadingMap:"),]
		void WillStartLoadingMap(MGLMapView mapView);
		//- (void)mapViewDidFinishLoadingMap:(MGLMapView *)mapView;
		[Export("mapViewDidFinishLoadingMap:"),]
		void DidFinishLoadingMap(MGLMapView mapView);
		//- (void)mapViewDidFailLoadingMap:(MGLMapView *)mapView withError:(NSError *)error;
		[Export("mapViewDidFailLoadingMap:withError:"),]
		void DidFailLoadingMap(MGLMapView mapView, NSError error);
		//- (void)mapViewWillStartRenderingMap:(MGLMapView *)mapView;
		[Export("mapViewWillStartRenderingMap:"),]
		void WillStartRenderingMap(MGLMapView mapView);
		//- (void)mapViewDidFinishRenderingMap:(MGLMapView *)mapView fullyRendered:(BOOL)fullyRendered;
		[Export("mapViewDidFinishRenderingMap:fullyRendered:"),]
		void DidFinishRenderingMap(MGLMapView mapView, bool fullyRendered);
		//- (void)mapViewWillStartRenderingFrame:(MGLMapView *)mapView;
		[Export("mapViewWillStartRenderingFrame:"),]
		void WillStartRenderingFrame(MGLMapView mapView);
		//- (void)mapViewDidFinishRenderingFrame:(MGLMapView *)mapView fullyRendered:(BOOL)fullyRendered;
		[Export("mapViewDidFinishRenderingFrame:fullyRendered:"),]
		void DidFinishRenderingFrame(MGLMapView mapView, bool fullyRendered);
		//- (void)mapView:(MGLMapView *)mapView didFinishLoadingStyle:(MGLStyle *)style;
		[Export("mapView:didFinishLoadingStyle:"),]
		void DidFinishLoadingStyle(MGLMapView mapView, MGLStyle style);
		//- (void)mapViewWillStartLocatingUser:(MGLMapView *)mapView;
		[Export("mapViewWillStartLocatingUser:"),]
		void WillStartLocatingUser(MGLMapView mapView);
		//- (void)mapViewDidStopLocatingUser:(MGLMapView *)mapView;
		[Export("mapViewDidStopLocatingUser:"),]
		void DidStopLocatingUser(MGLMapView mapView);
		//- (void)mapView:(MGLMapView *)mapView didUpdateUserLocation:(nullable MGLUserLocation *)userLocation;
		[Export("mapView:didUpdateUserLocation:"),]
		void DidUpdateUserLocation(MGLMapView mapView, MGLUserLocation userLocation);
		//- (void)mapView:(MGLMapView *)mapView didFailToLocateUserWithError:(NSError *)error;
		[Export("mapView:didFailToLocateUserWithError:"),]
		void DidFailToLocateUserWithError(MGLMapView mapView, NSError error);
		//- (void)mapView:(MGLMapView *)mapView didChangeUserTrackingMode:(MGLUserTrackingMode)mode animated:(BOOL)animated;
		[Export("mapView:didChangeUserTrackingMode:animated:"),]
		void DidChangeUserTrackingMode(MGLMapView mapView, MGLUserTrackingMode mode, bool animated);
		//- (nullable MGLAnnotationImage *)mapView:(MGLMapView *)mapView imageForAnnotation:(id <MGLAnnotation>)annotation;
		[Export("mapView:imageForAnnotation:"),]
		MGLAnnotationImage ImageForAnnotation(MGLMapView mapView, NSObject annotation);
		//- (nfloat)mapView:(MGLMapView *)mapView alphaForShapeAnnotation:(MGLShape *)annotation;
		[Export("mapView:alphaForShapeAnnotation:"),]
		nfloat AlphaForShapeAnnotation(MGLMapView mapView, MGLShape annotation);
		//- (UIColor *)mapView:(MGLMapView *)mapView strokeColorForShapeAnnotation:(MGLShape *)annotation;
		[Export("mapView:strokeColorForShapeAnnotation:"),]
		UIColor StrokeColorForShapeAnnotation(MGLMapView mapView, MGLShape annotation);
		//- (UIColor *)mapView:(MGLMapView *)mapView fillColorForPolygonAnnotation:(MGLPolygon *)annotation;
		[Export("mapView:fillColorForPolygonAnnotation:"),]
		UIColor FillColorForPolygonAnnotation(MGLMapView mapView, MGLPolygon annotation);
		//- (nfloat)mapView:(MGLMapView *)mapView lineWidthForPolylineAnnotation:(MGLPolyline *)annotation;
		[Export("mapView:lineWidthForPolylineAnnotation:"),]
		nfloat LineWidthForPolylineAnnotation(MGLMapView mapView, MGLPolyline annotation);
		//- (nullable MGLAnnotationView *)mapView:(MGLMapView *)mapView viewForAnnotation:(id <MGLAnnotation>)annotation;
		[Export("mapView:viewForAnnotation:"),]
		MGLAnnotationView ViewForAnnotation(MGLMapView mapView, NSObject annotation);
		//- (void)mapView:(MGLMapView *)mapView didAddAnnotationViews:(NS_ARRAY_OF(MGLAnnotationView *) *)annotationViews;
		[Export("mapView:didAddAnnotationViews:"),]
		void DidAddAnnotationViews(MGLMapView mapView, MGLAnnotationView[] annotationViews);
		//- (void)mapView:(MGLMapView *)mapView didSelectAnnotation:(id <MGLAnnotation>)annotation;
		[Export("mapView:didSelectAnnotation:"),]
		void DidSelectAnnotation(MGLMapView mapView, NSObject annotation);
		//- (void)mapView:(MGLMapView *)mapView didDeselectAnnotation:(id <MGLAnnotation>)annotation;
		[Export("mapView:didDeselectAnnotation:"),]
		void DidDeselectAnnotation(MGLMapView mapView, NSObject annotation);
		//- (void)mapView:(MGLMapView *)mapView didSelectAnnotationView:(MGLAnnotationView *)annotationView;
		[Export("mapView:didSelectAnnotationView:"),]
		void DidSelectAnnotationView(MGLMapView mapView, MGLAnnotationView annotationView);
		//- (void)mapView:(MGLMapView *)mapView didDeselectAnnotationView:(MGLAnnotationView *)annotationView;
		[Export("mapView:didDeselectAnnotationView:"),]
		void DidDeselectAnnotationView(MGLMapView mapView, MGLAnnotationView annotationView);
		//- (BOOL)mapView:(MGLMapView *)mapView annotationCanShowCallout:(id <MGLAnnotation>)annotation;
		[Export("mapView:annotationCanShowCallout:"),]
		bool AnnotationCanShowCallout(MGLMapView mapView, NSObject annotation);
		//- (nullable UIView <MGLCalloutView> *)mapView:(MGLMapView *)mapView calloutViewForAnnotation:(id <MGLAnnotation>)annotation;
		[Export("mapView:calloutViewForAnnotation:"),]
		UIView CalloutViewForAnnotation(MGLMapView mapView, NSObject annotation);
		//- (nullable UIView *)mapView:(MGLMapView *)mapView leftCalloutAccessoryViewForAnnotation:(id <MGLAnnotation>)annotation;
		[Export("mapView:leftCalloutAccessoryViewForAnnotation:"),]
		UIView LeftCalloutAccessoryViewForAnnotation(MGLMapView mapView, NSObject annotation);
		//- (nullable UIView *)mapView:(MGLMapView *)mapView rightCalloutAccessoryViewForAnnotation:(id <MGLAnnotation>)annotation;
		[Export("mapView:rightCalloutAccessoryViewForAnnotation:"),]
		UIView RightCalloutAccessoryViewForAnnotation(MGLMapView mapView, NSObject annotation);
		//- (void)mapView:(MGLMapView *)mapView annotation:(id <MGLAnnotation>)annotation calloutAccessoryControlTapped:(UIControl *)control;
		[Export("mapView:annotation:calloutAccessoryControlTapped:"),]
		void CalloutAccessoryControlTapped(MGLMapView mapView, NSObject annotation, UIControl control);
		//- (void)mapView:(MGLMapView *)mapView tapOnCalloutForAnnotation:(id <MGLAnnotation>)annotation;
		[Export("mapView:tapOnCalloutForAnnotation:"),]
		void TapOnCalloutForAnnotation(MGLMapView mapView, NSObject annotation);
		//@end
	}
	//@interface MGLMultiPoint : MGLShape
	[BaseType(typeof(MGLShape))]
	public partial interface MGLMultiPoint
	{
		//@property (nonatomic, readonly) CLLocationCoordinate2D *coordinates NS_RETURNS_INNER_POINTER;
		[Export("coordinates")]
		CLLocationCoordinate2D Coordinates { get; }
		//@property (nonatomic, readonly) nuint pointCount;
		[Export("pointCount")]
		nuint PointCount { get; }
		//- (void)getCoordinates:(CLLocationCoordinate2D *)coords range:(NSRange)range;
		[Export("getCoordinates:range:"),]
		void GetCoordinates(CLLocationCoordinate2D coords, NSRange range);
		//- (void)setCoordinates:(CLLocationCoordinate2D *)coords count:(nuint)count;
		[Export("setCoordinates:count:"),]
		void SetCoordinates(CLLocationCoordinate2D coords, nuint count);
		//- (void)insertCoordinates:(CLLocationCoordinate2D *)coords count:(nuint)count atIndex:(nuint)index;
		[Export("insertCoordinates:count:atIndex:"),]
		void InsertCoordinates(CLLocationCoordinate2D coords, nuint count, nuint index);
		//- (void)appendCoordinates:(CLLocationCoordinate2D *)coords count:(nuint)count;
		[Export("appendCoordinates:count:"),]
		void AppendCoordinates(ref CLLocationCoordinate2D coords, nuint count);
		//- (void)replaceCoordinatesInRange:(NSRange)range withCoordinates:(CLLocationCoordinate2D *)coords;
		[Export("replaceCoordinatesInRange:withCoordinates:"),]
		void ReplaceCoordinatesInRange(NSRange range, CLLocationCoordinate2D coords);
		//- (void)replaceCoordinatesInRange:(NSRange)range withCoordinates:(CLLocationCoordinate2D *)coords count:(nuint)count;
		[Export("replaceCoordinatesInRange:withCoordinates:count:"),]
		void ReplaceCoordinatesInRange(NSRange range, CLLocationCoordinate2D coords, nuint count);
		//- (void)removeCoordinatesInRange:(NSRange)range;
		[Export("removeCoordinatesInRange:"),]
		void RemoveCoordinatesInRange(NSRange range);
		//@end
	}
	//@interface MGLOfflinePack : NSObject
	[BaseType(typeof(NSObject))]
	public partial interface MGLOfflinePack
	{
		//@property (nonatomic, readonly) id <MGLOfflineRegion> region;
		[Export("region")]
		NSObject Region { get; }
		//@property (nonatomic, readonly) NSData *context;
		[Export("context")]
		NSData Context { get; }
		//@property (nonatomic, readonly) MGLOfflinePackState state;
		[Export("state")]
		MGLOfflinePackState State { get; }
		//@property (nonatomic, readonly) MGLOfflinePackProgress progress;
		[Export("progress")]
		MGLOfflinePackProgress Progress { get; }
		//- (void)resume;
		[Export("resume"),]
		void Resume();
		//- (void)suspend;
		[Export("suspend"),]
		void Suspend();
		//- (void)requestProgress;
		[Export("requestProgress"),]
		void RequestProgress();
		//@end
	}

	[BaseType(typeof(NSObject)), Model, Protocol]
	public partial interface MGLOfflineRegion
	{
		//@end
	}
	//extern NSString MGLOfflinePackProgressChangedNotification;
	//[Static]
	public partial interface Constants
	{
		[Field("MGLOfflinePackProgressChangedNotification", "__Internal")]
		NSString MGLOfflinePackProgressChangedNotification { get; }
	}
	//extern NSString MGLOfflinePackErrorNotification;
	//[Static]
	public partial interface Constants
	{
		[Field("MGLOfflinePackErrorNotification", "__Internal")]
		NSString MGLOfflinePackErrorNotification { get; }
	}
	//extern NSString MGLOfflinePackMaximumMapboxTilesReachedNotification;
	//[Static]
	public partial interface Constants
	{
		[Field("MGLOfflinePackMaximumMapboxTilesReachedNotification", "__Internal")]
		NSString MGLOfflinePackMaximumMapboxTilesReachedNotification { get; }
	}
	//extern NSString NSStringState;
	//[Static]
	public partial interface Constants
	{
		//[Field("NSStringState", "__Internal")]
		//NSString NSStringState { get; }
	}
	//extern NSString NSStringProgress;
	//[Static]
	public partial interface Constants
	{
		//[Field("NSStringProgress", "__Internal")]
		//NSString NSStringProgress { get; }
	}
	//extern NSString NSStringError;
	//[Static]
	public partial interface Constants
	{
		//[Field("NSStringError", "__Internal")]
		//NSString NSStringError { get; }
	}
	//extern NSString NSStringMaximumCount;
	//[Static]
	public partial interface Constants
	{
		//[Field("NSStringMaximumCount", "__Internal")]
		//NSString NSStringMaximumCount { get; }
	}

	//typedef void (^MGLOfflinePackAdditionCompletionHandler)(MGLOfflinePack * _Nullable pack, NSError * _Nullable error);
	public delegate void MGLOfflinePackAdditionCompletionHandler(MGLOfflinePack pack, NSError error);
	//typedef void (^MGLOfflinePackRemovalCompletionHandler)(NSError * _Nullable error);
	public delegate void MGLOfflinePackRemovalCompletionHandler(NSError error);

	public delegate void Default();

	//@interface MGLOfflineStorage : NSObject
	[BaseType(typeof(NSObject))]
	public partial interface MGLOfflineStorage
	{
		//+ (instancetype)sharedOfflineStorage;
		[Export("sharedOfflineStorage"), Static]
		MGLOfflineStorage SharedOfflineStorage();
		//@property (nonatomic, strong, readonly, nullable) NS_ARRAY_OF(MGLOfflinePack *) *packs;
		[Export("packs")]
		MGLOfflinePack[] Packs { get; }
		//- (void)addPackForRegion:(id <MGLOfflineRegion>)region withContext:(NSData *)context completionHandler:(nullable MGLOfflinePackAdditionCompletionHandler)completion;
		[Export("addPackForRegion:withContext:completionHandler:"),]
		void AddPackForRegion(NSObject region, NSData context, MGLOfflinePackAdditionCompletionHandler completion);
		//- (void)removePack:(MGLOfflinePack *)pack withCompletionHandler:(nullable MGLOfflinePackRemovalCompletionHandler)completion;
		[Export("removePack:withCompletionHandler:"),]
		void RemovePack(MGLOfflinePack pack, MGLOfflinePackRemovalCompletionHandler completion);
		//- (void)reloadPacks;
		[Export("reloadPacks"),]
		void ReloadPacks();
		//- (void)setMaximumAllowedMapboxTiles:(uint64_t)maximumCount;
		[Export("setMaximumAllowedMapboxTiles:"),]
		void SetMaximumAllowedMapboxTiles(long maximumCount);
		//@property (nonatomic, readonly) unsigned long long countOfBytesCompleted;
		[Export("countOfBytesCompleted")]
		long CountOfBytesCompleted { get; }
		//@end
	}
	//@interface MGLOpenGLStyleLayer : MGLStyleLayer
	[BaseType(typeof(MGLStyleLayer))]
	public partial interface MGLOpenGLStyleLayer
	{
		//@property (nonatomic, weak, readonly) MGLMapView *mapView;
		[Export("mapView")]
		MGLMapView MapView { get; }
		//- (void)didMoveToMapView:(MGLMapView *)mapView;
		[Export("didMoveToMapView:"),]
		void DidMoveToMapView(MGLMapView mapView);
		//- (void)willMoveFromMapView:(MGLMapView *)mapView;
		[Export("willMoveFromMapView:"),]
		void WillMoveFromMapView(MGLMapView mapView);
		//- (void)drawInMapView:(MGLMapView *)mapView withContext:(MGLStyleLayerDrawingContext)context;
		[Export("drawInMapView:withContext:"),]
		void DrawInMapView(MGLMapView mapView, MGLStyleLayerDrawingContext context);
		//- (void)setNeedsDisplay;
		[Export("setNeedsDisplay"),]
		void SetNeedsDisplay();
		//@end
	}

	[BaseType(typeof(NSObject)), Model, Protocol]
	public partial interface MGLOverlay : MGLAnnotation
	{
		//@property (nonatomic, readonly) CLLocationCoordinate2D coordinate;
		//[Export("coordinate")]
		//CLLocationCoordinate2D Coordinate { get; }
		//@property (nonatomic, readonly) MGLCoordinateBounds overlayBounds;
		[Export("overlayBounds")]
		MGLCoordinateBounds OverlayBounds { get; }
		//- (BOOL)intersectsOverlayBounds:(MGLCoordinateBounds)overlayBounds;
		[Export("intersectsOverlayBounds:"),]
		bool IntersectsOverlayBounds(MGLCoordinateBounds overlayBounds);
		//@end
	}
	//@interface MGLPointAnnotation : MGLShape
	[BaseType(typeof(MGLShape))]
	public partial interface MGLPointAnnotation
	{
		//@property (nonatomic, assign) CLLocationCoordinate2D coordinate;
		[Export("coordinate")]
		CLLocationCoordinate2D Coordinate { get; set; }
		//@end
	}
	//@interface MGLPointCollection : MGLShape <MGLOverlay>
	[BaseType(typeof(MGLShape))]
	public partial interface MGLPointCollection : MGLOverlay
	{
		//+ (instancetype)pointCollectionWithCoordinates:(CLLocationCoordinate2D *)coords count:(nuint)count;
		[Export("pointCollectionWithCoordinates:count:"), Static]
		MGLPointCollection PointCollectionWithCoordinates(CLLocationCoordinate2D coords, nuint count);
		//@property (nonatomic, readonly) CLLocationCoordinate2D *coordinates NS_RETURNS_INNER_POINTER;
		[Export("coordinates")]
		CLLocationCoordinate2D Coordinates { get; }
		//@property (nonatomic, readonly) nuint pointCount;
		[Export("pointCount")]
		nuint PointCount { get; }
		//- (void)getCoordinates:(CLLocationCoordinate2D *)coords range:(NSRange)range;
		[Export("getCoordinates:range:"),]
		void GetCoordinates(CLLocationCoordinate2D coords, NSRange range);
		//@end
	}
	//@interface MGLPolygon : MGLMultiPoint <MGLOverlay>
	[BaseType(typeof(MGLMultiPoint))]
	public partial interface MGLPolygon : MGLOverlay
	{
		//@property (nonatomic, nullable, readonly) NS_ARRAY_OF(MGLPolygon *) *interiorPolygons;
		[Export("interiorPolygons")]
		MGLPolygon[] InteriorPolygons { get; }
		//+ (instancetype)polygonWithCoordinates:(CLLocationCoordinate2D *)coords count:(nuint)count;
		[Export("polygonWithCoordinates:count:"), Static]
		MGLPolygon PolygonWithCoordinates(CLLocationCoordinate2D coords, nuint count);
		//+ (instancetype)polygonWithCoordinates:(CLLocationCoordinate2D *)coords count:(nuint)count interiorPolygons:(nullable NS_ARRAY_OF(MGLPolygon *) *)interiorPolygons;
		[Export("polygonWithCoordinates:count:interiorPolygons:"), Static]
		MGLPolygon PolygonWithCoordinates(CLLocationCoordinate2D coords, nuint count, MGLPolygon[] interiorPolygons);
		//@end
	}
	//@interface MGLMultiPolygon : MGLShape <MGLOverlay>
	[BaseType(typeof(MGLShape))]
	public partial interface MGLMultiPolygon : MGLOverlay
	{
		//@property (nonatomic, copy, readonly) NS_ARRAY_OF(MGLPolygon *) *polygons;
		[Export("polygons")]
		MGLPolygon[] Polygons { get; }
		//+ (instancetype)multiPolygonWithPolygons:(NS_ARRAY_OF(MGLPolygon *) *)polygons;
		[Export("multiPolygonWithPolygons:"), Static]
		MGLMultiPolygon MultiPolygonWithPolygons(MGLPolygon[] polygons);
		//@end
	}
	//@interface MGLPolyline : MGLMultiPoint <MGLOverlay>
	[BaseType(typeof(MGLMultiPoint))]
	public partial interface MGLPolyline : MGLOverlay
	{
		//+ (instancetype)polylineWithCoordinates:(CLLocationCoordinate2D *)coords count:(nuint)count;
		[Export("polylineWithCoordinates:count:"), Static]
		MGLPolyline PolylineWithCoordinates(ref CLLocationCoordinate2D coords, nuint count);
		//@end
	}
	//@interface MGLMultiPolyline : MGLShape <MGLOverlay>
	[BaseType(typeof(MGLShape))]
	public partial interface MGLMultiPolyline : MGLOverlay
	{
		//@property (nonatomic, copy, readonly) NS_ARRAY_OF(MGLPolyline *) *polylines;
		[Export("polylines")]
		MGLPolyline[] Polylines { get; }
		//+ (instancetype)multiPolylineWithPolylines:(NS_ARRAY_OF(MGLPolyline *) *)polylines;
		[Export("multiPolylineWithPolylines:"), Static]
		MGLMultiPolyline MultiPolylineWithPolylines(MGLPolyline[] polylines);
		//@end
	}
	//extern NSString NSStringTileSize;
	//[Static]
	public partial interface Constants
	{
		//[Field("NSStringTileSize", "__Internal")]
		//NSString NSStringTileSize { get; }
	}
	//### Example
	//@interface MGLRasterSource : MGLTileSource
	[BaseType(typeof(MGLTileSource))]
	public partial interface MGLRasterSource
	{
		//- (instancetype)initWithIdentifier:(NSString *)identifier configurationURL:(NSUrl *)configurationURL;
		[Export("initWithIdentifier:configurationURL:"),]
		IntPtr Constructor(NSString identifier, NSUrl configurationURL);
		//- (instancetype)initWithIdentifier:(NSString *)identifier configurationURL:(NSUrl *)configurationURL tileSize:(nfloat)tileSize NS_DESIGNATED_INITIALIZER;
		[Export("initWithIdentifier:configurationURL:tileSize:"),]
		IntPtr Constructor(NSString identifier, NSUrl configurationURL, nfloat tileSize);
		//- (instancetype)initWithIdentifier:(NSString *)identifier tileURLTemplates:(NS_ARRAY_OF(NSString *) *)tileURLTemplates options:(nullable NS_DICTIONARY_OF(NSString, id) *)options NS_DESIGNATED_INITIALIZER;
		[Export("initWithIdentifier:tileURLTemplates:options:"),]
		IntPtr Constructor(NSString identifier, NSString[] tileURLTemplates, NSDictionary<NSString, NSObject> options);
		//@end
	}
	//### Example
	//@interface MGLRasterStyleLayer : MGLForegroundStyleLayer
	[BaseType(typeof(MGLForegroundStyleLayer))]
	public partial interface MGLRasterStyleLayer
	{
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *maximumRasterBrightness;
		[Export("maximumRasterBrightness")]
		MGLStyleValue<NSNumber> MaximumRasterBrightness { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *minimumRasterBrightness;
		[Export("minimumRasterBrightness")]
		MGLStyleValue<NSNumber> MinimumRasterBrightness { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *rasterContrast;
		[Export("rasterContrast")]
		MGLStyleValue<NSNumber> RasterContrast { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *rasterFadeDuration;
		[Export("rasterFadeDuration")]
		MGLStyleValue<NSNumber> RasterFadeDuration { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *rasterHueRotation;
		[Export("rasterHueRotation")]
		MGLStyleValue<NSNumber> RasterHueRotation { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *rasterOpacity;
		[Export("rasterOpacity")]
		MGLStyleValue<NSNumber> RasterOpacity { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *rasterSaturation;
		[Export("rasterSaturation")]
		MGLStyleValue<NSNumber> RasterSaturation { get; set; }
		//@end
	}
	//@interface MGLShape : NSObject <MGLAnnotation, NSSecureCoding>
	[BaseType(typeof(NSObject))]
	public partial interface MGLShape : MGLAnnotation, INSSecureCoding
	{
		//### Example
		//+ (nullable MGLShape *)shapeWithData:(NSData *)data encoding:(NSStringEncoding)encoding error:(NSError * _Nullable *)outError;
		[Export("shapeWithData:encoding:error:"), Static]
		MGLShape ShapeWithData(NSData data, NSStringEncoding encoding, NSError outError);
		//@property (nonatomic, copy, nullable) NSString *title;
		[Export("title")]
		string Title { get; set; }
		//@property (nonatomic, copy, nullable) NSString *subtitle;
		[Export("subtitle")]
		string Subtitle { get; set; }
		//#if !TARGET_OS_IPHONE
		//@property (nonatomic, copy, nullable) NSString *toolTip;
		//[Export("toolTip")]
		//NSString ToolTip { get; set; }
		//#endif
		//- (NSData *)geoJSONDataUsingEncoding:(NSStringEncoding)encoding;
		[Export("geoJSONDataUsingEncoding:"),]
		NSData GeoJSONDataUsingEncoding(NSStringEncoding encoding);
		//@end
	}
	//@interface MGLShapeCollection : MGLShape
	[BaseType(typeof(MGLShape))]
	public partial interface MGLShapeCollection
	{
		//@property (nonatomic, copy, readonly) NS_ARRAY_OF(MGLShape *) *shapes;
		[Export("shapes")]
		MGLShape[] Shapes { get; }
		//+ (instancetype)shapeCollectionWithShapes:(NS_ARRAY_OF(MGLShape *) *)shapes;
		[Export("shapeCollectionWithShapes:"), Static]
		MGLShapeCollection ShapeCollectionWithShapes(MGLShape[] shapes);
		//@end
	}
	//extern NSString NSStringClustered;
	//[Static]
	public partial interface Constants
	{
		//[Field("NSStringClustered", "__Internal")]
		//NSString NSStringClustered { get; }
	}
	//extern NSString NSStringClusterRadius;
	//[Static]
	public partial interface Constants
	{
		//[Field("NSStringClusterRadius", "__Internal")]
		//NSString NSStringClusterRadius { get; }
	}
	//extern NSString NSStringMaximumZoomLevelForClustering;
	//[Static]
	public partial interface Constants
	{
		//[Field("NSStringMaximumZoomLevelForClustering", "__Internal")]
		//NSString NSStringMaximumZoomLevelForClustering { get; }
	}
	//extern NSString NSStringMaximumZoomLevel;
	//[Static]
	public partial interface Constants
	{
		//[Field("NSStringMaximumZoomLevel", "__Internal")]
		//NSString NSStringMaximumZoomLevel { get; }
	}
	//extern NSString NSStringBuffer;
	//[Static]
	public partial interface Constants
	{
		//[Field("NSStringBuffer", "__Internal")]
		//NSString NSStringBuffer { get; }
	}
	//extern NSString NSStringSimplificationTolerance;
	//[Static]
	public partial interface Constants
	{
		//[Field("NSStringSimplificationTolerance", "__Internal")]
		//NSString NSStringSimplificationTolerance { get; }
	}
	//### Example
	//@interface MGLShapeSource : MGLSource
	[BaseType(typeof(MGLSource))]
	public partial interface MGLShapeSource
	{
		//- (instancetype)initWithIdentifier:(NSString *)identifier URL:(NSUrl *)url options:(nullable NS_DICTIONARY_OF(NSString, id) *)options NS_DESIGNATED_INITIALIZER;
		[Export("initWithIdentifier:URL:options:"),]
		IntPtr Constructor(NSString identifier, NSUrl url, NSDictionary<NSString, NSObject> options);
		//- (instancetype)initWithIdentifier:(NSString *)identifier shape:(nullable MGLShape *)shape options:(nullable NS_DICTIONARY_OF(NSString, id) *)options NS_DESIGNATED_INITIALIZER;
		[Export("initWithIdentifier:shape:options:"),]
		IntPtr Constructor(NSString identifier, MGLShape shape, NSDictionary<NSString, NSObject> options);
		//- (instancetype)initWithIdentifier:(NSString *)identifier features:(NS_ARRAY_OF(MGLShape<MGLFeature> *) *)features options:(nullable NS_DICTIONARY_OF(NSString, id) *)options;
		[Export("initWithIdentifier:features:options:"),]
		IntPtr Constructor(NSString identifier, IMGLFeature[] features, NSDictionary<NSString, NSObject> options);
		//- (instancetype)initWithIdentifier:(NSString *)identifier shapes:(NS_ARRAY_OF(MGLShape *) *)shapes options:(nullable NS_DICTIONARY_OF(NSString, id) *)options;
		[Export("initWithIdentifier:shapes:options:"),]
		IntPtr Constructor(NSString identifier, MGLShape[] shapes, NSDictionary<NSString, NSObject> options);
		//@property (nonatomic, copy, nullable) MGLShape *shape;
		[Export("shape")]
		MGLShape Shape { get; set; }
		//@property (nonatomic, copy, nullable) NSUrl *URL;
		[Export("URL")]
		NSUrl URL { get; set; }
		//@end
	}
	//@interface MGLSource : NSObject
	[BaseType(typeof(NSObject))]
	public partial interface MGLSource
	{
		//- (instancetype)initWithIdentifier:(NSString *)identifier;
		[Export("initWithIdentifier:"),]
		IntPtr Constructor(NSString identifier);
		//@property (nonatomic, copy) NSString *identifier;
		[Export("identifier")]
		NSString Identifier { get; set; }
		//@end
	}
	//@warning The value of this constant may change in a future release of the SDK.
	//@interface MGLStyle : NSObject
	[BaseType(typeof(NSObject))]
	public partial interface MGLStyle
	{
		//+ (NSUrl *)streetsStyleURLWithVersion:(nint)version;
		[Export("streetsStyleURLWithVersion:"), Static]
		NSUrl StreetsStyleURLWithVersion(nint version);
		//+ (NSUrl *)outdoorsStyleURLWithVersion:(nint)version;
		[Export("outdoorsStyleURLWithVersion:"), Static]
		NSUrl OutdoorsStyleURLWithVersion(nint version);
		//+ (NSUrl *)lightStyleURLWithVersion:(nint)version;
		[Export("lightStyleURLWithVersion:"), Static]
		NSUrl LightStyleURLWithVersion(nint version);
		//+ (NSUrl *)darkStyleURLWithVersion:(nint)version;
		[Export("darkStyleURLWithVersion:"), Static]
		NSUrl DarkStyleURLWithVersion(nint version);
		//+ (NSUrl *)satelliteStyleURLWithVersion:(nint)version;
		[Export("satelliteStyleURLWithVersion:"), Static]
		NSUrl SatelliteStyleURLWithVersion(nint version);
		//+ (NSUrl *)satelliteStreetsStyleURLWithVersion:(nint)version;
		[Export("satelliteStreetsStyleURLWithVersion:"), Static]
		NSUrl SatelliteStreetsStyleURLWithVersion(nint version);
		//@property (readonly, copy, nullable) NSString *name;
		[Export("name")]
		NSString Name { get; }
		//@property (nonatomic, strong) NS_SET_OF(__kindof MGLSource *) *sources;
		[Export("sources")]
		NSSet Sources { get; set; }
		//- (nullable MGLSource *)sourceWithIdentifier:(NSString *)identifier;
		[Export("sourceWithIdentifier:"),]
		MGLSource SourceWithIdentifier(NSString identifier);
		//- (void)addSource:(MGLSource *)source;
		[Export("addSource:"),]
		void AddSource(MGLSource source);
		//- (void)removeSource:(MGLSource *)source;
		[Export("removeSource:"),]
		void RemoveSource(MGLSource source);
		//@property (nonatomic, strong) NS_ARRAY_OF(__kindof MGLStyleLayer *) *layers;
		[Export("layers")]
		MGLStyleLayer[] Layers { get; set; }
		//- (nullable MGLStyleLayer *)layerWithIdentifier:(NSString *)identifier;
		[Export("layerWithIdentifier:"),]
		MGLStyleLayer LayerWithIdentifier(NSString identifier);
		//- (void)addLayer:(MGLStyleLayer *)layer;
		[Export("addLayer:"),]
		void AddLayer(MGLStyleLayer layer);
		//- (void)insertLayer:(MGLStyleLayer *)layer atIndex:(nuint)index;
		[Export("insertLayer:atIndex:"),]
		void InsertLayer(MGLStyleLayer layer, nuint index);
		//- (void)insertLayer:(MGLStyleLayer *)layer belowLayer:(MGLStyleLayer *)sibling;
		[Export("insertLayer:belowLayer:"),]
		void InsertLayerBelow(MGLStyleLayer layer, MGLStyleLayer sibling);
		//- (void)insertLayer:(MGLStyleLayer *)layer aboveLayer:(MGLStyleLayer *)sibling;
		[Export("insertLayer:aboveLayer:"),]
		void InsertLayerAbove(MGLStyleLayer layer, MGLStyleLayer sibling);
		//- (void)removeLayer:(MGLStyleLayer *)layer;
		[Export("removeLayer:"),]
		void RemoveLayer(MGLStyleLayer layer);
		//- (nullable MGLImage *)imageForName:(NSString *)name;
		[Export("imageForName:"),]
		UIImage ImageForName(NSString name);
		//- (void)setImage:(MGLImage *)image forName:(NSString *)name;
		[Export("setImage:forName:"),]
		void SetImage(UIImage image, NSString name);
		//- (void)removeImageForName:(NSString *)name;
		[Export("removeImageForName:"),]
		void RemoveImageForName(NSString name);
		//@end
	}
	//@interface MGLStyleLayer : NSObject
	[BaseType(typeof(NSObject))]
	public partial interface MGLStyleLayer
	{
		//- (instancetype)initWithIdentifier:(NSString *)identifier;
		[Export("initWithIdentifier:"),]
		IntPtr Constructor(NSString identifier);
		//@property (nonatomic, copy, readonly) NSString *identifier;
		[Export("identifier")]
		NSString Identifier { get; }
		//@property (nonatomic, assign, getter=isVisible) BOOL visible;
		[Export("visible")]
		bool Visible { [Export("isVisible")]get; set; }
		//@property (nonatomic, assign) float maximumZoomLevel;
		[Export("maximumZoomLevel")]
		float MaximumZoomLevel { get; set; }
		//@property (nonatomic, assign) float minimumZoomLevel;
		[Export("minimumZoomLevel")]
		float MinimumZoomLevel { get; set; }
		//@end
	}

	//@interface MGLStyleValue<T> : NSObject
	[BaseType(typeof(NSObject))]
	public partial interface MGLStyleValue<T> : INativeObject
	{
		////+ (instancetype)valueWithRawValue:(T)rawValue;
		//[Export("valueWithRawValue:"), Static]
		//MGLStyleValue<Ti> ValueWithRawValue<Ti>(Ti rawValue);

		////+ (instancetype)valueWithStops:(NSDictionary<NSNumber *, MGLStyleValue<T> *> *)stops;
		//[Export("valueWithStops:"), Static]
		//MGLStyleValue<Ti> ValueWithStops<Ti>(NSDictionary<NSNumber, MGLStyleValue<Ti>> stops);
		////+ (instancetype)valueWithInterpolationBase:(nfloat)interpolationBase stops:(NSDictionary<NSNumber *, MGLStyleValue<T> *> *)stops;
		//[Export("valueWithInterpolationBase:stops:"), Static]
		//MGLStyleValue<Ti> ValueWithInterpolationBase<Ti>(nfloat interpolationBase, NSDictionary<NSNumber, MGLStyleValue<Ti>> stops);
		//@end
	}
	//@interface MGLStyleConstantValue<T> : MGLStyleValue<T>
	[BaseType(typeof(MGLStyleValue<>))]
	public partial interface MGLStyleConstantValue<T>
	{
		//+ (instancetype)valueWithRawValue:(T)rawValue;
		//[Export("valueWithRawValue:"), Static]
		//MGLStyleConstantValue<Ti> ValueWithRawValue<Ti>(Ti rawValue);
		//- (instancetype)initWithRawValue:(T)rawValue NS_DESIGNATED_INITIALIZER;
		[Export("initWithRawValue:"),]
		IntPtr Constructor(T rawValue);
		//@property (nonatomic) T rawValue;
		[Export("rawValue")]
		T RawValue { get; set; }
		//@end
	}
	//@interface MGLStyleFunction<T> : MGLStyleValue<T>
	[BaseType(typeof(MGLStyleValue<>))]
	public partial interface MGLStyleFunction<T>
	{
		////+ (instancetype)functionWithStops:(NSDictionary<NSNumber *, MGLStyleValue<T> *> *)stops;
		//[Export("functionWithStops:"), Static]
		//MGLStyleFunction<Ti> FunctionWithStops<Ti>(NSDictionary<NSNumber, MGLStyleValue<Ti>> stops);
		////+ (instancetype)functionWithInterpolationBase:(nfloat)interpolationBase stops:(NSDictionary<NSNumber *, MGLStyleValue<T> *> *)stops;
		//[Export("functionWithInterpolationBase:stops:"), Static]
		//MGLStyleFunction<Ti> FunctionWithInterpolationBase<Ti>(nfloat interpolationBase, NSDictionary<NSNumber, MGLStyleValue<Ti>> stops);
		//- (instancetype)initWithInterpolationBase:(nfloat)interpolationBase stops:(NSDictionary<NSNumber *, MGLStyleValue<T> *> *)stops NS_DESIGNATED_INITIALIZER;
		[Export("initWithInterpolationBase:stops:"),]
		IntPtr Constructor(nfloat interpolationBase, NSDictionary<NSNumber, MGLStyleValue<T>> stops);
		//@property (nonatomic) nfloat interpolationBase;
		[Export("interpolationBase")]
		nfloat InterpolationBase { get; set; }
		//@property (nonatomic, copy) NSDictionary<NSNumber *, MGLStyleValue<T> *> *stops;
		[Export("stops")]
		NSObject Stops { get; set; }
		//@end
	}
	//### Example
	//@interface MGLSymbolStyleLayer : MGLVectorStyleLayer
	[BaseType(typeof(MGLVectorStyleLayer))]
	public partial interface MGLSymbolStyleLayer
	{
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *iconAllowsOverlap;
		[Export("iconAllowsOverlap")]
		MGLStyleValue<NSNumber> IconAllowsOverlap { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *iconIgnoresPlacement;
		[Export("iconIgnoresPlacement")]
		MGLStyleValue<NSNumber> IconIgnoresPlacement { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSString *> *iconImageName;
		[Export("iconImageName")]
		MGLStyleValue<NSString> IconImageName { get; set; }
		//#if TARGET_OS_IPHONE
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *iconOffset;
		[Export("iconOffset")]
		MGLStyleValue<NSValue> IconOffset { get; set; }
		//#else
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *iconOffset;
		//[Export("iconOffset")]
		//MGLStyleValue<NSValue> IconOffset { get; set; }
		//#endif
		//@property (nonatomic, null_resettable, getter=isIconOptional) MGLStyleValue<NSNumber *> *iconOptional;
		[Export("iconOptional")]
		MGLStyleValue<NSNumber> IconOptional { [Export("isIconOptional")]get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *iconPadding;
		[Export("iconPadding")]
		MGLStyleValue<NSNumber> IconPadding { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *iconRotation;
		[Export("iconRotation")]
		MGLStyleValue<NSNumber> IconRotation { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *iconRotationAlignment;
		[Export("iconRotationAlignment")]
		MGLStyleValue<NSValue> IconRotationAlignment { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *iconScale;
		[Export("iconScale")]
		MGLStyleValue<NSNumber> IconScale { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *iconTextFit;
		[Export("iconTextFit")]
		MGLStyleValue<NSValue> IconTextFit { get; set; }
		//#if TARGET_OS_IPHONE
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *iconTextFitPadding;
		[Export("iconTextFitPadding")]
		MGLStyleValue<NSValue> IconTextFitPadding { get; set; }
		//#else
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *iconTextFitPadding;
		//[Export("iconTextFitPadding")]
		//MGLStyleValue<NSValue> IconTextFitPadding { get; set; }
		//#endif
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *keepsIconUpright;
		[Export("keepsIconUpright")]
		MGLStyleValue<NSNumber> KeepsIconUpright { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *keepsTextUpright;
		[Export("keepsTextUpright")]
		MGLStyleValue<NSNumber> KeepsTextUpright { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *maximumTextAngle;
		[Export("maximumTextAngle")]
		MGLStyleValue<NSNumber> MaximumTextAngle { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *maximumTextWidth;
		[Export("maximumTextWidth")]
		MGLStyleValue<NSNumber> MaximumTextWidth { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *symbolAvoidsEdges;
		[Export("symbolAvoidsEdges")]
		MGLStyleValue<NSNumber> SymbolAvoidsEdges { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *symbolPlacement;
		[Export("symbolPlacement")]
		MGLStyleValue<NSValue> SymbolPlacement { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *symbolSpacing;
		[Export("symbolSpacing")]
		MGLStyleValue<NSNumber> SymbolSpacing { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSString *> *text;
		[Export("text")]
		MGLStyleValue<NSString> Text { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *textAllowsOverlap;
		[Export("textAllowsOverlap")]
		MGLStyleValue<NSNumber> TextAllowsOverlap { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *textAnchor;
		[Export("textAnchor")]
		MGLStyleValue<NSValue> TextAnchor { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSArray<NSString *> *> *textFontNames;
		[Export("textFontNames")]
		MGLStyleValue<NSArray<NSString>> TextFontNames { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *textFontSize;
		[Export("textFontSize")]
		MGLStyleValue<NSNumber> TextFontSize { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *textIgnoresPlacement;
		[Export("textIgnoresPlacement")]
		MGLStyleValue<NSNumber> TextIgnoresPlacement { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *textJustification;
		[Export("textJustification")]
		MGLStyleValue<NSValue> TextJustification { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *textLetterSpacing;
		[Export("textLetterSpacing")]
		MGLStyleValue<NSNumber> TextLetterSpacing { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *textLineHeight;
		[Export("textLineHeight")]
		MGLStyleValue<NSNumber> TextLineHeight { get; set; }
		//#if TARGET_OS_IPHONE
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *textOffset;
		[Export("textOffset")]
		MGLStyleValue<NSValue> TextOffset { get; set; }
		//#else
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *textOffset;
		//[Export("textOffset")]
		//MGLStyleValue<NSValue> TextOffset { get; set; }
		//#endif
		//@property (nonatomic, null_resettable, getter=isTextOptional) MGLStyleValue<NSNumber *> *textOptional;
		[Export("textOptional")]
		MGLStyleValue<NSNumber> TextOptional { [Export("isTextOptional")]get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *textPadding;
		[Export("textPadding")]
		MGLStyleValue<NSNumber> TextPadding { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *textPitchAlignment;
		[Export("textPitchAlignment")]
		MGLStyleValue<NSValue> TextPitchAlignment { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *textRotation;
		[Export("textRotation")]
		MGLStyleValue<NSNumber> TextRotation { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *textRotationAlignment;
		[Export("textRotationAlignment")]
		MGLStyleValue<NSValue> TextRotationAlignment { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *textTransform;
		[Export("textTransform")]
		MGLStyleValue<NSValue> TextTransform { get; set; }
		//#if TARGET_OS_IPHONE
		//@property (nonatomic, null_resettable) MGLStyleValue<UIColor *> *iconColor;
		[Export("iconColor")]
		MGLStyleValue<UIColor> IconColor { get; set; }
		//#else
		//@property (nonatomic, null_resettable) MGLStyleValue<NSColor *> *iconColor;
		//[Export("iconColor")]
		//MGLStyleValue<NSColor> IconColor { get; set; }
		//#endif
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *iconHaloBlur;
		[Export("iconHaloBlur")]
		MGLStyleValue<NSNumber> IconHaloBlur { get; set; }
		//#if TARGET_OS_IPHONE
		//@property (nonatomic, null_resettable) MGLStyleValue<UIColor *> *iconHaloColor;
		[Export("iconHaloColor")]
		MGLStyleValue<UIColor> IconHaloColor { get; set; }
		//#else
		//@property (nonatomic, null_resettable) MGLStyleValue<NSColor *> *iconHaloColor;
		//[Export("iconHaloColor")]
		//MGLStyleValue<NSColor> IconHaloColor { get; set; }
		//#endif
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *iconHaloWidth;
		[Export("iconHaloWidth")]
		MGLStyleValue<NSNumber> IconHaloWidth { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *iconOpacity;
		[Export("iconOpacity")]
		MGLStyleValue<NSNumber> IconOpacity { get; set; }
		//#if TARGET_OS_IPHONE
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *iconTranslation;
		[Export("iconTranslation")]
		MGLStyleValue<NSValue> IconTranslation { get; set; }
		//#else
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *iconTranslation;
		//[Export("iconTranslation")]
		//MGLStyleValue<NSValue> IconTranslation { get; set; }
		//#endif
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *iconTranslationAnchor;
		[Export("iconTranslationAnchor")]
		MGLStyleValue<NSValue> IconTranslationAnchor { get; set; }
		//#if TARGET_OS_IPHONE
		//@property (nonatomic, null_resettable) MGLStyleValue<UIColor *> *textColor;
		[Export("textColor")]
		MGLStyleValue<UIColor> TextColor { get; set; }
		//#else
		//@property (nonatomic, null_resettable) MGLStyleValue<NSColor *> *textColor;
		//[Export("textColor")]
		//MGLStyleValue<NSColor> TextColor { get; set; }
		//#endif
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *textHaloBlur;
		[Export("textHaloBlur")]
		MGLStyleValue<NSNumber> TextHaloBlur { get; set; }
		//#if TARGET_OS_IPHONE
		//@property (nonatomic, null_resettable) MGLStyleValue<UIColor *> *textHaloColor;
		[Export("textHaloColor")]
		MGLStyleValue<UIColor> TextHaloColor { get; set; }
		//#else
		//@property (nonatomic, null_resettable) MGLStyleValue<NSColor *> *textHaloColor;
		//[Export("textHaloColor")]
		//MGLStyleValue<NSColor> TextHaloColor { get; set; }
		//#endif
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *textHaloWidth;
		[Export("textHaloWidth")]
		MGLStyleValue<NSNumber> TextHaloWidth { get; set; }
		//@property (nonatomic, null_resettable) MGLStyleValue<NSNumber *> *textOpacity;
		[Export("textOpacity")]
		MGLStyleValue<NSNumber> TextOpacity { get; set; }
		//#if TARGET_OS_IPHONE
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *textTranslation;
		[Export("textTranslation")]
		MGLStyleValue<NSValue> TextTranslation { get; set; }
		//#else
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *textTranslation;
		//[Export("textTranslation")]
		//MGLStyleValue<NSValue> TextTranslation { get; set; }
		//#endif
		//@property (nonatomic, null_resettable) MGLStyleValue<NSValue *> *textTranslationAnchor;
		[Export("textTranslationAnchor")]
		MGLStyleValue<NSValue> TextTranslationAnchor { get; set; }
		//@end
	}
	//@interface NSValue (MGLSymbolStyleLayerAdditions)
	[BaseType(typeof(NSValue)), Category]
	public partial interface MGLSymbolStyleLayerAdditions
	{
		//+ (instancetype)valueWithMGLIconRotationAlignment:(MGLIconRotationAlignment)iconRotationAlignment;
		[Export("valueWithMGLIconRotationAlignment:"), Static]
		NSValue ValueWithMGLIconRotationAlignment(MGLIconRotationAlignment iconRotationAlignment);
		//@property (readonly) MGLIconRotationAlignment MGLIconRotationAlignmentValue;
		[Export("MGLIconRotationAlignmentValue"), Static]
		MGLIconRotationAlignment GetMGLIconRotationAlignmentValue();
		//+ (instancetype)valueWithMGLIconTextFit:(MGLIconTextFit)iconTextFit;
		[Export("valueWithMGLIconTextFit:"), Static]
		NSValue ValueWithMGLIconTextFit(MGLIconTextFit iconTextFit);
		//@property (readonly) MGLIconTextFit MGLIconTextFitValue;
		[Export("MGLIconTextFitValue"), Static]
		MGLIconTextFit GetMGLIconTextFitValue();
		//+ (instancetype)valueWithMGLSymbolPlacement:(MGLSymbolPlacement)symbolPlacement;
		[Export("valueWithMGLSymbolPlacement:"), Static]
		NSValue ValueWithMGLSymbolPlacement(MGLSymbolPlacement symbolPlacement);
		//@property (readonly) MGLSymbolPlacement MGLSymbolPlacementValue;
		[Export("MGLSymbolPlacementValue"), Static]
		MGLSymbolPlacement GetMGLSymbolPlacementValue();
		//+ (instancetype)valueWithMGLTextAnchor:(MGLTextAnchor)textAnchor;
		[Export("valueWithMGLTextAnchor:"), Static]
		NSValue ValueWithMGLTextAnchor(MGLTextAnchor textAnchor);
		//@property (readonly) MGLTextAnchor MGLTextAnchorValue;
		[Export("MGLTextAnchorValue"), Static]
		MGLTextAnchor GetMGLTextAnchorValue();
		//+ (instancetype)valueWithMGLTextJustification:(MGLTextJustification)textJustification;
		[Export("valueWithMGLTextJustification:"), Static]
		NSValue ValueWithMGLTextJustification(MGLTextJustification textJustification);
		//@property (readonly) MGLTextJustification MGLTextJustificationValue;
		[Export("MGLTextJustificationValue"), Static]
		MGLTextJustification GetMGLTextJustificationValue();
		//+ (instancetype)valueWithMGLTextPitchAlignment:(MGLTextPitchAlignment)textPitchAlignment;
		[Export("valueWithMGLTextPitchAlignment:"), Static]
		NSValue ValueWithMGLTextPitchAlignment(MGLTextPitchAlignment textPitchAlignment);
		//@property (readonly) MGLTextPitchAlignment MGLTextPitchAlignmentValue;
		[Export("MGLTextPitchAlignmentValue"), Static]
		MGLTextPitchAlignment GetMGLTextPitchAlignmentValue();
		//+ (instancetype)valueWithMGLTextRotationAlignment:(MGLTextRotationAlignment)textRotationAlignment;
		[Export("valueWithMGLTextRotationAlignment:"), Static]
		NSValue ValueWithMGLTextRotationAlignment(MGLTextRotationAlignment textRotationAlignment);
		//@property (readonly) MGLTextRotationAlignment MGLTextRotationAlignmentValue;
		[Export("MGLTextRotationAlignmentValue"), Static]
		MGLTextRotationAlignment GetMGLTextRotationAlignmentValue();
		//+ (instancetype)valueWithMGLTextTransform:(MGLTextTransform)textTransform;
		[Export("valueWithMGLTextTransform:"), Static]
		NSValue ValueWithMGLTextTransform(MGLTextTransform textTransform);
		//@property (readonly) MGLTextTransform MGLTextTransformValue;
		[Export("MGLTextTransformValue"), Static]
		MGLTextTransform GetMGLTextTransformValue();
		//+ (instancetype)valueWithMGLIconTranslationAnchor:(MGLIconTranslationAnchor)iconTranslationAnchor;
		[Export("valueWithMGLIconTranslationAnchor:"), Static]
		NSValue ValueWithMGLIconTranslationAnchor(MGLIconTranslationAnchor iconTranslationAnchor);
		//@property (readonly) MGLIconTranslationAnchor MGLIconTranslationAnchorValue;
		[Export("MGLIconTranslationAnchorValue"), Static]
		MGLIconTranslationAnchor GetMGLIconTranslationAnchorValue();
		//+ (instancetype)valueWithMGLTextTranslationAnchor:(MGLTextTranslationAnchor)textTranslationAnchor;
		[Export("valueWithMGLTextTranslationAnchor:"), Static]
		NSValue ValueWithMGLTextTranslationAnchor(MGLTextTranslationAnchor textTranslationAnchor);
		//@property (readonly) MGLTextTranslationAnchor MGLTextTranslationAnchorValue;
		[Export("MGLTextTranslationAnchorValue"), Static]
		MGLTextTranslationAnchor GetMGLTextTranslationAnchorValue();
		//@end
	}
	//@interface MGLTilePyramidOfflineRegion : NSObject <MGLOfflineRegion, NSSecureCoding, NSCopying>
	[BaseType(typeof(NSObject))]
	public partial interface MGLTilePyramidOfflineRegion : IMGLOfflineRegion, INSSecureCoding, INSCopying
	{
		//@property (nonatomic, readonly) NSUrl *styleURL;
		[Export("styleURL")]
		NSUrl StyleURL { get; }
		//@property (nonatomic, readonly) MGLCoordinateBounds bounds;
		[Export("bounds")]
		MGLCoordinateBounds Bounds { get; }
		//@property (nonatomic, readonly) double minimumZoomLevel;
		[Export("minimumZoomLevel")]
		double MinimumZoomLevel { get; }
		//@property (nonatomic, readonly) double maximumZoomLevel;
		[Export("maximumZoomLevel")]
		double MaximumZoomLevel { get; }
		//- (instancetype)initWithStyleURL:(nullable NSUrl *)styleURL bounds:(MGLCoordinateBounds)bounds fromZoomLevel:(double)minimumZoomLevel toZoomLevel:(double)maximumZoomLevel NS_DESIGNATED_INITIALIZER;
		[Export("initWithStyleURL:bounds:fromZoomLevel:toZoomLevel:"),]
		IntPtr Constructor(NSUrl styleURL, MGLCoordinateBounds bounds, double minimumZoomLevel, double maximumZoomLevel);
		//@end
	}
	////extern NSString NSStringMinimumZoomLevel;
	////[Static]
	//public partial interface Constants
	//{
	//	[Field("NSStringMinimumZoomLevel", "__Internal")]
	//	NSString NSStringMinimumZoomLevel { get; set; }
	//}
	////extern NSString NSStringMaximumZoomLevel;
	////[Static]
	//public partial interface Constants
	//{
	//	[Field("NSStringMaximumZoomLevel", "__Internal")]
	//	NSString NSStringMaximumZoomLevel { get; set; }
	//}
	//#if TARGET_OS_IPHONE
	//extern NSString NSStringAttributionHTMLString;
	//[Static]
	public partial interface Constants
	{
		//[Field("NSStringAttributionHTMLString", "__Internal")]
		//NSString NSStringAttributionHTMLString { get; }
	}
	//extern NSString NSStringAttributionInfos;
	//[Static]
	public partial interface Constants
	{
		//[Field("NSStringAttributionInfos", "__Internal")]
		//NSString NSStringAttributionInfos { get; }
	}
	//#else
	////extern NSString NSStringAttributionHTMLString;
	////[Static]
	//public partial interface Constants
	//{
	//	[Field("NSStringAttributionHTMLString", "__Internal")]
	//	NSString NSStringAttributionHTMLString { get; set; }
	//}
	////extern NSString NSStringAttributionInfos;
	////[Static]
	//public partial interface Constants
	//{
	//	[Field("NSStringAttributionInfos", "__Internal")]
	//	NSString NSStringAttributionInfos { get; set; }
	//}
	//#endif
	//extern NSString NSStringTileCoordinateSystem;
	//[Static]
	public partial interface Constants
	{
		//[Field("NSStringTileCoordinateSystem", "__Internal")]
		//NSString NSStringTileCoordinateSystem { get; }
	}
	//@interface MGLTileSource : MGLSource
	[BaseType(typeof(MGLSource))]
	public partial interface MGLTileSource
	{
		//- (instancetype)initWithIdentifier:(NSString *)identifier configurationURL:(NSUrl *)configurationURL;
		[Export("initWithIdentifier:configurationURL:"),]
		IntPtr Constructor(NSString identifier, NSUrl configurationURL);
		//#### Tile URL templates
		//- (instancetype)initWithIdentifier:(NSString *)identifier tileURLTemplates:(NS_ARRAY_OF(NSString *) *)tileURLTemplates options:(nullable NS_DICTIONARY_OF(NSString, id) *)options;
		[Export("initWithIdentifier:tileURLTemplates:options:"),]
		IntPtr Constructor(NSString identifier, NSString[] tileURLTemplates, NSDictionary<NSString, NSObject> options);
		//@property (nonatomic, copy, nullable, readonly) NSUrl *configurationURL;
		[Export("configurationURL")]
		NSUrl ConfigurationURL { get; }
		//@property (nonatomic, copy, readonly) NS_ARRAY_OF(MGLAttributionInfo *) *attributionInfos;
		[Export("attributionInfos")]
		MGLAttributionInfo[] AttributionInfos { get; }
		//@end
	}
	//#if TARGET_OS_IPHONE
	//#define MGLImage UIImage
	//#else
	//#define MGLImage NSImage
	//#endif
	//#if TARGET_OS_IPHONE
	//#define MGLColor UIColor
	//#else
	//#define MGLColor NSColor
	//#endif
	//#ifndef NS_STRING_ENUM
	//#define NS_STRING_ENUM
	//#define NS_EXTENSIBLE_STRING_ENUM
	//#endif
	//#if !TARGET_OS_IPHONE
	//#endif
	//#ifndef NS_ARRAY_OF
	//#if __has_feature(objc_generics) && (__IPHONE_OS_VERSION_MAX_ALLOWED >= 90000 || __MAC_OS_X_VERSION_MAX_ALLOWED >= 101100)
	//#define NS_ARRAY_OF(ObjectClass...)                 NSArray <ObjectClass>
	//#define NS_MUTABLE_ARRAY_OF(ObjectClass...)         NSMutableArray <ObjectClass>
	//#define NS_SET_OF(ObjectClass...)                   NSSet <ObjectClass>
	//#define NS_MUTABLE_SET_OF(ObjectClass...)           NSMutableSet <ObjectClass>
	//#define NS_DICTIONARY_OF(ObjectClass...)            NSDictionary <ObjectClass>
	//#define NS_MUTABLE_DICTIONARY_OF(ObjectClass...)    NSMutableDictionary <ObjectClass>
	//#else
	//#define NS_ARRAY_OF(ObjectClass...)                 NSArray
	//#define NS_MUTABLE_ARRAY_OF(ObjectClass...)         NSMutableArray
	//#define NS_SET_OF(ObjectClass...)                   NSSet
	//#define NS_MUTABLE_SET_OF(ObjectClass...)           NSMutableSet
	//#define NS_DICTIONARY_OF(ObjectClass...)            NSDictionary
	//#define NS_MUTABLE_DICTIONARY_OF(ObjectClass...)    NSMutableDictionary
	//#endif
	//#endif
	//@interface MGLUserLocation : NSObject <MGLAnnotation, NSSecureCoding>
	[BaseType(typeof(NSObject))]
	public partial interface MGLUserLocation : MGLAnnotation, INSSecureCoding
	{
		//@property (nonatomic, readonly, nullable) CLLocation *location;
		[Export("location")]
		CLLocation Location { get; }
		//@property (nonatomic, readonly, getter=isUpdating) BOOL updating;
		[Export("updating")]
		bool Updating { [Export("isUpdating")]get; }
		//@property (nonatomic, readonly, nullable) CLHeading *heading;
		[Export("heading")]
		CLHeading Heading { get; }
		////@property (nonatomic, copy) NSString *title;
		//[Export("title")]
		//NSString Title { get; set; }
		////@property (nonatomic, copy, nullable) NSString *subtitle;
		//[Export("subtitle")]
		//NSString Subtitle { get; set; }
		//@end
	}
	//@interface MGLUserLocationAnnotationView : MGLAnnotationView
	[BaseType(typeof(MGLAnnotationView))]
	public partial interface MGLUserLocationAnnotationView
	{
		//@property (nonatomic, readonly, weak, nullable) MGLMapView *mapView;
		[Export("mapView")]
		MGLMapView MapView { get; }
		//@property (nonatomic, readonly, weak, nullable) MGLUserLocation *userLocation;
		[Export("userLocation")]
		MGLUserLocation UserLocation { get; }
		//@property (nonatomic, readonly, weak) CALayer *hitTestLayer;
		[Export("hitTestLayer")]
		CALayer HitTestLayer { get; }
		//- (void)update;
		[Export("update"),]
		void Update();
		//@end
	}
	//### Example
	//@interface MGLVectorSource : MGLTileSource
	[BaseType(typeof(MGLTileSource))]
	public partial interface MGLVectorSource
	{
		//- (instancetype)initWithIdentifier:(NSString *)identifier configurationURL:(NSUrl *)configurationURL NS_DESIGNATED_INITIALIZER;
		[Export("initWithIdentifier:configurationURL:"),]
		IntPtr Constructor(NSString identifier, NSUrl configurationURL);
		//- (instancetype)initWithIdentifier:(NSString *)identifier tileURLTemplates:(NS_ARRAY_OF(NSString *) *)tileURLTemplates options:(nullable NS_DICTIONARY_OF(NSString, id) *)options NS_DESIGNATED_INITIALIZER;
		[Export("initWithIdentifier:tileURLTemplates:options:"),]
		IntPtr Constructor(NSString identifier, NSString[] tileURLTemplates, NSDictionary<NSString, NSObject> options);
		//@end
	}
	//@interface MGLVectorStyleLayer : MGLForegroundStyleLayer
	[BaseType(typeof(MGLForegroundStyleLayer))]
	public partial interface MGLVectorStyleLayer
	{
		//@property (nonatomic, nullable) NSString *sourceLayerIdentifier;
		[Export("sourceLayerIdentifier")]
		NSString SourceLayerIdentifier { get; set; }
		//### Example
		//@property (nonatomic, nullable) NSPredicate *predicate;
		[Export("predicate")]
		NSPredicate Predicate { get; set; }
		//@end
	}
	//@interface NSValue (MGLAdditions)
	[BaseType(typeof(NSValue)), Category]
	public partial interface MGLAdditions
	{
		//+ (instancetype)valueWithMGLCoordinate:(CLLocationCoordinate2D)coordinate;
		[Export("valueWithMGLCoordinate:"), Static]
		NSValue ValueWithMGLCoordinate(CLLocationCoordinate2D coordinate);
		//@property (readonly) CLLocationCoordinate2D MGLCoordinateValue;
		[Export("MGLCoordinateValue"), Static]
		CLLocationCoordinate2D GetMGLCoordinateValue();
		//+ (instancetype)valueWithMGLCoordinateSpan:(MGLCoordinateSpan)span;
		[Export("valueWithMGLCoordinateSpan:"), Static]
		NSValue ValueWithMGLCoordinateSpan(MGLCoordinateSpan span);
		//@property (readonly) MGLCoordinateSpan MGLCoordinateSpanValue;
		[Export("MGLCoordinateSpanValue"), Static]
		MGLCoordinateSpan GetMGLCoordinateSpanValue();
		//+ (instancetype)valueWithMGLCoordinateBounds:(MGLCoordinateBounds)bounds;
		[Export("valueWithMGLCoordinateBounds:"), Static]
		NSValue ValueWithMGLCoordinateBounds(MGLCoordinateBounds bounds);
		//@property (readonly) MGLCoordinateBounds MGLCoordinateBoundsValue;
		[Export("MGLCoordinateBoundsValue"), Static]
		MGLCoordinateBounds GetMGLCoordinateBoundsValue();
		//+ (NSValue *)valueWithMGLOfflinePackProgress:(MGLOfflinePackProgress)progress;
		[Export("valueWithMGLOfflinePackProgress:"), Static]
		NSValue ValueWithMGLOfflinePackProgress(MGLOfflinePackProgress progress);
		//@property (readonly) MGLOfflinePackProgress MGLOfflinePackProgressValue;
		[Export("MGLOfflinePackProgressValue"), Static]
		MGLOfflinePackProgress GetMGLOfflinePackProgressValue();
		//@end
	}


	[Static]
	partial interface MGLOfflinePackUserInfoKey { 

		[Field("MGLOfflinePackUserInfoKeyError", "__Internal")]
		NSString Error { get; }

		[Field("MGLOfflinePackUserInfoKeyState", "__Internal")]
		NSString State { get; }

		[Field("MGLOfflinePackUserInfoKeyProgress", "__Internal")]
		NSString Progress { get; }

		[Field("MGLOfflinePackUserInfoKeyMaximumCount", "__Internal")]
		NSString MaximumCount { get; }
	}
}
