import { Component } from '@angular/core';

@Component({
  selector: 'app-analyze-page',
  templateUrl: './analyze-page.component.html',
  styleUrls: ['./analyze-page.component.scss'],
})
export class AnalyzePageComponent {
  selectedItem = '';

  listItems = [
    { id: 1, linkTitle: 'Home 1', Description: '/asdasd-a' },
    { id: 2, linkTitle: 'Home 2', Description: '/asdasd-a' },
    { id: 3, linkTitle: 'Home 3', Description: '/asdasd-a' },
    { id: 4, linkTitle: 'Home 4', Description: 'asdasd' },
    { id: 5, linkTitle: 'Home 5', Description: '/asdasd-a' },
  ];

  handleClick(selectedItem: { linkTitle: string }) {
    console.log(selectedItem);
  }
}
