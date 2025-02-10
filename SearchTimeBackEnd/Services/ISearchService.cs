using SearchTimeBackEnd.Models.Entities;
using SearchTimeBackEnd.Models.ViewModels;

namespace SearchTimeBackEnd.Services
{
    public interface ISearchService
    {
        public Task<SearchResultsViewModel> GetSearchResults();
    }
}
