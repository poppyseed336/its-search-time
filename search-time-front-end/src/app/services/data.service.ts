
import { Injectable } from '@angular/core';
import { Observable, BehaviorSubject } from 'rxjs';
import { Item } from '../models/item.model';

@Injectable({
  providedIn: 'root'
})

export class DataService {
  private searchResults: BehaviorSubject<Item[]> = new BehaviorSubject<Item[]>([]);
  private pageNumber: number = 1;
  private title: string = "";
  private color: string = "";

  constructor() { }

  getSearchResults$(): Observable<Item[]> {
    return this.searchResults.asObservable();
  }

  setSearchResults(newValue: Item[]) {
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
