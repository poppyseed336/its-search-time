import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { SearchService } from './services/search.service';
import { SearchResultsTable } from './components/search-results-table/search-results-table.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, SearchResultsTable],
  templateUrl: './app.component.html'
})

export class AppComponent {
  title = 'search-time-front-end';

  constructor(private searchService: SearchService) { }

  fetchSearchResults() {
    this.searchService.fetchSearchResults();  // to-do: will eventually need to be awaited once this service function becomes an async method
  }
}
