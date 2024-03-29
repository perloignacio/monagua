import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Calificaciones } from 'src/app/models/Calificaciones.model';
import { environment } from 'src/environments/environment';
const httpOptions = {
  withCredentials: true
};
@Injectable({
  providedIn: 'root'
})
export class CalificacionesService {
  
  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"calificaciones/";
  }
  
  ByActividad(idactividad:number,orden:string) {
    return this.httpClient.get<Calificaciones[]>(this.endpoint + `byActividad?idactividad=${idactividad}&orden=${orden}`, httpOptions)
  }
  comentar(comentario:string,calificacion:number,IdCompraDetalle:number){
    return this.httpClient.get<boolean>(this.endpoint + `comentar?comentario=${comentario}&calificacion=${calificacion}&idcompradetalle=${IdCompraDetalle}`, httpOptions)
  }
  responder(idcalificacion:number,respuesta:string){
    return this.httpClient.get<boolean>(this.endpoint + `responder?idcalificacion=${idcalificacion}&respuesta=${respuesta}`, httpOptions)
  }
  byCompra(IdCompraDetalle:number){
    return this.httpClient.get<Calificaciones>(this.endpoint + `byCompra?idcompradetalle=${IdCompraDetalle}`, httpOptions)
  }
}
