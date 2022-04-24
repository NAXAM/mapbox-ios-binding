// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
@class MBXFeature;

/**
 * Represents query result that is returned in QueryFeaturesCallback.
 * @see `queryRenderedFeatures` or `querySourceFeatures`
 */
NS_SWIFT_NAME(QueriedFeature)
__attribute__((visibility ("default")))
@interface MBMQueriedFeature : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithFeature:(nonnull MBXFeature *)feature
                                 source:(nonnull NSString *)source
                            sourceLayer:(nullable NSString *)sourceLayer
                                  state:(nonnull id)state NS_REFINED_FOR_SWIFT;

/** Feature returned by the query. */
@property (nonatomic, readonly, nonnull) MBXFeature *feature NS_REFINED_FOR_SWIFT;

/** Source id for a queried feature. */
@property (nonatomic, readonly, nonnull, copy) NSString *source;

/**
 * Source layer id for a queried feature. May be null if source does not support layers, e.g., 'geojson' source,
 * or when data provided by the source is not layered.
 */
@property (nonatomic, readonly, nullable, copy) NSString *sourceLayer;

/**
 * Feature state for a queried feature. Type of the value is an Object.
 * @see `setFeatureState` and `getFeatureState`
 */
@property (nonatomic, readonly, nonnull, copy) id state;


@end
