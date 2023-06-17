namespace MuntersTest.Models
{
    public interface IGifService
    {
        Task<GiphyResponse> GetTrendyGiphyAsync();
        Task<GiphyResponse> SearchGiphyAsync(string searchTerm);
    }
}
