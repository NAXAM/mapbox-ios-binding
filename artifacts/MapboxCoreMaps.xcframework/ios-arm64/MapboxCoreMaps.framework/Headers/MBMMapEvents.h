// This file is generated and will be overwritten automatically.

#import <Foundation/Foundation.h>

/**
 * List of supported event types by the `map` and `map snapshotter` objects,
 * and event data format specification for each event.
 *
 * ``` text
 * Simplified diagram for events emitted by the map object.
 *
 * ┌─────────────┐               ┌─────────┐                   ┌──────────────┐
 * │ Application │               │   Map   │                   │ResourceLoader│
 * └──────┬──────┘               └────┬────┘                   └───────┬──────┘
 *        │                           │                                │
 *        ├───────setStyleURI────────▶│                                │
 *        │                           ├───────────get style───────────▶│
 *        │                           │                                │
 *        │                           │◀─────────style data────────────┤
 *        │                           │                                │
 *        │                           ├─parse style─┐                  │
 *        │                           │             │                  │
 *        │      StyleDataLoaded      ◀─────────────┘                  │
 *        │◀────{"type": "style"}─────┤                                │
 *        │                           ├─────────get sprite────────────▶│
 *        │                           │                                │
 *        │                           │◀────────sprite data────────────┤
 *        │                           │                                │
 *        │                           ├──────parse sprite───────┐      │
 *        │                           │                         │      │
 *        │      StyleDataLoaded      ◀─────────────────────────┘      │
 *        │◀───{"type": "sprite"}─────┤                                │
 *        │                           ├─────get source TileJSON(s)────▶│
 *        │                           │                                │
 *        │     SourceDataLoaded      │◀─────parse TileJSON data───────┤
 *        │◀──{"type": "metadata"}────┤                                │
 *        │                           │                                │
 *        │                           │                                │
 *        │      StyleDataLoaded      │                                │
 *        │◀───{"type": "sources"}────┤                                │
 *        │                           ├──────────get tiles────────────▶│
 *        │                           │                                │
 *        │◀───────StyleLoaded────────┤                                │
 *        │                           │                                │
 *        │     SourceDataLoaded      │◀─────────tile data─────────────┤
 *        │◀────{"type": "tile"}──────┤                                │
 *        │                           │                                │
 *        │                           │                                │
 *        │◀────RenderFrameStarted────┤                                │
 *        │                           ├─────render─────┐               │
 *        │                           │                │               │
 *        │                           ◀────────────────┘               │
 *        │◀───RenderFrameFinished────┤                                │
 *        │                           ├──render, all tiles loaded──┐   │
 *        │                           │                            │   │
 *        │                           ◀────────────────────────────┘   │
 *        │◀────────MapLoaded─────────┤                                │
 *        │                           │                                │
 *        │                           │                                │
 *        │◀─────────MapIdle──────────┤                                │
 *        │                    ┌ ─── ─┴─ ─── ┐                         │
 *        │                    │   offline   │                         │
 *        │                    └ ─── ─┬─ ─── ┘                         │
 *        │                           │                                │
 *        ├─────────setCamera────────▶│                                │
 *        │                           ├───────────get tiles───────────▶│
 *        │                           │                                │
 *        │                           │┌ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─   │
 *        │◀─────────MapIdle──────────┤   waiting for connectivity  │  │
 *        │                           ││  Map renders cached data      │
 *        │                           │ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ┘  │
 *        │                           │                                │
 * ```
 */
