import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-registros',
  templateUrl: './registros.component.html',
  styleUrls: ['./registros.component.css']
})
export class RegistrosComponent implements OnInit {

  constructor(private formBuilder:FormBuilder) { }

  ngOnInit(): void {

  }
  formRegistro = this.formBuilder.group({

    nome: this.formBuilder.control('',
    [Validators.required,
      Validators.minLength(3),
      Validators.pattern('^[A-Za-z]*$')]),

      cargaHoraria: this.formBuilder.control('',
      [Validators.required,
        Validators.min(30),
        Validators.max(100)]),
        escola: this.formBuilder.control('',
        [Validators.required,
          Validators.minLength(3),
          Validators.pattern('^[A-Za-z]*$')]),
          professor: this.formBuilder.control('',
          [Validators.required]),
          materia: this.formBuilder.control('',
          [Validators.required]),
        })

  showForm(){
    console.log(this.formRegistro);

  }

  resetForm(){
    this.formRegistro.reset();
  }

}
