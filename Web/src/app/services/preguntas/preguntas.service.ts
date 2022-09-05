import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Preguntas } from 'src/app/models/Preguntas.model';
import { environment } from 'src/environments/environment';

const httpOptions = {
  withCredentials: true
};
@Injectable({
  providedIn: 'root'
})
export class PreguntasService {

  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"preguntas/";
  }
  
  Registrar(obj:any) {
    return this.httpClient.post<boolean>(this.endpoint + `registrar`,obj, httpOptions)
  }

  borrar(id:number) {
    return this.httpClient.get<boolean>(this.endpoint + `Admin/borrar?id=${id}`, httpOptions)
  }
  
  todosAdmin() {
    return this.httpClient.get<Preguntas[]>(this.endpoint + `Admin/todosAdmin`, httpOptions)
  }

  todas() {
    return this.httpClient.get<Preguntas[]>(this.endpoint + `todas`, httpOptions)
  }

  activar(id:number) {
    return this.httpClient.get<boolean>(this.endpoint + `Admin/activar?id=${id}`, httpOptions)
  }
  AgregarEditar(form:any) {
    return this.httpClient.post<boolean>(this.endpoint+'Admin/AgregarEditar',form);
  }
}
