import { Actividades } from "./Actividades.model";
import { Compras } from "./Compras.model";
import { EstadosCompraActividad } from "./EstadosCompraActividad";

export class ComprasDetalle{
    IdCompraDetalle:number;
    IdCompra:number;
    IdActividad:number;
    Cantidad:number;
    FechaHora:string;
    ActividadesEntity:Actividades;
    ComprasEntity:Compras;
    MontoActividad:number;
    EstadosCompraActividadEntity:EstadosCompraActividad;
    MensajesNoLeido:number;
}