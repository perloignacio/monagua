import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ClientesComponent } from './clientes/clientes.component';
import { PrestadoresComponent } from './prestadores/prestadores.component';
import { PanelRoutingModule } from './panel-routing-module';


@NgModule({
    declarations: [
        ClientesComponent,
        PrestadoresComponent
    ],
    exports:[
      
    ],
    imports: [
      CommonModule,
      RouterModule,
      PanelRoutingModule,
      
    ],providers:[
      DatePipe
    ]
  })
  export class PanelModule { }