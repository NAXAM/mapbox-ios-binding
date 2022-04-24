// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

@class MBXHttpRequest;

/** Structure to configure download session. */
NS_SWIFT_NAME(DownloadOptions)
__attribute__((visibility ("default")))
@interface MBXDownloadOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithRequest:(nonnull MBXHttpRequest *)request
                              localPath:(nonnull NSString *)localPath;

- (nonnull instancetype)initWithRequest:(nonnull MBXHttpRequest *)request
                              localPath:(nonnull NSString *)localPath
                                 resume:(BOOL)resume;

/**
 * Structure which contains parameters to use for sending HTTP request.
 * Http method will be ignored from this request.
 */
@property (nonatomic, readwrite, nonnull) MBXHttpRequest *request;

/**
 * Absolute path where to store downloaded file. If a file with the specified name already exists and resume is set to
 * false, the existing file is overwritten.
 */
@property (nonatomic, readonly, nonnull, copy) NSString *localPath;

/** If localPath points to an existing file on disk, resume the download starting from an offset equal to file size. */
@property (nonatomic, readwrite, getter=isResume) BOOL resume;


@end
