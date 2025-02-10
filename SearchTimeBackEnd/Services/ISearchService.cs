using SearchTimeBackEnd.Models.ViewModels;

namespace SearchTimeBackEnd.Services
{
    public interface ISearchService
    {
        public Task<SearchResultsViewModel> GetSearchResults(int pageNumber, string title, string color);
    }
}
