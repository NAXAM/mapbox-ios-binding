// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCoreMaps/MBMGlyphsRasterizationMode.h>

/** Describes the style package load option values. */
NS_SWIFT_NAME(StylePackLoadOptions)
__attribute__((visibility ("default")))
@interface MBMStylePackLoadOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithGlyphsRasterizationMode:(nullable NSNumber *)glyphsRasterizationMode
                                               metadata:(nullable id)metadata NS_REFINED_FOR_SWIFT;

- (nonnull instancetype)initWithGlyphsRasterizationMode:(nullable NSNumber *)glyphsRasterizationMode
                                               metadata:(nullable id)metadata
                                          acceptExpired:(BOOL)acceptExpired NS_REFINED_FOR_SWIFT;

/**
 * Specifies glyphs rasterization mode.
 *
 * If provided, updates the style package's glyphs rasterization mode,
 * which defines which glyphs will be loaded from the server.
 *
 * By default, ideographs are rasterized locally and other glyphs are loaded
 * from network (i.e. `IdeographsRasterizedLocally` value is used).
 */
@property (nonatomic, readonly, nullable) NSNumber *glyphsRasterizationMode NS_REFINED_FOR_SWIFT;

/**
 * A custom Mapbox value associated with this style package for storing metadata.
 *
 * If provided, the custom value value will be stored alongside the style package. Previous values will
 * be replaced with the new value.
 *
 * Developers can use this field to store custom metadata associated with a style package.
 */
@property (nonatomic, readonly, nullable, copy) id metadata;

/**
 * Accepts expired data when loading style resources.
 *
 * This flag should be set to true to accept expired responses. When a style resource is already loaded but expired,
 * no attempt will be made to refresh the data. This may lead to outdated data. Set to false to ensure that data
 * for a style is up-to-date.
 */
@property (nonatomic, readonly, getter=isAcceptExpired) BOOL acceptExpired;


@end
