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
import { TopComponent } from './shared/top/top.component';
import { MenuComponent } from './shared/menu/menu.component';
import { ComprasComponent } from './compras/compras.component';
import { ComprasFormComponent } from './compras-form/compras-form.component';
import { CuponesComponent } from './cupones/cupones.component';
import { CuponesFormComponent } from './cupones-form/cupones-form.component';
import { PrestadoresComponent } from './prestadores/prestadores.component';
import { PrestadoresFormComponent } from './prestadores-form/prestadores-form.component';
import { ClientesFormComponent } from './clientes-form/clientes-form.component';
import { FavoritosComponent } from './favoritos/favoritos.component';
import { MensajesComponent } from './mensajes/mensajes.component';
import { CalificacionesComponent } from './calificaciones/calificaciones.component';
import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';
import { UsuariosComponent } from './usuarios/usuarios.component';
import { UsuariosFormComponent } from './usuarios-form/usuarios-form.component';
import { FavoritosDetalleComponent } from './favoritos-detalle/favoritos-detalle.component';
import { SlidesComponent } from './slides/slides.component';
import { PreguntasComponent } from './preguntas/preguntas.component';
import { PreguntasFormComponent } from './preguntas-form/preguntas-form.component';
import { SlidesFormComponent } from './slides-form/slides-form.component';
@NgModule({
    declarations: [
        CategoriasComponent,
        CategoriasFormComponent,
        MainComponent,
        ClientesComponent,
        TopComponent,
        MenuComponent,
        ComprasComponent,
        ComprasFormComponent,
        CuponesComponent,
        CuponesFormComponent,
        PrestadoresComponent,
        PrestadoresFormComponent,
        ClientesFormComponent,
        FavoritosComponent,
        MensajesComponent,
        CalificacionesComponent,
        UsuariosComponent,
        UsuariosFormComponent,
        FavoritosDetalleComponent,
        SlidesComponent,
        PreguntasComponent,
        PreguntasFormComponent,
        SlidesFormComponent
    ],
    exports:[
      
    ],
    imports: [
      CommonModule,
      RouterModule,
      AdminRoutingModule,
      NgbModule,
      FormsModule,
      ReactiveFormsModule,
      PerfectScrollbarModule
      
    ],providers:[
      DatePipe
    ]
  })
  export class AdminModule { }