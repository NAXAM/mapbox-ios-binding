// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Enum representing state of download session. */
// NOLINTNEXTLINE(modernize-use-using)
typedef NS_ENUM(NSInteger, MBXDownloadState)
{
    /** Download session initiated but not started yet. */
    MBXDownloadStatePending,
    /** Download session is in progress. */
    MBXDownloadStateDownloading,
    /** Download session failed. */
    MBXDownloadStateFailed,
    /** Download session successfully finished. */
    MBXDownloadStateFinished
} NS_SWIFT_NAME(DownloadState);
