import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.scss'],
})
export class RegistrationComponent implements OnInit {
  form!: FormGroup;

  constructor(public fb: FormBuilder) {}

  ngOnInit(): void {
    this.validation();
  }

  private validation(): void {
    this.form = this.fb.group({
      primeiroNome: ['', [Validators.required, Validators.minLength(3)]],
      ultimoNome: ['', [Validators.required, Validators.minLength(3)]],
      email: ['', [Validators.required, Validators.email]],
      userName: ['', [Validators.required, Validators.minLength(3)]],
      senha: ['', [Validators.required, Validators.minLength(6)]],
      confirmarSenha: ['', [Validators.required, Validators.minLength(6)]],
    });
  }

  resetForm(): void {
    this.form.reset();
  }

  public get f(): any {
    return this.form.controls;
  }

  register(): void {
    if (this.form.valid) {
      console.log(this.form.value);
    }
  }
}
