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
            //SearchResultsViewModel results = await _searchService.GetSearchResults(pageNumber, title, color);

            // to-do: remove this dummy data method and use live DB results
            SearchResultsViewModel results = GetDummyData(pageNumber, title, color);

            return Ok(results);
        }

        // to-do: remove this dummy data method and use live DB results
        private SearchResultsViewModel GetDummyData(int pageNumber, string title, string color)
        {
            return new SearchResultsViewModel()
            {
                NumberOfResults = 18,
                SearchResults = new List<Models.Entities.SearchResultItem>()
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
                    new Models.Entities.SearchResultItem() { Id = 64, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 69, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 303, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 320, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 336, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 404, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 451, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 490, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 491, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 492, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 500, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 502, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 554, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 594, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 600, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 601, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 605, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 621, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 808, Title = title, Color = color },
                    new Models.Entities.SearchResultItem() { Id = 901, Title = title, Color = color }
                }
            };
        }
    }
}
