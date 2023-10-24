import { Component, Input, OnInit } from '@angular/core';
import { Usuarios } from 'src/app/models/Usuarios.model';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-recuperar',
  templateUrl: './recuperar.component.html',
  styleUrls: ['./recuperar.component.scss']
})
export class RecuperarComponent implements OnInit {
  obj:Usuarios=new Usuarios();
  org:string="";
  @Input() set origen(value: string) {
    this.org = value;
    
  }
  constructor(private auth:AuthenticationService) { }

  ngOnInit(): void {
  }
  Enviar(){
    this.auth.Recuperar(this.obj.Usuario).subscribe((b)=>{
      if(b){
        Swal.fire("Atención","Va a recibir un correo electronico para poder realizar el blanqueo de su contraseña",'success');
      }
    },(err)=>{

      Swal.fire("Upps",err.error.Message,'warning');
    })
  }
}
