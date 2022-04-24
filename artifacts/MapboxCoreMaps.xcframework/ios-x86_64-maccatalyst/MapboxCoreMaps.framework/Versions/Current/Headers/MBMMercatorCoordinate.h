// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Describes a point on the map in Mercator projection. */
NS_SWIFT_NAME(MercatorCoordinate)
__attribute__((visibility ("default")))
@interface MBMMercatorCoordinate : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithX:(double)x
                                y:(double)y;

/** A value representing the x position of this coordinate. */
@property (nonatomic, readonly) double x;

/** A value representing the y position of this coordinate. */
@property (nonatomic, readonly) double y;


- (BOOL)isEqualToMercatorCoordinate:(nonnull MBMMercatorCoordinate *)other;

@end
