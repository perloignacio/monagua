import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Preguntas } from 'src/app/models/Preguntas.model';
import { environment } from 'src/environments/environment';

const httpOptions = {
  withCredentials: true
};
@Injectable({
  providedIn: 'root'
})
export class PreguntasService {

  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"preguntas/";
  }
  
  

  todas() {
    return this.httpClient.get<Preguntas[]>(this.endpoint + `todas`, httpOptions)
  }

  
}
