import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuardService } from './services/AuthGuardService/auth-guard.service';
import { BlanqueoComponent } from './web/blanqueo/blanqueo.component';
import { HomeComponent } from './web/home/home.component';
import { LoginComponent } from './web/login/login.component';
import { RecuperarComponent } from './web/recuperar/recuperar.component';
import { RegistroClientesComponent } from './web/registro-clientes/registro-clientes.component';
import { RegistroPrestadoresComponent } from './web/registro-prestadores/registro-prestadores.component';

const routes: Routes = [
  {
    path:'',
    component:HomeComponent,
  },
  {
    path:'login',
    component:LoginComponent,
  },
  {
    path:'registro/cliente',
    component:RegistroClientesComponent,
  },
  {
    path:'registro/prestador',
    component:RegistroPrestadoresComponent,
  },
  {
    path:'recuperar',
    component:RecuperarComponent,
  },
  {
    path: 'blanqueo/:hash',
    component:BlanqueoComponent
  },
  
  {
    path: 'panel',
    loadChildren: () => import('./panel/panel.module').then(m => m.PanelModule),
     canLoad: [ AuthGuardService ],
     canActivate:[AuthGuardService],
  },
  {
     path: 'admin', loadChildren: () => import('./admin/admin.module').then(m => m.AdminModule),
     canLoad: [ AuthGuardService ],
     canActivate:[AuthGuardService],

  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
