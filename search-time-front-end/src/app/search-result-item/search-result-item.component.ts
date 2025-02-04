
import { Component, Input } from '@angular/core';
import { Item } from '../models/item.model';

@Component({
  selector: 'search-result-item',
  templateUrl: './search-result-item.component.html'
})

export class SearchResultItem {
  @Input() resultItem: Item = { id: 0, title: '', color: '' };
}
