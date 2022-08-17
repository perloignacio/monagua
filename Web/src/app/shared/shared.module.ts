import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { RouterModule } from '@angular/router';

import { ActividadSharedComponent } from './actividad/actividad.component';


@NgModule({
    declarations: [
        ActividadSharedComponent
        
    ],
    exports:[
        ActividadSharedComponent
    ],
    imports: [
      CommonModule,
      RouterModule,
      
    ],providers:[
      DatePipe
    ]
  })
  export class SharedModule { }