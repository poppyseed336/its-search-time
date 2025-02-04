
import { Component } from '@angular/core';
import { SearchResultItem } from '../search-result-item/search-result-item.component';
import { SearchService } from '../services/search.service';
import { Item } from '../models/item.model';
import { NgFor } from '@angular/common';

@Component({
  selector: 'search-results-table',
  imports: [SearchResultItem, NgFor],
  templateUrl: './search-results-table.component.html'
})
export class SearchResultsTable {
  searchResultItems: Item[] = [{ id: 0, title: '', color: '' }];

  constructor(private searchService: SearchService) { }

  ngOnInit(): void {
    this.searchResultItems = this.searchService.getSearchResults();
  }

  title = 'search-results-table';
}
