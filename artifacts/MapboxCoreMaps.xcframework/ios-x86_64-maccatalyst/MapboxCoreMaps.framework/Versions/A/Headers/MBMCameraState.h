// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <CoreLocation/CoreLocation.h>

@class MBMEdgeInsets;

/** Describes the viewpoint of a camera. */
NS_SWIFT_NAME(CameraState)
__attribute__((visibility ("default")))
@interface MBMCameraState : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithCenter:(CLLocationCoordinate2D)center
                               padding:(nonnull MBMEdgeInsets *)padding
                                  zoom:(double)zoom
                               bearing:(double)bearing
                                 pitch:(double)pitch;

/** Coordinate at the center of the camera. */
@property (nonatomic, readonly) CLLocationCoordinate2D center;

/**
 * Padding around the interior of the view that affects the frame of
 * reference for `center`.
 */
@property (nonatomic, readonly, nonnull) MBMEdgeInsets *padding;

/**
 * Zero-based zoom level. Constrained to the minimum and maximum zoom
 * levels.
 */
@property (nonatomic, readonly) double zoom;

/** Bearing, measured in degrees from true north. Wrapped to [0, 360). */
@property (nonatomic, readonly) double bearing;

/** Pitch toward the horizon measured in degrees. */
@property (nonatomic, readonly) double pitch;


@end
