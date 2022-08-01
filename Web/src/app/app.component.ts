import { Component } from '@angular/core';
import { Paises } from './models/Paises.model';
import { Provincias } from './models/Provincias.model';
import { Localidades } from './models/Localidades.model';
import { WebService } from './services/web/web.service';
import { ComprasService } from './services/compras/compras.service';
import { AuthenticationService } from './services/authentication/authentication.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Web';
  
  constructor(private srvCompras:ComprasService,private srvAut:AuthenticationService) {
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
    
  }
}

