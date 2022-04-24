using System;
using System.Net.Http;
using System.Threading.Tasks;
using ModernHttpClient;
using Mapbox.Shared;
using Newtonsoft.Json;

namespace Mapbox.Shared
{
    public interface IMapboxService {
        Task<RemoteLayer[]> GetLayers(string owner, string styleId, string accessToken);
        Task<RemoteStyle> GetStyleDetails(string owner, string styleId, string accessToken);
    }
    public class MapboxService: IMapboxService
    {
        private HttpClient client;
        public MapboxService()
        {
            client = new HttpClient(new NativeMessageHandler());
        }

        public async Task<RemoteLayer[]> GetLayers(string owner, string styleId, string accessToken)
        {
            var style = await GetStyleDetails(owner, styleId, accessToken);
            return style?.Layers;
        }

        public async Task<RemoteStyle> GetStyleDetails(string owner, string styleId, string accessToken)
        {
			var url = $"https://api.mapbox.com/styles/v1/{owner}/{styleId}?access_token={accessToken}";
			var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var jsonStr = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine(jsonStr);
                return JsonConvert.DeserializeObject<RemoteStyle>(jsonStr);
            }
            return null;
        }
    }
}