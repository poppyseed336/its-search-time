using SearchTimeBackEnd.Models;

namespace SearchTimeBackEnd.Services
{
    public class SearchService: ISearchService
    {
        private readonly ILogger<SearchService> _logger;

        public SearchService(ILogger<SearchService> logger)
        {
            _logger = logger;
        }

        public List<SearchResultItem> GetSearchResults()
        {
            return GetDummyData();
        }

        // to-do: Return live data from DB.
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
                },
                new SearchResultItem
                {
                    Id = 9993,
                    Title = "Poster",
                    Color = "black"
                }
            };
        }
    }
}
