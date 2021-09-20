import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { environment } from "../../environments/environment";
import { Login, Register } from '../models';


const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':  'application/json',
    Authorization: 'my-auth-token'
  })
};
@Injectable({
  providedIn: 'root'
})
export class UserService {

  private baseUrl = `${environment.apiUrl}/api/user`
  constructor(private http: HttpClient) {}


  /** POST: add a new hero to the database */
  register(register: Register): Observable<any> {
    return this.http.post<Register>(`${this.baseUrl}/register`, register, httpOptions);
  }
  /** POST: add a new hero to the database */
  login(login: Login): Observable<any> {
    return this.http.post<Login>(`${this.baseUrl}/login`, login, httpOptions);
  }
}
