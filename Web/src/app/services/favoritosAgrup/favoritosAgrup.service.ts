import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FavoritosAgrup } from 'src/app/models/FavoritosAgrup.model';
import { environment } from 'src/environments/environment';
const httpOptions = {
  withCredentials: true
};


@Injectable({
  providedIn: 'root'
})
export class FavoritosAgrupService {

  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"favoritos/";
  }
  
  todosAdmin() {
    return this.httpClient.get<FavoritosAgrup[]>(this.endpoint + `Admin/favoritos`, httpOptions)
  }
  
  
}
