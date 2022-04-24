using System;
using CoreLocation;
using Foundation;
using MapboxMobileEvents;
using ObjCRuntime;

namespace MapboxMobileEvents
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double MapboxMobileEventsVersionNumber;
		[Field ("MapboxMobileEventsVersionNumber", "__Internal")]
		double MapboxMobileEventsVersionNumber { get; }

		// extern const unsigned char [] MapboxMobileEventsVersionString;
		[Field ("MapboxMobileEventsVersionString", "__Internal")]
		byte[] MapboxMobileEventsVersionString { get; }

		// extern NSString *const MMEAPIClientBaseEventsURL;
		[Field ("MMEAPIClientBaseEventsURL", "__Internal")]
		NSString MMEAPIClientBaseEventsURL { get; }

		// extern NSString *const MMEAPIClientBaseAPIURL;
		[Field ("MMEAPIClientBaseAPIURL", "__Internal")]
		NSString MMEAPIClientBaseAPIURL { get; }

		// extern NSString *const MMEAPIClientBaseChinaEventsURL;
		[Field ("MMEAPIClientBaseChinaEventsURL", "__Internal")]
		NSString MMEAPIClientBaseChinaEventsURL { get; }

		// extern NSString *const MMEAPIClientBaseChinaAPIURL;
		[Field ("MMEAPIClientBaseChinaAPIURL", "__Internal")]
		NSString MMEAPIClientBaseChinaAPIURL { get; }

		// extern NSString *const MMEAPIClientEventsPath;
		[Field ("MMEAPIClientEventsPath", "__Internal")]
		NSString MMEAPIClientEventsPath { get; }

		// extern NSString *const MMEAPIClientEventsConfigPath;
		[Field ("MMEAPIClientEventsConfigPath", "__Internal")]
		NSString MMEAPIClientEventsConfigPath { get; }

		// extern NSString *const MMEAPIClientAttachmentsPath;
		[Field ("MMEAPIClientAttachmentsPath", "__Internal")]
		NSString MMEAPIClientAttachmentsPath { get; }

		// extern NSString *const MMEAPIClientHeaderFieldUserAgentKey;
		[Field ("MMEAPIClientHeaderFieldUserAgentKey", "__Internal")]
		NSString MMEAPIClientHeaderFieldUserAgentKey { get; }

		// extern NSString *const MMEAPIClientHeaderFieldContentTypeKey;
		[Field ("MMEAPIClientHeaderFieldContentTypeKey", "__Internal")]
		NSString MMEAPIClientHeaderFieldContentTypeKey { get; }

		// extern NSString *const MMEAPIClientHeaderFieldContentTypeValue;
		[Field ("MMEAPIClientHeaderFieldContentTypeValue", "__Internal")]
		NSString MMEAPIClientHeaderFieldContentTypeValue { get; }

		// extern NSString *const MMEAPIClientAttachmentsHeaderFieldContentTypeValue;
		[Field ("MMEAPIClientAttachmentsHeaderFieldContentTypeValue", "__Internal")]
		NSString MMEAPIClientAttachmentsHeaderFieldContentTypeValue { get; }

		// extern NSString *const MMEAPIClientHeaderFieldContentEncodingKey;
		[Field ("MMEAPIClientHeaderFieldContentEncodingKey", "__Internal")]
		NSString MMEAPIClientHeaderFieldContentEncodingKey { get; }

		// extern NSString *const MMEAPIClientHTTPMethodPost;
		[Field ("MMEAPIClientHTTPMethodPost", "__Internal")]
		NSString MMEAPIClientHTTPMethodPost { get; }

		// extern NSString *const MMEAPIClientHTTPMethodGet;
		[Field ("MMEAPIClientHTTPMethodGet", "__Internal")]
		NSString MMEAPIClientHTTPMethodGet { get; }

		// extern NSString *const MMEDebugEventType;
		[Field ("MMEDebugEventType", "__Internal")]
		NSString MMEDebugEventType { get; }

		// extern NSString *const MMEDebugEventTypeError;
		[Field ("MMEDebugEventTypeError", "__Internal")]
		NSString MMEDebugEventTypeError { get; }

		// extern NSString *const MMEDebugEventTypeFlush;
		[Field ("MMEDebugEventTypeFlush", "__Internal")]
		NSString MMEDebugEventTypeFlush { get; }

		// extern NSString *const MMEDebugEventTypePush;
		[Field ("MMEDebugEventTypePush", "__Internal")]
		NSString MMEDebugEventTypePush { get; }

		// extern NSString *const MMEDebugEventTypePost;
		[Field ("MMEDebugEventTypePost", "__Internal")]
		NSString MMEDebugEventTypePost { get; }

		// extern NSString *const MMEDebugEventTypePostFailed;
		[Field ("MMEDebugEventTypePostFailed", "__Internal")]
		NSString MMEDebugEventTypePostFailed { get; }

		// extern NSString *const MMEDebugEventTypeTurnstile;
		[Field ("MMEDebugEventTypeTurnstile", "__Internal")]
		NSString MMEDebugEventTypeTurnstile { get; }

		// extern NSString *const MMEDebugEventTypeTurnstileFailed;
		[Field ("MMEDebugEventTypeTurnstileFailed", "__Internal")]
		NSString MMEDebugEventTypeTurnstileFailed { get; }

		// extern NSString *const MMEDebugEventTypeBackgroundTask;
		[Field ("MMEDebugEventTypeBackgroundTask", "__Internal")]
		NSString MMEDebugEventTypeBackgroundTask { get; }

		// extern NSString *const MMEDebugEventTypeMetricCollection;
		[Field ("MMEDebugEventTypeMetricCollection", "__Internal")]
		NSString MMEDebugEventTypeMetricCollection { get; }

		// extern NSString *const MMEDebugEventTypeLocationManager;
		[Field ("MMEDebugEventTypeLocationManager", "__Internal")]
		NSString MMEDebugEventTypeLocationManager { get; }

		// extern NSString *const MMEDebugEventTypeTelemetryMetrics;
		[Field ("MMEDebugEventTypeTelemetryMetrics", "__Internal")]
		NSString MMEDebugEventTypeTelemetryMetrics { get; }

		// extern NSString *const MMEDebugEventTypeCertPinning;
		[Field ("MMEDebugEventTypeCertPinning", "__Internal")]
		NSString MMEDebugEventTypeCertPinning { get; }

		// extern NSString *const MMEEventTypeAppUserTurnstile;
		[Field ("MMEEventTypeAppUserTurnstile", "__Internal")]
		NSString MMEEventTypeAppUserTurnstile { get; }

		// extern NSString *const MMEEventTypeTelemetryMetrics;
		[Field ("MMEEventTypeTelemetryMetrics", "__Internal")]
		NSString MMEEventTypeTelemetryMetrics { get; }

		// extern NSString *const MMEEventTypeMapLoad;
		[Field ("MMEEventTypeMapLoad", "__Internal")]
		NSString MMEEventTypeMapLoad { get; }

		// extern NSString *const MMEEventTypeLocation;
		[Field ("MMEEventTypeLocation", "__Internal")]
		NSString MMEEventTypeLocation { get; }

		// extern NSString *const MMEEventTypeVisit;
		[Field ("MMEEventTypeVisit", "__Internal")]
		NSString MMEEventTypeVisit { get; }

		// extern NSString *const MMEEventTypeLocalDebug;
		[Field ("MMEEventTypeLocalDebug", "__Internal")]
		NSString MMEEventTypeLocalDebug { get; }

		// extern NSString *const MMEventTypeOfflineDownloadStart;
		[Field ("MMEventTypeOfflineDownloadStart", "__Internal")]
		NSString MMEventTypeOfflineDownloadStart { get; }

		// extern NSString *const MMEventTypeOfflineDownloadEnd;
		[Field ("MMEventTypeOfflineDownloadEnd", "__Internal")]
		NSString MMEventTypeOfflineDownloadEnd { get; }

		// extern NSString *const MMEEventKeyArrivalDate;
		[Field ("MMEEventKeyArrivalDate", "__Internal")]
		NSString MMEEventKeyArrivalDate { get; }

		// extern NSString *const MMEEventKeyDepartureDate;
		[Field ("MMEEventKeyDepartureDate", "__Internal")]
		NSString MMEEventKeyDepartureDate { get; }

		// extern NSString *const MMEEventKeyLatitude;
		[Field ("MMEEventKeyLatitude", "__Internal")]
		NSString MMEEventKeyLatitude { get; }

		// extern NSString *const MMEEventKeyLongitude;
		[Field ("MMEEventKeyLongitude", "__Internal")]
		NSString MMEEventKeyLongitude { get; }

		// extern NSString *const MMEEventKeyZoomLevel;
		[Field ("MMEEventKeyZoomLevel", "__Internal")]
		NSString MMEEventKeyZoomLevel { get; }

		// extern NSString *const MMEEventKeyMaxZoomLevel;
		[Field ("MMEEventKeyMaxZoomLevel", "__Internal")]
		NSString MMEEventKeyMaxZoomLevel { get; }

		// extern NSString *const MMEEventKeyMinZoomLevel;
		[Field ("MMEEventKeyMinZoomLevel", "__Internal")]
		NSString MMEEventKeyMinZoomLevel { get; }

		// extern NSString *const MMEEventKeyEvent;
		[Field ("MMEEventKeyEvent", "__Internal")]
		NSString MMEEventKeyEvent { get; }

		// extern NSString *const MMEEventKeyCreated;
		[Field ("MMEEventKeyCreated", "__Internal")]
		NSString MMEEventKeyCreated { get; }

		// extern NSString *const MMEEventKeyStyleURL;
		[Field ("MMEEventKeyStyleURL", "__Internal")]
		NSString MMEEventKeyStyleURL { get; }

		// extern NSString *const MMEEventKeySpeed;
		[Field ("MMEEventKeySpeed", "__Internal")]
		NSString MMEEventKeySpeed { get; }

		// extern NSString *const MMEEventKeyCourse;
		[Field ("MMEEventKeyCourse", "__Internal")]
		NSString MMEEventKeyCourse { get; }

		// extern NSString *const MMEEventKeySpeedAccuracy;
		[Field ("MMEEventKeySpeedAccuracy", "__Internal")]
		NSString MMEEventKeySpeedAccuracy { get; }

		// extern NSString *const MMEEventKeyCourseAccuracy;
		[Field ("MMEEventKeyCourseAccuracy", "__Internal")]
		NSString MMEEventKeyCourseAccuracy { get; }

		// extern NSString *const MMEEventKeyVerticalAccuracy;
		[Field ("MMEEventKeyVerticalAccuracy", "__Internal")]
		NSString MMEEventKeyVerticalAccuracy { get; }

		// extern NSString *const MMEEventKeyFloor;
		[Field ("MMEEventKeyFloor", "__Internal")]
		NSString MMEEventKeyFloor { get; }

		// extern NSString *const MMEEventKeyVendorId;
		[Field ("MMEEventKeyVendorId", "__Internal")]
		NSString MMEEventKeyVendorId { get; }

		// extern NSString *const MMEEventKeyModel;
		[Field ("MMEEventKeyModel", "__Internal")]
		NSString MMEEventKeyModel { get; }

		// extern NSString *const MMEEventKeyDevice;
		[Field ("MMEEventKeyDevice", "__Internal")]
		NSString MMEEventKeyDevice { get; }

		// extern NSString *const MMEEventKeyConfig;
		[Field ("MMEEventKeyConfig", "__Internal")]
		NSString MMEEventKeyConfig { get; }

		// extern NSString *const MMEEventKeySkuId;
		[Field ("MMEEventKeySkuId", "__Internal")]
		NSString MMEEventKeySkuId { get; }

		// extern NSString *const MMEEventKeyEnabledTelemetry;
		[Field ("MMEEventKeyEnabledTelemetry", "__Internal")]
		NSString MMEEventKeyEnabledTelemetry { get; }

		// extern NSString *const MMEEventKeyOperatingSystem;
		[Field ("MMEEventKeyOperatingSystem", "__Internal")]
		NSString MMEEventKeyOperatingSystem { get; }

		// extern NSString *const MMEEventKeyResolution;
		[Field ("MMEEventKeyResolution", "__Internal")]
		NSString MMEEventKeyResolution { get; }

		// extern NSString *const MMEEventKeyAccessibilityFontScale;
		[Field ("MMEEventKeyAccessibilityFontScale", "__Internal")]
		NSString MMEEventKeyAccessibilityFontScale { get; }

		// extern NSString *const MMEEventKeyOrientation;
		[Field ("MMEEventKeyOrientation", "__Internal")]
		NSString MMEEventKeyOrientation { get; }

		// extern NSString *const MMEEventKeyPluggedIn;
		[Field ("MMEEventKeyPluggedIn", "__Internal")]
		NSString MMEEventKeyPluggedIn { get; }

		// extern NSString *const MMEEventKeyWifi;
		[Field ("MMEEventKeyWifi", "__Internal")]
		NSString MMEEventKeyWifi { get; }

		// extern NSString *const MMEEventKeyShapeForOfflineRegion;
		[Field ("MMEEventKeyShapeForOfflineRegion", "__Internal")]
		NSString MMEEventKeyShapeForOfflineRegion { get; }

		// extern NSString *const MMEEventKeySource;
		[Field ("MMEEventKeySource", "__Internal")]
		NSString MMEEventKeySource { get; }

		// extern NSString *const MMEEventKeySessionId;
		[Field ("MMEEventKeySessionId", "__Internal")]
		NSString MMEEventKeySessionId { get; }

		// extern NSString *const MMEEventKeyApplicationState;
		[Field ("MMEEventKeyApplicationState", "__Internal")]
		NSString MMEEventKeyApplicationState { get; }

		// extern NSString *const MMEEventKeyAltitude;
		[Field ("MMEEventKeyAltitude", "__Internal")]
		NSString MMEEventKeyAltitude { get; }

		// extern NSString *const MMEEventKeyLocationAuthorization;
		[Field ("MMEEventKeyLocationAuthorization", "__Internal")]
		NSString MMEEventKeyLocationAuthorization { get; }

		// extern NSString *const MMEEventKeyLocationEnabled;
		[Field ("MMEEventKeyLocationEnabled", "__Internal")]
		NSString MMEEventKeyLocationEnabled { get; }

		// extern NSString *const MMEEventKeyAccuracyAuthorization;
		[Field ("MMEEventKeyAccuracyAuthorization", "__Internal")]
		NSString MMEEventKeyAccuracyAuthorization { get; }

		// extern NSString *const MMEEventHorizontalAccuracy;
		[Field ("MMEEventHorizontalAccuracy", "__Internal")]
		NSString MMEEventHorizontalAccuracy { get; }

		// extern NSString *const MMEEventSDKIdentifier;
		[Field ("MMEEventSDKIdentifier", "__Internal")]
		NSString MMEEventSDKIdentifier { get; }

		// extern NSString *const MMEEventSDKVersion;
		[Field ("MMEEventSDKVersion", "__Internal")]
		NSString MMEEventSDKVersion { get; }

		// extern NSString *const MMEEventKeyLocalDebugDescription;
		[Field ("MMEEventKeyLocalDebugDescription", "__Internal")]
		NSString MMEEventKeyLocalDebugDescription { get; }

		// extern NSString *const MMEEventKeyErrorCode;
		[Field ("MMEEventKeyErrorCode", "__Internal")]
		NSString MMEEventKeyErrorCode { get; }

		// extern NSString *const MMEEventKeyErrorDomain;
		[Field ("MMEEventKeyErrorDomain", "__Internal")]
		NSString MMEEventKeyErrorDomain { get; }

		// extern NSString *const MMEEventKeyErrorDescription;
		[Field ("MMEEventKeyErrorDescription", "__Internal")]
		NSString MMEEventKeyErrorDescription { get; }

		// extern NSString *const MMEEventKeyErrorFailureReason;
		[Field ("MMEEventKeyErrorFailureReason", "__Internal")]
		NSString MMEEventKeyErrorFailureReason { get; }

		// extern NSString *const MMEEventKeyErrorNoReason;
		[Field ("MMEEventKeyErrorNoReason", "__Internal")]
		NSString MMEEventKeyErrorNoReason { get; }

		// extern NSString *const MMEEventKeyErrorNoDomain;
		[Field ("MMEEventKeyErrorNoDomain", "__Internal")]
		NSString MMEEventKeyErrorNoDomain { get; }

		// extern NSString *const MMEEventKeyFailedRequests;
		[Field ("MMEEventKeyFailedRequests", "__Internal")]
		NSString MMEEventKeyFailedRequests { get; }

		// extern NSString *const MMEEventKeyHeader;
		[Field ("MMEEventKeyHeader", "__Internal")]
		NSString MMEEventKeyHeader { get; }

		// extern NSString *const MMEEventKeyPlatform;
		[Field ("MMEEventKeyPlatform", "__Internal")]
		NSString MMEEventKeyPlatform { get; }

		// extern NSString *const MMEEventKeyUserAgent;
		[Field ("MMEEventKeyUserAgent", "__Internal")]
		NSString MMEEventKeyUserAgent { get; }

		// extern NSString *const MMEEventKeyiOS;
		[Field ("MMEEventKeyiOS", "__Internal")]
		NSString MMEEventKeyiOS { get; }

		// extern NSString *const MMEEventKeyMac;
		[Field ("MMEEventKeyMac", "__Internal")]
		NSString MMEEventKeyMac { get; }

		// extern NSString *const MMEEventKeyApproximate;
		[Field ("MMEEventKeyApproximate", "__Internal")]
		NSString MMEEventKeyApproximate { get; }

		// extern NSString *const MMEEventKeyLocationsForeground;
		[Field ("MMEEventKeyLocationsForeground", "__Internal")]
		NSString MMEEventKeyLocationsForeground { get; }

		// extern NSString *const MMEEventKeyLocationsBackground;
		[Field ("MMEEventKeyLocationsBackground", "__Internal")]
		NSString MMEEventKeyLocationsBackground { get; }

		// extern NSString *const MMEEventKeyLocationsWithApproximateValues;
		[Field ("MMEEventKeyLocationsWithApproximateValues", "__Internal")]
		NSString MMEEventKeyLocationsWithApproximateValues { get; }

		// extern NSString *const MMEEventKeyLocationsDroppedBecauseOfHAF;
		[Field ("MMEEventKeyLocationsDroppedBecauseOfHAF", "__Internal")]
		NSString MMEEventKeyLocationsDroppedBecauseOfHAF { get; }

		// extern NSString *const MMEEventKeyLocationsDroppedDueTimeout;
		[Field ("MMEEventKeyLocationsDroppedDueTimeout", "__Internal")]
		NSString MMEEventKeyLocationsDroppedDueTimeout { get; }

		// extern NSString *const MMEEventKeyLocationsConvertedIntoEvents;
		[Field ("MMEEventKeyLocationsConvertedIntoEvents", "__Internal")]
		NSString MMEEventKeyLocationsConvertedIntoEvents { get; }

		// extern NSString *const MMENavigationEventPrefix;
		[Field ("MMENavigationEventPrefix", "__Internal")]
		NSString MMENavigationEventPrefix { get; }

		// extern NSString *const MMEVisionEventPrefix;
		[Field ("MMEVisionEventPrefix", "__Internal")]
		NSString MMEVisionEventPrefix { get; }

		// extern NSString *const MMEEventTypeNavigationDepart;
		[Field ("MMEEventTypeNavigationDepart", "__Internal")]
		NSString MMEEventTypeNavigationDepart { get; }

		// extern NSString *const MMEEventTypeNavigationArrive;
		[Field ("MMEEventTypeNavigationArrive", "__Internal")]
		NSString MMEEventTypeNavigationArrive { get; }

		// extern NSString *const MMEEventTypeNavigationCancel;
		[Field ("MMEEventTypeNavigationCancel", "__Internal")]
		NSString MMEEventTypeNavigationCancel { get; }

		// extern NSString *const MMEEventTypeNavigationFeedback;
		[Field ("MMEEventTypeNavigationFeedback", "__Internal")]
		NSString MMEEventTypeNavigationFeedback { get; }

		// extern NSString *const MMEEventTypeNavigationReroute;
		[Field ("MMEEventTypeNavigationReroute", "__Internal")]
		NSString MMEEventTypeNavigationReroute { get; }

		// extern NSString *const MMEventTypeNavigationCarplayConnect;
		[Field ("MMEventTypeNavigationCarplayConnect", "__Internal")]
		NSString MMEventTypeNavigationCarplayConnect { get; }

		// extern NSString *const MMEventTypeNavigationCarplayDisconnect;
		[Field ("MMEventTypeNavigationCarplayDisconnect", "__Internal")]
		NSString MMEventTypeNavigationCarplayDisconnect { get; }

		// extern NSString *const MMEEventTypeSearchSelected;
		[Field ("MMEEventTypeSearchSelected", "__Internal")]
		NSString MMEEventTypeSearchSelected { get; }

		// extern NSString *const MMEEventTypeSearchFeedback;
		[Field ("MMEEventTypeSearchFeedback", "__Internal")]
		NSString MMEEventTypeSearchFeedback { get; }

		// extern NSString *const MMESearchEventPrefix;
		[Field ("MMESearchEventPrefix", "__Internal")]
		NSString MMESearchEventPrefix { get; }

		// extern NSString *const MMEEventDateUTC;
		[Field ("MMEEventDateUTC", "__Internal")]
		NSString MMEEventDateUTC { get; }

		// extern NSString *const MMEEventRequests;
		[Field ("MMEEventRequests", "__Internal")]
		NSString MMEEventRequests { get; }

		// extern NSString *const MMEEventTotalDataSent;
		[Field ("MMEEventTotalDataSent", "__Internal")]
		NSString MMEEventTotalDataSent { get; }

		// extern NSString *const MMEEventCellDataSent;
		[Field ("MMEEventCellDataSent", "__Internal")]
		NSString MMEEventCellDataSent { get; }

		// extern NSString *const MMEEventWiFiDataSent;
		[Field ("MMEEventWiFiDataSent", "__Internal")]
		NSString MMEEventWiFiDataSent { get; }

		// extern NSString *const MMEEventTotalDataReceived;
		[Field ("MMEEventTotalDataReceived", "__Internal")]
		NSString MMEEventTotalDataReceived { get; }

		// extern NSString *const MMEEventCellDataReceived;
		[Field ("MMEEventCellDataReceived", "__Internal")]
		NSString MMEEventCellDataReceived { get; }

		// extern NSString *const MMEEventWiFiDataReceived;
		[Field ("MMEEventWiFiDataReceived", "__Internal")]
		NSString MMEEventWiFiDataReceived { get; }

		// extern NSString *const MMEEventAppWakeups;
		[Field ("MMEEventAppWakeups", "__Internal")]
		NSString MMEEventAppWakeups { get; }

		// extern NSString *const MMEEventEventCountPerType;
		[Field ("MMEEventEventCountPerType", "__Internal")]
		NSString MMEEventEventCountPerType { get; }

		// extern NSString *const MMEEventEventCountFailed;
		[Field ("MMEEventEventCountFailed", "__Internal")]
		NSString MMEEventEventCountFailed { get; }

		// extern NSString *const MMEEventEventCountTotal;
		[Field ("MMEEventEventCountTotal", "__Internal")]
		NSString MMEEventEventCountTotal { get; }

		// extern NSString *const MMEEventEventCountMax;
		[Field ("MMEEventEventCountMax", "__Internal")]
		NSString MMEEventEventCountMax { get; }

		// extern NSString *const MMEEventDeviceLat;
		[Field ("MMEEventDeviceLat", "__Internal")]
		NSString MMEEventDeviceLat { get; }

		// extern NSString *const MMEEventDeviceLon;
		[Field ("MMEEventDeviceLon", "__Internal")]
		NSString MMEEventDeviceLon { get; }

		// extern NSString *const MMEEventDeviceTimeDrift;
		[Field ("MMEEventDeviceTimeDrift", "__Internal")]
		NSString MMEEventDeviceTimeDrift { get; }

		// extern NSString *const MMEEventConfigResponse;
		[Field ("MMEEventConfigResponse", "__Internal")]
		NSString MMEEventConfigResponse { get; }

		// extern NSString *const MMEEventStatusDenied;
		[Field ("MMEEventStatusDenied", "__Internal")]
		NSString MMEEventStatusDenied { get; }

		// extern NSString *const MMEEventStatusRestricted;
		[Field ("MMEEventStatusRestricted", "__Internal")]
		NSString MMEEventStatusRestricted { get; }

		// extern NSString *const MMEEventStatusNotDetermined;
		[Field ("MMEEventStatusNotDetermined", "__Internal")]
		NSString MMEEventStatusNotDetermined { get; }

		// extern NSString *const MMEEventStatusAuthorizedAlways;
		[Field ("MMEEventStatusAuthorizedAlways", "__Internal")]
		NSString MMEEventStatusAuthorizedAlways { get; }

		// extern NSString *const MMEEventStatusAuthorizedWhenInUse;
		[Field ("MMEEventStatusAuthorizedWhenInUse", "__Internal")]
		NSString MMEEventStatusAuthorizedWhenInUse { get; }

		// extern NSString *const MMEEventUnknown;
		[Field ("MMEEventUnknown", "__Internal")]
		NSString MMEEventUnknown { get; }

		// extern NSString *const MMEAccuracyAuthorizationFull;
		[Field ("MMEAccuracyAuthorizationFull", "__Internal")]
		NSString MMEAccuracyAuthorizationFull { get; }

		// extern NSString *const MMEAccuracyAuthorizationReduced;
		[Field ("MMEAccuracyAuthorizationReduced", "__Internal")]
		NSString MMEAccuracyAuthorizationReduced { get; }

		// extern NSString *const MMEResponseKey;
		[Field ("MMEResponseKey", "__Internal")]
		NSString MMEResponseKey { get; }

		// extern NSString *const MMEEventSource;
		[Field ("MMEEventSource", "__Internal")]
		NSString MMEEventSource { get; }

		// extern NSString *const MMEEventMobileCrash;
		[Field ("MMEEventMobileCrash", "__Internal")]
		NSString MMEEventMobileCrash { get; }

		// extern NSString *const MMEEventKeyOSVersion;
		[Field ("MMEEventKeyOSVersion", "__Internal")]
		NSString MMEEventKeyOSVersion { get; }

		// extern NSString *const MMEEventKeyBuildType;
		[Field ("MMEEventKeyBuildType", "__Internal")]
		NSString MMEEventKeyBuildType { get; }

		// extern NSString *const MMEEventKeyIsSilentCrash;
		[Field ("MMEEventKeyIsSilentCrash", "__Internal")]
		NSString MMEEventKeyIsSilentCrash { get; }

		// extern NSString *const MMEEventKeyStackTrace;
		[Field ("MMEEventKeyStackTrace", "__Internal")]
		NSString MMEEventKeyStackTrace { get; }

		// extern NSString *const MMEEventKeyStackTraceHash;
		[Field ("MMEEventKeyStackTraceHash", "__Internal")]
		NSString MMEEventKeyStackTraceHash { get; }

		// extern NSString *const MMEEventKeyInstallationId;
		[Field ("MMEEventKeyInstallationId", "__Internal")]
		NSString MMEEventKeyInstallationId { get; }

		// extern NSString *const MMEEventKeyThreadDetails;
		[Field ("MMEEventKeyThreadDetails", "__Internal")]
		NSString MMEEventKeyThreadDetails { get; }

		// extern NSString *const MMEEventKeyAppId;
		[Field ("MMEEventKeyAppId", "__Internal")]
		NSString MMEEventKeyAppId { get; }

		// extern NSString *const MMEEventKeyAppVersion;
		[Field ("MMEEventKeyAppVersion", "__Internal")]
		NSString MMEEventKeyAppVersion { get; }

		// extern NSString *const MMEEventKeyAppStartDate;
		[Field ("MMEEventKeyAppStartDate", "__Internal")]
		NSString MMEEventKeyAppStartDate { get; }

		// extern NSString *const MMEEventKeyCustomData;
		[Field ("MMEEventKeyCustomData", "__Internal")]
		NSString MMEEventKeyCustomData { get; }

		// extern const NSErrorDomain MMEErrorDomain;
		[Field ("MMEErrorDomain", "__Internal")]
		NSString MMEErrorDomain { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const MMEErrorEventAttributesKey;
		[Field ("MMEErrorEventAttributesKey", "__Internal")]
		NSString MMEErrorEventAttributesKey { get; }

		// extern NSString *const MMEErrorUnderlyingExceptionKey;
		[Field ("MMEErrorUnderlyingExceptionKey", "__Internal")]
		NSString MMEErrorUnderlyingExceptionKey { get; }

		// extern NSString *const MMEAPIClientBaseURL;
		[Field ("MMEAPIClientBaseURL", "__Internal")]
		NSString MMEAPIClientBaseURL { get; }

		// extern NSString *const MMEErrorDescriptionKey;
		[Field ("MMEErrorDescriptionKey", "__Internal")]
		NSString MMEErrorDescriptionKey { get; }

		// extern NSString *const MMEEventKeyVendorID;
		[Field ("MMEEventKeyVendorID", "__Internal")]
		NSString MMEEventKeyVendorID { get; }

		// extern NSString *const MMEEventKeyInstallationID;
		[Field ("MMEEventKeyInstallationID", "__Internal")]
		NSString MMEEventKeyInstallationID { get; }

		// extern NSString *const MMEEventKeyAppID;
		[Field ("MMEEventKeyAppID", "__Internal")]
		NSString MMEEventKeyAppID { get; }

		// extern NSString *const MMEEventKeyGestureId;
		[Field ("MMEEventKeyGestureId", "__Internal")]
		NSString MMEEventKeyGestureId { get; }

		// extern NSString *const MMEEventKeyGestureID;
		[Field ("MMEEventKeyGestureID", "__Internal")]
		NSString MMEEventKeyGestureID { get; }

		// extern NSString *const MMEEventGestureSingleTap;
		[Field ("MMEEventGestureSingleTap", "__Internal")]
		NSString MMEEventGestureSingleTap { get; }

		// extern NSString *const MMEEventGestureDoubleTap;
		[Field ("MMEEventGestureDoubleTap", "__Internal")]
		NSString MMEEventGestureDoubleTap { get; }

		// extern NSString *const MMEEventGestureTwoFingerSingleTap;
		[Field ("MMEEventGestureTwoFingerSingleTap", "__Internal")]
		NSString MMEEventGestureTwoFingerSingleTap { get; }

		// extern NSString *const MMEEventGestureQuickZoom;
		[Field ("MMEEventGestureQuickZoom", "__Internal")]
		NSString MMEEventGestureQuickZoom { get; }

		// extern NSString *const MMEEventGesturePanStart;
		[Field ("MMEEventGesturePanStart", "__Internal")]
		NSString MMEEventGesturePanStart { get; }

		// extern NSString *const MMEEventGesturePinchStart;
		[Field ("MMEEventGesturePinchStart", "__Internal")]
		NSString MMEEventGesturePinchStart { get; }

		// extern NSString *const MMEEventGestureRotateStart;
		[Field ("MMEEventGestureRotateStart", "__Internal")]
		NSString MMEEventGestureRotateStart { get; }

		// extern NSString *const MMEEventGesturePitchStart;
		[Field ("MMEEventGesturePitchStart", "__Internal")]
		NSString MMEEventGesturePitchStart { get; }

		// extern NSString *const MMEEventTypeMapTap;
		[Field ("MMEEventTypeMapTap", "__Internal")]
		NSString MMEEventTypeMapTap { get; }

		// extern NSString *const MMEEventTypeMapDragEnd;
		[Field ("MMEEventTypeMapDragEnd", "__Internal")]
		NSString MMEEventTypeMapDragEnd { get; }
	}

	// @interface MMEEvent : NSObject <NSCopying, NSSecureCoding>
	[BaseType (typeof(NSObject))]
	interface MMEEvent : INSCopying, INSSecureCoding
	{
		// @property (readonly, copy, nonatomic) NSDate * _Nonnull date;
		[Export ("date", ArgumentSemantic.Copy)]
		NSDate Date { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nonnull attributes;
		[Export ("attributes", ArgumentSemantic.Copy)]
		NSDictionary Attributes { get; }

		// -(instancetype _Nonnull)initWithAttributes:(NSDictionary * _Nonnull)eventAttributes error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
		[Export ("initWithAttributes:error:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSDictionary eventAttributes, [NullAllowed] out NSError error);

		// +(instancetype _Nonnull)eventWithAttributes:(NSDictionary * _Nonnull)attributes;
		[Static]
		[Export ("eventWithAttributes:")]
		MMEEvent EventWithAttributes (NSDictionary attributes);

		// +(instancetype _Nonnull)eventWithAttributes:(NSDictionary * _Nonnull)attributes error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export ("eventWithAttributes:error:")]
		MMEEvent EventWithAttributes (NSDictionary attributes, [NullAllowed] out NSError error);

		// +(instancetype _Nonnull)turnstileEventWithAttributes:(NSDictionary * _Nonnull)attributes;
		[Static]
		[Export ("turnstileEventWithAttributes:")]
		MMEEvent TurnstileEventWithAttributes (NSDictionary attributes);

		// +(instancetype _Nonnull)visitEventWithAttributes:(NSDictionary * _Nonnull)attributes;
		[Static]
		[Export ("visitEventWithAttributes:")]
		MMEEvent VisitEventWithAttributes (NSDictionary attributes);

		// +(instancetype _Nonnull)crashEventReporting:(NSError * _Nonnull)eventsError error:(NSError * _Nullable * _Nullable)createError;
		[Static]
		[Export ("crashEventReporting:error:")]
		MMEEvent CrashEventReporting (NSError eventsError, [NullAllowed] out NSError createError);

		// +(instancetype _Nonnull)debugEventWithAttributes:(NSDictionary * _Nonnull)attributes;
		[Static]
		[Export ("debugEventWithAttributes:")]
		MMEEvent DebugEventWithAttributes (NSDictionary attributes);

		// +(instancetype _Nonnull)debugEventWithError:(NSError * _Nonnull)error;
		[Static]
		[Export ("debugEventWithError:")]
		MMEEvent DebugEventWithError (NSError error);

		// +(instancetype _Nonnull)debugEventWithException:(NSException * _Nonnull)except;
		[Static]
		[Export ("debugEventWithException:")]
		MMEEvent DebugEventWithException (NSException except);

		// +(instancetype _Nonnull)locationEventWithAttributes:(NSDictionary * _Nonnull)attributes instanceIdentifer:(NSString * _Nonnull)instanceIdentifer commonEventData:(MMECommonEventData * _Nonnull)commonEventData;
		[Static]
		[Export ("locationEventWithAttributes:instanceIdentifer:commonEventData:")]
		MMEEvent LocationEventWithAttributes (NSDictionary attributes, string instanceIdentifer, MMECommonEventData commonEventData);

		// +(instancetype _Nonnull)mapLoadEventWithDateString:(NSString * _Nonnull)dateString commonEventData:(MMECommonEventData * _Nonnull)commonEventData;
		[Static]
		[Export ("mapLoadEventWithDateString:commonEventData:")]
		MMEEvent MapLoadEventWithDateString (string dateString, MMECommonEventData commonEventData);

		// +(instancetype _Nonnull)eventWithName:(NSString * _Nonnull)eventName attributes:(NSDictionary * _Nonnull)attributes;
		[Static]
		[Export ("eventWithName:attributes:")]
		MMEEvent EventWithName (string eventName, NSDictionary attributes);

		// +(instancetype _Nonnull)navigationEventWithName:(NSString * _Nonnull)name attributes:(NSDictionary * _Nonnull)attributes;
		[Static]
		[Export ("navigationEventWithName:attributes:")]
		MMEEvent NavigationEventWithName (string name, NSDictionary attributes);

		// +(instancetype _Nonnull)visionEventWithName:(NSString * _Nonnull)name attributes:(NSDictionary * _Nonnull)attributes;
		[Static]
		[Export ("visionEventWithName:attributes:")]
		MMEEvent VisionEventWithName (string name, NSDictionary attributes);

		// +(instancetype _Nonnull)searchEventWithName:(NSString * _Nonnull)name attributes:(NSDictionary * _Nonnull)attributes;
		[Static]
		[Export ("searchEventWithName:attributes:")]
		MMEEvent SearchEventWithName (string name, NSDictionary attributes);

		// +(instancetype _Nonnull)carplayEventWithName:(NSString * _Nonnull)name attributes:(NSDictionary * _Nonnull)attributes;
		[Static]
		[Export ("carplayEventWithName:attributes:")]
		MMEEvent CarplayEventWithName (string name, NSDictionary attributes);

		// +(instancetype _Nonnull)telemetryMetricsEventWithDateString:(NSString * _Nonnull)dateString attributes:(NSDictionary * _Nonnull)attributes;
		[Static]
		[Export ("telemetryMetricsEventWithDateString:attributes:")]
		MMEEvent TelemetryMetricsEventWithDateString (string dateString, NSDictionary attributes);

		// +(instancetype _Nonnull)mapTapEventWithDateString:(NSString * _Nonnull)dateString attributes:(NSDictionary * _Nonnull)attributes;
		[Static]
		[Export ("mapTapEventWithDateString:attributes:")]
		MMEEvent MapTapEventWithDateString (string dateString, NSDictionary attributes);

		// +(instancetype _Nonnull)mapDragEndEventWithDateString:(NSString * _Nonnull)dateString attributes:(NSDictionary * _Nonnull)attributes;
		[Static]
		[Export ("mapDragEndEventWithDateString:attributes:")]
		MMEEvent MapDragEndEventWithDateString (string dateString, NSDictionary attributes);

		// +(instancetype _Nonnull)mapOfflineDownloadStartEventWithDateString:(NSString * _Nonnull)dateString attributes:(NSDictionary * _Nonnull)attributes;
		[Static]
		[Export ("mapOfflineDownloadStartEventWithDateString:attributes:")]
		MMEEvent MapOfflineDownloadStartEventWithDateString (string dateString, NSDictionary attributes);

		// +(instancetype _Nonnull)mapOfflineDownloadEndEventWithDateString:(NSString * _Nonnull)dateString attributes:(NSDictionary * _Nonnull)attributes;
		[Static]
		[Export ("mapOfflineDownloadEndEventWithDateString:attributes:")]
		MMEEvent MapOfflineDownloadEndEventWithDateString (string dateString, NSDictionary attributes);

		// +(instancetype _Nonnull)eventWithDateString:(NSString * _Nonnull)dateString name:(NSString * _Nonnull)name attributes:(NSDictionary * _Nonnull)attributes;
		[Static]
		[Export ("eventWithDateString:name:attributes:")]
		MMEEvent EventWithDateString (string dateString, string name, NSDictionary attributes);
	}

	// @interface MMEEventsManager : NSObject
	[BaseType (typeof(NSObject))]
	interface MMEEventsManager
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MMEEventsManagerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MMEEventsManagerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull skuId;
		[Export ("skuId")]
		string SkuId { get; set; }

		// @property (nonatomic) id<MMEAPIClient> _Nonnull apiClient;
		[Export ("apiClient", ArgumentSemantic.Assign)]
		MMEAPIClient ApiClient { get; set; }

		// +(instancetype _Nonnull)sharedManager;
		[Static]
		[Export ("sharedManager")]
		MMEEventsManager SharedManager ();

		// -(void)initializeWithAccessToken:(NSString * _Nonnull)accessToken userAgentBase:(NSString * _Nonnull)userAgentBase hostSDKVersion:(NSString * _Nonnull)hostSDKVersion;
		[Export ("initializeWithAccessToken:userAgentBase:hostSDKVersion:")]
		void InitializeWithAccessToken (string accessToken, string userAgentBase, string hostSDKVersion);

		// -(void)pauseOrResumeMetricsCollectionIfRequired;
		[Export ("pauseOrResumeMetricsCollectionIfRequired")]
		void PauseOrResumeMetricsCollectionIfRequired ();

		// -(void)flush;
		[Export ("flush")]
		void Flush ();

		// -(void)resetEventQueuing;
		[Export ("resetEventQueuing")]
		void ResetEventQueuing ();

		// -(void)sendTurnstileEvent;
		[Export ("sendTurnstileEvent")]
		void SendTurnstileEvent ();

		// -(void)sendTelemetryMetricsEvent;
		[Export ("sendTelemetryMetricsEvent")]
		void SendTelemetryMetricsEvent ();

		// -(void)disableLocationMetrics;
		[Export ("disableLocationMetrics")]
		void DisableLocationMetrics ();

		// -(void)enqueueEventWithName:(NSString * _Nonnull)name;
		[Export ("enqueueEventWithName:")]
		void EnqueueEventWithName (string name);

		// -(void)enqueueEventWithName:(NSString * _Nonnull)name attributes:(MMEMapboxEventAttributes * _Nonnull)attributes;
		[Export ("enqueueEventWithName:attributes:")]
		void EnqueueEventWithName (string name, NSDictionary<NSString, NSObject> attributes);

		// -(void)postMetadata:(NSArray * _Nonnull)metadata filePaths:(NSArray * _Nonnull)filePaths completionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
		[Export ("postMetadata:filePaths:completionHandler:")]
		[Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
		void PostMetadata (NSObject[] metadata, NSObject[] filePaths, [NullAllowed] Action<NSError> completionHandler);

		// -(MMEEvent * _Nonnull)reportError:(NSError * _Nonnull)eventsError;
		[Export ("reportError:")]
		MMEEvent ReportError (NSError eventsError);

		// -(MMEEvent * _Nonnull)reportException:(NSException * _Nonnull)eventException;
		[Export ("reportException:")]
		MMEEvent ReportException (NSException eventException);

		// -(void)setDebugHandler:(void (^ _Nonnull)(NSUInteger, NSString * _Nonnull, NSString * _Nonnull))handler;
		[Export ("setDebugHandler:")]
		void SetDebugHandler (Action<nuint, NSString, NSString> handler);
	}

	// @protocol MMEEventsManagerDelegate <NSObject>
	[Protocol, Model (AutoGeneratedName = true)]
	[BaseType (typeof(NSObject))]
	interface MMEEventsManagerDelegate
	{
		// @optional -(void)eventsManager:(MMEEventsManager * _Nonnull)eventsManager didUpdateLocations:(NSArray<CLLocation *> * _Nonnull)locations;
		[Export ("eventsManager:didUpdateLocations:")]
		void DidUpdateLocations (MMEEventsManager eventsManager, CLLocation[] locations);

		// @optional -(void)eventsManager:(MMEEventsManager * _Nonnull)eventsManager didEncounterError:(NSError * _Nonnull)error;
		[Export ("eventsManager:didEncounterError:")]
		void DidEncounterError (MMEEventsManager eventsManager, NSError error);

		// @optional -(void)eventsManager:(MMEEventsManager * _Nonnull)eventsManager didEnqueueEvent:(MMEEvent * _Nonnull)enqueued;
		[Export ("eventsManager:didEnqueueEvent:")]
		void DidEnqueueEvent (MMEEventsManager eventsManager, MMEEvent enqueued);

		// @optional -(void)eventsManager:(MMEEventsManager * _Nonnull)eventsManager didSendEvents:(NSArray<MMEEvent *> * _Nonnull)events;
		[Export ("eventsManager:didSendEvents:")]
		void DidSendEvents (MMEEventsManager eventsManager, MMEEvent[] events);

		// @optional -(void)eventsManager:(MMEEventsManager * _Nonnull)eventsManager didVisit:(CLVisit * _Nonnull)visit;
		[Export ("eventsManager:didVisit:")]
		void DidVisit (MMEEventsManager eventsManager, CLVisit visit);
	}

	// @interface MMEConfiguration (NSUserDefaults)
	[Category]
	[BaseType (typeof(NSUserDefaults))]
	interface NSUserDefaults_MMEConfiguration
	{
		// +(instancetype _Nonnull)mme_configuration;
		[Static]
		[Export ("mme_configuration")]
		NSUserDefaults Mme_configuration ();

		// @property (readonly, nonatomic) NSTimeInterval mme_startupDelay;
		[Export ("mme_startupDelay")]
		double Mme_startupDelay { get; }

		// @property (readonly, nonatomic) NSUInteger mme_eventFlushCount;
		[Export ("mme_eventFlushCount")]
		nuint Mme_eventFlushCount { get; }

		// @property (readonly, nonatomic) NSTimeInterval mme_eventFlushInterval;
		[Export ("mme_eventFlushInterval")]
		double Mme_eventFlushInterval { get; }

		// @property (readonly, nonatomic) NSTimeInterval mme_identifierRotationInterval;
		[Export ("mme_identifierRotationInterval")]
		double Mme_identifierRotationInterval { get; }

		// @property (readonly, nonatomic) NSTimeInterval mme_configUpdateInterval;
		[Export ("mme_configUpdateInterval")]
		double Mme_configUpdateInterval { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull mme_eventTag;
		[Export ("mme_eventTag")]
		string Mme_eventTag { get; }

		// @property (copy, nonatomic, setter = mme_setAccessToken:) NSString * _Nonnull mme_accessToken;
		[Export ("mme_accessToken")]
		string Mme_accessToken { get; [Bind ("mme_setAccessToken:")] set; }

		// @property (copy, nonatomic, setter = mme_setLegacyUserAgentBase:) NSString * _Nonnull mme_legacyUserAgentBase;
		[Export ("mme_legacyUserAgentBase")]
		string Mme_legacyUserAgentBase { get; [Bind ("mme_setLegacyUserAgentBase:")] set; }

		// @property (copy, nonatomic, setter = mme_setLegacyHostSDKVersion:) NSString * _Nonnull mme_legacyHostSDKVersion;
		[Export ("mme_legacyHostSDKVersion")]
		string Mme_legacyHostSDKVersion { get; [Bind ("mme_setLegacyHostSDKVersion:")] set; }

		// @property (assign, nonatomic, setter = mme_setIsCNRegion:) BOOL mme_isCNRegion;
		[Export ("mme_isCNRegion")]
		bool Mme_isCNRegion { get; [Bind ("mme_setIsCNRegion:")] set; }

		// @property (readonly, nonatomic) NSURL * _Nonnull mme_APIServiceURL;
		[Export ("mme_APIServiceURL")]
		NSURL Mme_APIServiceURL { get; }

		// @property (readonly, nonatomic) NSURL * _Nonnull mme_eventsServiceURL;
		[Export ("mme_eventsServiceURL")]
		NSURL Mme_eventsServiceURL { get; }

		// @property (readonly, nonatomic) NSURL * _Nonnull mme_configServiceURL;
		[Export ("mme_configServiceURL")]
		NSURL Mme_configServiceURL { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull mme_userAgentString;
		[Export ("mme_userAgentString")]
		string Mme_userAgentString { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull mme_legacyUserAgentString;
		[Export ("mme_legacyUserAgentString")]
		string Mme_legacyUserAgentString { get; }

		// @property (nonatomic, setter = mme_setConfigUpdateDate:) MMEDate * _Nullable mme_configUpdateDate;
		[NullAllowed, Export ("mme_configUpdateDate", ArgumentSemantic.Assign)]
		MMEDate Mme_configUpdateDate { get; [Bind ("mme_setConfigUpdateDate:")] set; }

		// @property (nonatomic, setter = mme_setIsCollectionEnabled:) BOOL mme_isCollectionEnabled;
		[Export ("mme_isCollectionEnabled")]
		bool Mme_isCollectionEnabled { get; [Bind ("mme_setIsCollectionEnabled:")] set; }

		// @property (readonly, nonatomic) BOOL mme_isCollectionEnabledInSimulator;
		[Export ("mme_isCollectionEnabledInSimulator")]
		bool Mme_isCollectionEnabledInSimulator { get; }

		// @property (readonly, nonatomic) BOOL mme_isCollectionEnabledInLowPowerMode;
		[Export ("mme_isCollectionEnabledInLowPowerMode")]
		bool Mme_isCollectionEnabledInLowPowerMode { get; }

		// @property (readonly, nonatomic) BOOL mme_isCollectionEnabledInBackground;
		[Export ("mme_isCollectionEnabledInBackground")]
		bool Mme_isCollectionEnabledInBackground { get; }

		// @property (readonly, nonatomic) NSTimeInterval mme_backgroundStartupDelay;
		[Export ("mme_backgroundStartupDelay")]
		double Mme_backgroundStartupDelay { get; }

		// @property (readonly, nonatomic) CLLocationDistance mme_backgroundGeofence;
		[Export ("mme_backgroundGeofence")]
		double Mme_backgroundGeofence { get; }

		// @property (readonly, nonatomic) CLLocationAccuracy mme_horizontalAccuracy;
		[Export ("mme_horizontalAccuracy")]
		double Mme_horizontalAccuracy { get; }

		// @property (readonly, nonatomic) NSArray<NSString *> * _Nonnull mme_certificateRevocationList;
		[Export ("mme_certificateRevocationList")]
		string[] Mme_certificateRevocationList { get; }

		// @property (readonly, nonatomic) NSDictionary * _Nonnull mme_certificatePinningConfig;
		[Export ("mme_certificatePinningConfig")]
		NSDictionary Mme_certificatePinningConfig { get; }
	}
}
