// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCommon/MBXBillingSessionStatus_Internal.h>
#import <MapboxCommon/MBXOnBillingServiceError_Internal.h>
#import <MapboxCommon/MBXSessionSKUIdentifier_Internal.h>
#import <MapboxCommon/MBXUserSKUIdentifier_Internal.h>

NS_SWIFT_NAME(BillingServiceInterface)
@protocol MBXBillingServiceInterface
- (void)triggerUserBillingEventForAccessToken:(nonnull NSString *)accessToken
                                    userAgent:(nonnull NSString *)userAgent
                                skuIdentifier:(MBXUserSKUIdentifier)skuIdentifier
                                     callback:(nonnull MBXOnBillingServiceError)callback;
- (void)beginBillingSessionForAccessToken:(nonnull NSString *)accessToken
                                userAgent:(nonnull NSString *)userAgent
                            skuIdentifier:(MBXSessionSKUIdentifier)skuIdentifier
                                 callback:(nonnull MBXOnBillingServiceError)callback
                                 validity:(NSTimeInterval)validity;
- (void)pauseBillingSessionForSkuIdentifier:(MBXSessionSKUIdentifier)skuIdentifier;
- (void)resumeBillingSessionForSkuIdentifier:(MBXSessionSKUIdentifier)skuIdentifier
                                    callback:(nonnull MBXOnBillingServiceError)callback;
- (void)stopBillingSessionForSkuIdentifier:(MBXSessionSKUIdentifier)skuIdentifier;
- (MBXBillingSessionStatus)getSessionStatusForSkuIdentifier:(MBXSessionSKUIdentifier)skuIdentifier;
- (nonnull NSString *)getSessionSKUTokenIfValidForSkuIdentifier:(MBXSessionSKUIdentifier)skuIdentifier;
- (nonnull NSString *)getUserSKUTokenForSkuIdentifier:(MBXUserSKUIdentifier)skuIdentifier;
@end
