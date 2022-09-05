import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';


const httpOptions = {
  withCredentials: true
};
@Injectable({
  providedIn: 'root'
})
export class ContactoService {

  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"contacto/";
  }
  
  Enviar(obj:any) {
    return this.httpClient.post<boolean>(this.endpoint + `enviar`,obj, httpOptions)
  }
}
