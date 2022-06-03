import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
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
  
   Registrar(obj:any) {
    return this.httpClient.post<boolean>(this.endpoint + `registrar`,obj, httpOptions)
  }
}
