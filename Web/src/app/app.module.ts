import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { JwtInterceptor } from './helpers/jwt.interseptor';
import { CalendarModule, DateAdapter } from 'angular-calendar';
import { adapterFactory } from 'angular-calendar/date-adapters/date-fns';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './web/login/login.component';
import { RegistroClientesComponent } from './web/registro-clientes/registro-clientes.component';
import { RegistroPrestadoresComponent } from './web/registro-prestadores/registro-prestadores.component';
import { HomeComponent } from './web/home/home.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { SweetAlert2Module } from '@sweetalert2/ngx-sweetalert2';
import { RecuperarComponent } from './web/recuperar/recuperar.component';
import { BlanqueoComponent } from './web/blanqueo/blanqueo.component';
import { DatePipe } from '@angular/common';
import { FichaComponent } from './web/ficha/ficha.component';
import { ActividadComponent } from './web/shared/actividad/actividad.component';
import { LOCALE_ID } from '@angular/core';
import { registerLocaleData } from "@angular/common";
import localeEs from "@angular/common/locales/es-AR";
import { ComprasComponent } from './web/compras/compras.component';
import { ModalActualizaActividadComponent } from './web/shared/modal-actualiza-actividad/modal-actualiza-actividad.component';
import { CheckoutComponent } from './web/checkout/checkout.component';
import { GraciasComponent } from './web/gracias/gracias.component';



registerLocaleData(localeEs, "es");
@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegistroClientesComponent,
    RegistroPrestadoresComponent,
    HomeComponent,
    RecuperarComponent,
    BlanqueoComponent,
    FichaComponent,
    ActividadComponent,
    ComprasComponent,
    ModalActualizaActividadComponent,
    CheckoutComponent,
    GraciasComponent,
    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule,
    CalendarModule.forRoot({
      provide: DateAdapter,
      useFactory: adapterFactory,
    }),
    SweetAlert2Module.forRoot(),
    HttpClientModule,
         NgbModule
  ],
  providers: [{ provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },DatePipe,{ provide: LOCALE_ID, useValue: "es-AR"}],
  
  bootstrap: [AppComponent]
})
export class AppModule { }
