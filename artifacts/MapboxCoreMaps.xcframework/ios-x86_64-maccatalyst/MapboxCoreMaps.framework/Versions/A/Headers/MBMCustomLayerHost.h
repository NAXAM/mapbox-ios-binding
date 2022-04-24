#import <Foundation/Foundation.h>

@protocol MTLDevice, MTLCommandBuffer, MTLRenderCommandEncoder;

@class MTLRenderPassDescriptor;

@class MBMCustomLayerRenderParameters;

/**
 * Interface for hosting a custom map style layer.
 */
NS_SWIFT_NAME(CustomLayerHost)
@protocol MBMCustomLayerHost <NSObject>

/**
 * Initialize any Metal 3D graphic API state needed by the custom layer. This method is called
 * once when view starts or resumes to foreground but before rendering for the first time.
 *
 * `colorPixelFormat` and `depthStencilPixelFormat` are values of MTLPixelFormat and are declared here
 * as underlying NSUinteger to avoid import here.
 *
 * This method is called if underlying map rendering backend uses Metal graphic API.
 *
 * Resources that are acquired in this method must be released in the `deinitialize` function.
 */
- (void)renderingWillStart:(nonnull id<MTLDevice>)metalDevice
          colorPixelFormat:(NSUInteger)colorPixelFormat
   depthStencilPixelFormat:(NSUInteger)depthStencilPixelFormat;
/**
 * Render the layer. This method is called once per frame.
 *
 * This method is called if underlying map rendering backend uses Metal graphic API.
 *
 * @param The `parameters` that define the current camera position.
 * @param The MTLCommandBuffer used to render all map layers.
 * Use to create new command encoders. Do not submit as there could be map
 * layers following this custom layer in style's layer list and those won't get
 * to be encoded.
 * @param The MTLRenderPassDescriptor that defines rendering map to view drawable.
 *
 */
- (void)render:(nonnull MBMCustomLayerRenderParameters *)parameters
mtlCommandBuffer:(nonnull id<MTLCommandBuffer>)mtlCommandBuffer
mtlRenderPassDescriptor:(nonnull MTLRenderPassDescriptor *)mtlRenderPassDescriptor;
/**
 * Destroy any state needed by the custom layer, and deallocate context, if necessary. This
 * method is called once, from the main thread, at a point when Metal or OpenGL context is active.
 *
 * Note that it may be called even when the `renderingWillStart` function has not been called.
 */
- (void)renderingWillEnd;

@optional

/**
 * Initialize any OpenGL 3D graphic API state needed by the custom layer. This method is called
 * once when view starts or resumes to foreground but before rendering for the first time.
 * 
 * As Apple is deprecating legacy OpenGL API, this method is optional and is called only if
 * underlying map rendering backend uses OpenGL graphic API.
 *
 * Resources that are acquired in this method must be released in the `deinitialize` function.
 */
- (void)renderingWillStartOpenGL;
/**
 * Render the layer. This method is called once per frame. The implementation should not make
 * any assumptions about the GL state (other than that the correct context is active). It may
 * make changes to the state, and is not required to reset values such as the depth mask, stencil
 * mask, and corresponding test flags to their original values.
 * Make sure that you are drawing your fragments with a z value of 1 to take advantage of the
 * opaque fragment culling in case there are opaque layers above your custom layer.
 *
 * As Apple is deprecating legacy OpenGL API, this method is optional and is called only if
 * underlying map rendering backend uses OpenGL graphic API.
 *
 * @param The `parameters` that define the current camera position.
 *
 */
- (void)renderOpenGL:(nonnull MBMCustomLayerRenderParameters *)parameters;
/**
 * Called when the system has destroyed the underlying OpenGL context. The
 * `renderingWillEnd` function will not be called in this case, however
 * `setupRendering` will be called instead to prepare for a new render.
 *
 * As Apple is deprecating legacy OpenGL API, this method is optional and is called only if
 * underlying map rendering backend uses OpenGL graphic API.
 *
 */
- (void)openGLContextLost;
@end
