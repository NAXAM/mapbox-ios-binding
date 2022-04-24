// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
@class MBXExpected;
@class MBXFeature;
#import <MapboxCoreMaps/MBMObservable.h>

@class MBMCameraOptions;
@class MBMCanonicalTileID;
@class MBMCoordinateBounds;
@class MBMCustomGeometrySourceOptions;
@class MBMImage;
@class MBMImageContent;
@class MBMImageStretches;
@class MBMLayerPosition;
@class MBMStyleObjectInfo;
@class MBMStylePropertyValue;
@class MBMTransitionOptions;
@protocol MBMCustomLayerHost;

/** Interface for managing style of the `map`. */
NS_SWIFT_NAME(StyleManager)
__attribute__((visibility ("default")))
@interface MBMStyleManager : MBMObservable

/**
 * Get the URI of the current style in use.
 *
 * @return A string containing a style URI.
 */
- (nonnull NSString *)getStyleURI __attribute((ns_returns_retained));
/**
 * Load style from provided URI.
 *
 * This is an asynchronous call. To check the result of this operation the user must register an observer observing
 * `MapLoaded` or `MapLoadingError` events. In case of successful style load, `StyleLoaded` event will be also emitted.
 *
 * @param uri URI where the style should be loaded from.
 */
- (void)setStyleURIForUri:(nonnull NSString *)uri;
/**
 * Get the JSON serialization string of the current style in use.
 *
 * @return A JSON string containing a serialized style.
 */
- (nonnull NSString *)getStyleJSON __attribute((ns_returns_retained));
/**
 * Load the style from a provided JSON string.
 *
 * @param json A JSON string containing a serialized style.
 */
- (void)setStyleJSONForJson:(nonnull NSString *)json;
/**
 * Returns the map style's default camera, if any, or a default camera otherwise.
 * The map style's default camera is defined as follows:
 * - [center](https://docs.mapbox.com/mapbox-gl-js/style-spec/#root-center)
 * - [zoom](https://docs.mapbox.com/mapbox-gl-js/style-spec/#root-zoom)
 * - [bearing](https://docs.mapbox.com/mapbox-gl-js/style-spec/#root-bearing)
 * - [pitch](https://docs.mapbox.com/mapbox-gl-js/style-spec/#root-pitch)
 *
 * The style default camera is re-evaluated when a new style is loaded.
 *
 * @return The default `camera options` of the current style in use.
 */
- (nonnull MBMCameraOptions *)getStyleDefaultCamera __attribute((ns_returns_retained));
/**
 * Returns the map style's transition options. By default, the style parser will attempt
 * to read the style default transition options, if any, fallbacking to an immediate transition
 * otherwise. Transition options can be overriden via `setStyleTransition`, but the options are
 * reset once a new style has been loaded.
 *
 * The style transition is re-evaluated when a new style is loaded.
 *
 * @return The `transition options` of the current style in use.
 */
- (nonnull MBMTransitionOptions *)getStyleTransition __attribute((ns_returns_retained));
/**
 * Overrides the map style's transition options with user-provided options.
 *
 * The style transition is re-evaluated when a new style is loaded.
 *
 * @param transitionOptions The `transition options`.
 */
- (void)setStyleTransitionForTransitionOptions:(nonnull MBMTransitionOptions *)transitionOptions;
/**
 * Checks whether a given style layer exists.
 *
 * @param layerId Style layer identifier.
 *
 * @return A `true` value if the given style layer exists, `false` otherwise.
 */
- (BOOL)styleLayerExistsForLayerId:(nonnull NSString *)layerId;
/**
 * Returns the existing style layers.
 *
 * @return The list containing the information about existing style layer objects.
 */
- (nonnull NSArray<MBMStyleObjectInfo *> *)getStyleLayers __attribute((ns_returns_retained));
/**
 * Gets the value of style layer property.
 *
 * @param layerId A style layer identifier.
 * @param property The style layer property name.
 * @return The `style property value`.
 */
- (nonnull MBMStylePropertyValue *)getStyleLayerPropertyForLayerId:(nonnull NSString *)layerId
                                                          property:(nonnull NSString *)property __attribute((ns_returns_retained));
/**
 * Gets the default value of style layer property
 *
 * @param layerType A style [layer type](https://docs.mapbox.com/mapbox-gl-js/style-spec/#layers).
 * @param property The style layer property name.
 * @return The default `style property value` for a given `layerType` and `property` name.
 */
+ (nonnull MBMStylePropertyValue *)getStyleLayerPropertyDefaultValueForLayerType:(nonnull NSString *)layerType
                                                                        property:(nonnull NSString *)property __attribute((ns_returns_retained));
/**
 * Gets the value of style source property.
 *
 * @param sourceId A style source identifier.
 * @param property The style source property name.
 * @return The value of a `property` in the source with a `sourceId`.
 */
- (nonnull MBMStylePropertyValue *)getStyleSourcePropertyForSourceId:(nonnull NSString *)sourceId
                                                            property:(nonnull NSString *)property __attribute((ns_returns_retained));
/**
 * Gets the default value of style source property.
 *
 * @param sourceType A style source type.
 * @param property The style source property name.
 * @return The default value of a `property` for the sources with of a `sourceType` type.
 */
+ (nonnull MBMStylePropertyValue *)getStyleSourcePropertyDefaultValueForSourceType:(nonnull NSString *)sourceType
                                                                          property:(nonnull NSString *)property __attribute((ns_returns_retained));
/**
 * Checks whether a given style source exists.
 *
 * @param sourceId A style source identifier.
 *
 * @return `true` if the given source exists, `false` otherwise.
 */
- (BOOL)styleSourceExistsForSourceId:(nonnull NSString *)sourceId;
/**
 * Returns the existing style sources.
 *
 * @return The list containing the information about existing style source objects.
 */
- (nonnull NSArray<MBMStyleObjectInfo *> *)getStyleSources __attribute((ns_returns_retained));
/**
 * Gets the value of a style light property.
 *
 * @param property The style light property name.
 * @return The style light property value.
 */
- (nonnull MBMStylePropertyValue *)getStyleLightPropertyForProperty:(nonnull NSString *)property __attribute((ns_returns_retained));
/**
 * Gets the value of a style terrain property.
 *
 * @param property The style terrain property name.
 * @return The style terrain property value.
 */
- (nonnull MBMStylePropertyValue *)getStyleTerrainPropertyForProperty:(nonnull NSString *)property __attribute((ns_returns_retained));
/**
 * Get an `image` from the style.
 *
 * @param imageId The identifier of the `image`.
 *
 * @return The `image` for the given `imageId`, or empty if no image is associated with the `imageId`.
 */
- (nullable MBMImage *)getStyleImageForImageId:(nonnull NSString *)imageId __attribute((ns_returns_retained));
/**
 * Checks whether an image exists.
 *
 * @param imageId The identifier of the image.
 *
 * @return True if image exists, false otherwise.
 */
- (BOOL)hasStyleImageForImageId:(nonnull NSString *)imageId;
/**
 * Check if the style is completely loaded.
 *
 * Note: The style specified sprite would be marked as loaded even with sprite loading error (An error will be emitted via `MapLoadingError`).
 * Sprite loading error is not fatal and we don't want it to block the map rendering, thus the function will still return `true` if style and sources are fully loaded.
 *
 * @return `true` iff the style JSON contents, the style specified sprite and sources are all loaded, otherwise returns `false`.
 *
 */
- (BOOL)isStyleLoaded;

@end
