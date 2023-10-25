import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { Usuarios } from 'src/app/models/Usuarios.model';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import { ComprasService } from 'src/app/services/compras/compras.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  obj:Usuarios=new Usuarios();
  org:string="";
  @Input() set origen(value: string) {
    this.org = value;
    
  }
  constructor(private auth:AuthenticationService,private route:Router,private srvCompras:ComprasService) { }

  ngOnInit(): void {
  }
  Enviar(){

    
    this.auth.login(this.obj.Usuario,this.obj.Contra).subscribe((u)=>{

      if(u.ClientesEntity!=null){
        if(this.org=="checkout"){
          this.srvCompras.setCliente(u.ClientesEntity);
          this.srvCompras.ActualizaCarrito().subscribe((c)=>{
            this.srvCompras.setCarrito(c);
          })
          this.route.navigate(['/checkout'])
        }else{
          this.route.navigate(['/panel/cliente'])
        }
        
      }else{
        if(u.PrestadoresEntity!=null){
          this.route.navigate(['/panel/prestador'])
        }else{
          this.route.navigate(['/admin'])
        }
      }
      
    },(err)=>{

      Swal.fire("Upps",err.error.Message,'warning');
    })
  }
}
