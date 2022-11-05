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

  it('validar uso do toBe', () => {
    const cliente = component.returnCliente('Eliane');
    expect(component.returnCliente('Eliane')).toBe(cliente);
  });
});
