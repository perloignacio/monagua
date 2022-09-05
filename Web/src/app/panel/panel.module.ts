import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { RouterModule } from '@angular/router';
import { ClientesComponent } from './clientes/clientes.component';
import { PrestadoresComponent } from './prestadores/prestadores.component';
import { PanelRoutingModule } from './panel-routing-module';
import { ActividadesComponent } from './actividades/actividades.component';
import { HorariosActividadesComponent } from './horarios-actividades/horarios-actividades.component';
import { HorarioComponent } from './horario/horario.component';
import { CalendarModule, DateAdapter } from 'angular-calendar';
import { adapterFactory } from 'angular-calendar/date-adapters/date-fns';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MainComponent } from './main/main.component';
import { NgxFileUploaderModule } from '@uniprank/ngx-file-uploader';
import { ActividadComponent } from './actividad/actividad.component';
import { FavoritosCliComponent } from './favoritosCli/favoritosCli.component';
import { SharedModule } from '../shared/shared.module';
import { CambioContraComponent } from './cambio-contra/cambio-contra.component';




@NgModule({
    declarations: [
        ClientesComponent,
        PrestadoresComponent,
        ActividadesComponent,
        HorariosActividadesComponent,
        HorarioComponent,
        MainComponent,
        ActividadComponent,
        FavoritosCliComponent,
        CambioContraComponent,
        
    ],
    exports:[
      
    ],
    imports: [
      CommonModule,
      RouterModule,
      FormsModule,
      ReactiveFormsModule,
      PanelRoutingModule,
      SharedModule,
      NgxFileUploaderModule.forRoot(),
      CalendarModule.forRoot({
        provide: DateAdapter,
        useFactory: adapterFactory,
      }),
    ],providers:[
      DatePipe
    ]
  })
  export class PanelModule { }