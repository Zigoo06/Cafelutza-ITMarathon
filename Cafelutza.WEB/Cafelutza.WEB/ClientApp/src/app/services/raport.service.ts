import { HttpClient } from '@angular/common/http';
import { Raport } from '../models/raport';
import { environment } from 'src/environments/environment';
import { Injectable } from '@angular/core';
import { Observable, map } from 'rxjs';

@Injectable()
export class RaportService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  sendRaport(raport: Raport) {
    this.http.post(this.baseUrl + '/Raport', raport).subscribe();
  }

  getRaports(): Observable<Raport[]> {
    return this.http.get<Raport[]>(this.baseUrl + '/Raport/getall').pipe(
      map((res) => {
        const raports: Raport[] = [];
        res.forEach((x) => raports.push(x));
        return raports;
      })
    );
  }

  removeRaport(id: number) {
    this.http.delete(this.baseUrl + '/raport/' + id).subscribe();
  }
}
