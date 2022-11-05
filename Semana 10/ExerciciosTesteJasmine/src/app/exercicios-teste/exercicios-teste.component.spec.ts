import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExerciciosTesteComponent } from './exercicios-teste.component';

describe('ExerciciosTesteComponent', () => {
  let component: ExerciciosTesteComponent;
  let fixture: ComponentFixture<ExerciciosTesteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ExerciciosTesteComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ExerciciosTesteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();

  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  //exercicio 01
  it('validar uso do toBe', () => {
    const cliente = component.returnCliente('Eliane');
    expect(component.returnCliente('Eliane')).toBe(cliente);
  });

    //exercicio 02
  it('validar uso do toEqual', () => {
    const empresario = component.returnCliente('Eliane');
    expect(component.returnCliente('Eliane')).toEqual(empresario);
  });

    //exercicio 03
  it('validar o uso do toMatch', () => {
    const cpf = component.exibirCpf('12345678912')
    expect(cpf).toMatch(/^[0-9]{3}.?[0-9]{3}.?[0-9]{3}-?[0-9]{2}/)
  });


  //exercicio 04
  it('validar o uso do toBeDefined', () => {
    const cpf = component.exibirCpf('12345678912');;

    expect(cpf).toMatch(/^[0-9]{3}.?[0-9]{3}.?[0-9]{3}-?[0-9]{2}/)
    expect(cpf).toBeDefined();
  });

  it('validar o uso do toBeUndefined', () => {

    expect(component.returnNull()).toBeUndefined ();
  });

  //Exercicio 05
  it('validar o uso do toBeTruthy', () => {

    expect(component.multiplicar).toBeTruthy ();
  });

  it('validar o uso do toBeFalse', () => {

    expect(component.multiplicar).toBeTruthy ();
  });

  //Exercicio 06

  it('validar o uso do toContain', () => {

    expect(component.cidades).toContain('Urubici');
  });



});
