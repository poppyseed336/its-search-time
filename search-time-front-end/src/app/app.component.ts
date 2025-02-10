import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { NgFor } from '@angular/common';
import { SearchService } from './services/search.service';
import { DataService } from './services/data.service';
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

  constructor(private searchService: SearchService, private dataService: DataService) { }

  async fetchSearchResults() {
    this.dataService.setTitle(this.titleOfSearchItem);
    this.dataService.setColor(this.color);
    await this.searchService.fetchSearchResults();
  }
}
