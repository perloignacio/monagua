import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ComprasComponent } from './web/compras/compras.component';
import { AuthGuardService } from './services/AuthGuardService/auth-guard.service';
import { BlanqueoComponent } from './web/blanqueo/blanqueo.component';
import { FichaComponent } from './web/ficha/ficha.component';
import { HomeComponent } from './web/home/home.component';
import { LoginComponent } from './web/login/login.component';
import { RecuperarComponent } from './web/recuperar/recuperar.component';
import { RegistroClientesComponent } from './web/registro-clientes/registro-clientes.component';
import { RegistroPrestadoresComponent } from './web/registro-prestadores/registro-prestadores.component';
import { CheckoutComponent } from './web/checkout/checkout.component';
import { GraciasComponent } from './web/gracias/gracias.component';
import { PanelRoutingModule } from './panel/panel-routing-module';
import { NosotrosComponent } from './web/nosotros/nosotros.component';
import { PreguntasComponent } from './web/preguntas/preguntas.component';
import { TerminosComponent } from './web/terminos/terminos.component';
import { PoliticasComponent } from './web/politicas/politicas.component';
import { ContactoComponent } from './web/contacto/contacto.component';
import { ListadoComponent } from './web/listado/listado.component';

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
    path:'actividades',
    component:ListadoComponent,
  },
  {
    path:'actividades/buscar/:categoria/:nombre',
    component:ListadoComponent,
  },
  {
    path:'actividades/buscar/:categoria/:nombre/:fecha',
    component:ListadoComponent,
  },
  {
    path:'actividades/buscar/:fecha',
    component:ListadoComponent,
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
    path:'actividad/:name/:id',
    component:FichaComponent,
  
  },
  {
    path:'compras',
    component:ComprasComponent,
  
  },
  {
    path:'checkout',
    component:CheckoutComponent,
  
  },
  {
    path:'terminosycondiciones',
    component:TerminosComponent,
  
  },
  {
    path:'politicasdeprivacidad',
    component:PoliticasComponent,
  
  },
  {
    path:'contacto',
    component:ContactoComponent,
  
  },
  {
    path:'nosotros',
    component:NosotrosComponent,
  
  },
  {
    path:'ayuda',
    component:PreguntasComponent,
  
  },
  {
    path:'gracias',
    component:GraciasComponent,
  
  },
  {
    path: 'panel',
    loadChildren: () => import('./panel/panel.module').then(m => m.PanelModule),
     canLoad: [ AuthGuardService ],
     canActivate:[AuthGuardService],
  },
  {
     path: 'admin', loadChildren: () => import('./admin/admin.module').then(m => m.AdminModule),
     //canLoad: [ AuthGuardService ],
     //canActivate:[AuthGuardService],

  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
