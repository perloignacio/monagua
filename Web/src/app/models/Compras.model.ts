import { Clientes } from "./Clientes.model";
import { ComprasDetalle } from "./ComprasDetalle.model";
import { Descuentos } from "./Descuentos.model";
import { EstadosCompra } from "./EstadosCompra.model";

export class Compras{
    IdCompra:number;
    IdObjeto:number;
    IdCliente:number;
    Fecha:Date;
    Total:number;
    Reserva:boolean;
    IdDescuento:number;
    MercadoPago:string;
    IdEstadoCompra:number;
    Activa:boolean;
    Comentarios:string;
    ClientesEntity:Clientes;
    DescuentosEntity:Descuentos;
    EstadosCompraEntity:EstadosCompra;
    Detalle:ComprasDetalle[]=[];
    MontoDescuento:number
    constructor(json:any) {
        if(json!=null){
            this.IdCompra=json.IdCompra;
            this.IdObjeto=json.IdObjeto;
            this.IdCliente=json.IdCliente;
            this.Fecha=json.Fecha;
            this.Total=json.Total;
            this.Reserva=json.Reserva;
            this.IdDescuento=json.IdDescuento;
            this.MercadoPago=json.MercadoPago;
            this.IdEstadoCompra=json.IdEstadoCompra;
            this.Activa=json.Activa;
            this.Comentarios=json.Comentarios;
            this.ClientesEntity=json.ClientesEntity;
            this.DescuentosEntity=json.DescuentosEntity;
            this.EstadosCompraEntity=json.EstadosCompraEntity;
            this.Detalle=json.Detalle;
          
        }
    
      }
}