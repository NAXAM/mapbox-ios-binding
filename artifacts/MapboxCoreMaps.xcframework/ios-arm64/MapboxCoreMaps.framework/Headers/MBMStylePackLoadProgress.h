// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/**
 * A `style pack load` progress includes information about
 * the number of resources that have completed downloading
 * and the total number of resources that are required.
 */
NS_SWIFT_NAME(StylePackLoadProgress)
__attribute__((visibility ("default")))
@interface MBMStylePackLoadProgress : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithCompletedResourceCount:(uint64_t)completedResourceCount
                                 completedResourceSize:(uint64_t)completedResourceSize
                                  erroredResourceCount:(uint64_t)erroredResourceCount
                                 requiredResourceCount:(uint64_t)requiredResourceCount
                                   loadedResourceCount:(uint64_t)loadedResourceCount
                                    loadedResourceSize:(uint64_t)loadedResourceSize;

/** The number of resources that are ready for offline access. */
@property (nonatomic, readonly) uint64_t completedResourceCount;

/** The cumulative size, in bytes, of all resources that are ready for offline access. */
@property (nonatomic, readonly) uint64_t completedResourceSize;

/** The number of resources that have failed to download due to an error. */
@property (nonatomic, readonly) uint64_t erroredResourceCount;

/** The number of resources that are known to be required for this style package. */
@property (nonatomic, readonly) uint64_t requiredResourceCount;

/** The number of resources that have been fully downloaded from the network. */
@property (nonatomic, readonly) uint64_t loadedResourceCount;

/**
 * The cumulative size, in bytes, of all resources that have been fully downloaded
 * from the network.
 */
@property (nonatomic, readonly) uint64_t loadedResourceSize;


@end
