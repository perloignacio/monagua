import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import * as moment from 'moment';
import { ActividadesHorarios } from 'src/app/models/ActividadesHorarios.model';
import { TipoReticiones } from 'src/app/models/TipoRepeticiones.model';
import { ActividadesService } from 'src/app/services/actividades/actividades.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { WebService } from 'src/app/services/web/web.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-horario',
  templateUrl: './horario.component.html',
  styleUrls: ['./horario.component.scss']
})
export class HorarioComponent implements OnInit {
  obj:ActividadesHorarios=new ActividadesHorarios();
  Repeticiones:TipoReticiones[]=[];
  Agregar:boolean=true;
  constructor(private srvWeb:WebService,private srvAct:ActividadesService,public srvShared:SharedService,private activemodal:NgbActiveModal) { 
    this.srvWeb.TipoRepeticiones().subscribe((lr)=>{
      this.Repeticiones=lr;
      if(this.srvShared.objModal as ActividadesHorarios!=null){
        this.Agregar=false;
        this.obj=this.srvShared.objModal;
        console.log(this.obj);
      }
    })

  }

  ngOnInit(): void {
  }
  Guardar(){
    const form=new FormData();
    this.obj.IdActividad=2;
    
    
    form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
    this.srvAct.agregarHorario(form).subscribe((band)=>{
      if(band){
        Swal.fire("Ok","La operación se realizo con exito",'success');
        this.activemodal.close(true);
      } 
    },(err)=>{

      Swal.fire("Upps",err.error.Message,'warning');
    })
  }

  Modificar(tipo:string){
    const form=new FormData();
    form.append("id",this.obj.id.toString());
    if(tipo=="solo"){
      this.obj.HoraDesde=this.obj.FechaInicio;
      this.obj.HoraHasta=this.obj.FechaFin;
      form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
      this.srvAct.modificarUnHorario(form).subscribe((band)=>{
        if(band){
          Swal.fire("Ok","La operación se realizo con exito",'success');
          this.activemodal.close(true);
        } 
      },(err)=>{
  
        Swal.fire("Upps",err.error.Message,'warning');
      })
    }

    if(tipo=="siguientes"){
      this.obj.HoraDesde=this.obj.FechaInicio;
      this.obj.HoraHasta=this.obj.FechaFin;
      let fin: moment.Moment = moment(this.obj.FechaInicio);
      form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
      form.append("fin",fin.format("YYYY-MM-DD"));
      //console.log(form);
      this.srvAct.modificarSiguientesHorario(form).subscribe((band)=>{
        if(band){
          Swal.fire("Ok","La operación se realizo con exito",'success');
          this.activemodal.close(true);
        } 
      },(err)=>{
  
        Swal.fire("Upps",err.error.Message,'warning');
      })
    }

    if(tipo=="todos"){
      this.obj.HoraDesde=this.obj.FechaInicio;
      this.obj.HoraHasta=this.obj.FechaFin;
      let fin: moment.Moment = moment(this.obj.FechaInicio);
      form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
      form.append("fin",fin.format("YYYY-MM-DD"));
      //console.log(form);
      this.srvAct.modificarHorario(form).subscribe((band)=>{
        if(band){
          Swal.fire("Ok","La operación se realizo con exito",'success');
          this.activemodal.close(true);
        } 
      },(err)=>{
  
        Swal.fire("Upps",err.error.Message,'warning');
      })
    }
    
  }


  Borrar(tipo:string){
    const form=new FormData();
    form.append("id",this.obj.id.toString());
    if(tipo=="solo"){
      form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
      this.srvAct.borrarUnHorario(form).subscribe((band)=>{
        if(band){
          Swal.fire("Ok","La operación se realizo con exito",'success');
          this.activemodal.close(true);
        } 
      },(err)=>{
  
        Swal.fire("Upps",err.error.Message,'warning');
      })
    }

    if(tipo=="siguientes"){
      let fin: moment.Moment = moment(this.obj.FechaInicio);
      form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
      form.append("fin",fin.format("YYYY-MM-DD"));
      //console.log(form);
      this.srvAct.borrarSiguientesHorario(form).subscribe((band)=>{
        if(band){
          Swal.fire("Ok","La operación se realizo con exito",'success');
          this.activemodal.close(true);
        } 
      },(err)=>{
  
        Swal.fire("Upps",err.error.Message,'warning');
      })
    }

    if(tipo=="todos"){
      
      form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
      
      //console.log(form);
      this.srvAct.borrarHorario(form).subscribe((band)=>{
        if(band){
          Swal.fire("Ok","La operación se realizo con exito",'success');
          this.activemodal.close(true);
        } 
      },(err)=>{
  
        Swal.fire("Upps",err.error.Message,'warning');
      })
    }
    
  }
}
