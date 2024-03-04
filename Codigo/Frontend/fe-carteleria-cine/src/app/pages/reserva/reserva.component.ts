import { Component, OnInit } from '@angular/core';
import { MessageService } from '../../services/message.service';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ReservaService } from '../../services/reserva.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-reserva',
  templateUrl: './reserva.component.html',
  styleUrl: './reserva.component.scss'
})
export class ReservaComponent implements OnInit {

  form!: FormGroup;
  numeroTicket: number = 0;
  horarioId: number = 0;

  constructor(private messageService: MessageService,
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private reservaService: ReservaService) {
  }

  ngOnInit(): void {
    this.horarioId = parseInt(this.route.snapshot.paramMap.get('horarioId') || '0');
    this.messageService.getMessage.subscribe(msg => console.log(msg));
    this.inicializarForm();
  }

  inicializarForm() {
    this.form = this.fb.group({
      nombres: ['', Validators.required],
      apellidoPaterno: ['', Validators.required],
      apellidoMaterno: ['', Validators.required],
      fechaNacimiento: ['', Validators.required],
      genero: ['', Validators.required],
      tipoDocumento: ['', Validators.required],
      numeroDocumento: ['', Validators.required]
    });

  }

  get nombres(): FormControl{
    return this.form.controls['nombres'] as FormControl;
  }

  reservar() {

    const {
      nombres,
      apellidoPaterno,
      apellidoMaterno,
      fechaNacimiento,
      genero,
      tipoDocumento,
      numeroDocumento
    } = this.form.value;


    this.reservaService.guardarReserva({
      horarioId: this.horarioId,
      nombres,
      apellidoPaterno,
      apellidoMaterno,
      numeroDocumento,
      fechaNacimiento,
      genero,
      tipoDocumentoIdentidadId: tipoDocumento
    }).subscribe({
      next: (response) => {
        this.numeroTicket = response.nroTicket;
        this.form.disable();
      },
      error: (e) => console.error(e)
    });
  }
}
