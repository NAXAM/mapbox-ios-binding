// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCoreMaps/MBMViewAnnotationAnchor.h>
@class MBXGeometry;

/** Various options needed for displaying view annotation. */
NS_SWIFT_NAME(ViewAnnotationOptions)
__attribute__((visibility ("default")))
@interface MBMViewAnnotationOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithGeometry:(nullable MBXGeometry *)geometry
                     associatedFeatureId:(nullable NSString *)associatedFeatureId
                                   width:(nullable NSNumber *)width
                                  height:(nullable NSNumber *)height
                            allowOverlap:(nullable NSNumber *)allowOverlap
                                 visible:(nullable NSNumber *)visible
                                  anchor:(nullable NSNumber *)anchor
                                 offsetX:(nullable NSNumber *)offsetX
                                 offsetY:(nullable NSNumber *)offsetY
                                selected:(nullable NSNumber *)selected NS_REFINED_FOR_SWIFT;

/**
 * Geometry the view annotation is bound to. Currently only support 'point' geometry type.
 * Note: geometry must be set when adding a new view annotation, otherwise an operation error will be returned from the call that is associated to this option.
 */
@property (nonatomic, readonly, nullable) MBXGeometry *geometry NS_REFINED_FOR_SWIFT;

/**
 * Optional style symbol id connected to given view annotation.
 *
 * View annotation's visibility behaviour becomes tied to feature visibility where feature could represent an icon or a text label.
 * E.g. if the bounded symbol is not visible view annotation also becomes not visible.
 *
 * Note: Invalid associatedFeatureId (meaning no actual symbol has such feature id) will lead to the cooresponding annotation to be invisible.
 */
@property (nonatomic, readonly, nullable, copy) NSString *associatedFeatureId NS_REFINED_FOR_SWIFT;

/** View annotation width in `platform pixels`. */
@property (nonatomic, readonly, nullable) NSNumber *width NS_REFINED_FOR_SWIFT;

/** View annotation height in `platform pixels`. */
@property (nonatomic, readonly, nullable) NSNumber *height NS_REFINED_FOR_SWIFT;

/**
 * If true, the annotation will be visible even if it collides with other previously drawn annotations.
 * If allowOverlap is null, default value `false` will be applied.
 */
@property (nonatomic, readonly, nullable) NSNumber *allowOverlap NS_REFINED_FOR_SWIFT;

/**
 * Specifies if this view annotation is visible or not.
 *
 * Note: For Android and iOS platforms, if this property is not specified explicitly when creating / updating view annotation, visibility will be
 * handled automatically based on actual Android or iOS view's visibility e.g. if actual view is set to be not visible - Android / iOS part
 * will automatically update view annotation to have `visible = false`.
 *
 * If visible is null, default value `true` will be applied.
 */
@property (nonatomic, readonly, nullable) NSNumber *visible NS_REFINED_FOR_SWIFT;

/**
 * Anchor describing where the view annotation will be located relatively to given geometry.
 * If anchor is null, default value `CENTER` will be applied.
 */
@property (nonatomic, readonly, nullable) NSNumber *anchor NS_REFINED_FOR_SWIFT;

/**
 * Extra X offset in `platform pixels`.
 * Providing positive value moves view annotation to the right while negative moves it to the left.
 */
@property (nonatomic, readonly, nullable) NSNumber *offsetX NS_REFINED_FOR_SWIFT;

/**
 * Extra Y offset in `platform pixels`.
 * Providing positive value moves view annotation to the top while negative moves it to the bottom.
 */
@property (nonatomic, readonly, nullable) NSNumber *offsetY NS_REFINED_FOR_SWIFT;

/**
 * Specifies if this view annotation is selected meaning it should be placed on top of others.
 * If selected in null, default value `false` will be applied.
 */
@property (nonatomic, readonly, nullable) NSNumber *selected NS_REFINED_FOR_SWIFT;


@end
