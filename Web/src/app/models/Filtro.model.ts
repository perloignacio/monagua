import { Actividades } from "./Actividades.model";
import { Categorias } from "./Categorias.model";
import { Prestadores } from "./Prestadores.model";
import { Provincias } from "./Provincias.model";

export class Filtro{
    provincias:Provincias[]=[];
    actividades:Actividades[]=[];
    categorias:Categorias[]=[];
    prestadores:Prestadores[]=[];
    duracion:number[]=[];
    dificultades:string[]=[];
    idiomas:string[]=[];
    cantPaginas:number;
}