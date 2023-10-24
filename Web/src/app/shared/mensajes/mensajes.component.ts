import { Component, Input, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Mensajes } from 'src/app/models/Mensajes.model';
import { MensajesService } from 'src/app/services/mensajes/mensajes.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-mensajes',
  templateUrl: './mensajes.component.html',
  styleUrls: ['./mensajes.component.scss']
})
export class MensajesComponent implements OnInit {
  Mensajes:Mensajes[]=[];
  m:Mensajes=new Mensajes();
  idcd:number;
  @Input()
  set IdCompraDetalle(value: number) {
    this.idcd=value;
    this.Cargar();
    
  }
  constructor(private srvMensaje:MensajesService,private modal:NgbActiveModal) { 
    
  }

  Cargar(){
    this.srvMensaje.ByCompraDetalle(this.idcd).subscribe((lm)=>{
      this.Mensajes=lm;
    })
  }
  ngOnInit(): void {
  }

  cerrar(){
    this.modal.close();
  }
  Agregar(){
    this.m.IdCompraDetalle=this.idcd;
    this.srvMensaje.Agregar(this.m).subscribe((b)=>{
      if(b){
        this.Cargar();
        this.limpiar();
      }
    },(err)=>{
      Swal.fire("Upps",err.error.Message,'warning');
    })
  }
  limpiar(){
    this.m=new Mensajes();
  }
}
