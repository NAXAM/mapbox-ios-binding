// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/**
 * The `transition options` controls timing for the interpolation between a transitionable style
 * property's previous value and new value. These can be used to define the style default property
 * transition behavior. Also, any transitionable style property may also have its own `-transition`
 * property that defines specific transition timing for that specific layer property, overriding
 * the global transition values.
 */
NS_SWIFT_NAME(TransitionOptions)
__attribute__((visibility ("default")))
@interface MBMTransitionOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithDuration:(nullable NSNumber *)duration
                                   delay:(nullable NSNumber *)delay
              enablePlacementTransitions:(nullable NSNumber *)enablePlacementTransitions NS_REFINED_FOR_SWIFT;

/** Time allotted for transitions to complete. Units in milliseconds. Defaults to `300.0`. */
@property (nonatomic, readonly, nullable) NSNumber *duration NS_REFINED_FOR_SWIFT;

/** Length of time before a transition begins. Units in milliseconds. Defaults to `0.0`. */
@property (nonatomic, readonly, nullable) NSNumber *delay NS_REFINED_FOR_SWIFT;

/** Whether the fade in/out symbol placement transition is enabled. Defaults to `true`. */
@property (nonatomic, readonly, nullable) NSNumber *enablePlacementTransitions NS_REFINED_FOR_SWIFT;


@end
