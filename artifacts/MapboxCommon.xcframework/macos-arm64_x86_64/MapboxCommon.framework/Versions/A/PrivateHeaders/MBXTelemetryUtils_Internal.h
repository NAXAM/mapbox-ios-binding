// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import "MBXTelemetryUtilsResponseCallback_Internal.h"

NS_SWIFT_NAME(TelemetryUtils)
__attribute__((visibility ("default")))
@interface MBXTelemetryUtils : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

+ (void)setEventsCollectionStateForEnableCollection:(BOOL)enableCollection
                                           callback:(nullable MBXTelemetryUtilsResponseCallback)callback;
+ (BOOL)getEventsCollectionState;
+ (nonnull NSString *)getUserID __attribute((ns_returns_retained));

@end
