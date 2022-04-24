// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Parameters that defines behavior of the render cache. */
NS_SWIFT_NAME(RenderCacheOptions)
__attribute__((visibility ("default")))
@interface MBMRenderCacheOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithSize:(nullable NSNumber *)size NS_REFINED_FOR_SWIFT;

/**
 * Maximum size allocated for the render cache in megabytes. Setting the value to zero will effectively disable the feature.
 *
 * Recommended starting values for the cache sizes are 64 and 128 for devices with pixel ratio 1.0 and > 1.0 respectively.
 */
@property (nonatomic, readonly, nullable) NSNumber *size NS_REFINED_FOR_SWIFT;


@end
