import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { PeliculaService } from '../../services/pelicula.service';
import { Pelicula } from '../../models/pelicula.model';
import { MessageService } from '../../services/message.service';

@Component({
  selector: 'app-detalle-pelicula',
  templateUrl: './detalle-pelicula.component.html',
  styleUrls: ['./detalle-pelicula.component.scss']
})
export class DetallePeliculaComponent implements OnInit {

  peliculaId: number = 0;
  pelicula: Pelicula | undefined;

  constructor(private route: ActivatedRoute, 
    private peliculaService: PeliculaService,
    private messageService: MessageService,
    private router: Router) { }

  ngOnInit() {
    this.peliculaId = parseInt(this.route.snapshot.paramMap.get('id') || '0');
    this.obtenerDetalle();
  }

  obtenerDetalle() {
    this.peliculaService.getPelicula(this.peliculaId)
      .subscribe({
        next: (pelicula) => this.pelicula = pelicula,
        error: (e) => console.error(e)
      });
  }

  reservar(idHorario: number){
    if (this.pelicula) {
      this.messageService.setMessage(this.pelicula);
      this.router.navigate(['pages/reserva', idHorario]);
    }
  }
}