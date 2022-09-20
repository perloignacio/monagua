import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Actividades } from 'src/app/models/Actividades.model';
import { ActividadesService } from 'src/app/services/actividades/actividades.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { ComentariosComponent } from 'src/app/shared/comentarios/comentarios.component';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-actividades',
  templateUrl: './actividades.component.html',
  styleUrls: ['./actividades.component.scss']
})
export class ActividadesComponent implements OnInit {

  ArrObj:Actividades[]=[];
  page = 1;
  pageSize = 10;
  collectionSize = 0
  OriginalArr:Actividades[]=[];
  strFiltro="";
  constructor(private srvShared:SharedService,private srvActividad:ActividadesService,private route:Router,private modal: NgbModal) {
    this.cargar();
  }
  refreshData(){
    this.ArrObj=this.OriginalArr.slice((this.page - 1) * this.pageSize, (this.page - 1) * this.pageSize + this.pageSize);
  }
  Filtro(){
    
    this.ArrObj=this.OriginalArr.filter(obj => {
      const term = this.strFiltro.toLowerCase();
      return obj.Nombre.toLowerCase().includes(term) 
      || obj.Nombre.toLowerCase().includes(term) 
      || obj.PrestadoresEntity.NombreFantasia.toLowerCase().includes(term) 
    
      
          
    });
  }
  cargar(){
    this.srvActividad.Admintodas().subscribe((la)=>{
     
      this.OriginalArr=la;
      this.collectionSize=this.OriginalArr.length;
      this.refreshData();
    })
  }
  Editar(obj:Actividades){
    this.srvShared.ObjEdit=obj;
    this.route.navigate(['panel/prestador/actividad']);
  }
  Comentarios(obj:Actividades){
    const modalRef = this.modal.open(ComentariosComponent,{ size: 'lg' });
    modalRef.componentInstance.Actividades = obj;
    modalRef.componentInstance.showmore = false;
    modalRef.componentInstance.premiteResponder = false;
  }
  Horarios(obj:Actividades){
    this.srvShared.ObjEdit=obj;
    this.route.navigate(['/panel/prestador/actividad/'+obj.IdActividad.toString()+'/horarios'])
  }
  Borrar(obj:Actividades){
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
        this.srvActividad.borrar(obj.IdActividad).subscribe((band)=>{
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

  Activar(obj:Actividades){
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
        this.srvActividad.activar(obj.IdActividad).subscribe((band)=>{
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

  ngOnInit(): void {
  }

}
