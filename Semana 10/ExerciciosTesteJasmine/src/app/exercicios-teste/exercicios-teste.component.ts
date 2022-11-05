import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-exercicios-teste',
  templateUrl: './exercicios-teste.component.html',
  styleUrls: ['./exercicios-teste.component.css']
})
export class ExerciciosTesteComponent implements OnInit {

  cidades:string[] = ['Urubici','Lages', 'Florianopolis','Rio de Janeiro']
  constructor() { }

  ngOnInit(): void {
  }


  returnCliente(value:string):string{
    let cliente = value;
    return cliente;
  }

    exibirCpf(value:string):string{
      let cpf = value;
      return cpf;
    }

    returnNull(){
      return;
    }

    multiplicar(n1:number, n2:number):number{
      return n1*n2;
    }

    exemploTeste():boolean{
      let n1 = 3;
      if(n1 > 6)
      return true;
      return false;
    }
}
