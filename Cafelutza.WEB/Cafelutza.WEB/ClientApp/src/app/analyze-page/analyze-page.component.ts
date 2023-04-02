import { Component, OnInit } from '@angular/core';
import { Raport } from '../models/raport';
import { RaportService } from '../services/raport.service';
@Component({
  selector: 'app-analyze-page',
  templateUrl: './analyze-page.component.html',
  styleUrls: ['./analyze-page.component.scss'],
})
export class AnalyzePageComponent implements OnInit {
  raports: Raport[] = [];

  constructor(private raportService: RaportService) {}

  ngOnInit(): void {
    this.getData();
  }
  getData() {
    this.raportService.getRaports().subscribe((response) => {
      this.raports = response;
      console.log(this.raports);
    });
  }
}
