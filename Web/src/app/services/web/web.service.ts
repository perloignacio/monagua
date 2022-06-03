import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Paises } from 'src/app/models/Paises.model';
const httpOptions = {
  withCredentials: true
};

@Injectable({
  providedIn: 'root'
})
export class WebService {

  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"/web/";
  }
  
  Paises() {
    return this.httpClient.get<Paises[]>(this.endpoint + `paises`, httpOptions)
  }
}
