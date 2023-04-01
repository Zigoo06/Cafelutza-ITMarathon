import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { Raport } from '../models/raport';
@Injectable()
export class RaportService {
  baseUrl = environment.apiUrl;
  constructor(private http: HttpClient) {
    this.getRaports();
  }

  getRaports(): Observable<Raport[]> {
    return this.http.get<Raport[]>(this.baseUrl + '/Raport/getall');
  }
}
