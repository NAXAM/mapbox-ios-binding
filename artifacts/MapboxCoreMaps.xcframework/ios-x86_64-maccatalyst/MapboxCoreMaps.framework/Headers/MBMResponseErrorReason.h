// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Describes the reason for an offline request response error. */
// NOLINTNEXTLINE(modernize-use-using)
typedef NS_ENUM(NSInteger, MBMResponseErrorReason)
{
    /** The resource is not found. */
    MBMResponseErrorReasonNotFound,
    /** The server error. */
    MBMResponseErrorReasonServer,
    /** The connection error. */
    MBMResponseErrorReasonConnection,
    /** The error happened because of a rate limit. */
    MBMResponseErrorReasonRateLimit,
    /** Other reason. */
    MBMResponseErrorReasonOther
} NS_SWIFT_NAME(ResponseErrorReason) __attribute__((deprecated));
