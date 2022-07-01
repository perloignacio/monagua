import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';

import { JsonResult } from 'src/app/models/jsonresult.interface';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  ObjEdit:any;
  IdActividad:number;
  AccionModal:string;
  objModal:any;
  isActive: boolean=false;
  msjValidacionArchivos:string;
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

  validaArchivos(file: File, Archivos: any[], PorAportar: any[]) {
    var resultado = true;
    if (file.size > 104857600) {
      this.msjValidacionArchivos = 'El archivo supera los 100 mega bytes.';
      resultado = false;
    }

    var nombreArchivo = file.name.substring(0, file.name.lastIndexOf('.'));

    

    if (PorAportar.length > 0) {
      if (PorAportar.filter((x) => x.file.name == file.name).length > 1) {
        this.msjValidacionArchivos =
          'No se permite subir dos o más archivos con el mismo nombre para un mismo ítem';
        resultado = false;
      }
    }

    var allowedExtensions =
      /(.jpg|.jpeg|.png)$/i;
    if (
      !allowedExtensions.exec(file.name.substring(file.name.lastIndexOf('.')))
    ) {
      this.msjValidacionArchivos = 'Formato de archivo no permitido.';
      resultado = false;
    }

    return resultado;
  }
}
