// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

@class MBMCoordinateBounds;

/** A coordinate bounds and zoom. */
NS_SWIFT_NAME(CoordinateBoundsZoom)
__attribute__((visibility ("default")))
@interface MBMCoordinateBoundsZoom : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithBounds:(nonnull MBMCoordinateBounds *)bounds
                                  zoom:(double)zoom;

/** The latitude and longitude bounds. */
@property (nonatomic, readonly, nonnull) MBMCoordinateBounds *bounds;

/** Zoom. */
@property (nonatomic, readonly) double zoom;


@end
