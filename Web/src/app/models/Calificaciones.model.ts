import { ComrpasDetalle } from "./ComprasDetalle.model";

export class Calificaciones{
    IdCalificacion:number;
    Fecha:Date;
    IdCompraDetalle:number;
    Calificacion:number;
    Comentario:string;
    Respuesta:string;
    ComprasDetalleEntity:ComrpasDetalle;
}