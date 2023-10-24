import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ActividadComponent } from './actividad/actividad.component';
import { ActividadesComponent } from './actividades/actividades.component';
import { FavoritosCliComponent } from './favoritosCli/favoritosCli.component';
import { ClientesComponent } from './clientes/clientes.component';
import { HorariosActividadesComponent } from './horarios-actividades/horarios-actividades.component';
import { MainComponent } from './main/main.component';
import { PrestadoresComponent } from './prestadores/prestadores.component';
import { CambioContraComponent } from './cambio-contra/cambio-contra.component';
import { ComprasComponent } from './compras/compras.component';


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
          path: 'cliente/favoritos',
          component: FavoritosCliComponent,
        },
        {
          path: 'compras',
          component: ComprasComponent,
        },
        {
          path: 'cambiarContra',
          component: CambioContraComponent,
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