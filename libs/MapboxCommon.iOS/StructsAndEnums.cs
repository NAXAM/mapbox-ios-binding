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
	public enum MBXSettingsServiceStorageType : long
	{
		Persistent,
		NonPersistent
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
}
