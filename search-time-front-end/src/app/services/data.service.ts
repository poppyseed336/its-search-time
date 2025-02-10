
import { Injectable } from '@angular/core';
import { Observable, BehaviorSubject } from 'rxjs';
import { Item } from '../models/item.model';
import { SearchResults } from '../models/searchResults.model';

@Injectable({
  providedIn: 'root'
})

export class DataService {
  private searchResults: BehaviorSubject<SearchResults> = new BehaviorSubject<SearchResults>({
    SearchResults: [],
    NumberOfResults: 0
  });
  private pageNumber: number = 1;
  private title: string = "";
  private color: string = "";

  constructor() { }

  getSearchResults$(): Observable<SearchResults> {
    return this.searchResults.asObservable();
  }

  setSearchResults(newValue: SearchResults) {
    this.searchResults.next(newValue);
  }

  getPageNumber(): number {
    return this.pageNumber;
  }

  setPageNumber(newValue: number) {
    this.pageNumber = newValue;
  }

  getTitle(): string {
    return this.title;
  }

  setTitle(newValue: string) {
    this.title = newValue;
  }

  getColor(): string {
    return this.color;
  }

  setColor(newValue: string) {
    this.color = newValue;
  }
}
