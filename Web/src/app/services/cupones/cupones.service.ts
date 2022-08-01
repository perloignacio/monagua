import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Descuentos } from 'src/app/models/Descuentos.model';
import { environment } from 'src/environments/environment';


const httpOptions = {
  withCredentials: true
};
@Injectable({
  providedIn: 'root'
})
export class CuponesService {

  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"cupones/";
  }
  
  

  borrar(id:number) {
    return this.httpClient.get<boolean>(this.endpoint + `Admin/borrar?id=${id}`, httpOptions)
  }
  activar(id:number) {
    return this.httpClient.get<boolean>(this.endpoint + `Admin/activar?id=${id}`, httpOptions)
  }
  todosAdmin() {
    return this.httpClient.get<Descuentos[]>(this.endpoint + `Admin/todosAdmin`, httpOptions)
  }
  
  Registrar(obj:any) {
    return this.httpClient.post<boolean>(this.endpoint + `registrar`,obj, httpOptions)
  }
  
  AgregarEditar(form:any) {
    return this.httpClient.post<boolean>(this.endpoint+'Admin/AgregarEditar',form);
  }
  Canjear(codigo:string){
    return this.httpClient.get<Descuentos>(this.endpoint + `Canjear?codigo=${codigo}`, httpOptions)
  }
}
