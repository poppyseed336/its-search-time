
import { Component } from '@angular/core';
import { NgFor, NgIf } from '@angular/common';
import { DataService } from '../../services/data.service';
import { SearchService } from '../../services/search.service';
import { Item } from '../../models/item.model';

@Component({
  selector: 'search-results-table',
  imports: [NgFor, NgIf],
  templateUrl: './search-results-table.component.html'
})
export class SearchResultsTable {
  searchResultItems: Item[] = [];

  constructor(private dataService: DataService, private searchService: SearchService) { }

  ngOnInit(): void {
    this.searchService.fetchSearchResults();  // to-do: will eventually need to be awaited once this service function becomes an async http call

    this.dataService.getSearchResults$().subscribe(updatedData => {
      this.searchResultItems = updatedData;
    });
  }

  title = 'search-results-table';
}
