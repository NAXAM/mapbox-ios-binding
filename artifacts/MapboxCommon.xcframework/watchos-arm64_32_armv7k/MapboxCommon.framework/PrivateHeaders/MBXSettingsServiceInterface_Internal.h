// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import "MBXOnValueChanged_Internal.h"
@class MBXExpected<__covariant Value, __covariant Error>;

NS_SWIFT_NAME(SettingsServiceInterface)
@protocol MBXSettingsServiceInterface
- (nonnull MBXExpected<NSNull *, NSString *> *)setForKey:(nonnull NSString *)key
                                                   value:(nonnull id)value;
- (nonnull MBXExpected<id, NSString *> *)getForKey:(nonnull NSString *)key;
- (nonnull MBXExpected<id, NSString *> *)getForKey:(nonnull NSString *)key
                                      defaultValue:(nonnull id)defaultValue;
- (nonnull MBXExpected<NSNull *, NSString *> *)eraseForKey:(nonnull NSString *)key;
- (nonnull MBXExpected<NSNumber *, NSString *> *)hasForKey:(nonnull NSString *)key;
- (int32_t)registerObserverForKey:(nonnull NSString *)key
                         observer:(nonnull MBXOnValueChanged)observer;
- (void)unregisterObserverForObserverId:(int32_t)observerId;
@end
