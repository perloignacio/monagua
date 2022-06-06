import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoriasFormComponent } from './categorias-form/categorias-form.component';
import { CategoriasComponent } from './categorias/categorias.component';
import { ClientesComponent } from './clientes/clientes.component';
import { MainComponent } from './main/main.component';
    const routes: Routes = [
    {
      path: '',
      component: MainComponent,
      children:[
        {
          path: 'categorias',
          component: CategoriasComponent,
        },
        {
          path: 'CategoriasForm',
          component: CategoriasFormComponent,
        },
        {
          path: 'clientes',
          component: ClientesComponent,
        },
        {
          path: 'clientesForm',
          component: CategoriasFormComponent,
        }
  
      ]
    }
  
  ];
  
  @NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class AdminRoutingModule { }