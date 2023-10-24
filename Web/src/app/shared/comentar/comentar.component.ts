import { Component, OnInit,Input } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Calificaciones } from 'src/app/models/Calificaciones.model';
import { CalificacionesService } from 'src/app/services/calificaciones/calificaciones.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-comentar',
  templateUrl: './comentar.component.html',
  styleUrls: ['./comentar.component.scss']
})
export class ComentarComponent implements OnInit {

  c:Calificaciones=new Calificaciones();
  idcd:number;
  responder:boolean=false;
  @Input()
  set IdCompraDetalle(value: number) {
    this.idcd=value;
    this.c.Calificacion=0;
    this.cargar();
  }
  @Input()
  set premiteResponder(value: boolean) {
    this.responder=value;
    
  }
  constructor(private srvCali:CalificacionesService,private modal:NgbActiveModal) {
    
  }

  cerrar(){
    this.modal.close();
  }
  cargar(){
    this.srvCali.byCompra(this.idcd).subscribe((cali)=>{
      
      if(cali){
        this.c=cali;
      }else{
        this.c=new Calificaciones();
        this.c.Calificacion=0;
      }
    })
  }
  Responder(obj:Calificaciones){
    this.srvCali.responder(obj.IdCalificacion,obj.Respuesta).subscribe((b)=>{
      if(b){
        Swal.fire("Ok","La respuesta se cargo correctamente",'success');
      }
    },(err)=>{
      Swal.fire("Upps",err.error.Message,'warning');
    })
  }
  Comentar(obj:Calificaciones){
    this.srvCali.comentar(obj.Comentario,obj.Calificacion,this.idcd).subscribe((b)=>{
      if(b){
        Swal.fire("Ok","Gracias por calificar tu experiencia",'success');
        this.modal.close();
      }
    },(err)=>{
      Swal.fire("Upps",err.error.Message,'warning');
    })
  }
  ngOnInit(): void {
  }

}
