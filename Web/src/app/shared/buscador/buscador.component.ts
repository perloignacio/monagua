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
  categoria:number;
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
    this.route.navigate(["/actividades"])
  }
  ngOnInit(): void {
  }

}
