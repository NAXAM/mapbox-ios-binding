// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCoreMaps/MBMOfflineRegionDownloadState.h>

/**
 * A region's status includes its active/inactive state as well as counts
 * of the number of resources that have completed downloading, their total
 * size in bytes, and the total number of resources that are required.
 *
 * Note that the total required size in bytes is not currently available. A
 * future API release may provide an estimate of this number.
 */
NS_SWIFT_NAME(OfflineRegionStatus)
__attribute__((visibility ("default")))
__attribute__((deprecated))
@interface MBMOfflineRegionStatus : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithDownloadState:(MBMOfflineRegionDownloadState)downloadState
                       completedResourceCount:(uint64_t)completedResourceCount
                        completedResourceSize:(uint64_t)completedResourceSize
                           completedTileCount:(uint64_t)completedTileCount
                            requiredTileCount:(uint64_t)requiredTileCount
                            completedTileSize:(uint64_t)completedTileSize
                        requiredResourceCount:(uint64_t)requiredResourceCount
               requiredResourceCountIsPrecise:(BOOL)requiredResourceCountIsPrecise;

/** Describes the download state. */
@property (nonatomic, readonly) MBMOfflineRegionDownloadState downloadState;

/**
 * The number of resources that have been fully downloaded and are ready for
 * offline access.
 */
@property (nonatomic, readonly) uint64_t completedResourceCount;

/**
 * The cumulative size, in bytes, of all resources (inclusive of tiles) that have
 * been fully downloaded.
 */
@property (nonatomic, readonly) uint64_t completedResourceSize;

/**
 * The number of tiles that are known to be required for this region. This is a
 * subset of `completedResourceCount`.
 */
@property (nonatomic, readonly) uint64_t completedTileCount;

/** The number of tiles that are known to be required for this region. */
@property (nonatomic, readonly) uint64_t requiredTileCount;

/**
 * The cumulative size, in bytes, of all tiles that have been fully downloaded.
 * This is a subset of `completedResourceSize`.
 */
@property (nonatomic, readonly) uint64_t completedTileSize;

/**
 * The number of resources that are known to be required for this region. See the
 * documentation for `requiredResourceCountIsPrecise` for an important caveat
 * about this number.
 */
@property (nonatomic, readonly) uint64_t requiredResourceCount;

/**
 * This property is true when the value of requiredResourceCount is a precise
 * count of the number of required resources, and false when it is merely a lower
 * bound.
 *
 * Specifically, it is false during early phases of an offline download. Once
 * style and tile sources have been downloaded, it is possible to calculate the
 * precise number of required resources, at which point it is set to true.
 */
@property (nonatomic, readonly, getter=isRequiredResourceCountIsPrecise) BOOL requiredResourceCountIsPrecise;


@end
