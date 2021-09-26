import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { IRegister } from '../models';
import { UserService } from '../services';
import { NotifierService } from 'angular-notifier';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss'],
})
export class RegisterComponent implements OnInit {
  formGroup: FormGroup = this.fb.group({
    firstName: new FormControl('', [Validators.required]),
    lastName: new FormControl('', [Validators.required]),
    email: new FormControl('', [Validators.required, Validators.email]),
    password: new FormControl('', [Validators.required]),
  });
  constructor(
    private fb: FormBuilder,
    private userService: UserService,
    private notifierService: NotifierService,
    private router: Router
  ) {}

  ngOnInit(): void {}

  register() {
    if (this.f?.invalid) {
      this.f.markAllAsTouched();
    }
    var register: IRegister = {
      FirstName: this.firstName?.value,
      LastName: this.lastName?.value,
      Email: this.email?.value,
      Password: this.password?.value,
    };
    this.userService.register(register).subscribe(
      (result) => {
        this.notifierService.notify(
          'success',
          `${register.Email} registered successfully`
        );
        this.router.navigateByUrl('/login');
      },
      (error) => {
        this.notifierService.notify('error', 'Unable to register');
      }
    );
  }

  get f(): AbstractControl | null {
    return this.formGroup;
  }
  get firstName(): AbstractControl | null {
    return this.formGroup.get('firstName');
  }
  get lastName(): AbstractControl | null {
    return this.formGroup.get('lastName');
  }
  get email(): AbstractControl | null {
    return this.formGroup.get('email');
  }
  get password(): AbstractControl | null {
    return this.formGroup.get('password');
  }
}
