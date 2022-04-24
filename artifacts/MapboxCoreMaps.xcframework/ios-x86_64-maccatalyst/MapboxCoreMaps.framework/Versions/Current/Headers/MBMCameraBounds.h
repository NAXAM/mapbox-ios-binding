// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

@class MBMCoordinateBounds;

/** Holds information about `camera bounds`. */
NS_SWIFT_NAME(CameraBounds)
__attribute__((visibility ("default")))
@interface MBMCameraBounds : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithBounds:(nonnull MBMCoordinateBounds *)bounds
                               maxZoom:(double)maxZoom
                               minZoom:(double)minZoom
                              maxPitch:(double)maxPitch
                              minPitch:(double)minPitch;

/** The latitude and longitude bounds to which the camera center are constrained. */
@property (nonatomic, readonly, nonnull) MBMCoordinateBounds *bounds;

/** The maximum zoom level, in Mapbox zoom levels 0-25.5. At low zoom levels, a small set of map tiles covers a large geographical area. At higher zoom levels, a larger number of tiles cover a smaller geographical area. */
@property (nonatomic, readonly) double maxZoom;

/** The minimum zoom level, in Mapbox zoom levels 0-25.5. */
@property (nonatomic, readonly) double minZoom;

/** The maximum allowed pitch value in degrees. */
@property (nonatomic, readonly) double maxPitch;

/** The minimum allowed pitch value in degrees. */
@property (nonatomic, readonly) double minPitch;


@end
