// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCoreMaps/MBMOfflineRegionDownloadState.h>

@class MBMOfflineRegionGeometryDefinition;
@class MBMOfflineRegionTilePyramidDefinition;
@protocol MBMOfflineRegionObserver;

/** An offline region represents an identifiable geographic region with optional metadata. */
NS_SWIFT_NAME(OfflineRegion)
__attribute__((visibility ("default")))
__attribute__((deprecated))
@interface MBMOfflineRegion : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

/** The regions identifier */
- (int64_t)getIdentifier;
/**
 * The tile pyramid defining the region. Tile pyramid and geometry definitions are
 * mutually exclusive.
 *
 * @return A definition describing the tile pyramid including attributes, otherwise empty.
 */
- (nullable MBMOfflineRegionTilePyramidDefinition *)getTilePyramidDefinition __attribute((ns_returns_retained));
/**
 * The geometry defining the region. Geometry and tile pyramid definitions are
 * mutually exclusive.
 *
 * @return A definition describing the geometry including attributes, otherwise empty.
 */
- (nullable MBMOfflineRegionGeometryDefinition *)getGeometryDefinition __attribute((ns_returns_retained));
/**
 * Arbitrary binary region metadata.
 *
 * @return The metadata associated with the region.
 */
- (nonnull NSData *)getMetadata __attribute((ns_returns_retained));
/**
 * Sets the download state of an offline region
 * A region is either inactive (not downloading, but previously-downloaded
 * resources are available for use), or active (resources are being downloaded
 * or will be downloaded, if necessary, when network access is available).
 *
 * If the region is already in the given state, this call is ignored.
 *
 * @param state The new state to set.
 */
- (void)setOfflineRegionDownloadStateForState:(MBMOfflineRegionDownloadState)state;
/**
 * Register an observer to be notified when the state of the region changes.
 *
 * @param observer The observer that will be notified when a region’s status changes.
 */
- (void)setOfflineRegionObserverForObserver:(nonnull id<MBMOfflineRegionObserver>)observer;

@end
