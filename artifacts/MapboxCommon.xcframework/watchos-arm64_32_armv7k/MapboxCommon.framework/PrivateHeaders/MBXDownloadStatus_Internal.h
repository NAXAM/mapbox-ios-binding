// This file is generated and will be overwritten automatically.

#import <MapboxCommon/MBXDownloadStatus.h>

@interface MBXDownloadStatus ()
- (nonnull instancetype)initWithDownloadId:(uint64_t)downloadId
                                     state:(MBXDownloadState)state
                                     error:(nullable MBXDownloadError *)error
                                totalBytes:(nullable NSNumber *)totalBytes
                             receivedBytes:(uint64_t)receivedBytes
                          transferredBytes:(uint64_t)transferredBytes
                           downloadOptions:(nonnull MBXDownloadOptions *)downloadOptions
                                httpResult:(nullable MBXExpected *)httpResult NS_REFINED_FOR_SWIFT;
- (nonnull instancetype)initWithError:(nullable MBXDownloadError *)error
                           totalBytes:(nullable NSNumber *)totalBytes
                      downloadOptions:(nonnull MBXDownloadOptions *)downloadOptions
                           httpResult:(nullable MBXExpected *)httpResult NS_REFINED_FOR_SWIFT;

@property (nonatomic, readwrite, nullable) MBXExpected *httpResult NS_REFINED_FOR_SWIFT;
@end
