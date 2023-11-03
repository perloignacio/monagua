import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { objBlanqueo } from 'src/app/models/Blanqueo.model';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { Usuarios } from 'src/app/models/Usuarios.model';
import Swal from 'sweetalert2';
import { UsuariosService } from 'src/app/services/usuarios/usuarios.service';

@Component({
  selector: 'app-cambio-contra',
  templateUrl: './cambio-contra.component.html',
  styleUrls: ['./cambio-contra.component.scss']
})
export class CambioContraComponent implements OnInit {

  contra:string;
  contraNew:string;
  nContraNew:string;
  passOK: boolean;
  
  constructor(private route:ActivatedRoute,private router:Router,private srvUsuario:UsuariosService,private srvShared:SharedService,private srvAuth:AuthenticationService) { 
    
  }

  ngOnInit(): void {
  }
  
  Enviar(){
    if(!this.passOK){
      return
    }
      this.srvUsuario.CambiarContra(this.contra,this.contraNew,this.nContraNew).subscribe((band)=>{

        if (band){
          Swal.fire("Ok","Su contraseña se actualizó correctamente","success").then((res)=>{
            if(this.srvAuth.currentUserValue.ClientesEntity){
              this.router.navigate(["/panel/cliente"])
            }else{
              this.router.navigate(["/panel/prestador"])
            }
            
          });
        }else{
         Swal.fire("Oops","Ocurrió un error, por favor intente nuevemente en unos minutos","error");
        }
       },(err)=>{
        Swal.fire("Upps",err.error.Message,"warning"); 
       });
    
  }

  passValidate(contra){
    const regex = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$/;
       if (!regex.test(contra)) {
        this.passOK=false;
         }else{
          this.passOK=true;
         }
    
  }
  
}
