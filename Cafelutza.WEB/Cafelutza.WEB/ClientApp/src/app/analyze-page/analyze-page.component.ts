import { AfterViewInit, Component, OnInit } from '@angular/core';
import { Raport } from '../models/raport';
import { RaportService } from '../services/raport.service';

// @Component({
//   selector: 'app-analyze-page',
//   templateUrl: './analyze-page.component.html',
//   styleUrls: ['./analyze-page.component.scss'],
// })
// export class AnalyzePageComponent implements OnInit {
//   selectedItem = '';

//   listItems: Raport[] = [];
//   constructor(private raportService: RaportService) {}

//   ngOnInit(): void {
//     this.getData();
//   }
//   getData() {
//     this.raportService.getRaports().subscribe((response) => {
//       this.listItems = response;
//     });
//     console.log(this.listItems);
//   }
// }
@Component({
  selector: 'app-analyze-page',
  templateUrl: './analyze-page.component.html',
  styleUrls: ['./analyze-page.component.scss'],
})
export class AnalyzePageComponent implements OnInit {
  selectedItem = '';

  listItems: Raport[] = [];
  constructor(private raportService: RaportService) {}

  ngOnInit(): void {
    this.getData();
  }
  getData() {
    this.raportService.getRaports().subscribe((response) => {
      this.listItems = response;
      console.log(this.listItems);
    });
  }
}
