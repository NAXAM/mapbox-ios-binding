using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using CoreLocation;
using Foundation;
using Mapbox;
using ObjCRuntime;

[Native]
public enum MGLAnnotationViewDragState : nuint
{
	None = 0,
	Starting,
	Dragging,
	Canceling,
	Ending
}

[StructLayout (LayoutKind.Sequential)]
public struct MGLCoordinateSpan
{
	public double latitudeDelta;

	public double longitudeDelta;
}

static class CFunctions
{
	// MGLCoordinateSpan MGLCoordinateSpanMake (CLLocationDegrees latitudeDelta, CLLocationDegrees longitudeDelta) __attribute__((always_inline));
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern MGLCoordinateSpan MGLCoordinateSpanMake (double latitudeDelta, double longitudeDelta);

	// BOOL MGLCoordinateSpanEqualToCoordinateSpan (MGLCoordinateSpan span1, MGLCoordinateSpan span2) __attribute__((always_inline));
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern bool MGLCoordinateSpanEqualToCoordinateSpan (MGLCoordinateSpan span1, MGLCoordinateSpan span2);

	// MGLCoordinateBounds MGLCoordinateBoundsMake (CLLocationCoordinate2D sw, CLLocationCoordinate2D ne) __attribute__((always_inline));
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern MGLCoordinateBounds MGLCoordinateBoundsMake (CLLocationCoordinate2D sw, CLLocationCoordinate2D ne);

	// BOOL MGLCoordinateBoundsEqualToCoordinateBounds (MGLCoordinateBounds bounds1, MGLCoordinateBounds bounds2) __attribute__((always_inline));
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern bool MGLCoordinateBoundsEqualToCoordinateBounds (MGLCoordinateBounds bounds1, MGLCoordinateBounds bounds2);

	// BOOL MGLCoordinateBoundsIntersectsCoordinateBounds (MGLCoordinateBounds bounds1, MGLCoordinateBounds bounds2) __attribute__((always_inline));
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern bool MGLCoordinateBoundsIntersectsCoordinateBounds (MGLCoordinateBounds bounds1, MGLCoordinateBounds bounds2);

	// BOOL MGLCoordinateInCoordinateBounds (CLLocationCoordinate2D coordinate, MGLCoordinateBounds bounds) __attribute__((always_inline));
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern bool MGLCoordinateInCoordinateBounds (CLLocationCoordinate2D coordinate, MGLCoordinateBounds bounds);

	// MGLCoordinateSpan MGLCoordinateBoundsGetCoordinateSpan (MGLCoordinateBounds bounds) __attribute__((always_inline));
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern MGLCoordinateSpan MGLCoordinateBoundsGetCoordinateSpan (MGLCoordinateBounds bounds);

	// MGLCoordinateBounds MGLCoordinateBoundsOffset (MGLCoordinateBounds bounds, MGLCoordinateSpan offset) __attribute__((always_inline));
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern MGLCoordinateBounds MGLCoordinateBoundsOffset (MGLCoordinateBounds bounds, MGLCoordinateSpan offset);

	// BOOL MGLCoordinateBoundsIsEmpty (MGLCoordinateBounds bounds) __attribute__((always_inline));
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern bool MGLCoordinateBoundsIsEmpty (MGLCoordinateBounds bounds);

	// NSString * _Nonnull MGLStringFromCoordinateBounds (MGLCoordinateBounds bounds) __attribute__((always_inline));
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern NSString MGLStringFromCoordinateBounds (MGLCoordinateBounds bounds);

	// CGFloat MGLRadiansFromDegrees (CLLocationDegrees degrees) __attribute__((always_inline));
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern nfloat MGLRadiansFromDegrees (double degrees);

	// CLLocationDegrees MGLDegreesFromRadians (CGFloat radians) __attribute__((always_inline));
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern double MGLDegreesFromRadians (nfloat radians);

	// MGLTransition MGLTransitionMake (NSTimeInterval duration, NSTimeInterval delay) __attribute__((always_inline));
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern MGLTransition MGLTransitionMake (double duration, double delay);
}

