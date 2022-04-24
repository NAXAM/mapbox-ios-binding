// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/**
 * Describes the map context mode.
 * We can make some optimizations if we know that the drawing context is not shared with other code.
 */
// NOLINTNEXTLINE(modernize-use-using)
typedef NS_ENUM(NSInteger, MBMContextMode)
{
    /**
     * Unique context mode: in OpenGL, the GL context is not shared, thus we can retain knowledge about the GL state
     * from a previous render pass. It also enables clearing the screen using glClear for the bottommost background
     * layer when no pattern is applied to that layer.
     */
    MBMContextModeUnique,
    /**
     * Shared context mode: in OpenGL, the GL context is shared with other renderers, thus we cannot rely on the GL
     * state set from a previous render pass.
     */
    MBMContextModeShared
} NS_SWIFT_NAME(ContextMode);
