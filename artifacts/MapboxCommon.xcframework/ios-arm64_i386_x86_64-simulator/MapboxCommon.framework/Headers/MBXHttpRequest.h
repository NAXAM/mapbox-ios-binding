// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCommon/MBXHttpMethod.h>
#import <MapboxCommon/MBXNetworkRestriction.h>

@class MBXUAComponents;

/** HttpRequest holds basic information for construction of an HTTP request */
NS_SWIFT_NAME(HttpRequest)
__attribute__((visibility ("default")))
@interface MBXHttpRequest : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithUrl:(nonnull NSString *)url
                            headers:(nonnull NSDictionary<NSString *, NSString *> *)headers
                       uaComponents:(nonnull MBXUAComponents *)uaComponents
                               body:(nullable NSData *)body;

- (nonnull instancetype)initWithMethod:(MBXHttpMethod)method
                                   url:(nonnull NSString *)url
                               headers:(nonnull NSDictionary<NSString *, NSString *> *)headers
                       keepCompression:(BOOL)keepCompression
                               timeout:(uint64_t)timeout
                    networkRestriction:(MBXNetworkRestriction)networkRestriction
                          uaComponents:(nonnull MBXUAComponents *)uaComponents
                                  body:(nullable NSData *)body;

/**
 * HTTP defines a set of request methods to indicate the desired action to be performed for a given resource.
 * Specify desired method using this parameter.
 */
@property (nonatomic, readwrite) MBXHttpMethod method;

/** URL the request should be sent to */
@property (nonatomic, readonly, nonnull, copy) NSString *url;

/** HTTP headers to include */
@property (nonatomic, readwrite, nonnull, copy) NSDictionary<NSString *, NSString *> *headers;

/**
 * Keep compression flag. If set to true, responses will not be automatically decompressed.
 * Default is false.
 */
@property (nonatomic, readonly, getter=isKeepCompression) BOOL keepCompression;

/**
 * Timeout defines how long, in seconds, the request is allowed to take in total (including connecting to the host).
 * Default is 0, meaning no timeout.
 */
@property (nonatomic, readonly) uint64_t timeout;

/**
 * Restrict the request to the specified network types. If none of the specified network types is available, the
 * download fails with a connection error.
 *
 * Default is allowed to all network types
 */
@property (nonatomic, readonly) MBXNetworkRestriction networkRestriction;

/** Application and SDK information for generating a User-Agent string. */
@property (nonatomic, readonly, nonnull) MBXUAComponents *uaComponents;

/**
 * HTTP Body data transmitted in an HTTP transaction message immediatelly following the headers if there is any.
 * Body data is used by POST HTTP methods.
 */
@property (nonatomic, readonly, nullable) NSData *body;


@end
