
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import axios from 'axios';
import { DataService } from './data.service';
import { Item } from '../models/item.model';

@Injectable({
  providedIn: 'root'
})

export class SearchService {
  private searchResults: BehaviorSubject<Item[]> = new BehaviorSubject<Item[]>([]);

  private baseUrl = 'https://localhost:32771';
  private searchUrl = `${ this.baseUrl }/Search`;

  constructor(private dataService: DataService) { }

  fetchSearchResults() {

    axios.get(this.searchUrl)
      .then((response) => {
        this.dataService.setSearchResults(response.data);
      })
      .catch((error) => {
        console.error('Error executing search: ', error);
        throw error;
      });
  }
}
