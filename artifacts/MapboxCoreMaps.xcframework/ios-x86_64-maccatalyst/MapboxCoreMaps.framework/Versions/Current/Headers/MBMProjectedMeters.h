// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/**
 * ProjectedMeters is a coordinate in a specific
 * [Spherical Mercator](http://docs.openlayers.org/library/spherical_mercator.html) projection.
 *
 * This specific Spherical Mercator projection assumes the Earth is a sphere with a radius
 * of 6,378,137 meters. Coordinates are determined as distances, in meters, on the surface
 * of that sphere.
 */
NS_SWIFT_NAME(ProjectedMeters)
__attribute__((visibility ("default")))
@interface MBMProjectedMeters : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithNorthing:(double)northing
                                 easting:(double)easting;

/** Projected meters in north direction. */
@property (nonatomic, readonly) double northing;

/** Projected meters in east direction. */
@property (nonatomic, readonly) double easting;


@end
