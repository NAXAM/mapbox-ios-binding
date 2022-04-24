// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Enum which represents different error cases which could happen during download session. */
// NOLINTNEXTLINE(modernize-use-using)
typedef NS_ENUM(NSInteger, MBXDownloadErrorCode)
{
    /** General filesystem related error code. For cases like: write error, no such file or directory, not enough space and etc. */
    MBXDownloadErrorCodeFileSystemError,
    /** General network related error. Should be probably representation of HttpRequestError. */
    MBXDownloadErrorCodeNetworkError
} NS_SWIFT_NAME(DownloadErrorCode);

NSString* MBXDownloadErrorCodeToString(MBXDownloadErrorCode download_error_code);
