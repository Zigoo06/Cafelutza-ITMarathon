import { HttpClient } from '@angular/common/http';
import { Raport } from '../models/raport';
import { environment } from 'src/environments/environment';
import { Injectable } from '@angular/core';

@Injectable()
export class RaportService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  sendRaport(raport: Raport) {
    this.http.post(this.baseUrl + '/Raport', raport).subscribe();
  }
}
