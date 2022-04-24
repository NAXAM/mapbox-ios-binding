// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/**
 * Callback invoked once a request operation completes.
 *
 * In case of cancel request, this callback does not report if
 * the actual cancelation worked or not.
 *
 * @param result \c true on successfull call; otherwise, it is invoked with \c false.
 */
NS_SWIFT_NAME(ResultCallback)
typedef void (^MBXResultCallback)(BOOL result); // NOLINT(modernize-use-using)
