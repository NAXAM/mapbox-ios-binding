// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import "MBXEventsServiceResponseCallback_Internal.h"

@class MBXEvent;
@class MBXEventsServiceOptions;
@class MBXTurnstileEvent;
@protocol MBXEventsServiceObserver;

NS_SWIFT_NAME(EventsService)
__attribute__((visibility ("default")))
@interface MBXEventsService : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithOptions:(nonnull MBXEventsServiceOptions *)options;

- (void)registerObserverForObserver:(nonnull id<MBXEventsServiceObserver>)observer;
- (void)unregisterObserverForObserver:(nonnull id<MBXEventsServiceObserver>)observer;
- (void)sendTurnstileEventForTurnstileEvent:(nonnull MBXTurnstileEvent *)turnstileEvent
                                   callback:(nullable MBXEventsServiceResponseCallback)callback;
- (void)sendEventForEvent:(nonnull MBXEvent *)event
                 callback:(nullable MBXEventsServiceResponseCallback)callback;
- (void)pauseEventsCollection;
- (void)resumeEventsCollection;

@end
