// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Settings class provides non-persistent, in-process key-value storage. */
NS_SWIFT_NAME(Settings)
__attribute__((visibility ("default")))
__attribute__((deprecated))
@interface MBMSettings : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

/**
 * Sets setting value for a specified key.
 *
 * @param key A name of the key.
 * @param value The `value` for the key.
 */
+ (void)setForKey:(nonnull NSString *)key
            value:(nonnull id)value;
/**
 * Return value for a key.
 *
 * @param key A name of the key.
 *
 * @return `value` if a key exists in settings otherwise a `null value` will be returned.
 */
+ (nonnull id)getForKey:(nonnull NSString *)key __attribute((ns_returns_retained));

@end
