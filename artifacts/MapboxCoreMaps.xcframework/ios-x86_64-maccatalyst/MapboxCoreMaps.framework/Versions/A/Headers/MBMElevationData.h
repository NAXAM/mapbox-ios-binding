// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <CoreLocation/CoreLocation.h>

/** Interface that provides access to elevation data. */
NS_SWIFT_NAME(ElevationData)
@protocol MBMElevationData
/**
 * Get elevation for given coordinate. Value is available only for the visible region on the screen, if terrain (DEM) tile is available.
 *
 * @param coordinate defined as longitude-latitude pair.
 *
 * @return Elevation (in meters) multiplied by current terrain exaggeration, or empty if elevation for the coordinate is not available.
 */
- (nullable NSNumber *)getElevationForCoordinate:(CLLocationCoordinate2D)coordinate;
/**
 * Current value of terrain exaggeration.
 * @return Current value of terrain exaggeration.
 */
- (double)getTerrainExaggeration;
@end
