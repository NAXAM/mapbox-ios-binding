// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCoreMaps/MBMStylePackErrorType.h>

/** Describes a style package load request error. */
NS_SWIFT_NAME(StylePackError)
__attribute__((visibility ("default")))
@interface MBMStylePackError : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithType:(MBMStylePackErrorType)type
                             message:(nonnull NSString *)message;

/** The reason for the response error. */
@property (nonatomic, readonly) MBMStylePackErrorType type;

/** An error message. */
@property (nonatomic, readonly, nonnull, copy) NSString *message;


@end
