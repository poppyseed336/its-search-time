
import { Injectable } from '@angular/core';
import axios from 'axios';
import { DataService } from './data.service';

@Injectable({
  providedIn: 'root'
})

export class SearchService {
  private baseUrl = 'https://localhost:32773';
  private searchUrl = `${ this.baseUrl }/Search`;

  constructor(private dataService: DataService) { }

  fetchSearchResults() {

    axios.get(this.searchUrl, {
      params: {
        pageNumber: this.dataService.getPageNumber(),
        title: this.dataService.getTitle(),
        color: this.dataService.getColor()
      }
    })
    .then((response) => {
        this.dataService.setSearchResults(response.data);
    })
    .catch((error) => {
        console.error('Error executing search: ', error);
        throw error;
    });
  }
}
