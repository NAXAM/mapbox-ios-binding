// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <CoreLocation/CoreLocation.h>

@class MBMImage;
@class MBMScreenCoordinate;

/** An image snapshot of a map rendered by `map snapshotter`. */
NS_SWIFT_NAME(MapSnapshot)
__attribute__((visibility ("default")))
@interface MBMMapSnapshot : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

/**
 * Calculate screen coordinate on the snapshot from geographical `coordinate`.
 *
 * @param coordinate A geographical `coordinate`.
 * @return A `screen coordinate` measured in `platform pixels` on the snapshot for geographical `coordinate`.
 */
- (nonnull MBMScreenCoordinate *)screenCoordinateForCoordinate:(CLLocationCoordinate2D)coordinate __attribute((ns_returns_retained));
/**
 * Calculate geographical coordinates from a point on the snapshot.
 *
 * @param screenCoordinate A `screen coordinate` on the snapshot in `platform pixels`.
 * @return A geographical `coordinate` for a `screen coordinate` on the snapshot.
 */
- (CLLocationCoordinate2D)coordinateForScreenCoordinate:(nonnull MBMScreenCoordinate *)screenCoordinate;
/**
 * Get list of attributions for the sources in this snapshot.
 *
 * @return A list of attributions for the sources in this snapshot.
 */
- (nonnull NSArray<NSString *> *)attributions __attribute((ns_returns_retained));
/**
 * Get the rendered snapshot `image`.
 *
 * @return A rendered snapshot `image`.
 */
- (nonnull MBMImage *)image __attribute((ns_returns_retained));

@end
