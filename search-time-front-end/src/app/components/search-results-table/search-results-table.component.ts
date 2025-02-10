
import { Component } from '@angular/core';
import { NgFor, NgIf } from '@angular/common';
import { DataService } from '../../services/data.service';
import { Item } from '../../models/item.model';

@Component({
  selector: 'search-results-table',
  imports: [NgFor, NgIf],
  templateUrl: './search-results-table.component.html'
})
export class SearchResultsTable {
  title = 'search-results-table';
  
  searchResultItems: Item[] = [];

  constructor(private dataService: DataService) { }

  ngOnInit(): void {
    this.dataService.getSearchResults$().subscribe(updatedData => {
      this.searchResultItems = updatedData.SearchResults;
    });
  }
}
