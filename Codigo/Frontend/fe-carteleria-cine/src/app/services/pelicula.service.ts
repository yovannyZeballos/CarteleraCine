import { Injectable } from "@angular/core";
import { ApiService } from "./api.service";
import { Observable } from "rxjs";
import { Pelicula } from "../models/pelicula.model";

@Injectable({
    providedIn: 'root'
})
export class PeliculaService {

    private readonly peliculaUrl = 'pelicula';

    constructor(private apiService: ApiService) { }

    getPeliculas(params:any): Observable<Pelicula[]> {
        return this.apiService.get<Pelicula[]>(this.peliculaUrl,params);
    }

    getPelicula(id: number): Observable<Pelicula> {
        return this.apiService.get<Pelicula>(`${this.peliculaUrl}/${id}`);
    }

}