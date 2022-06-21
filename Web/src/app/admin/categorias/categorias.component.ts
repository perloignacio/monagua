import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Categorias } from 'src/app/models/Categorias.model';
import { CategoriasService } from 'src/app/services/categorias/categorias.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-categorias',
  templateUrl: './categorias.component.html',
  styleUrls: ['./categorias.component.scss']
})
export class CategoriasComponent implements OnInit {

  ArrObj:Categorias[]=[];
  page = 1;
  pageSize = 10;
  collectionSize = 0
  OriginalArr:Categorias[]=[];
  strFiltro="";
  constructor(private srvObj:CategoriasService,private srvShared:SharedService,private router:Router,private route:ActivatedRoute) {
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
      return obj.Nombre.toLowerCase().includes(term) 
      
      
          
    });
  }
  ngOnInit(): void {
  }
  Borrar(obj:Categorias){
    Swal.fire({
      title: "Atención",
      text:"¿Está seguro que desea borrar?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      /* Read more about isConfirmed, isDenied below */
      if (result.isConfirmed) {
        this.srvObj.borrar(obj.IdCategoria).subscribe((band)=>{
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

  Activar(obj:Categorias){
    Swal.fire({
      title: "Atención",
      text:"¿Está seguro que desea activar este registro?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      /* Read more about isConfirmed, isDenied below */
      if (result.isConfirmed) {
        this.srvObj.activar(obj.IdCategoria).subscribe((band)=>{
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
  Editar(obj:Categorias){
    this.srvShared.ObjEdit=obj;
    this.router.navigate(['admin/categoriasForm']);
  }
  Nuevo(){
    this.srvShared.ObjEdit=null;
    this.router.navigate(['admin/categoriasForm']);
  }
}