NS_SWIFT_NAME(MapEvents)
__attribute__((visibility ("default")))
@interface MBMMapEvents : NSObject

    /**
     * The style has been fully loaded, and the `map` has rendered all visible tiles.
     *
     * ``` text
     * Event data format (Object).
     * ```
     */
    @property (nonatomic, class, readonly) NSString * MapLoaded;
    /**
     * Describes an error that has occured while loading the Map. The `type` property defines what resource could
     * not be loaded and the `message` property will contain a descriptive error message.
     * In case of `source` or `tile` loading errors, `source-id` will contain the id of the source failing.
     * In case of `tile` loading errors, `tile-id` will contain the id of the tile
     *
     * ``` text
     * Event data format (Object):
     * .
     * ├── type - String ("style" | "sprite" | "source" | "tile" | "glyphs")
     * ├── message - String
     * ├── source-id - optional String
     * └── tile-id - optional Object
     *     ├── z Number (zoom level)
     *     ├── x Number (x coorinate)
     *     └── y Number (y coorinate)
     * ```
     */
    @property (nonatomic, class, readonly) NSString * MapLoadingError;
    /**
     * The `map` has entered the idle state. The `map` is in the idle state when there are no ongoing transitions
     * and the `map` has rendered all requested non-volatile tiles. The event will not be emitted if `setUserAnimationInProgress`
     * and / or `setGestureInProgress` is set to `true`.
     *
     * ``` text
     * Event data format (Object).
     * ```
     */
    @property (nonatomic, class, readonly) NSString * MapIdle;
    /**
     * The requested style data has been loaded. The `type` property defines what kind of style data has been loaded.
     * Event may be emitted synchronously, for example, when `setStyleJSON` is used to load style.
     *
     * Based on an event data `type` property value, following use-cases may be implemented:
     * - `style`: Style is parsed, style layer properties could be read and modified, style layers and sources could be
     *   added or removed before rendering is started.
     * - `sprite`: Style's sprite sheet is parsed and it is possible to add or update images.
     * - `sources`: All sources defined by the style are loaded and their properties could be read and updated if needed.
     *
     * ``` text
     * Event data format (Object):
     * .
     * └── type - String ("style" | "sprite" | "sources")
     * ```
     */
    @property (nonatomic, class, readonly) NSString * StyleDataLoaded;
    /**
     * The requested style has been fully loaded, including the style, specified sprite and sources' metadata.
     *
     * ``` text
     * Event data format (Object).
     * ```
     *
     * Note: The style specified sprite would be marked as loaded even with sprite loading error (An error will be emitted via `MapLoadingError`).
     * Sprite loading error is not fatal and we don't want it to block the map rendering, thus this event will still be emitted if style and sources are fully loaded.
     *
     */
    @property (nonatomic, class, readonly) NSString * StyleLoaded;
    /**
     * A style has a missing image. This event is emitted when the `map` renders visible tiles and
     * one of the required images is missing in the sprite sheet. Subscriber has to provide the missing image
     * by calling `addStyleImage` method.
     *
     * ``` text
     * Event data format (Object):
     * .
     * └── id - String
     * ```
     */
    @property (nonatomic, class, readonly) NSString * StyleImageMissing;
    /**
     * An image added to the style is no longer needed and can be removed using `removeStyleImage` method.
     *
     * ``` text
     * Event data format (Object):
     * .
     * └── id - String
     * ```
     */
    @property (nonatomic, class, readonly) NSString * StyleImageRemoveUnused;
    /**
     * A source data has been loaded.
     * Event may be emitted synchronously in cases when source's metadata is available when source is added to the style.
     *
     * The `id` property defines the source id.
     *
     * The `type` property defines if source's metadata (e.g., TileJSON) or tile has been loaded. The property of `metadata`
     * value might be useful to identify when particular source's metadata is loaded, thus all source's properties are
     * readable and can be updated before `map` will start requesting data to be rendered.
     *
     * The `loaded` property will be set to `true` if all source's data required for visible viewport of the `map`, are loaded.
     * The `tile-id` property defines the tile id if the `type` field equals `tile`.
     *
     * ``` text
     * Event data format (Object):
     * .
     * ├── id - String
     * ├── type - String ("metadata" | "tile")
     * ├── loaded - optional Boolean
     * └── tile-id - optional Object
     *     ├── z Number (zoom level)
     *     ├── x Number (x coorinate)
     *     └── y Number (y coorinate)
     * ```
     */
    @property (nonatomic, class, readonly) NSString * SourceDataLoaded;
    /**
     * The source has been added with `addStyleSource` method.
     * The event is emitted synchronously, therefore, it is possible to immediately
     * read added source's properties.
     *
     * ``` text
     * Event data format (Object):
     * .
     * └── id - String
     * ```
     */
    @property (nonatomic, class, readonly) NSString * SourceAdded;
    /**
     * The source has been removed with `removeStyleSource` method.
     * The event is emitted synchronously, thus, `getStyleSources` will be
     * in sync when the `observer` receives the notification.
     *
     * ``` text
     * Event data format (Object):
     * .
     * └── id - String
     * ```
     */
    @property (nonatomic, class, readonly) NSString * SourceRemoved;
    /**
     * The `map` started rendering a frame.
     *
     * Event data format (Object).
     */
    @property (nonatomic, class, readonly) NSString * RenderFrameStarted;
    /**
     * The `map` finished rendering a frame.
     * The `render-mode` property tells whether the `map` has all data (`full`) required to render the visible viewport.
     * The `needs-repaint` property provides information about ongoing transitions that trigger `map` repaint.
     * The `placement-changed` property tells if the symbol placement has been changed in the visible viewport.
     *
     * ``` text
     * Event data format (Object):
     * .
     * ├── render-mode - String ("partial" | "full")
     * ├── needs-repaint - Boolean
     * └── placement-changed - Boolean
     * ```
     */
    @property (nonatomic, class, readonly) NSString * RenderFrameFinished;
    /**
     * The camera has changed. This event is emitted whenever the visible viewport
     * changes due to the invocation of `setSize`, `setBounds` methods or when the camera
     * is modified by calling camera methods. The event is emitted synchronously,
     * so that an updated camera state can be fetched immediately.
     *
     * ``` text
     * Event data format (Object).
     * ```
     */
    @property (nonatomic, class, readonly) NSString * CameraChanged;
    /**
     * The `ResourceRequest` event allows client to observe resource requests made by a
     * `map` or `map snapshotter` objects.
     *
     * ``` text
     * Event data format (Object):
     * .
     * ├── data-source - String ("resource-loader" | "network" | "database" | "asset" | "file-system")
     * ├── request - Object
     * │   ├── url - String
     * │   ├── kind - String ("unknown" | "style" | "source" | "tile" | "glyphs" | "sprite-image" | "sprite-json" | "image")
     * │   ├── priority - String ("regular" | "low")
     * │   └── loading-method - Array ["cache" | "network"]
     * ├── response - optional Object
     * │   ├── no-content - Boolean
     * │   ├── not-modified - Boolean
     * │   ├── must-revalidate - Boolean
     * │   ├── source - String ("network" | "cache" | "tile-store" | "local-file")
     * │   ├── size - Number (size in bytes)
     * │   ├── modified - optional String, rfc1123 timestamp
     * │   ├── expires - optional String, rfc1123 timestamp
     * │   ├── etag - optional String
     * │   └── error - optional Object
     * │       ├── reason - String ("success" | "not-found" | "server" | "connection" | "rate-limit" | "in-offline-mode" | "other")
     * │       └── message - String
     * └── cancelled - Boolean
     * ```
     */
    @property (nonatomic, class, readonly) NSString * ResourceRequest;

@end
