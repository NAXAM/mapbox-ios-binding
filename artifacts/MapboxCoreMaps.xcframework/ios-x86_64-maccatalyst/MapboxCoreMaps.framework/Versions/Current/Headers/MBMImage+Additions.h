#import <UIKit/UIKit.h>
#import <ImageIO/ImageIO.h>
#import "MBMImage.h"

NS_ASSUME_NONNULL_BEGIN

@interface MBMImage(Additions)

/**
 Initializes and returns an image.
 @param uiImage The UIImage used to construct image.
 @return an image initialized with UIImage or nil if conversion fails.
*/
- (nullable instancetype)initWithUIImage:(UIImage *)uiImage;

/**
 Allocates, initializes and returns an image.
 @param uiImage The UIImage used to construct image.
 @return an image initialized with UIImage or nil if conversion fails.
*/
+ (nullable instancetype)imageWithUIImage:(UIImage *)uiImage;

/**
 * Converts an `MBMImage` to a `CGImage`.
 */
- (CGImageRef)cgImage;

@end

NS_ASSUME_NONNULL_END
