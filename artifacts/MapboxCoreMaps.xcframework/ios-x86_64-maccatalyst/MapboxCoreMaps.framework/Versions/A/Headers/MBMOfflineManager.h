// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCoreMaps/MBMStylePackLoadProgressCallback.h>

@class MBMResourceOptions;
@class MBMStylePackLoadOptions;
@class MBMTilesetDescriptorOptions;
@class MBXCancelable;
@class MBXTilesetDescriptor;

/**
 * An `offline manager` manages downloads and storage for style packages and also produces tileset descriptors for the `tile store`.
 *
 * All the asynchronous methods calls complete even if the `offline manager` instance gets out of scope before.
 */
NS_SWIFT_NAME(OfflineManager)
__attribute__((visibility ("default")))
@interface MBMOfflineManager : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

/**
 * Construct a new `offline manager`.
 *
 * @param resourceOptions The `resource options` to manage.
 */
- (nonnull instancetype)initWithResourceOptions:(nonnull MBMResourceOptions *)resourceOptions;

/**
 * Construct a new `tileset descriptor` for the `tile store`.
 *
 * Tileset descriptors are used by the `tile store` to create new offline regions.
 * Resolving the created tileset descriptor includes loading and parsing the style and might include
 * creation or update of a style package - depending on the given options.
 *
 * @param tilesetDescriptorOptions The `tileset descriptor options` to manage.
 * @return A new `tileset descriptor`.
 */
- (nonnull MBXTilesetDescriptor *)createTilesetDescriptorForTilesetDescriptorOptions:(nonnull MBMTilesetDescriptorOptions *)tilesetDescriptorOptions __attribute((ns_returns_retained));
/**
 * Removes a style package.
 *
 * Removes a style package from the existing packages list. The actual resources
 * eviction might be deferred as the implementation can first put the resources to the disk cache.
 * Call `MapboxMap#clearData()` API to make sure all the temporary data is physically removed
 * from the disk cache.
 *
 * All pending loading operations for the style package with the given id will
 * fail with `Canceled` error.
 *
 * @param styleURI The URI of the style package's associated style
 */
- (void)removeStylePackForStyleURI:(nonnull NSString *)styleURI;

@end
