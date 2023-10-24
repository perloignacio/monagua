import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Mensajes } from 'src/app/models/Mensajes.model';
import { environment } from 'src/environments/environment';
const httpOptions = {
  withCredentials: true
};
@Injectable({
  providedIn: 'root'
})
export class MensajesService {

  endpoint:string="";
  environment: any;
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"mensajes/";
  }
  ByCompraDetalle(idcompradetalle:number) {
    return this.httpClient.get<Mensajes[]>(this.endpoint + `ByCompraDetalle?id=${idcompradetalle}`, httpOptions)
  }
  
  NoLeidos(idmensaje:number){
    return this.httpClient.get<number>(this.endpoint + `NoLeidos?idmensaje?id=${idmensaje}`, httpOptions)
  }
  Agregar(mensaje:Mensajes) {
    return this.httpClient.post<boolean>(this.endpoint+'Agregar',mensaje,httpOptions);
  }
}
