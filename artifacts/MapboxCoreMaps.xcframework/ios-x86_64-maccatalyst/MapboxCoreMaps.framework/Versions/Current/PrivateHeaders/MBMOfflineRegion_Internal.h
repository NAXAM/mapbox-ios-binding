// This file is generated and will be overwritten automatically.

#import <MapboxCoreMaps/MBMOfflineRegion.h>
#import <MapboxCoreMaps/MBMAsyncOperationResultCallback_Internal.h>
#import <MapboxCoreMaps/MBMOfflineRegionStatusCallback_Internal.h>

@interface MBMOfflineRegion ()
- (void)setMetadataForMetadata:(nonnull NSData *)metadata
                      callback:(nonnull MBMAsyncOperationResultCallback)callback;
- (void)invalidateForCallback:(nonnull MBMAsyncOperationResultCallback)callback;
- (void)purgeForCallback:(nonnull MBMAsyncOperationResultCallback)callback;
- (void)getStatusForCallback:(nonnull MBMOfflineRegionStatusCallback)callback;
@end
