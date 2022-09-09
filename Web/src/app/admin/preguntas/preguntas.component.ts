import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Preguntas } from 'src/app/models/Preguntas.model';
import { PreguntasService } from 'src/app/services/preguntas/preguntas.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-preguntas',
  templateUrl: './preguntas.component.html',
  styleUrls: ['./preguntas.component.scss']
})
export class PreguntasComponent implements OnInit {

  ArrObj:Preguntas[]=[];
  page = 1;
  pageSize = 10;
  collectionSize = 0
  OriginalArr:Preguntas[]=[];
  strFiltro="";
  constructor(private srvObj:PreguntasService,private srvShared:SharedService,private router:Router,private route:ActivatedRoute) {
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
      return obj.Pregunta.toLowerCase().includes(term) 
      || obj.Respuesta.toLowerCase().includes(term) 
      || obj.Orden.toString().includes(term)
    });
  }

  ngOnInit(): void {
  }

  Borrar(obj:Preguntas){
    Swal.fire({
      title: "Atención",
      text:"¿Está seguro que desea borrar?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      if (result.isConfirmed) {
        this.srvObj.borrar(obj.IdPregunta).subscribe((band)=>{
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

  Activar(obj:Preguntas){
    Swal.fire({
      title: "Atencion",
      text:"¿Está seguro que desea activar este registro?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      /* Read more about isConfirmed, isDenied below */
      if (result.isConfirmed) {
        this.srvObj.activar(obj.IdPregunta).subscribe((band)=>{
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
  Ver(obj:Preguntas){
    this.srvShared.ObjEdit=obj;
    this.router.navigate(['admin/preguntasForm']);
  }

  Nuevo(){
    this.srvShared.ObjEdit=null;
    this.router.navigate(['admin/preguntasForm']);
  }

}