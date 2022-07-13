import { Actividades } from "./Actividades.model";
import { Compras } from "./Compras.model";

export class ComprasDetalle{
    IdCompraDetalle:number;
    IdCompra:number;
    IdActividad:number;
    Cantidad:number;
    FechaHora:string;
    ActividadesEntity:Actividades;
    ComprasEntity:Compras;
}