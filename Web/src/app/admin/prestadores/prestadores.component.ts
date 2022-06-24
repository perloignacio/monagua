import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Prestadores } from 'src/app/models/Prestadores.model';
import { PrestadoresService } from 'src/app/services/prestadores/prestadores.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { environment } from 'src/environments/environment';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-prestadores',
  templateUrl: './prestadores.component.html',
  styleUrls: ['./prestadores.component.scss']
})
export class PrestadoresComponent implements OnInit {

  ArrObj:Prestadores[]=[];
  page = 1;
  pageSize = 10;
  collectionSize = 0
  OriginalArr:Prestadores[]=[];
  strFiltro="";
  constructor(private srvObj:PrestadoresService,private srvShared:SharedService,private router:Router,private route:ActivatedRoute) { 
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
      return obj.RazonSocial.toLowerCase().includes(term) 
      || obj.NombreFantasia.toLowerCase().includes(term) 
      || obj.Email.toLowerCase().includes(term)
      || obj.Telefono.toString().includes(term)
      
          
    });
  }
  ngOnInit(): void {
  }

  Borrar(obj:Prestadores){
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
        this.srvObj.borrar(obj.IdPrestador).subscribe((band)=>{
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

  Activar(obj:Prestadores){
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
        this.srvObj.activar(obj.IdPrestador).subscribe((band)=>{
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
  Ver(obj:Prestadores){
    this.srvShared.ObjEdit=obj;
    this.router.navigate(['admin/prestadoresForm']);
  }

  
}
