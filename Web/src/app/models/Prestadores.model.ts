import { Localidades } from "./Localidades.model";
import { Paises } from "./Paises.model";
import { Provincias } from "./Provincias.model";

export class Prestadores{
    IdPrestador:number;
    RazonSocial:string;
    NombreFantasia:string;
    Cuit:number;
    Telefono:number;
    IdPais:number;
    IdProvincia:number;
    IdLocalidad:number;
    Email:string;
    Logo:string;
    FechaRegistro:Date;
    PrestadorHabilitado:boolean;
    Politicas:boolean;
    Activo:boolean;
    LocalidadesEntity:Localidades;
    PaisesEntity:Paises;
    ProvinciasEntity:Provincias;
}