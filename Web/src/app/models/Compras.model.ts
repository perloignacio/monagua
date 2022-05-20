import { Clientes } from "./Clientes.model";
import { Descuentos } from "./Descuentos.model";
import { EstadosCompra } from "./EstadosCompra.model";

export class Compras{
    IdCompra:number;
    IdCliente:number;
    Fecha:Date;
    Total:number;
    Reserva:boolean;
    IdDescuento:number;
    MercadoPago:string;
    IdEstadoCompra:number;
    Activa:boolean;
    ClientesEntity:Clientes;
    DescuentosEntity:Descuentos;
    EstadosCompraEntity:EstadosCompra;
}