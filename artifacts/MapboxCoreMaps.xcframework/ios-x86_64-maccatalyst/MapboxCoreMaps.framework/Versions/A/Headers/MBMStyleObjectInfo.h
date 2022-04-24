// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** The information about style object (source or layer). */
NS_SWIFT_NAME(StyleObjectInfo)
__attribute__((visibility ("default")))
@interface MBMStyleObjectInfo : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithId:(nonnull NSString *)id
                              type:(nonnull NSString *)type;

/** The object's identifier. */
@property (nonatomic, readonly, nonnull, copy) NSString *id;

/** The object's type. */
@property (nonatomic, readonly, nonnull, copy) NSString *type;


@end
