// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <CoreLocation/CoreLocation.h>
#import <MapboxCoreMaps/MBMConstrainMode.h>
#import <MapboxCoreMaps/MBMMapDebugOptions.h>
#import <MapboxCoreMaps/MBMNorthOrientation.h>
#import <MapboxCoreMaps/MBMViewportMode.h>
@class MBXExpected;
@class MBXFeature;
#import <MapboxCoreMaps/MBMCameraManager.h>

@class MBMMapMemoryBudget;
@class MBMMapOptions;
@class MBMRenderCacheOptions;
@class MBMRenderedQueryGeometry;
@class MBMRenderedQueryOptions;
@class MBMResourceOptions;
@class MBMScreenBox;
@class MBMScreenCoordinate;
@class MBMSize;
@class MBMSourceQueryOptions;
@class MBMViewAnnotationOptions;
@class MBXCancelable;
@protocol MBMMapClient;
@protocol MBMViewAnnotationPositionsUpdateListener;

/**
 * Map class provides map rendering functionality.
 *
 */
NS_SWIFT_NAME(Map)
__attribute__((visibility ("default")))
@interface MBMMap : MBMCameraManager

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

/**
 * Creates the infrastructure needed for rendering the map.
 * It should be called before any call to `render` method. Must be called on the render thread.
 */
- (void)createRenderer;
/**
 * Destroys the infrastructure needed for rendering the map, releasing resources.
 * Must be called on the render thread.
 */
- (void)destroyRenderer;
/** Renders the map. */
- (void)render;
/**
 * Sets the size of the map.
 * @param size The new `size` of the map in `platform pixels`.
 */
- (void)setSizeForSize:(nonnull MBMSize *)size;
/**
 * Gets the size of the map.
 *
 * @return The `size` of the map in `platform pixels`.
 */
- (nonnull MBMSize *)getSize __attribute((ns_returns_retained));
/** Triggers a repaint of the map. */
- (void)triggerRepaint;
/**
 * Tells the map rendering engine that there is currently a gesture in progress. This
 * affects how the map renders labels, as it will use different texture filters if a gesture
 * is ongoing.
 *
 * @param inProgress The `boolean` value representing if a gesture is in progress.
 */
- (void)setGestureInProgressForInProgress:(BOOL)inProgress;
/**
 * Returns `true` if a gesture is currently in progress.
 *
 * @return `true` if a gesture is currently in progress, `false` otherwise.
 */
- (BOOL)isGestureInProgress;
/**
 * Tells the map rendering engine that the animation is currently performed by the
 * user (e.g. with a `setCamera` calls series). It adjusts the engine for the animation use case.
 * In particular, it brings more stability to symbol placement and rendering.
 *
 * @param inProgress The `boolean` value representing if user animation is in progress
 */
- (void)setUserAnimationInProgressForInProgress:(BOOL)inProgress;
/**
 * Returns `true` if user animation is currently in progress.
 *
 * @return `true` if a user animation is currently in progress, `false` otherwise.
 */
- (BOOL)isUserAnimationInProgress;
/**
 * When loading a map, if prefetch zoom `delta` is set to any number greater than 0,
 * the map will first request a tile at zoom level lower than `zoom - delta`, with requested
 * zoom level a multiple of `delta`, in an attempt to display a full map at lower resolution as quick as possible.
 *
 * @param delta The new prefetch zoom delta.
 */
- (void)setPrefetchZoomDeltaForDelta:(uint8_t)delta;
/**
 * Returns the map's prefetch zoom delta.
 *
 * @return The map's prefetch zoom `delta`.
 */
- (uint8_t)getPrefetchZoomDelta;
/** Sets the north `orientation mode`. */
- (void)setNorthOrientationForOrientation:(MBMNorthOrientation)orientation;
/** Sets the map `constrain mode`. */
- (void)setConstrainModeForMode:(MBMConstrainMode)mode;
/** Sets the `viewport mode`. */
- (void)setViewportModeForMode:(MBMViewportMode)mode;
/**
 * Returns the `map options`.
 *
 * @return The map's `map options`.
 */
- (nonnull MBMMapOptions *)getMapOptions __attribute((ns_returns_retained));
/**
 * Returns the `map debug options`.
 *
 * @return An array of `map debug options` flags currently set to the map.
 */
