// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Options for enabling debugging features in a map. */
// NOLINTNEXTLINE(modernize-use-using)
typedef NS_ENUM(NSInteger, MBMMapDebugOptions)
{
    /**
     * Edges of tile boundaries are shown as thick, red lines to help diagnose
     * tile clipping issues.
     */
    MBMMapDebugOptionsTileBorders,
    /** Each tile shows its tile coordinate (x/y/z) in the upper-left corner. */
    MBMMapDebugOptionsParseStatus,
    /** Each tile shows a timestamp indicating when it was loaded. */
    MBMMapDebugOptionsTimestamps,
    /**
     * Edges of glyphs and symbols are shown as faint, green lines to help
     * diagnose collision and label placement issues.
     */
    MBMMapDebugOptionsCollision,
    /**
     * Each drawing operation is replaced by a translucent fill. Overlapping
     * drawing operations appear more prominent to help diagnose overdrawing.
     */
    MBMMapDebugOptionsOverdraw,
    /** The stencil buffer is shown instead of the color buffer. */
    MBMMapDebugOptionsStencilClip,
    /** The depth buffer is shown instead of the color buffer. */
    MBMMapDebugOptionsDepthBuffer,
    /**
     * Visualize residency of tiles in the render cache. Tile boundaries of cached tiles
     * are rendered with green, tiles waiting for an update with yellow and tiles not in the cache
     * with red.
     */
    MBMMapDebugOptionsRenderCache,
    /** Show 3D model bounding boxes. */
    MBMMapDebugOptionsModelBounds,
    /** Show a wireframe for terrain. */
    MBMMapDebugOptionsTerrainWireframe
} NS_SWIFT_NAME(MapDebugOptions);
