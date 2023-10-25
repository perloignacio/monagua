import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Clientes } from 'src/app/models/Clientes.model';
import { Localidades } from 'src/app/models/Localidades.model';
import { Paises } from 'src/app/models/Paises.model';
import { Prestadores } from 'src/app/models/Prestadores.model';
import { Provincias } from 'src/app/models/Provincias.model';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import { ClientesService } from 'src/app/services/clientes/clientes.service';
import { PrestadoresService } from 'src/app/services/prestadores/prestadores.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { WebService } from 'src/app/services/web/web.service';
import { environment } from 'src/environments/environment';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-prestadores',
  templateUrl: './prestadores.component.html',
  styleUrls: ['./prestadores.component.scss']
})
export class PrestadoresComponent implements OnInit {
  Archivos:FileList;
  presta:Prestadores=new Prestadores();
  cli:Clientes=new Clientes();
  listalocalidades:Localidades[]=[];
  listaprovincias:Provincias[]=[];
  listapaises:Paises[]=[];
  algo2:Prestadores=new Prestadores();
  assets:string=environment.assets;
  constructor(private srvAut:AuthenticationService,private router:Router,private srvWeb:WebService,private srvShared:SharedService,private srvPrestador:PrestadoresService) { 
    if(this.srvAut.currentUserValue){
    
      
      this.srvWeb.Paises().subscribe((lp)=>{
        this.presta=this.srvAut.currentUserValue.PrestadoresEntity;
        
        this.listapaises=lp;
        this.cargaProvincias()
        this.cargaLocalidades()
        
      })
      
    }else{
      this.router.navigate(["/"])
    }
    
    
  }

  onFileChange(event) {
    this.Archivos=event.target.files;

  }

  ngOnInit(): void {
    
  }

  onChangePais(e){
    this.cargaProvincias();
  }

  cargaProvincias(){
    this.srvWeb.Provincias(this.presta.IdPais).subscribe((provincias)=>{
      this.listaprovincias=provincias;
    })  }

  cargaLocalidades(){
    this.srvWeb.Localidades(this.presta.IdProvincia).subscribe((localidades)=>{
      this.listalocalidades=localidades;
      //this.obj.IdLocalidad=localidades[0].IdLocalidad;
    })
  }
  onChangeProvincia(e){
    this.cargaLocalidades();
  }
  Registrar(){
    const form=new FormData();
    
       
    form.append("obj",this.srvShared.convertToJSON(this.presta).objeto);
    if(this.Archivos!=null){
      for(let i=0;i<=this.Archivos.length-1;i++){
        form.append("Archivos[]", this.Archivos[i],this.Archivos[i].name);
      }
    }
    this.srvPrestador.Editar(form).subscribe((pre)=>{
      if(pre){
        
        this.srvAut.currentUserValue.PrestadoresEntity=pre;
        localStorage.setItem('userMonagua', JSON.stringify(this.srvAut.currentUserValue));
        Swal.fire("Ok","Su perfil se actualizó correctamente",'success');
        
      } 
    },(err)=>{

      Swal.fire("Upps",err.error.Message,'warning');
    })
  }
}

