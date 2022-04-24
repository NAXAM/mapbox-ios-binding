// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>
#import <MapboxCommon/MBXLoggingLevel_Internal.h>

@protocol MBXLogWriterBackend;

NS_SWIFT_NAME(LogConfiguration)
__attribute__((visibility ("default")))
@interface MBXLogConfiguration : NSObject

// This class provides custom init which should be called
- (nonnull instancetype)init NS_UNAVAILABLE;

// This class provides custom init which should be called
+ (nonnull instancetype)new NS_UNAVAILABLE;

- (void)registerLogWriterBackendForLogWriter:(nonnull id<MBXLogWriterBackend>)logWriter;
- (nonnull id<MBXLogWriterBackend>)getLogWriterBackend __attribute((ns_returns_retained));
- (void)setFilterLevelForLevel:(MBXLoggingLevel)level;
- (MBXLoggingLevel)getFilterLevel;
- (void)addCategoryFilterForCategory:(nonnull NSString *)category;
- (void)removeCategoryFilterForCategory:(nonnull NSString *)category;
- (nonnull NSArray<NSString *> *)getCategoryFilters __attribute((ns_returns_retained));
- (BOOL)isFilteredForCategory:(nonnull NSString *)category;
+ (nonnull MBXLogConfiguration *)getInstance __attribute((ns_returns_retained));

@end
