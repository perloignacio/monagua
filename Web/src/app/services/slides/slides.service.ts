import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Slides } from 'src/app/models/Slides.model';
import { environment } from 'src/environments/environment';

const httpOptions = {
  withCredentials: true
};
@Injectable({
  providedIn: 'root'
})
export class SlidesService {

  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"slides/";
  }
  
  Registrar(obj:any) {
    return this.httpClient.post<boolean>(this.endpoint + `registrar`,obj, httpOptions)
  }

  borrar(id:number) {
    return this.httpClient.get<boolean>(this.endpoint + `Admin/borrar?id=${id}`, httpOptions)
  }
  
  todosAdmin() {
    return this.httpClient.get<Slides[]>(this.endpoint + `Admin/todosAdmin`, httpOptions)
  }

  todos() {
    return this.httpClient.get<Slides[]>(this.endpoint + `todos`, httpOptions)
  }

  activar(id:number) {
    return this.httpClient.get<boolean>(this.endpoint + `Admin/activar?id=${id}`, httpOptions)
  }
  AgregarEditar(form:any) {
    return this.httpClient.post<boolean>(this.endpoint+'Admin/AgregarEditar',form);
  }
  /*Prueba*/
}
