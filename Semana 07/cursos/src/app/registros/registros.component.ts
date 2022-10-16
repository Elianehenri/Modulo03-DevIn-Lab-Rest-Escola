import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-registros',
  templateUrl: './registros.component.html',
  styleUrls: ['./registros.component.css']
})
export class RegistrosComponent implements OnInit {

  constructor(private formBuilder:FormBuilder) { }

  ngOnInit(): void {

  }
  register = this.formBuilder.group({
    nome: this.formBuilder.control(''),
    cargaHoraria: this.formBuilder.control(''),
    escola: this.formBuilder.control('SENAI/SC - Serviço Nacional de Aprendizagem Industrial'),
    professor: this.formBuilder.control(''),
    materia: this.formBuilder.control(''),
  })
  showForm(){
    console.log(this.register);

  }

}
