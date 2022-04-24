// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Generic Event type used to notify an `observer`. */
NS_SWIFT_NAME(Event)
__attribute__((visibility ("default")))
@interface MBMEvent : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithType:(nonnull NSString *)type
                                data:(nonnull id)data;

/** Type of the event. */
@property (nonatomic, readonly, nonnull, copy) NSString *type;

/**
 * Generic container for an event's data (Object). By default, event data will contain `begin` key, whose value
 * is a number representing timestamp taken at the time of an event creation, in microseconds, since the epoch.
 * For an interval events, an optional `end` property will be present that represents timestamp taken at the time
 * of an event completion. Additional data properties are docummented by respective events.
 *
 * ``` text
 * Event data format (Object):
 * .
 * ├── begin - Number
 * └── end - optional Number
 * ```
 */
@property (nonatomic, readonly, nonnull, copy) id data;


@end
