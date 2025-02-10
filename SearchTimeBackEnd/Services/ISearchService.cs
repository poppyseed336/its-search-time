using SearchTimeBackEnd.Models;

namespace SearchTimeBackEnd.Services
{
    public interface ISearchService
    {
        public Task<List<SearchResultItem>> GetSearchResults();
    }
}