[StructLayout (LayoutKind.Sequential)]
public struct MGLCoordinateBounds
{
	public CLLocationCoordinate2D sw;

	public CLLocationCoordinate2D ne;
}

[Native]
public enum MGLErrorCode : nint
{
	Unknown = -1,
	NotFound = 1,
	BadServerResponse = 2,
	ConnectionFailed = 3
}

[Native]
public enum MGLMapDebugMaskOptions : nuint
{
	TileBoundariesMask = 1 << 1,
	TileInfoMask = 1 << 2,
	TimestampsMask = 1 << 3,
	CollisionBoxesMask = 1 << 4,
	OverdrawVisualizationMask = 1 << 5
}

[StructLayout (LayoutKind.Sequential)]
public struct MGLTransition
{
	public double duration;

	public double delay;
}

[Native]
public enum MGLAnnotationVerticalAlignment : nuint
{
	Center = 0,
	Top,
	Bottom
}

[Native]
public enum MGLUserTrackingMode : nuint
{
	None = 0,
	Follow,
	FollowWithHeading,
	FollowWithCourse
}

[Native]
public enum MGLOfflinePackState : nint
{
	Unknown = 0,
	Inactive = 1,
	Active = 2,
	Complete = 3,
	Invalid = 4
}

[StructLayout (LayoutKind.Sequential)]
public struct MGLOfflinePackProgress
{
	public ulong countOfResourcesCompleted;

	public ulong countOfBytesCompleted;

	public ulong countOfTilesCompleted;

	public ulong countOfTileBytesCompleted;

	public ulong countOfResourcesExpected;

	public ulong maximumResourcesExpected;
}

[Native]
public enum MGLResourceKind : nuint
{
	Unknown,
	Style,
	Source,
	Tile,
	Glyphs,
	SpriteImage,
	SpriteJSON
}

[Native]
public enum MGLInterpolationMode : nuint
{
	Exponential = 0,
	Interval,
	Categorical,
	Identity
}

[Native]
public enum MGLFillTranslationAnchor : nuint
{
	Map,
	Viewport
}

[Native]
public enum MGLLineCap : nuint
{
	Butt,
	Round,
	Square
}

[Native]
public enum MGLLineJoin : nuint
{
	Bevel,
	Round,
	Miter
}

[Native]
public enum MGLLineTranslationAnchor : nuint
{
	Map,
	Viewport
}

[Native]
public enum MGLIconRotationAlignment : nuint
{
	Map,
	Viewport,
	Auto
}

[Native]
public enum MGLIconTextFit : nuint
{
	None,
	Width,
	Height,
	Both
}

[Native]
public enum MGLSymbolPlacement : nuint
{
	Point,
	Line
}

[Native]
public enum MGLTextAnchor : nuint
{
	Center,
	Left,
	Right,
	Top,
	Bottom,
	TopLeft,
	TopRight,
	BottomLeft,
	BottomRight
}

[Native]
public enum MGLTextJustification : nuint
{
	Left,
	Center,
	Right
}

[Native]
public enum MGLTextPitchAlignment : nuint
{
	Map,
	Viewport,
	Auto
}

[Native]
public enum MGLTextRotationAlignment : nuint
{
	Map,
	Viewport,
	Auto
}

[Native]
public enum MGLTextTransform : nuint
{
	None,
	Uppercase,
	Lowercase
}

[Native]
public enum MGLIconTranslationAnchor : nuint
{
	Map,
	Viewport
}

[Native]
public enum MGLTextTranslationAnchor : nuint
{
	Map,
	Viewport
}

[Native]
public enum MGLCircleScaleAlignment : nuint
{
	Map,
	Viewport
}

[Native]
public enum MGLCircleTranslationAnchor : nuint
{
	Map,
	Viewport
}

[StructLayout (LayoutKind.Sequential)]
public struct MGLStyleLayerDrawingContext
{
	public CGSize size;

	public CLLocationCoordinate2D centerCoordinate;

	public double zoomLevel;

	public double direction;

	public nfloat pitch;

	public nfloat fieldOfView;
}

[Native]
public enum MGLTileCoordinateSystem : nuint
{
	Xyz = 0,
	Tms
}
