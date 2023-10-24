import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Categorias } from 'src/app/models/Categorias.model';
import { CategoriasService } from 'src/app/services/categorias/categorias.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-categorias',
  templateUrl: './categorias.component.html',
  styleUrls: ['./categorias.component.scss']
})
export class CategoriasComponent implements OnInit {
  slideConfig = {"slidesToShow": 12, "slidesToScroll": 2,"autoplay":true,"arrows":true,"responsive":[
    {
      breakpoint: 1024,
      settings: {
        slidesToShow: 12,
        slidesToScroll: 2,

      }
    },
    {
      breakpoint: 600,
      settings: {
        slidesToShow: 6,
        slidesToScroll: 2
      }
    },
    {
      breakpoint: 480,
      settings: {
        slidesToShow:4,
        slidesToScroll: 2
      }
    }
  ]};
  base= environment.assets;
  baseImg= this.base + 'assets/categorias/';
  categorias:Categorias[]=[];
  constructor(private srvCategorias:CategoriasService,private route:Router) { 
    this.srvCategorias.todas().subscribe((lc)=>{
      this.categorias=lc;
    })
  }


  Categoria(c:Categorias){
    this.route.navigate([`/actividades/buscar/categoria/${c.IdCategoria}/${c.Nombre}`])
  }
  ngOnInit(): void {
  }

}
