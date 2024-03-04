import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { PagesComponent } from './pages.component';
import { ListadoPeliculasComponent } from './listado-peliculas/listado-peliculas.component';
import { DetallePeliculaComponent } from './detalle-pelicula/detalle-pelicula.component';
import { ReservaComponent } from './reserva/reserva.component';

const routes: Routes = [{
  path: '',
  component: PagesComponent,
  children: [
    {
        path: 'pelicula',
        component: ListadoPeliculasComponent
    },
    {
        path: 'pelicula/:id',
        component: DetallePeliculaComponent
    },
    {
      path: 'reserva/:horarioId',
      component: ReservaComponent
  },
    {
        path: '',
        redirectTo: 'pelicula',
        pathMatch: 'full',
      },
  ],
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PagesRoutingModule {
}
