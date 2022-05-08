// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import "MBXUserSKUIdentifier_Internal.h"

NS_SWIFT_NAME(TurnstileEvent)
__attribute__((visibility ("default")))
@interface MBXTurnstileEvent : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithSkuId:(MBXUserSKUIdentifier)skuId
                        sdkIdentifier:(nonnull NSString *)sdkIdentifier
                           sdkVersion:(nonnull NSString *)sdkVersion;

@property (nonatomic, readonly) MBXUserSKUIdentifier skuId;
@property (nonatomic, readonly, nonnull, copy) NSString *sdkIdentifier;
@property (nonatomic, readonly, nonnull, copy) NSString *sdkVersion;

@end
