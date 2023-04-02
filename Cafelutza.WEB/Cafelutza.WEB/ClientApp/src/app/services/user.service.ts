import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable()
export class UserService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  userIsOperator(): Observable<boolean> {
    return this.http.get<boolean>(this.baseUrl + '/user/isOperator').pipe();
  }
}
