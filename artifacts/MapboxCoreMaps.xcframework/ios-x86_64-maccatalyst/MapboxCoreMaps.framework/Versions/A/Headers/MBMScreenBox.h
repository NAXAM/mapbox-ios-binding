// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

@class MBMScreenCoordinate;

/**
 * Describes the coordinate box on the screen, measured in `platform pixels`
 * from top to bottom and from left to right.
 */
NS_SWIFT_NAME(ScreenBox)
__attribute__((visibility ("default")))
@interface MBMScreenBox : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithMin:(nonnull MBMScreenCoordinate *)min
                                max:(nonnull MBMScreenCoordinate *)max;

/** The screen coordinate close to the top left corner of the screen. */
@property (nonatomic, readonly, nonnull) MBMScreenCoordinate *min;

/** The screen coordinate close to the bottom right corner of the screen. */
@property (nonatomic, readonly, nonnull) MBMScreenCoordinate *max;


- (BOOL)isEqualToScreenBox:(nonnull MBMScreenBox *)other;

@end
