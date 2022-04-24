// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

@class MBMGlyphsRasterizationOptions;
@class MBMResourceOptions;
@class MBMSize;

/** Set of options for taking map snapshot with `map snapshotter`. */
NS_SWIFT_NAME(MapSnapshotOptions)
__attribute__((visibility ("default")))
@interface MBMMapSnapshotOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithSize:(nonnull MBMSize *)size
          glyphsRasterizationOptions:(nullable MBMGlyphsRasterizationOptions *)glyphsRasterizationOptions
                     resourceOptions:(nonnull MBMResourceOptions *)resourceOptions NS_REFINED_FOR_SWIFT;

- (nonnull instancetype)initWithSize:(nonnull MBMSize *)size
                          pixelRatio:(float)pixelRatio
          glyphsRasterizationOptions:(nullable MBMGlyphsRasterizationOptions *)glyphsRasterizationOptions
                     resourceOptions:(nonnull MBMResourceOptions *)resourceOptions NS_REFINED_FOR_SWIFT;

/** Dimensions of the snapshot in `platform pixel` units. */
@property (nonatomic, readonly, nonnull) MBMSize *size NS_REFINED_FOR_SWIFT;

/** Ratio between the number device-independent and screen pixels. */
@property (nonatomic, readonly) float pixelRatio;

/**
 * Glyphs rasterization options to use for client-side text rendering.
 * By default, `GlyphsRasterizationOptions` will use `NoGlyphsRasterizedLocally` mode.
 */
@property (nonatomic, readonly, nullable) MBMGlyphsRasterizationOptions *glyphsRasterizationOptions;

/** The `resource options` to be used by the snapshotter. */
@property (nonatomic, readonly, nonnull) MBMResourceOptions *resourceOptions;


@end
