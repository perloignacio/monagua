import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
const httpOptions = {
  withCredentials: true
};


@Injectable({
  providedIn: 'root'
})
export class FavoritosService {

  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"favoritos/";
  }

  Agregar(id:number) {
    return this.httpClient.get<boolean>(this.endpoint+'Agregar?id='+id);
  }
}
