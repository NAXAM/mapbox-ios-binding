using System;
using CoreFoundation;
using CoreLocation;
using Foundation;
using MapboxCommon;
using ObjCRuntime;
using Security;

namespace MapboxCommon
{
	// @interface MBXFeature : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXFeature
	{
		// @property (readonly, retain) NSObject * _Nonnull identifier;
		[Export ("identifier", ArgumentSemantic.Retain)]
		NSObject Identifier { get; }

		// @property (readonly, retain) MBXGeometry * _Nonnull geometry;
		[Export ("geometry", ArgumentSemantic.Retain)]
		MBXGeometry Geometry { get; }

		// @property (readonly, retain) NSDictionary<NSString *,NSObject *> * _Nonnull properties;
		[Export ("properties", ArgumentSemantic.Retain)]
		NSDictionary<NSString, NSObject> Properties { get; }

		// -(instancetype _Nonnull)initWithIdentifier:(NSObject * _Nonnull)identifier geometry:(MBXGeometry * _Nonnull)geometry properties:(NSDictionary<NSString *,NSObject *> * _Nonnull)properties;
		[Export ("initWithIdentifier:geometry:properties:")]
		IntPtr Constructor (NSObject identifier, MBXGeometry geometry, NSDictionary<NSString, NSObject> properties);
	}

	// @interface MBXGeometry : NSObject
	[BaseType (typeof(NSObject))]
	interface MBXGeometry
	{
		// @property (readonly, assign) MBXGeometryType geometryType;
		[Export ("geometryType", ArgumentSemantic.Assign)]
		MBXGeometryType GeometryType { get; }

		// @property (readonly, assign) void * _Nonnull geometry;
		[Export ("geometry", ArgumentSemantic.Assign)]
        MBXGeometry Geometry { get; }

		// -(instancetype _Nonnull)initWithPoint:(NSValue * _Nonnull)location;
		[Export ("initWithPoint:")]
		IntPtr Constructor (NSValue location);

		// -(instancetype _Nonnull)initWithLine:(NSArray<NSValue *> * _Nonnull)locations;
		[Export ("initWithLine:")]
		IntPtr Constructor (NSValue[] locations);

		// -(instancetype _Nonnull)initWithPolygon:(NSArray<NSArray<NSValue *> *> * _Nonnull)locations;
		[Export ("initWithPolygon:")]
		IntPtr Constructor (NSArray<NSValue>[] locations);
		
		// TODO MBXGeometry - Create factory method
		// // -(instancetype _Nonnull)initWithMultiPoint:(NSArray<NSValue *> * _Nonnull)locations;
		// [Export ("initWithMultiPoint:")]
		// IntPtr Constructor (NSValue[] locations);

		// // -(instancetype _Nonnull)initWithMultiLine:(NSArray<NSArray<NSValue *> *> * _Nonnull)locations;
		// [Export ("initWithMultiLine:")]
		// IntPtr Constructor (NSArray<NSValue>[] locations);

		// -(instancetype _Nonnull)initWithMultiPolygon:(NSArray<NSArray<NSArray<NSValue *> *> *> * _Nonnull)locations;
		[Export ("initWithMultiPolygon:")]
		IntPtr Constructor (NSArray<NSArray<NSValue>>[] locations);

		// -(instancetype _Nonnull)initWithGeometryCollection:(NSArray<MBXGeometry *> * _Nonnull)geometries;
		[Export ("initWithGeometryCollection:")]
		IntPtr Constructor (MBXGeometry[] geometries);

		// -(NSValue * _Nullable)extractLocations;
		[NullAllowed, Export ("extractLocations")]
		NSValue ExtractLocations ();

		// -(NSArray<NSValue *> * _Nullable)extractLocationsArray;
		[NullAllowed, Export ("extractLocationsArray")]
		NSValue[] ExtractLocationsArray ();

		// -(NSArray<NSArray<NSValue *> *> * _Nullable)extractLocations2DArray;
		[NullAllowed, Export ("extractLocations2DArray")]
		NSArray<NSValue>[] ExtractLocations2DArray ();

		// -(NSArray<NSArray<NSArray<NSValue *> *> *> * _Nullable)extractLocations3DArray;
		[NullAllowed, Export ("extractLocations3DArray")]
		NSArray<NSArray<NSValue>>[] ExtractLocations3DArray ();

