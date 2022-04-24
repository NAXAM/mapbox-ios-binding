// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCommon/MBXLoggingLevel_Internal.h>

NS_SWIFT_NAME(LogWriterBackend)
@protocol MBXLogWriterBackend
- (void)writeLogForLevel:(MBXLoggingLevel)level
                 message:(nonnull NSString *)message
                category:(nullable NSString *)category;
@end
