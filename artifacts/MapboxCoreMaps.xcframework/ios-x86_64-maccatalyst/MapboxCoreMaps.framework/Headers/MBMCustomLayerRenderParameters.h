// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

@protocol MBMElevationData;

/** Parameters that define the current camera position for a `CustomLayerHost::render()` function. */
NS_SWIFT_NAME(CustomLayerRenderParameters)
__attribute__((visibility ("default")))
@interface MBMCustomLayerRenderParameters : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (nonnull instancetype)initWithWidth:(double)width
                               height:(double)height
                             latitude:(double)latitude
                            longitude:(double)longitude
                                 zoom:(double)zoom
                              bearing:(double)bearing
                                pitch:(double)pitch
                          fieldOfView:(double)fieldOfView
                     projectionMatrix:(nonnull NSArray<NSNumber *> *)projectionMatrix
                        elevationData:(nullable id<MBMElevationData>)elevationData;

/** The width. */
@property (nonatomic, readonly) double width;

/** The height. */
@property (nonatomic, readonly) double height;

/** The latitude of camera position. */
@property (nonatomic, readonly) double latitude;

/** The longitude of camera position. */
@property (nonatomic, readonly) double longitude;

/** The zoom of the camera. */
@property (nonatomic, readonly) double zoom;

/** The bearing (orientation) of the camera. In degrees clockwise from north, it describes the direction in which the camera points. */
@property (nonatomic, readonly) double bearing;

/** The pitch of the camera, the angle of pitch applied to the camera around the x-axis. */
@property (nonatomic, readonly) double pitch;

/** The field of view of the camera in degrees */
@property (nonatomic, readonly) double fieldOfView;

/** The projection matrix used for rendering. It projects spherical mercator coordinates to gl coordinates. */
@property (nonatomic, readonly, nonnull, copy) NSArray<NSNumber *> *projectionMatrix;

/** If terrain is enabled, provides value to elevation data from render thread. Empty if terrain is not enabled. */
@property (nonatomic, readonly, nullable) id<MBMElevationData> elevationData;


@end
