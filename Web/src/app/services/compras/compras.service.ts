import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import * as moment from 'moment';
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
    var objcarito=localStorage.getItem("c_monagua");
    if(objcarito){
      this.carrito=new Compras(JSON.parse(objcarito));
      let fecCarrito=moment(this.carrito.Fecha).add(2,'days')
      let fechaActual=moment(new Date());

      if(!fecCarrito.isSameOrAfter(fechaActual)){
        this.carrito=new Compras(null);
      }
    }else{
      this.carrito=new Compras(null);
    }
    
    
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

  Limpia(){
    this.carrito=new Compras(null);
    this.setCarrito(this.carrito);
  }
  obtieneCarrito(cliente?:Clientes):Compras{
    if(this.carrito){
      return this.carrito;
    }else{
      return this.inicia(cliente);
    } 
  }

  setCarrito(c:Compras){
    this.carrito=c;
    this.setLocalStorage();
  }
  setLocalStorage(){
    localStorage.setItem("c_monagua",JSON.stringify(this.carrito));
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
    return this.httpClient.post<Compras>(this.endpoint + `AgregarEditar/`,this.carrito, httpOptions)
  }

  ActualizaActividad(det:ComprasDetalle){
    let index=this.carrito.Detalle.findIndex(d=>d.IdActividad==det.IdActividad);
    this.carrito.Detalle[index]=det;
    return this.httpClient.post<Compras>(this.endpoint + `AgregarEditar/`,this.carrito, httpOptions)
  }

  ActualizaCarrito(){
    return this.httpClient.post<Compras>(this.endpoint + `AgregarEditar/`,this.carrito, httpOptions)
  }

  Quitar(cd:ComprasDetalle){
    let index=this.carrito.Detalle.findIndex(det=>det.IdActividad==cd.IdActividad);
    this.carrito.Detalle.splice(index,1);
    return this.httpClient.post<Compras>(this.endpoint + `AgregarEditar/`,this.carrito, httpOptions)
  }

  

  getTotal(){
    let acu=this.getSubTotal();
    let desc=this.getDescuento();
    if(this.carrito.Reserva){
      return (acu-desc)/2;
    }else{
      return (acu-desc)
    }
      

  }


  getSubTotal(){
    let acu=0;
    this.carrito.Detalle.forEach((d)=>{
      let precio=d.ActividadesEntity.PrecioOferta!=null ? d.ActividadesEntity.PrecioOferta : d.ActividadesEntity.Precio;
      acu+=d.Cantidad*precio
    })
    
    return acu;

  }

  getDescuento(){
    let acu=this.getSubTotal();
    let desc=0;
    
    if(this.carrito.DescuentosEntity!=null){
      desc=this.carrito.DescuentosEntity.Monto!=null? this.carrito.DescuentosEntity.Monto : ((this.carrito.DescuentosEntity.Porcentaje*acu)/100)
      
    }
    
    return desc;

  }


  constructor(public httpClient: HttpClient) { 
    this.endpoint=environment.apiUrl+"compras/";
  }

  validar(cd:ComprasDetalle) {
    return this.httpClient.post<any>(this.endpoint + `validar/`,cd, httpOptions)
  }

  Pagar() {
    return this.httpClient.post<string>(this.endpoint + `GetLinkMercadoPago/`,this.carrito, httpOptions)
  }
  Finalizar() {
    return this.httpClient.post<boolean>(this.endpoint + `FinalizarManual/`,this.carrito, httpOptions)
  }
}
