// This file is generated and will be overwritten automatically.

#import "MBMOfflineRegionManager.h"
#import "MBMOfflineDatabaseMergeCallback_Internal.h"
#import "MBMOfflineRegionCallback_Internal.h"
#import "MBMOfflineRegionCreateCallback_Internal.h"

@interface MBMOfflineRegionManager ()
- (void)getOfflineRegionsForCallback:(nonnull MBMOfflineRegionCallback)callback;
- (void)createOfflineRegionForGeometryDefinition:(nonnull MBMOfflineRegionGeometryDefinition *)geometryDefinition
                                        callback:(nonnull MBMOfflineRegionCreateCallback)callback;
- (void)createOfflineRegionForTilePyramidDefinition:(nonnull MBMOfflineRegionTilePyramidDefinition *)tilePyramidDefinition
                                           callback:(nonnull MBMOfflineRegionCreateCallback)callback;
- (void)mergeOfflineDatabaseForFilePath:(nonnull NSString *)filePath
                               callback:(nonnull MBMOfflineDatabaseMergeCallback)callback;
@end
