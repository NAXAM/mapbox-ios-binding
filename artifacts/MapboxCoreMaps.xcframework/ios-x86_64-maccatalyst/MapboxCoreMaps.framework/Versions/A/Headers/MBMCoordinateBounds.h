// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <CoreLocation/CoreLocation.h>

/** A rectangular area as measured on a two-dimensional map projection. */
NS_SWIFT_NAME(CoordinateBounds)
__attribute__((visibility ("default")))
@interface MBMCoordinateBounds : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithSouthwest:(CLLocationCoordinate2D)southwest
                                northeast:(CLLocationCoordinate2D)northeast;

- (nonnull instancetype)initWithSouthwest:(CLLocationCoordinate2D)southwest
                                northeast:(CLLocationCoordinate2D)northeast
                           infiniteBounds:(BOOL)infiniteBounds;

/**
 * Returns a bounds covering the entire (unwrapped) world.
 *
 * @return The newly constructed record.
 */
+ (nonnull MBMCoordinateBounds *)world __attribute((ns_returns_retained)) NS_REFINED_FOR_SWIFT;
/**
 * Returns the bounds consisting of the single point.
 *
 * @param point The coordinate of all corners of the bounds.
 *
 * @return The newly constructed singleton bounds record.
 */
+ (nonnull MBMCoordinateBounds *)singletonForPoint:(CLLocationCoordinate2D)point __attribute((ns_returns_retained)) NS_REFINED_FOR_SWIFT;
/**
 * Returns the convex hull of two points; the smallest bounds that contains both.
 *
 * @param a The first of the two coordinates to fit.
 * @param b The second of the two coordinates to fit.
 *
 * @return The newly constructed record.
 */
+ (nonnull MBMCoordinateBounds *)hullForA:(CLLocationCoordinate2D)a
                                        b:(CLLocationCoordinate2D)b __attribute((ns_returns_retained)) NS_REFINED_FOR_SWIFT;
/**
 * Returns whether the bounds are valid or not.
 *
 * @return `true` if `southwest` is the same or south-west of `northeast`, `false` otherwise.
 */
- (BOOL)isValid NS_REFINED_FOR_SWIFT;
/**
 * Returns the southern latitude of the bounds.
 *
 * @return The southern latitude of the bounds.
 */
- (double)south NS_REFINED_FOR_SWIFT;
/**
 * Returns the western longitude of the bounds.
 *
 * @return The western longitude of the bounds.
 */
- (double)west NS_REFINED_FOR_SWIFT;
/**
 * Returns the northern latitude of the bounds.
 *
 * @return The northern latitude of the bounds.
 */
- (double)north NS_REFINED_FOR_SWIFT;
/**
 * Returns the eastern longitude of the bounds.
 *
 * @return The eastern longitude of the bounds.
 */
- (double)east NS_REFINED_FOR_SWIFT;
/**
 * Returns the southeast coordinate of the bounds.
 *
 * @return The southeast coordinate of the bounds.
 */
- (CLLocationCoordinate2D)southeast NS_REFINED_FOR_SWIFT;
/**
 * Returns the northwest coordinate of the bounds.
 *
 * @return The northwest coordinate of the bounds.
 */
- (CLLocationCoordinate2D)northwest NS_REFINED_FOR_SWIFT;
/**
 * Returns the center coordinate of the bounds.
 *
 * @return The center coordinate of the bounds.
 */
- (CLLocationCoordinate2D)center NS_REFINED_FOR_SWIFT;
/**
 * Constrains `point` against the bounds.
 *
 * @param point The coordinate to be constrained.
 */
- (CLLocationCoordinate2D)constrainForPoint:(CLLocationCoordinate2D)point;
/**
 * Returns whether the bounds are empty or not.
 *
 * @return `true` if the bounds are empty, `false` otherwise.
 */
- (BOOL)isEmpty NS_REFINED_FOR_SWIFT;
/**
 * Returns whether the bounds are infinite or bounded.
 *
 * @return `true` if the bounds are not infinite, `false` otherwise.
 */
