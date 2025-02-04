
import { Injectable } from '@angular/core';
import { Observable, BehaviorSubject } from 'rxjs';
import { Item } from '../models/item.model';

@Injectable({
  providedIn: 'root'
})

export class DataService {
  private searchResults: BehaviorSubject<Item[]> = new BehaviorSubject<Item[]>([]);

  constructor() { }

  getSearchResults(): Observable<Item[]> {
    return this.searchResults.asObservable();
  }

  setSearchResults(newData: Item[]) {
    this.searchResults.next(newData);
  }
}
