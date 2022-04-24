// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Describes the image stretch areas. */
NS_SWIFT_NAME(ImageStretches)
__attribute__((visibility ("default")))
@interface MBMImageStretches : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithFirst:(float)first
                               second:(float)second;

/** The first stretchable part in screen pixel units. */
@property (nonatomic, readonly) float first;

/** The second stretchable part in screen pixel units. */
@property (nonatomic, readonly) float second;


- (BOOL)isEqualToImageStretches:(nonnull MBMImageStretches *)other;

@end
