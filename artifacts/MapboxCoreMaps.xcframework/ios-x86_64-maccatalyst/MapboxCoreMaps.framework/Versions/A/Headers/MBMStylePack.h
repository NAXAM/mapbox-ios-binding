// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCoreMaps/MBMGlyphsRasterizationMode.h>

/** The `style pack` represents a stored style package. */
NS_SWIFT_NAME(StylePack)
__attribute__((visibility ("default")))
@interface MBMStylePack : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithStyleURI:(nonnull NSString *)styleURI
                 glyphsRasterizationMode:(MBMGlyphsRasterizationMode)glyphsRasterizationMode
                   requiredResourceCount:(uint64_t)requiredResourceCount
                  completedResourceCount:(uint64_t)completedResourceCount
                   completedResourceSize:(uint64_t)completedResourceSize
                                 expires:(nullable NSDate *)expires;

/** The style associated with the style package. */
@property (nonatomic, readonly, nonnull, copy) NSString *styleURI;

/**
 * The glyphs rasterization mode of the style package.
 *
 * It defines which glyphs will be loaded from the server.
 */
@property (nonatomic, readonly) MBMGlyphsRasterizationMode glyphsRasterizationMode;

/** The number of resources that are known to be required for this style package. */
@property (nonatomic, readonly) uint64_t requiredResourceCount;

/**
 * The number of resources that have been fully downloaded and are ready for
 * offline access.
 */
@property (nonatomic, readonly) uint64_t completedResourceCount;

/**
 * The cumulative size, in bytes, of all resources that have
 * been fully downloaded.
 */
@property (nonatomic, readonly) uint64_t completedResourceSize;

/**
 * The earliest point in time when any of the style package resources gets expired.
 *
 * Unitialized for incomplete style packages or for complete style packages with all immutable resources.
 */
@property (nonatomic, readonly, nullable) NSDate *expires;


@end
