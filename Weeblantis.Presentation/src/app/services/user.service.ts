import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { environment } from "../../environments/environment";
import { ILogin, IRegister } from '../models';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
    Authorization: 'my-auth-token',
  }),
};
@Injectable({
  providedIn: 'root',
})
export class UserService {
  private baseUrl = `${environment.apiUrl}/api/user`;
  constructor(private http: HttpClient) {}

  /** POST: register new user */
  register(register: IRegister): Observable<any> {
    return this.http.post<IRegister>(
      `${this.baseUrl}/register`,
      register,
      httpOptions
    );
  }
  /** POST: login with registered user */
  login(login: ILogin): Observable<any> {
    return this.http.post<ILogin>(`${this.baseUrl}/login`, login, httpOptions);
  }
}
