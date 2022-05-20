import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { AdminRoutingModule } from './admin-routing.module';
import { RouterModule } from '@angular/router';
import { CategoriasComponent } from './categorias/categorias.component';
import { CategoriasFormComponent } from './categorias-form/categorias-form.component';
import { MainComponent } from './main/main.component';

@NgModule({
    declarations: [
        CategoriasComponent,
        CategoriasFormComponent,
        MainComponent
    ],
    exports:[
      
    ],
    imports: [
      CommonModule,
      RouterModule,
      AdminRoutingModule,
      
    ],providers:[
      DatePipe
    ]
  })
  export class AdminModule { }