import { Component, Input } from '@angular/core';
import { Pelicula } from '../../models/pelicula.model';

@Component({
  selector: 'app-pelicula-card',
  templateUrl: './pelicula-card.component.html',
  styleUrl: './pelicula-card.component.scss'
})
export class PeliculaCardComponent {

  @Input() pelicula!: Pelicula 

}
