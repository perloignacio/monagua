import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';

import { JsonResult } from 'src/app/models/jsonresult.interface';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  ObjEdit:any;
  AccionModal:string;
  objModal:any;
  isActive: boolean=false;
  CambiaActive$ = new Subject<boolean>();
  setActive(band:boolean) {
    this.isActive=band
    this.CambiaActive$.next(band);
  }

  getActive$(): Observable<boolean> {
    return this.CambiaActive$.asObservable();
  }

  constructor() { }
  convertToJSON(objeto: any): JsonResult {
    var resultado: JsonResult;
    try {
      var objetoJson = JSON.stringify(objeto);
      resultado = {
        resultado: true,
        objeto: objetoJson,
      };
    } catch (error) {
      resultado = {
        resultado: false,
        objeto: 'No se pudo convertir el objeto al formato JSON',
      };
    }
    return resultado;
  } 
}
