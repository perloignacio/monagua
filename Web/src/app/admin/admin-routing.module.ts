import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FavoritosDetalleComponent } from './favoritos-detalle/favoritos-detalle.component';
import { CalificacionesComponent } from './calificaciones/calificaciones.component';
import { CategoriasFormComponent } from './categorias-form/categorias-form.component';
import { CategoriasComponent } from './categorias/categorias.component';
import { ClientesFormComponent } from './clientes-form/clientes-form.component';
import { ClientesComponent } from './clientes/clientes.component';
import { ComprasFormComponent } from './compras-form/compras-form.component';
import { ComprasComponent } from './compras/compras.component';
import { CuponesFormComponent } from './cupones-form/cupones-form.component';
import { CuponesComponent } from './cupones/cupones.component';
import { FavoritosComponent } from './favoritos/favoritos.component';
import { MainComponent } from './main/main.component';
import { MensajesComponent } from './mensajes/mensajes.component';
import { PrestadoresFormComponent } from './prestadores-form/prestadores-form.component';
import { PrestadoresComponent } from './prestadores/prestadores.component';
import { UsuariosFormComponent } from './usuarios-form/usuarios-form.component';
import { UsuariosComponent } from './usuarios/usuarios.component';
import { SlidesComponent } from './slides/slides.component';
import { PreguntasComponent } from './preguntas/preguntas.component';
import { PreguntasFormComponent } from './preguntas-form/preguntas-form.component';
import { SlidesFormComponent } from './slides-form/slides-form.component';
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
          path: 'categoriasForm',
          component: CategoriasFormComponent,
        },
        {
          path: 'clientes',
          component: ClientesComponent,
        },
        {
          path: 'clientesForm',
          component: ClientesFormComponent,
        },
        {
          path: 'prestadores',
          component: PrestadoresComponent,
        },
        {
          path: 'prestadoresForm',
          component: PrestadoresFormComponent,
        },
        {
          path: 'compras',
          component: ComprasComponent,
        },
        {
          path: 'comprasForm',
          component: ComprasFormComponent,
        },
        {
          path: 'cupones',
          component: CuponesComponent,
        },
        {
          path: 'cuponesForm',
          component: CuponesFormComponent,
        },
        {
          path: 'favoritos',
          component: FavoritosComponent,
        },
        {
          path: 'favoritos-detalle',
          component: FavoritosDetalleComponent,
        },
        {
          path: 'calificaciones',
          component: CalificacionesComponent,
        },
        {
          path: 'mensajes',
          component: MensajesComponent,
        },
        {
          path: 'usuarios',
          component: UsuariosComponent,
        },
        {
          path: 'usuariosForm',
          component: UsuariosFormComponent,
        },
        {
          path: 'slides',
          component: SlidesComponent,
        },
        {
          path: 'slidesForm',
          component: SlidesFormComponent,
        },
        {
          path: 'preguntas',
          component: PreguntasComponent,
        },
        {
          path: 'preguntasForm',
          component: PreguntasFormComponent,
        }
      ]
    }
  
  ];
  
  @NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class AdminRoutingModule { }