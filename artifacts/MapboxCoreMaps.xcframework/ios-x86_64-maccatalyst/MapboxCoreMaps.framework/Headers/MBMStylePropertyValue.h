// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCoreMaps/MBMStylePropertyValueKind.h>

/** Holds a style property value with meta data. */
NS_SWIFT_NAME(StylePropertyValue)
__attribute__((visibility ("default")))
@interface MBMStylePropertyValue : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithValue:(nonnull id)value
                                 kind:(MBMStylePropertyValueKind)kind;

/** The property value. */
@property (nonatomic, readonly, nonnull, copy) id value;

/** The kind of the property value. */
@property (nonatomic, readonly) MBMStylePropertyValueKind kind;


@end
