import { Actividades } from "./Actividades.model";

export class ActividadesHorarios{
    IdHorario:number;
    IdActividad:number;
    Tipo:number;
    FechaHoraDesde:Date;
    FechaHoraHasta:Date;
    Activa:boolean;
    ActividadesEntity:Actividades;
}