import { Actividades } from "./Actividades.model";
import { Compras } from "./Compras.model";

export class ComrpasDetalle{
    IdCompraDetalle:number;
    IdCompra:number;
    IdActividad:number;
    Cantidad:number;
    IdHorarioActividad:number;
    ActividadesEntity:Actividades;
    ComprasEntity:Compras;
}