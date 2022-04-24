// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

@protocol MBMObserver;

/**
 * The `observable` interface provides basic Publish&Subscribe functionality. Classes that extend
 * this functionality and capable of generating events, have to specify event types and
 * corresponding data format for an event.
 */
NS_SWIFT_NAME(Observable)
__attribute__((visibility ("default")))
@interface MBMObservable : NSObject

/**
 * Subscribes an `observer` to a provided array of event types.
 * The `observable` will hold a strong reference to an `observer` instance, therefore,
 * in order to stop receiving notifications, caller must call `unsubscribe` with an
 * `observer` instance used for an initial subscription.
 *
 * @param observer An `observer` that will be subscribed to a given events.
 * @param events An array of event types to be subscribed to.
 */
- (void)subscribeForObserver:(nonnull id<MBMObserver>)observer
                      events:(nonnull NSArray<NSString *> *)events;
/**
 * Unsubscribes an `observer` from a provided array of event types.
 *
 * @param observer An `observer` that will be unsubscribed from a given events.
 * @param events An array of event types to be unsubscribed from.
 */
- (void)unsubscribeForObserver:(nonnull id<MBMObserver>)observer
                        events:(nonnull NSArray<NSString *> *)events;
/**
 * Unsubscribes an `observer` from all events.
 *
 * @param observer An `observer` that will be unsubscribed from all previously subscribed events.
 */
- (void)unsubscribeForObserver:(nonnull id<MBMObserver>)observer;

@end
