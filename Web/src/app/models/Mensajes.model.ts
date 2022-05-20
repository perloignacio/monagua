import { ComrpasDetalle } from "./ComprasDetalle.model";

export class Mensajes{
    IdMensaje:number;
    Fecha:Date;
    Mensaje:string;
    LeidoPrestador:boolean;
    LeidoCliente:boolean;
    OrigenCliente:boolean;
    Activo:boolean;
    IdCompraDetalle:number;
    ComprasDetalleEntity:ComrpasDetalle;
}