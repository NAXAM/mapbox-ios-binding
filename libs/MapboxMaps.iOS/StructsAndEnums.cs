using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using CoreLocation;
using Foundation;
using Mapbox;
using ObjCRuntime;

namespace Mapbox
{
    [Native]
    public enum MGLOrnamentVisibility : ulong {
        /** A constant indicating that the ornament adapts to the current map state. */
        Adaptive,
        /** A constant indicating that the ornament is always hidden. */
        Hidden,
        /** A constant indicating that the ornament is always visible. */
        Visible
    }

    [Native] 
    public enum MGLTextWritingMode : ulong {
        /**
        If a text's language supports horizontal writing mode, symbols with point
        placement would be laid out horizontally.
        */
        Horizontal,
        /**
        If a text's language supports vertical writing mode, symbols with point
        placement would be laid out vertically.
        */
        Vertical,
    }

    [Native]
    public enum MGLMetricType : ulong
    {
        /** :nodoc:
        Metric that measures performance.
        */
        Performance = 0,
    }

    [Native]
	public enum MGLLoggingLevel : ulong
    {
        /**
        None-level messages are ignored.
        */
        None = 0,
        /**
        Fault-level messages contain system-level error information.
        */
        Fault,
        /**
        :nodoc: Any new logging level should be included in the default logging implementation.
        */
        /**
        Error-level messages contain information that is intended to aid in process-level
        errors.
        */
        Error,
        /**
        Warning-level messages contain warning information for potential risks.
        errors.
        */
        Warning,
        /**
        Info-level messages contain information that may be helpful for flow tracing
        but is not essential.
        */
        Info,
        /**
        Verbose-level will print all messages.
        */
        Verbose,
    }

    [Native]
	public enum MGLSymbolZOrder : ulong
    {
        /**
        If `MGLSymbolStyleLayer.symbolSortKey` is set, sort based on that.
        Otherwise sort symbols by their y-position relative to the viewport.
        */
        Auto,

        /**
        Specify this z order if symbols’ appearance relies on lower features
        overlapping higher features. For example, symbols with a pin-like
        appearance would require this z order.
        */
        ViewportY,
        /**
        Specify this z order if the order in which features appear in the source is
        significant.
        */
        Source,
    }

    [Native]
	public enum MGLOrnamentPosition : ulong
    {
        /** Place the ornament in the top left of the map view. */
        TopLeft = 0,
        /** Place the ornament in the top right of the map view. */
        TopRight,
        /** Place the ornament in the bottom left of the map view. */
        BottomLeft,
        /** Place the ornament in the bottom right of the map view. */
        BottomRight,
    }

    [Native]
	public enum MGLAnnotationViewDragState : ulong
    {
        None = 0,
        Starting,
        Dragging,
        Canceling,
        Ending
    }

    [Native]
    public enum MGLErrorCode : long
    {
        Unknown = -1,
        NotFound = 1,
        BadServerResponse = 2,
        ConnectionFailed = 3,
        ParseStyleFailed = 4,
        LoadStyleFailed = 5,
        SnapshotFailed = 6,

        // /** Source is in use and cannot be removed */
        SourceIsInUseCannotRemove = 7,
        // /** Source is in use and cannot be removed */
        SourceIdentifierMismatch = 8,
        /** An error occurred while modifying the offline storage database */
        ModifyingOfflineStorageFailed = 9,
        SourceCannotBeRemovedFromStyle  = 10
    }

    [Flags]
    [Native]
    public enum MGLMapDebugMaskOptions : ulong
    {
        TileBoundariesMask = 1uL << 1,
        TileInfoMask = 1uL << 2,
        TimestampsMask = 1uL << 3,
        CollisionBoxesMask = 1uL << 4,
        OverdrawVisualizationMask = 1uL << 5
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct MGLTransition
    {
        public double duration;

        public double delay;
    }

    [Native]
    public enum MGLAttributionInfoStyle : ulong
    {
        Short = 1,
        Medium,
        Long
    }

    [Flags]
    [Native]
    public enum MGLCameraChangeReason : ulong
    {
        None = 0x0,
        Programmatic = 1uL << 0,
        ResetNorth = 1uL << 1,
        GesturePan = 1uL << 2,
        GesturePinch = 1uL << 3,
        GestureRotate = 1uL << 4,
        GestureZoomIn = 1uL << 5,
        GestureZoomOut = 1uL << 6,
        GestureOneFingerZoom = 1uL << 7,
        GestureTilt = 1uL << 8,
		TransitionCancelled = 1uL << 16
    }

    [Native]
    public enum MGLCirclePitchAlignment : ulong
    {
        Map,
        Viewport
    }

