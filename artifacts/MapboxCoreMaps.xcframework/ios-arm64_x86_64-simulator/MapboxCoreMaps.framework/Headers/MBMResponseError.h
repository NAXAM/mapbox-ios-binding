// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCoreMaps/MBMResponseErrorReason.h>

/** Describes an offline request response error. */
NS_SWIFT_NAME(ResponseError)
__attribute__((visibility ("default")))
__attribute__((deprecated))
@interface MBMResponseError : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithReason:(MBMResponseErrorReason)reason
                               message:(nonnull NSString *)message
                            retryAfter:(nullable NSDate *)retryAfter;

/** The reason for the response error. */
@property (nonatomic, readonly) MBMResponseErrorReason reason;

/** An error message */
@property (nonatomic, readonly, nonnull, copy) NSString *message;

/** Time after which to try again. */
@property (nonatomic, readonly, nullable) NSDate *retryAfter;


@end
