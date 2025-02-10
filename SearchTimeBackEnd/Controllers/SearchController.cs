using Microsoft.AspNetCore.Mvc;
using SearchTimeBackEnd.Models.Entities;
using SearchTimeBackEnd.Models.ViewModels;
using SearchTimeBackEnd.Services;

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
        public async Task<ActionResult<SearchResultsViewModel>> Get()
        {
            SearchResultsViewModel results = await _searchService.GetSearchResults();
            return Ok(results);
        }
    }
}
