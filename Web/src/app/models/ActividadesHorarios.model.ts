import { Actividades } from "./Actividades.model";
import { TipoReticiones } from "./TipoRepeticiones.model";

export class ActividadesHorarios{
    IdHorario:number;
    IdActividad:number;
    IdTipoRepeticion:number;
    HoraDesde:Date;
    HoraHasta:Date;
    Activa:boolean;
    Capacidad:number;
    FechaInicio:Date;
    FechaFin:Date;
    TipoRepeticionesEntity:TipoReticiones;
    ActividadesEntity:Actividades;
    id:number;
    idCalendar:number;
}