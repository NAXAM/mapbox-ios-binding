using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Mapbox.Shared
{
    public class RemoteLayer
    {
        public RemoteLayer()
        {
        }

        public string Id
        {
            get;
            set;
        }

        public string SourceLayer
        {
            get;
            set;
        }

        public LayerLayout Layout
        {
            get;
            set;
        }

        public LayerMetadata Metadata {
            get;
            set;
        }
    }

    public class LayerLayout
    {
		[JsonProperty(PropertyName = "icon-image")]
        public object IconImage
        {
            get;
            set;
        }
    }

    public class IconImageWithStops {
        public int Base
        {
            get;
            set;
        }
        public object[][] Stops { get; set; }
    }

    public class RemoteStyle
    {
        public string Id
        {
            get;
            set;
        }

        public string Owner
        {
            get;
            set;
        }

        public StyleMetadata Metadata
        {
            get;
            set;
        }

        public RemoteLayer[] Layers
        {
            get;
            set;
        }
    }

    public class StyleMetadata {
		[JsonProperty(PropertyName = "mapbox:groups")]
		public Dictionary<string, MapboxGroup> Groups
		{
			get;
			set;
		}
    }

    public class LayerMetadata {
        [JsonProperty(PropertyName = "mapbox:group")]
        public string GroupId
        {
            get;
            set;
        }
    }

    public class MapboxGroup
    {
        public string Name
        {
            get;
            set;
        }

        public bool Collapsed
        {
            get;
            set;
        }
    }
}
