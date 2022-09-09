import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Slides } from 'src/app/models/Slides.model';
import { environment } from 'src/environments/environment';

const httpOptions = {
  withCredentials: true
};
@Injectable({
  providedIn: 'root'
})
export class SlidesService {

  endpoint:string="";
  constructor(public httpClient: HttpClient) {
    this.endpoint = environment.apiUrl+"slides/";
  }
  
  
  todos() {
    return this.httpClient.get<Slides[]>(this.endpoint + `todos`, httpOptions)
  }

  
}
