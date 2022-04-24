// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCoreMaps/MBMTask_Internal.h>

NS_SWIFT_NAME(MapClient)
@protocol MBMMapClient
/**
 * A callback that notifies the client that the map contains updated information, and thus requires a new render to be scheduled.
 *
 * Note: this callback might be invoked from different threads and it blocks rendering, so
 * clients shall avoid performing any extra operations in this callback.
 */
- (void)scheduleRepaint;
- (void)scheduleTaskForTask:(nonnull MBMTask)task;
@end
