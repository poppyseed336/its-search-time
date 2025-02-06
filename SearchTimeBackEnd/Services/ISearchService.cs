using SearchTimeBackEnd.Models;

namespace SearchTimeBackEnd.Services
{
    public interface ISearchService
    {
        public List<SearchResultItem> GetSearchResults();
    }
}
