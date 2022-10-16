import { Component } from '@angular/core';
import { FormBuilder,FormControl,FormGroup, FormGroupName } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'portifolio';

contato = new FormGroup({
  nome: new FormControl(),
  sobrenome:new FormControl(),
  email:new FormControl(),
  feedback: new FormControl(),


});
control: FormControl;
group: FormGroup;
  constructor(private formBuilder: FormBuilder){


      this.control = formBuilder.control({value: 'my val', disabled: true});
      this.group = formBuilder.group({
        controller: this.control,
        controllerTwo: new FormControl('')
      });
      console.log(this.contato);



  }
}
