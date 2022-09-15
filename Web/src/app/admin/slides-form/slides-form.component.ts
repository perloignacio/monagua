import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Slides } from 'src/app/models/Slides.model';
import { SharedService } from 'src/app/services/shared/shared.service';
import { SlidesService } from 'src/app/services/slides/slides.service';
import { environment } from 'src/environments/environment';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-slides-form',
  templateUrl: './slides-form.component.html',
  styleUrls: ['./slides-form.component.scss']
})
export class SlidesFormComponent implements OnInit {
  Archivos:FileList;
  Agregar:boolean=true;
  obj:Slides;
  assets:string=environment.assets;
  constructor(private srvObj:SlidesService,private srvShared:SharedService,private route:Router) {
    this.obj=this.srvShared.ObjEdit as Slides;
      if(this.obj!=null){
        this.Agregar=false;
      }else{
        this.obj=new Slides();
      }
   }

   onFileChange(event) {
    this.Archivos=event.target.files;

  }

   Guardar(){
    const form=new FormData();
    if(this.Archivos!=null){
      for(let i=0;i<=this.Archivos.length-1;i++){
        form.append("Archivos[]", this.Archivos[i],this.Archivos[i].name);
      }
    }
    if(!this.Agregar){
      form.append("id",this.obj.IdSlide.toString());
    }else{
      form.append("id","0");
    }
    
    form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
    this.srvObj.AgregarEditar(form).subscribe((band)=>{
      if(band){

        Swal.fire("Ok","La operación se realizó con éxito",'success');
        this.route.navigate(['admin/slides'])
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