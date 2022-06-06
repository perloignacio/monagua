import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Clientes } from 'src/app/models/Clientes.model';
import { environment } from 'src/environments/environment';


const httpOptions = {
  withCredentials: true
};
@Injectable({
  providedIn: 'root'
})
export class ClientesService {

  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"clientes/";
  }
  
  

  borrar(id:number) {
    return this.httpClient.get<boolean>(this.endpoint + `Admin/borrar?id=${id}`, httpOptions)
  }
  activar(id:number) {
    return this.httpClient.get<boolean>(this.endpoint + `Admin/activar?id=${id}`, httpOptions)
  }
  todosAdmin() {
    return this.httpClient.get<Clientes[]>(this.endpoint + `Admin/todosAdmin`, httpOptions)
  }
   Registrar(obj:any) {
    return this.httpClient.post<boolean>(this.endpoint + `registrar`,obj, httpOptions)
  }
}
