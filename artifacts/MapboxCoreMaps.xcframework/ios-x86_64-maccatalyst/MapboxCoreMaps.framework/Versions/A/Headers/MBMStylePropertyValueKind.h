// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Describes the kind of a style property value. */
// NOLINTNEXTLINE(modernize-use-using)
typedef NS_ENUM(NSInteger, MBMStylePropertyValueKind)
{
    /** The property value is not defined. */
    MBMStylePropertyValueKindUndefined,
    /** The property value is a constant. */
    MBMStylePropertyValueKindConstant,
    /** The property value is a style [expression](https://docs.mapbox.com/mapbox-gl-js/style-spec/#expressions). */
    MBMStylePropertyValueKindExpression,
    /** Property value is a style [transition](https://docs.mapbox.com/mapbox-gl-js/style-spec/#transition). */
    MBMStylePropertyValueKindTransition
} NS_SWIFT_NAME(StylePropertyValueKind);