		// -(NSArray<MBXGeometry *> * _Nullable)extractGeometriesArray;
		[NullAllowed, Export ("extractGeometriesArray")]
		MBXGeometry[] ExtractGeometriesArray ();
	}

	// @interface MBXTilesetDescriptor : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXTilesetDescriptor
	{
	}

	// @interface MBXCancelable : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXCancelable
	{
		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();
	}

	// @interface MBXUAComponents : NSObject
	[BaseType (typeof(NSObject))]
	interface MBXUAComponents
	{
		// -(instancetype _Nonnull)initWithAppNameComponent:(NSString * _Nonnull)appNameComponent appVersionComponent:(NSString * _Nonnull)appVersionComponent appIdentifierComponent:(NSString * _Nonnull)appIdentifierComponent appBuildNumberComponent:(NSString * _Nonnull)appBuildNumberComponent osNameComponent:(NSString * _Nonnull)osNameComponent osVersionComponent:(NSString * _Nonnull)osVersionComponent sdkNameComponent:(NSString * _Nonnull)sdkNameComponent sdkVersionComponent:(NSString * _Nonnull)sdkVersionComponent sdkIdentifierComponent:(NSString * _Nonnull)sdkIdentifierComponent sdkBuildNumberComponent:(NSString * _Nonnull)sdkBuildNumberComponent;
		[Export ("initWithAppNameComponent:appVersionComponent:appIdentifierComponent:appBuildNumberComponent:osNameComponent:osVersionComponent:sdkNameComponent:sdkVersionComponent:sdkIdentifierComponent:sdkBuildNumberComponent:")]
		IntPtr Constructor (string appNameComponent, string appVersionComponent, string appIdentifierComponent, string appBuildNumberComponent, string osNameComponent, string osVersionComponent, string sdkNameComponent, string sdkVersionComponent, string sdkIdentifierComponent, string sdkBuildNumberComponent);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull appNameComponent;
		[Export ("appNameComponent")]
		string AppNameComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull appVersionComponent;
		[Export ("appVersionComponent")]
		string AppVersionComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull appIdentifierComponent;
		[Export ("appIdentifierComponent")]
		string AppIdentifierComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull appBuildNumberComponent;
		[Export ("appBuildNumberComponent")]
		string AppBuildNumberComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull osNameComponent;
		[Export ("osNameComponent")]
		string OsNameComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull osVersionComponent;
		[Export ("osVersionComponent")]
		string OsVersionComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sdkNameComponent;
		[Export ("sdkNameComponent")]
		string SdkNameComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sdkVersionComponent;
		[Export ("sdkVersionComponent")]
		string SdkVersionComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sdkIdentifierComponent;
		[Export ("sdkIdentifierComponent")]
		string SdkIdentifierComponent { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull sdkBuildNumberComponent;
		[Export ("sdkBuildNumberComponent")]
		string SdkBuildNumberComponent { get; }
	}

