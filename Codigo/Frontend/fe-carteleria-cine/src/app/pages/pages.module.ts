import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PagesComponent } from './pages.component';
import { PagesRoutingModule } from './pages-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { ComponentsModule } from '../components/components.module';
import { DetallePeliculaComponent } from './detalle-pelicula/detalle-pelicula.component';
import { ReservaComponent } from './reserva/reserva.component';
import { ListadoPeliculasComponent } from './listado-peliculas/listado-peliculas.component';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    PagesComponent,
    ListadoPeliculasComponent,
    DetallePeliculaComponent,
    ReservaComponent,
  ],
  imports: [
    CommonModule,
    PagesRoutingModule,
    HttpClientModule,
    ComponentsModule,
    ReactiveFormsModule
  ]
})
export class PagesModule { }
