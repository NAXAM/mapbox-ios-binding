// This file is generated and will be overwritten automatically.

#import "MBMOfflineRegion.h"
#import "MBMAsyncOperationResultCallback_Internal.h"
#import "MBMOfflineRegionStatusCallback_Internal.h"

@interface MBMOfflineRegion ()
- (void)setMetadataForMetadata:(nonnull NSData *)metadata
                      callback:(nonnull MBMAsyncOperationResultCallback)callback;
- (void)invalidateForCallback:(nonnull MBMAsyncOperationResultCallback)callback;
- (void)purgeForCallback:(nonnull MBMAsyncOperationResultCallback)callback;
- (void)getStatusForCallback:(nonnull MBMOfflineRegionStatusCallback)callback;
@end
