// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

@class MBMOfflineRegionGeometryDefinition;
@class MBMOfflineRegionTilePyramidDefinition;
@class MBMResourceOptions;

/**
 * The `offline region manager` that manages offline packs. All of the class’s instance methods are asynchronous
 * reflecting the fact that offline resources are stored in a database. The offline manager maintains a canonical
 * collection of offline packs.
 */
NS_SWIFT_NAME(OfflineRegionManager)
__attribute__((visibility ("default")))
__attribute__((deprecated))
@interface MBMOfflineRegionManager : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

/**
 * Construct a new offline manager.
 *
 * @param resourceOptions the `resource options` to manage.
 */
- (nonnull instancetype)initWithResourceOptions:(nonnull MBMResourceOptions *)resourceOptions;

/**
 * Sets the maximum number of Mapbox-hosted tiles that may be downloaded and stored on the current device.
 *
 * By default, the limit is set to 6,000.
 * Once this limit is reached, `OfflineRegionObserver.mapboxTileCountLimitExceeded()`
 * fires every additional attempt to download additional tiles until already downloaded tiles are removed
 * by calling `OfflineRegion.purge()` API.
 *
 * @param limit the maximum number of tiles allowed to be downloaded
 */
- (void)setOfflineMapboxTileCountLimitForLimit:(uint64_t)limit;

@end
