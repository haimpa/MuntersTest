namespace MuntersTest.Models
{
    public interface IGifService
    {
        Task<string> GetTrendyGiphyAsync();
        Task<string> SearchGiphy(string searchTerm);
    }
}
