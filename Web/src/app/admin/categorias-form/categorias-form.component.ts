import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { Categorias } from 'src/app/models/Categorias.model';
import { CategoriasService } from 'src/app/services/categorias/categorias.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-categorias-form',
  templateUrl: './categorias-form.component.html',
  styleUrls: ['./categorias-form.component.scss']
})
export class CategoriasFormComponent implements OnInit {

  
  Agregar:boolean=true;
  obj:Categorias;
  
  constructor(private srvObj:CategoriasService,private srvShared:SharedService,private route:Router) {
    this.obj=this.srvShared.ObjEdit as Categorias;
      if(this.obj!=null){
        this.Agregar=false;
      }else{
        this.obj=new Categorias();
      }
      
  
      
   }
  
  Guardar(){
    const form=new FormData();

    if(!this.Agregar){
      form.append("id",this.obj.IdCategoria.toString());
    }else{
      form.append("id","0");
    }
    

    form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
    this.srvObj.AgregarEditar(form).subscribe((band)=>{
      if(band){

        Swal.fire("Ok","La operación se realizo con exito",'success');
        this.route.navigate(['admin/categorias'])
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
