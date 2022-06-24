import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Descuentos } from 'src/app/models/Descuentos.model';
import { CuponesService } from 'src/app/services/cupones/cupones.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-cupones-form',
  templateUrl: './cupones-form.component.html',
  styleUrls: ['./cupones-form.component.scss']
})
export class CuponesFormComponent implements OnInit {

  Agregar:boolean=true;
  obj:Descuentos;

  constructor(private srvObj:CuponesService,private srvShared:SharedService,private route:Router) {
    this.obj=this.srvShared.ObjEdit as Descuentos;
      if(this.obj!=null){
        this.Agregar=false;
      }else{
        this.obj=new Descuentos();
      }
      
   }
  
  Guardar(){
    const form=new FormData();

    if(!this.Agregar){
      form.append("id",this.obj.IdDescuento.toString());
    }else{
      form.append("id","0");
    }
    

    form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
    this.srvObj.AgregarEditar(form).subscribe((band)=>{
      if(band){

        Swal.fire("Ok","La operación se realizó con éxito",'success');
        this.route.navigate(['admin/cupones'])
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