// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

@class MBMCoordinateBounds;

/** Holds options to be used for setting `camera bounds`. */
NS_SWIFT_NAME(CameraBoundsOptions)
__attribute__((visibility ("default")))
@interface MBMCameraBoundsOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithBounds:(nullable MBMCoordinateBounds *)bounds
                               maxZoom:(nullable NSNumber *)maxZoom
                               minZoom:(nullable NSNumber *)minZoom
                              maxPitch:(nullable NSNumber *)maxPitch
                              minPitch:(nullable NSNumber *)minPitch NS_REFINED_FOR_SWIFT;

/** The latitude and longitude bounds to which the camera center are constrained. */
@property (nonatomic, readonly, nullable) MBMCoordinateBounds *bounds;

/** The maximum zoom level, in Mapbox zoom levels 0-25.5. At low zoom levels, a small set of map tiles covers a large geographical area. At higher zoom levels, a larger number of tiles cover a smaller geographical area. */
@property (nonatomic, readonly, nullable) NSNumber *maxZoom NS_REFINED_FOR_SWIFT;

/** The minimum zoom level, in Mapbox zoom levels 0-25.5. */
@property (nonatomic, readonly, nullable) NSNumber *minZoom NS_REFINED_FOR_SWIFT;

/** The maximum allowed pitch value in degrees. */
@property (nonatomic, readonly, nullable) NSNumber *maxPitch NS_REFINED_FOR_SWIFT;

/** The minimum allowed pitch value in degrees. */
@property (nonatomic, readonly, nullable) NSNumber *minPitch NS_REFINED_FOR_SWIFT;


@end
