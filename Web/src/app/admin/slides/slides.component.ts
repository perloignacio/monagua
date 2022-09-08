import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Slides } from 'src/app/models/Slides.model';
import { SharedService } from 'src/app/services/shared/shared.service';
import { SlidesService } from 'src/app/services/slides/slides.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-slides',
  templateUrl: './slides.component.html',
  styleUrls: ['./slides.component.scss']
})

export class SlidesComponent implements OnInit { ArrObj:Slides[]=[];
  page = 1;
  pageSize = 10;
  collectionSize = 0
  OriginalArr:Slides[]=[];
  strFiltro="";
  constructor(private srvObj:SlidesService,private srvShared:SharedService,private router:Router,private route:ActivatedRoute) {
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
      return obj.Titulo.toLowerCase().includes(term) 
      || obj.Descripcion.toLowerCase().includes(term) 
      || obj.Foto.toLowerCase().includes(term)
      || obj.Link.toLowerCase().includes(term)
      
          
    });
  }
  ngOnInit(): void {
  }
  Borrar(obj:Slides){
    Swal.fire({
      title: "Atención",
      text:"¿Está seguro que desea borrar?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      if (result.isConfirmed) {
        this.srvObj.borrar(obj.IdSlide).subscribe((band)=>{
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

  Activar(obj:Slides){
    Swal.fire({
      title: "Atencion",
      text:"¿Está seguro que desea activar este registro?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      if (result.isConfirmed) {
        this.srvObj.activar(obj.IdSlide).subscribe((band)=>{
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
  Ver(obj:Slides){
    this.srvShared.ObjEdit=obj;
    this.router.navigate(['admin/slidesForm']);
  }
  
  Nuevo(){
    this.srvShared.ObjEdit=null;
    this.router.navigate(['admin/slidesForm']);
  }
}

