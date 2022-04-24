// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCoreMaps/MBMCancelTileFunctionCallback.h>
#import <MapboxCoreMaps/MBMFetchTileFunctionCallback.h>

@class MBMTileOptions;

/** Options for custom geometry source. */
NS_SWIFT_NAME(CustomGeometrySourceOptions)
__attribute__((visibility ("default")))
@interface MBMCustomGeometrySourceOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithFetchTileFunction:(nonnull MBMFetchTileFunctionCallback)fetchTileFunction
                               cancelTileFunction:(nonnull MBMCancelTileFunctionCallback)cancelTileFunction
                                      tileOptions:(nonnull MBMTileOptions *)tileOptions;

- (nonnull instancetype)initWithFetchTileFunction:(nonnull MBMFetchTileFunctionCallback)fetchTileFunction
                               cancelTileFunction:(nonnull MBMCancelTileFunctionCallback)cancelTileFunction
                                          minZoom:(uint8_t)minZoom
                                          maxZoom:(uint8_t)maxZoom
                                      tileOptions:(nonnull MBMTileOptions *)tileOptions;

/** The callback that provides data for a tile. */
@property (nonatomic, readonly, nonnull) MBMFetchTileFunctionCallback fetchTileFunction;

/** The callback that cancels a tile. */
@property (nonatomic, readonly, nonnull) MBMCancelTileFunctionCallback cancelTileFunction;

/**
 * A minimum zoom level, at which to create vector tiles.
 *
 * The default value is `0`.
 */
@property (nonatomic, readonly) uint8_t minZoom;

/**
 * A maximum zoom level, at which to create vector tiles.
 *
 * A higher maximum zoom level provides greater details at high map zoom levels.
 *
 * The default value is `18`.
 */
@property (nonatomic, readonly) uint8_t maxZoom;

/** Tile options. */
@property (nonatomic, readonly, nonnull) MBMTileOptions *tileOptions;


@end
