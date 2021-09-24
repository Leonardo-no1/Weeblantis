import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Login} from '../models';
import { UserService } from '../services';
import { NotifierService } from 'angular-notifier';
import { emailValidator } from '../shared/email.validator';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent implements OnInit {
  formGroup: FormGroup = this.fb.group({
    email: new FormControl('', [
      Validators.email,
      Validators.required,
      emailValidator,
    ]),
    password: new FormControl('', [Validators.required]),
  });
  constructor(
    private fb: FormBuilder,
    private userService: UserService,
    private notifierService: NotifierService,
    private router: Router
  ) {}

  ngOnInit(): void {}

  login() {
    if (this.f?.invalid) {
      this.f.markAllAsTouched();
      return;
    }
    var login: Login = {
      Email: this.email?.value,
      Password: this.password?.value,
    };
    this.userService.login(login).subscribe(
      (result) => {
        if (result) {
          this.notifierService.notify('success', 'Logged in successfully');
          this.router.navigateByUrl('');
        } else {
          this.notifierService.notify('error', 'Email or Password incorrect');
        }
      },
      (error) => {
        this.notifierService.notify('error', 'No user found');
      }
    );
  }

  get f(): AbstractControl | null {
    return this.formGroup;
  }
  get email(): AbstractControl | null {
    return this.formGroup.get('email');
  }
  get password(): AbstractControl | null {
    return this.formGroup.get('password');
  }
}
