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
        public String Get()
        {
            return "Hello world!";
        }
    }
}
