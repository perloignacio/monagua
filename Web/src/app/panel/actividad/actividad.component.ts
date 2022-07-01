import { Component, OnChanges, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Actividades } from 'src/app/models/Actividades.model';
import { Categorias } from 'src/app/models/Categorias.model';
import { CategoriasService } from 'src/app/services/categorias/categorias.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';
import { FileUploader, FileFilter, FileManagerInterface } from '@uniprank/ngx-file-uploader';
import { ActividadesService } from 'src/app/services/actividades/actividades.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-actividad',
  templateUrl: './actividad.component.html',
  styleUrls: ['./actividad.component.scss']
})
export class ActividadComponent implements OnInit {

  obj:Actividades=new Actividades();
  Categorias:Categorias[]=[];
  dataSource: any[] = [];
  archivos:any[]=[];
  fileInput = new FormControl();
  Agregar:boolean=true;
  public uploader: FileUploader;
  constructor(private srvCat:CategoriasService,private srvShared:SharedService,private srvActividad:ActividadesService,private route:Router) {
    this.srvCat.todas().subscribe((clist)=>{
      this.Categorias=clist;
    })

    this.uploader = new FileUploader({
      url: '',
      removeBySuccess: false,
      autoUpload: false,
      filters: [new FileFilter('only:JPG/PNG/GIF', new RegExp('image/jpeg|image/png|image/gif'), 'type')]
  });
  }

  ngOnChanges() {
    this.obtenerArchivosAportados();
  }

  obtenerArchivosAportados() {
    this.dataSource=this.obj.Fotos.split(",");
  }
  archivoIngresado(event: any) {
    var file = <File>event;
    this.archivos.push(file);
    
  }

  
  

  //aclaración: elimina el archivo aportado ANTES de confirmar el aporte. NO se puede eliminar el archivo una vez ya aportado
  borrar(_file:FileManagerInterface) {
    
    this.uploader.removeFile(_file);
  }
  Guardar(){
    const form=new FormData();
    if(!this.Agregar){
      form.append("id",this.obj.IdActividad.toString());
    }else{
      form.append("id","0");
    }

    this.uploader.queueObs.forEach((f)=>{
      form.append("Archivos[]", f.element,f.object.name);  
    })
    
    
    form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
    
    
    this.srvActividad.AgregarEditar(form).subscribe((b)=>{
      if(b){
        Swal.fire("Ok","La actividad se registro correctamente, ahora indique los horarios",'success');        
        this.route.navigate(['/panel/prestador/actividad/'+b.IdActividad.toString()+'/horarios'])
      } 
    },(err)=>{

      console.log("Upps",err.error.Message,'Warning');
    })
  }
  ngOnInit(): void {
  }

}
