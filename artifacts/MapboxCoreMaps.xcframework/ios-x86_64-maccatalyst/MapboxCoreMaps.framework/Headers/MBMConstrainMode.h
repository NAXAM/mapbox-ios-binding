// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/** Describes whether to constrain the map in both axes or only vertically e.g. while panning. */
// NOLINTNEXTLINE(modernize-use-using)
typedef NS_ENUM(NSInteger, MBMConstrainMode)
{
    /** No constrains. */
    MBMConstrainModeNone,
    /** Constrain to height only */
    MBMConstrainModeHeightOnly,
    /** Constrain both width and height axes. */
    MBMConstrainModeWidthAndHeight
} NS_SWIFT_NAME(ConstrainMode);
