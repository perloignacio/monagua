import { Component, OnInit } from '@angular/core';
import { NgModel } from '@angular/forms';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Compras } from 'src/app/models/Compras.model';
import { ComprasDetalle } from 'src/app/models/ComprasDetalle.model';
import { ComprasService } from 'src/app/services/compras/compras.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { ComentariosComponent } from 'src/app/shared/comentarios/comentarios.component';

@Component({
  selector: 'app-compras-detalle',
  templateUrl: './compras-detalle.component.html',
  styleUrls: ['./compras-detalle.component.scss']
})
export class ComprasDetalleComponent implements OnInit {
  obj:Compras;
  ArrObj:ComprasDetalle[]=[];
  constructor(private srvShared:SharedService,private srvCompras:ComprasService,private modal:NgbModal) { 
    this.obj=this.srvShared.ObjEdit as Compras;
      if(this.obj!=null){
        this.srvCompras.GetCompra(this.obj.IdCompra).subscribe((c)=>{
          this.obj=c;
          this.ArrObj=c.Detalle;
        })
      }else{
        this.obj=new Compras(null);
      }
  }
  Volver(){
    history.back();
  }

  Comentarios(obj:ComprasDetalle){
    const modalRef = this.modal.open(ComentariosComponent,{ size: 'lg' });
    modalRef.componentInstance.Actividades = obj;
    modalRef.componentInstance.showmore = false;
    modalRef.componentInstance.premiteResponder = false;
    modalRef.componentInstance.IdCompraDetalle = obj.IdCompraDetalle;
  }
  ngOnInit(): void {
  }

}
