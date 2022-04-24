// This file is generated and will be overwritten automatically.

#import <MapboxCoreMaps/MBMOfflineRegionManager.h>
#import <MapboxCoreMaps/MBMOfflineDatabaseMergeCallback_Internal.h>
#import <MapboxCoreMaps/MBMOfflineRegionCallback_Internal.h>
#import <MapboxCoreMaps/MBMOfflineRegionCreateCallback_Internal.h>

@interface MBMOfflineRegionManager ()
- (void)getOfflineRegionsForCallback:(nonnull MBMOfflineRegionCallback)callback;
- (void)createOfflineRegionForGeometryDefinition:(nonnull MBMOfflineRegionGeometryDefinition *)geometryDefinition
                                        callback:(nonnull MBMOfflineRegionCreateCallback)callback;
- (void)createOfflineRegionForTilePyramidDefinition:(nonnull MBMOfflineRegionTilePyramidDefinition *)tilePyramidDefinition
                                           callback:(nonnull MBMOfflineRegionCreateCallback)callback;
- (void)mergeOfflineDatabaseForFilePath:(nonnull NSString *)filePath
                               callback:(nonnull MBMOfflineDatabaseMergeCallback)callback;
@end
