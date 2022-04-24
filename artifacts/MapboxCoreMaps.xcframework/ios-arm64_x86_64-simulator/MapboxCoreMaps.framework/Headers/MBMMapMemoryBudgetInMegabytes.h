// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Map memory budget in megabytes. */
NS_SWIFT_NAME(MapMemoryBudgetInMegabytes)
__attribute__((visibility ("default")))
@interface MBMMapMemoryBudgetInMegabytes : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithSize:(uint64_t)size;

@property (nonatomic, readonly) uint64_t size;

- (BOOL)isEqualToMapMemoryBudgetInMegabytes:(nonnull MBMMapMemoryBudgetInMegabytes *)other;

@end
