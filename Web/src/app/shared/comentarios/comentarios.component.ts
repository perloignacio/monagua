import { Component, Input, OnInit } from '@angular/core';
import { NgbActiveModal, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Actividades } from 'src/app/models/Actividades.model';
import { Calificaciones } from 'src/app/models/Calificaciones.model';
import { CalificacionesService } from 'src/app/services/calificaciones/calificaciones.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-comentarios',
  templateUrl: './comentarios.component.html',
  styleUrls: ['./comentarios.component.scss']
})
export class ComentariosComponent implements OnInit {
  obj:Actividades;
  orden:string='positivas';
  more:boolean=true;
  responder:boolean=false;
  calificaciones:Calificaciones[]=[];
  idcd:number;
  @Input()
  set Actividades(value: Actividades) {
    this.obj=value;
    this.cargaCalificaciones()
  }

  @Input()
  set showmore(value: boolean) {
    this.more=value;
    
  }
  @Input()
  set IdCompraDetalle(value: number) {
    this.idcd=value;
    
  }
  

  @Input()
  set premiteResponder(value: boolean) {
    this.responder=value;
    
  }
  constructor(private srvCali:CalificacionesService,private modal: NgbModal,private ActiveModal:NgbActiveModal) { 
    
  }

  Responder(c:Calificaciones){
    this.srvCali.responder(c.IdCalificacion,c.Respuesta).subscribe((b)=>{
      Swal.fire("Ok","La respuesta se cargo correctamente",'success');
      this.cargaCalificaciones();
    },(err)=>{
      Swal.fire("Upps",err.error.Message,'warning');
    })
  }

  cargaCalificaciones(){
    this.srvCali.ByActividad(this.obj.IdActividad,this.orden).subscribe((lc)=>{
      if(this.more){
        this.calificaciones=lc.slice(0,3);
      }else{
        this.calificaciones=lc;
      }
      if(this.idcd){
        this.calificaciones=this.calificaciones.filter(c=>c.IdCompraDetalle==this.idcd);
      }
    })
  }

  cerrar(){
    this.ActiveModal.close();
  }
  verMas(){
    const modalRef = this.modal.open(ComentariosComponent,{ size: 'lg' });
    modalRef.componentInstance.Actividades = this.obj;
    modalRef.componentInstance.showmore = false;
  }
  ngOnInit(): void {
  }

}
