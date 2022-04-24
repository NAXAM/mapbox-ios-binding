// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Map memory budget in tiles. */
NS_SWIFT_NAME(MapMemoryBudgetInTiles)
__attribute__((visibility ("default")))
@interface MBMMapMemoryBudgetInTiles : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithSize:(uint64_t)size;

@property (nonatomic, readonly) uint64_t size;

- (BOOL)isEqualToMapMemoryBudgetInTiles:(nonnull MBMMapMemoryBudgetInTiles *)other;

@end
