using Microsoft.EntityFrameworkCore;
using SearchTimeBackEnd.Models;
using SearchTimeBackEnd.Models.ViewModels;

namespace SearchTimeBackEnd.Services
{
    public class SearchService: ISearchService
    {
        private readonly ILogger<SearchService> _logger;
        private readonly AppDbContext _appDbContext;

        private const int PAGE_SIZE = 10;

        public SearchService(ILogger<SearchService> logger, AppDbContext context)
        {
            _logger = logger;
            _appDbContext = context;
        }

        public async Task<SearchResultsViewModel> GetSearchResults(int pageNumber, string title, string color)
        {
            try
            {
                var searchResults = _appDbContext.SearchResultItems
                    .AsQueryable()
                    .Where(searchResultItem =>
                        searchResultItem.Title.ToLower().Contains(title.ToLower()) &&
                        (color.Equals("") || searchResultItem.Color.ToLower().Equals(color)))
                    .OrderBy(searchResultItem => searchResultItem.Id);

                var numberOfResults = searchResults.Count();

                var paginatedSearchResults = await searchResults
                    .Skip((pageNumber - 1) * PAGE_SIZE)
                    .Take(PAGE_SIZE)
                    .ToListAsync();

                var result = new SearchResultsViewModel()
                {
                    SearchResults = paginatedSearchResults,
                    NumberOfResults = numberOfResults
                };

                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error retrieving search results:");
                Console.WriteLine(exception.Message);
                if (exception.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {exception.InnerException.Message}");
                }
                throw;
            }
        }
    }
}
