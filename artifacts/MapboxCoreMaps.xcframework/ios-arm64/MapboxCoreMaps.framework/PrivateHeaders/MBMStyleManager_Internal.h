// This file is generated and will be overwritten automatically.

#import <MapboxCoreMaps/MBMStyleManager.h>

@interface MBMStyleManager ()
- (nonnull MBXExpected *)addStyleLayerForProperties:(nonnull id)properties
                                      layerPosition:(nullable MBMLayerPosition *)layerPosition __attribute((ns_returns_retained));
- (nonnull MBXExpected *)addStyleCustomLayerForLayerId:(nonnull NSString *)layerId
                                             layerHost:(nonnull id<MBMCustomLayerHost>)layerHost
                                         layerPosition:(nullable MBMLayerPosition *)layerPosition __attribute((ns_returns_retained));
- (nonnull MBXExpected *)addPersistentStyleLayerForProperties:(nonnull id)properties
                                                layerPosition:(nullable MBMLayerPosition *)layerPosition __attribute((ns_returns_retained));
- (nonnull MBXExpected *)addPersistentStyleCustomLayerForLayerId:(nonnull NSString *)layerId
                                                       layerHost:(nonnull id<MBMCustomLayerHost>)layerHost
                                                   layerPosition:(nullable MBMLayerPosition *)layerPosition __attribute((ns_returns_retained));
- (nonnull MBXExpected *)isStyleLayerPersistentForLayerId:(nonnull NSString *)layerId __attribute((ns_returns_retained));
- (nonnull MBXExpected *)removeStyleLayerForLayerId:(nonnull NSString *)layerId __attribute((ns_returns_retained));
- (nonnull MBXExpected *)moveStyleLayerForLayerId:(nonnull NSString *)layerId
                                    layerPosition:(nullable MBMLayerPosition *)layerPosition __attribute((ns_returns_retained));
- (nonnull MBXExpected *)setStyleLayerPropertyForLayerId:(nonnull NSString *)layerId
                                                property:(nonnull NSString *)property
                                                   value:(nonnull id)value __attribute((ns_returns_retained));
- (nonnull MBXExpected *)getStyleLayerPropertiesForLayerId:(nonnull NSString *)layerId __attribute((ns_returns_retained));
- (nonnull MBXExpected *)setStyleLayerPropertiesForLayerId:(nonnull NSString *)layerId
                                                properties:(nonnull id)properties __attribute((ns_returns_retained));
- (nonnull MBXExpected *)addStyleSourceForSourceId:(nonnull NSString *)sourceId
                                        properties:(nonnull id)properties __attribute((ns_returns_retained));
- (nonnull MBXExpected *)setStyleSourcePropertyForSourceId:(nonnull NSString *)sourceId
                                                  property:(nonnull NSString *)property
                                                     value:(nonnull id)value __attribute((ns_returns_retained));
- (nonnull MBXExpected *)getStyleSourcePropertiesForSourceId:(nonnull NSString *)sourceId __attribute((ns_returns_retained));
- (nonnull MBXExpected *)setStyleSourcePropertiesForSourceId:(nonnull NSString *)sourceId
                                                  properties:(nonnull id)properties __attribute((ns_returns_retained));
- (nonnull MBXExpected *)updateStyleImageSourceImageForSourceId:(nonnull NSString *)sourceId
                                                          image:(nonnull MBMImage *)image __attribute((ns_returns_retained));
- (nonnull MBXExpected *)removeStyleSourceForSourceId:(nonnull NSString *)sourceId __attribute((ns_returns_retained));
- (nonnull MBXExpected *)setStyleLightForProperties:(nonnull id)properties __attribute((ns_returns_retained));
- (nonnull MBXExpected *)setStyleLightPropertyForProperty:(nonnull NSString *)property
                                                    value:(nonnull id)value __attribute((ns_returns_retained));
- (nonnull MBXExpected *)setStyleTerrainForProperties:(nonnull id)properties __attribute((ns_returns_retained));
- (nonnull MBXExpected *)setStyleTerrainPropertyForProperty:(nonnull NSString *)property
                                                      value:(nonnull id)value __attribute((ns_returns_retained));
- (nonnull MBXExpected *)addStyleImageForImageId:(nonnull NSString *)imageId
                                           scale:(float)scale
                                           image:(nonnull MBMImage *)image
                                             sdf:(BOOL)sdf
                                        stretchX:(nonnull NSArray<MBMImageStretches *> *)stretchX
                                        stretchY:(nonnull NSArray<MBMImageStretches *> *)stretchY
                                         content:(nullable MBMImageContent *)content __attribute((ns_returns_retained));
- (nonnull MBXExpected *)removeStyleImageForImageId:(nonnull NSString *)imageId __attribute((ns_returns_retained));
- (nonnull MBXExpected *)addStyleCustomGeometrySourceForSourceId:(nonnull NSString *)sourceId
                                                         options:(nonnull MBMCustomGeometrySourceOptions *)options __attribute((ns_returns_retained));
- (nonnull MBXExpected *)setStyleCustomGeometrySourceTileDataForSourceId:(nonnull NSString *)sourceId
                                                                  tileId:(nonnull MBMCanonicalTileID *)tileId
                                                       featureCollection:(nonnull NSArray<MBXFeature *> *)featureCollection __attribute((ns_returns_retained));
- (nonnull MBXExpected *)invalidateStyleCustomGeometrySourceTileForSourceId:(nonnull NSString *)sourceId
                                                                     tileId:(nonnull MBMCanonicalTileID *)tileId __attribute((ns_returns_retained));
- (nonnull MBXExpected *)invalidateStyleCustomGeometrySourceRegionForSourceId:(nonnull NSString *)sourceId
                                                                       bounds:(nonnull MBMCoordinateBounds *)bounds __attribute((ns_returns_retained));
@end
