using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MuntersTest.Models;

namespace MuntersTest.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class GiphyController : ControllerBase
    {
        private readonly ILogger<GiphyController> _logger;
        private static AppSettings _appSettings;
        private static string _giphyUrl;
        private IGifService _gifService;
        public GiphyController(IOptions<AppSettings> appSettings, IGifService gifService,ILogger<GiphyController> logger)
        {
            _logger = logger;
            _appSettings = appSettings.Value;
            _giphyUrl = _appSettings.ApiUrl;
            _gifService = gifService;
        }

        [Produces("application/json")]
        [HttpGet("gettrendys")]
        //Setting catching duration to 1 day (86400 seconds) for trendy gifs of the day
        [ResponseCache(VaryByHeader = "User-Agent", Duration = 86400)]
        public async Task<GiphyResponse> GetTrendyGifs()
        {
            return await _gifService.GetTrendyGiphyAsync();            
        }

        [Produces("application/json")]
        [HttpGet("searchgifs")]
        //Setting catching duration to 30 minutes (1800 seconds) to search for gifs by term
        [ResponseCache(VaryByHeader = "User-Agent", Duration = 1800)]
        public async Task<GiphyResponse> SearchGifs(string term)
        {
            return await _gifService.SearchGiphyAsync(term);            
        }
    }
}