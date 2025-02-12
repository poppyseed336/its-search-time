
import { Injectable } from '@angular/core';
import { Observable, BehaviorSubject } from 'rxjs';
import { SearchResults } from '../models/searchResults.model';

@Injectable({
  providedIn: 'root'
})

export class DataService {
  private searchResults: BehaviorSubject<SearchResults> = new BehaviorSubject<SearchResults>({
    searchResults: [],
    numberOfResults: 0
  });
  private pageNumber:  BehaviorSubject<number> = new BehaviorSubject<number>(1);
  private title: string = "";
  private color: string = "";

  constructor() { }

  getSearchResults(): SearchResults {
    return this.searchResults.value;
  }

  getSearchResults$(): Observable<SearchResults> {
    return this.searchResults.asObservable();
  }

  setSearchResults(newValue: SearchResults) {
    this.searchResults.next(newValue);
  }

  getPageNumber(): number {
    return this.pageNumber.value;
  }

  getPageNumber$(): Observable<number> {
    return this.pageNumber.asObservable();
  }

  setPageNumber(newValue: number) {
    this.pageNumber.next(newValue);
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
