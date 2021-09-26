import { AbstractControl } from '@angular/forms';

export function emailValidator(
  control: AbstractControl
): { [key: string]: boolean } | null {
  if (control.pristine) {
    return null;
  }
  const emailValidationRegex: RegExp =
    /^(?=[A-Z])[A-Z0-9_\-\.]+@(?=(([A-Z0-9_\-]+\.)+))\1[A-Z]{2,4}$/i;
  const email = control.value;
  return email.match(emailValidationRegex) ? null : { invalidEmail: true };
}
