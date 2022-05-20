import { Categorias } from "./Categorias.model";
import { Prestadores } from "./Prestadores.model";

export class Actividades{
    IdActividad:number;
    Nombre:string;
    DescripcionCorta:string;
    Descripcion:string;
    Fotos:string;
    Video:string;
    Lat:number;
    Lng:number;
    Ubicacion:string;
    Precio:number;
    PrecioOferta:number;
    Mascotas:boolean;
    PersonasCapacidadRed:boolean;
    DietasEspeciales:boolean;
    Idiomas:string;
    Dificultad:string;
    QueIncluye:string;
    QueNoIncluye:string;
    Duracion:number;
    IdCategoria:number;
    IdPrestador:number;
    Activa:boolean;
    CategoriasEntity:Categorias;
    PrestadoresEntity:Prestadores
}