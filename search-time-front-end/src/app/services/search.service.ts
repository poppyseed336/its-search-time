
import { Injectable } from '@angular/core';
import { Observable, BehaviorSubject } from 'rxjs';
import { DataService } from './data.service';
import { Item } from '../models/item.model';

@Injectable({
  providedIn: 'root'
})

export class SearchService {
  private searchResults: BehaviorSubject<Item[]> = new BehaviorSubject<Item[]>([]);

  constructor(private dataService: DataService) { }

  fetchSearchResults() {
    // to-do: For now this mocks a remote API call. Later we'll add an actual http call and make this function async.
    let results = [
      { id: 1167, title: 'Guitar', color: 'blue' } as Item,
      { id: 9992, title: 'Video Game', color: 'green' } as Item,
      { id: 2424, title: 'Dinosaur', color: 'red' } as Item,
      { id: 6552, title: 'Dress', color: 'purple' } as Item,
      { id: 7777, title: 'Planet', color: 'red' } as Item,
      { id: 1010, title: 'President', color: 'orange' } as Item,
      { id: 1011, title: 'Chapstick', color: 'red' } as Item,
      { id: 3360, title: 'Food', color: 'red' } as Item,
      { id: 1919, title: 'Beverage', color: 'green' } as Item,
      { id: 2123, title: 'lifeguard', color: 'red' } as Item,
      { id: 6666, title: 'tunnel', color: 'purple' } as Item
    ];

    this.dataService.setSearchResults(results);
  }
}
