// This file is generated and will be overwritten automatically.

#import "MBMStyleManager.h"

@interface MBMStyleManager ()
- (nonnull MBXExpected<NSNull *, NSString *> *)addStyleLayerForProperties:(nonnull id)properties
                                                            layerPosition:(nullable MBMLayerPosition *)layerPosition __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)addStyleCustomLayerForLayerId:(nonnull NSString *)layerId
                                                                   layerHost:(nonnull id<MBMCustomLayerHost>)layerHost
                                                               layerPosition:(nullable MBMLayerPosition *)layerPosition __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)addPersistentStyleLayerForProperties:(nonnull id)properties
                                                                      layerPosition:(nullable MBMLayerPosition *)layerPosition __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)addPersistentStyleCustomLayerForLayerId:(nonnull NSString *)layerId
                                                                             layerHost:(nonnull id<MBMCustomLayerHost>)layerHost
                                                                         layerPosition:(nullable MBMLayerPosition *)layerPosition __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNumber *, NSString *> *)isStyleLayerPersistentForLayerId:(nonnull NSString *)layerId __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)removeStyleLayerForLayerId:(nonnull NSString *)layerId __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)moveStyleLayerForLayerId:(nonnull NSString *)layerId
                                                          layerPosition:(nullable MBMLayerPosition *)layerPosition __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)setStyleLayerPropertyForLayerId:(nonnull NSString *)layerId
                                                                      property:(nonnull NSString *)property
                                                                         value:(nonnull id)value __attribute((ns_returns_retained));
- (nonnull MBXExpected<id, NSString *> *)getStyleLayerPropertiesForLayerId:(nonnull NSString *)layerId __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)setStyleLayerPropertiesForLayerId:(nonnull NSString *)layerId
                                                                      properties:(nonnull id)properties __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)addStyleSourceForSourceId:(nonnull NSString *)sourceId
                                                              properties:(nonnull id)properties __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)setStyleSourcePropertyForSourceId:(nonnull NSString *)sourceId
                                                                        property:(nonnull NSString *)property
                                                                           value:(nonnull id)value __attribute((ns_returns_retained));
- (nonnull MBXExpected<id, NSString *> *)getStyleSourcePropertiesForSourceId:(nonnull NSString *)sourceId __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)setStyleSourcePropertiesForSourceId:(nonnull NSString *)sourceId
                                                                        properties:(nonnull id)properties __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)updateStyleImageSourceImageForSourceId:(nonnull NSString *)sourceId
                                                                                image:(nonnull MBMImage *)image __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)removeStyleSourceForSourceId:(nonnull NSString *)sourceId __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)setStyleLightForProperties:(nonnull id)properties __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)setStyleLightPropertyForProperty:(nonnull NSString *)property
                                                                          value:(nonnull id)value __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)setStyleTerrainForProperties:(nonnull id)properties __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)setStyleTerrainPropertyForProperty:(nonnull NSString *)property
                                                                            value:(nonnull id)value __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)setStyleProjectionForProperties:(nonnull id)properties __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)setStyleProjectionPropertyForProperty:(nonnull NSString *)property
                                                                               value:(nonnull id)value __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)addStyleImageForImageId:(nonnull NSString *)imageId
                                                                 scale:(float)scale
                                                                 image:(nonnull MBMImage *)image
                                                                   sdf:(BOOL)sdf
                                                              stretchX:(nonnull NSArray<MBMImageStretches *> *)stretchX
                                                              stretchY:(nonnull NSArray<MBMImageStretches *> *)stretchY
                                                               content:(nullable MBMImageContent *)content __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)removeStyleImageForImageId:(nonnull NSString *)imageId __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)addStyleCustomGeometrySourceForSourceId:(nonnull NSString *)sourceId
                                                                               options:(nonnull MBMCustomGeometrySourceOptions *)options __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)setStyleCustomGeometrySourceTileDataForSourceId:(nonnull NSString *)sourceId
                                                                                        tileId:(nonnull MBMCanonicalTileID *)tileId
                                                                             featureCollection:(nonnull NSArray<MBXFeature *> *)featureCollection __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)invalidateStyleCustomGeometrySourceTileForSourceId:(nonnull NSString *)sourceId
                                                                                           tileId:(nonnull MBMCanonicalTileID *)tileId __attribute((ns_returns_retained));
- (nonnull MBXExpected<NSNull *, NSString *> *)invalidateStyleCustomGeometrySourceRegionForSourceId:(nonnull NSString *)sourceId
                                                                                             bounds:(nonnull MBMCoordinateBounds *)bounds __attribute((ns_returns_retained));
@end
