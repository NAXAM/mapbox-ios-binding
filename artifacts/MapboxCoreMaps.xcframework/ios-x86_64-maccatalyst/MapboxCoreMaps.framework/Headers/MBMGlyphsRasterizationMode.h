// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Describes glyphs rasterization modes. */
// NOLINTNEXTLINE(modernize-use-using)
typedef NS_ENUM(NSInteger, MBMGlyphsRasterizationMode)
{
    /** No glyphs are rasterized locally. All glyphs are loaded from the server. */
    MBMGlyphsRasterizationModeNoGlyphsRasterizedLocally,
    /** Ideographs are rasterized locally, and they are not loaded from the server. */
    MBMGlyphsRasterizationModeIdeographsRasterizedLocally,
    /** All glyphs are rasterized locally. No glyphs are loaded from the server. */
    MBMGlyphsRasterizationModeAllGlyphsRasterizedLocally
} NS_SWIFT_NAME(GlyphsRasterizationMode);
