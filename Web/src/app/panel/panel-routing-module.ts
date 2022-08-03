import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ActividadComponent } from './actividad/actividad.component';
import { ActividadesComponent } from './actividades/actividades.component';
import { ClientesComponent } from './clientes/clientes.component';
import { HorariosActividadesComponent } from './horarios-actividades/horarios-actividades.component';
import { MainComponent } from './main/main.component';
import { PrestadoresComponent } from './prestadores/prestadores.component';


    const routes: Routes = [
    {
      path: '',
      component: MainComponent,
      children:[
        {
          path: 'cliente',
          component: ClientesComponent,
        },
        {
          path: 'prestador',
          component: PrestadoresComponent,
        },
        {
          path: 'prestador/actividades',
          component: ActividadesComponent,
        },
        {
          path: 'prestador/actividad',
          component: ActividadComponent,
        },
        {
          path: 'prestador/actividad/:id/horarios',
          component:HorariosActividadesComponent
        },
  
      ]
    }
  
  ];
  
  @NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class PanelRoutingModule { }