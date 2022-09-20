import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Preguntas } from 'src/app/models/Preguntas.model';
import { PreguntasService } from 'src/app/services/preguntas/preguntas.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';
import * as ClassicEditor from '@ckeditor/ckeditor5-build-classic';
@Component({
  selector: 'app-preguntas-form',
  templateUrl: './preguntas-form.component.html',
  styleUrls: ['./preguntas-form.component.scss']
})
export class PreguntasFormComponent implements OnInit {
  public Editor = ClassicEditor;
  Agregar:boolean=true;
  obj:Preguntas;

  constructor(private srvObj:PreguntasService,private srvShared:SharedService,private route:Router) {
    this.obj=this.srvShared.ObjEdit as Preguntas;
      if(this.obj!=null){
        this.Agregar=false;
      }else{
        this.obj=new Preguntas();
      }
   }

   Guardar(){
    const form=new FormData();

    if(!this.Agregar){
      form.append("id",this.obj.IdPregunta.toString());
    }else{
      form.append("id","0");
    }
    
    form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
    this.srvObj.AgregarEditar(form).subscribe((band)=>{
      if(band){

        Swal.fire("Ok","La operación se realizó con éxito",'success');
        this.route.navigate(['admin/preguntas'])
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