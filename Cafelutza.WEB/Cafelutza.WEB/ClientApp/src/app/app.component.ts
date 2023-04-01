import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  title = 'Cafelutza.SPA';

  constructor(private http: HttpClient) {}
  ngOnInit(): void {
    this.http.get(environment.apiUrl + '/user').subscribe();
  }
}
