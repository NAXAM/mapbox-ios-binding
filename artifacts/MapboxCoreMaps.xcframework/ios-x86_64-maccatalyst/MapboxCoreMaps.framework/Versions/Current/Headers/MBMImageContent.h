// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/**
 * Describes the image content, e.g. where text can be fit into an image.
 *
 * When sizing icons with `icon-text-fit`, the icon size will be adjusted so that the this content box fits exactly around the text.
 */
NS_SWIFT_NAME(ImageContent)
__attribute__((visibility ("default")))
@interface MBMImageContent : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithLeft:(float)left
                                 top:(float)top
                               right:(float)right
                              bottom:(float)bottom;

/** Distance to the left, in screen pixels. */
@property (nonatomic, readonly) float left;

/** Distance to the top, in screen pixels. */
@property (nonatomic, readonly) float top;

/** Distance to the right, in screen pixels. */
@property (nonatomic, readonly) float right;

/** Distance to the bottom, in screen pixels. */
@property (nonatomic, readonly) float bottom;


- (BOOL)isEqualToImageContent:(nonnull MBMImageContent *)other;

@end
