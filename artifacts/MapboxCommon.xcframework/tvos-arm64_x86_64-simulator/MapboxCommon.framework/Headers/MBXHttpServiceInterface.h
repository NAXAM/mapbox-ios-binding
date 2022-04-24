// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCommon/MBXDownloadStatusCallback.h>
#import <MapboxCommon/MBXHttpResponseCallback.h>
#import <MapboxCommon/MBXResultCallback.h>

@class MBXDownloadOptions;
@class MBXHttpRequest;
@protocol MBXHttpServiceInterceptorInterface;

/**
 * Interface to the HTTP service.
 * This interface provides basic functionality that allows exchanging HTTP requests/responses between client and server
 * in an asynchronous way.
 */
NS_SWIFT_NAME(HttpServiceInterface)
@protocol MBXHttpServiceInterface
/**
 * Set an interceptor for the HttpService's function calls.
 *
 * @param interceptor The interceptor to be set.
 */
- (void)setInterceptorForInterceptor:(nullable id<MBXHttpServiceInterceptorInterface>)interceptor;
/**
 * Set maximum number of requests to a single host.
 *
 * @param max Maximum number of requests.
 *
 * Default value for cURL is 0 (which means unlimited)
 * Default value for OkHttp is unspecified
 * Default value for NSURLSession is 8
 */
- (void)setMaxRequestsPerHostForMax:(uint8_t)max;
/**
 * Sends (or enqueues) a platform's native HTTP Request.
 *
 * @param request HttpRequest to provide url, headers and other information.
 * @param callback Callback to be called in response to the request.
 *
 * @return ID handle to cancel the request.
 */
- (uint64_t)requestForRequest:(nonnull MBXHttpRequest *)request
                     callback:(nonnull MBXHttpResponseCallback)callback;
/**
 * Cancels a pending or running request (or download request).
 * In case of success, the result of the HttpResponse in the requests callback will hold the error RequestCancelled
 *
 * @param id Handle given by request() or download() methods.
 * @param callback Callback to be called after attempt to cancel requests. Use this for error handling related to the id. It does not report if the request gets actually cancelled.
 */
- (void)cancelRequestForId:(uint64_t)id
                  callback:(nonnull MBXResultCallback)callback;
/** Returns true when the HTTP service supports the keepCompression flag for HTTP requests, false otherwise. */
- (BOOL)supportsKeepCompression;
/**
 * Send the download request.
 *        Successful request initiates download session to fetch requested resource.
 *
 * @param options Download options describing url to download from and place on the disk where to save.
 * @param callback Callback to report status of download session.
 *
 * @return Download id to observe and to cancel the download session.
 */
- (uint64_t)downloadForOptions:(nonnull MBXDownloadOptions *)options
                      callback:(nonnull MBXDownloadStatusCallback)callback;
@end
