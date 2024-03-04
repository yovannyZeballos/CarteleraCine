import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss'
})
export class HeaderComponent {

  filtro: string = '0';
  valorFiltro: string = "";

  constructor(private router: Router) {
  }

  buscar(){

    let query = {};
    console.log(query);

    switch (this.filtro) {
      case '1':
        query = {numeroSala: this.valorFiltro};
        break;
      case '2':
        query = {genero: this.valorFiltro};
        break;
      case '3':
        query = {titulo: this.valorFiltro};
        break;
      case '4':
        query = {horaInicio: this.valorFiltro};
        break;
    }

    console.log(query);

    this.router.navigate(
      ['/pages/pelicula'],
      { queryParams: query }
    );
  }
}
