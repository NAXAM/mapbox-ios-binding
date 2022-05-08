// This file is generated and will be overwritten automatically.

#import "MBXTileStore.h"
#import "MBXResourceLoadProgressCallback_Internal.h"
#import "MBXResourceLoadResultCallback_Internal.h"
#import "MBXTileRegionBooleanCallback_Internal.h"
#import "MBXTileRegionCallback_Internal.h"
#import "MBXTileRegionGeometryCallback_Internal.h"
#import "MBXTileRegionMetadataCallback_Internal.h"
#import "MBXTileRegionsCallback_Internal.h"

@interface MBXTileStore ()
- (void)addObserverForObserver:(nonnull id<MBXTileStoreObserver>)observer NS_REFINED_FOR_SWIFT;
- (void)removeObserverForObserver:(nonnull id<MBXTileStoreObserver>)observer NS_REFINED_FOR_SWIFT;
- (nonnull MBXCancelable *)loadTileRegionForId:(nonnull NSString *)id
                                   loadOptions:(nonnull MBXTileRegionLoadOptions *)loadOptions
                                    onProgress:(nonnull MBXTileRegionLoadProgressCallback)onProgress
                                    onFinished:(nonnull MBXTileRegionCallback)onFinished __attribute((ns_returns_retained)) NS_REFINED_FOR_SWIFT;
- (nonnull MBXCancelable *)loadTileRegionForId:(nonnull NSString *)id
                                   loadOptions:(nonnull MBXTileRegionLoadOptions *)loadOptions
                                    onFinished:(nonnull MBXTileRegionCallback)onFinished __attribute((ns_returns_retained)) NS_REFINED_FOR_SWIFT;
- (nonnull MBXCancelable *)loadResourceForDescription:(nonnull MBXResourceDescription *)description
                                              options:(nonnull MBXResourceLoadOptions *)options
                                     progressCallback:(nonnull MBXResourceLoadProgressCallback)progressCallback
                                       resultCallback:(nonnull MBXResourceLoadResultCallback)resultCallback __attribute((ns_returns_retained));
- (void)tileRegionContainsDescriptorsForId:(nonnull NSString *)id
                               descriptors:(nonnull NSArray<MBXTilesetDescriptor *> *)descriptors
                                  callback:(nonnull MBXTileRegionBooleanCallback)callback NS_REFINED_FOR_SWIFT;
- (void)getAllTileRegionsForCallback:(nonnull MBXTileRegionsCallback)callback NS_REFINED_FOR_SWIFT;
- (void)getTileRegionForId:(nonnull NSString *)id
                  callback:(nonnull MBXTileRegionCallback)callback NS_REFINED_FOR_SWIFT;
- (void)getTileRegionGeometryForId:(nonnull NSString *)id
                          callback:(nonnull MBXTileRegionGeometryCallback)callback NS_REFINED_FOR_SWIFT;
- (void)getTileRegionMetadataForId:(nonnull NSString *)id
                          callback:(nonnull MBXTileRegionMetadataCallback)callback NS_REFINED_FOR_SWIFT;
- (void)removeTileRegionForId:(nonnull NSString *)id
                     callback:(nonnull MBXTileRegionCallback)callback NS_REFINED_FOR_SWIFT;
- (void)computeCoveredAreaForDescriptors:(nonnull NSArray<MBXTilesetDescriptor *> *)descriptors
                                callback:(nonnull MBXTileRegionGeometryCallback)callback;
@end
