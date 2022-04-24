// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Options for querying source features. */
NS_SWIFT_NAME(SourceQueryOptions)
__attribute__((visibility ("default")))
@interface MBMSourceQueryOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithSourceLayerIds:(nullable NSArray<NSString *> *)sourceLayerIds
                                        filter:(nonnull id)filter;

/** Source layer IDs to include in the query. */
@property (nonatomic, readonly, nullable, copy) NSArray<NSString *> *sourceLayerIds;

/** Filters the returned features with an expression */
@property (nonatomic, readonly, nonnull, copy) id filter;


@end
