// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

@class MBMScreenCoordinate;

/**
 * Read-only data that is needed to correctly position the single view annotation on screen.
 * Used inside ViewAnnotationPositionsUpdateListener callback to notify the listener about the visible view annotations' position updates.
 *
 */
NS_SWIFT_NAME(ViewAnnotationPositionDescriptor)
__attribute__((visibility ("default")))
@interface MBMViewAnnotationPositionDescriptor : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithIdentifier:(nonnull NSString *)identifier
                                     width:(uint32_t)width
                                    height:(uint32_t)height
                         leftTopCoordinate:(nonnull MBMScreenCoordinate *)leftTopCoordinate NS_REFINED_FOR_SWIFT;

/** Unique id in order to lookup an actual view in platform SDKs. */
@property (nonatomic, readonly, nonnull, copy) NSString *identifier;

/** View annotation width in `platform pixels` for drawing the annotation. */
@property (nonatomic, readonly) uint32_t width;

/** View annotation height in `platform pixels` for drawing the annotation. */
@property (nonatomic, readonly) uint32_t height;

/** Left-top screen coordinate in `platform pixels` for view annotation. */
@property (nonatomic, readonly, nonnull) MBMScreenCoordinate *leftTopCoordinate;


@end
