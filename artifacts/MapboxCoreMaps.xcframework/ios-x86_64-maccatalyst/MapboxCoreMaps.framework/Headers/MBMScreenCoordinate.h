// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/**
 * Describes the coordinate on the screen, measured from top to bottom and from left to right.
 * Note: the `map` uses screen coordinate units measured in `platform pixels`.
 */
NS_SWIFT_NAME(ScreenCoordinate)
__attribute__((visibility ("default")))
@interface MBMScreenCoordinate : NSObject

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


- (BOOL)isEqualToScreenCoordinate:(nonnull MBMScreenCoordinate *)other;

@end
