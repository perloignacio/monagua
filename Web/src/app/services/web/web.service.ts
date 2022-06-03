import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Paises } from 'src/app/models/Paises.model';
import { Provincias } from 'src/app/models/Provincias.model';
import { Localidades } from 'src/app/models/Localidades.model';
import { Usuarios } from 'src/app/models/Usuarios.model';
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
  Provincias(IdPais:number) {
    return this.httpClient.get<Provincias[]>(this.endpoint + `provincias?idpais=${IdPais}`, httpOptions)
  }
  Localidades(IdProvincia:number) {
    return this.httpClient.get<Localidades[]>(this.endpoint + `localidades?idprovincia=${IdProvincia}`, httpOptions)
  }
  GuardarUsu(form:any) {
    return this.httpClient.post<Usuarios>(this.endpoint + 'registrar', form);
  }

}


