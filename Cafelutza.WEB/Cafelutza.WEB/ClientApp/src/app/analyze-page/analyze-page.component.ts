import { AfterViewInit, Component, OnInit } from '@angular/core';
import { Raport } from '../models/raport';
import { RaportService } from '../services/raport.service';
import { map } from 'rxjs/operators';

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
    //this.getData(){
    this.raportService
      .getRaports()
      .pipe(
        map((response: { [key: number]: Raport }) => {
          const raportul = [];
          for (const key in response) {
            if (response.hasOwnProperty(key)) {
              raportul.push({ ...response[key], id: key });
            }
            raportul.push({ ...response[key], id: key });
          }
          return raportul;
        })
      )
      .subscribe((response) => {
        this.listItems = response;
        console.log(this.listItems);
      });
  }
}