- (nonnull NSArray<NSNumber *> *)getDebug __attribute((ns_returns_retained));
/**
 * Sets the `map debug options` and enables debug mode based on the passed value.
 *
 * @param debugOptions An array of `map debug options` to be set.
 * @param value A `boolean` value representing the state for a given `map debug options`.
 *
 */
- (void)setDebugForDebugOptions:(nonnull NSArray<NSNumber *> *)debugOptions
                          value:(BOOL)value;
/**
 * Returns `true` when the map is completely rendered, `false` otherwise. A partially
 * rendered map ranges from nothing rendered at all to only labels missing.
 *
 * @return `true` when the map is completely rendered, `false` otherwise.
 *
 */
- (BOOL)isMapLoaded;
/**
 * Updates the state object of a feature within a style source.
 *
 * Update entries in the `state` object of a given feature within a style source. Only properties of the
 * `state` object will be updated. A property in the feature `state` object that is not listed in `state` will
 * retain its previous value.
 *
 * Note that updates to feature `state` are asynchronous, so changes made by this method migth not be
 * immediately visible using `getStateFeature`.
 *
 * @param sourceId The style source identifier.
 * @param sourceLayerId The style source layer identifier (for multi-layer sources such as vector sources).
 * @param featureId The feature identifier of the feature whose state should be updated.
 * @param state The `state` object with properties to update with their respective new values.
 */
- (void)setFeatureStateForSourceId:(nonnull NSString *)sourceId
                     sourceLayerId:(nullable NSString *)sourceLayerId
                         featureId:(nonnull NSString *)featureId
                             state:(nonnull id)state;
/**
 * Removes entries from a feature state object.
 *
 * Remove a specified property or all property from a feature's state object, depending on the value of
 * `stateKey`.
 *
 * Note that updates to feature state are asynchronous, so changes made by this method migth not be
 * immediately visible using `getStateFeature`.
 *
 * @param sourceId The style source identifier.
 * @param sourceLayerId The style source layer identifier (for multi-layer sources such as vector sources).
 * @param featureId The feature identifier of the feature whose state should be removed.
 * @param stateKey The key of the property to remove. If `null`, all feature's state object properties are removed.
 */
- (void)removeFeatureStateForSourceId:(nonnull NSString *)sourceId
                        sourceLayerId:(nullable NSString *)sourceLayerId
                            featureId:(nonnull NSString *)featureId
                             stateKey:(nullable NSString *)stateKey;
/** Reduces memory use. Useful to call when the application gets paused or sent to background. */
- (void)reduceMemoryUse;
/**
 * Gets the resource options for the map.
 *
 * All optional fields of the retuned object are initialized with the actual values.
 *
 * Note that result of this method is different from the `resource options` that were provided to the map's constructor.
 *
 * @return The `resource options` for the map.
 */
- (nonnull MBMResourceOptions *)getResourceOptions __attribute((ns_returns_retained));
/**
 * Gets elevation for the given coordinate.
 * Note: Elevation is only available for the visible region on the screen.
 *
 * @param coordinate The `coordinate` defined as longitude-latitude pair.
 * @return The elevation (in meters) multiplied by current terrain exaggeration, or empty if elevation for the coordinate is not available.
 */
- (nullable NSNumber *)getElevationForCoordinate:(CLLocationCoordinate2D)coordinate __attribute((ns_returns_retained));
/**
 * Enables or disables the experimental render cache feature.
 *
 * Render cache is an experimental feature aiming to reduce resource usage of map rendering
 * by caching intermediate rendering results of tiles into specific cache textures for reuse between frames.
 * Performance benefit of the cache depends on the style as not all layers are cacheable due to e.g.
 * viewport aligned features. Render cache always prefers quality over performance.
 *
 * @param options The `render cache options` defining the render cache behavior.
 */
- (void)setRenderCacheOptionsForOptions:(nonnull MBMRenderCacheOptions *)options;
/**
 * Returns the `render cache options` used by the map.
 *
 * @return The `render cache options` currently used by the map.
 */
- (nonnull MBMRenderCacheOptions *)getRenderCacheOptions __attribute((ns_returns_retained));

@end
