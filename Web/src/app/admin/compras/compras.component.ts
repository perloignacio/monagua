import { Component, OnInit } from '@angular/core';
import { Compras } from 'src/app/models/Compras.model';

@Component({
  selector: 'app-compras',
  templateUrl: './compras.component.html',
  styleUrls: ['./compras.component.scss']
})
export class ComprasComponent implements OnInit {
  ArrObj:Compras[]=[];
  OriginalArr:Compras[]=[];
  strFiltro:string;
  constructor() { }

  Filtro(){
    
    this.ArrObj=this.OriginalArr.filter(obj => {
      const term = this.strFiltro.toLowerCase();
      return obj.ClientesEntity.Apellido.toLowerCase().includes(term) 
      || obj.EstadosCompraEntity.Nombre.toLowerCase().includes(term) 
      
    
      
          
    });
  }

  ngOnInit(): void {
  }

}
