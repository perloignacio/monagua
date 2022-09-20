import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Prestadores } from 'src/app/models/Prestadores.model';
import { environment } from 'src/environments/environment';

const httpOptions = {
  withCredentials: true
};
@Injectable({
  providedIn: 'root'
})
export class PrestadoresService {
  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"prestadores/";
  }
  
  Registrar(obj:any) {
    return this.httpClient.post<boolean>(this.endpoint + `registrar`,obj, httpOptions)
  }
  Editar(obj:any) {
    return this.httpClient.post<Prestadores>(this.endpoint + `editar`,obj, httpOptions)
  }

  borrar(id:number) {
    return this.httpClient.get<boolean>(this.endpoint + `Admin/borrar?id=${id}`, httpOptions)
  }
  
  todosAdmin() {
    return this.httpClient.get<Prestadores[]>(this.endpoint + `Admin/todosAdmin`, httpOptions)
  }

  activar(id:number) {
    return this.httpClient.get<boolean>(this.endpoint + `Admin/activar?id=${id}`, httpOptions)
  }
}
