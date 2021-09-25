import { Component, OnChanges, SimpleChanges } from '@angular/core';
import { AuthService } from './services/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  title = 'Weeblantis';
  loggedIn: boolean = false;
  constructor(private authService: AuthService) {
    this.authService.setToken();
  }
  logout() {}
}
