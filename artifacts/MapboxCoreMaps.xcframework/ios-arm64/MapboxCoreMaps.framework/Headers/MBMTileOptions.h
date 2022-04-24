// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Options for custom geometry tiles. */
NS_SWIFT_NAME(TileOptions)
__attribute__((visibility ("default")))
@interface MBMTileOptions : NSObject

- (nonnull instancetype)init;

- (nonnull instancetype)initWithTolerance:(double)tolerance
                                 tileSize:(uint16_t)tileSize
                                   buffer:(uint16_t)buffer
                                     clip:(BOOL)clip
                                     wrap:(BOOL)wrap;

/** Douglas-Peucker simplification tolerance (higher means simpler geometries and faster performance). Default is `0.375`. */
@property (nonatomic, readonly) double tolerance;

/** Size of the tiles. Tile size must be a power of 2. Default is `512`. */
@property (nonatomic, readonly) uint16_t tileSize;

/** Tile buffer size on each side (measured in 1/512ths of a tile; higher means fewer rendering artifacts near tile edges but slower performance). Default is `128`. */
@property (nonatomic, readonly) uint16_t buffer;

/** If the data includes geometry outside the tile boundaries, setting this to true clips the geometry to the tile boundaries. Default is `false`; */
@property (nonatomic, readonly, getter=isClip) BOOL clip;

/** If the data includes wrapped coordinates, setting this to true unwraps the coordinates. Default is `false`; */
@property (nonatomic, readonly, getter=isWrap) BOOL wrap;


@end
