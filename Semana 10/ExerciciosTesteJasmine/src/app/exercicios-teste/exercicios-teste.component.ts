import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-exercicios-teste',
  templateUrl: './exercicios-teste.component.html',
  styleUrls: ['./exercicios-teste.component.css']
})
export class ExerciciosTesteComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }


  returnCliente(value:string):string{
    let cliente = value;
    return cliente;
  }

 
}
