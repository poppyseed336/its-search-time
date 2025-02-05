using Microsoft.AspNetCore.Mvc;
using SearchTimeBackEnd.Models;

namespace SearchTimeBackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly ILogger<SearchController> _logger;

        public SearchController(ILogger<SearchController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Search")]
        public ActionResult<IEnumerable<SearchResultItem>> Get()
        {
            return Ok(GetDummyData());
        }

        // to-do: Use a service-layer class to return live data from a DB.
        private List<SearchResultItem> GetDummyData()
        {
            return new List<SearchResultItem>
            {
                new SearchResultItem
                {
                    Id = 1167,
                    Title = "Guitar",
                    Color = "blue"
                },
                new SearchResultItem
                {
                    Id = 9992,
                    Title = "Video Game",
                    Color = "green"
                },
                new SearchResultItem
                {
                    Id = 2424,
                    Title = "Dinosaur",
                    Color = "red"
                },
                new SearchResultItem
                {
                    Id = 6552,
                    Title = "Dress",
                    Color = "purple"
                },
                new SearchResultItem
                {
                    Id = 7777,
                    Title = "Planet",
                    Color = "red"
                },
                new SearchResultItem
                {
                    Id = 1010,
                    Title = "President",
                    Color = "orange"
                },
                new SearchResultItem
                {
                    Id = 1011,
                    Title = "Chapstick",
                    Color = "red"
                },
                new SearchResultItem
                {
                    Id = 3360,
                    Title = "Food",
                    Color = "red"
                },
                new SearchResultItem
                {
                    Id = 1919,
                    Title = "Beverage",
                    Color = "green"
                },
                new SearchResultItem
                {
                    Id = 2123,
                    Title = "Lifeguard",
                    Color = "red"
                },
                new SearchResultItem
                {
                    Id = 6666,
                    Title = "Tunnel",
                    Color = "purple"
                }
            };
        }
    }
}
