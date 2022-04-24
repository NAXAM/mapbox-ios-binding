// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Describes tile store usage modes. */
// NOLINTNEXTLINE(modernize-use-using)
typedef NS_ENUM(NSInteger, MBMTileStoreUsageMode)
{
    /**
     * Tile store usage is disabled.
     *
     * The implementation skips checking tile store when requesting a tile.
     */
    MBMTileStoreUsageModeDisabled,
    /**
     * Tile store enabled for accessing loaded tile packs.
     *
     * The implementation first checks tile store when requesting a tile.
     * If a tile pack is already loaded, the tile will be extracted and returned. Otherwise, the implementation
     * falls back to requesting the individual tile and storing it in the disk cache.
     */
    MBMTileStoreUsageModeReadOnly,
    /**
     * Tile store enabled for accessing local tile packs and for loading new tile packs from server.
     *
     * All tile requests are converted to tile pack requests, i.e.
     * the tile pack that includes the request tile will be loaded, and the tile extracted
     * from it. In this mode, no individual tile requests will be made.
     *
     * This mode can be useful if the map trajectory is predefined and the user cannot pan
     * freely (e.g. navigation use cases), so that there is a good chance tile packs are already loaded
     * in the vicinity of the user.
     *
     * If users can pan freely, this mode is not recommended. Otherwise, panning
     * will download tile packs instead of using individual tiles. Note that this means that we could first
     * download an individual tile, and then a tile pack that also includes this tile. The individual tile in
     * the disk cache won’t be used as long as the up-to-date tile pack exists in the cache.
     */
    MBMTileStoreUsageModeReadAndUpdate
} NS_SWIFT_NAME(TileStoreUsageMode);

NSString* MBMTileStoreUsageModeToString(MBMTileStoreUsageMode tile_store_usage_mode);
