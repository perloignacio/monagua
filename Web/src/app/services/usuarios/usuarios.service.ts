import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Usuarios } from 'src/app/models/Usuarios.model';
import { environment } from 'src/environments/environment';


const httpOptions = {
  withCredentials: true
};
@Injectable({
  providedIn: 'root'
})
export class UsuariosService {

  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"usuarios/";
  }
  
  

  borrar(id:number) {
    return this.httpClient.get<boolean>(this.endpoint + `Admin/borrar?id=${id}`, httpOptions)
  }
  activar(id:number) {
    return this.httpClient.get<boolean>(this.endpoint + `Admin/activar?id=${id}`, httpOptions)
  }
  todosAdmin() {
    return this.httpClient.get<Usuarios[]>(this.endpoint + `Admin/todosAdmin`, httpOptions)
  }
  AgregarEditar(form:any) {
    return this.httpClient.post<boolean>(this.endpoint + `Admin/AgregarEditar`, httpOptions)
  }
  CambiarContra(contra:string,ncontra:string,rncontra:string){
      return this.httpClient.get<boolean>(this.endpoint + `/cambiarContra?contraActual=${contra}&contraNueva=${ncontra}&rcontraNueva=${rncontra}`, httpOptions)
  }
}
