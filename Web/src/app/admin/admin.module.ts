import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { AdminRoutingModule } from './admin-routing.module';
import { RouterModule } from '@angular/router';
import { CategoriasComponent } from './categorias/categorias.component';
import { CategoriasFormComponent } from './categorias-form/categorias-form.component';
import { MainComponent } from './main/main.component';
import { ClientesComponent } from './clientes/clientes.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
@NgModule({
    declarations: [
        CategoriasComponent,
        CategoriasFormComponent,
        MainComponent,
        ClientesComponent
    ],
    exports:[
      
    ],
    imports: [
      CommonModule,
      RouterModule,
      AdminRoutingModule,
      NgbModule,
      FormsModule,
      ReactiveFormsModule
      
    ],providers:[
      DatePipe
    ]
  })
  export class AdminModule { }