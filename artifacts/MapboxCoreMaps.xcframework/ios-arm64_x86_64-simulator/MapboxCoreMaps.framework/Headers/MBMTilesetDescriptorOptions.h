// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

@class MBMStylePackLoadOptions;

/** Describes the style package load option values. */
NS_SWIFT_NAME(TilesetDescriptorOptions)
__attribute__((visibility ("default")))
@interface MBMTilesetDescriptorOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithStyleURI:(nonnull NSString *)styleURI
                                 minZoom:(uint8_t)minZoom
                                 maxZoom:(uint8_t)maxZoom
                        stylePackOptions:(nullable MBMStylePackLoadOptions *)stylePackOptions;

- (nonnull instancetype)initWithStyleURI:(nonnull NSString *)styleURI
                                 minZoom:(uint8_t)minZoom
                                 maxZoom:(uint8_t)maxZoom
                              pixelRatio:(float)pixelRatio
                        stylePackOptions:(nullable MBMStylePackLoadOptions *)stylePackOptions;

/** The style associated with the tileset descriptor */
@property (nonatomic, readonly, nonnull, copy) NSString *styleURI;

/**
 * Minimum zoom level for the tile package.
 *
 * Note: the implementation loads and stores the loaded tiles
 * in batches, each batch has a pre-defined zoom range and it contains
 * all child tiles within the range.
 * The currently used tile batches zoom ranges are:
 * - Global coverage: 0 - 5
 * - Regional information: 6 - 10
 * - Local information: 11 - 14
 * - Streets detail: 15 - 16
 *
 * Internally, the implementation maps the given tile pack zoom range
 * and geometry to a set of pre-defined batches to load, therefore
 * it is highly recommended to choose the `minZoom` and `maxZoom` values
 * in accordance with the tile batches zoom ranges (see the list above).
 */
@property (nonatomic, readonly) uint8_t minZoom;

/**
 * Maximum zoom level for the tile package.
 *
 * maxZoom value cannot exceed the maximum allowed tile batch zoom value,
 * @see `minZoom`
 */
@property (nonatomic, readonly) uint8_t maxZoom;

/**
 * Pixel ratio to be accounted for when downloading raster tiles.
 *
 * The `pixelRatio` must be ≥ 0 and should typically be 1.0 or 2.0.
 */
@property (nonatomic, readonly) float pixelRatio;

/**
 * Style package load options, associated with the tileset descriptor.
 *
 * If provided, `offline manager` will create a style package while resolving the corresponding
 * tileset descriptor and load all the resources as defined in the provided style package options,
 * i.e. resolving of corresponding the tileset descriptor will be equivalent to calling the `loadStylePack`
 * method of `offline manager`.
 * If not provided, resolving of the corresponding tileset descriptor will not cause creating of a new style
 * package but the loaded resources will be stored in the disk cache.
 */
@property (nonatomic, readonly, nullable) MBMStylePackLoadOptions *stylePackOptions;


@end
