using Microsoft.AspNetCore.Mvc;
using SearchTimeBackEnd.Models;
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
        public async Task<ActionResult<IEnumerable<SearchResultItem>>> Get()
        {
            List<SearchResultItem> results = await _searchService.GetSearchResults();

            return Ok(results);
        }
    }
}
