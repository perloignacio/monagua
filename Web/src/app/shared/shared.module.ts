import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ActividadSharedComponent } from './actividad/actividad.component';
import { BuscadorComponent } from './buscador/buscador.component';
import { CategoriasComponent } from './categorias/categorias.component';
import { SlickCarouselModule } from 'ngx-slick-carousel';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ImpactosComponent } from './impactos/impactos.component';
import { ComentariosComponent } from './comentarios/comentarios.component';
@NgModule({
    declarations: [
        ActividadSharedComponent,
        BuscadorComponent,
        CategoriasComponent,
        ImpactosComponent,
        ComentariosComponent
        
    ],
    exports:[
        ActividadSharedComponent,
        BuscadorComponent,
        CategoriasComponent,
        ImpactosComponent,
        ComentariosComponent
    ],
    imports: [
      CommonModule,
      RouterModule,
      FormsModule, 
      ReactiveFormsModule,
      SlickCarouselModule,
      NgbModule
      
    ],providers:[
      DatePipe
    ]
  })
  export class SharedModule { }