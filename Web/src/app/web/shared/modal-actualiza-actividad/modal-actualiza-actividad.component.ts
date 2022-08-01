import { Component, OnInit } from '@angular/core';
import { NgbActiveModal, NgbDate, NgbDatepickerConfig } from '@ng-bootstrap/ng-bootstrap';
import * as moment from 'moment';
import { Actividades } from 'src/app/models/Actividades.model';
import { ComprasDetalle } from 'src/app/models/ComprasDetalle.model';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import { ComprasService } from 'src/app/services/compras/compras.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-modal-actualiza-actividad',
  templateUrl: './modal-actualiza-actividad.component.html',
  styleUrls: ['./modal-actualiza-actividad.component.scss']
})
export class ModalActualizaActividadComponent implements OnInit {
  isDisabled:any;
  fecha:NgbDate;
  obj:ComprasDetalle;
  horasdisponibles:string[]=[];
  cantidad:number=0;
  horario:string;
  constructor(private config: NgbDatepickerConfig,
    private srvCompras:ComprasService,private srvAutenticate:AuthenticationService,private activemodal:NgbActiveModal,private srvShared:SharedService) { 
      this.obj=this.srvShared.objModal as ComprasDetalle
      if(this.obj){
          let mom=moment();
        this.config.minDate={year: mom.year(), month: mom.month()+1, day: mom.date()+1}
        let fechas=this.obj.ActividadesEntity.Horarios.map(h=>moment(h.FechaInicio).format("YYYY-MM-DD"));
      
        this.isDisabled=(date: NgbDate, current: { month: number,year:number,day:number }) =>
        {
        
          let fecha=moment(date.year+"-"+date.month+"-"+date.day,'YYYY-M-D').format("YYYY-MM-DD");
        
          return !fechas.includes(fecha);
          
        }
      }
      
  }

  cargaHoras(){
    let fecha=moment(this.fecha.year+"-"+this.fecha.month+"-"+this.fecha.day,'YYYY-M-D').format("YYYY-MM-DD");
    this.horasdisponibles=this.obj.ActividadesEntity.Horarios.filter((h)=>moment(h.FechaInicio).format("YYYY-MM-DD")==fecha).map(h=>moment(h.FechaInicio).format("HH:mm"))
  }
  ngOnInit(): void {
  }

  Actualizar(){
    let cli=this.srvAutenticate.currentUserValue ? this.srvAutenticate.currentUserValue.ClientesEntity:null;
    this.srvCompras.obtieneCarrito(cli);
    let det:ComprasDetalle=new ComprasDetalle;
    det.ActividadesEntity=this.obj.ActividadesEntity;
    det.Cantidad=this.cantidad;
    let fechorastr=this.fecha.year+"-"+this.fecha.month+"-"+this.fecha.day+" "+this.horario.split(":")[0]+":"+this.horario.split(":")[1]+":00";
    
    let fechora=moment(fechorastr,'YYYY-M-D HH:mm:ss').format("YYYY-MM-DD HH:mm:ss");
    det.FechaHora=fechora;
    
    det.IdActividad=this.obj.IdActividad;
    this.srvCompras.validar(det).subscribe((resp)=>{
      if(resp.estado=="OK"){
        
          this.srvCompras.ActualizaActividad(det).subscribe((c)=>{
            this.srvCompras.setCarrito(c);
            Swal.fire("Ok","Los datos se actualizaron correctamente","success");
            this.activemodal.close(true);
          },(err)=>{
            Swal.fire("upps",err.error.Message,"warning");
          })
        
        
        
      }else{
        Swal.fire("upps",resp.mensaje,"warning");
      }
    })
    
  }

}
