import { Component, OnInit } from '@angular/core';
import { Prestadores } from 'src/app/models/Prestadores.model';
import { Usuarios } from 'src/app/models/Usuarios.model';
import { SharedService } from 'src/app/services/shared/shared.service';
import { Paises } from 'src/app/models/Paises.model';
import { Provincias } from 'src/app/models/Provincias.model';
import { Localidades } from 'src/app/models/Localidades.model';
import { WebService } from 'src/app/services/web/web.service';
import { Router } from '@angular/router';
import { PrestadoresService } from 'src/app/services/prestadores/prestadores.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-registro-prestadores',
  templateUrl: './registro-prestadores.component.html',
  styleUrls: ['./registro-prestadores.component.scss']
})
export class RegistroPrestadoresComponent implements OnInit {
  obj:Prestadores=new Prestadores();
  usu:Usuarios=new Usuarios();
  listapaises:Paises[]=[];
  listaprovincias:Provincias[]=[];
  listalocalidades:Localidades[]=[];
  contra:string;
  Agregar:boolean=true;
  Archivos:FileList;
  Certi:FileList;
  passOK:boolean = true;
  constructor(private srvShared:SharedService,private srvWeb:WebService,private route:Router,private srvPrestadores:PrestadoresService) { 
    this.srvWeb.Paises().subscribe((paises)=>{
    
      this.listapaises=paises;
      })
    }
    
  onChangePais(d){
    this.srvWeb.Provincias(this.obj.IdPais).subscribe((provincias)=>{
    
      this.listaprovincias=provincias;
      })
  }

  onChangeProvincia(u){
    this.srvWeb.Localidades(this.obj.IdProvincia).subscribe((localidades)=>{
    
      this.listalocalidades=localidades;
      })
  }

  onFileChange(event,tipo:string) {
    if(tipo!='certi'){
      let files = event.target.files;
      let format:string[]=["pdf","jpg","png","jpeg","tiff"];
      let band=true;
      for( var file of files){
        console.log(file.size)
        var ext = file.name.substring(file.name.lastIndexOf('.') + 1).toLowerCase();
        
        if(!format.includes(ext)){
          Swal.fire("Formato incorrecto","Solo puede adjuntar archivos en formato "+format.toString(),'error');
          band=false;
        }
        if(file.size>4000000){
          Swal.fire("Peso máximo excedido","Solo puede adjuntar archivos hasta 4MB",'error');
          band=false;
        }
      }
      if(band){
        this.Archivos=event.target.files;
        
      }
     
    }else{
      let files = event.target.files;
      let format:string[]=["pdf"];
      let band=true;
      for( var file of files){
        var ext = file.name.substring(file.name.lastIndexOf('.') + 1).toLowerCase();
        
        if(!format.includes(ext)){
          Swal.fire("Formato incorrecto","Solo puede adjuntar archivos en formato "+format.toString(),'error');
          band=false;
        }
        if(file.size>4000000){
          Swal.fire("Peso máximo excedido","Solo puede adjuntar archivos hasta 4MB",'error');
          band=false;
        }
      }
      if(band){
        this.Certi=event.target.files;
        
      }
      
    }
    

  }

  ngOnInit(): void {
  }

  Registrar(){
    if(!this.passOK){
      return
    }
    const form=new FormData();
    if(!this.Agregar){
      form.append("id",this.obj.IdPrestador.toString());
    }else{
      form.append("id","0");
    }
    this.obj.Politicas=true;
    this.usu.Usuario=this.obj.Email;
    
    if(this.Archivos){
      for(let i=0;i<=this.Archivos.length-1;i++){
        form.append("Archivos[]", this.Archivos[i],this.Archivos[i].name);
      }
    }
    if(this.Certi){
      for(let i=0;i<=this.Certi.length-1;i++){
        form.append("Certi[]", this.Certi[i],this.Certi[i].name);
      }
    }
    form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
    form.append("usuario",this.srvShared.convertToJSON(this.usu).objeto);
    
    this.srvPrestadores.Registrar(form).subscribe((band)=>{
      if(band){
        Swal.fire("OK","El registro se realizó correctamente, vamos a procesar su solicitud y en 48 horas puede ingresar al sitio web",'success');        
      } 
    },(err)=>{

      Swal.fire("Upps",err.error.Message,'warning');
    })
    
    
  }
passValidate(contra){
  const regex = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$/;
     if (!regex.test(contra)) {
      this.passOK=false;
       }else{
        this.passOK=true;
       }
  
}

  validateFormat(event) {
    let key;
    if (event.type === 'paste') {
      key = event.clipboardData.getData('text/plain');
    } else {
      key = event.keyCode;
      key = String.fromCharCode(key);
    }
    const regex = /[0-9]|\./;
     if (!regex.test(key)) {
      event.returnValue = false;
       if (event.preventDefault) {
        event.preventDefault();
       }
     }
    }

}
