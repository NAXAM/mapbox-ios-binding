// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCoreMaps/MBMConstrainMode.h>
#import <MapboxCoreMaps/MBMContextMode.h>
#import <MapboxCoreMaps/MBMNorthOrientation.h>
#import <MapboxCoreMaps/MBMViewportMode.h>

@class MBMGlyphsRasterizationOptions;
@class MBMSize;

/** Describes the map option values. */
NS_SWIFT_NAME(MapOptions)
__attribute__((visibility ("default")))
@interface MBMMapOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithContextMode:(nullable NSNumber *)contextMode
                              constrainMode:(nullable NSNumber *)constrainMode
                               viewportMode:(nullable NSNumber *)viewportMode
                                orientation:(nullable NSNumber *)orientation
                      crossSourceCollisions:(nullable NSNumber *)crossSourceCollisions
                         optimizeForTerrain:(nullable NSNumber *)optimizeForTerrain
                                       size:(nullable MBMSize *)size
                 glyphsRasterizationOptions:(nullable MBMGlyphsRasterizationOptions *)glyphsRasterizationOptions NS_REFINED_FOR_SWIFT;

- (nonnull instancetype)initWithContextMode:(nullable NSNumber *)contextMode
                              constrainMode:(nullable NSNumber *)constrainMode
                               viewportMode:(nullable NSNumber *)viewportMode
                                orientation:(nullable NSNumber *)orientation
                      crossSourceCollisions:(nullable NSNumber *)crossSourceCollisions
                         optimizeForTerrain:(nullable NSNumber *)optimizeForTerrain
                                       size:(nullable MBMSize *)size
                                 pixelRatio:(float)pixelRatio
                 glyphsRasterizationOptions:(nullable MBMGlyphsRasterizationOptions *)glyphsRasterizationOptions NS_REFINED_FOR_SWIFT;

/**
 * The map context mode. This can be used to optimizations
 * if we know that the drawing context is not shared with other code.
 */
@property (nonatomic, readonly, nullable) NSNumber *contextMode NS_REFINED_FOR_SWIFT;

/**
 * The map constrain mode. This can be used to limit the map
 * to wrap around the globe horizontally. By default, it is set to
 * `HeightOnly`.
 */
@property (nonatomic, readonly, nullable) NSNumber *constrainMode NS_REFINED_FOR_SWIFT;

/**
 * The viewport mode. This can be used to flip the vertical
 * orientation of the map as some devices may use inverted orientation.
 */
@property (nonatomic, readonly, nullable) NSNumber *viewportMode NS_REFINED_FOR_SWIFT;

/**
 * The orientation of the Map. By default, it is set to
 * `Upwards`.
 */
@property (nonatomic, readonly, nullable) NSNumber *orientation NS_REFINED_FOR_SWIFT;

/**
 * Specify whether to enable cross-source symbol collision detection
 * or not. By default, it is set to `true`.
 */
@property (nonatomic, readonly, nullable) NSNumber *crossSourceCollisions NS_REFINED_FOR_SWIFT;

/**
 * With terrain on, if `true`, the map will render for performance
 * priority, which may lead to layer reordering allowing to maximize
 * performance (layers that are draped over terrain will be drawn first,
 * including fill, line, background, hillshade and raster). Any layers that
 * are positioned after symbols are draped last, over symbols. Otherwise, if
 * set to `false`, the map will always be drawn for layer order priority.
 * By default, it is set to `true`.
 */
@property (nonatomic, readonly, nullable) NSNumber *optimizeForTerrain NS_REFINED_FOR_SWIFT;

/**
 * The size to resize the map object and renderer backend.
 * The size is given in `platform pixel` units. macOS and iOS platforms use
 * device-independent pixel units, while other platforms, such as Android,
 * use screen pixel units.
 */
@property (nonatomic, readonly, nullable) MBMSize *size NS_REFINED_FOR_SWIFT;

/** The custom pixel ratio. By default, it is set to 1.0 */
@property (nonatomic, readonly) float pixelRatio;

/** Glyphs rasterization options to use for client-side text rendering. */
@property (nonatomic, readonly, nullable) MBMGlyphsRasterizationOptions *glyphsRasterizationOptions;


@end
