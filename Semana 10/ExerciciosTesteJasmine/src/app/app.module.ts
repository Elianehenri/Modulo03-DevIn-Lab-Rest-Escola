import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ExerciciosTesteComponent } from './exercicios-teste/exercicios-teste.component';

@NgModule({
  declarations: [
    AppComponent,
    ExerciciosTesteComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
