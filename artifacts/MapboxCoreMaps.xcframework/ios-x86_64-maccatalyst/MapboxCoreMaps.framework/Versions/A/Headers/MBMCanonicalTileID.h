// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Represents a tile coordinate. */
NS_SWIFT_NAME(CanonicalTileID)
__attribute__((visibility ("default")))
@interface MBMCanonicalTileID : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithZ:(uint8_t)z
                                x:(uint32_t)x
                                y:(uint32_t)y;

/** The z value of the coordinate (zoom-level). */
@property (nonatomic, readonly) uint8_t z;

/** The x value of the coordinate. */
@property (nonatomic, readonly) uint32_t x;

/** The y value of the coordinate. */
@property (nonatomic, readonly) uint32_t y;


@end
