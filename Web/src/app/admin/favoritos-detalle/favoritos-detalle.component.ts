import { Component, OnInit } from '@angular/core';
import { NgModel } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Actividades } from 'src/app/models/Actividades.model';
import { Clientes } from 'src/app/models/Clientes.model';
import { Favoritos } from 'src/app/models/Favoritos.model';
import { FavoritosService } from 'src/app/services/favoritos/favoritos.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';


@Component({
  selector: 'app-favoritos-detalle',
  templateUrl: './favoritos-detalle.component.html',
  styleUrls: ['./favoritos-detalle.component.scss']
})
export class FavoritosDetalleComponent implements OnInit {
  clientes:Clientes[]=[];
  fechaDesdeFiltro:Date;
  fechaHastaFiltro:Date;
  idUsuarioFiltro:number;
  ArrObj:Favoritos[]=[];
  actividad:Actividades;
  page = 1;
  pageSize = 10;
  collectionSize = 0
  OriginalArr:Favoritos[]=[];
  strFiltro1="";
  strFiltro2="";
  constructor(private srvObj:FavoritosService,private srvShared:SharedService,private router:Router,private route:ActivatedRoute) {
    if(this.srvShared.ObjEdit){
      this.actividad=this.srvShared.ObjEdit as Actividades;
      this.cargar(this.actividad.IdActividad,null,null,null)
    }else{
      this.router.navigate(["admin/favoritos"])
    }
    
  }

  cargar(idactividad:number,idcliente:number,desde:Date,hasta:Date){
    this.route.params.subscribe(val => {
            
      this.srvObj.todosAdmin(idactividad,desde,hasta,idcliente).subscribe((lista)=>{
        this.OriginalArr=lista;
        this.collectionSize=this.OriginalArr.length;
        this.getClientes()
        this.refreshData();
      })
    })
  }
  
  Filtrar(){
    
    let _idusuario=null;
    let _desde=null;
    let _hasta=null;

    if(this.idUsuarioFiltro!=0){
      _idusuario=this.idUsuarioFiltro;
    }

    if(this.fechaDesdeFiltro && this.fechaHastaFiltro){
      _desde=this.fechaDesdeFiltro;
      _hasta=this.fechaHastaFiltro;
    }

    
    this.cargar(this.actividad.IdActividad,_idusuario,_desde,_hasta);
    this.idUsuarioFiltro=0;
    this.fechaDesdeFiltro=null;
    this.fechaHastaFiltro=null;
  }
  getClientes(){
    this.clientes=this.OriginalArr.map(f=>f.ClientesEntity);
  }
  refreshData(){
    this.ArrObj=this.OriginalArr.slice((this.page - 1) * this.pageSize, (this.page - 1) * this.pageSize + this.pageSize);
  }
  Filtro(){
    
    this.ArrObj=this.OriginalArr.filter(obj => {
      const term = this.strFiltro1.toLowerCase();
      return obj.IdActividad.toString().includes(term) 
      || obj.IdCliente.toString().includes(term)      
          
    });
  }

  FiltroHasta(){
    
    this.ArrObj=this.OriginalArr.filter(obj => {
      const term = this.strFiltro2.toLowerCase();
      return obj.IdActividad.toString().includes(term) 
      || obj.IdCliente.toString().includes(term)      
          
    });
  }

  Volver(){
    history.back();
  }

  ngOnInit(): void {
  }
  
    
}
