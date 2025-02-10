using Microsoft.EntityFrameworkCore;
using SearchTimeBackEnd.Models;
using SearchTimeBackEnd.Models.Entities;
using SearchTimeBackEnd.Models.ViewModels;

namespace SearchTimeBackEnd.Services
{
    public class SearchService: ISearchService
    {
        private readonly ILogger<SearchService> _logger;
        private readonly AppDbContext _appDbContext;

        public SearchService(ILogger<SearchService> logger, AppDbContext context)
        {
            _logger = logger;
            _appDbContext = context;
        }

        public async Task<SearchResultsViewModel> GetSearchResults()
        {
            try
            {
                var searchResults = await _appDbContext.SearchResultItems.ToListAsync();
                var result = new SearchResultsViewModel()
                {
                    SearchResults = searchResults
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
