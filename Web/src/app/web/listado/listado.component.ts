import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { NgbDate, NgbDatepickerConfig } from '@ng-bootstrap/ng-bootstrap';
import * as moment from 'moment';
import { NgxSpinnerService } from 'ngx-spinner';
import { Actividades } from 'src/app/models/Actividades.model';
import { Categorias } from 'src/app/models/Categorias.model';
import { Provincias } from 'src/app/models/Provincias.model';
import { ActividadesService } from 'src/app/services/actividades/actividades.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';
@Component({
  selector: 'app-listado',
  templateUrl: './listado.component.html',
  styleUrls: ['./listado.component.scss']
})
export class ListadoComponent implements OnInit {
  orden:string="";
  fecha:NgbDate;
  Ubicaciones:Provincias[]=[];
  Duraciones:any[]=[];
  Prestadores:any[]=[];
  Dificultades:any[]=[];
  Idiomas:any[]=[];
  Actividades:Actividades[]=[];
  FiltrosAplicados:any[]=[]
  Categorias:Categorias[]=[];
  paginaActual:number=1;
  cantPaginas:number;
  fakePaginas=new Array();
  constructor(private srvActividades:ActividadesService,private srvShared:SharedService,private spinner: NgxSpinnerService,private route:ActivatedRoute) { 
    route.params.subscribe(val => { 
      this.checkFiltros();
      this.render();
    });
     
  }

  checkFiltros(){
    if(this.route.snapshot.params["categoria"]){
      this.Addfiltro("categoria",this.route.snapshot.params["categoria"],this.route.snapshot.params["nombre"]);
    }
    if(this.route.snapshot.params["fecha"]){
      let fec=this.route.snapshot.params["fecha"];
      
      this.fecha=new NgbDate(parseInt(fec.split("-")[0]),parseInt(fec.split("-")[1]),parseInt(fec.split("-")[2]))
      
      this.Addfiltro("fecha",this.route.snapshot.params["fecha"],"asdas");
    }
  }
  render(){
    this.spinner.show();
    const form=new FormData();
    form.append("filtros",this.srvShared.convertToJSON(this.FiltrosAplicados).objeto);
    this.srvActividades.filtrar(form,this.paginaActual-1,this.orden).subscribe((res)=>{
      this.Actividades=res.actividades;
      this.Ubicaciones=res.provincias;
      this.Categorias=res.categorias;
      this.Prestadores=res.prestadores;
      this.Duraciones=res.duracion;
      this.Dificultades=res.dificultades;
      this.Idiomas=res.idiomas;
      this.cantPaginas=res.cantPaginas;
      this.fakePaginas=new Array(res.cantPaginas);
      this.spinner.hide();
    },(err)=>{
      this.spinner.hide();
      Swal.fire("upps",err.error.Message,"warning");
    })
  }
  ngOnInit(): void {
  }
  quitarFiltro(f:any){
    let index=this.FiltrosAplicados.findIndex(fi=>fi.tipo==f.tipo);
    this.FiltrosAplicados.splice(index,1);
    this.fecha=null;
    this.render()
    
  }
  Addfiltro(tipo:string,value:any,label:string){
    if(tipo=="fecha"){
      let fecha=moment(this.fecha.year+"-"+this.fecha.month+"-"+this.fecha.day,'YYYY-M-D').format("YYYY-MM-DD");
      value=fecha;
      label=fecha.toLocaleString();
    }
    let index=this.FiltrosAplicados.findIndex(fi=>fi.tipo==tipo);
    console.log(index);
    if(index==-1){
      this.FiltrosAplicados.push({tipo:tipo,value:value,label:label});
    }else{
      this.FiltrosAplicados[index].value=value;
      this.FiltrosAplicados[index].label=label;
    }
    
    this.render()
  }
  prev(){
    if(this.paginaActual>1){
      this.paginaActual--;
      this.render();
    }
  }
  next(){
    console.log(this.paginaActual);
    console.log(this.cantPaginas);
    if(this.paginaActual<this.cantPaginas){
      this.paginaActual++;
      this.render();
    }
  }

  cambiaPagina(prox:number){
    this.paginaActual=prox;
    this.render();
  }
  createRange(number){
    // return new Array(number);
    return new Array(number).fill(0)
      .map((n, index) => index + 1);
  }
}
