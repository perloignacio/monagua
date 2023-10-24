import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Clientes } from 'src/app/models/Clientes.model';
import { Compras } from 'src/app/models/Compras.model';
import { EstadosCompra } from 'src/app/models/EstadosCompra.model';
import { ClientesService } from 'src/app/services/clientes/clientes.service';
import { ComprasService } from 'src/app/services/compras/compras.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { WebService } from 'src/app/services/web/web.service';

@Component({
  selector: 'app-compras',
  templateUrl: './compras.component.html',
  styleUrls: ['./compras.component.scss']
})
export class ComprasComponent implements OnInit {
  ArrObj:any[]=[];
  strFiltro:string="";
  page = 1;
  pageSize = 10;
  collectionSize = 0
  clientes:Clientes[]=[];
  estados:EstadosCompra[]=[];
  fechaDesdeFiltro:Date;
  fechaHastaFiltro:Date;
  idUsuarioFiltro:number;
  idEstadoFiltro:number;
  constructor(private srvCompras:ComprasService,private srvWeb:WebService,private srvClientes:ClientesService,private srvShared:SharedService,private router:Router) { 
    this.srvWeb.EstadosCompra().subscribe((le)=>{
      this.estados=le;
    })
    this.srvClientes.todosAdmin().subscribe((lc)=>{
      this.clientes=lc;
    })
    this.cargar();
  }

  cargar(){
    this.srvCompras.GetComprasAdmin(this.fechaDesdeFiltro,this.fechaHastaFiltro,this.idUsuarioFiltro,this.idEstadoFiltro).subscribe((lc)=>{
     this.ArrObj=lc;
     
    })
  }
  
  Editar(obj:Compras){
    this.srvShared.ObjEdit=obj;
    this.router.navigate(['admin/comprasDetalle']);
  }
  
  ngOnInit(): void {
  }

}
