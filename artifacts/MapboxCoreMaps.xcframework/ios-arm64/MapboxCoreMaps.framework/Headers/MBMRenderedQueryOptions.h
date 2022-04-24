// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Options for querying rendered features. */
NS_SWIFT_NAME(RenderedQueryOptions)
__attribute__((visibility ("default")))
@interface MBMRenderedQueryOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithLayerIds:(nullable NSArray<NSString *> *)layerIds
                                  filter:(nullable id)filter NS_REFINED_FOR_SWIFT;

/** Layer IDs to include in the query. */
@property (nonatomic, readonly, nullable, copy) NSArray<NSString *> *layerIds;

/** Filters the returned features with an expression */
@property (nonatomic, readonly, nullable, copy) id filter NS_REFINED_FOR_SWIFT;


@end
