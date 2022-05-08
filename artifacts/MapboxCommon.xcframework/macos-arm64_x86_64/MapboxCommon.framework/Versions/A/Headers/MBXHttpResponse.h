// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
@class MBXExpected<__covariant Value, __covariant Error>;

@class MBXHttpRequest;
@class MBXHttpRequestError;
@class MBXHttpResponseData;

/** Record which is used to report HTTP response to the caller. */
NS_SWIFT_NAME(HttpResponse)
__attribute__((visibility ("default")))
@interface MBXHttpResponse : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;


/** HTTP request data which was use to send HTTP request. */
@property (nonatomic, readonly, nonnull) MBXHttpRequest *request;


@end
