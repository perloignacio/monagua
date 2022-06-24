import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ActividadesHorarios } from 'src/app/models/ActividadesHorarios.model';

import { environment } from 'src/environments/environment';

const httpOptions = {
  withCredentials: true
};

@Injectable({
  providedIn: 'root'
})
export class ActividadesService {

  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"actividades/";
  }
  
  HorariosByActividad(id:number) {
    return this.httpClient.get<ActividadesHorarios[]>(this.endpoint + `getHorarios?idactividad=${id}`, httpOptions)
  }

  
  agregarHorario(form:any) {
    return this.httpClient.post<boolean>(this.endpoint + `/agregarHorario`,form, httpOptions)
  }

  modificarHorario(form:any) {
    return this.httpClient.post<boolean>(this.endpoint + `/modificarHorario`,form, httpOptions)
  }
  modificarUnHorario(form:any) {
    return this.httpClient.post<boolean>(this.endpoint + `/modificarUnHorario`,form, httpOptions)
  }
  modificarSiguientesHorario(form:any) {
    return this.httpClient.post<boolean>(this.endpoint + `/modificarSiguientesHorario`,form, httpOptions)
  }

  borrarHorario(form:any) {
    return this.httpClient.post<boolean>(this.endpoint + `/borrarHorario`,form, httpOptions)
  }
  borrarUnHorario(form:any) {
    return this.httpClient.post<boolean>(this.endpoint + `/borrarUnHorario`,form, httpOptions)
  }
  borrarSiguientesHorario(form:any) {
    return this.httpClient.post<boolean>(this.endpoint + `/borrarSiguientesHorario`,form, httpOptions)
  }
  
 
  
}
