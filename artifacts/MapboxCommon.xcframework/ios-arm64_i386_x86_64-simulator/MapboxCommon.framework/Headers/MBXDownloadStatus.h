// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCommon/MBXDownloadState.h>
@class MBXExpected;

@class MBXDownloadError;
@class MBXDownloadOptions;
@class MBXHttpRequestError;
@class MBXHttpResponseData;

/** Structure to hold current status information about ongoing download session. */
NS_SWIFT_NAME(DownloadStatus)
__attribute__((visibility ("default")))
@interface MBXDownloadStatus : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;


/** Download id which was created by download request. */
@property (nonatomic, readwrite) uint64_t downloadId;

/** State of download request. */
@property (nonatomic, readwrite) MBXDownloadState state;

/** The optional which contains error information in case of failure when state is set to DownloadState::Failed. */
@property (nonatomic, readwrite, nullable) MBXDownloadError *error;

/** Total amount of bytes to receive. In some cases this value is unknown until we get final part of the file. */
@property (nonatomic, readwrite, nullable) NSNumber *totalBytes NS_REFINED_FOR_SWIFT;

/**
 * Amount of bytes already received and saved on the disk. Includes previous download attempts for a resumed
 * download.
 */
@property (nonatomic, readwrite) uint64_t receivedBytes;

/**
 * Amount of bytes received during the current resume attempt. For downloads that weren't resumed,
 * this value will be the same as receivedBytes.
 */
@property (nonatomic, readwrite) uint64_t transferredBytes;

/** Download options used to send the download request. */
@property (nonatomic, readwrite, nonnull) MBXDownloadOptions *downloadOptions;


@end
