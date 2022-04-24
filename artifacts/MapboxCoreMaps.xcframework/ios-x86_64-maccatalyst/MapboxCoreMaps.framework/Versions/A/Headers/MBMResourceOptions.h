// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCoreMaps/MBMTileStoreUsageMode.h>

@class MBXTileStore;

/** Options to configure a resource */
NS_SWIFT_NAME(ResourceOptions)
__attribute__((visibility ("default")))
@interface MBMResourceOptions : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithAccessToken:(nonnull NSString *)accessToken
                                    baseURL:(nullable NSString *)baseURL
                                   dataPath:(nullable NSString *)dataPath
                                  assetPath:(nullable NSString *)assetPath
                                  tileStore:(nullable MBXTileStore *)tileStore;

- (nonnull instancetype)initWithAccessToken:(nonnull NSString *)accessToken
                                    baseURL:(nullable NSString *)baseURL
                                   dataPath:(nullable NSString *)dataPath
                                  assetPath:(nullable NSString *)assetPath
                                  tileStore:(nullable MBXTileStore *)tileStore
                         tileStoreUsageMode:(MBMTileStoreUsageMode)tileStoreUsageMode;

/** The access token that is used to access resources provided by Mapbox services. */
@property (nonatomic, readonly, nonnull, copy) NSString *accessToken;

/** The base URL that would be used to make HTTP requests. By default it is `https://api.mapbox.com`. */
@property (nonatomic, readonly, nullable, copy) NSString *baseURL;

/**
 * The path to the map data folder.
 *
 * The implementation will use this folder for storing offline style packages and temporary data.
 *
 * The application must have sufficient permissions to create files within the provided directory.
 * If a dataPath is not provided, the default location will be used (the application data path defined
 * in the `Mapbox Common SystemInformation API`).
 */
@property (nonatomic, readonly, nullable, copy) NSString *dataPath;

/**
 * The path to the folder where application assets are located. Resources whose protocol is `asset://`
 * will be fetched from an asset folder or asset management system provided by respective platform.
 * This option is ignored for Android platform. An iOS application may provide path to an application bundle's path.
 */
@property (nonatomic, readonly, nullable, copy) NSString *assetPath;

/**
 * The tile store instance.
 *
 * This setting can be applied only if tile store usage is enabled,
 * otherwise it is ignored.
 *
 * If not set and tile store usage is enabled, a tile store at the default
 * location will be created and used.
 */
@property (nonatomic, readonly, nullable) MBXTileStore *tileStore;

/** The tile store usage mode. */
@property (nonatomic, readonly) MBMTileStoreUsageMode tileStoreUsageMode;


@end
