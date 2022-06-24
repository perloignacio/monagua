import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { objBlanqueo } from 'src/app/models/Blanqueo.model';
import { Usuarios } from 'src/app/models/Usuarios.model';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-blanqueo',
  templateUrl: './blanqueo.component.html',
  styleUrls: ['./blanqueo.component.scss']
})
export class BlanqueoComponent implements OnInit {
  obj:objBlanqueo=new objBlanqueo();
  nContra:string;
  constructor(private route:ActivatedRoute,private router:Router,private srvUsuario:AuthenticationService,private srvShared:SharedService) { 
    this.obj.Hash=this.route.snapshot.params["hash"];
  }

  ngOnInit(): void {
  }
  Enviar(){
    if(this.obj.Contra==this.nContra){
      const form=new FormData();
      form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
      this.srvUsuario.Blanqueo(form).subscribe((band)=>{

        if (band){
          Swal.fire("Ok","Su contraseña se actualizo correctamente","success").then((res)=>{
            this.router.navigate(["/login"])
          });
        }else{
         Swal.fire("Oops","Ocurrio un error, por favor intente nuevemente en unos minutos","error");
        }
       });
    }else{
      Swal.fire("Upps","Las contraseñas no coinciden","warning");
    }
  }
}
