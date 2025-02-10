using SearchTimeBackEnd.Models.Entities;

namespace SearchTimeBackEnd.Models.ViewModels
{
    public class SearchResultsViewModel
    {
        public List<SearchResultItem>? SearchResults { get; set; }

        public int NumberOfResults { get; set; }
    }
}
