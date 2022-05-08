// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import "MBXTileDataDomain.h"

NS_SWIFT_NAME(ResourceDescription)
__attribute__((visibility ("default")))
@interface MBXResourceDescription : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithUrl:(nonnull NSString *)url
                             domain:(MBXTileDataDomain)domain;

@property (nonatomic, readonly, nonnull, copy) NSString *url;
@property (nonatomic, readonly) MBXTileDataDomain domain;

- (BOOL)isEqualToResourceDescription:(nonnull MBXResourceDescription *)other;

@end
