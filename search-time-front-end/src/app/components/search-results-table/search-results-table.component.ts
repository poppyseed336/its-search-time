
import { Component } from '@angular/core';
import { NgFor, NgIf, CommonModule } from '@angular/common';
import { BehaviorSubject } from 'rxjs';
import { DataService } from '../../services/data.service';
import { SearchService } from '../../services/search.service';
import { Item } from '../../models/item.model';

@Component({
  selector: 'search-results-table',
  imports: [NgFor, NgIf, CommonModule],
  templateUrl: './search-results-table.component.html',
  styles: [`
    button[disabled] {
      text-decoration: none;
    }
    .ellpsis {
      display: inline-block;
      transform: translate(30px, 5px);
    }
  `]
})
export class SearchResultsTable {
  title = 'search-results-table';

  searchResultItems: Item[] = [];
  private paginationArray:  BehaviorSubject<number[]> = new BehaviorSubject<number[]>([]);

  constructor(private dataService: DataService, private searchService: SearchService) { }

  ngOnInit(): void {
    this.dataService.getSearchResults$().subscribe(updatedData => {
      this.searchResultItems = updatedData.searchResults;

      if (this.dataService.getSearchResults().numberOfResults > 0) {
        this.updatePaginationArray();
      }
    });
  }

  public getPaginationArray() {
    return this.paginationArray.value;
  }

  public getPaginationArray$() {
    return this.paginationArray.asObservable();
  }

  public resetPaginationArray() {
    this.paginationArray.next([]);
  }

  public pushToPaginationArray(newValue: number) {
    this.paginationArray.next([...this.paginationArray.value, newValue]);
  }

  public getPageNumber$() {
    return this.dataService.getPageNumber$();
  }

  async fetchSearchResults(pageNumber: number) {
    this.dataService.setPageNumber(pageNumber);
 
    await this.searchService.fetchSearchResults();
  }

  private updatePaginationArray() {
    this.resetPaginationArray();

    let numberOfPages = Math.floor(this.dataService.getSearchResults().numberOfResults / 10);
    if (this.dataService.getSearchResults().numberOfResults % 10 !== 0) {
      numberOfPages++;
    }

    if (numberOfPages > 1) {
      this.pushToPaginationArray(1);

      if (numberOfPages >= 5
        && this.dataService.getPageNumber() === numberOfPages
        && !this.getPaginationArray().includes(this.dataService.getPageNumber() - 3)
      ) {
        this.pushToPaginationArray(this.dataService.getPageNumber() - 3);
      }

      if ((!(this.getPaginationArray().length > 0) || this.dataService.getPageNumber() + 1 >= numberOfPages)
        && this.dataService.getPageNumber() - 2 > 0
        && !this.getPaginationArray().includes(this.dataService.getPageNumber() - 2))
      {  
        this.pushToPaginationArray(this.dataService.getPageNumber() - 2);
      }

      if (this.dataService.getPageNumber() - 1 > 0
        && !this.getPaginationArray().includes(this.dataService.getPageNumber() - 1))
      {
        this.pushToPaginationArray(this.dataService.getPageNumber() - 1);
      }

      let pageIndex = this.dataService.getPageNumber();
      while (this.getPaginationArray().length < 5 && pageIndex <= numberOfPages) {
        if (pageIndex <= numberOfPages) {
          if (this.getPaginationArray().length + 1 === 5
            && !this.getPaginationArray().includes(numberOfPages))
          {
            this.pushToPaginationArray(numberOfPages);
          }
          else if (!this.getPaginationArray().includes(pageIndex)) {
            this.pushToPaginationArray(pageIndex);
          }
        }

        pageIndex++;
      }
    }
  }
}
