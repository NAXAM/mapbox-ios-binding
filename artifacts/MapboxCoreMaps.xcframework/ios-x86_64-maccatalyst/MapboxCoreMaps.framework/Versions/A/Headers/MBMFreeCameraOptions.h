// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <CoreLocation/CoreLocation.h>

@class MBMVec3;
@class MBMVec4;

/**
 * Various options for accessing physical properties of the underlying camera entity.
 * A direct access to these properties allows more flexible and precise controlling
 * of the camera while also being fully compatible and interchangeable with CameraOptions.
 * All fields are optional.
 */
NS_SWIFT_NAME(FreeCameraOptions)
__attribute__((visibility ("default")))
@interface MBMFreeCameraOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

/**
 * Get the position of the camera in slightly modified web mercator coordinates
 *   - The size of 1 unit is the width of the projected world instead of the "mercator meter".
 *     Coordinate [0, 0, 0] is the north-west corner and [1, 1, 0] is the south-east corner.
 *   - Z coordinate is conformal and must respect minimum and maximum zoom values.
 *   - Zoom is automatically computed from the altitude (z)
 *
 * @return The position if set.
 */
- (nullable MBMVec3 *)getPosition __attribute((ns_returns_retained));
/**
 * Set the position of the camera in slightly modified web mercator coordinates
 *   - The size of 1 unit is the width of the projected world instead of the "mercator meter".
 *     Coordinate [0, 0, 0] is the north-west corner and [1, 1, 0] is the south-east corner.
 *   - Z coordinate is conformal and must respect minimum and maximum zoom values.
 *   - Zoom is automatically computed from the altitude (z)
 *
 * @param position The position to be set.
 */
- (void)setPositionForPosition:(nullable MBMVec3 *)position;
/**
 * Get the orientation of the camera represented as a unit quaternion [x, y, z, w].
 *   The default pose of the camera is such that the forward vector is looking up the -Z axis and
 *   the up vector is aligned with north orientation of the map:
 *     forward: [0, 0, -1]
 *     up:      [0, -1, 0]
 *     right    [1, 0, 0]
 *
 *     With the w value as the real part of the complex number
 *
 * @return The orientation if set.
 */
- (nullable MBMVec4 *)getOrientation __attribute((ns_returns_retained));
/**
 * Set the orientation of the camera represented as a unit quaternion [x, y, z, w].
 *   The default pose of the camera is such that the forward vector is looking up the -Z axis and
 *   the up vector is aligned with north orientation of the map:
 *     forward: [0, 0, -1]
 *     up:      [0, -1, 0]
 *     right    [1, 0, 0]
 *
 *     With the w value as the real part of the complex number
 *
 *   Orientation can be set freely but certain constraints still apply
 *    - Orientation must be representable with only pitch and bearing.
 *    - Pitch has an upper limit
 *
 * @param orientation The orientation to be set.
 *
 */
- (void)setOrientationForOrientation:(nullable MBMVec4 *)orientation;
/**
 * Helper function for setting the mercator position as Lat&Lng and altitude in meters
 *
 * @param location The mercator `coordinate`.
 * @param altitude The altitude in meters.
 */
- (void)setLocationForLocation:(CLLocationCoordinate2D)location
                      altitude:(double)altitude;
/**
 * Helper function for setting orientation of the camera by defining a focus point.
 * Elevation of 0.0 is used and no up vector.
 *
 * @param location The `coordinate` representing focal point.
 */
- (void)lookAtPointForLocation:(CLLocationCoordinate2D)location;
/**
 * Helper function for setting orientation of the camera by defining a focus point.
 * No up vector is used.
 *
 * @param location The `coordinate` representing focal point.
 * @param altitude The altitude in meters of the focal point.
 */
- (void)lookAtPointForLocation:(CLLocationCoordinate2D)location
                      altitude:(double)altitude;
/**
 * Helper function for setting orientation of the camera by defining a focus point.
 *
 * Up vector is required in certain scenarios where bearing can't be deduced from
 * the viewing direction.
 *
 * @param location The `coordinate` representing focal point.
 * @param altitude The altitude in meters of the focal point.
 * @param upVector The up vector.
 */
- (void)lookAtPointForLocation:(CLLocationCoordinate2D)location
                      altitude:(double)altitude
                      upVector:(nonnull MBMVec3 *)upVector;
/**
 * Helper function for setting the orientation of the camera as a pitch and a bearing.
 *
 * @param pitch The pitch in degrees
 * @param bearing The bearing in degrees
 */
- (void)setPitchBearingForPitch:(double)pitch
                        bearing:(double)bearing;

@end
