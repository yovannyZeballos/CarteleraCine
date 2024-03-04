import { Component, OnInit } from '@angular/core';
import { PeliculaService } from '../../services/pelicula.service';
import { Pelicula } from '../../models/pelicula.model';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-listado-peliculas',
  templateUrl: './listado-peliculas.component.html',
  styleUrl: './listado-peliculas.component.scss'
})
export class ListadoPeliculasComponent implements OnInit {

  peliculas: Pelicula[] = [];

  constructor(private peliculaService: PeliculaService,
    private route: ActivatedRoute) { }

  ngOnInit(): void {

    this.route.queryParams
      .subscribe(params => {

        this.peliculaService.getPeliculas(params)
        .subscribe({
          next: (peliculas) => this.peliculas = peliculas,
          error: (e) => console.error(e)
        });
      }
    );

   

  }

}
