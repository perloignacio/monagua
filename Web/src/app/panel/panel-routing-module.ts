import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Prestadores } from '../Models/Prestadores.model';
import { ClientesComponent } from './clientes/clientes.component';
import { MainComponent } from './main/main.component';


    const routes: Routes = [
    {
      path: '',
      component: MainComponent,
      children:[
        {
          path: 'clientes',
          component: ClientesComponent,
        },
        {
          path: 'prestadores',
          component: Prestadores,
        }
  
      ]
    }
  
  ];
  
  @NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class PanelRoutingModule { }