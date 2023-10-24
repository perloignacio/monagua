import { Component } from '@angular/core';
import { Paises } from './models/Paises.model';
import { Provincias } from './models/Provincias.model';
import { Localidades } from './models/Localidades.model';
import { WebService } from './services/web/web.service';
import { ComprasService } from './services/compras/compras.service';
import { AuthenticationService } from './services/authentication/authentication.service';
import { CategoriasService } from './services/categorias/categorias.service';
import { Categorias } from './models/Categorias.model';
import { environment } from 'src/environments/environment';
import { Slides } from './models/Slides.model';
import { SlidesService } from './services/slides/slides.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Web';
  esAdmin:boolean=false
  whatsapp:string="";
  constructor(public srvCompras:ComprasService,public srvAut:AuthenticationService,private route:Router,public activeRoute:ActivatedRoute,private srvWeb:WebService) {
    this.activeRoute.url.subscribe(value => {
        if(window.location.href.includes("admin")){
          this.esAdmin=true;
        }
    })
    this.srvCompras.obtieneCarrito(null);
    if(this.srvAut.currentUserValue!=null){
      this.srvAut.validar().subscribe((b)=>{
        if(!b){
          this.srvAut.logout();
        }
      },(err)=>{
        this.srvAut.logout();
      })
    }
    this.srvWeb.Whatsapp().subscribe((w)=>{
     
      this.whatsapp=w.Valor;
    })
    
  }
  Salir(){
    this.srvAut.logout();
    this.route.navigate(["/"])
  }
  Cuenta(){
    if(this.srvAut.currentUserValue.ClientesEntity){
      this.route.navigate(['/panel/cliente']);
    }else{
      this.route.navigate(['/panel/prestador'])
    }
  }
}

