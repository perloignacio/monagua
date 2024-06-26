import { Component, OnChanges, OnInit } from '@angular/core';
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
export class ActividadesComponent implements OnInit,OnChanges {
  
  ArrObj:Actividades[]=[];
  constructor(private srvShared:SharedService,private srvActividad:ActividadesService,private route:Router,private modal: NgbModal) {
    this.cargar();
  }
  
  cargar(){
    this.srvActividad.byPrestador().subscribe((la)=>{
      this.ArrObj=la;
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
    modalRef.componentInstance.premiteResponder = true;
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

  Nueva(){
    this.srvShared.ObjEdit=null;
    this.route.navigate(['panel/prestador/actividad']);
  }
  ngOnChanges() {
   
  }

  
  ngOnInit(): void {
  }

}
