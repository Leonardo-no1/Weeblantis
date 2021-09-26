import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable, Subject } from 'rxjs';
import { environment } from '../../environments/environment';
import { ILogin, IRegister } from '../models';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
  }),
};
@Injectable({
  providedIn: 'root',
})
export class UserService {
  private baseUrl = `${environment.apiUrl}/api/user`;

  private _loginState: Subject<boolean> = new Subject<boolean>();
  loggedIn: boolean;
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

  logout() {
    this.loggedIn = false;
    this._loginState.next(this.loggedIn);
    localStorage.removeItem('loggedIn');
  }
  getLoggedInState() {
    return this._loginState.asObservable();
  }

  setLogin() {
    this.loggedIn = true;
    this._loginState.next(this.loggedIn);
    localStorage.setItem('loggedIn', 'true');
  }
}
