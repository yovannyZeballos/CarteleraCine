import { Injectable } from "@angular/core";
import { ApiService } from "./api.service";
import { Observable } from "rxjs";
import { Pelicula } from "../models/pelicula.model";
import { ReservaResponse } from "../models/reserva-response.model";
import { Reserva } from "../models/reserva.model";

@Injectable({
    providedIn: 'root'
})
export class ReservaService {

    private readonly reservaUrl = 'reserva';

    constructor(private apiService: ApiService) { }

    guardarReserva(reserva: Reserva): Observable<ReservaResponse> {
        return this.apiService.post<ReservaResponse>(this.reservaUrl,reserva);
    }

}