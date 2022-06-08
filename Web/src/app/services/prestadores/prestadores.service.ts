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

}
