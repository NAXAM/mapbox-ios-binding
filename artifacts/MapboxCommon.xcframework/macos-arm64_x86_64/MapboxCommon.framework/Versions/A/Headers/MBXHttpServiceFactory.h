// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

@protocol MBXHttpServiceInterface;

/**
 * HTTP service factory.
 *
 * This class is used to get a pointer/reference to HTTP service platform implementation.
 * In order to set a custom implementation, the client must call `setUserDefined()` method once before any actual HTTP service is required.
 */
NS_SWIFT_NAME(HttpServiceFactory)
__attribute__((visibility ("default")))
@interface MBXHttpServiceFactory : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

/**
 * Replaces the implementation of the HTTP service with a custom one.
 *
 * If a default implementation has been created or previous a user defined implementation has been set already,
 * it will be replaced. The factory maintains a strong reference to the provided implementation
 * which can be released with the reset() method.
 */
+ (void)setUserDefinedForCustom:(nonnull id<MBXHttpServiceInterface>)custom;
/**
 * Releases the implementation of the HTTP service.
 *
 * The strong reference from the factory to a custom HTTP service implementation will be released. This can be
 * used to release the HTTP service implementation once it is no longer needed. It may otherwise be kept until
 * the end of the program.
 */
+ (void)reset;
/**
 * Returns an instance of the HTTP service.
 *
 * If a user defined implementation has been set with setUserDefined(), it will be returned.
 * Otherwise, a default implementation is allocated on the first call of after a call to reset().
 * The default implementation is kept until a call to reset() or setUserDefined() releases it.
 */
+ (nonnull id<MBXHttpServiceInterface>)getInstance __attribute((ns_returns_retained));

@end
