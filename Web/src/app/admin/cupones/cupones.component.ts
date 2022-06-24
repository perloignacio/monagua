import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Descuentos } from 'src/app/models/Descuentos.model';
import { CuponesService } from 'src/app/services/cupones/cupones.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-cupones',
  templateUrl: './cupones.component.html',
  styleUrls: ['./cupones.component.scss']
})
export class CuponesComponent implements OnInit {

  ArrObj:Descuentos[]=[];
  page = 1;
  pageSize = 10;
  collectionSize = 0
  OriginalArr:Descuentos[]=[];
  strFiltro="";

  constructor(private srvObj:CuponesService,private srvShared:SharedService,private router:Router,private route:ActivatedRoute) {
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
      || obj.Codigo.toLowerCase().includes(term) 
      || obj.Porcentaje.toString().includes(term)
      || obj.Monto.toString().includes(term)
      || obj.FechaDesde.toString().includes(term)
      || obj.FechaHasta.toString().includes(term)
          
    });
  }
  ngOnInit(): void {
  }

  Borrar(obj:Descuentos){
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
        this.srvObj.borrar(obj.IdDescuento).subscribe((band)=>{
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

  Activar(obj:Descuentos){
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
        this.srvObj.activar(obj.IdDescuento).subscribe((band)=>{
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
  Editar(obj:Descuentos){
    this.srvShared.ObjEdit=obj;
    this.router.navigate(['admin/cuponesForm']);
  }
  Nuevo(){
    this.srvShared.ObjEdit=null;
    this.router.navigate(['admin/cuponesForm']);
  }
}
