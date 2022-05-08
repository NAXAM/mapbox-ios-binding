// This file is generated and will be overwritten automatically.

#import "MBXHttpResponse.h"

@interface MBXHttpResponse ()
- (nonnull instancetype)initWithRequest:(nonnull MBXHttpRequest *)request
                                 result:(nonnull MBXExpected<MBXHttpResponseData *, MBXHttpRequestError *> *)result NS_REFINED_FOR_SWIFT;
@property (nonatomic, readonly, nonnull) MBXExpected<MBXHttpResponseData *, MBXHttpRequestError *> *result NS_REFINED_FOR_SWIFT;
@end
