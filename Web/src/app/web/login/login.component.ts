import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { Usuarios } from 'src/app/models/Usuarios.model';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  obj:Usuarios=new Usuarios();
  constructor(private auth:AuthenticationService,private route:Router) { }

  ngOnInit(): void {
  }
  Enviar(){
    this.auth.login(this.obj.Usuario,this.obj.Contra).subscribe((u)=>{
      if(u.ClientesEntity!=null){
        this.route.navigate(['/panel/cliente'])
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
