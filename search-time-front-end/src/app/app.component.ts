import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NgFor } from '@angular/common';
import { DataService } from './services/data.service';
import { SearchService } from './services/search.service';
import { SearchResultsTable } from './components/search-results-table/search-results-table.component';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, SearchResultsTable, FormsModule, NgFor],
  templateUrl: './app.component.html'
})

export class AppComponent {
  title = 'search-time-front-end';
  colorOptions = ["black", "blue", "green", "purple", "red"];
  titleOfSearchItem = "";
  color = "";

  constructor(private dataService: DataService, private searchService: SearchService) { }

  async fetchSearchResults() {
    this.dataService.setTitle(this.titleOfSearchItem);
    this.dataService.setColor(this.color);
    await this.searchService.fetchSearchResults();
  }
}
