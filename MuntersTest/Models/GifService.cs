using Microsoft.Extensions.Options;

namespace MuntersTest.Models
{
    public class GifService : IGifService
    {
        private readonly ILogger<GifService> _logger;
        private static AppSettings _appSettings;
         
        public GifService(IOptions<AppSettings> appSettings, ILogger<GifService> logger)
        {
            _logger = logger;
            _appSettings = appSettings.Value;
        }

        public async Task<GiphyResponse> GetTrendyGiphyAsync()
        {
            using var client = new HttpClient();
            string trendyurl = $"{_appSettings.ApiUrl}/trending?api_key={_appSettings.ApiKey}&limit=25&offset=0&rating=g&bundle=messaging_non_clips";
            return (GiphyResponse)await client.GetFromJsonAsync(requestUri: trendyurl, typeof(GiphyResponse));
        }

        public async Task<GiphyResponse> SearchGiphyAsync(string searchTerm)
        {
            using var client = new HttpClient();
            string searchyurl = $"{_appSettings.ApiUrl}/search?api_key={_appSettings.ApiKey}&q={searchTerm}&limit=25&offset=0&rating=g&lang=en&bundle=messaging_non_clips";
            //return await client.GetStringAsync(searchyurl);
            return (GiphyResponse)await client.GetFromJsonAsync(requestUri: searchyurl, typeof(GiphyResponse));
        }
    }
}
