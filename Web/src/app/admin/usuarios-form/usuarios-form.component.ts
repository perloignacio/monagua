import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Usuarios } from 'src/app/models/Usuarios.model';
import { UsuariosService } from 'src/app/services/usuarios/usuarios.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-usuarios-form',
  templateUrl: './usuarios-form.component.html',
  styleUrls: ['./usuarios-form.component.scss']
})
export class UsuariosFormComponent implements OnInit {

  Agregar:boolean=true;
  obj:Usuarios;

  constructor(private srvObj:UsuariosService,private srvShared:SharedService,private route:Router) {
    this.obj=this.srvShared.ObjEdit as Usuarios;
      if(this.obj!=null){
        this.Agregar=false;
      }else{
        this.obj=new Usuarios();
      }
        
   }

   Guardar(){
    const form=new FormData();

    if(!this.Agregar){
      form.append("id",this.obj.IdUsuario.toString());
    }else{
      form.append("id","0");
    }
    

    form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
    this.srvObj.AgregarEditar(form).subscribe((band)=>{
      if(band){

        Swal.fire("Ok","La operación se realizó con éxito",'success');
        this.route.navigate(['admin/usuarios'])
      }
    },(err)=>{

      Swal.fire("Upps",err.error.Message,'warning');
    })
  }
  
   Volver(){
    history.back();
  }

  ngOnInit(): void {
  }

}
