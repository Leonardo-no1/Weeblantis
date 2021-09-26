import { Component, OnChanges, SimpleChanges } from '@angular/core';
import { UserService } from './services';
import { AuthService } from './services/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  title = 'Weeblantis';
  isLoggedIn: boolean = false;
  constructor(
    private authService: AuthService,
    private userService: UserService
  ) {
    this.authService.setToken();
    this.userService.getLoggedInState().subscribe((result) => {
      this.isLoggedIn = result;
    });
  }
  logout() {
    this.userService.logout();
  }
}
