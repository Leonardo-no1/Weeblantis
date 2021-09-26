import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { environment } from '../../environments/environment';
import { IToken } from '../models';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private baseUrl = `${environment.apiUrl}/api/auth`;
  constructor(private http: HttpClient) {}

  public getToken(): any {
    return localStorage.getItem('token');
  }

  public setToken(): any {
    return this.http
      .post<IToken>(`${this.baseUrl}/authenticate`, {
        Website: `${environment.website}`,
      })
      .subscribe((result: IToken) => {
        localStorage.setItem('token', result.token);
      });
  }
}
