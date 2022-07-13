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
}