- (BOOL)isBounded NS_REFINED_FOR_SWIFT;
/**
 * Returns whether the bounds cross the date line or not.
 *
 * @return `true` if the bounds cross the antimeridian, `false` otherwise.
 */
- (BOOL)crossesAntimeridian NS_REFINED_FOR_SWIFT;
/**
 * Returns whether the bounds contains `point` or not.
 *
 * @param point The coordinate to be checked against the bounds.
 * @param wrappedCoordinates Whether to wrap the coordinate or not.
 *
 * @return `true` if the bounds contains `point`, `false` otherwise.
 */
- (BOOL)containsForPoint:(CLLocationCoordinate2D)point
      wrappedCoordinates:(BOOL)wrappedCoordinates;
/**
 * Returns whether the bounds contains `area` or not.
 *
 * @param area The area to be checked against the bounds.
 * @param wrappedCoordinates Whether to wrap the coordinate or not.
 *
 * @return `true` if the bounds contains `area`, `false` otherwise.
 */
- (BOOL)containsForArea:(nonnull MBMCoordinateBounds *)area
     wrappedCoordinates:(BOOL)wrappedCoordinates;
/**
 * Returns whether the bounds contains `latitude` or not.
 *
 * @param latitude The latitude to be checked against the bounds.
 *
 * @return `true` if the bounds contains `latitude`, `false` otherwise.
 */
- (BOOL)containsLatitudeForLatitude:(double)latitude;
/**
 * Returns whether the bounds contains `longitude` or not.
 *
 * @param longitude The longitude to be checked against the bounds.
 *
 * @return `true` if the bounds contains `longitude`, `false` otherwise.
 */
- (BOOL)containsLongitudeForLongitude:(double)longitude;
/**
 * Returns the absolute distance, in degrees, between the north and
 * south boundaries of these bounds.
 *
 * @return Span distance
 */
- (double)latitudeSpan NS_REFINED_FOR_SWIFT;
/**
 * Returns the absolute distance, in degrees, between the west and
 * east boundaries of these bounds.
 *
 * @return Span distance
 */
- (double)longitudeSpan NS_REFINED_FOR_SWIFT;
/**
 * Returns whether the bounds intersects `area` or not.
 *
 * @param area The area to be checked against the bounds.
 * @param wrappedCoordinates Whether to wrap the coordinate or not.
 *
 * @return `true` if the bounds intersects `area`, `false` otherwise.
 */
- (BOOL)intersectsForArea:(nonnull MBMCoordinateBounds *)area
       wrappedCoordinates:(BOOL)wrappedCoordinates;
/**
 * Extends these bounds to include `point`.
 *
 * @param point The coordinate to be included.
 *
 * @return The extended bounds.
 */
- (nonnull MBMCoordinateBounds *)extendForPoint:(CLLocationCoordinate2D)point __attribute((ns_returns_retained));
/**
 * Extends these bounds to include `area`.
 *
 * @param area The bounds to be included.
 *
 * @return The extended bounds.
 */
- (nonnull MBMCoordinateBounds *)extendForArea:(nonnull MBMCoordinateBounds *)area __attribute((ns_returns_retained));

/**
 * Coordinate at the southwest corner.
 * Note: setting this field with invalid values (infinite, NaN) will crash the application.
 */
@property (nonatomic, readonly) CLLocationCoordinate2D southwest;

/**
 * Coordinate at the northeast corner.
 * Note: setting this field with invalid values (infinite, NaN) will crash the application.
 */
@property (nonatomic, readonly) CLLocationCoordinate2D northeast;

/**
 * If set to `true`, an infinite (unconstrained) bounds covering the world coordinates would be used.
 * Coordinates provided in `southwest` and `northeast` fields would be omitted and have no effect.
 */
@property (nonatomic, readonly, getter=isInfiniteBounds) BOOL infiniteBounds;


@end
