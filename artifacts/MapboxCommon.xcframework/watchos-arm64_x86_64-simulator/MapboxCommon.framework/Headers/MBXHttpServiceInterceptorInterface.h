// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

@class MBXDownloadOptions;
@class MBXHttpRequest;
@class MBXHttpResponse;

/** Interface for intercepting and modifying HttpService function calls. */
NS_SWIFT_NAME(HttpServiceInterceptorInterface)
@protocol MBXHttpServiceInterceptorInterface
/**
 * The function to intercept HTTP requests with.
 * @param request The original HttpRequest object to be modified.
 *
 * @return The modified HttpRequest object.
 */
- (nonnull MBXHttpRequest *)onRequestForRequest:(nonnull MBXHttpRequest *)request;
/**
 * The function to intercept HTTP download options with.
 * @param download The original DownloadOptions object to be modified.
 *
 * @return The modified DownloadOptions object.
 */
- (nonnull MBXDownloadOptions *)onDownloadForDownload:(nonnull MBXDownloadOptions *)download;
/**
 * The function to intercept HTTP responses with.
 * @param response The original HttpResponse object to be modified.
 *
 * @return The modified HttpResponse object.
 */
- (nonnull MBXHttpResponse *)onResponseForResponse:(nonnull MBXHttpResponse *)response;
@end
