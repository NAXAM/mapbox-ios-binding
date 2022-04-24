// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

@class MBMEvent;

/** An `observer` interface used to subscribe for an `observable` events. */
NS_SWIFT_NAME(Observer)
@protocol MBMObserver
/**
 * Notifies an `observer` about an `event`.
 *
 * @param event An `event` emitted by the `observable`.
 */
- (void)notifyForEvent:(nonnull MBMEvent *)event;
@end
