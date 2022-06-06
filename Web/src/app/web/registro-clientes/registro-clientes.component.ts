import { Component, OnInit } from '@angular/core';
import { Clientes } from 'src/app/models/Clientes.model';
import { Usuarios } from 'src/app/models/Usuarios.model';
import { SharedService } from 'src/app/services/shared/shared.service';
import { Paises } from 'src/app/models/Paises.model';
import { Provincias } from 'src/app/models/Provincias.model';
import { Localidades } from 'src/app/models/Localidades.model';
import { WebService } from 'src/app/services/web/web.service';
import { Router } from '@angular/router';
import { ClientesService } from 'src/app/services/clientes/clientes.service';
import { ThisReceiver } from '@angular/compiler';

@Component({
  selector: 'app-registro-clientes',
  templateUrl: './registro-clientes.component.html',
  styleUrls: ['./registro-clientes.component.scss']
})
export class RegistroClientesComponent implements OnInit {
  obj:Clientes=new Clientes();
  usu:Usuarios=new Usuarios();
  listapaises:Paises[]=[];
  listaprovincias:Provincias[]=[];
  listalocalidades:Localidades[]=[];
  contra:string;
  Agregar:boolean=true;

  constructor(private srvShared:SharedService,private srvWeb:WebService,private route:Router,private srvClientes:ClientesService) { 
    this.srvWeb.Paises().subscribe((paises)=>{
    
      this.listapaises=paises;
      })
    }
    
  onChangePais(e){
    this.srvWeb.Provincias(this.obj.IdPais).subscribe((provincias)=>{
    
      this.listaprovincias=provincias;
      })
  }

  onChangeProvincia(f){
    this.srvWeb.Localidades(this.obj.IdProvincia).subscribe((localidades)=>{
    
      this.listalocalidades=localidades;
      })
  }

  ngOnInit(): void {
     }
  
  
     Registrar(){
      const form=new FormData();
      if(!this.Agregar){
        form.append("id",this.obj.IdCliente.toString());
      }else{
        form.append("id","0");
      }
      this.usu.IdUsuario=this.obj.IdCliente;
      this.usu.Email=this.obj.Email;
      this.usu.Contra=this.obj.Contra;
      this.usu.Nombre=this.obj.Nombre;
      this.usu.Apellido=this.obj.Apellido;
      this.usu.Usuario=this.obj.Email;
      this.obj.IdPais;
      this.obj.IdProvincia;
      this.obj.IdLocalidad;
      form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
      form.append("usuario",this.srvShared.convertToJSON(this.usu).objeto);
      this.srvClientes.Registrar(form).subscribe((band)=>{
        if(band){
                  
        } 
      },(err)=>{

        console.log("Upps",err.error.Message,'Warning');
      })
      
      console.log(this.obj);
      }
  
}