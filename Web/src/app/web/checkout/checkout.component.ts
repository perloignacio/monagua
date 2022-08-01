import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import { ComprasService } from 'src/app/services/compras/compras.service';
import { CuponesService } from 'src/app/services/cupones/cupones.service';
import { environment } from 'src/environments/environment';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-checkout',
  templateUrl: './checkout.component.html',
  styleUrls: ['./checkout.component.scss']
})
export class CheckoutComponent implements OnInit {
  assets:string=environment.assets;
  codigoCupon:string="";
  constructor(public srvAut:AuthenticationService,public srvCompras:ComprasService,private srvCupones:CuponesService,public router:Router) { 
    if(this.srvAut.currentUserValue!=null){
      this.srvCompras.setCliente(this.srvAut.currentUserValue.ClientesEntity);
      this.srvCompras.ActualizaCarrito().subscribe((c)=>{
        this.srvCompras.setCarrito(c);
      })
    }
  }

  Finalizar(){
    this.srvCompras.Pagar().subscribe((linkMP)=>{
      if(linkMP!=""){
        //window.location.href=linkMP;
        this.srvCompras.Finalizar().subscribe((band)=>{
          if(band){
            this.router.navigate(["/gracias"])
          }
        },(err)=>{
          Swal.fire("upps",err.error.Message,"warning");
        })
      }
    })
  }

  
  CambiaReserva(reserva:boolean){
    this.srvCompras.carrito.Reserva=reserva;
    this.srvCompras.ActualizaCarrito().subscribe((c)=>{
      this.srvCompras.setCarrito(c);
    })
  }
  
  Canjear(){
    if(this.srvAut.currentUserValue==null){
      Swal.fire("Atención","Debe estar logueado para poder canjear el descuento","warning")
    }else{
      this.srvCupones.Canjear(this.codigoCupon).subscribe((cup)=>{
        if(cup!=null){
          this.srvCompras.setDescuento(cup);
          this.srvCompras.ActualizaCarrito().subscribe((c)=>{
            this.srvCompras.setCarrito(c);
          })
        }
      },(err)=>{
         
        Swal.fire("Upps",err.error.Message,'warning');
      })
    }
  }
  ngOnInit(): void {
  }

}
