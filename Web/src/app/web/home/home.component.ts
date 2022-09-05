import { Component, OnInit } from '@angular/core';
import { Actividades } from 'src/app/models/Actividades.model';
import { Categorias } from 'src/app/models/Categorias.model';
import { Slides } from 'src/app/models/Slides.model';
import { ActividadesService } from 'src/app/services/actividades/actividades.service';
import { CategoriasService } from 'src/app/services/categorias/categorias.service';
import { SlidesService } from 'src/app/services/slides/slides.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  categorias:Categorias[]=[];
  slideConfig = {"slidesToShow": 1, "slidesToScroll": 1,"autoplay":true,"dots":true,"responsive":[
    {
      breakpoint: 1024,
      settings: {
        slidesToShow: 1,
        slidesToScroll: 1,

      }
    },
    {
      breakpoint: 600,
      settings: {
        slidesToShow: 1,
        slidesToScroll: 1
      }
    },
    {
      breakpoint: 480,
      settings: {
        slidesToShow:1,
        slidesToScroll: 1
      }
    }
  ]};
  Actividades:Actividades[]=[];
  base= environment.assets;
  baseImg= this.base + 'assets/slides/';
  slides:Slides[]=[];
  constructor(private srvActividades:ActividadesService,private srvCategorias:CategoriasService,private srvSlides:SlidesService) {
    this.srvActividades.todos().subscribe((la)=>{
      this.Actividades=la;
    })
    
    this.srvCategorias.todas().subscribe((lc)=>{
      this.categorias=lc;
    })
    this.srvSlides.todos().subscribe((ls)=>{
      this.slides=ls;
    })
  }
  
  

  ngOnInit(): void {
  }

}
