import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Categorias } from 'src/app/models/Categorias.model';
import { environment } from 'src/environments/environment';

const httpOptions = {
  withCredentials: true
};
@Injectable({
  providedIn: 'root'
})
export class CategoriasService {
  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"categorias/";
  }
  
  Registrar(obj:any) {
    return this.httpClient.post<boolean>(this.endpoint + `registrar`,obj, httpOptions)
  }

  borrar(id:number) {
    return this.httpClient.get<boolean>(this.endpoint + `Admin/borrar?id=${id}`, httpOptions)
  }
  
  todosAdmin() {
    return this.httpClient.get<Categorias[]>(this.endpoint + `Admin/todosAdmin`, httpOptions)
  }

  activar(id:number) {
    return this.httpClient.get<boolean>(this.endpoint + `Admin/activar?id=${id}`, httpOptions)
  }
}
