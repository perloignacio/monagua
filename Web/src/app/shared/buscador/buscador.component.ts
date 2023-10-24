import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Categorias } from 'src/app/models/Categorias.model';
import { Provincias } from 'src/app/models/Provincias.model';
import { CategoriasService } from 'src/app/services/categorias/categorias.service';
import { WebService } from 'src/app/services/web/web.service';

@Component({
  selector: 'app-buscador',
  templateUrl: './buscador.component.html',
  styleUrls: ['./buscador.component.scss']
})
export class BuscadorComponent implements OnInit {
  fecha:Date;
  provincia:Provincias;
  provincias:Provincias[]=[];
  slide:boolean=false;
  @Input()
  set InsideSlide(value: boolean) {
    this.slide=value;
  }
  constructor(private srvWeb:WebService,private route:Router) {
    this.srvWeb.Provincias(1).subscribe((lp)=>{
      this.provincias=lp;
    })
  }
  
  buscar(){
    if(this.provincia && this.fecha){
      this.route.navigate([`/actividades/buscar/${this.provincia.IdProvincia}/${this.provincia.Nombre}/${this.fecha}`])
    }else{
      if(this.provincia){
        this.route.navigate([`/actividades/buscar/${this.provincia.IdProvincia}/${this.provincia.Nombre}`])
      }else{
        if(this.fecha){
          this.route.navigate([`/actividades/buscar/${this.fecha}`])
        }
      }
    }
    
  }
  ngOnInit(): void {
  }

}
