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

@end

