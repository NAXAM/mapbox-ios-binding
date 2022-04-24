// This file is generated and will be overwritten automatically.

#import <MapboxCoreMaps/MBMOfflineManager.h>
#import <MapboxCoreMaps/MBMStylePackCallback_Internal.h>
#import <MapboxCoreMaps/MBMStylePackMetadataCallback_Internal.h>
#import <MapboxCoreMaps/MBMStylePacksCallback_Internal.h>

@interface MBMOfflineManager ()
- (nonnull MBXCancelable *)loadStylePackForStyleURI:(nonnull NSString *)styleURI
                                        loadOptions:(nonnull MBMStylePackLoadOptions *)loadOptions
                                         onProgress:(nonnull MBMStylePackLoadProgressCallback)onProgress
                                         onFinished:(nonnull MBMStylePackCallback)onFinished __attribute((ns_returns_retained)) NS_REFINED_FOR_SWIFT;
- (nonnull MBXCancelable *)loadStylePackForStyleURI:(nonnull NSString *)styleURI
                                        loadOptions:(nonnull MBMStylePackLoadOptions *)loadOptions
                                         onFinished:(nonnull MBMStylePackCallback)onFinished __attribute((ns_returns_retained)) NS_REFINED_FOR_SWIFT;
- (void)getAllStylePacksForCallback:(nonnull MBMStylePacksCallback)callback NS_REFINED_FOR_SWIFT;
- (void)getStylePackForStyleURI:(nonnull NSString *)styleURI
                       callback:(nonnull MBMStylePackCallback)callback NS_REFINED_FOR_SWIFT;
- (void)getStylePackMetadataForStyleURI:(nonnull NSString *)styleURI
                               callback:(nonnull MBMStylePackMetadataCallback)callback NS_REFINED_FOR_SWIFT;
@end
