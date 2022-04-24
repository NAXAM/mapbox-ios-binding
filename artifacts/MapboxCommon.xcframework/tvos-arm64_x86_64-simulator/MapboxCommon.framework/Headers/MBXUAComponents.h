// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/**
 * UAComponents holds Application and SDK information for generating User-Agent string.
 *
 * The UA string itself is broken down into four components:
 * 1. Application Name and version - appName/appVersion.
 * 2. Application Identifier and OS Information - (appIdentifier; appBuildNumber; osName osVersion). This will be skipped from UA string, if any one of the field is empty or unknown.
 * 3. SDK Name and Version - sdkName/sdkVersion.
 * 4. SDK Identifier - (sdkIdentifier; sdkBuildNumber). This will be skipped from UA string, if any one of the field is empty or unknown.
 *
 * User Agent String Example: AppName/1.0 (app.bundle.identifier; v1; iOS 13.0.1) MapboxFramework/1.0 (framework.bundle.identifier; v1) Mapbox Common Library/v1.0.0
 *
 * Note that if the User-Agent is already part of the HTTP request headers, we skip the generation using the information provided through the UserAgentComponents.
 */
NS_SWIFT_NAME(UAComponents)
__attribute__((visibility ("default")))
@interface MBXUAComponents : NSObject

- (nonnull instancetype)init;

- (nonnull instancetype)initWithAppNameComponent:(nonnull NSString *)appNameComponent
                             appVersionComponent:(nonnull NSString *)appVersionComponent
                          appIdentifierComponent:(nonnull NSString *)appIdentifierComponent
                         appBuildNumberComponent:(nonnull NSString *)appBuildNumberComponent
                                 osNameComponent:(nonnull NSString *)osNameComponent
                              osVersionComponent:(nonnull NSString *)osVersionComponent
                                sdkNameComponent:(nonnull NSString *)sdkNameComponent
                             sdkVersionComponent:(nonnull NSString *)sdkVersionComponent
                          sdkIdentifierComponent:(nonnull NSString *)sdkIdentifierComponent
                         sdkBuildNumberComponent:(nonnull NSString *)sdkBuildNumberComponent;

/** Application Name (e.g. kCFBundleNameKey on Darwin) */
@property (nonatomic, readonly, nonnull, copy) NSString *appNameComponent;

/** Application Version (e.g. may be simple version 1.0) */
@property (nonatomic, readonly, nonnull, copy) NSString *appVersionComponent;

/** Application Identifier (e.g. bundle identifier on Darwin, package name of Android) */
@property (nonatomic, readonly, nonnull, copy) NSString *appIdentifierComponent;

/** Application Build Number (e.g. kCFBundleVersionKey on Darwin) */
@property (nonatomic, readonly, nonnull, copy) NSString *appBuildNumberComponent;

/** OS Name (e.g. iOS or Android) */
@property (nonatomic, readonly, nonnull, copy) NSString *osNameComponent;

/** OS Version (e.g 13.1.0) */
@property (nonatomic, readonly, nonnull, copy) NSString *osVersionComponent;

/** SDK/Framework Name (e.g. Maps) */
@property (nonatomic, readonly, nonnull, copy) NSString *sdkNameComponent;

/** SDK/Framework Version (e.g v1.0.0) */
@property (nonatomic, readonly, nonnull, copy) NSString *sdkVersionComponent;

/** SDK/Framework Identifier */
@property (nonatomic, readonly, nonnull, copy) NSString *sdkIdentifierComponent;

/** SDK/Framework Build Number */
@property (nonatomic, readonly, nonnull, copy) NSString *sdkBuildNumberComponent;


@end
