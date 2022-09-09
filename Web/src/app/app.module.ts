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
import { SlickCarouselModule } from 'ngx-slick-carousel';
import { SweetAlert2Module } from '@sweetalert2/ngx-sweetalert2';
import { RecuperarComponent } from './web/recuperar/recuperar.component';
import { BlanqueoComponent } from './web/blanqueo/blanqueo.component';
import { DatePipe } from '@angular/common';
import { FichaComponent } from './web/ficha/ficha.component';

import { LOCALE_ID } from '@angular/core';
import { registerLocaleData } from "@angular/common";
import localeEs from "@angular/common/locales/es-AR";
import { ComprasComponent } from './web/compras/compras.component';
import { ModalActualizaActividadComponent } from './web/shared/modal-actualiza-actividad/modal-actualiza-actividad.component';
import { CheckoutComponent } from './web/checkout/checkout.component';
import { GraciasComponent } from './web/gracias/gracias.component';
import { SharedModule } from './shared/shared.module';
import { NosotrosComponent } from './web/nosotros/nosotros.component';
import { ListadoComponent } from './web/listado/listado.component';
import { PreguntasComponent } from './web/preguntas/preguntas.component';
import { PoliticasComponent } from './web/politicas/politicas.component';
import { TerminosComponent } from './web/terminos/terminos.component';
import { ContactoComponent } from './web/contacto/contacto.component';
import { NgxSpinnerModule } from "ngx-spinner";


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
    
    ComprasComponent,
    ModalActualizaActividadComponent,
    CheckoutComponent,
    GraciasComponent,
    NosotrosComponent,
    ListadoComponent,
    PreguntasComponent,
    PoliticasComponent,
    TerminosComponent,
    ContactoComponent,
    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule,
    SlickCarouselModule,
    ReactiveFormsModule,
    CalendarModule.forRoot({
      provide: DateAdapter,
      useFactory: adapterFactory,
    }),
    NgxSpinnerModule,
    SharedModule,
    SweetAlert2Module.forRoot(),
    HttpClientModule,
         NgbModule
  ],
  
  providers: [{ provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },DatePipe,{ provide: LOCALE_ID, useValue: "es-AR"}],
  exports:[],
  bootstrap: [AppComponent]
})
export class AppModule { }
