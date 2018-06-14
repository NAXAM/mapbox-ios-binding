using System;
using CoreAnimation;
using CoreFoundation;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Mapbox
{
    //@protocol MGLAnnotation <NSObject>
    public partial interface IMGLAnnotation { }
    //@protocol MGLCalloutView <NSObject>
    public partial interface IMGLCalloutView { }
    //@protocol MGLCalloutViewDelegate <NSObject>
    public partial interface IMGLCalloutViewDelegate { }
    //@protocol MGLFeature <MGLAnnotation>
    public partial interface IMGLFeature { }
    //@protocol MGLMapViewDelegate <NSObject>
    public partial interface IMGLMapViewDelegate { }
    //@protocol MGLOfflineRegion <NSObject>
    public partial interface IMGLOfflineRegion { }
    //@protocol MGLOverlay <MGLAnnotation>
    public partial interface IMGLOverlay { }
    public partial interface IMGLOfflineStorageDelegate { }
    //@protocol MGLComputedShapeSourceDataSource<NSObject>
    public partial interface IMGLComputedShapeSourceDataSource { }

    // @interface MGLAccountManager : NSObject
    [BaseType(typeof(NSObject))]
    interface MGLAccountManager
    {
        // @property (class) NSString * _Nullable accessToken;
        [Static]
        [NullAllowed, Export("accessToken")]
        string AccessToken { get; set; }
    }

    // @protocol MGLAnnotation <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MGLAnnotation
    {
        // @required @property (readonly, nonatomic) CLLocationCoordinate2D coordinate;
        [Abstract]
        [Export("coordinate")]
        CLLocationCoordinate2D Coordinate { get; }

        // @optional @property (readonly, copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; }

        // @optional @property (readonly, copy, nonatomic) NSString * _Nullable subtitle;
        [NullAllowed, Export("subtitle")]
        string Subtitle { get; }
    }

    // @interface MGLAnnotationImage : NSObject <NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface MGLAnnotationImage : INSSecureCoding
    {
        // +(instancetype _Nonnull)annotationImageWithImage:(UIImage * _Nonnull)image reuseIdentifier:(NSString * _Nonnull)reuseIdentifier;
        [Static]
        [Export("annotationImageWithImage:reuseIdentifier:")]
        MGLAnnotationImage AnnotationImageWithImage(UIImage image, string reuseIdentifier);

        // @property (nonatomic, strong) UIImage * _Nullable image;
        [NullAllowed, Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // @property (readonly, nonatomic) NSString * _Nonnull reuseIdentifier;
        [Export("reuseIdentifier")]
        string ReuseIdentifier { get; }

        // @property (getter = isEnabled, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { [Bind("isEnabled")] get; set; }
    }

    // @interface MGLAnnotationView : UIView <NSSecureCoding>
    [BaseType(typeof(UIView))]
    interface MGLAnnotationView : INSSecureCoding
    {
        // -(instancetype _Nonnull)initWithReuseIdentifier:(NSString * _Nullable)reuseIdentifier;
        [Export("initWithReuseIdentifier:")]
        IntPtr Constructor([NullAllowed] string reuseIdentifier);

        // -(instancetype _Nonnull)initWithAnnotation:(id<MGLAnnotation> _Nullable)annotation reuseIdentifier:(NSString * _Nullable)reuseIdentifier;
        [Export("initWithAnnotation:reuseIdentifier:")]
        IntPtr Constructor([NullAllowed] IMGLAnnotation annotation, [NullAllowed] string reuseIdentifier);

        // -(void)prepareForReuse;
        [Export("prepareForReuse")]
        void PrepareForReuse();

        // @property (nonatomic) id<MGLAnnotation> _Nullable annotation;
        [NullAllowed, Export("annotation", ArgumentSemantic.Assign)]
        MGLAnnotation Annotation { get; set; }

        // @property (readonly, nonatomic) NSString * _Nullable reuseIdentifier;
        [NullAllowed, Export("reuseIdentifier")]
        string ReuseIdentifier { get; }

        // @property (nonatomic) CGVector centerOffset;
        [Export("centerOffset", ArgumentSemantic.Assign)]
        CGVector CenterOffset { get; set; }

        // @property (assign, nonatomic) BOOL scalesWithViewingDistance;
        [Export("scalesWithViewingDistance")]
        bool ScalesWithViewingDistance { get; set; }

        // @property (assign, nonatomic) BOOL rotatesToMatchCamera;
        [Export("rotatesToMatchCamera")]
        bool RotatesToMatchCamera { get; set; }

        // @property (getter = isSelected, assign, nonatomic) BOOL selected;
        [Export("selected")]
        bool Selected { [Bind("isSelected")] get; set; }

        // -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
        [Export("setSelected:animated:")]
        void SetSelected(bool selected, bool animated);

        // @property (getter = isEnabled, assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { [Bind("isEnabled")] get; set; }

        // @property (getter = isDraggable, assign, nonatomic) BOOL draggable;
        [Export("draggable")]
        bool Draggable { [Bind("isDraggable")] get; set; }

        // @property (readonly, nonatomic) MGLAnnotationViewDragState dragState;
        [Export("dragState")]
        MGLAnnotationViewDragState DragState { get; }

        // -(void)setDragState:(MGLAnnotationViewDragState)dragState animated:(BOOL)animated __attribute__((objc_requires_super));
        [Export("setDragState:animated:")]
        [RequiresSuper]
        void SetDragState(MGLAnnotationViewDragState dragState, bool animated);
    }

    // @interface MGLAttributionInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface MGLAttributionInfo
    {
        // -(instancetype _Nonnull)initWithTitle:(NSAttributedString * _Nonnull)title URL:(NSURL * _Nullable)URL;
        [Export("initWithTitle:URL:")]
        IntPtr Constructor(NSAttributedString title, [NullAllowed] NSUrl URL);

        // @property (nonatomic) NSAttributedString * _Nonnull title;
        [Export("title", ArgumentSemantic.Assign)]
        NSAttributedString Title { get; set; }

        // @property (nonatomic) NSURL * _Nullable URL;
        [NullAllowed, Export("URL", ArgumentSemantic.Assign)]
        NSUrl URL { get; set; }

        // @property (getter = isFeedbackLink, nonatomic) BOOL feedbackLink;
        [Export("feedbackLink")]
        bool FeedbackLink { [Bind("isFeedbackLink")] get; set; }

        // -(NSURL * _Nullable)feedbackURLAtCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate zoomLevel:(double)zoomLevel;
        [Export("feedbackURLAtCenterCoordinate:zoomLevel:")]
        [return: NullAllowed]
        NSUrl FeedbackURLAtCenterCoordinate(CLLocationCoordinate2D centerCoordinate, double zoomLevel);

        // -(NSAttributedString * _Nonnull)titleWithStyle:(MGLAttributionInfoStyle)style;
        [Export("titleWithStyle:")]
        NSAttributedString TitleWithStyle(MGLAttributionInfoStyle style);
    }

    // @interface MGLStyleLayer : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MGLStyleLayer
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (getter = isVisible, assign, nonatomic) BOOL visible;
        [Export("visible")]
        bool Visible { [Bind("isVisible")] get; set; }

        // @property (assign, nonatomic) float maximumZoomLevel;
        [Export("maximumZoomLevel")]
        float MaximumZoomLevel { get; set; }

        // @property (assign, nonatomic) float minimumZoomLevel;
        [Export("minimumZoomLevel")]
        float MinimumZoomLevel { get; set; }
    }

    // @interface MGLBackgroundStyleLayer : MGLStyleLayer
    [BaseType(typeof(MGLStyleLayer))]
    interface MGLBackgroundStyleLayer
    {
        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier;
        [Export("initWithIdentifier:")]
        IntPtr Constructor(string identifier);

        // @property (nonatomic) NSExpression * _Null_unspecified backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Assign)]
        NSExpression BackgroundColor { get; set; }

        // @property (nonatomic) MGLTransition backgroundColorTransition;
        [Export("backgroundColorTransition", ArgumentSemantic.Assign)]
        MGLTransition BackgroundColorTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified backgroundOpacity;
        [Export("backgroundOpacity", ArgumentSemantic.Assign)]
        NSExpression BackgroundOpacity { get; set; }

        // @property (nonatomic) MGLTransition backgroundOpacityTransition;
        [Export("backgroundOpacityTransition", ArgumentSemantic.Assign)]
        MGLTransition BackgroundOpacityTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified backgroundPattern;
        [Export("backgroundPattern", ArgumentSemantic.Assign)]
        NSExpression BackgroundPattern { get; set; }

        // @property (nonatomic) MGLTransition backgroundPatternTransition;
        [Export("backgroundPatternTransition", ArgumentSemantic.Assign)]
        MGLTransition BackgroundPatternTransition { get; set; }
    }

    // @protocol MGLCalloutView <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MGLCalloutView
    {
        // @required @property (nonatomic, strong) id<MGLAnnotation> _Nonnull representedObject;
        [Abstract]
        [Export("representedObject", ArgumentSemantic.Strong)]
        MGLAnnotation RepresentedObject { get; set; }

        // @required @property (nonatomic, strong) UIView * _Nonnull leftAccessoryView;
        [Abstract]
        [Export("leftAccessoryView", ArgumentSemantic.Strong)]
        UIView LeftAccessoryView { get; set; }

        // @required @property (nonatomic, strong) UIView * _Nonnull rightAccessoryView;
        [Abstract]
        [Export("rightAccessoryView", ArgumentSemantic.Strong)]
        UIView RightAccessoryView { get; set; }

        //[Wrap("WeakDelegate"), Abstract]
        //[NullAllowed]
        //MGLCalloutViewDelegate Delegate { get; set; }

        // @required @property (nonatomic, weak) id<MGLCalloutViewDelegate> _Nullable delegate;
        [Abstract]
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @required -(void)presentCalloutFromRect:(CGRect)rect inView:(UIView * _Nonnull)view constrainedToRect:(CGRect)constrainedRect animated:(BOOL)animated;
        [Abstract]
        [Export("presentCalloutFromRect:inView:constrainedToRect:animated:")]
        void PresentCalloutFromRect(CGRect rect, UIView view, CGRect constrainedRect, bool animated);

        // @required -(void)dismissCalloutAnimated:(BOOL)animated;
        [Abstract]
        [Export("dismissCalloutAnimated:")]
        void DismissCalloutAnimated(bool animated);

        // @optional -(UIEdgeInsets)marginInsetsHintForPresentationFromRect:(CGRect)rect;
        [Export("marginInsetsHintForPresentationFromRect:")]
        UIEdgeInsets MarginInsetsHintForPresentationFromRect(CGRect rect);

        // @optional @property (readonly, getter = isAnchoredToAnnotation, assign, nonatomic) BOOL anchoredToAnnotation;
        [Export("anchoredToAnnotation")]
        bool AnchoredToAnnotation { [Bind("isAnchoredToAnnotation")] get; }

        // @optional @property (readonly, assign, nonatomic) BOOL dismissesAutomatically;
        [Export("dismissesAutomatically")]
        bool DismissesAutomatically { get; }
    }

    // @protocol MGLCalloutViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MGLCalloutViewDelegate
    {
        // @optional -(BOOL)calloutViewShouldHighlight:(UIView<MGLCalloutView> * _Nonnull)calloutView;
        [Export("calloutViewShouldHighlight:")]
        bool CalloutViewShouldHighlight(MGLCalloutView calloutView);

        // @optional -(void)calloutViewTapped:(UIView<MGLCalloutView> * _Nonnull)calloutView;
        [Export("calloutViewTapped:")]
        void CalloutViewTapped(MGLCalloutView calloutView);

        // @optional -(void)calloutViewWillAppear:(UIView<MGLCalloutView> * _Nonnull)calloutView;
        [Export("calloutViewWillAppear:")]
        void CalloutViewWillAppear(MGLCalloutView calloutView);

        // @optional -(void)calloutViewDidAppear:(UIView<MGLCalloutView> * _Nonnull)calloutView;
        [Export("calloutViewDidAppear:")]
        void CalloutViewDidAppear(MGLCalloutView calloutView);
    }

    // @interface MGLForegroundStyleLayer : MGLStyleLayer
    [BaseType(typeof(MGLStyleLayer))]
    [DisableDefaultCtor]
    interface MGLForegroundStyleLayer
    {
        // @property (readonly, nonatomic) NSString * _Nullable sourceIdentifier;
        [NullAllowed, Export("sourceIdentifier")]
        string SourceIdentifier { get; }
    }

    // @interface MGLVectorStyleLayer : MGLForegroundStyleLayer
    [BaseType(typeof(MGLForegroundStyleLayer))]
    interface MGLVectorStyleLayer
    {
        // @property (nonatomic) NSString * _Nullable sourceLayerIdentifier;
        [NullAllowed, Export("sourceLayerIdentifier")]
        string SourceLayerIdentifier { get; set; }

        // @property (nonatomic) NSPredicate * _Nullable predicate;
        [NullAllowed, Export("predicate", ArgumentSemantic.Assign)]
        NSPredicate Predicate { get; set; }
    }

    // @interface MGLCircleStyleLayer : MGLVectorStyleLayer
    [BaseType(typeof(MGLVectorStyleLayer))]
    interface MGLCircleStyleLayer
    {
        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source;
        [Export("initWithIdentifier:source:")]
        IntPtr Constructor(string identifier, MGLSource source);

        // @property (nonatomic) NSExpression * _Null_unspecified circleBlur;
        [Export("circleBlur", ArgumentSemantic.Assign)]
        NSExpression CircleBlur { get; set; }

        // @property (nonatomic) MGLTransition circleBlurTransition;
        [Export("circleBlurTransition", ArgumentSemantic.Assign)]
        MGLTransition CircleBlurTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified circleColor;
        [Export("circleColor", ArgumentSemantic.Assign)]
        NSExpression CircleColor { get; set; }

        // @property (nonatomic) MGLTransition circleColorTransition;
        [Export("circleColorTransition", ArgumentSemantic.Assign)]
        MGLTransition CircleColorTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified circleOpacity;
        [Export("circleOpacity", ArgumentSemantic.Assign)]
        NSExpression CircleOpacity { get; set; }

        // @property (nonatomic) MGLTransition circleOpacityTransition;
        [Export("circleOpacityTransition", ArgumentSemantic.Assign)]
        MGLTransition CircleOpacityTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified circlePitchAlignment;
        [Export("circlePitchAlignment", ArgumentSemantic.Assign)]
        NSExpression CirclePitchAlignment { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified circleRadius;
        [Export("circleRadius", ArgumentSemantic.Assign)]
        NSExpression CircleRadius { get; set; }

        // @property (nonatomic) MGLTransition circleRadiusTransition;
        [Export("circleRadiusTransition", ArgumentSemantic.Assign)]
        MGLTransition CircleRadiusTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified circleScaleAlignment;
        [Export("circleScaleAlignment", ArgumentSemantic.Assign)]
        NSExpression CircleScaleAlignment { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified circleStrokeColor;
        [Export("circleStrokeColor", ArgumentSemantic.Assign)]
        NSExpression CircleStrokeColor { get; set; }

        // @property (nonatomic) MGLTransition circleStrokeColorTransition;
        [Export("circleStrokeColorTransition", ArgumentSemantic.Assign)]
        MGLTransition CircleStrokeColorTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified circleStrokeOpacity;
        [Export("circleStrokeOpacity", ArgumentSemantic.Assign)]
        NSExpression CircleStrokeOpacity { get; set; }

        // @property (nonatomic) MGLTransition circleStrokeOpacityTransition;
        [Export("circleStrokeOpacityTransition", ArgumentSemantic.Assign)]
        MGLTransition CircleStrokeOpacityTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified circleStrokeWidth;
        [Export("circleStrokeWidth", ArgumentSemantic.Assign)]
        NSExpression CircleStrokeWidth { get; set; }

        // @property (nonatomic) MGLTransition circleStrokeWidthTransition;
        [Export("circleStrokeWidthTransition", ArgumentSemantic.Assign)]
        MGLTransition CircleStrokeWidthTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified circleTranslation;
        [Export("circleTranslation", ArgumentSemantic.Assign)]
        NSExpression CircleTranslation { get; set; }

        // @property (nonatomic) MGLTransition circleTranslationTransition;
        [Export("circleTranslationTransition", ArgumentSemantic.Assign)]
        MGLTransition CircleTranslationTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified circleTranslationAnchor;
        [Export("circleTranslationAnchor", ArgumentSemantic.Assign)]
        NSExpression CircleTranslationAnchor { get; set; }
    }

    // @interface MGLCircleStyleLayerAdditions (NSValue)
    [Category]
    [BaseType(typeof(NSValue))]
    interface NSValue_MGLCircleStyleLayerAdditions
    {
        // +(instancetype _Nonnull)valueWithMGLCirclePitchAlignment:(MGLCirclePitchAlignment)circlePitchAlignment;
        [Static]
        [Export("valueWithMGLCirclePitchAlignment:")]
        NSValue ValueWithMGLCirclePitchAlignment(MGLCirclePitchAlignment circlePitchAlignment);

        // @property (readonly) MGLCirclePitchAlignment MGLCirclePitchAlignmentValue;
        [Export("MGLCirclePitchAlignmentValue")]
        MGLCirclePitchAlignment MGLCirclePitchAlignmentValue();

        // +(instancetype _Nonnull)valueWithMGLCircleScaleAlignment:(MGLCircleScaleAlignment)circleScaleAlignment;
        [Static]
        [Export("valueWithMGLCircleScaleAlignment:")]
        NSValue ValueWithMGLCircleScaleAlignment(MGLCircleScaleAlignment circleScaleAlignment);

        // @property (readonly) MGLCircleScaleAlignment MGLCircleScaleAlignmentValue;
        [Export("MGLCircleScaleAlignmentValue")]
        MGLCircleScaleAlignment MGLCircleScaleAlignmentValue();

        // +(instancetype _Nonnull)valueWithMGLCircleTranslationAnchor:(MGLCircleTranslationAnchor)circleTranslationAnchor;
        [Static]
        [Export("valueWithMGLCircleTranslationAnchor:")]
        NSValue ValueWithMGLCircleTranslationAnchor(MGLCircleTranslationAnchor circleTranslationAnchor);

        // @property (readonly) MGLCircleTranslationAnchor MGLCircleTranslationAnchorValue;
        [Export("MGLCircleTranslationAnchorValue")]
        MGLCircleTranslationAnchor MGLCircleTranslationAnchorValue();
    }

    // @interface MGLClockDirectionFormatter : NSFormatter
    [BaseType(typeof(NSFormatter))]
    interface MGLClockDirectionFormatter
    {
        // @property (nonatomic) NSFormattingUnitStyle unitStyle;
        [Export("unitStyle", ArgumentSemantic.Assign)]
        NSFormattingUnitStyle UnitStyle { get; set; }

        // -(NSString * _Nonnull)stringFromDirection:(CLLocationDirection)direction;
        [Export("stringFromDirection:")]
        string StringFromDirection(double direction);

        // -(BOOL)getObjectValue:(id  _Nullable * _Nullable)obj forString:(NSString * _Nonnull)string errorDescription:(NSString * _Nullable * _Nullable)error;
        [Export("getObjectValue:forString:errorDescription:")]
        bool GetObjectValue([NullAllowed] out NSObject obj, string @string, [NullAllowed] out string error);
    }

    // @interface MGLCompassDirectionFormatter : NSFormatter
    [BaseType(typeof(NSFormatter))]
    interface MGLCompassDirectionFormatter
    {
        // @property (nonatomic) NSFormattingUnitStyle unitStyle;
        [Export("unitStyle", ArgumentSemantic.Assign)]
        NSFormattingUnitStyle UnitStyle { get; set; }

        // -(NSString * _Nonnull)stringFromDirection:(CLLocationDirection)direction;
        [Export("stringFromDirection:")]
        string StringFromDirection(double direction);

        // -(BOOL)getObjectValue:(id  _Nullable * _Nullable)obj forString:(NSString * _Nonnull)string errorDescription:(NSString * _Nullable * _Nullable)error;
        [Export("getObjectValue:forString:errorDescription:")]
        bool GetObjectValue([NullAllowed] out NSObject obj, string @string, [NullAllowed] out string error);
    }


    // @interface MGLSource : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MGLSource
    {
        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier;
        [Export("initWithIdentifier:")]
        IntPtr Constructor(string identifier);

        // @property (copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; set; }
    }

    [Static]
    partial interface MGLShapeSourceOptions
    {
        // extern const MGLShapeSourceOption _Nonnull MGLShapeSourceOptionClustered __attribute__((visibility("default")));
        [Field("MGLShapeSourceOptionClustered", "__Internal")]
        NSString Clustered { get; }

        // extern const MGLShapeSourceOption _Nonnull MGLShapeSourceOptionClusterRadius __attribute__((visibility("default")));
        [Field("MGLShapeSourceOptionClusterRadius", "__Internal")]
        NSString ClusterRadius { get; }

        // extern const MGLShapeSourceOption _Nonnull MGLShapeSourceOptionMaximumZoomLevelForClustering __attribute__((visibility("default")));
        [Field("MGLShapeSourceOptionMaximumZoomLevelForClustering", "__Internal")]
        NSString MaximumZoomLevelForClustering { get; }

        // extern const MGLShapeSourceOption _Nonnull MGLShapeSourceOptionMinimumZoomLevel __attribute__((visibility("default")));
        [Field("MGLShapeSourceOptionMinimumZoomLevel", "__Internal")]
        NSString MinimumZoomLevel { get; }

        // extern const MGLShapeSourceOption _Nonnull MGLShapeSourceOptionMaximumZoomLevel __attribute__((visibility("default")));
        [Field("MGLShapeSourceOptionMaximumZoomLevel", "__Internal")]
        NSString MaximumZoomLevel { get; }

        // extern const MGLShapeSourceOption _Nonnull MGLShapeSourceOptionBuffer __attribute__((visibility("default")));
        [Field("MGLShapeSourceOptionBuffer", "__Internal")]
        NSString Buffer { get; }

        // extern const MGLShapeSourceOption _Nonnull MGLShapeSourceOptionSimplificationTolerance __attribute__((visibility("default")));
        [Field("MGLShapeSourceOptionSimplificationTolerance", "__Internal")]
        NSString SimplificationTolerance { get; }

        // extern const MGLShapeSourceOption _Nonnull MGLShapeSourceOptionWrapsCoordinates __attribute__((visibility("default")));
        [Field("MGLShapeSourceOptionWrapsCoordinates", "__Internal")]
        NSString WrapsCoordinates { get; }

        // extern const MGLShapeSourceOption _Nonnull MGLShapeSourceOptionClipsCoordinates __attribute__((visibility("default")));
        [Field("MGLShapeSourceOptionClipsCoordinates", "__Internal")]
        NSString ClipsCoordinates { get; }
    }

    // @interface MGLShapeSource : MGLSource
    [BaseType(typeof(MGLSource))]
    interface MGLShapeSource
    {
        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier URL:(NSURL * _Nonnull)url options:(NSDictionary<MGLShapeSourceOption,id> * _Nullable)options __attribute__((objc_designated_initializer));
        [Export("initWithIdentifier:URL:options:")]
        [DesignatedInitializer]
        IntPtr Constructor(string identifier, NSUrl url, [NullAllowed] NSDictionary<NSString, NSObject> options);

        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier shape:(MGLShape * _Nullable)shape options:(NSDictionary<MGLShapeSourceOption,id> * _Nullable)options __attribute__((objc_designated_initializer));
        [Export("initWithIdentifier:shape:options:")]
        [DesignatedInitializer]
        IntPtr Constructor(string identifier, [NullAllowed] MGLShape shape, [NullAllowed] NSDictionary<NSString, NSObject> options);

        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier features:(NSArray<MGLShape<MGLFeature> *> * _Nonnull)features options:(NSDictionary<MGLShapeSourceOption,id> * _Nullable)options;
        [Export("initWithIdentifier:features:options:")]
        IntPtr Constructor(string identifier, NSObject[] features, [NullAllowed] NSDictionary<NSString, NSObject> options);

        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier shapes:(NSArray<MGLShape *> * _Nonnull)shapes options:(NSDictionary<MGLShapeSourceOption,id> * _Nullable)options;
        [Export("initWithIdentifier:shapes:options:")]
        IntPtr Constructor(string identifier, MGLShape[] shapes, [NullAllowed] NSDictionary<NSString, NSObject> options);

        // @property (copy, nonatomic) MGLShape * _Nullable shape;
        [NullAllowed, Export("shape", ArgumentSemantic.Copy)]
        MGLShape Shape { get; set; }

        // @property (copy, nonatomic) NSURL * _Nullable URL;
        [NullAllowed, Export("URL", ArgumentSemantic.Copy)]
        NSUrl URL { get; set; }

        // -(NSArray<id<MGLFeature>> * _Nonnull)featuresMatchingPredicate:(NSPredicate * _Nullable)predicate;
        [Export("featuresMatchingPredicate:")]
        NSObject[] FeaturesMatchingPredicate([NullAllowed] NSPredicate predicate);
    }

    // @protocol MGLComputedShapeSourceDataSource <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MGLComputedShapeSourceDataSource
    {
        // @optional -(NSArray<MGLShape<MGLFeature> *> * _Nonnull)featuresInTileAtX:(NSUInteger)x y:(NSUInteger)y zoomLevel:(NSUInteger)zoomLevel;
        [Export("featuresInTileAtX:y:zoomLevel:")]
        NSObject[] FeaturesInTileAtX(nuint x, nuint y, nuint zoomLevel);

        // @optional -(NSArray<MGLShape<MGLFeature> *> * _Nonnull)featuresInCoordinateBounds:(MGLCoordinateBounds)bounds zoomLevel:(NSUInteger)zoomLevel;
        [Export("featuresInCoordinateBounds:zoomLevel:")]
        NSObject[] FeaturesInCoordinateBounds(MGLCoordinateBounds bounds, nuint zoomLevel);
    }

    // @interface MGLComputedShapeSource : MGLSource
    [BaseType(typeof(MGLSource))]
    interface MGLComputedShapeSource
    {
        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier options:(NSDictionary<MGLShapeSourceOption,id> * _Nullable)options __attribute__((objc_designated_initializer));
        [Export("initWithIdentifier:options:")]
        [DesignatedInitializer]
        IntPtr Constructor(string identifier, [NullAllowed] NSDictionary<NSString, NSObject> options);

        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier dataSource:(id<MGLComputedShapeSourceDataSource> _Nonnull)dataSource options:(NSDictionary<MGLShapeSourceOption,id> * _Nullable)options;
        [Export("initWithIdentifier:dataSource:options:")]
        IntPtr Constructor(string identifier, IMGLComputedShapeSourceDataSource dataSource, [NullAllowed] NSDictionary<NSString, NSObject> options);

        // -(void)invalidateBounds:(MGLCoordinateBounds)bounds;
        [Export("invalidateBounds:")]
        void InvalidateBounds(MGLCoordinateBounds bounds);

        // -(void)invalidateTileAtX:(NSUInteger)x y:(NSUInteger)y zoomLevel:(NSUInteger)zoomLevel;
        [Export("invalidateTileAtX:y:zoomLevel:")]
        void InvalidateTileAtX(nuint x, nuint y, nuint zoomLevel);

        // -(void)setFeatures:(NSArray<MGLShape<MGLFeature> *> * _Nonnull)features inTileAtX:(NSUInteger)x y:(NSUInteger)y zoomLevel:(NSUInteger)zoomLevel;
        [Export("setFeatures:inTileAtX:y:zoomLevel:")]
        void SetFeatures(NSObject[] features, nuint x, nuint y, nuint zoomLevel);

        // @property (nonatomic, weak) id<MGLComputedShapeSourceDataSource> _Nullable dataSource;
        [NullAllowed, Export("dataSource", ArgumentSemantic.Weak)]
        NSObject WeakDataSource { get; set; }

        // @property (readonly, nonatomic) NSOperationQueue * _Nonnull requestQueue;
        [Export("requestQueue")]
        NSOperationQueue RequestQueue { get; }
    }

    // @interface MGLCoordinateFormatter : NSFormatter
    [BaseType(typeof(NSFormatter))]
    interface MGLCoordinateFormatter
    {
        // @property (nonatomic) BOOL allowsMinutes;
        [Export("allowsMinutes")]
        bool AllowsMinutes { get; set; }

        // @property (nonatomic) BOOL allowsSeconds;
        [Export("allowsSeconds")]
        bool AllowsSeconds { get; set; }

        // @property (nonatomic) NSFormattingUnitStyle unitStyle;
        [Export("unitStyle", ArgumentSemantic.Assign)]
        NSFormattingUnitStyle UnitStyle { get; set; }

        // -(NSString * _Nonnull)stringFromCoordinate:(CLLocationCoordinate2D)coordinate;
        [Export("stringFromCoordinate:")]
        string StringFromCoordinate(CLLocationCoordinate2D coordinate);

        // -(BOOL)getObjectValue:(id  _Nullable * _Nullable)obj forString:(NSString * _Nonnull)string errorDescription:(NSString * _Nullable * _Nullable)error;
        [Export("getObjectValue:forString:errorDescription:")]
        bool GetObjectValue([NullAllowed] out NSObject obj, string @string, [NullAllowed] out string error);
    }

    // @interface MGLDistanceFormatter : NSLengthFormatter
    [BaseType(typeof(NSLengthFormatter))]
    interface MGLDistanceFormatter
    {
        // -(NSString * _Nonnull)stringFromDistance:(CLLocationDistance)distance;
        [Export("stringFromDistance:")]
        string StringFromDistance(double distance);
    }

    // @interface MGLShape : NSObject <MGLAnnotation, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface MGLShape : MGLAnnotation, INSSecureCoding
    {
        // +(MGLShape * _Nullable)shapeWithData:(NSData * _Nonnull)data encoding:(NSStringEncoding)encoding error:(NSError * _Nullable * _Nullable)outError;
        [Static]
        [Export("shapeWithData:encoding:error:")]
        [return: NullAllowed]
        MGLShape ShapeWithData(NSData data, nuint encoding, [NullAllowed] out NSError outError);

        // @property (copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable subtitle;
        [NullAllowed, Export("subtitle")]
        string Subtitle { get; set; }

        // -(NSData * _Nonnull)geoJSONDataUsingEncoding:(NSStringEncoding)encoding;
        [Export("geoJSONDataUsingEncoding:")]
        NSData GeoJSONDataUsingEncoding(nuint encoding);
    }

    // @interface MGLMultiPoint : MGLShape
    [BaseType(typeof(MGLShape))]
    interface MGLMultiPoint
    {
        // @property (readonly, nonatomic) CLLocationCoordinate2D * _Nonnull coordinates __attribute__((objc_returns_inner_pointer));
        [Export("coordinates")]
        NSArray Coordinates { get; }

        // @property (readonly, nonatomic) NSUInteger pointCount;
        [Export("pointCount")]
        nuint PointCount { get; }

        // -(void)getCoordinates:(CLLocationCoordinate2D * _Nonnull)coords range:(NSRange)range;
        [Export("getCoordinates:range:")]
        unsafe void GetCoordinates(ref CLLocationCoordinate2D coords, NSRange range);

        // -(void)setCoordinates:(CLLocationCoordinate2D * _Nonnull)coords count:(NSUInteger)count;
        [Export("setCoordinates:count:")]
        unsafe void SetCoordinates(ref CLLocationCoordinate2D coords, nuint count);

        // -(void)insertCoordinates:(const CLLocationCoordinate2D * _Nonnull)coords count:(NSUInteger)count atIndex:(NSUInteger)index;
        [Export("insertCoordinates:count:atIndex:")]
        unsafe void InsertCoordinates(ref CLLocationCoordinate2D coords, nuint count, nuint index);

        // -(void)appendCoordinates:(const CLLocationCoordinate2D * _Nonnull)coords count:(NSUInteger)count;
        [Export("appendCoordinates:count:")]
        unsafe void AppendCoordinates(ref CLLocationCoordinate2D coords, nuint count);

        // -(void)replaceCoordinatesInRange:(NSRange)range withCoordinates:(const CLLocationCoordinate2D * _Nonnull)coords;
        [Export("replaceCoordinatesInRange:withCoordinates:")]
        unsafe void ReplaceCoordinatesInRange(NSRange range, ref CLLocationCoordinate2D coords);

        // -(void)replaceCoordinatesInRange:(NSRange)range withCoordinates:(const CLLocationCoordinate2D * _Nonnull)coords count:(NSUInteger)count;
        [Export("replaceCoordinatesInRange:withCoordinates:count:")]
        unsafe void ReplaceCoordinatesInRange(NSRange range, ref CLLocationCoordinate2D coords, nuint count);

        // -(void)removeCoordinatesInRange:(NSRange)range;
        [Export("removeCoordinatesInRange:")]
        void RemoveCoordinatesInRange(NSRange range);
    }

    // @protocol MGLOverlay <MGLAnnotation>
    [Protocol, Model]
    interface MGLOverlay : MGLAnnotation
    {
        //// @required @property (readonly, nonatomic) CLLocationCoordinate2D coordinate;
        //[Abstract]
        //[Export("coordinate")]
        //CLLocationCoordinate2D Coordinate { get; }

        // @required @property (readonly, nonatomic) MGLCoordinateBounds overlayBounds;
        [Abstract]
        [Export("overlayBounds")]
        MGLCoordinateBounds OverlayBounds { get; }

        // @required -(BOOL)intersectsOverlayBounds:(MGLCoordinateBounds)overlayBounds;
        [Abstract]
        [Export("intersectsOverlayBounds:")]
        bool IntersectsOverlayBounds(MGLCoordinateBounds overlayBounds);
    }

    // @interface MGLPolyline : MGLMultiPoint <MGLOverlay>
    [BaseType(typeof(MGLMultiPoint))]
    interface MGLPolyline : MGLOverlay
    {
        // +(instancetype _Nonnull)polylineWithCoordinates:(const CLLocationCoordinate2D * _Nonnull)coords count:(NSUInteger)count;
        [Static]
        [Export("polylineWithCoordinates:count:")]
        unsafe MGLPolyline PolylineWithCoordinates(ref CLLocationCoordinate2D coords, nuint count);
    }

    // @interface MGLMultiPolyline : MGLShape <MGLOverlay>
    [BaseType(typeof(MGLShape))]
    interface MGLMultiPolyline : MGLOverlay
    {
        // @property (readonly, copy, nonatomic) NSArray<MGLPolyline *> * _Nonnull polylines;
        [Export("polylines", ArgumentSemantic.Copy)]
        MGLPolyline[] Polylines { get; }

        // +(instancetype _Nonnull)multiPolylineWithPolylines:(NSArray<MGLPolyline *> * _Nonnull)polylines;
        [Static]
        [Export("multiPolylineWithPolylines:")]
        MGLMultiPolyline MultiPolylineWithPolylines(MGLPolyline[] polylines);
    }

    // @interface MGLPolygon : MGLMultiPoint <MGLOverlay>
    [BaseType(typeof(MGLMultiPoint))]
    interface MGLPolygon : MGLOverlay
    {
        // @property (readonly, nonatomic) NSArray<MGLPolygon *> * _Nullable interiorPolygons;
        [NullAllowed, Export("interiorPolygons")]
        MGLPolygon[] InteriorPolygons { get; }

        // +(instancetype _Nonnull)polygonWithCoordinates:(const CLLocationCoordinate2D * _Nonnull)coords count:(NSUInteger)count;
        [Static]
        [Export("polygonWithCoordinates:count:")]
        unsafe MGLPolygon PolygonWithCoordinates(ref CLLocationCoordinate2D coords, nuint count);

        // +(instancetype _Nonnull)polygonWithCoordinates:(const CLLocationCoordinate2D * _Nonnull)coords count:(NSUInteger)count interiorPolygons:(NSArray<MGLPolygon *> * _Nullable)interiorPolygons;
        [Static]
        [Export("polygonWithCoordinates:count:interiorPolygons:")]
        unsafe MGLPolygon PolygonWithCoordinates(ref CLLocationCoordinate2D coords, nuint count, [NullAllowed] MGLPolygon[] interiorPolygons);
    }

    // @interface MGLMultiPolygon : MGLShape <MGLOverlay>
    [BaseType(typeof(MGLShape))]
    interface MGLMultiPolygon : MGLOverlay
    {
        // @property (readonly, copy, nonatomic) NSArray<MGLPolygon *> * _Nonnull polygons;
        [Export("polygons", ArgumentSemantic.Copy)]
        MGLPolygon[] Polygons { get; }

        // +(instancetype _Nonnull)multiPolygonWithPolygons:(NSArray<MGLPolygon *> * _Nonnull)polygons;
        [Static]
        [Export("multiPolygonWithPolygons:")]
        MGLMultiPolygon MultiPolygonWithPolygons(MGLPolygon[] polygons);
    }


    // @interface MGLPointAnnotation : MGLShape
    [BaseType(typeof(MGLShape))]
    interface MGLPointAnnotation
    {
        // @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
        [Export("coordinate", ArgumentSemantic.Assign)]
        CLLocationCoordinate2D Coordinate { get; set; }
    }

    // @interface MGLPointCollection : MGLShape <MGLOverlay>
    [BaseType(typeof(MGLShape))]
    interface MGLPointCollection : MGLOverlay
    {
        // +(instancetype)pointCollectionWithCoordinates:(const CLLocationCoordinate2D *)coords count:(NSUInteger)count;
        [Static]
        [Export("pointCollectionWithCoordinates:count:")]
        unsafe MGLPointCollection PointCollectionWithCoordinates(ref CLLocationCoordinate2D coords, nuint count);

        // @property (readonly, nonatomic) CLLocationCoordinate2D * coordinates __attribute__((objc_returns_inner_pointer));
        [Export("coordinates")]
        NSArray Coordinates { get; }

        // @property (readonly, nonatomic) NSUInteger pointCount;
        [Export("pointCount")]
        nuint PointCount { get; }

        // -(void)getCoordinates:(CLLocationCoordinate2D *)coords range:(NSRange)range;
        [Export("getCoordinates:range:")]
        unsafe void GetCoordinates(ref CLLocationCoordinate2D coords, NSRange range);
    }

    // @interface MGLShapeCollection : MGLShape
    [BaseType(typeof(MGLShape))]
    interface MGLShapeCollection
    {
        // @property (readonly, copy, nonatomic) NSArray<MGLShape *> * _Nonnull shapes;
        [Export("shapes", ArgumentSemantic.Copy)]
        MGLShape[] Shapes { get; }

        // +(instancetype _Nonnull)shapeCollectionWithShapes:(NSArray<MGLShape *> * _Nonnull)shapes;
        [Static]
        [Export("shapeCollectionWithShapes:")]
        MGLShapeCollection ShapeCollectionWithShapes(MGLShape[] shapes);
    }

    // @protocol MGLFeature <MGLAnnotation>
    [Protocol, Model]
    interface MGLFeature : MGLAnnotation
    {
        // @required @property (copy, nonatomic) id _Nullable identifier;
        [Abstract]
        [NullAllowed, Export("identifier", ArgumentSemantic.Copy)]
        NSObject Identifier { get; set; }

        // @required @property (copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull attributes;
        [Abstract]
        [Export("attributes", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSObject> Attributes { get; set; }

        // @required -(id _Nullable)attributeForKey:(NSString * _Nonnull)key;
        [Abstract]
        [Export("attributeForKey:")]
        [return: NullAllowed]
        NSObject AttributeForKey(string key);

        // @required -(NSDictionary<NSString *,id> * _Nonnull)geoJSONDictionary;
        [Abstract]
        [Export("geoJSONDictionary")]
        NSDictionary<NSString, NSObject> GeoJSONDictionary { get; }
    }

    // @interface MGLPointFeature : MGLPointAnnotation <MGLFeature>
    [BaseType(typeof(MGLPointAnnotation))]
    interface MGLPointFeature : MGLFeature
    {
    }

    // @interface MGLPolylineFeature : MGLPolyline <MGLFeature>
    [BaseType(typeof(MGLPolyline))]
    interface MGLPolylineFeature : MGLFeature
    {
    }

    // @interface MGLPolygonFeature : MGLPolygon <MGLFeature>
    [BaseType(typeof(MGLPolygon))]
    interface MGLPolygonFeature : MGLFeature
    {
    }

    // @interface MGLPointCollectionFeature : MGLPointCollection <MGLFeature>
    [BaseType(typeof(MGLPointCollection))]
    interface MGLPointCollectionFeature : MGLFeature
    {
    }

    // @interface MGLMultiPolylineFeature : MGLMultiPolyline <MGLFeature>
    [BaseType(typeof(MGLMultiPolyline))]
    interface MGLMultiPolylineFeature : MGLFeature
    {
    }

    // @interface MGLMultiPolygonFeature : MGLMultiPolygon <MGLFeature>
    [BaseType(typeof(MGLMultiPolygon))]
    interface MGLMultiPolygonFeature : MGLFeature
    {
    }

    // @interface MGLShapeCollectionFeature : MGLShapeCollection <MGLFeature>
    [BaseType(typeof(MGLShapeCollection))]
    interface MGLShapeCollectionFeature : MGLFeature
    {
        // @property (readonly, copy, nonatomic) NSArray<MGLShape<MGLFeature> *> * _Nonnull shapes;
        [Export("shapes", ArgumentSemantic.Copy)]
        NSObject[] Shapes { get; }

        // +(instancetype _Nonnull)shapeCollectionWithShapes:(NSArray<MGLShape<MGLFeature> *> * _Nonnull)shapes;
        [Static]
        [Export("shapeCollectionWithShapes:")]
        MGLShapeCollectionFeature ShapeCollectionWithShapes(NSObject[] shapes);
    }


    // @interface MGLFillExtrusionStyleLayer : MGLVectorStyleLayer
    [BaseType(typeof(MGLVectorStyleLayer))]
    interface MGLFillExtrusionStyleLayer
    {
        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source;
        [Export("initWithIdentifier:source:")]
        IntPtr Constructor(string identifier, MGLSource source);

        // @property (nonatomic) NSExpression * _Null_unspecified fillExtrusionBase;
        [Export("fillExtrusionBase", ArgumentSemantic.Assign)]
        NSExpression FillExtrusionBase { get; set; }

        // @property (nonatomic) MGLTransition fillExtrusionBaseTransition;
        [Export("fillExtrusionBaseTransition", ArgumentSemantic.Assign)]
        MGLTransition FillExtrusionBaseTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified fillExtrusionColor;
        [Export("fillExtrusionColor", ArgumentSemantic.Assign)]
        NSExpression FillExtrusionColor { get; set; }

        // @property (nonatomic) MGLTransition fillExtrusionColorTransition;
        [Export("fillExtrusionColorTransition", ArgumentSemantic.Assign)]
        MGLTransition FillExtrusionColorTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified fillExtrusionHeight;
        [Export("fillExtrusionHeight", ArgumentSemantic.Assign)]
        NSExpression FillExtrusionHeight { get; set; }

        // @property (nonatomic) MGLTransition fillExtrusionHeightTransition;
        [Export("fillExtrusionHeightTransition", ArgumentSemantic.Assign)]
        MGLTransition FillExtrusionHeightTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified fillExtrusionOpacity;
        [Export("fillExtrusionOpacity", ArgumentSemantic.Assign)]
        NSExpression FillExtrusionOpacity { get; set; }

        // @property (nonatomic) MGLTransition fillExtrusionOpacityTransition;
        [Export("fillExtrusionOpacityTransition", ArgumentSemantic.Assign)]
        MGLTransition FillExtrusionOpacityTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified fillExtrusionPattern;
        [Export("fillExtrusionPattern", ArgumentSemantic.Assign)]
        NSExpression FillExtrusionPattern { get; set; }

        // @property (nonatomic) MGLTransition fillExtrusionPatternTransition;
        [Export("fillExtrusionPatternTransition", ArgumentSemantic.Assign)]
        MGLTransition FillExtrusionPatternTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified fillExtrusionTranslation;
        [Export("fillExtrusionTranslation", ArgumentSemantic.Assign)]
        NSExpression FillExtrusionTranslation { get; set; }

        // @property (nonatomic) MGLTransition fillExtrusionTranslationTransition;
        [Export("fillExtrusionTranslationTransition", ArgumentSemantic.Assign)]
        MGLTransition FillExtrusionTranslationTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified fillExtrusionTranslationAnchor;
        [Export("fillExtrusionTranslationAnchor", ArgumentSemantic.Assign)]
        NSExpression FillExtrusionTranslationAnchor { get; set; }
    }


    // @interface MGLFillExtrusionStyleLayerAdditions (NSValue)
    [Category]
    [BaseType(typeof(NSValue))]
    interface NSValue_MGLFillExtrusionStyleLayerAdditions
    {
        // +(instancetype _Nonnull)valueWithMGLFillExtrusionTranslationAnchor:(MGLFillExtrusionTranslationAnchor)fillExtrusionTranslationAnchor;
        [Static]
        [Export("valueWithMGLFillExtrusionTranslationAnchor:")]
        NSValue ValueWithMGLFillExtrusionTranslationAnchor(MGLFillExtrusionTranslationAnchor fillExtrusionTranslationAnchor);

        // @property (readonly) MGLFillExtrusionTranslationAnchor MGLFillExtrusionTranslationAnchorValue;
        [Export("MGLFillExtrusionTranslationAnchorValue")]
        MGLFillExtrusionTranslationAnchor MGLFillExtrusionTranslationAnchorValue();
    }

    // @interface MGLFillStyleLayer : MGLVectorStyleLayer
    [BaseType(typeof(MGLVectorStyleLayer))]
    interface MGLFillStyleLayer
    {
        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source;
        [Export("initWithIdentifier:source:")]
        IntPtr Constructor(string identifier, MGLSource source);

        // @property (getter = isFillAntialiased, nonatomic) NSExpression * _Null_unspecified fillAntialiased;
        [Export("fillAntialiased", ArgumentSemantic.Assign)]
        NSExpression FillAntialiased { [Bind("isFillAntialiased")] get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified fillColor;
        [Export("fillColor", ArgumentSemantic.Assign)]
        NSExpression FillColor { get; set; }

        // @property (nonatomic) MGLTransition fillColorTransition;
        [Export("fillColorTransition", ArgumentSemantic.Assign)]
        MGLTransition FillColorTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified fillOpacity;
        [Export("fillOpacity", ArgumentSemantic.Assign)]
        NSExpression FillOpacity { get; set; }

        // @property (nonatomic) MGLTransition fillOpacityTransition;
        [Export("fillOpacityTransition", ArgumentSemantic.Assign)]
        MGLTransition FillOpacityTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified fillOutlineColor;
        [Export("fillOutlineColor", ArgumentSemantic.Assign)]
        NSExpression FillOutlineColor { get; set; }

        // @property (nonatomic) MGLTransition fillOutlineColorTransition;
        [Export("fillOutlineColorTransition", ArgumentSemantic.Assign)]
        MGLTransition FillOutlineColorTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified fillPattern;
        [Export("fillPattern", ArgumentSemantic.Assign)]
        NSExpression FillPattern { get; set; }

        // @property (nonatomic) MGLTransition fillPatternTransition;
        [Export("fillPatternTransition", ArgumentSemantic.Assign)]
        MGLTransition FillPatternTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified fillTranslation;
        [Export("fillTranslation", ArgumentSemantic.Assign)]
        NSExpression FillTranslation { get; set; }

        // @property (nonatomic) MGLTransition fillTranslationTransition;
        [Export("fillTranslationTransition", ArgumentSemantic.Assign)]
        MGLTransition FillTranslationTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified fillTranslationAnchor;
        [Export("fillTranslationAnchor", ArgumentSemantic.Assign)]
        NSExpression FillTranslationAnchor { get; set; }
    }

    // @interface MGLFillStyleLayerAdditions (NSValue)
    [Category]
    [BaseType(typeof(NSValue))]
    interface NSValue_MGLFillStyleLayerAdditions
    {
        // +(instancetype _Nonnull)valueWithMGLFillTranslationAnchor:(MGLFillTranslationAnchor)fillTranslationAnchor;
        [Static]
        [Export("valueWithMGLFillTranslationAnchor:")]
        NSValue ValueWithMGLFillTranslationAnchor(MGLFillTranslationAnchor fillTranslationAnchor);

        // @property (readonly) MGLFillTranslationAnchor MGLFillTranslationAnchorValue;
        [Export("MGLFillTranslationAnchorValue")]
        MGLFillTranslationAnchor MGLFillTranslationAnchorValue();
    }

    // @interface MGLHeatmapStyleLayer : MGLVectorStyleLayer
    [BaseType(typeof(MGLVectorStyleLayer))]
    interface MGLHeatmapStyleLayer
    {
        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source;
        [Export("initWithIdentifier:source:")]
        IntPtr Constructor(string identifier, MGLSource source);

        // @property (nonatomic) NSExpression * _Null_unspecified heatmapColor;
        [Export("heatmapColor", ArgumentSemantic.Assign)]
        NSExpression HeatmapColor { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified heatmapIntensity;
        [Export("heatmapIntensity", ArgumentSemantic.Assign)]
        NSExpression HeatmapIntensity { get; set; }

        // @property (nonatomic) MGLTransition heatmapIntensityTransition;
        [Export("heatmapIntensityTransition", ArgumentSemantic.Assign)]
        MGLTransition HeatmapIntensityTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified heatmapOpacity;
        [Export("heatmapOpacity", ArgumentSemantic.Assign)]
        NSExpression HeatmapOpacity { get; set; }

        // @property (nonatomic) MGLTransition heatmapOpacityTransition;
        [Export("heatmapOpacityTransition", ArgumentSemantic.Assign)]
        MGLTransition HeatmapOpacityTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified heatmapRadius;
        [Export("heatmapRadius", ArgumentSemantic.Assign)]
        NSExpression HeatmapRadius { get; set; }

        // @property (nonatomic) MGLTransition heatmapRadiusTransition;
        [Export("heatmapRadiusTransition", ArgumentSemantic.Assign)]
        MGLTransition HeatmapRadiusTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified heatmapWeight;
        [Export("heatmapWeight", ArgumentSemantic.Assign)]
        NSExpression HeatmapWeight { get; set; }
    }

    // @interface MGLHillshadeStyleLayer : MGLForegroundStyleLayer
    [BaseType(typeof(MGLForegroundStyleLayer))]
    interface MGLHillshadeStyleLayer
    {
        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source;
        [Export("initWithIdentifier:source:")]
        IntPtr Constructor(string identifier, MGLSource source);

        // @property (nonatomic) NSExpression * _Null_unspecified hillshadeAccentColor;
        [Export("hillshadeAccentColor", ArgumentSemantic.Assign)]
        NSExpression HillshadeAccentColor { get; set; }

        // @property (nonatomic) MGLTransition hillshadeAccentColorTransition;
        [Export("hillshadeAccentColorTransition", ArgumentSemantic.Assign)]
        MGLTransition HillshadeAccentColorTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified hillshadeExaggeration;
        [Export("hillshadeExaggeration", ArgumentSemantic.Assign)]
        NSExpression HillshadeExaggeration { get; set; }

        // @property (nonatomic) MGLTransition hillshadeExaggerationTransition;
        [Export("hillshadeExaggerationTransition", ArgumentSemantic.Assign)]
        MGLTransition HillshadeExaggerationTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified hillshadeHighlightColor;
        [Export("hillshadeHighlightColor", ArgumentSemantic.Assign)]
        NSExpression HillshadeHighlightColor { get; set; }

        // @property (nonatomic) MGLTransition hillshadeHighlightColorTransition;
        [Export("hillshadeHighlightColorTransition", ArgumentSemantic.Assign)]
        MGLTransition HillshadeHighlightColorTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified hillshadeIlluminationAnchor;
        [Export("hillshadeIlluminationAnchor", ArgumentSemantic.Assign)]
        NSExpression HillshadeIlluminationAnchor { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified hillshadeIlluminationDirection;
        [Export("hillshadeIlluminationDirection", ArgumentSemantic.Assign)]
        NSExpression HillshadeIlluminationDirection { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified hillshadeShadowColor;
        [Export("hillshadeShadowColor", ArgumentSemantic.Assign)]
        NSExpression HillshadeShadowColor { get; set; }

        // @property (nonatomic) MGLTransition hillshadeShadowColorTransition;
        [Export("hillshadeShadowColorTransition", ArgumentSemantic.Assign)]
        MGLTransition HillshadeShadowColorTransition { get; set; }
    }


    // @interface MGLHillshadeStyleLayerAdditions (NSValue)
    [Category]
    [BaseType(typeof(NSValue))]
    interface NSValue_MGLHillshadeStyleLayerAdditions
    {
        // +(instancetype _Nonnull)valueWithMGLHillshadeIlluminationAnchor:(MGLHillshadeIlluminationAnchor)hillshadeIlluminationAnchor;
        [Static]
        [Export("valueWithMGLHillshadeIlluminationAnchor:")]
        NSValue ValueWithMGLHillshadeIlluminationAnchor(MGLHillshadeIlluminationAnchor hillshadeIlluminationAnchor);

        // @property (readonly) MGLHillshadeIlluminationAnchor MGLHillshadeIlluminationAnchorValue;
        [Export("MGLHillshadeIlluminationAnchorValue")]
        MGLHillshadeIlluminationAnchor MGLHillshadeIlluminationAnchorValue();
    }

    // @interface MGLImageSource : MGLSource
    [BaseType(typeof(MGLSource))]
    interface MGLImageSource
    {
        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier coordinateQuad:(MGLCoordinateQuad)coordinateQuad URL:(NSURL * _Nonnull)url;
        [Export("initWithIdentifier:coordinateQuad:URL:")]
        IntPtr Constructor(string identifier, MGLCoordinateQuad coordinateQuad, NSUrl url);

        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier coordinateQuad:(MGLCoordinateQuad)coordinateQuad image:(UIImage * _Nonnull)image;
        [Export("initWithIdentifier:coordinateQuad:image:")]
        IntPtr Constructor(string identifier, MGLCoordinateQuad coordinateQuad, UIImage image);

        // @property (copy, nonatomic) NSURL * _Nullable URL;
        [NullAllowed, Export("URL", ArgumentSemantic.Copy)]
        NSUrl URL { get; set; }

        // @property (retain, nonatomic) UIImage * _Nullable image;
        [NullAllowed, Export("image", ArgumentSemantic.Retain)]
        UIImage Image { get; set; }

        // @property (nonatomic) MGLCoordinateQuad coordinates;
        [Export("coordinates", ArgumentSemantic.Assign)]
        MGLCoordinateQuad Coordinates { get; set; }
    }

    // @interface MGLLight : NSObject
    [BaseType(typeof(NSObject))]
    interface MGLLight
    {
        // @property (nonatomic) NSExpression * _Nonnull anchor;
        [Export("anchor", ArgumentSemantic.Assign)]
        NSExpression Anchor { get; set; }

        // @property (nonatomic) NSExpression * _Nonnull position;
        [Export("position", ArgumentSemantic.Assign)]
        NSExpression Position { get; set; }

        // @property (nonatomic) MGLTransition positionTransition;
        [Export("positionTransition", ArgumentSemantic.Assign)]
        MGLTransition PositionTransition { get; set; }

        // @property (nonatomic) NSExpression * _Nonnull color;
        [Export("color", ArgumentSemantic.Assign)]
        NSExpression Color { get; set; }

        // @property (nonatomic) MGLTransition colorTransition;
        [Export("colorTransition", ArgumentSemantic.Assign)]
        MGLTransition ColorTransition { get; set; }

        // @property (nonatomic) NSExpression * _Nonnull intensity;
        [Export("intensity", ArgumentSemantic.Assign)]
        NSExpression Intensity { get; set; }

        // @property (nonatomic) MGLTransition intensityTransition;
        [Export("intensityTransition", ArgumentSemantic.Assign)]
        MGLTransition IntensityTransition { get; set; }
    }

    // @interface MGLLineStyleLayer : MGLVectorStyleLayer
    [BaseType(typeof(MGLVectorStyleLayer))]
    interface MGLLineStyleLayer
    {
        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source;
        [Export("initWithIdentifier:source:")]
        IntPtr Constructor(string identifier, MGLSource source);

        // @property (nonatomic) NSExpression * _Null_unspecified lineCap;
        [Export("lineCap", ArgumentSemantic.Assign)]
        NSExpression LineCap { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified lineJoin;
        [Export("lineJoin", ArgumentSemantic.Assign)]
        NSExpression LineJoin { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified lineMiterLimit;
        [Export("lineMiterLimit", ArgumentSemantic.Assign)]
        NSExpression LineMiterLimit { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified lineRoundLimit;
        [Export("lineRoundLimit", ArgumentSemantic.Assign)]
        NSExpression LineRoundLimit { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified lineBlur;
        [Export("lineBlur", ArgumentSemantic.Assign)]
        NSExpression LineBlur { get; set; }

        // @property (nonatomic) MGLTransition lineBlurTransition;
        [Export("lineBlurTransition", ArgumentSemantic.Assign)]
        MGLTransition LineBlurTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified lineColor;
        [Export("lineColor", ArgumentSemantic.Assign)]
        NSExpression LineColor { get; set; }

        // @property (nonatomic) MGLTransition lineColorTransition;
        [Export("lineColorTransition", ArgumentSemantic.Assign)]
        MGLTransition LineColorTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified lineDashPattern;
        [Export("lineDashPattern", ArgumentSemantic.Assign)]
        NSExpression LineDashPattern { get; set; }

        // @property (nonatomic) MGLTransition lineDashPatternTransition;
        [Export("lineDashPatternTransition", ArgumentSemantic.Assign)]
        MGLTransition LineDashPatternTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified lineGapWidth;
        [Export("lineGapWidth", ArgumentSemantic.Assign)]
        NSExpression LineGapWidth { get; set; }

        // @property (nonatomic) MGLTransition lineGapWidthTransition;
        [Export("lineGapWidthTransition", ArgumentSemantic.Assign)]
        MGLTransition LineGapWidthTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified lineOffset;
        [Export("lineOffset", ArgumentSemantic.Assign)]
        NSExpression LineOffset { get; set; }

        // @property (nonatomic) MGLTransition lineOffsetTransition;
        [Export("lineOffsetTransition", ArgumentSemantic.Assign)]
        MGLTransition LineOffsetTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified lineOpacity;
        [Export("lineOpacity", ArgumentSemantic.Assign)]
        NSExpression LineOpacity { get; set; }

        // @property (nonatomic) MGLTransition lineOpacityTransition;
        [Export("lineOpacityTransition", ArgumentSemantic.Assign)]
        MGLTransition LineOpacityTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified linePattern;
        [Export("linePattern", ArgumentSemantic.Assign)]
        NSExpression LinePattern { get; set; }

        // @property (nonatomic) MGLTransition linePatternTransition;
        [Export("linePatternTransition", ArgumentSemantic.Assign)]
        MGLTransition LinePatternTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified lineTranslation;
        [Export("lineTranslation", ArgumentSemantic.Assign)]
        NSExpression LineTranslation { get; set; }

        // @property (nonatomic) MGLTransition lineTranslationTransition;
        [Export("lineTranslationTransition", ArgumentSemantic.Assign)]
        MGLTransition LineTranslationTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified lineTranslationAnchor;
        [Export("lineTranslationAnchor", ArgumentSemantic.Assign)]
        NSExpression LineTranslationAnchor { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified lineWidth;
        [Export("lineWidth", ArgumentSemantic.Assign)]
        NSExpression LineWidth { get; set; }

        // @property (nonatomic) MGLTransition lineWidthTransition;
        [Export("lineWidthTransition", ArgumentSemantic.Assign)]
        MGLTransition LineWidthTransition { get; set; }
    }

    // @interface MGLLineStyleLayerAdditions (NSValue)
    [Category]
    [BaseType(typeof(NSValue))]
    interface NSValue_MGLLineStyleLayerAdditions
    {
        // +(instancetype _Nonnull)valueWithMGLLineCap:(MGLLineCap)lineCap;
        [Static]
        [Export("valueWithMGLLineCap:")]
        NSValue ValueWithMGLLineCap(MGLLineCap lineCap);

        // @property (readonly) MGLLineCap MGLLineCapValue;
        [Export("MGLLineCapValue")]
        MGLLineCap MGLLineCapValue();

        // +(instancetype _Nonnull)valueWithMGLLineJoin:(MGLLineJoin)lineJoin;
        [Static]
        [Export("valueWithMGLLineJoin:")]
        NSValue ValueWithMGLLineJoin(MGLLineJoin lineJoin);

        // @property (readonly) MGLLineJoin MGLLineJoinValue;
        [Export("MGLLineJoinValue")]
        MGLLineJoin MGLLineJoinValue();

        // +(instancetype _Nonnull)valueWithMGLLineTranslationAnchor:(MGLLineTranslationAnchor)lineTranslationAnchor;
        [Static]
        [Export("valueWithMGLLineTranslationAnchor:")]
        NSValue ValueWithMGLLineTranslationAnchor(MGLLineTranslationAnchor lineTranslationAnchor);

        // @property (readonly) MGLLineTranslationAnchor MGLLineTranslationAnchorValue;
        [Export("MGLLineTranslationAnchorValue")]
        MGLLineTranslationAnchor MGLLineTranslationAnchorValue();
    }

    // @interface MGLMapCamera : NSObject <NSSecureCoding, NSCopying>
    [BaseType(typeof(NSObject))]
    interface MGLMapCamera : INSSecureCoding, INSCopying
    {
        // @property (nonatomic) CLLocationCoordinate2D centerCoordinate;
        [Export("centerCoordinate", ArgumentSemantic.Assign)]
        CLLocationCoordinate2D CenterCoordinate { get; set; }

        // @property (nonatomic) CLLocationDirection heading;
        [Export("heading")]
        double Heading { get; set; }

        // @property (nonatomic) CGFloat pitch;
        [Export("pitch")]
        nfloat Pitch { get; set; }

        // @property (nonatomic) CLLocationDistance altitude;
        [Export("altitude")]
        double Altitude { get; set; }

        // +(instancetype _Nonnull)camera;
        [Static]
        [Export("camera")]
        MGLMapCamera Camera();

        // +(instancetype _Nonnull)cameraLookingAtCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate fromEyeCoordinate:(CLLocationCoordinate2D)eyeCoordinate eyeAltitude:(CLLocationDistance)eyeAltitude;
        [Static]
        [Export("cameraLookingAtCenterCoordinate:fromEyeCoordinate:eyeAltitude:")]
        MGLMapCamera CameraLookingAtCenterCoordinate(CLLocationCoordinate2D centerCoordinate, CLLocationCoordinate2D eyeCoordinate, double eyeAltitude);

        // +(instancetype _Nonnull)cameraLookingAtCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate fromDistance:(CLLocationDistance)distance pitch:(CGFloat)pitch heading:(CLLocationDirection)heading;
        [Static]
        [Export("cameraLookingAtCenterCoordinate:fromDistance:pitch:heading:")]
        MGLMapCamera CameraLookingAtCenterCoordinate(CLLocationCoordinate2D centerCoordinate, double distance, nfloat pitch, double heading);

        // -(BOOL)isEqualToMapCamera:(MGLMapCamera * _Nonnull)otherCamera;
        [Export("isEqualToMapCamera:")]
        bool IsEqualToMapCamera(MGLMapCamera otherCamera);
    }

    // @interface MGLMapSnapshotOptions : NSObject
    [BaseType(typeof(NSObject))]
    interface MGLMapSnapshotOptions
    {
        // -(instancetype _Nonnull)initWithStyleURL:(NSURL * _Nullable)styleURL camera:(MGLMapCamera * _Nonnull)camera size:(CGSize)size;
        [Export("initWithStyleURL:camera:size:")]
        IntPtr Constructor([NullAllowed] NSUrl styleURL, MGLMapCamera camera, CGSize size);

        // @property (readonly, nonatomic) NSURL * _Nonnull styleURL;
        [Export("styleURL")]
        NSUrl StyleURL { get; }

        // @property (nonatomic) double zoomLevel;
        [Export("zoomLevel")]
        double ZoomLevel { get; set; }

        // @property (nonatomic) MGLMapCamera * _Nonnull camera;
        [Export("camera", ArgumentSemantic.Assign)]
        MGLMapCamera Camera { get; set; }

        // @property (nonatomic) MGLCoordinateBounds coordinateBounds;
        [Export("coordinateBounds", ArgumentSemantic.Assign)]
        MGLCoordinateBounds CoordinateBounds { get; set; }

        // @property (readonly, nonatomic) CGSize size;
        [Export("size")]
        CGSize Size { get; }

        // @property (nonatomic) CGFloat scale;
        [Export("scale")]
        nfloat Scale { get; set; }
    }

    // @interface MGLMapSnapshot : NSObject
    [BaseType(typeof(NSObject))]
    interface MGLMapSnapshot
    {
        // -(CGPoint)pointForCoordinate:(CLLocationCoordinate2D)coordinate;
        [Export("pointForCoordinate:")]
        CGPoint PointForCoordinate(CLLocationCoordinate2D coordinate);

        // @property (readonly, nonatomic) UIImage * _Nonnull image;
        [Export("image")]
        UIImage Image { get; }
    }

    // typedef void (^MGLMapSnapshotCompletionHandler)(MGLMapSnapshot * _Nullable, NSError * _Nullable);
    delegate void MGLMapSnapshotCompletionHandler([NullAllowed] MGLMapSnapshot arg0, [NullAllowed] NSError arg1);

    // @interface MGLMapSnapshotter : NSObject
    [BaseType(typeof(NSObject))]
    interface MGLMapSnapshotter
    {
        // -(instancetype _Nonnull)initWithOptions:(MGLMapSnapshotOptions * _Nonnull)options;
        [Export("initWithOptions:")]
        IntPtr Constructor(MGLMapSnapshotOptions options);

        // -(void)startWithCompletionHandler:(MGLMapSnapshotCompletionHandler _Nonnull)completionHandler;
        [Export("startWithCompletionHandler:")]
        void StartWithCompletionHandler(MGLMapSnapshotCompletionHandler completionHandler);

        // -(void)startWithQueue:(dispatch_queue_t _Nonnull)queue completionHandler:(MGLMapSnapshotCompletionHandler _Nonnull)completionHandler;
        [Export("startWithQueue:completionHandler:")]
        void StartWithQueue(DispatchQueue queue, MGLMapSnapshotCompletionHandler completionHandler);

        // -(void)cancel;
        [Export("cancel")]
        void Cancel();

        // @property (nonatomic) MGLMapSnapshotOptions * _Nonnull options;
        [Export("options", ArgumentSemantic.Assign)]
        MGLMapSnapshotOptions Options { get; set; }

        // @property (readonly, getter = isLoading, nonatomic) BOOL loading;
        [Export("loading")]
        bool Loading { [Bind("isLoading")] get; }
    }


    [Static]
    partial interface MGLMapViewDecelerationRate
    {
        // extern const CGFloat MGLMapViewDecelerationRateNormal __attribute__((visibility("default")));
        [Field("MGLMapViewDecelerationRateNormal", "__Internal")]
        nfloat Normal { get; }

        // extern const CGFloat MGLMapViewDecelerationRateFast __attribute__((visibility("default")));
        [Field("MGLMapViewDecelerationRateFast", "__Internal")]
        nfloat Fast { get; }

        // extern const CGFloat MGLMapViewDecelerationRateImmediate __attribute__((visibility("default")));
        [Field("MGLMapViewDecelerationRateImmediate", "__Internal")]
        nfloat Immediate { get; }
    }

    // @interface MGLMapView : UIView
    [BaseType(typeof(UIView))]
    interface MGLMapView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame;
        [Export("initWithFrame:")]
        IntPtr Constructor(CGRect frame);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame styleURL:(NSURL * _Nullable)styleURL;
        [Export("initWithFrame:styleURL:")]
        IntPtr Constructor(CGRect frame, [NullAllowed] NSUrl styleURL);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MGLMapViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MGLMapViewDelegate> _Nullable delegate __attribute__((iboutlet));
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic) MGLStyle * _Nullable style;
        [NullAllowed, Export("style")]
        MGLStyle Style { get; }

        // @property (nonatomic) NSURL * _Null_unspecified styleURL;
        [Export("styleURL", ArgumentSemantic.Assign)]
        NSUrl StyleURL { get; set; }

        // -(void)reloadStyle:(id _Nullable)sender __attribute__((ibaction));
        [Export("reloadStyle:")]
        void ReloadStyle([NullAllowed] NSObject sender);

        // @property (assign, nonatomic) BOOL showsScale;
        [Export("showsScale")]
        bool ShowsScale { get; set; }

        // @property (readonly, nonatomic) UIView * _Nonnull scaleBar;
        [Export("scaleBar")]
        UIView ScaleBar { get; }

        // @property (readonly, nonatomic) UIImageView * _Nonnull compassView;
        [Export("compassView")]
        UIImageView CompassView { get; }

        // @property (readonly, nonatomic) UIImageView * _Nonnull logoView;
        [Export("logoView")]
        UIImageView LogoView { get; }

        // @property (readonly, nonatomic) UIButton * _Nonnull attributionButton;
        [Export("attributionButton")]
        UIButton AttributionButton { get; }

        // -(void)showAttribution:(id _Nonnull)sender __attribute__((ibaction));
        [Export("showAttribution:")]
        void ShowAttribution(NSObject sender);

        // @property (assign, nonatomic) BOOL showsUserLocation;
        [Export("showsUserLocation")]
        bool ShowsUserLocation { get; set; }

        // @property (readonly, getter = isUserLocationVisible, assign, nonatomic) BOOL userLocationVisible;
        [Export("userLocationVisible")]
        bool UserLocationVisible { [Bind("isUserLocationVisible")] get; }

        // @property (readonly, nonatomic) MGLUserLocation * _Nullable userLocation;
        [NullAllowed, Export("userLocation")]
        MGLUserLocation UserLocation { get; }

        // @property (assign, nonatomic) MGLUserTrackingMode userTrackingMode;
        [Export("userTrackingMode", ArgumentSemantic.Assign)]
        MGLUserTrackingMode UserTrackingMode { get; set; }

        // -(void)setUserTrackingMode:(MGLUserTrackingMode)mode animated:(BOOL)animated;
        [Export("setUserTrackingMode:animated:")]
        void SetUserTrackingMode(MGLUserTrackingMode mode, bool animated);

        // @property (assign, nonatomic) MGLAnnotationVerticalAlignment userLocationVerticalAlignment;
        [Export("userLocationVerticalAlignment", ArgumentSemantic.Assign)]
        MGLAnnotationVerticalAlignment UserLocationVerticalAlignment { get; set; }

        // -(void)setUserLocationVerticalAlignment:(MGLAnnotationVerticalAlignment)alignment animated:(BOOL)animated;
        [Export("setUserLocationVerticalAlignment:animated:")]
        void SetUserLocationVerticalAlignment(MGLAnnotationVerticalAlignment alignment, bool animated);

        // @property (assign, nonatomic) BOOL showsUserHeadingIndicator;
        [Export("showsUserHeadingIndicator")]
        bool ShowsUserHeadingIndicator { get; set; }

        // @property (assign, nonatomic) BOOL displayHeadingCalibration;
        [Export("displayHeadingCalibration")]
        bool DisplayHeadingCalibration { get; set; }

        // @property (assign, nonatomic) CLLocationCoordinate2D targetCoordinate;
        [Export("targetCoordinate", ArgumentSemantic.Assign)]
        CLLocationCoordinate2D TargetCoordinate { get; set; }

        // -(void)setTargetCoordinate:(CLLocationCoordinate2D)targetCoordinate animated:(BOOL)animated;
        [Export("setTargetCoordinate:animated:")]
        void SetTargetCoordinate(CLLocationCoordinate2D targetCoordinate, bool animated);

        // @property (getter = isZoomEnabled, nonatomic) BOOL zoomEnabled;
        [Export("zoomEnabled")]
        bool ZoomEnabled { [Bind("isZoomEnabled")] get; set; }

        // @property (getter = isScrollEnabled, nonatomic) BOOL scrollEnabled;
        [Export("scrollEnabled")]
        bool ScrollEnabled { [Bind("isScrollEnabled")] get; set; }

        // @property (getter = isRotateEnabled, nonatomic) BOOL rotateEnabled;
        [Export("rotateEnabled")]
        bool RotateEnabled { [Bind("isRotateEnabled")] get; set; }

        // @property (getter = isPitchEnabled, nonatomic) BOOL pitchEnabled;
        [Export("pitchEnabled")]
        bool PitchEnabled { [Bind("isPitchEnabled")] get; set; }

        // @property (getter = isHapticFeedbackEnabled, nonatomic) BOOL hapticFeedbackEnabled;
        [Export("hapticFeedbackEnabled")]
        bool HapticFeedbackEnabled { [Bind("isHapticFeedbackEnabled")] get; set; }

        // @property (nonatomic) CGFloat decelerationRate;
        [Export("decelerationRate")]
        nfloat DecelerationRate { get; set; }

        // @property (nonatomic) CLLocationCoordinate2D centerCoordinate;
        [Export("centerCoordinate", ArgumentSemantic.Assign)]
        CLLocationCoordinate2D CenterCoordinate { get; set; }

        // -(void)setCenterCoordinate:(CLLocationCoordinate2D)coordinate animated:(BOOL)animated;
        [Export("setCenterCoordinate:animated:")]
        void SetCenterCoordinate(CLLocationCoordinate2D coordinate, bool animated);

        // -(void)setCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate zoomLevel:(double)zoomLevel animated:(BOOL)animated;
        [Export("setCenterCoordinate:zoomLevel:animated:")]
        void SetCenterCoordinate(CLLocationCoordinate2D centerCoordinate, double zoomLevel, bool animated);

        // -(void)setCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate zoomLevel:(double)zoomLevel direction:(CLLocationDirection)direction animated:(BOOL)animated;
        [Export("setCenterCoordinate:zoomLevel:direction:animated:")]
        void SetCenterCoordinate(CLLocationCoordinate2D centerCoordinate, double zoomLevel, double direction, bool animated);

        // -(void)setCenterCoordinate:(CLLocationCoordinate2D)centerCoordinate zoomLevel:(double)zoomLevel direction:(CLLocationDirection)direction animated:(BOOL)animated completionHandler:(void (^ _Nullable)(void))completion;
        [Export("setCenterCoordinate:zoomLevel:direction:animated:completionHandler:")]
        void SetCenterCoordinate(CLLocationCoordinate2D centerCoordinate, double zoomLevel, double direction, bool animated, [NullAllowed] Action completion);

        // @property (nonatomic) double zoomLevel;
        [Export("zoomLevel")]
        double ZoomLevel { get; set; }

        // -(void)setZoomLevel:(double)zoomLevel animated:(BOOL)animated;
        [Export("setZoomLevel:animated:")]
        void SetZoomLevel(double zoomLevel, bool animated);

        // @property (nonatomic) double minimumZoomLevel;
        [Export("minimumZoomLevel")]
        double MinimumZoomLevel { get; set; }

        // @property (nonatomic) double maximumZoomLevel;
        [Export("maximumZoomLevel")]
        double MaximumZoomLevel { get; set; }

        // @property (nonatomic) CLLocationDirection direction;
        [Export("direction")]
        double Direction { get; set; }

        // -(void)setDirection:(CLLocationDirection)direction animated:(BOOL)animated;
        [Export("setDirection:animated:")]
        void SetDirection(double direction, bool animated);

        // -(void)resetNorth __attribute__((ibaction));
        [Export("resetNorth")]
        void ResetNorth();

        // -(void)resetPosition __attribute__((ibaction));
        [Export("resetPosition")]
        void ResetPosition();

        // @property (nonatomic) MGLCoordinateBounds visibleCoordinateBounds;
        [Export("visibleCoordinateBounds", ArgumentSemantic.Assign)]
        MGLCoordinateBounds VisibleCoordinateBounds { get; set; }

        // -(void)setVisibleCoordinateBounds:(MGLCoordinateBounds)bounds animated:(BOOL)animated;
        [Export("setVisibleCoordinateBounds:animated:")]
        void SetVisibleCoordinateBounds(MGLCoordinateBounds bounds, bool animated);

        // -(void)setVisibleCoordinateBounds:(MGLCoordinateBounds)bounds edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
        [Export("setVisibleCoordinateBounds:edgePadding:animated:")]
        void SetVisibleCoordinateBounds(MGLCoordinateBounds bounds, UIEdgeInsets insets, bool animated);

        // -(void)setVisibleCoordinates:(const CLLocationCoordinate2D * _Nonnull)coordinates count:(NSUInteger)count edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
        [Export("setVisibleCoordinates:count:edgePadding:animated:")]
        unsafe void SetVisibleCoordinates(ref CLLocationCoordinate2D coordinates, nuint count, UIEdgeInsets insets, bool animated);

        // -(void)setVisibleCoordinates:(const CLLocationCoordinate2D * _Nonnull)coordinates count:(NSUInteger)count edgePadding:(UIEdgeInsets)insets direction:(CLLocationDirection)direction duration:(NSTimeInterval)duration animationTimingFunction:(CAMediaTimingFunction * _Nullable)function completionHandler:(void (^ _Nullable)(void))completion;
        [Export("setVisibleCoordinates:count:edgePadding:direction:duration:animationTimingFunction:completionHandler:")]
        unsafe void SetVisibleCoordinates(ref CLLocationCoordinate2D coordinates, nuint count, UIEdgeInsets insets, double direction, double duration, [NullAllowed] CAMediaTimingFunction function, [NullAllowed] Action completion);

        // -(void)showAnnotations:(NSArray<id<MGLAnnotation>> * _Nonnull)annotations animated:(BOOL)animated;
        [Export("showAnnotations:animated:")]
        void ShowAnnotations(IMGLAnnotation[] annotations, bool animated);

        // -(void)showAnnotations:(NSArray<id<MGLAnnotation>> * _Nonnull)annotations edgePadding:(UIEdgeInsets)insets animated:(BOOL)animated;
        [Export("showAnnotations:edgePadding:animated:")]
        void ShowAnnotations(IMGLAnnotation[] annotations, UIEdgeInsets insets, bool animated);

        // @property (copy, nonatomic) MGLMapCamera * _Nonnull camera;
        [Export("camera", ArgumentSemantic.Copy)]
        MGLMapCamera Camera { get; set; }

        // -(void)setCamera:(MGLMapCamera * _Nonnull)camera animated:(BOOL)animated;
        [Export("setCamera:animated:")]
        void SetCamera(MGLMapCamera camera, bool animated);

        // -(void)setCamera:(MGLMapCamera * _Nonnull)camera withDuration:(NSTimeInterval)duration animationTimingFunction:(CAMediaTimingFunction * _Nullable)function;
        [Export("setCamera:withDuration:animationTimingFunction:")]
        void SetCamera(MGLMapCamera camera, double duration, [NullAllowed] CAMediaTimingFunction function);

        // -(void)setCamera:(MGLMapCamera * _Nonnull)camera withDuration:(NSTimeInterval)duration animationTimingFunction:(CAMediaTimingFunction * _Nullable)function completionHandler:(void (^ _Nullable)(void))completion;
        [Export("setCamera:withDuration:animationTimingFunction:completionHandler:")]
        void SetCamera(MGLMapCamera camera, double duration, [NullAllowed] CAMediaTimingFunction function, [NullAllowed] Action completion);

        // -(void)setCamera:(MGLMapCamera * _Nonnull)camera withDuration:(NSTimeInterval)duration animationTimingFunction:(CAMediaTimingFunction * _Nullable)function edgePadding:(UIEdgeInsets)edgePadding completionHandler:(void (^ _Nullable)(void))completion;
        [Export("setCamera:withDuration:animationTimingFunction:edgePadding:completionHandler:")]
        void SetCamera(MGLMapCamera camera, double duration, [NullAllowed] CAMediaTimingFunction function, UIEdgeInsets edgePadding, [NullAllowed] Action completion);

        // -(void)flyToCamera:(MGLMapCamera * _Nonnull)camera completionHandler:(void (^ _Nullable)(void))completion;
        [Export("flyToCamera:completionHandler:")]
        void FlyToCamera(MGLMapCamera camera, [NullAllowed] Action completion);

        // -(void)flyToCamera:(MGLMapCamera * _Nonnull)camera withDuration:(NSTimeInterval)duration completionHandler:(void (^ _Nullable)(void))completion;
        [Export("flyToCamera:withDuration:completionHandler:")]
        void FlyToCamera(MGLMapCamera camera, double duration, [NullAllowed] Action completion);

        // -(void)flyToCamera:(MGLMapCamera * _Nonnull)camera withDuration:(NSTimeInterval)duration peakAltitude:(CLLocationDistance)peakAltitude completionHandler:(void (^ _Nullable)(void))completion;
        [Export("flyToCamera:withDuration:peakAltitude:completionHandler:")]
        void FlyToCamera(MGLMapCamera camera, double duration, double peakAltitude, [NullAllowed] Action completion);

        // -(MGLMapCamera * _Nonnull)cameraThatFitsCoordinateBounds:(MGLCoordinateBounds)bounds;
        [Export("cameraThatFitsCoordinateBounds:")]
        MGLMapCamera CameraThatFitsCoordinateBounds(MGLCoordinateBounds bounds);

        // -(MGLMapCamera * _Nonnull)cameraThatFitsCoordinateBounds:(MGLCoordinateBounds)bounds edgePadding:(UIEdgeInsets)insets;
        [Export("cameraThatFitsCoordinateBounds:edgePadding:")]
        MGLMapCamera CameraThatFitsCoordinateBounds(MGLCoordinateBounds bounds, UIEdgeInsets insets);

        // -(MGLMapCamera * _Nonnull)cameraThatFitsShape:(MGLShape * _Nonnull)shape direction:(CLLocationDirection)direction edgePadding:(UIEdgeInsets)insets;
        [Export("cameraThatFitsShape:direction:edgePadding:")]
        MGLMapCamera CameraThatFitsShape(MGLShape shape, double direction, UIEdgeInsets insets);

        // -(CGPoint)anchorPointForGesture:(UIGestureRecognizer * _Nonnull)gesture;
        [Export("anchorPointForGesture:")]
        CGPoint AnchorPointForGesture(UIGestureRecognizer gesture);

        // @property (assign, nonatomic) UIEdgeInsets contentInset;
        [Export("contentInset", ArgumentSemantic.Assign)]
        UIEdgeInsets ContentInset { get; set; }

        // -(void)setContentInset:(UIEdgeInsets)contentInset animated:(BOOL)animated;
        [Export("setContentInset:animated:")]
        void SetContentInset(UIEdgeInsets contentInset, bool animated);

        // -(CLLocationCoordinate2D)convertPoint:(CGPoint)point toCoordinateFromView:(UIView * _Nullable)view;
        [Export("convertPoint:toCoordinateFromView:")]
        CLLocationCoordinate2D ConvertPoint(CGPoint point, [NullAllowed] UIView view);

        // -(CGPoint)convertCoordinate:(CLLocationCoordinate2D)coordinate toPointToView:(UIView * _Nullable)view;
        [Export("convertCoordinate:toPointToView:")]
        CGPoint ConvertCoordinate(CLLocationCoordinate2D coordinate, [NullAllowed] UIView view);

        // -(MGLCoordinateBounds)convertRect:(CGRect)rect toCoordinateBoundsFromView:(UIView * _Nullable)view;
        [Export("convertRect:toCoordinateBoundsFromView:")]
        MGLCoordinateBounds ConvertRect(CGRect rect, [NullAllowed] UIView view);

        // -(CGRect)convertCoordinateBounds:(MGLCoordinateBounds)bounds toRectToView:(UIView * _Nullable)view;
        [Export("convertCoordinateBounds:toRectToView:")]
        CGRect ConvertCoordinateBounds(MGLCoordinateBounds bounds, [NullAllowed] UIView view);

        // -(CLLocationDistance)metersPerPointAtLatitude:(CLLocationDegrees)latitude;
        [Export("metersPerPointAtLatitude:")]
        double MetersPerPointAtLatitude(double latitude);

        // @property (readonly, nonatomic) NSArray<id<MGLAnnotation>> * _Nullable annotations;
        [NullAllowed, Export("annotations")]
        MGLAnnotation[] Annotations { get; }

        // -(void)addAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
        [Export("addAnnotation:")]
        void AddAnnotation(IMGLAnnotation annotation);

        // -(void)addAnnotations:(NSArray<id<MGLAnnotation>> * _Nonnull)annotations;
        [Export("addAnnotations:")]
        void AddAnnotations(IMGLAnnotation[] annotations);

        // -(void)removeAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
        [Export("removeAnnotation:")]
        void RemoveAnnotation(IMGLAnnotation annotation);

        // -(void)removeAnnotations:(NSArray<id<MGLAnnotation>> * _Nonnull)annotations;
        [Export("removeAnnotations:")]
        void RemoveAnnotations(IMGLAnnotation[] annotations);

        // -(MGLAnnotationView * _Nullable)viewForAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
        [Export("viewForAnnotation:")]
        [return: NullAllowed]
        MGLAnnotationView ViewForAnnotation(IMGLAnnotation annotation);

        // -(__kindof MGLAnnotationImage * _Nullable)dequeueReusableAnnotationImageWithIdentifier:(NSString * _Nonnull)identifier;
        [Export("dequeueReusableAnnotationImageWithIdentifier:")]
        MGLAnnotationImage DequeueReusableAnnotationImageWithIdentifier(string identifier);

        // -(__kindof MGLAnnotationView * _Nullable)dequeueReusableAnnotationViewWithIdentifier:(NSString * _Nonnull)identifier;
        [Export("dequeueReusableAnnotationViewWithIdentifier:")]
        MGLAnnotationView DequeueReusableAnnotationViewWithIdentifier(string identifier);

        // @property (readonly, nonatomic) NSArray<id<MGLAnnotation>> * _Nullable visibleAnnotations;
        [NullAllowed, Export("visibleAnnotations")]
        MGLAnnotation[] VisibleAnnotations { get; }

        // -(NSArray<id<MGLAnnotation>> * _Nullable)visibleAnnotationsInRect:(CGRect)rect;
        [Export("visibleAnnotationsInRect:")]
        [return: NullAllowed]
        MGLAnnotation[] VisibleAnnotationsInRect(CGRect rect);

        // @property (copy, nonatomic) NSArray<id<MGLAnnotation>> * _Nonnull selectedAnnotations;
        [Export("selectedAnnotations", ArgumentSemantic.Copy)]
        MGLAnnotation[] SelectedAnnotations { get; set; }

        // -(void)selectAnnotation:(id<MGLAnnotation> _Nonnull)annotation animated:(BOOL)animated;
        [Export("selectAnnotation:animated:")]
        void SelectAnnotation(IMGLAnnotation annotation, bool animated);

        // -(void)deselectAnnotation:(id<MGLAnnotation> _Nullable)annotation animated:(BOOL)animated;
        [Export("deselectAnnotation:animated:")]
        void DeselectAnnotation([NullAllowed] IMGLAnnotation annotation, bool animated);

        // @property (readonly, nonatomic) NSArray<id<MGLOverlay>> * _Nonnull overlays;
        [Export("overlays")]
        NSObject[] Overlays { get; }

        // -(void)addOverlay:(id<MGLOverlay> _Nonnull)overlay;
        [Export("addOverlay:")]
        void AddOverlay(IMGLOverlay overlay);

        // -(void)addOverlays:(NSArray<id<MGLOverlay>> * _Nonnull)overlays;
        [Export("addOverlays:")]
        void AddOverlays(IMGLOverlay[] overlays);

        // -(void)removeOverlay:(id<MGLOverlay> _Nonnull)overlay;
        [Export("removeOverlay:")]
        void RemoveOverlay(IMGLOverlay overlay);

        // -(void)removeOverlays:(NSArray<id<MGLOverlay>> * _Nonnull)overlays;
        [Export("removeOverlays:")]
        void RemoveOverlays(IMGLOverlay[] overlays);

        // -(NSArray<id<MGLFeature>> * _Nonnull)visibleFeaturesAtPoint:(CGPoint)point;
        [Export("visibleFeaturesAtPoint:")]
        NSObject[] VisibleFeaturesAtPoint(CGPoint point);

        // -(NSArray<id<MGLFeature>> * _Nonnull)visibleFeaturesAtPoint:(CGPoint)point inStyleLayersWithIdentifiers:(NSSet<NSString *> * _Nullable)styleLayerIdentifiers;
        [Export("visibleFeaturesAtPoint:inStyleLayersWithIdentifiers:")]
        NSObject[] VisibleFeaturesAtPoint(CGPoint point, [NullAllowed] NSSet<NSString> styleLayerIdentifiers);

        // -(NSArray<id<MGLFeature>> * _Nonnull)visibleFeaturesAtPoint:(CGPoint)point inStyleLayersWithIdentifiers:(NSSet<NSString *> * _Nullable)styleLayerIdentifiers predicate:(NSPredicate * _Nullable)predicate;
        [Export("visibleFeaturesAtPoint:inStyleLayersWithIdentifiers:predicate:")]
        NSObject[] VisibleFeaturesAtPoint(CGPoint point, [NullAllowed] NSSet<NSString> styleLayerIdentifiers, [NullAllowed] NSPredicate predicate);

        // -(NSArray<id<MGLFeature>> * _Nonnull)visibleFeaturesInRect:(CGRect)rect;
        [Export("visibleFeaturesInRect:")]
        NSObject[] VisibleFeaturesInRect(CGRect rect);

        // -(NSArray<id<MGLFeature>> * _Nonnull)visibleFeaturesInRect:(CGRect)rect inStyleLayersWithIdentifiers:(NSSet<NSString *> * _Nullable)styleLayerIdentifiers;
        [Export("visibleFeaturesInRect:inStyleLayersWithIdentifiers:")]
        NSObject[] VisibleFeaturesInRect(CGRect rect, [NullAllowed] NSSet<NSString> styleLayerIdentifiers);

        // -(NSArray<id<MGLFeature>> * _Nonnull)visibleFeaturesInRect:(CGRect)rect inStyleLayersWithIdentifiers:(NSSet<NSString *> * _Nullable)styleLayerIdentifiers predicate:(NSPredicate * _Nullable)predicate;
        [Export("visibleFeaturesInRect:inStyleLayersWithIdentifiers:predicate:")]
        NSObject[] VisibleFeaturesInRect(CGRect rect, [NullAllowed] NSSet<NSString> styleLayerIdentifiers, [NullAllowed] NSPredicate predicate);

        // @property (nonatomic) MGLMapDebugMaskOptions debugMask;
        [Export("debugMask", ArgumentSemantic.Assign)]
        MGLMapDebugMaskOptions DebugMask { get; set; }
    }

    // @protocol MGLMapViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MGLMapViewDelegate
    {
        // @optional -(BOOL)mapView:(MGLMapView * _Nonnull)mapView shouldChangeFromCamera:(MGLMapCamera * _Nonnull)oldCamera toCamera:(MGLMapCamera * _Nonnull)newCamera;
        [Export("mapView:shouldChangeFromCamera:toCamera:")]
        bool MapViewShouldChangeCamera(MGLMapView mapView, MGLMapCamera oldCamera, MGLMapCamera newCamera);

        // @optional -(BOOL)mapView:(MGLMapView * _Nonnull)mapView shouldChangeFromCamera:(MGLMapCamera * _Nonnull)oldCamera toCamera:(MGLMapCamera * _Nonnull)newCamera reason:(MGLCameraChangeReason)reason;
        [Export("mapView:shouldChangeFromCamera:toCamera:reason:")]
        bool MapViewShouldChangeCameraWithReason(MGLMapView mapView, MGLMapCamera oldCamera, MGLMapCamera newCamera, MGLCameraChangeReason reason);

        // @optional -(void)mapView:(MGLMapView * _Nonnull)mapView regionWillChangeAnimated:(BOOL)animated;
        [Export("mapView:regionWillChangeAnimated:")]
        void MapViewRegionWillChange(MGLMapView mapView, bool animated);

        // @optional -(void)mapView:(MGLMapView * _Nonnull)mapView regionWillChangeWithReason:(MGLCameraChangeReason)reason animated:(BOOL)animated;
        [Export("mapView:regionWillChangeWithReason:animated:")]
        void MapViewRegionWillChangeWithReason(MGLMapView mapView, MGLCameraChangeReason reason, bool animated);

        // @optional -(void)mapViewRegionIsChanging:(MGLMapView * _Nonnull)mapView;
        [Export("mapViewRegionIsChanging:")]
        void MapViewRegionIsChanging(MGLMapView mapView);

        // @optional -(void)mapView:(MGLMapView * _Nonnull)mapView regionIsChangingWithReason:(MGLCameraChangeReason)reason;
        [Export("mapView:regionIsChangingWithReason:")]
        void MapViewRegionIsChangingWithReason(MGLMapView mapView, MGLCameraChangeReason reason);

        // @optional -(void)mapView:(MGLMapView * _Nonnull)mapView regionDidChangeAnimated:(BOOL)animated;
        [Export("mapView:regionDidChangeAnimated:")]
        void MapViewRegionDidChange(MGLMapView mapView, bool animated);

        // @optional -(void)mapView:(MGLMapView * _Nonnull)mapView regionDidChangeWithReason:(MGLCameraChangeReason)reason animated:(BOOL)animated;
        [Export("mapView:regionDidChangeWithReason:animated:")]
        void MapViewRegionDidChangeWithReason(MGLMapView mapView, MGLCameraChangeReason reason, bool animated);

        // @optional -(void)mapViewWillStartLoadingMap:(MGLMapView * _Nonnull)mapView;
        [Export("mapViewWillStartLoadingMap:")]
        void MapViewWillStartLoadingMap(MGLMapView mapView);

        // @optional -(void)mapViewDidFinishLoadingMap:(MGLMapView * _Nonnull)mapView;
        [Export("mapViewDidFinishLoadingMap:")]
        void MapViewDidFinishLoadingMap(MGLMapView mapView);

        // @optional -(void)mapViewDidFailLoadingMap:(MGLMapView * _Nonnull)mapView withError:(NSError * _Nonnull)error;
        [Export("mapViewDidFailLoadingMap:withError:")]
        void MapViewDidFailLoadingMap(MGLMapView mapView, NSError error);

        // @optional -(void)mapViewWillStartRenderingMap:(MGLMapView * _Nonnull)mapView;
        [Export("mapViewWillStartRenderingMap:")]
        void MapViewWillStartRenderingMap(MGLMapView mapView);

        // @optional -(void)mapViewDidFinishRenderingMap:(MGLMapView * _Nonnull)mapView fullyRendered:(BOOL)fullyRendered;
        [Export("mapViewDidFinishRenderingMap:fullyRendered:")]
        void MapViewDidFinishRenderingMap(MGLMapView mapView, bool fullyRendered);

        // @optional -(void)mapViewWillStartRenderingFrame:(MGLMapView * _Nonnull)mapView;
        [Export("mapViewWillStartRenderingFrame:")]
        void MapViewWillStartRenderingFrame(MGLMapView mapView);

        // @optional -(void)mapViewDidFinishRenderingFrame:(MGLMapView * _Nonnull)mapView fullyRendered:(BOOL)fullyRendered;
        [Export("mapViewDidFinishRenderingFrame:fullyRendered:")]
        void MapViewDidFinishRenderingFrame(MGLMapView mapView, bool fullyRendered);

        // @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didFinishLoadingStyle:(MGLStyle * _Nonnull)style;
        [Export("mapView:didFinishLoadingStyle:")]
        void MapViewDidFinishLoadingStyle(MGLMapView mapView, MGLStyle style);

        // @optional -(void)mapViewWillStartLocatingUser:(MGLMapView * _Nonnull)mapView;
        [Export("mapViewWillStartLocatingUser:")]
        void MapViewWillStartLocatingUser(MGLMapView mapView);

        // @optional -(void)mapViewDidStopLocatingUser:(MGLMapView * _Nonnull)mapView;
        [Export("mapViewDidStopLocatingUser:")]
        void MapViewDidStopLocatingUser(MGLMapView mapView);

        // @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didUpdateUserLocation:(MGLUserLocation * _Nullable)userLocation;
        [Export("mapView:didUpdateUserLocation:")]
        void MapViewDidUpdateUserLocation(MGLMapView mapView, [NullAllowed] MGLUserLocation userLocation);

        // @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didFailToLocateUserWithError:(NSError * _Nonnull)error;
        [Export("mapView:didFailToLocateUserWithError:")]
        void MapViewDidFailToLocateUser(MGLMapView mapView, NSError error);

        // @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didChangeUserTrackingMode:(MGLUserTrackingMode)mode animated:(BOOL)animated;
        [Export("mapView:didChangeUserTrackingMode:animated:")]
        void MapViewDidChangeUserTrackingMode(MGLMapView mapView, MGLUserTrackingMode mode, bool animated);

        // @optional -(MGLAnnotationImage * _Nullable)mapView:(MGLMapView * _Nonnull)mapView imageForAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
        [Export("mapView:imageForAnnotation:")]
        [return: NullAllowed]
        MGLAnnotationImage MapView_ImageForAnnotation(MGLMapView mapView, IMGLAnnotation annotation);

        // @optional -(CGFloat)mapView:(MGLMapView * _Nonnull)mapView alphaForShapeAnnotation:(MGLShape * _Nonnull)annotation;
        [Export("mapView:alphaForShapeAnnotation:")]
        nfloat MapView_AlphaForShapeAnnotation(MGLMapView mapView, MGLShape annotation);

        // @optional -(UIColor * _Nonnull)mapView:(MGLMapView * _Nonnull)mapView strokeColorForShapeAnnotation:(MGLShape * _Nonnull)annotation;
        [Export("mapView:strokeColorForShapeAnnotation:")]
        UIColor MapView_StrokeColorForShapeAnnotation(MGLMapView mapView, MGLShape annotation);

        // @optional -(UIColor * _Nonnull)mapView:(MGLMapView * _Nonnull)mapView fillColorForPolygonAnnotation:(MGLPolygon * _Nonnull)annotation;
        [Export("mapView:fillColorForPolygonAnnotation:")]
        UIColor MapView_FillColorForPolygonAnnotation(MGLMapView mapView, MGLPolygon annotation);

        // @optional -(CGFloat)mapView:(MGLMapView * _Nonnull)mapView lineWidthForPolylineAnnotation:(MGLPolyline * _Nonnull)annotation;
        [Export("mapView:lineWidthForPolylineAnnotation:")]
        nfloat MapView_LineWidthForPolylineAnnotation(MGLMapView mapView, MGLPolyline annotation);

        // @optional -(MGLAnnotationView * _Nullable)mapView:(MGLMapView * _Nonnull)mapView viewForAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
        [Export("mapView:viewForAnnotation:")]
        [return: NullAllowed]
        MGLAnnotationView MapView_ViewForAnnotation(MGLMapView mapView, IMGLAnnotation annotation);

        // @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didAddAnnotationViews:(NSArray<MGLAnnotationView *> * _Nonnull)annotationViews;
        [Export("mapView:didAddAnnotationViews:")]
        void MapViewDidAddAnnotationViews(MGLMapView mapView, MGLAnnotationView[] annotationViews);

        // @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didSelectAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
        [Export("mapView:didSelectAnnotation:")]
        void MapViewDidSelectAnnotation(MGLMapView mapView, IMGLAnnotation annotation);

        // @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didDeselectAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
        [Export("mapView:didDeselectAnnotation:")]
        void MapViewDidDeselectAnnotation(MGLMapView mapView, IMGLAnnotation annotation);

        // @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didSelectAnnotationView:(MGLAnnotationView * _Nonnull)annotationView;
        [Export("mapView:didSelectAnnotationView:")]
        void MapViewDidSelectAnnotationView(MGLMapView mapView, MGLAnnotationView annotationView);

        // @optional -(void)mapView:(MGLMapView * _Nonnull)mapView didDeselectAnnotationView:(MGLAnnotationView * _Nonnull)annotationView;
        [Export("mapView:didDeselectAnnotationView:")]
        void MapViewDidDeselectAnnotationView(MGLMapView mapView, MGLAnnotationView annotationView);

        // @optional -(BOOL)mapView:(MGLMapView * _Nonnull)mapView annotationCanShowCallout:(id<MGLAnnotation> _Nonnull)annotation;
        [Export("mapView:annotationCanShowCallout:")]
        bool MapView_AnnotationCanShowCallout(MGLMapView mapView, IMGLAnnotation annotation);

        // @optional -(id<MGLCalloutView> _Nullable)mapView:(MGLMapView * _Nonnull)mapView calloutViewForAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
        [Export("mapView:calloutViewForAnnotation:")]
        [return: NullAllowed]
        MGLCalloutView MapView_CalloutViewForAnnotation(MGLMapView mapView, IMGLAnnotation annotation);

        // @optional -(UIView * _Nullable)mapView:(MGLMapView * _Nonnull)mapView leftCalloutAccessoryViewForAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
        [Export("mapView:leftCalloutAccessoryViewForAnnotation:")]
        [return: NullAllowed]
        UIView MapView_LeftCalloutAccessoryViewForAnnotation(MGLMapView mapView, IMGLAnnotation annotation);

        // @optional -(UIView * _Nullable)mapView:(MGLMapView * _Nonnull)mapView rightCalloutAccessoryViewForAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
        [Export("mapView:rightCalloutAccessoryViewForAnnotation:")]
        [return: NullAllowed]
        UIView MapView_RightCalloutAccessoryViewForAnnotation(MGLMapView mapView, IMGLAnnotation annotation);

        // @optional -(void)mapView:(MGLMapView * _Nonnull)mapView annotation:(id<MGLAnnotation> _Nonnull)annotation calloutAccessoryControlTapped:(UIControl * _Nonnull)control;
        [Export("mapView:annotation:calloutAccessoryControlTapped:")]
        void MapView_CalloutAccessoryControlTapped(MGLMapView mapView, IMGLAnnotation annotation, UIControl control);

        // @optional -(void)mapView:(MGLMapView * _Nonnull)mapView tapOnCalloutForAnnotation:(id<MGLAnnotation> _Nonnull)annotation;
        [Export("mapView:tapOnCalloutForAnnotation:")]
        void MapView_TapOnCalloutForAnnotation(MGLMapView mapView, IMGLAnnotation annotation);
    }

    // @protocol MGLOfflineRegion <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MGLOfflineRegion
    {
    }

    // @interface MGLOfflinePack : NSObject
    [BaseType(typeof(NSObject))]
    interface MGLOfflinePack
    {
        // @property (readonly, nonatomic) id<MGLOfflineRegion> _Nonnull region;
        [Export("region")]
        MGLOfflineRegion Region { get; }

        // @property (readonly, nonatomic) NSData * _Nonnull context;
        [Export("context")]
        NSData Context { get; }

        // @property (readonly, nonatomic) MGLOfflinePackState state;
        [Export("state")]
        MGLOfflinePackState State { get; }

        // @property (readonly, nonatomic) MGLOfflinePackProgress progress;
        [Export("progress")]
        MGLOfflinePackProgress Progress { get; }

        // -(void)resume;
        [Export("resume")]
        void Resume();

        // -(void)suspend;
        [Export("suspend")]
        void Suspend();

        // -(void)requestProgress;
        [Export("requestProgress")]
        void RequestProgress();
    }

    [Static]
    partial interface MGLOfflinePackKeys
    {
        // extern const NSNotificationName _Nonnull MGLOfflinePackProgressChangedNotification __attribute__((visibility("default")));
        [Field("MGLOfflinePackProgressChangedNotification", "__Internal")]
        NSString ProgressChangedNotification { get; }

        // extern const NSNotificationName _Nonnull MGLOfflinePackErrorNotification __attribute__((visibility("default")));
        [Field("MGLOfflinePackErrorNotification", "__Internal")]
        NSString ErrorNotification { get; }

        // extern const NSNotificationName _Nonnull MGLOfflinePackMaximumMapboxTilesReachedNotification __attribute__((visibility("default")));
        [Field("MGLOfflinePackMaximumMapboxTilesReachedNotification", "__Internal")]
        NSString MaximumMapboxTilesReachedNotification { get; }

        // extern const MGLOfflinePackUserInfoKey _Nonnull MGLOfflinePackUserInfoKeyState __attribute__((visibility("default")));
        [Field("MGLOfflinePackUserInfoKeyState", "__Internal")]
        NSString UserInfoKeyState { get; }

        // extern const MGLOfflinePackUserInfoKey _Nonnull MGLOfflinePackUserInfoKeyProgress __attribute__((visibility("default")));
        [Field("MGLOfflinePackUserInfoKeyProgress", "__Internal")]
        NSString UserInfoKeyProgress { get; }

        // extern const MGLOfflinePackUserInfoKey _Nonnull MGLOfflinePackUserInfoKeyError __attribute__((visibility("default")));
        [Field("MGLOfflinePackUserInfoKeyError", "__Internal")]
        NSString UserInfoKeyError { get; }

        // extern const MGLOfflinePackUserInfoKey _Nonnull MGLOfflinePackUserInfoKeyMaximumCount __attribute__((visibility("default")));
        [Field("MGLOfflinePackUserInfoKeyMaximumCount", "__Internal")]
        NSString UserInfoKeyMaximumCount { get; }
    }

    // typedef void (^MGLOfflinePackAdditionCompletionHandler)(MGLOfflinePack * _Nullable, NSError * _Nullable);
    delegate void MGLOfflinePackAdditionCompletionHandler([NullAllowed] MGLOfflinePack arg0, [NullAllowed] NSError arg1);

    // typedef void (^MGLOfflinePackRemovalCompletionHandler)(NSError * _Nullable);
    delegate void MGLOfflinePackRemovalCompletionHandler([NullAllowed] NSError arg0);

    // @interface MGLOfflineStorage : NSObject
    [BaseType(typeof(NSObject))]
    interface MGLOfflineStorage
    {
        // @property (readonly, nonatomic, class) MGLOfflineStorage * _Nonnull sharedOfflineStorage;
        [Static]
        [Export("sharedOfflineStorage")]
        MGLOfflineStorage SharedOfflineStorage { get; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MGLOfflineStorageDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MGLOfflineStorageDelegate> _Nullable delegate __attribute__((iboutlet));
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic, strong) NSArray<MGLOfflinePack *> * _Nullable packs;
        [NullAllowed, Export("packs", ArgumentSemantic.Strong)]
        MGLOfflinePack[] Packs { get; }

        // -(void)addPackForRegion:(id<MGLOfflineRegion> _Nonnull)region withContext:(NSData * _Nonnull)context completionHandler:(MGLOfflinePackAdditionCompletionHandler _Nullable)completion;
        [Export("addPackForRegion:withContext:completionHandler:")]
        void AddPackForRegion(IMGLOfflineRegion region, NSData context, [NullAllowed] MGLOfflinePackAdditionCompletionHandler completion);

        // -(void)removePack:(MGLOfflinePack * _Nonnull)pack withCompletionHandler:(MGLOfflinePackRemovalCompletionHandler _Nullable)completion;
        [Export("removePack:withCompletionHandler:")]
        void RemovePack(MGLOfflinePack pack, [NullAllowed] MGLOfflinePackRemovalCompletionHandler completion);

        // -(void)reloadPacks;
        [Export("reloadPacks")]
        void ReloadPacks();

        // -(void)setMaximumAllowedMapboxTiles:(uint64_t)maximumCount;
        [Export("setMaximumAllowedMapboxTiles:")]
        void SetMaximumAllowedMapboxTiles(ulong maximumCount);

        // @property (readonly, nonatomic) unsigned long long countOfBytesCompleted;
        [Export("countOfBytesCompleted")]
        ulong CountOfBytesCompleted { get; }
    }

    // @protocol MGLOfflineStorageDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MGLOfflineStorageDelegate
    {
        // @required -(NSURL * _Nonnull)offlineStorage:(MGLOfflineStorage * _Nonnull)storage URLForResourceOfKind:(MGLResourceKind)kind withURL:(NSURL * _Nonnull)url;
        [Abstract]
        [Export("offlineStorage:URLForResourceOfKind:withURL:")]
        NSUrl URLForResourceOfKind(MGLOfflineStorage storage, MGLResourceKind kind, NSUrl url);
    }

    // @interface MGLOpenGLStyleLayer : MGLStyleLayer
    [BaseType(typeof(MGLStyleLayer))]
    interface MGLOpenGLStyleLayer
    {
        // @property (readonly, nonatomic, weak) MGLStyle * _Nullable style;
        [NullAllowed, Export("style", ArgumentSemantic.Weak)]
        MGLStyle Style { get; }

        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier;
        [Export("initWithIdentifier:")]
        IntPtr Constructor(string identifier);

        // -(void)didMoveToMapView:(MGLMapView * _Nonnull)mapView;
        [Export("didMoveToMapView:")]
        void DidMoveToMapView(MGLMapView mapView);

        // -(void)willMoveFromMapView:(MGLMapView * _Nonnull)mapView;
        [Export("willMoveFromMapView:")]
        void WillMoveFromMapView(MGLMapView mapView);

        // -(void)drawInMapView:(MGLMapView * _Nonnull)mapView withContext:(MGLStyleLayerDrawingContext)context;
        [Export("drawInMapView:withContext:")]
        void DrawInMapView(MGLMapView mapView, MGLStyleLayerDrawingContext context);

        // -(void)setNeedsDisplay;
        [Export("setNeedsDisplay")]
        void SetNeedsDisplay();
    }

    [Static]
    partial interface MGLTileSourceOptions
    {
        // extern const MGLTileSourceOption _Nonnull MGLTileSourceOptionMinimumZoomLevel __attribute__((visibility("default")));
        [Field("MGLTileSourceOptionMinimumZoomLevel", "__Internal")]
        NSString MinimumZoomLevel { get; }

        // extern const MGLTileSourceOption _Nonnull MGLTileSourceOptionMaximumZoomLevel __attribute__((visibility("default")));
        [Field("MGLTileSourceOptionMaximumZoomLevel", "__Internal")]
        NSString MaximumZoomLevel { get; }

        // extern const MGLTileSourceOption _Nonnull MGLTileSourceOptionCoordinateBounds __attribute__((visibility("default")));
        [Field("MGLTileSourceOptionCoordinateBounds", "__Internal")]
        NSString CoordinateBounds { get; }

        // extern const MGLTileSourceOption _Nonnull MGLTileSourceOptionAttributionHTMLString __attribute__((visibility("default")));
        [Field("MGLTileSourceOptionAttributionHTMLString", "__Internal")]
        NSString AttributionHTMLString { get; }

        // extern const MGLTileSourceOption _Nonnull MGLTileSourceOptionAttributionInfos __attribute__((visibility("default")));
        [Field("MGLTileSourceOptionAttributionInfos", "__Internal")]
        NSString AttributionInfos { get; }

        // extern const MGLTileSourceOption _Nonnull MGLTileSourceOptionTileCoordinateSystem __attribute__((visibility("default")));
        [Field("MGLTileSourceOptionTileCoordinateSystem", "__Internal")]
        NSString TileCoordinateSystem { get; }

        // extern const MGLTileSourceOption _Nonnull MGLTileSourceOptionTileSize __attribute__((visibility("default")));
        [Field("MGLTileSourceOptionTileSize", "__Internal")]
        NSString TileSize { get; }

        // extern const MGLTileSourceOption MGLTileSourceOptionDEMEncoding __attribute__((visibility("default")));
        [Field("MGLTileSourceOptionDEMEncoding", "__Internal")]
        NSString DEMEncoding { get; }
    }

    // @interface MGLTileSource : MGLSource
    [BaseType(typeof(MGLSource))]
    interface MGLTileSource
    {
        // @property (readonly, copy, nonatomic) NSURL * _Nullable configurationURL;
        [NullAllowed, Export("configurationURL", ArgumentSemantic.Copy)]
        NSUrl ConfigurationURL { get; }

        // @property (readonly, copy, nonatomic) NSArray<MGLAttributionInfo *> * _Nonnull attributionInfos;
        [Export("attributionInfos", ArgumentSemantic.Copy)]
        MGLAttributionInfo[] AttributionInfos { get; }
    }

    // @interface MGLRasterTileSource : MGLTileSource
    [BaseType(typeof(MGLTileSource))]
    interface MGLRasterTileSource
    {
        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier configurationURL:(NSURL * _Nonnull)configurationURL;
        [Export("initWithIdentifier:configurationURL:")]
        IntPtr Constructor(string identifier, NSUrl configurationURL);

        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier configurationURL:(NSURL * _Nonnull)configurationURL tileSize:(CGFloat)tileSize __attribute__((objc_designated_initializer));
        [Export("initWithIdentifier:configurationURL:tileSize:")]
        [DesignatedInitializer]
        IntPtr Constructor(string identifier, NSUrl configurationURL, nfloat tileSize);

        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier tileURLTemplates:(NSArray<NSString *> * _Nonnull)tileURLTemplates options:(NSDictionary<MGLTileSourceOption,id> * _Nullable)options __attribute__((objc_designated_initializer));
        [Export("initWithIdentifier:tileURLTemplates:options:")]
        [DesignatedInitializer]
        IntPtr Constructor(string identifier, string[] tileURLTemplates, [NullAllowed] NSDictionary<NSString, NSObject> options);
    }

    // @interface MGLRasterDEMSource : MGLRasterTileSource
    [BaseType(typeof(MGLRasterTileSource))]
    interface MGLRasterDEMSource
    {
    }

    // @interface MGLRasterStyleLayer : MGLForegroundStyleLayer
    [BaseType(typeof(MGLForegroundStyleLayer))]
    interface MGLRasterStyleLayer
    {
        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source;
        [Export("initWithIdentifier:source:")]
        IntPtr Constructor(string identifier, MGLSource source);

        // @property (nonatomic) NSExpression * _Null_unspecified maximumRasterBrightness;
        [Export("maximumRasterBrightness", ArgumentSemantic.Assign)]
        NSExpression MaximumRasterBrightness { get; set; }

        // @property (nonatomic) MGLTransition maximumRasterBrightnessTransition;
        [Export("maximumRasterBrightnessTransition", ArgumentSemantic.Assign)]
        MGLTransition MaximumRasterBrightnessTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified minimumRasterBrightness;
        [Export("minimumRasterBrightness", ArgumentSemantic.Assign)]
        NSExpression MinimumRasterBrightness { get; set; }

        // @property (nonatomic) MGLTransition minimumRasterBrightnessTransition;
        [Export("minimumRasterBrightnessTransition", ArgumentSemantic.Assign)]
        MGLTransition MinimumRasterBrightnessTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified rasterContrast;
        [Export("rasterContrast", ArgumentSemantic.Assign)]
        NSExpression RasterContrast { get; set; }

        // @property (nonatomic) MGLTransition rasterContrastTransition;
        [Export("rasterContrastTransition", ArgumentSemantic.Assign)]
        MGLTransition RasterContrastTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified rasterFadeDuration;
        [Export("rasterFadeDuration", ArgumentSemantic.Assign)]
        NSExpression RasterFadeDuration { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified rasterHueRotation;
        [Export("rasterHueRotation", ArgumentSemantic.Assign)]
        NSExpression RasterHueRotation { get; set; }

        // @property (nonatomic) MGLTransition rasterHueRotationTransition;
        [Export("rasterHueRotationTransition", ArgumentSemantic.Assign)]
        MGLTransition RasterHueRotationTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified rasterOpacity;
        [Export("rasterOpacity", ArgumentSemantic.Assign)]
        NSExpression RasterOpacity { get; set; }

        // @property (nonatomic) MGLTransition rasterOpacityTransition;
        [Export("rasterOpacityTransition", ArgumentSemantic.Assign)]
        MGLTransition RasterOpacityTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified rasterSaturation;
        [Export("rasterSaturation", ArgumentSemantic.Assign)]
        NSExpression RasterSaturation { get; set; }

        // @property (nonatomic) MGLTransition rasterSaturationTransition;
        [Export("rasterSaturationTransition", ArgumentSemantic.Assign)]
        MGLTransition RasterSaturationTransition { get; set; }
    }

    // @interface MGLStyle : NSObject
    [BaseType(typeof(NSObject))]
    interface MGLStyle
    {
        // @property (readonly, nonatomic, class) NSURL * _Nonnull streetsStyleURL;
        [Static]
        [Export("streetsStyleURL")]
        NSUrl StreetsStyleURL { get; }

        // +(NSURL * _Nonnull)streetsStyleURLWithVersion:(NSInteger)version;
        [Static]
        [Export("streetsStyleURLWithVersion:")]
        NSUrl StreetsStyleURLWithVersion(nint version);

        // @property (readonly, nonatomic, class) NSURL * _Nonnull outdoorsStyleURL;
        [Static]
        [Export("outdoorsStyleURL")]
        NSUrl OutdoorsStyleURL { get; }

        // +(NSURL * _Nonnull)outdoorsStyleURLWithVersion:(NSInteger)version;
        [Static]
        [Export("outdoorsStyleURLWithVersion:")]
        NSUrl OutdoorsStyleURLWithVersion(nint version);

        // @property (readonly, nonatomic, class) NSURL * _Nonnull lightStyleURL;
        [Static]
        [Export("lightStyleURL")]
        NSUrl LightStyleURL { get; }

        // +(NSURL * _Nonnull)lightStyleURLWithVersion:(NSInteger)version;
        [Static]
        [Export("lightStyleURLWithVersion:")]
        NSUrl LightStyleURLWithVersion(nint version);

        // @property (readonly, nonatomic, class) NSURL * _Nonnull darkStyleURL;
        [Static]
        [Export("darkStyleURL")]
        NSUrl DarkStyleURL { get; }

        // +(NSURL * _Nonnull)darkStyleURLWithVersion:(NSInteger)version;
        [Static]
        [Export("darkStyleURLWithVersion:")]
        NSUrl DarkStyleURLWithVersion(nint version);

        // @property (readonly, nonatomic, class) NSURL * _Nonnull satelliteStyleURL;
        [Static]
        [Export("satelliteStyleURL")]
        NSUrl SatelliteStyleURL { get; }

        // +(NSURL * _Nonnull)satelliteStyleURLWithVersion:(NSInteger)version;
        [Static]
        [Export("satelliteStyleURLWithVersion:")]
        NSUrl SatelliteStyleURLWithVersion(nint version);

        // @property (readonly, nonatomic, class) NSURL * _Nonnull satelliteStreetsStyleURL;
        [Static]
        [Export("satelliteStreetsStyleURL")]
        NSUrl SatelliteStreetsStyleURL { get; }

        // +(NSURL * _Nonnull)satelliteStreetsStyleURLWithVersion:(NSInteger)version;
        [Static]
        [Export("satelliteStreetsStyleURLWithVersion:")]
        NSUrl SatelliteStreetsStyleURLWithVersion(nint version);

        // @property (readonly, copy) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; }

        // @property (nonatomic, strong) NSSet<__kindof MGLSource *> * _Nonnull sources;
        [Export("sources", ArgumentSemantic.Strong)]
        NSSet Sources { get; set; }

        // @property (nonatomic) MGLTransition transition;
        [Export("transition", ArgumentSemantic.Assign)]
        MGLTransition Transition { get; set; }

        // -(MGLSource * _Nullable)sourceWithIdentifier:(NSString * _Nonnull)identifier;
        [Export("sourceWithIdentifier:")]
        [return: NullAllowed]
        MGLSource SourceWithIdentifier(string identifier);

        // -(void)addSource:(MGLSource * _Nonnull)source;
        [Export("addSource:")]
        void AddSource(MGLSource source);

        // -(void)removeSource:(MGLSource * _Nonnull)source;
        [Export("removeSource:")]
        void RemoveSource(MGLSource source);

        // @property (nonatomic, strong) NSArray<__kindof MGLStyleLayer *> * _Nonnull layers;
        [Export("layers", ArgumentSemantic.Strong)]
        MGLStyleLayer[] Layers { get; set; }

        // -(MGLStyleLayer * _Nullable)layerWithIdentifier:(NSString * _Nonnull)identifier;
        [Export("layerWithIdentifier:")]
        [return: NullAllowed]
        MGLStyleLayer LayerWithIdentifier(string identifier);

        // -(void)addLayer:(MGLStyleLayer * _Nonnull)layer;
        [Export("addLayer:")]
        void AddLayer(MGLStyleLayer layer);

        // -(void)insertLayer:(MGLStyleLayer * _Nonnull)layer atIndex:(NSUInteger)index;
        [Export("insertLayer:atIndex:")]
        void InsertLayer(MGLStyleLayer layer, nuint index);

        // -(void)insertLayer:(MGLStyleLayer * _Nonnull)layer belowLayer:(MGLStyleLayer * _Nonnull)sibling;
        [Export("insertLayer:belowLayer:")]
        void InsertLayerBelow(MGLStyleLayer layer, MGLStyleLayer sibling);

        // -(void)insertLayer:(MGLStyleLayer * _Nonnull)layer aboveLayer:(MGLStyleLayer * _Nonnull)sibling;
        [Export("insertLayer:aboveLayer:")]
        void InsertLayerAbove(MGLStyleLayer layer, MGLStyleLayer sibling);

        // -(void)removeLayer:(MGLStyleLayer * _Nonnull)layer;
        [Export("removeLayer:")]
        void RemoveLayer(MGLStyleLayer layer);

        // -(UIImage * _Nullable)imageForName:(NSString * _Nonnull)name;
        [Export("imageForName:")]
        [return: NullAllowed]
        UIImage ImageForName(string name);

        // -(void)setImage:(UIImage * _Nonnull)image forName:(NSString * _Nonnull)name;
        [Export("setImage:forName:")]
        void SetImage(UIImage image, string name);

        // -(void)removeImageForName:(NSString * _Nonnull)name;
        [Export("removeImageForName:")]
        void RemoveImageForName(string name);

        // @property (nonatomic, strong) MGLLight * _Nonnull light;
        [Export("light", ArgumentSemantic.Strong)]
        MGLLight Light { get; set; }

        // -(void)localizeLabelsIntoLocale:(NSLocale * _Nullable)locale;
        [Export("localizeLabelsIntoLocale:")]
        void LocalizeLabelsIntoLocale([NullAllowed] NSLocale locale);
    }

    // @interface MGLSymbolStyleLayer : MGLVectorStyleLayer
    [BaseType(typeof(MGLVectorStyleLayer))]
    interface MGLSymbolStyleLayer
    {
        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier source:(MGLSource * _Nonnull)source;
        [Export("initWithIdentifier:source:")]
        IntPtr Constructor(string identifier, MGLSource source);

        // @property (nonatomic) NSExpression * _Null_unspecified iconAllowsOverlap;
        [Export("iconAllowsOverlap", ArgumentSemantic.Assign)]
        NSExpression IconAllowsOverlap { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconAnchor;
        [Export("iconAnchor", ArgumentSemantic.Assign)]
        NSExpression IconAnchor { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconIgnoresPlacement;
        [Export("iconIgnoresPlacement", ArgumentSemantic.Assign)]
        NSExpression IconIgnoresPlacement { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconImageName;
        [Export("iconImageName", ArgumentSemantic.Assign)]
        NSExpression IconImageName { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconOffset;
        [Export("iconOffset", ArgumentSemantic.Assign)]
        NSExpression IconOffset { get; set; }

        // @property (getter = isIconOptional, nonatomic) NSExpression * _Null_unspecified iconOptional;
        [Export("iconOptional", ArgumentSemantic.Assign)]
        NSExpression IconOptional { [Bind("isIconOptional")] get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconPadding;
        [Export("iconPadding", ArgumentSemantic.Assign)]
        NSExpression IconPadding { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconPitchAlignment;
        [Export("iconPitchAlignment", ArgumentSemantic.Assign)]
        NSExpression IconPitchAlignment { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconRotation;
        [Export("iconRotation", ArgumentSemantic.Assign)]
        NSExpression IconRotation { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconRotationAlignment;
        [Export("iconRotationAlignment", ArgumentSemantic.Assign)]
        NSExpression IconRotationAlignment { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconScale;
        [Export("iconScale", ArgumentSemantic.Assign)]
        NSExpression IconScale { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconTextFit;
        [Export("iconTextFit", ArgumentSemantic.Assign)]
        NSExpression IconTextFit { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconTextFitPadding;
        [Export("iconTextFitPadding", ArgumentSemantic.Assign)]
        NSExpression IconTextFitPadding { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified keepsIconUpright;
        [Export("keepsIconUpright", ArgumentSemantic.Assign)]
        NSExpression KeepsIconUpright { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified keepsTextUpright;
        [Export("keepsTextUpright", ArgumentSemantic.Assign)]
        NSExpression KeepsTextUpright { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified maximumTextAngle;
        [Export("maximumTextAngle", ArgumentSemantic.Assign)]
        NSExpression MaximumTextAngle { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified maximumTextWidth;
        [Export("maximumTextWidth", ArgumentSemantic.Assign)]
        NSExpression MaximumTextWidth { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified symbolAvoidsEdges;
        [Export("symbolAvoidsEdges", ArgumentSemantic.Assign)]
        NSExpression SymbolAvoidsEdges { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified symbolPlacement;
        [Export("symbolPlacement", ArgumentSemantic.Assign)]
        NSExpression SymbolPlacement { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified symbolSpacing;
        [Export("symbolSpacing", ArgumentSemantic.Assign)]
        NSExpression SymbolSpacing { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified text;
        [Export("text", ArgumentSemantic.Assign)]
        NSExpression Text { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textAllowsOverlap;
        [Export("textAllowsOverlap", ArgumentSemantic.Assign)]
        NSExpression TextAllowsOverlap { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textAnchor;
        [Export("textAnchor", ArgumentSemantic.Assign)]
        NSExpression TextAnchor { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textFontNames;
        [Export("textFontNames", ArgumentSemantic.Assign)]
        NSExpression TextFontNames { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textFontSize;
        [Export("textFontSize", ArgumentSemantic.Assign)]
        NSExpression TextFontSize { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textIgnoresPlacement;
        [Export("textIgnoresPlacement", ArgumentSemantic.Assign)]
        NSExpression TextIgnoresPlacement { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textJustification;
        [Export("textJustification", ArgumentSemantic.Assign)]
        NSExpression TextJustification { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textLetterSpacing;
        [Export("textLetterSpacing", ArgumentSemantic.Assign)]
        NSExpression TextLetterSpacing { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textLineHeight;
        [Export("textLineHeight", ArgumentSemantic.Assign)]
        NSExpression TextLineHeight { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textOffset;
        [Export("textOffset", ArgumentSemantic.Assign)]
        NSExpression TextOffset { get; set; }

        // @property (getter = isTextOptional, nonatomic) NSExpression * _Null_unspecified textOptional;
        [Export("textOptional", ArgumentSemantic.Assign)]
        NSExpression TextOptional { [Bind("isTextOptional")] get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textPadding;
        [Export("textPadding", ArgumentSemantic.Assign)]
        NSExpression TextPadding { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textPitchAlignment;
        [Export("textPitchAlignment", ArgumentSemantic.Assign)]
        NSExpression TextPitchAlignment { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textRotation;
        [Export("textRotation", ArgumentSemantic.Assign)]
        NSExpression TextRotation { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textRotationAlignment;
        [Export("textRotationAlignment", ArgumentSemantic.Assign)]
        NSExpression TextRotationAlignment { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textTransform;
        [Export("textTransform", ArgumentSemantic.Assign)]
        NSExpression TextTransform { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconColor;
        [Export("iconColor", ArgumentSemantic.Assign)]
        NSExpression IconColor { get; set; }

        // @property (nonatomic) MGLTransition iconColorTransition;
        [Export("iconColorTransition", ArgumentSemantic.Assign)]
        MGLTransition IconColorTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconHaloBlur;
        [Export("iconHaloBlur", ArgumentSemantic.Assign)]
        NSExpression IconHaloBlur { get; set; }

        // @property (nonatomic) MGLTransition iconHaloBlurTransition;
        [Export("iconHaloBlurTransition", ArgumentSemantic.Assign)]
        MGLTransition IconHaloBlurTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconHaloColor;
        [Export("iconHaloColor", ArgumentSemantic.Assign)]
        NSExpression IconHaloColor { get; set; }

        // @property (nonatomic) MGLTransition iconHaloColorTransition;
        [Export("iconHaloColorTransition", ArgumentSemantic.Assign)]
        MGLTransition IconHaloColorTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconHaloWidth;
        [Export("iconHaloWidth", ArgumentSemantic.Assign)]
        NSExpression IconHaloWidth { get; set; }

        // @property (nonatomic) MGLTransition iconHaloWidthTransition;
        [Export("iconHaloWidthTransition", ArgumentSemantic.Assign)]
        MGLTransition IconHaloWidthTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconOpacity;
        [Export("iconOpacity", ArgumentSemantic.Assign)]
        NSExpression IconOpacity { get; set; }

        // @property (nonatomic) MGLTransition iconOpacityTransition;
        [Export("iconOpacityTransition", ArgumentSemantic.Assign)]
        MGLTransition IconOpacityTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconTranslation;
        [Export("iconTranslation", ArgumentSemantic.Assign)]
        NSExpression IconTranslation { get; set; }

        // @property (nonatomic) MGLTransition iconTranslationTransition;
        [Export("iconTranslationTransition", ArgumentSemantic.Assign)]
        MGLTransition IconTranslationTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified iconTranslationAnchor;
        [Export("iconTranslationAnchor", ArgumentSemantic.Assign)]
        NSExpression IconTranslationAnchor { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textColor;
        [Export("textColor", ArgumentSemantic.Assign)]
        NSExpression TextColor { get; set; }

        // @property (nonatomic) MGLTransition textColorTransition;
        [Export("textColorTransition", ArgumentSemantic.Assign)]
        MGLTransition TextColorTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textHaloBlur;
        [Export("textHaloBlur", ArgumentSemantic.Assign)]
        NSExpression TextHaloBlur { get; set; }

        // @property (nonatomic) MGLTransition textHaloBlurTransition;
        [Export("textHaloBlurTransition", ArgumentSemantic.Assign)]
        MGLTransition TextHaloBlurTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textHaloColor;
        [Export("textHaloColor", ArgumentSemantic.Assign)]
        NSExpression TextHaloColor { get; set; }

        // @property (nonatomic) MGLTransition textHaloColorTransition;
        [Export("textHaloColorTransition", ArgumentSemantic.Assign)]
        MGLTransition TextHaloColorTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textHaloWidth;
        [Export("textHaloWidth", ArgumentSemantic.Assign)]
        NSExpression TextHaloWidth { get; set; }

        // @property (nonatomic) MGLTransition textHaloWidthTransition;
        [Export("textHaloWidthTransition", ArgumentSemantic.Assign)]
        MGLTransition TextHaloWidthTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textOpacity;
        [Export("textOpacity", ArgumentSemantic.Assign)]
        NSExpression TextOpacity { get; set; }

        // @property (nonatomic) MGLTransition textOpacityTransition;
        [Export("textOpacityTransition", ArgumentSemantic.Assign)]
        MGLTransition TextOpacityTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textTranslation;
        [Export("textTranslation", ArgumentSemantic.Assign)]
        NSExpression TextTranslation { get; set; }

        // @property (nonatomic) MGLTransition textTranslationTransition;
        [Export("textTranslationTransition", ArgumentSemantic.Assign)]
        MGLTransition TextTranslationTransition { get; set; }

        // @property (nonatomic) NSExpression * _Null_unspecified textTranslationAnchor;
        [Export("textTranslationAnchor", ArgumentSemantic.Assign)]
        NSExpression TextTranslationAnchor { get; set; }
    }

    // @interface MGLSymbolStyleLayerAdditions (NSValue)
    [Category]
    [BaseType(typeof(NSValue))]
    interface NSValue_MGLSymbolStyleLayerAdditions
    {
        // +(instancetype _Nonnull)valueWithMGLIconAnchor:(MGLIconAnchor)iconAnchor;
        [Static]
        [Export("valueWithMGLIconAnchor:")]
        NSValue ValueWithMGLIconAnchor(MGLIconAnchor iconAnchor);

        // @property (readonly) MGLIconAnchor MGLIconAnchorValue;
        [Export("MGLIconAnchorValue")]
        MGLIconAnchor MGLIconAnchorValue();

        // +(instancetype _Nonnull)valueWithMGLIconPitchAlignment:(MGLIconPitchAlignment)iconPitchAlignment;
        [Static]
        [Export("valueWithMGLIconPitchAlignment:")]
        NSValue ValueWithMGLIconPitchAlignment(MGLIconPitchAlignment iconPitchAlignment);

        // @property (readonly) MGLIconPitchAlignment MGLIconPitchAlignmentValue;
        [Export("MGLIconPitchAlignmentValue")]
        MGLIconPitchAlignment MGLIconPitchAlignmentValue();

        // +(instancetype _Nonnull)valueWithMGLIconRotationAlignment:(MGLIconRotationAlignment)iconRotationAlignment;
        [Static]
        [Export("valueWithMGLIconRotationAlignment:")]
        NSValue ValueWithMGLIconRotationAlignment(MGLIconRotationAlignment iconRotationAlignment);

        // @property (readonly) MGLIconRotationAlignment MGLIconRotationAlignmentValue;
        [Export("MGLIconRotationAlignmentValue")]
        MGLIconRotationAlignment MGLIconRotationAlignmentValue();

        // +(instancetype _Nonnull)valueWithMGLIconTextFit:(MGLIconTextFit)iconTextFit;
        [Static]
        [Export("valueWithMGLIconTextFit:")]
        NSValue ValueWithMGLIconTextFit(MGLIconTextFit iconTextFit);

        // @property (readonly) MGLIconTextFit MGLIconTextFitValue;
        [Export("MGLIconTextFitValue")]
        MGLIconTextFit MGLIconTextFitValue();

        // +(instancetype _Nonnull)valueWithMGLSymbolPlacement:(MGLSymbolPlacement)symbolPlacement;
        [Static]
        [Export("valueWithMGLSymbolPlacement:")]
        NSValue ValueWithMGLSymbolPlacement(MGLSymbolPlacement symbolPlacement);

        // @property (readonly) MGLSymbolPlacement MGLSymbolPlacementValue;
        [Export("MGLSymbolPlacementValue")]
        MGLSymbolPlacement MGLSymbolPlacementValue();

        // +(instancetype _Nonnull)valueWithMGLTextAnchor:(MGLTextAnchor)textAnchor;
        [Static]
        [Export("valueWithMGLTextAnchor:")]
        NSValue ValueWithMGLTextAnchor(MGLTextAnchor textAnchor);

        // @property (readonly) MGLTextAnchor MGLTextAnchorValue;
        [Export("MGLTextAnchorValue")]
        MGLTextAnchor MGLTextAnchorValue();

        // +(instancetype _Nonnull)valueWithMGLTextJustification:(MGLTextJustification)textJustification;
        [Static]
        [Export("valueWithMGLTextJustification:")]
        NSValue ValueWithMGLTextJustification(MGLTextJustification textJustification);

        // @property (readonly) MGLTextJustification MGLTextJustificationValue;
        [Export("MGLTextJustificationValue")]
        MGLTextJustification MGLTextJustificationValue();

        // +(instancetype _Nonnull)valueWithMGLTextPitchAlignment:(MGLTextPitchAlignment)textPitchAlignment;
        [Static]
        [Export("valueWithMGLTextPitchAlignment:")]
        NSValue ValueWithMGLTextPitchAlignment(MGLTextPitchAlignment textPitchAlignment);

        // @property (readonly) MGLTextPitchAlignment MGLTextPitchAlignmentValue;
        [Export("MGLTextPitchAlignmentValue")]
        MGLTextPitchAlignment MGLTextPitchAlignmentValue();

        // +(instancetype _Nonnull)valueWithMGLTextRotationAlignment:(MGLTextRotationAlignment)textRotationAlignment;
        [Static]
        [Export("valueWithMGLTextRotationAlignment:")]
        NSValue ValueWithMGLTextRotationAlignment(MGLTextRotationAlignment textRotationAlignment);

        // @property (readonly) MGLTextRotationAlignment MGLTextRotationAlignmentValue;
        [Export("MGLTextRotationAlignmentValue")]
        MGLTextRotationAlignment MGLTextRotationAlignmentValue();

        // +(instancetype _Nonnull)valueWithMGLTextTransform:(MGLTextTransform)textTransform;
        [Static]
        [Export("valueWithMGLTextTransform:")]
        NSValue ValueWithMGLTextTransform(MGLTextTransform textTransform);

        // @property (readonly) MGLTextTransform MGLTextTransformValue;
        [Export("MGLTextTransformValue")]
        MGLTextTransform MGLTextTransformValue();

        // +(instancetype _Nonnull)valueWithMGLIconTranslationAnchor:(MGLIconTranslationAnchor)iconTranslationAnchor;
        [Static]
        [Export("valueWithMGLIconTranslationAnchor:")]
        NSValue ValueWithMGLIconTranslationAnchor(MGLIconTranslationAnchor iconTranslationAnchor);

        // @property (readonly) MGLIconTranslationAnchor MGLIconTranslationAnchorValue;
        [Export("MGLIconTranslationAnchorValue")]
        MGLIconTranslationAnchor MGLIconTranslationAnchorValue();

        // +(instancetype _Nonnull)valueWithMGLTextTranslationAnchor:(MGLTextTranslationAnchor)textTranslationAnchor;
        [Static]
        [Export("valueWithMGLTextTranslationAnchor:")]
        NSValue ValueWithMGLTextTranslationAnchor(MGLTextTranslationAnchor textTranslationAnchor);

        // @property (readonly) MGLTextTranslationAnchor MGLTextTranslationAnchorValue;
        [Export("MGLTextTranslationAnchorValue")]
        MGLTextTranslationAnchor MGLTextTranslationAnchorValue();
    }

    // @interface MGLTilePyramidOfflineRegion : NSObject <MGLOfflineRegion, NSSecureCoding, NSCopying>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface MGLTilePyramidOfflineRegion : MGLOfflineRegion, INSSecureCoding, INSCopying
    {
        // @property (readonly, nonatomic) NSURL * _Nonnull styleURL;
        [Export("styleURL")]
        NSUrl StyleURL { get; }

        // @property (readonly, nonatomic) MGLCoordinateBounds bounds;
        [Export("bounds")]
        MGLCoordinateBounds Bounds { get; }

        // @property (readonly, nonatomic) double minimumZoomLevel;
        [Export("minimumZoomLevel")]
        double MinimumZoomLevel { get; }

        // @property (readonly, nonatomic) double maximumZoomLevel;
        [Export("maximumZoomLevel")]
        double MaximumZoomLevel { get; }

        // -(instancetype _Nonnull)initWithStyleURL:(NSURL * _Nullable)styleURL bounds:(MGLCoordinateBounds)bounds fromZoomLevel:(double)minimumZoomLevel toZoomLevel:(double)maximumZoomLevel __attribute__((objc_designated_initializer));
        [Export("initWithStyleURL:bounds:fromZoomLevel:toZoomLevel:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] NSUrl styleURL, MGLCoordinateBounds bounds, double minimumZoomLevel, double maximumZoomLevel);
    }

    // @interface MGLUserLocation : NSObject <MGLAnnotation, NSSecureCoding>
    [BaseType(typeof(NSObject))]
    interface MGLUserLocation : MGLAnnotation, INSSecureCoding
    {
        // @property (readonly, nonatomic) CLLocation * _Nullable location;
        [NullAllowed, Export("location")]
        CLLocation Location { get; }

        // @property (readonly, getter = isUpdating, nonatomic) BOOL updating;
        [Export("updating")]
        bool Updating { [Bind("isUpdating")] get; }

        // @property (readonly, nonatomic) CLHeading * _Nullable heading;
        [NullAllowed, Export("heading")]
        CLHeading Heading { get; }

        //// @property (copy, nonatomic) NSString * _Nonnull title;
        //[Export("title")]
        //string Title { get; set; }

        //// @property (copy, nonatomic) NSString * _Nullable subtitle;
        //[NullAllowed, Export("subtitle")]
        //string Subtitle { get; set; }
    }

    // @interface MGLUserLocationAnnotationView : MGLAnnotationView
    [BaseType(typeof(MGLAnnotationView))]
    interface MGLUserLocationAnnotationView
    {
        // @property (readonly, nonatomic, weak) MGLMapView * _Nullable mapView;
        [NullAllowed, Export("mapView", ArgumentSemantic.Weak)]
        MGLMapView MapView { get; }

        // @property (readonly, nonatomic, weak) MGLUserLocation * _Nullable userLocation;
        [NullAllowed, Export("userLocation", ArgumentSemantic.Weak)]
        MGLUserLocation UserLocation { get; }

        // @property (readonly, nonatomic, weak) CALayer * _Nullable hitTestLayer;
        [NullAllowed, Export("hitTestLayer", ArgumentSemantic.Weak)]
        CALayer HitTestLayer { get; }

        // -(void)update;
        [Export("update")]
        void Update();
    }

    // @interface MGLVectorTileSource : MGLTileSource
    [BaseType(typeof(MGLTileSource))]
    interface MGLVectorTileSource
    {
        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier configurationURL:(NSURL * _Nonnull)configurationURL __attribute__((objc_designated_initializer));
        [Export("initWithIdentifier:configurationURL:")]
        [DesignatedInitializer]
        IntPtr Constructor(string identifier, NSUrl configurationURL);

        // -(instancetype _Nonnull)initWithIdentifier:(NSString * _Nonnull)identifier tileURLTemplates:(NSArray<NSString *> * _Nonnull)tileURLTemplates options:(NSDictionary<MGLTileSourceOption,id> * _Nullable)options __attribute__((objc_designated_initializer));
        [Export("initWithIdentifier:tileURLTemplates:options:")]
        [DesignatedInitializer]
        IntPtr Constructor(string identifier, string[] tileURLTemplates, [NullAllowed] NSDictionary<NSString, NSObject> options);

        // -(NSArray<id<MGLFeature>> * _Nonnull)featuresInSourceLayersWithIdentifiers:(NSSet<NSString *> * _Nonnull)sourceLayerIdentifiers predicate:(NSPredicate * _Nullable)predicate;
        [Export("featuresInSourceLayersWithIdentifiers:predicate:")]
        NSObject[] FeaturesInSourceLayersWithIdentifiers(NSSet<NSString> sourceLayerIdentifiers, [NullAllowed] NSPredicate predicate);
    }

    // @interface MGLAdditions (NSValue)
    [Category]
    [BaseType(typeof(NSValue))]
    interface NSValue_MGLAdditions
    {
        // +(instancetype _Nonnull)valueWithMGLCoordinate:(CLLocationCoordinate2D)coordinate;
        [Static]
        [Export("valueWithMGLCoordinate:")]
        NSValue ValueWithMGLCoordinate(CLLocationCoordinate2D coordinate);

        // @property (readonly) CLLocationCoordinate2D MGLCoordinateValue;
        [Export("MGLCoordinateValue")]
        CLLocationCoordinate2D MGLCoordinateValue();

        // +(instancetype _Nonnull)valueWithMGLMapPoint:(MGLMapPoint)point;
        [Static]
        [Export("valueWithMGLMapPoint:")]
        NSValue ValueWithMGLMapPoint(MGLMapPoint point);

        // @property (readonly) MGLMapPoint MGLMapPointValue;
        [Export("MGLMapPointValue")]
        MGLMapPoint MGLMapPointValue();

        // +(instancetype _Nonnull)valueWithMGLCoordinateSpan:(MGLCoordinateSpan)span;
        [Static]
        [Export("valueWithMGLCoordinateSpan:")]
        NSValue ValueWithMGLCoordinateSpan(MGLCoordinateSpan span);

        // @property (readonly) MGLCoordinateSpan MGLCoordinateSpanValue;
        [Export("MGLCoordinateSpanValue")]
        MGLCoordinateSpan MGLCoordinateSpanValue();

        // +(instancetype _Nonnull)valueWithMGLCoordinateBounds:(MGLCoordinateBounds)bounds;
        [Static]
        [Export("valueWithMGLCoordinateBounds:")]
        NSValue ValueWithMGLCoordinateBounds(MGLCoordinateBounds bounds);

        // @property (readonly) MGLCoordinateBounds MGLCoordinateBoundsValue;
        [Export("MGLCoordinateBoundsValue")]
        MGLCoordinateBounds MGLCoordinateBoundsValue();

        // +(instancetype _Nonnull)valueWithMGLCoordinateQuad:(MGLCoordinateQuad)quad;
        [Static]
        [Export("valueWithMGLCoordinateQuad:")]
        NSValue ValueWithMGLCoordinateQuad(MGLCoordinateQuad quad);

        // -(MGLCoordinateQuad)MGLCoordinateQuadValue;
        [Export("MGLCoordinateQuadValue")]
        MGLCoordinateQuad MGLCoordinateQuadValue();

        // +(NSValue * _Nonnull)valueWithMGLOfflinePackProgress:(MGLOfflinePackProgress)progress;
        [Static]
        [Export("valueWithMGLOfflinePackProgress:")]
        NSValue ValueWithMGLOfflinePackProgress(MGLOfflinePackProgress progress);

        // @property (readonly) MGLOfflinePackProgress MGLOfflinePackProgressValue;
        [Export("MGLOfflinePackProgressValue")]
        MGLOfflinePackProgress MGLOfflinePackProgressValue();

        // +(NSValue * _Nonnull)valueWithMGLTransition:(MGLTransition)transition;
        [Static]
        [Export("valueWithMGLTransition:")]
        NSValue ValueWithMGLTransition(MGLTransition transition);

        // @property (readonly) MGLTransition MGLTransitionValue;
        [Export("MGLTransitionValue")]
        MGLTransition MGLTransitionValue();

        // +(instancetype _Nonnull)valueWithMGLSphericalPosition:(MGLSphericalPosition)lightPosition;
        [Static]
        [Export("valueWithMGLSphericalPosition:")]
        NSValue ValueWithMGLSphericalPosition(MGLSphericalPosition lightPosition);

        // @property (readonly) MGLSphericalPosition MGLSphericalPositionValue;
        [Export("MGLSphericalPositionValue")]
        MGLSphericalPosition MGLSphericalPositionValue();

        // +(NSValue * _Nonnull)valueWithMGLLightAnchor:(MGLLightAnchor)lightAnchor;
        [Static]
        [Export("valueWithMGLLightAnchor:")]
        NSValue ValueWithMGLLightAnchor(MGLLightAnchor lightAnchor);

        // @property (readonly) MGLLightAnchor MGLLightAnchorValue;
        [Export("MGLLightAnchorValue")]
        MGLLightAnchor MGLLightAnchorValue();
    }

    [Static]
    partial interface MGLExpressionInterpolationMode
    {
        // extern const MGLExpressionInterpolationMode _Nonnull MGLExpressionInterpolationModeLinear __attribute__((visibility("default")));
        [Field("MGLExpressionInterpolationModeLinear", "__Internal")]
        NSString Linear { get; }

        // extern const MGLExpressionInterpolationMode _Nonnull MGLExpressionInterpolationModeExponential __attribute__((visibility("default")));
        [Field("MGLExpressionInterpolationModeExponential", "__Internal")]
        NSString Exponential { get; }

        // extern const MGLExpressionInterpolationMode _Nonnull MGLExpressionInterpolationModeCubicBezier __attribute__((visibility("default")));
        [Field("MGLExpressionInterpolationModeCubicBezier", "__Internal")]
        NSString CubicBezier { get; }
    }

    // @interface MGLAdditions (NSExpression)
    [Category]
    [BaseType(typeof(NSExpression))]
    interface NSExpression_MGLAdditions
    {
        // @property (readonly, nonatomic, class) NSExpression * _Nonnull zoomLevelVariableExpression;
        [Static]
        [Export("zoomLevelVariableExpression")]
        NSExpression ZoomLevelVariableExpression { get; }

        // @property (readonly, nonatomic, class) NSExpression * _Nonnull heatmapDensityVariableExpression;
        [Static]
        [Export("heatmapDensityVariableExpression")]
        NSExpression HeatmapDensityVariableExpression { get; }

        // @property (readonly, nonatomic, class) NSExpression * _Nonnull geometryTypeVariableExpression;
        [Static]
        [Export("geometryTypeVariableExpression")]
        NSExpression GeometryTypeVariableExpression { get; }

        // @property (readonly, nonatomic, class) NSExpression * _Nonnull featureIdentifierVariableExpression;
        [Static]
        [Export("featureIdentifierVariableExpression")]
        NSExpression FeatureIdentifierVariableExpression { get; }

        // @property (readonly, nonatomic, class) NSExpression * _Nonnull featureAttributesVariableExpression;
        [Static]
        [Export("featureAttributesVariableExpression")]
        NSExpression FeatureAttributesVariableExpression { get; }

        // @property (readonly, nonatomic, class) NSExpression * _Nonnull featurePropertiesVariableExpression __attribute__((deprecated("Use -featureAttributesVariableExpression.")));
        [Static]
        [Export("featurePropertiesVariableExpression")]
        NSExpression FeaturePropertiesVariableExpression { get; }

        // +(instancetype _Nonnull)mgl_expressionForConditional:(NSPredicate * _Nonnull)conditionPredicate trueExpression:(NSExpression * _Nonnull)trueExpression falseExpresssion:(NSExpression * _Nonnull)falseExpression;
        [Static]
        [Export("mgl_expressionForConditional:trueExpression:falseExpresssion:")]
        NSExpression Mgl_expressionForConditional(NSPredicate conditionPredicate, NSExpression trueExpression, NSExpression falseExpression);

        // +(instancetype _Nonnull)mgl_expressionForSteppingExpression:(NSExpression * _Nonnull)steppingExpression fromExpression:(NSExpression * _Nonnull)minimumExpression stops:(NSExpression * _Nonnull)stops;
        [Static]
        [Export("mgl_expressionForSteppingExpression:fromExpression:stops:")]
        NSExpression Mgl_expressionForSteppingExpression(NSExpression steppingExpression, NSExpression minimumExpression, NSExpression stops);

        // +(instancetype _Nonnull)mgl_expressionForInterpolatingExpression:(NSExpression * _Nonnull)inputExpression withCurveType:(MGLExpressionInterpolationMode _Nonnull)curveType parameters:(NSExpression * _Nullable)parameters stops:(NSExpression * _Nonnull)stops;
        [Static]
        [Export("mgl_expressionForInterpolatingExpression:withCurveType:parameters:stops:")]
        NSExpression Mgl_expressionForInterpolatingExpression(NSExpression inputExpression, string curveType, [NullAllowed] NSExpression parameters, NSExpression stops);

        // +(instancetype _Nonnull)mgl_expressionForMatchingExpression:(NSExpression * _Nonnull)inputExpression inDictionary:(NSDictionary<NSExpression *,NSExpression *> * _Nonnull)matchedExpressions defaultExpression:(NSExpression * _Nonnull)defaultExpression;
        [Static]
        [Export("mgl_expressionForMatchingExpression:inDictionary:defaultExpression:")]
        NSExpression Mgl_expressionForMatchingExpression(NSExpression inputExpression, NSDictionary<NSExpression, NSExpression> matchedExpressions, NSExpression defaultExpression);

        // -(instancetype _Nonnull)mgl_expressionByAppendingExpression:(NSExpression * _Nonnull)expression;
        [Export("mgl_expressionByAppendingExpression:")]
        NSExpression Mgl_expressionByAppendingExpression(NSExpression expression);

        // +(instancetype _Nonnull)expressionWithMGLJSONObject:(id _Nonnull)object;
        [Static]
        [Export("expressionWithMGLJSONObject:")]
        NSExpression ExpressionWithMGLJSONObject(NSObject @object);

        // @property (readonly, nonatomic) id _Nonnull mgl_jsonExpressionObject;
        [Export("mgl_jsonExpressionObject")]
        NSObject Mgl_jsonExpressionObject();

        // -(NSExpression * _Nonnull)mgl_expressionLocalizedIntoLocale:(NSLocale * _Nullable)locale;
        [Export("mgl_expressionLocalizedIntoLocale:")]
        NSExpression Mgl_expressionLocalizedIntoLocale([NullAllowed] NSLocale locale);
    }

    // @interface MGLAdditions (NSPredicate)
    [Category]
    [BaseType(typeof(NSPredicate))]
    interface NSPredicate_MGLAdditions
    {
        // +(instancetype _Nonnull)predicateWithMGLJSONObject:(id _Nonnull)object;
        [Static]
        [Export("predicateWithMGLJSONObject:")]
        NSPredicate PredicateWithMGLJSONObject(NSObject @object);

        // @property (readonly, nonatomic) id _Nonnull mgl_jsonExpressionObject;
        [Export("mgl_jsonExpressionObject")]
        NSObject Mgl_jsonExpressionObject();
    }
}