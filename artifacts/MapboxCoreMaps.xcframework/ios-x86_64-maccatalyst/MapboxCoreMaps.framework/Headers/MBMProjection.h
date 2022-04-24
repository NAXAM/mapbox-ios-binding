// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <CoreLocation/CoreLocation.h>

@class MBMMercatorCoordinate;
@class MBMProjectedMeters;

/** Collection of [Spherical Mercator](http://docs.openlayers.org/library/spherical_mercator.html) projection methods. */
NS_SWIFT_NAME(Projection)
__attribute__((visibility ("default")))
@interface MBMProjection : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

/**
 * Calculate distance spanned by one pixel at the specified latitude
 * and zoom level.
 *
 * @param latitude The latitude for which to return the value.
 * @param zoom The zoom level.
 *
 * @return Returns the distance measured in meters.
 */
+ (double)getMetersPerPixelAtLatitudeForLatitude:(double)latitude
                                            zoom:(double)zoom;
/**
 * Calculate Spherical Mercator ProjectedMeters coordinates.
 *
 * @param coordinate A longitude-latitude pair for which to calculate
 * `projected meters` coordinates.
 *
 * @return Returns Spherical Mercator ProjectedMeters coordinates.
 */
+ (nonnull MBMProjectedMeters *)projectedMetersForCoordinateForCoordinate:(CLLocationCoordinate2D)coordinate __attribute((ns_returns_retained));
/**
 * Calculate a longitude-latitude pair for a Spherical Mercator projected
 * meters.
 *
 * @param projectedMeters Spherical Mercator ProjectedMeters coordinates for
 * which to calculate a longitude-latitude pair.
 *
 * @return Returns a longitude-latitude pair.
 */
+ (CLLocationCoordinate2D)coordinateForProjectedMetersForProjectedMeters:(nonnull MBMProjectedMeters *)projectedMeters;
/**
 * Calculate a point on the map in Mercator Projection for a given
 * coordinate at the specified zoom scale.
 *
 * @param coordinate The longitude-latitude pair for which to return the value.
 * @param zoomScale The current zoom factor (2 ^ Zoom level) applied on the map, is used to
 * calculate the world size as tileSize * zoomScale (i.e., 512 * 2 ^ Zoom level)
 * where tileSize is the width of a tile in pixels.
 *
 * @return Returns a point on the map in Mercator projection.
 */
+ (nonnull MBMMercatorCoordinate *)projectForCoordinate:(CLLocationCoordinate2D)coordinate
                                              zoomScale:(double)zoomScale __attribute((ns_returns_retained));
/**
 * Calculate a coordinate for a given point on the map in Mercator Projection.
 *
 * @param coordinate Point on the map in Mercator projection.
 * @param zoomScale The current zoom factor applied on the map, is used to
 * calculate the world size as tileSize * zoomScale (i.e., 512 * 2 ^ Zoom level)
 * where tileSize is the width of a tile in pixels.
 *
 * @return Returns a coordinate.
 */
+ (CLLocationCoordinate2D)unprojectForCoordinate:(nonnull MBMMercatorCoordinate *)coordinate
                                       zoomScale:(double)zoomScale;

@end
