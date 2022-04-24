// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCoreMaps/MBMGlyphsRasterizationMode.h>

/** Describes the glyphs rasterization option values. */
NS_SWIFT_NAME(GlyphsRasterizationOptions)
__attribute__((visibility ("default")))
@interface MBMGlyphsRasterizationOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithRasterizationMode:(MBMGlyphsRasterizationMode)rasterizationMode
                                       fontFamily:(nullable NSString *)fontFamily;

/** Glyphs rasterization mode for client-side text rendering. */
@property (nonatomic, readonly) MBMGlyphsRasterizationMode rasterizationMode;

/**
 * Font family to use as font fallback for client-side text renderings.
 *
 * Note: `GlyphsRasterizationMode` has precedence over font family. If `AllGlyphsRasterizedLocally`
 * or `IdeographsRasterizedLocally` is set, local glyphs will be generated based on the provided font family. If no
 * font family is provided, the map will fall back to use the system default font. The mechanisms of choosing the
 * default font are varied in platforms:
 * - For darwin(iOS/macOS) platform, the default font family is created from the <a href="https://developer.apple.com/documentation/uikit/uifont/1619027-systemfontofsize?language=objc">systemFont</a>.
 *   If provided fonts are not supported on darwin platform, the map will fall back to use the first available font from the global fallback list.
 * - For Android platform: the default font <a href="https://developer.android.com/reference/android/graphics/Typeface#DEFAULT">Typeface.DEFAULT</a> will be used.
 *
 * Besides, the font family will be discarded if it is provided along with `NoGlyphsRasterizedLocally` mode.
 *
 */
@property (nonatomic, readonly, nullable, copy) NSString *fontFamily;


@end
