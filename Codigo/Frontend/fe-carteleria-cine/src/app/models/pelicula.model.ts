import { Horario } from "./horario.model"
import { Sala } from "./sala.model"

export interface Pelicula {
    id: number
    titulo: string
    sinopsis: string
    genero: string
    duracion: number
    urlImagen: string
    horarios: Horario[],
    salas: Sala[]
  }