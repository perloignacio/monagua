import { Localidades } from "./Localidades.model";
import { Paises } from "./Paises.model";

export class Provincias{
    IdProvincia:number;
    Nombre:string;
    IdPais:number;
    PaisesEntity:Paises;
    localidades:Localidades[]=[];
}