using Microsoft.AspNetCore.Mvc;
using SearchTimeBackEnd.Models.ViewModels;
using SearchTimeBackEnd.Services;
using System.Drawing;

namespace SearchTimeBackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly ILogger<SearchController> _logger;
        private ISearchService _searchService;

        public SearchController(ILogger<SearchController> logger, ISearchService searchService)
        {
            _logger = logger;
            _searchService = searchService;
        }

        [HttpGet(Name = "Search")]
        public async Task<ActionResult<SearchResultsViewModel>> Get(int pageNumber = 1, string title = "", string color = "")
        {
            // to-do: Implement this for the actual, live DB results
            SearchResultsViewModel results = await _searchService.GetSearchResults(pageNumber, title, color);

            // to-do: remove this dummy data method and use live DB results
            //SearchResultsViewModel results = GetDummyData(title, color);

            return Ok(results);
        }

        // to-do: remove this dummy data method and use live DB results
        private SearchResultsViewModel GetDummyData(string title, string color)
        {
            var dummySearchResults = new List<Models.Entities.SearchResultItem>()
                {
                    new Models.Entities.SearchResultItem() { Id = 1, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 3, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 45, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 50, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 51, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 52, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 54, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 59, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 60, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 64, Title = title, Color = color }
                };

            return new SearchResultsViewModel()
            {
                NumberOfResults = 177,
                SearchResults = dummySearchResults
            };
        }
    }
}
