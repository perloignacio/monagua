import { Component, OnChanges, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Actividades } from 'src/app/models/Actividades.model';
import { Categorias } from 'src/app/models/Categorias.model';
import { CategoriasService } from 'src/app/services/categorias/categorias.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';
import { FileUploader, FileFilter, FileManagerInterface, FileManager } from '@uniprank/ngx-file-uploader';
import { ActividadesService } from 'src/app/services/actividades/actividades.service';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment';
import * as ClassicEditor from '@ckeditor/ckeditor5-build-classic';
import { WebService } from 'src/app/services/web/web.service';
import { Provincias } from 'src/app/models/Provincias.model';
import { Localidades } from 'src/app/models/Localidades.model';

@Component({
  selector: 'app-actividad',
  templateUrl: './actividad.component.html',
  styleUrls: ['./actividad.component.scss']
})
export class ActividadComponent implements OnInit {
  public Editor = ClassicEditor;
  obj:Actividades=new Actividades();
  listaprovincias:Provincias[]=[];
  listalocalidades:Localidades[]=[]
  Categorias:Categorias[]=[];
  dataSource: any[] = [];
  archivos:any[]=[];
  fotosCargadas:any[]=[];
  assets:string=environment.assets;
  fileInput = new FormControl();
  Agregar:boolean=true;
  public uploader: FileUploader;
  constructor(private srvCat:CategoriasService,private srvShared:SharedService,private srvActividad:ActividadesService,private route:Router,private srvWeb:WebService) {
    this.srvCat.todas().subscribe((clist)=>{
      this.Categorias=clist;
      this.obj=this.srvShared.ObjEdit as Actividades;
      if(this.obj!=null){
       this.Agregar=false;
       this.fotosCargadas=this.obj.Fotos.split(",");
      }else{
        this.obj=new Actividades();
      }
      this.cargaProvincias();
    })

    this.uploader = new FileUploader({
      url: '',
      removeBySuccess: false,
      autoUpload: false,
      filters: [new FileFilter('only:JPG/PNG/GIF', new RegExp('image/jpeg|image/png|image/gif'), 'type')]
    });
  }

  cargaProvincias(){
    this.srvWeb.Provincias(1).subscribe((provincias)=>{
      this.listaprovincias=provincias;
      let idprov= this.Agregar ? this.listaprovincias[0].IdProvincia: this.obj.IdProvincia;
      this.obj.IdProvincia=idprov;
      this.cargaLocalidades(false)
    })  
  }

  onChangeProvincia(e){
    this.cargaLocalidades(true);
  }
  cargaLocalidades(cambio:boolean){
    this.srvWeb.Localidades(this.obj.IdProvincia).subscribe((localidades)=>{
      this.listalocalidades=localidades;
      let idloc=cambio ? this.listalocalidades[0].IdLocalidad: this.obj.IdLocalidad;
      this.obj.IdLocalidad=idloc;
      //this.obj.IdLocalidad=localidades[0].IdLocalidad;
    })
  }

  ngOnChanges() {
    this.obtenerArchivosAportados();
  }
  borrarCargado(foto){
    let index=this.fotosCargadas.findIndex(f=>f==foto);
    if(index>=0){
      this.fotosCargadas.splice(index,1);
    }
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
    
    this.obj.Fotos=this.fotosCargadas.join(",");
    
    this.uploader.queueObs.forEach((f)=>{
      form.append("Archivos[]", f.element,f.object.name);  
    })
    
    
    form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
    
    
    this.srvActividad.AgregarEditar(form).subscribe((b)=>{
      if(b){
        Swal.fire("Ok","La actividad se registró correctamente, ahora indique los horarios",'success');        
        this.route.navigate(['/panel/prestador/actividad/'+b.IdActividad.toString()+'/horarios'])
      } 
    },(err)=>{

      Swal.fire("Upps",err.error.Message,'warning');
    })
  }
  ngOnInit(): void {
  }

}
