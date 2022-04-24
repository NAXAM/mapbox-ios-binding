// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCoreMaps/MBMGlyphsRasterizationMode.h>

@class MBMCoordinateBounds;

/**
 * An offline region definition is a geographic region defined by a style URL,
 * geographic bounding box, zoom range, and device pixel ratio. Both `minZoom` and `maxZoom` must be ≥ 0,
 * and `maxZoom` must be ≥ `minZoom`. The `maxZoom` may be ∞, in which case for each tile source,
 * the region will include tiles from `minZoom` up to the maximum zoom level provided by that source.
 * The `pixelRatio` must be ≥ 0 and should typically be 1.0 or 2.0.
 */
NS_SWIFT_NAME(OfflineRegionTilePyramidDefinition)
__attribute__((visibility ("default")))
__attribute__((deprecated))
@interface MBMOfflineRegionTilePyramidDefinition : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithStyleURL:(nonnull NSString *)styleURL
                                  bounds:(nonnull MBMCoordinateBounds *)bounds
                                 minZoom:(double)minZoom
                                 maxZoom:(double)maxZoom
                              pixelRatio:(float)pixelRatio
                 glyphsRasterizationMode:(MBMGlyphsRasterizationMode)glyphsRasterizationMode;

/** The style associated with the offline region. */
@property (nonatomic, readonly, nonnull, copy) NSString *styleURL;

/** The bounds covering the region. */
@property (nonatomic, readonly, nonnull) MBMCoordinateBounds *bounds;

/** Minimum zoom level for the offline region. */
@property (nonatomic, readonly) double minZoom;

/** Maximum zoom level for the offline region. */
@property (nonatomic, readonly) double maxZoom;

/** Pixel ratio to be accounted for when downloading assets. */
@property (nonatomic, readonly) float pixelRatio;

/** Specifies glyphs download mode. */
@property (nonatomic, readonly) MBMGlyphsRasterizationMode glyphsRasterizationMode;


@end
