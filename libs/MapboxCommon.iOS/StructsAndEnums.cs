using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreLocation;
using Foundation;
using MapboxCommon;
using ObjCRuntime;
using Security;

namespace MapboxCommon
{
	public enum MBXGeometryType : uint
	{
		Empty,
		Point,
		Line,
		Polygon,
		MultiPoint,
		MultiLine,
		MultiPolygon,
		GeometryCollection
	}

	[Native]
	public enum MBXHttpMethod : long
	{
		Get,
		Head,
		Post
	}

	[Native]
	public enum MBXNetworkRestriction : long
	{
		None = 0,
		DisallowExpensive = 1,
		DisallowAll = 255
	}

	[Native]
	public enum MBXHttpRequestErrorType : long
	{
		ConnectionError,
		SSLError,
		RequestCancelled,
		RequestTimedOut,
		RangeError,
		OtherError
	}

	[Native]
	public enum MBXDownloadErrorCode : long
	{
		FileSystemError,
		NetworkError
	}

	[Native]
	public enum MBXDownloadState : long
	{
		Pending,
		Downloading,
		Failed,
		Finished
	}

	[Native]
	public enum MBXTileDataDomain : long
	{
		Maps,
		Navigation,
		Search,
		Adas
	}

	[Native]
	public enum MBXTileRegionErrorType : long
	{
		Canceled,
		DoesNotExist,
		TilesetDescriptor,
		DiskFull,
		Other,
		TileCountExceeded
	}

	[Native]
	public enum CLError : long
	{
		LocationUnknown = 0,
		Denied,
		Network,
		HeadingFailure,
		RegionMonitoringDenied,
		RegionMonitoringFailure,
		RegionMonitoringSetupDelayed,
		RegionMonitoringResponseDelayed,
		GeocodeFoundNoResult,
		GeocodeFoundPartialResult,
		GeocodeCanceled,
		DeferredFailed,
		DeferredNotUpdatingLocation,
		DeferredAccuracyTooLow,
		DeferredDistanceFiltered,
		DeferredCanceled,
		RangingUnavailable,
		RangingFailure,
		PromptDeclined
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct CLLocationCoordinate2D
	{
		public double latitude;

		public double longitude;
	}

	[NoWatch, NoTV, Mac (10,10), iOS (7,0)]
	[Native]
	public enum CLRegionState : long
	{
		Unknown,
		Inside,
		Outside
	}

	[NoWatch, NoTV, Mac (10,15), iOS (7,0)]
	[Native]
	public enum CLProximity : long
	{
		Unknown,
		Immediate,
		Near,
		Far
	}

	public enum CLDeviceOrientation
	{
		Unknown = 0,
		Portrait,
		PortraitUpsideDown,
		LandscapeLeft,
		LandscapeRight,
		FaceUp,
		FaceDown
	}

	public enum CLAuthorizationStatus
	{
		NotDetermined = 0,
		Restricted,
		Denied,
		AuthorizedAlways,
		AuthorizedWhenInUse,
		Authorized = AuthorizedAlways
	}

	[Native]
	public enum CLAccuracyAuthorization : long
	{
		FullAccuracy,
		ReducedAccuracy
	}

	[Native]
	public enum CLActivityType : long
	{
		Other = 1,
		AutomotiveNavigation,
		Fitness,
		OtherNavigation,
		Airborne
	}

	[Unavailable (PlatformName.MacCatalyst)]
	[NoWatch, NoTV, NoMac, iOS (15,0)]
	[Native, Advice ("This API is not available when using UIKit on macOS.")]
	public enum CLLocationPushServiceError : long
	{
		Unknown = 0,
		MissingPushExtension = 1,
		MissingPushServerEnvironment = 2,
		MissingEntitlement = 3
	}
}
