import { Horario } from "./horario.model"

export interface Sala {
    numero: number
    entradasDisponibles: number
    horario: Horario
  }