import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PeliculaCardComponent } from './pelicula-card/pelicula-card.component';
import { RouterModule } from '@angular/router';
import { HeaderComponent } from './header/header.component';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    PeliculaCardComponent,
    HeaderComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    FormsModule
  ],
  exports: [
    PeliculaCardComponent,
    HeaderComponent
  ]
})
export class ComponentsModule { }
