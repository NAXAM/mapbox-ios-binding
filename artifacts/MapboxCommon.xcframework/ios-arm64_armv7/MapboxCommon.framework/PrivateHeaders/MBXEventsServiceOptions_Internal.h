// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

NS_SWIFT_NAME(EventsServiceOptions)
__attribute__((visibility ("default")))
@interface MBXEventsServiceOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithToken:(nonnull NSString *)token
                    userAgentFragment:(nonnull NSString *)userAgentFragment
                              baseURL:(nullable NSString *)baseURL;

@property (nonatomic, readonly, nonnull, copy) NSString *token;
@property (nonatomic, readonly, nonnull, copy) NSString *userAgentFragment;
@property (nonatomic, readonly, nullable, copy) NSString *baseURL;

@end
