import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ComprasDetalle } from 'src/app/models/ComprasDetalle.model';
import { ComprasService } from 'src/app/services/compras/compras.service';
import { environment } from 'src/environments/environment';
import Swal from 'sweetalert2';
import { SharedService } from 'src/app/services/shared/shared.service';
import { ModalActualizaActividadComponent } from '../shared/modal-actualiza-actividad/modal-actualiza-actividad.component';
import { Router } from '@angular/router';


@Component({
  selector: 'app-compras',
  templateUrl: './compras.component.html',
  styleUrls: ['./compras.component.scss']
})
export class ComprasComponent implements OnInit {
  assets:string=environment.assets;
  constructor(public srvCompra:ComprasService,private modal: NgbModal,private srvShared:SharedService,private router:Router) { }

  ngOnInit(): void {
  }

  borrarproducto(det:ComprasDetalle){
    Swal.fire({
      title: "Atencion",
      text:"Esta seguro que desea borrar?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      /* Read more about isConfirmed, isDenied below */
      if (result.isConfirmed) {
        this.srvCompra.Quitar(det).subscribe((c)=>{
          if(c){
            this.srvCompra.setCarrito(c);
            Swal.fire("Ok","Se borro el registro",'success');

          }
        },(err)=>{
         
          Swal.fire("Upps",err.error.Message,'warning');
        })
      };
    });
  }
  cambiar(det:ComprasDetalle){
    this.srvShared.objModal=det;
    this.modal.open(ModalActualizaActividadComponent, { size: 'md' }).result.then((result) => {
      
       /* To subscribe data from Modal */

      }, (reason)=>{ 
      
        /*Leave empty or handle reject*/

      });
  }

  Actualizar(){
    this.srvCompra.ActualizaCarrito().subscribe((c)=>{
      this.srvCompra.setCarrito(c);
      this.router.navigate(["/checkout"]);
    })                           
  }
  
}
