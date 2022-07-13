import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { firstValueFrom } from 'rxjs';
import { Clientes } from 'src/app/models/Clientes.model';
import { Compras } from 'src/app/models/Compras.model';
import { ComprasDetalle } from 'src/app/models/ComprasDetalle.model';
import { Descuentos } from 'src/app/models/Descuentos.model';
import { environment } from 'src/environments/environment';

const httpOptions = {
  withCredentials: true
};

@Injectable({
  providedIn: 'root'
})
export class ComprasService {
  carrito:Compras;
  endpoint:string="";

  private inicia(cliente?:Clientes){
    this.carrito=new Compras();
    this.carrito.Activa=true;
    this.carrito.Fecha=new Date();
    if(cliente!=null){
      this.carrito.IdCliente=cliente.IdCliente;
      this.carrito.ClientesEntity=cliente;
    }
    
    this.carrito.IdEstadoCompra=1;
    this.carrito.Reserva=false;
    this.carrito.MercadoPago="";
    return this.carrito;
  }

  obtieneCarrito(cliente?:Clientes){
    if(this.carrito){
      return this.carrito;
    }else{
      return this.inicia(cliente);
    } 
  }

  setCarrito(c:Compras){
    this.carrito=c;
  }
  
  setCliente(cliente:Clientes){
    this.carrito.IdCliente=cliente.IdCliente;
    this.carrito.ClientesEntity=cliente;
  }
  setDescuento(descuento:Descuentos){
    this.carrito.IdDescuento=descuento.IdDescuento;
    this.carrito.DescuentosEntity=descuento;
  }

  AgregaActividad(cd:ComprasDetalle){
    this.carrito.Detalle.push(cd);
    return this.httpClient.post<Compras>(this.endpoint + `agregar/`,this.carrito, httpOptions)
  }

  

  getTotal(){
    let acu=0;
    this.carrito.Detalle.forEach((d)=>{
      let precio=d.ActividadesEntity.PrecioOferta!=null ? d.ActividadesEntity.PrecioOferta : d.ActividadesEntity.Precio;
      acu=d.Cantidad*precio
    })
    if(this.carrito.DescuentosEntity!=null){
      let desc=this.carrito.DescuentosEntity.Monto!=null? this.carrito.DescuentosEntity.Monto : ((this.carrito.DescuentosEntity.Porcentaje*acu)/100)
      acu=acu-desc;
    }
    return acu;

  }


  constructor(public httpClient: HttpClient) { 
    this.endpoint=environment.apiUrl+"compras/";
  }

  validar(cd:ComprasDetalle) {
    return this.httpClient.post<any>(this.endpoint + `validar/`,cd, httpOptions)
  }
}
