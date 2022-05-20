import { Provincias } from "./Provincias.model";

export class Localidades{
    IdLocalidad:number;
    Nombre:string;
    Cp:string;
    IdProvincia:number;
    ProvinciasEntity:Provincias;
}