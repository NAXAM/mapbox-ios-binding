#import <Foundation/Foundation.h>
#import <MetalKit/MTKView.h>
#import <Metal/MTLTexture.h>

/**
 * Interface for providing MTKView to the map renderer.
 */
@protocol MBMMetalViewProvider

@optional

- (MTKView *_Nullable)getMetalViewFor:(nullable id<MTLDevice>)metalDevice;

@optional

- (nullable id<MTLTexture>)getDrawableTexture;

/// The point in time at which metal view should refresh its content.
/// In case the refresh is synced with `CADisplayLink` update,
/// use `CADisplayLink.targetTimestamp` as a return value for this proprety.
/// Return `CACurrentMediaTime()` to indicate that the metal view should be redrawn as soon as possible.
- (CFTimeInterval)getTargetFrameTimestamp;

@end

