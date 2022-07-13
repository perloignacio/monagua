import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { NgbDate, NgbDatepickerConfig } from '@ng-bootstrap/ng-bootstrap';
import { de } from 'date-fns/locale';
import * as moment from 'moment';
import { Actividades } from 'src/app/models/Actividades.model';
import { ComprasDetalle } from 'src/app/models/ComprasDetalle.model';
import { ActividadesService } from 'src/app/services/actividades/actividades.service';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import { ComprasService } from 'src/app/services/compras/compras.service';
import { FavoritosService } from 'src/app/services/favoritos/favoritos.service';
import { environment } from 'src/environments/environment';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-ficha',
  templateUrl: './ficha.component.html',
  styleUrls: ['./ficha.component.scss']
})
export class FichaComponent implements OnInit {
  obj:Actividades;
  foto:string="";
  fecha:NgbDate;
  isDisabled:any;
  assets:string=environment.assets;
  
  cantidad:number=0;
  horario:string;
  horasdisponibles:string[]=[];
  constructor(private srvACtividades:ActividadesService,
    private route:ActivatedRoute,
    private srvAutenticate:AuthenticationService,
    private srvFav:FavoritosService,
    private config: NgbDatepickerConfig,
    private srvCompras:ComprasService,
    private router:Router) { 

    this.route.params.subscribe(val => {
      this.srvACtividades.Ficha(val["id"]).subscribe((ac)=>{
        this.Cargadatos(ac);
        
        
      })
    })
    
  }
  Cargadatos(ac:Actividades){
    this.foto=ac.Fotos.split(",")[0];
    this.obj=ac;
    let mom=moment();
    this.config.minDate={year: mom.year(), month: mom.month()+1, day: mom.date()+1}
    let fechas=this.obj.Horarios.map(h=>moment(h.FechaInicio).format("YYYY-MM-DD"));
    
    this.isDisabled=(date: NgbDate, current: { month: number,year:number,day:number }) =>
    {
     
      let fecha=moment(date.year+"-"+date.month+"-"+date.day,'YYYY-M-D').format("YYYY-MM-DD");
     
      return !fechas.includes(fecha);
      
    }
  }
  cargaHoras(){
    let fecha=moment(this.fecha.year+"-"+this.fecha.month+"-"+this.fecha.day,'YYYY-M-D').format("YYYY-MM-DD");
    this.horasdisponibles=this.obj.Horarios.filter((h)=>moment(h.FechaInicio).format("YYYY-MM-DD")==fecha).map(h=>moment(h.FechaInicio).format("HH:mm"))
  }
  favoritos(){
    
    let u=this.srvAutenticate.currentUserValue;
    
    if(u!=null && u.ClientesEntity!=null){
      this.srvFav.Agregar(this.obj.IdActividad).subscribe((b)=>{
        if(b){
          Swal.fire("Ok","La actividad se guardo en favoritos","success");    
        }
      },(err)=>{
        Swal.fire("Upps",err.error.Message,"warning");    
      })
    }else{
      Swal.fire("upps","debe estar logueado para poder agregar a favoritos","warning");
    }
  }

  Comprar(){
    let cli=this.srvAutenticate.currentUserValue ? this.srvAutenticate.currentUserValue.ClientesEntity:null;
    this.srvCompras.obtieneCarrito(cli);
    let det:ComprasDetalle=new ComprasDetalle;
    det.ActividadesEntity=this.obj;
    det.Cantidad=this.cantidad;
    let fechorastr=this.fecha.year+"-"+this.fecha.month+"-"+this.fecha.day+" "+this.horario.split(":")[0]+":"+this.horario.split(":")[1]+":00";
    
    let fechora=moment(fechorastr,'YYYY-M-D HH:mm:ss').format("YYYY-MM-DD HH:mm:ss");
    det.FechaHora=fechora;
    
    det.IdActividad=this.obj.IdActividad;
    this.srvCompras.validar(det).subscribe((resp)=>{
      if(resp.estado=="OK"){
        this.srvCompras.AgregaActividad(det).subscribe((c)=>{
          this.srvCompras.setCarrito(c);
          this.router.navigate(["/compras"]);
        },(err)=>{
          Swal.fire("upps",err.error.Message,"warning");
        })
        
      }else{
        Swal.fire("upps",resp.mensaje,"warning");
      }
    })
  }
  
  ngOnInit(): void {
  }

}