	// @interface MBXHttpRequest : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXHttpRequest
	{
		// -(instancetype _Nonnull)initWithUrl:(NSString * _Nonnull)url headers:(NSDictionary<NSString *,NSString *> * _Nonnull)headers uaComponents:(MBXUAComponents * _Nonnull)uaComponents body:(NSData * _Nullable)body;
		[Export ("initWithUrl:headers:uaComponents:body:")]
		IntPtr Constructor (string url, NSDictionary<NSString, NSString> headers, MBXUAComponents uaComponents, [NullAllowed] NSData body);

		// -(instancetype _Nonnull)initWithMethod:(MBXHttpMethod)method url:(NSString * _Nonnull)url headers:(NSDictionary<NSString *,NSString *> * _Nonnull)headers keepCompression:(BOOL)keepCompression timeout:(uint64_t)timeout networkRestriction:(MBXNetworkRestriction)networkRestriction uaComponents:(MBXUAComponents * _Nonnull)uaComponents body:(NSData * _Nullable)body;
		[Export ("initWithMethod:url:headers:keepCompression:timeout:networkRestriction:uaComponents:body:")]
		IntPtr Constructor (MBXHttpMethod method, string url, NSDictionary<NSString, NSString> headers, bool keepCompression, ulong timeout, MBXNetworkRestriction networkRestriction, MBXUAComponents uaComponents, [NullAllowed] NSData body);

		// @property (readwrite, nonatomic) MBXHttpMethod method;
		[Export ("method", ArgumentSemantic.Assign)]
		MBXHttpMethod Method { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull url;
		[Export ("url")]
		string Url { get; }

		// @property (readwrite, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nonnull headers;
		[Export ("headers", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> Headers { get; set; }

		// @property (readonly, getter = isKeepCompression, nonatomic) BOOL keepCompression;
		[Export ("keepCompression")]
		bool KeepCompression { [Bind ("isKeepCompression")] get; }

		// @property (readonly, nonatomic) uint64_t timeout;
		[Export ("timeout")]
		ulong Timeout { get; }

		// @property (readonly, nonatomic) MBXNetworkRestriction networkRestriction;
		[Export ("networkRestriction")]
		MBXNetworkRestriction NetworkRestriction { get; }

		// @property (readonly, nonatomic) MBXUAComponents * _Nonnull uaComponents;
		[Export ("uaComponents")]
		MBXUAComponents UaComponents { get; }

		// @property (readonly, nonatomic) NSData * _Nullable body;
		[NullAllowed, Export ("body")]
		NSData Body { get; }
	}

	// @interface MBXHttpRequestError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXHttpRequestError
	{
		// -(instancetype _Nonnull)initWithType:(MBXHttpRequestErrorType)type message:(NSString * _Nonnull)message;
		[Export ("initWithType:message:")]
		IntPtr Constructor (MBXHttpRequestErrorType type, string message);

		// @property (readonly, nonatomic) MBXHttpRequestErrorType type;
		[Export ("type")]
		MBXHttpRequestErrorType Type { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull message;
		[Export ("message")]
		string Message { get; }
	}

	// @interface MBXHttpResponseData : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXHttpResponseData
	{
		// -(instancetype _Nonnull)initWithHeaders:(NSDictionary<NSString *,NSString *> * _Nonnull)headers code:(int64_t)code data:(NSData * _Nonnull)data;
		[Export ("initWithHeaders:code:data:")]
		IntPtr Constructor (NSDictionary<NSString, NSString> headers, long code, NSData data);

		// @property (readonly, copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nonnull headers;
		[Export ("headers", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> Headers { get; }

		// @property (readonly, nonatomic) int64_t code;
		[Export ("code")]
		long Code { get; }

		// @property (readonly, nonatomic) NSData * _Nonnull data;
		[Export ("data")]
		NSData Data { get; }
	}

	// @interface MBXHttpResponse : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXHttpResponse
	{
		// @property (readonly, nonatomic) MBXHttpRequest * _Nonnull request;
		[Export ("request")]
		MBXHttpRequest Request { get; }
	}

	// @interface MBXDownloadOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXDownloadOptions
	{
		// -(instancetype _Nonnull)initWithRequest:(MBXHttpRequest * _Nonnull)request localPath:(NSString * _Nonnull)localPath;
		[Export ("initWithRequest:localPath:")]
		IntPtr Constructor (MBXHttpRequest request, string localPath);

		// -(instancetype _Nonnull)initWithRequest:(MBXHttpRequest * _Nonnull)request localPath:(NSString * _Nonnull)localPath resume:(BOOL)resume;
		[Export ("initWithRequest:localPath:resume:")]
		IntPtr Constructor (MBXHttpRequest request, string localPath, bool resume);

		// @property (readwrite, nonatomic) MBXHttpRequest * _Nonnull request;
		[Export ("request", ArgumentSemantic.Assign)]
		MBXHttpRequest Request { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull localPath;
		[Export ("localPath")]
		string LocalPath { get; }

		// @property (getter = isResume, readwrite, nonatomic) BOOL resume;
		[Export ("resume")]
		bool Resume { [Bind ("isResume")] get; set; }
	}

	// @interface MBXDownloadError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXDownloadError
	{
		// -(instancetype _Nonnull)initWithCode:(MBXDownloadErrorCode)code message:(NSString * _Nonnull)message;
		[Export ("initWithCode:message:")]
		IntPtr Constructor (MBXDownloadErrorCode code, string message);

		// @property (readonly, nonatomic) MBXDownloadErrorCode code;
		[Export ("code")]
		MBXDownloadErrorCode Code { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull message;
		[Export ("message")]
		string Message { get; }
	}

	// @interface MBXDownloadStatus : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXDownloadStatus
	{
		// @property (readwrite, nonatomic) uint64_t downloadId;
		[Export ("downloadId")]
		ulong DownloadId { get; set; }

		// @property (readwrite, nonatomic) MBXDownloadState state;
		[Export ("state", ArgumentSemantic.Assign)]
		MBXDownloadState State { get; set; }

		// @property (readwrite, nonatomic) MBXDownloadError * _Nullable error;
		[NullAllowed, Export ("error", ArgumentSemantic.Assign)]
		MBXDownloadError Error { get; set; }

		// @property (readwrite, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * totalBytes __attribute__((swift_private));
		[Export ("totalBytes", ArgumentSemantic.Assign)]
		NSNumber TotalBytes { get; set; }

		// @property (readwrite, nonatomic) uint64_t receivedBytes;
		[Export ("receivedBytes")]
		ulong ReceivedBytes { get; set; }

		// @property (readwrite, nonatomic) uint64_t transferredBytes;
		[Export ("transferredBytes")]
		ulong TransferredBytes { get; set; }

		// @property (readwrite, nonatomic) MBXDownloadOptions * _Nonnull downloadOptions;
		[Export ("downloadOptions", ArgumentSemantic.Assign)]
		MBXDownloadOptions DownloadOptions { get; set; }
	}

	// @interface MBXHttpServiceFactory : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXHttpServiceFactory
	{
		// +(void)setUserDefinedForCustom:(id<MBXHttpServiceInterface> _Nonnull)custom;
		[Static]
		[Export ("setUserDefinedForCustom:")]
		void SetUserDefinedForCustom (IMBXHttpServiceInterface custom);

		// +(void)reset;
		[Static]
		[Export ("reset")]
		void Reset ();

		// +(id<MBXHttpServiceInterface> _Nonnull)getInstance __attribute__((ns_returns_retained));
		[Static]
		[Export ("getInstance")]
		IMBXHttpServiceInterface Instance { get; }
	}

	// @protocol MBXHttpServiceInterceptorInterface
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    partial interface IMBXHttpServiceInterceptorInterface { }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
	interface MBXHttpServiceInterceptorInterface
	{
		// @required -(MBXHttpRequest * _Nonnull)onRequestForRequest:(MBXHttpRequest * _Nonnull)request;
		[Abstract]
		[Export ("onRequestForRequest:")]
		MBXHttpRequest OnRequestForRequest (MBXHttpRequest request);

		// @required -(MBXDownloadOptions * _Nonnull)onDownloadForDownload:(MBXDownloadOptions * _Nonnull)download;
		[Abstract]
		[Export ("onDownloadForDownload:")]
		MBXDownloadOptions OnDownloadForDownload (MBXDownloadOptions download);

		// @required -(MBXHttpResponse * _Nonnull)onResponseForResponse:(MBXHttpResponse * _Nonnull)response;
		[Abstract]
		[Export ("onResponseForResponse:")]
		MBXHttpResponse OnResponseForResponse (MBXHttpResponse response);
	}

	// typedef void (^MBXDownloadStatusCallback)(MBXDownloadStatus * _Nonnull);
	delegate void MBXDownloadStatusCallback (MBXDownloadStatus arg0);

	// typedef void (^MBXHttpResponseCallback)(MBXHttpResponse * _Nonnull);
	delegate void MBXHttpResponseCallback (MBXHttpResponse arg0);

	// typedef void (^MBXResultCallback)(BOOL);
	delegate void MBXResultCallback (bool arg0);

	// @protocol MBXHttpServiceInterface
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    partial interface IMBXHttpServiceInterface { }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
	interface MBXHttpServiceInterface
	{
		// @required -(void)setInterceptorForInterceptor:(id<MBXHttpServiceInterceptorInterface> _Nullable)interceptor;
		[Abstract]
		[Export ("setInterceptorForInterceptor:")]
		void SetInterceptorForInterceptor ([NullAllowed] IMBXHttpServiceInterceptorInterface interceptor);

		// @required -(void)setMaxRequestsPerHostForMax:(uint8_t)max;
		[Abstract]
		[Export ("setMaxRequestsPerHostForMax:")]
		void SetMaxRequestsPerHostForMax (byte max);

		// @required -(uint64_t)requestForRequest:(MBXHttpRequest * _Nonnull)request callback:(MBXHttpResponseCallback _Nonnull)callback;
		[Abstract]
		[Export ("requestForRequest:callback:")]
		ulong RequestForRequest (MBXHttpRequest request, MBXHttpResponseCallback callback);

		// @required -(void)cancelRequestForId:(uint64_t)id callback:(MBXResultCallback _Nonnull)callback;
		[Abstract]
		[Export ("cancelRequestForId:callback:")]
		void CancelRequestForId (ulong id, MBXResultCallback callback);

		// @required -(BOOL)supportsKeepCompression;
		[Abstract]
		[Export ("supportsKeepCompression")]
		bool SupportsKeepCompression { get; }

		// @required -(uint64_t)downloadForOptions:(MBXDownloadOptions * _Nonnull)options callback:(MBXDownloadStatusCallback _Nonnull)callback;
		[Abstract]
		[Export ("downloadForOptions:callback:")]
		ulong DownloadForOptions (MBXDownloadOptions options, MBXDownloadStatusCallback callback);
	}

	// @interface MBXOfflineSwitch : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXOfflineSwitch
	{
		// -(void)setMapboxStackConnectedForConnected:(BOOL)connected;
		[Export ("setMapboxStackConnectedForConnected:")]
		void SetMapboxStackConnectedForConnected (bool connected);

		// -(BOOL)isMapboxStackConnected;
		[Export ("isMapboxStackConnected")]
		bool IsMapboxStackConnected { get; }

		// +(MBXOfflineSwitch * _Nonnull)getInstance __attribute__((ns_returns_retained));
		[Static]
		[Export ("getInstance")]
		MBXOfflineSwitch Instance { get; }

		// +(void)reset;
		[Static]
		[Export ("reset")]
		void Reset ();
	}

	// @interface MBXSettingsServiceFactory : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXSettingsServiceFactory
	{
	}

	// @interface MBXMapboxCommonSettings : NSObject
	[BaseType (typeof(NSObject))]
	interface MBXMapboxCommonSettings
	{
		// @property (readonly, nonatomic, class) NSString * Language;
		[Static]
		[Export ("Language")]
		string Language { get; }

		// @property (readonly, nonatomic, class) NSString * Worldview;
		[Static]
		[Export ("Worldview")]
		string Worldview { get; }
	}

	// typedef void (^MBXTileRegionLoadProgressCallback)(MBXTileRegionLoadProgress * _Nonnull);
	delegate void MBXTileRegionLoadProgressCallback (MBXTileRegionLoadProgress arg0);

	// @interface MBXTileStore : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXTileStore
	{
		// +(MBXTileStore * _Nonnull)createForPath:(NSString * _Nonnull)path __attribute__((ns_returns_retained)) __attribute__((swift_private));
		[Static]
		[Export ("createForPath:")]
		MBXTileStore CreateForPath (string path);

		// +(MBXTileStore * _Nonnull)create __attribute__((ns_returns_retained)) __attribute__((swift_private));
		[Static]
		[Export ("create")]
		MBXTileStore Create ();

		// -(MBXCancelable * _Nonnull)loadTileRegionForId:(NSString * _Nonnull)id loadOptions:(MBXTileRegionLoadOptions * _Nonnull)loadOptions __attribute__((ns_returns_retained)) __attribute__((swift_private));
		[Export ("loadTileRegionForId:loadOptions:")]
		MBXCancelable LoadTileRegionForId (string id, MBXTileRegionLoadOptions loadOptions);

		// -(void)removeTileRegionForId:(NSString * _Nonnull)id;
		[Export ("removeTileRegionForId:")]
		void RemoveTileRegionForId (string id);

		// -(void)setOptionForKey:(NSString * _Nonnull)key value:(id _Nonnull)value;
		[Export ("setOptionForKey:value:")]
		void SetOptionForKey (string key, NSObject value);

		// -(void)setOptionForKey:(NSString * _Nonnull)key domain:(MBXTileDataDomain)domain value:(id _Nonnull)value;
		[Export ("setOptionForKey:domain:value:")]
		void SetOptionForKey (string key, MBXTileDataDomain domain, NSObject value);
	}

	// @interface MBXTileRegion : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXTileRegion
	{
		// -(instancetype _Nonnull)initWithId:(NSString * _Nonnull)id requiredResourceCount:(uint64_t)requiredResourceCount completedResourceCount:(uint64_t)completedResourceCount completedResourceSize:(uint64_t)completedResourceSize expires:(NSDate * _Nullable)expires;
		[Export ("initWithId:requiredResourceCount:completedResourceCount:completedResourceSize:expires:")]
		IntPtr Constructor (string id, ulong requiredResourceCount, ulong completedResourceCount, ulong completedResourceSize, [NullAllowed] NSDate expires);

		// @property (readonly, copy, nonatomic) NSString * _Nonnull id;
		[Export ("id")]
		string Id { get; }

		// @property (readonly, nonatomic) uint64_t requiredResourceCount;
		[Export ("requiredResourceCount")]
		ulong RequiredResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t completedResourceCount;
		[Export ("completedResourceCount")]
		ulong CompletedResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t completedResourceSize;
		[Export ("completedResourceSize")]
		ulong CompletedResourceSize { get; }

		// @property (readonly, nonatomic) NSDate * _Nullable expires;
		[NullAllowed, Export ("expires")]
		NSDate Expires { get; }
	}

	// @interface MBXTileRegionLoadProgress : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXTileRegionLoadProgress
	{
		// -(instancetype _Nonnull)initWithCompletedResourceCount:(uint64_t)completedResourceCount completedResourceSize:(uint64_t)completedResourceSize erroredResourceCount:(uint64_t)erroredResourceCount requiredResourceCount:(uint64_t)requiredResourceCount loadedResourceCount:(uint64_t)loadedResourceCount loadedResourceSize:(uint64_t)loadedResourceSize;
		[Export ("initWithCompletedResourceCount:completedResourceSize:erroredResourceCount:requiredResourceCount:loadedResourceCount:loadedResourceSize:")]
		IntPtr Constructor (ulong completedResourceCount, ulong completedResourceSize, ulong erroredResourceCount, ulong requiredResourceCount, ulong loadedResourceCount, ulong loadedResourceSize);

		// @property (readonly, nonatomic) uint64_t completedResourceCount;
		[Export ("completedResourceCount")]
		ulong CompletedResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t completedResourceSize;
		[Export ("completedResourceSize")]
		ulong CompletedResourceSize { get; }

		// @property (readonly, nonatomic) uint64_t erroredResourceCount;
		[Export ("erroredResourceCount")]
		ulong ErroredResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t requiredResourceCount;
		[Export ("requiredResourceCount")]
		ulong RequiredResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t loadedResourceCount;
		[Export ("loadedResourceCount")]
		ulong LoadedResourceCount { get; }

		// @property (readonly, nonatomic) uint64_t loadedResourceSize;
		[Export ("loadedResourceSize")]
		ulong LoadedResourceSize { get; }
	}

	// @interface MBXTileRegionError : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXTileRegionError
	{
		// -(instancetype _Nonnull)initWithType:(MBXTileRegionErrorType)type message:(NSString * _Nonnull)message;
		[Export ("initWithType:message:")]
		IntPtr Constructor (MBXTileRegionErrorType type, string message);

		// @property (readonly, nonatomic) MBXTileRegionErrorType type;
		[Export ("type")]
		MBXTileRegionErrorType Type { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull message;
		[Export ("message")]
		string Message { get; }
	}

	// @interface MBXTileRegionLoadOptions : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXTileRegionLoadOptions
	{
		// -(instancetype _Nonnull)initWithGeometry:(MBXGeometry * _Nullable)geometry descriptors:(NSArray<MBXTilesetDescriptor *> * _Nullable)descriptors metadata:(id _Nullable)metadata startLocation:(CLLocation * _Nullable)startLocation averageBytesPerSecond:(NSNumber * _Nullable)averageBytesPerSecond extraOptions:(id _Nullable)extraOptions __attribute__((swift_private));
		[Export ("initWithGeometry:descriptors:metadata:startLocation:averageBytesPerSecond:extraOptions:")]
		IntPtr Constructor ([NullAllowed] MBXGeometry geometry, [NullAllowed] MBXTilesetDescriptor[] descriptors, [NullAllowed] NSObject metadata, [NullAllowed] CLLocation startLocation, [NullAllowed] NSNumber averageBytesPerSecond, [NullAllowed] NSObject extraOptions);

		// -(instancetype _Nonnull)initWithGeometry:(MBXGeometry * _Nullable)geometry descriptors:(NSArray<MBXTilesetDescriptor *> * _Nullable)descriptors metadata:(id _Nullable)metadata acceptExpired:(BOOL)acceptExpired networkRestriction:(MBXNetworkRestriction)networkRestriction startLocation:(CLLocation * _Nullable)startLocation averageBytesPerSecond:(NSNumber * _Nullable)averageBytesPerSecond extraOptions:(id _Nullable)extraOptions __attribute__((swift_private));
		[Export ("initWithGeometry:descriptors:metadata:acceptExpired:networkRestriction:startLocation:averageBytesPerSecond:extraOptions:")]
		IntPtr Constructor ([NullAllowed] MBXGeometry geometry, [NullAllowed] MBXTilesetDescriptor[] descriptors, [NullAllowed] NSObject metadata, bool acceptExpired, MBXNetworkRestriction networkRestriction, [NullAllowed] CLLocation startLocation, [NullAllowed] NSNumber averageBytesPerSecond, [NullAllowed] NSObject extraOptions);

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT MBXGeometry * geometry __attribute__((swift_private));
		[Export ("geometry")]
		MBXGeometry Geometry { get; }

		// @property (readonly, copy, nonatomic) NSArray<MBXTilesetDescriptor *> * _Nullable descriptors;
		[NullAllowed, Export ("descriptors", ArgumentSemantic.Copy)]
		MBXTilesetDescriptor[] Descriptors { get; }

		// @property (readonly, copy, nonatomic) id _Nullable metadata;
		[NullAllowed, Export ("metadata", ArgumentSemantic.Copy)]
		NSObject Metadata { get; }

		// @property (readonly, getter = isAcceptExpired, nonatomic) BOOL acceptExpired;
		[Export ("acceptExpired")]
		bool AcceptExpired { [Bind ("isAcceptExpired")] get; }

		// @property (readonly, nonatomic) MBXNetworkRestriction networkRestriction;
		[Export ("networkRestriction")]
		MBXNetworkRestriction NetworkRestriction { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT CLLocation * startLocation __attribute__((swift_private));
		[Export ("startLocation")]
		CLLocation StartLocation { get; }

		// @property (readonly, nonatomic) NS_REFINED_FOR_SWIFT NSNumber * averageBytesPerSecond __attribute__((swift_private));
		[Export ("averageBytesPerSecond")]
		NSNumber AverageBytesPerSecond { get; }

		// @property (readonly, copy, nonatomic) id _Nullable extraOptions;
		[NullAllowed, Export ("extraOptions", ArgumentSemantic.Copy)]
		NSObject ExtraOptions { get; }
	}

	// @interface MBXTileStoreOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface MBXTileStoreOptions
	{
		// @property (readonly, nonatomic, class) NSString * DiskQuota;
		[Static]
		[Export ("DiskQuota")]
		string DiskQuota { get; }

		// @property (readonly, nonatomic, class) NSString * MapboxAccessToken;
		[Static]
		[Export ("MapboxAccessToken")]
		string MapboxAccessToken { get; }

		// @property (readonly, nonatomic, class) NSString * MapboxAPIURL;
		[Static]
		[Export ("MapboxAPIURL")]
		string MapboxAPIURL { get; }

		// @property (readonly, nonatomic, class) NSString * TileURLTemplate;
		[Static]
		[Export ("TileURLTemplate")]
		string TileURLTemplate { get; }
	}

	// @interface MBXValueConverter : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface MBXValueConverter
	{
		// +(NSString * _Nonnull)toJsonForValue:(id _Nonnull)value __attribute__((ns_returns_retained));
		[Static]
		[Export ("toJsonForValue:")]
		string ToJsonForValue (NSObject value);

		// +(NSString * _Nonnull)toJsonForValue:(id _Nonnull)value indent:(uint32_t)indent __attribute__((ns_returns_retained));
		[Static]
		[Export ("toJsonForValue:indent:")]
		string ToJsonForValue (NSObject value, uint indent);
	}
}
