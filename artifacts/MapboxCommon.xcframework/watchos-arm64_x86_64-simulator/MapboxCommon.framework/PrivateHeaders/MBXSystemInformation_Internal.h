// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCommon/MBXPlatform_Internal.h>

NS_SWIFT_NAME(SystemInformation)
__attribute__((visibility ("default")))
@interface MBXSystemInformation : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithPlatform:(MBXPlatform)platform
                            platformName:(nonnull NSString *)platformName
                         platformVersion:(nonnull NSString *)platformVersion
                         applicationName:(nonnull NSString *)applicationName
                      applicationPackage:(nullable NSString *)applicationPackage
                      applicationVersion:(nonnull NSString *)applicationVersion
                  applicationBuildNumber:(nonnull NSString *)applicationBuildNumber
                                  device:(nonnull NSString *)device
                     applicationDataPath:(nonnull NSString *)applicationDataPath
                        isPhysicalDevice:(BOOL)isPhysicalDevice
                defaultMapboxAccessToken:(nullable NSString *)defaultMapboxAccessToken
                    applicationCachePath:(nonnull NSString *)applicationCachePath;

@property (nonatomic, readonly) MBXPlatform platform;
@property (nonatomic, readonly, nonnull, copy) NSString *platformName;
@property (nonatomic, readonly, nonnull, copy) NSString *platformVersion;
@property (nonatomic, readonly, nonnull, copy) NSString *applicationName;
@property (nonatomic, readonly, nullable, copy) NSString *applicationPackage;
@property (nonatomic, readonly, nonnull, copy) NSString *applicationVersion;
@property (nonatomic, readonly, nonnull, copy) NSString *applicationBuildNumber;
@property (nonatomic, readonly, nonnull, copy) NSString *device;
@property (nonatomic, readonly, nonnull, copy) NSString *applicationDataPath;
@property (nonatomic, readonly, getter=isIsPhysicalDevice) BOOL isPhysicalDevice;
@property (nonatomic, readonly, nullable, copy) NSString *defaultMapboxAccessToken;
@property (nonatomic, readonly, nonnull, copy) NSString *applicationCachePath;

@end
