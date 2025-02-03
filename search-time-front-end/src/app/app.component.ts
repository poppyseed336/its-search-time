import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { SearchResultsTable } from './search-results-table/search-results-table.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, SearchResultsTable],
  templateUrl: './app.component.html'
})

export class AppComponent {
  title = 'search-time-front-end';
}
