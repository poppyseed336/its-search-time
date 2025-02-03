
import { Component } from '@angular/core';
import { SearchResultItem } from '../search-result-item/search-result-item.component';

@Component({
  selector: 'search-results-table',
  imports: [SearchResultItem],
  templateUrl: './search-results-table.component.html'
})
export class SearchResultsTable {
  title = 'search-results-table';
}
