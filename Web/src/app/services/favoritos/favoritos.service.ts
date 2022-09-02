import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Favoritos } from 'src/app/models/Favoritos.model';
import { FavoritosAgrup } from 'src/app/models/FavoritosAgrup.model';
import { environment } from 'src/environments/environment';
const httpOptions = {
  withCredentials: true
};


@Injectable({
  providedIn: 'root'
})
export class FavoritosService {
  

  endpoint:string="";
  environment: any;
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"favoritos/";
  }
  todosAdmin(id:number,desde:Date,hasta:Date,idcliente:number) {
    return this.httpClient.get<Favoritos[]>(this.endpoint + `Admin/detalle?idactividad=${id}&desde=${desde}&hasta=${hasta}&idcliente=${idcliente}`, httpOptions)
  }
 
  Agregar(id:number) {
    return this.httpClient.get<boolean>(this.endpoint+'Agregar?id='+id);
  }

  

}
