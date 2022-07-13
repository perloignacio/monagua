import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Usuarios } from 'src/app/models/Usuarios.model';
import { UsuariosService } from 'src/app/services/usuarios/usuarios.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-usuarios',
  templateUrl: './usuarios.component.html',
  styleUrls: ['./usuarios.component.scss']
})
export class UsuariosComponent implements OnInit {
  
  ArrObj:Usuarios[]=[];
  page = 1;
  pageSize = 10;
  collectionSize = 0
  OriginalArr:Usuarios[]=[];
  strFiltro="";
  constructor(private srvObj:UsuariosService,private srvShared:SharedService,private router:Router,private route:ActivatedRoute) {
    this.cargar()
  }

  cargar(){
    this.route.params.subscribe(val => {
      
      
      this.srvObj.todosAdmin().subscribe((lista)=>{
        this.OriginalArr=lista;
        this.collectionSize=this.OriginalArr.length;
        this.refreshData();
      })
    })
  }
  refreshData(){
    this.ArrObj=this.OriginalArr.slice((this.page - 1) * this.pageSize, (this.page - 1) * this.pageSize + this.pageSize);
  }
  Filtro(){
    
    this.ArrObj=this.OriginalArr.filter(obj => {
      const term = this.strFiltro.toLowerCase();
      return obj.Apellido.toLowerCase().includes(term) 
      || obj.Nombre.toLowerCase().includes(term) 
      || obj.Email.toLowerCase().includes(term)
      || obj.Usuario.toLowerCase().includes(term)
      || obj.IdCliente.toString().includes(term)
      || obj.IdPrestador.toString().includes(term)    
    });
  }
  ngOnInit(): void {
  }
  Borrar(obj:Usuarios){
    Swal.fire({
      title: "Atención",
      text:"¿Está seguro que desea borrar?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      if (result.isConfirmed) {
        this.srvObj.borrar(obj.IdUsuario).subscribe((band)=>{
          if(band){
            this.cargar();
            Swal.fire("Ok","Se borró el registro",'success');

          }
        },(err)=>{
          this.cargar();
          Swal.fire("Upps",err.error.Message,'warning');
        })
      };
    });

  }

  Activar(obj:Usuarios){
    Swal.fire({
      title: "Atencion",
      text:"¿Está seguro que desea activar este registro?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      if (result.isConfirmed) {
        this.srvObj.activar(obj.IdUsuario).subscribe((band)=>{
          if(band){
            this.cargar();
            Swal.fire("Ok","Se activó el registro",'success');

          }
        },(err)=>{
          this.cargar();
          Swal.fire("Upps",err.error.Message,'warning');
        })
      };
    });

  }
  Ver(obj:Usuarios){
    this.srvShared.ObjEdit=obj;
    this.router.navigate(['admin/usuariosForm']);
  }

  Nuevo(){
    this.srvShared.ObjEdit=null;
    this.router.navigate(['admin/usuariosForm']);
  }
}
