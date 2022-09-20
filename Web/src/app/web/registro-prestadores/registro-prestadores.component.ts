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

  onFileChange(event) {
    this.Archivos=event.target.files;

  }

  ngOnInit(): void {
  }

  Registrar(){
    const form=new FormData();
    if(!this.Agregar){
      form.append("id",this.obj.IdPrestador.toString());
    }else{
      form.append("id","0");
    }
    this.obj.Politicas=true;
    this.usu.Usuario=this.obj.Email;
    
    if(this.Archivos!=null){
      for(let i=0;i<=this.Archivos.length-1;i++){
        form.append("Archivos[]", this.Archivos[i],this.Archivos[i].name);
      }
    }
    form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
    form.append("usuario",this.srvShared.convertToJSON(this.usu).objeto);
    
    this.srvPrestadores.Registrar(form).subscribe((band)=>{
      if(band){
        Swal.fire("OK","El registro se realizo correctamente",'success');        
      } 
    },(err)=>{

      Swal.fire("Upps",err.error.Message,'warning');
    })
    
    
  }

}
