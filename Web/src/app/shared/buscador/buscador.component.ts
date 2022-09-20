import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Categorias } from 'src/app/models/Categorias.model';
import { CategoriasService } from 'src/app/services/categorias/categorias.service';

@Component({
  selector: 'app-buscador',
  templateUrl: './buscador.component.html',
  styleUrls: ['./buscador.component.scss']
})
export class BuscadorComponent implements OnInit {
  fecha:Date;
  categoria:Categorias;
  categorias:Categorias[]=[];
  slide:boolean=false;
  @Input()
  set InsideSlide(value: boolean) {
    this.slide=value;
  }
  constructor(private srvCategorias:CategoriasService,private route:Router) {
    this.srvCategorias.todas().subscribe((lc)=>{
      this.categorias=lc;
    })
  }
  
  buscar(){
    if(this.categoria && this.fecha){
      this.route.navigate([`/actividades/buscar/${this.categoria.IdCategoria}/${this.categoria.Nombre}/${this.fecha}`])
    }else{
      if(this.categoria){
        this.route.navigate([`/actividades/buscar/${this.categoria.IdCategoria}/${this.categoria.Nombre}`])
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
