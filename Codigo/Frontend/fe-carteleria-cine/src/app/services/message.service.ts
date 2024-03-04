import { Injectable } from "@angular/core";
import { BehaviorSubject } from "rxjs";
import { Pelicula } from "../models/pelicula.model";

@Injectable({
    providedIn: 'root'
  })
  export class MessageService {

    private message = new BehaviorSubject({});
    getMessage =  this.message.asObservable();

    constructor() {}

    setMessage(pelicula: Pelicula){
        this.message.next(pelicula);
    }
  }