    [Native]
    public enum MGLCircleScaleAlignment : ulong
    {
        Map,
        Viewport
    }

    [Native]
    public enum MGLCircleTranslationAnchor : ulong
    {
        Map,
        Viewport
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct MGLCoordinateSpan
    {
        public double latitudeDelta;

        public double longitudeDelta;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct MGLMapPoint
    {
        public nfloat x;

        public nfloat y;

        public nfloat zoomLevel;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct MGLMatrix4
    {
        public double m00;

        public double m01;

        public double m02;

        public double m03;

        public double m10;

        public double m11;

        public double m12;

        public double m13;

        public double m20;

        public double m21;

        public double m22;

        public double m23;

        public double m30;

        public double m31;

        public double m32;

        public double m33;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct MGLCoordinateBounds
    {
        public CLLocationCoordinate2D sw;

        public CLLocationCoordinate2D ne;
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct MGLCoordinateQuad
    {
        public CLLocationCoordinate2D TopLeft;

        public CLLocationCoordinate2D BottomLeft;

        public CLLocationCoordinate2D BottomRight;

        public CLLocationCoordinate2D TopRight;
    }

    [Native]
    public enum MGLFillExtrusionTranslationAnchor : ulong
    {
        Map,
        Viewport
    }

    [Native]
    public enum MGLFillTranslationAnchor : ulong
    {
        Map,
        Viewport
    }

    [Native]
    public enum MGLHillshadeIlluminationAnchor : ulong
    {
        Map,
        Viewport
    }

    [Native]
    public enum MGLLightAnchor : ulong
    {
        Map,
        Viewport
    }

    [StructLayout (LayoutKind.Sequential)]
    public struct MGLSphericalPosition
    {
        public nfloat radial;

        public double azimuthal;

        public double polar;
    }

    [Native]
    public enum MGLLineCap : ulong
    {
        Butt,
        Round,
        Square
    }

    [Native]
    public enum MGLLineJoin : ulong
    {
        Bevel,
        Round,
        Miter
    }

    [Native]
    public enum MGLLineTranslationAnchor : ulong
    {
        Map,
        Viewport
    }

    [Native]
    public enum MGLAnnotationVerticalAlignment : ulong
    {
        Center = 0,
        Top,
        Bottom
    }

    [Native]
    public enum MGLUserTrackingMode : ulong
    {
        None = 0,
        Follow,
        FollowWithHeading,
        FollowWithCourse
    }

    [Native]
    public enum MGLOfflinePackState : long
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
    public enum MGLResourceKind : ulong
    {
        Unknown,
        Style,
        Source,
        Tile,
        Glyphs,
        SpriteImage,
        SpriteJSON,
        Image
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

        public MGLMatrix4 projectionMatrix;
    }

    [Native]
    public enum MGLTileCoordinateSystem : ulong
    {
        Xyz = 0,
        Tms
    }

    [Native]
    public enum MGLDEMEncoding : ulong
    {
        Mapbox = 0,
        Terrarium
    }

    [Native]
    public enum MGLIconAnchor : ulong
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
    public enum MGLIconPitchAlignment : ulong
    {
        Map,
        Viewport,
        Auto
    }

    [Native]
    public enum MGLIconRotationAlignment : ulong
    {
        Map,
        Viewport,
        Auto
    }

    [Native]
    public enum MGLIconTextFit : ulong
    {
        None,
        Width,
        Height,
        Both
    }

    [Native]
    public enum MGLSymbolPlacement : ulong
    {
        Point,
        Line,
		LineCenter
    }

    [Native]
    public enum MGLTextAnchor : ulong
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
    public enum MGLTextJustification : ulong
    {
        Auto,
        Left,
        Center,
        Right
    }

    [Native]
    public enum MGLTextPitchAlignment : ulong
    {
        Map,
        Viewport,
        Auto
    }

    [Native]
    public enum MGLTextRotationAlignment : ulong
    {
        Map,
        Viewport,
        Auto
    }

    [Native]
    public enum MGLTextTransform : ulong
    {
        None,
        Uppercase,
        Lowercase
    }

    [Native]
    public enum MGLIconTranslationAnchor : ulong
    {
        Map,
        Viewport
    }

    [Native]
    public enum MGLTextTranslationAnchor : ulong
    {
        Map,
        Viewport
    }


	[Native]
	public enum MGLMapViewPreferredFramesPerSecond : long
    {
        Default,
        LowPower,
		Maximum
    }

	[Native]
	public enum MGLRasterResamplingMode : ulong
    {
		Linear,
		Nearest
    }
}
