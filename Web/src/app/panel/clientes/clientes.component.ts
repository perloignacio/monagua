import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Clientes } from 'src/app/models/Clientes.model';
import { Localidades } from 'src/app/models/Localidades.model';
import { Paises } from 'src/app/models/Paises.model';
import { Provincias } from 'src/app/models/Provincias.model';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import { ClientesService } from 'src/app/services/clientes/clientes.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { WebService } from 'src/app/services/web/web.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.scss']
})
export class ClientesComponent implements OnInit {
  obj:Clientes=new Clientes();
  listalocalidades:Localidades[]=[];
  listaprovincias:Provincias[]=[];
  listapaises:Paises[]=[];
  constructor(private srvAut:AuthenticationService,private router:Router,private srvWeb:WebService,private srvShared:SharedService,private srvClientes:ClientesService) { 
    if(this.srvAut.currentUserValue){
      this.srvWeb.Paises().subscribe((paises)=>{
        this.obj=this.srvAut.currentUserValue.ClientesEntity;
        this.listapaises=paises;
        this.cargaProvincias()
        this.cargaLocalidades()
      })
      
    }else{
      this.router.navigate(["/"])
    }
    
  }

  ngOnInit(): void {
  }

  onChangePais(e){
    this.cargaProvincias();
  }

  cargaProvincias(){
    this.srvWeb.Provincias(this.obj.IdPais).subscribe((provincias)=>{
      this.listaprovincias=provincias;
    })
  }

  cargaLocalidades(){
    this.srvWeb.Localidades(this.obj.IdProvincia).subscribe((localidades)=>{
      this.listalocalidades=localidades;
      this.obj.IdLocalidad=localidades[0].IdLocalidad;
    })
  }
  onChangeProvincia(e){
    this.cargaLocalidades();
  }
  Registrar(){
    const form=new FormData();
    
    console.log("ad");
    
    form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
    
    this.srvClientes.Editar(form).subscribe((cli)=>{
      if(cli){
        this.srvAut.currentUserValue.ClientesEntity=cli;
        localStorage.setItem('userMonagua', JSON.stringify(this.srvAut.currentUserValue));
        Swal.fire("Ok","Su perfil se actualizó correctamente",'success');
        
      } 
    },(err)=>{

      Swal.fire("Upps",err.error.Message,'warning');
    })
  }
}
