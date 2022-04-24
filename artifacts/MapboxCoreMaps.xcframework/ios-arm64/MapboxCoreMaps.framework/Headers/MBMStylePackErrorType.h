// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Describes the reason for a style package download request failure. */
// NOLINTNEXTLINE(modernize-use-using)
typedef NS_ENUM(NSInteger, MBMStylePackErrorType)
{
    /** The operation was canceled. */
    MBMStylePackErrorTypeCanceled,
    /** The style package does not exist. */
    MBMStylePackErrorTypeDoesNotExist,
    /** There is no available space to store the resources. */
    MBMStylePackErrorTypeDiskFull,
    /** Other reason. */
    MBMStylePackErrorTypeOther
} NS_SWIFT_NAME(StylePackErrorType);

NSString* MBMStylePackErrorTypeToString(MBMStylePackErrorType style_pack_error_type);
