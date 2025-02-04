
import { Component } from '@angular/core';
import { SearchResultItem } from '../search-result-item/search-result-item.component';
import { DataService } from '../services/data.service';
import { SearchService } from '../services/search.service';
import { Item } from '../models/item.model';
import { NgFor } from '@angular/common';

@Component({
  selector: 'search-results-table',
  imports: [SearchResultItem, NgFor],
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
