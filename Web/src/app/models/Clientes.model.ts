import { Localidades } from "./Localidades.model";
import { Paises } from "./Paises.model";
import { Provincias } from "./Provincias.model";

export class Clientes{
    IdCliente:number;
    FechaRegistro:Date;
    Nombre:string;
    Apellido:string;
    Email:string;
    Contra:string;
    FechaNacimiento:Date;
    Novedades:boolean;
    Politicas:boolean;
    IdPais:number;
    IdProvincia:number;
    IdLocalidad:number;
    Sexo:string;
    Telefono:string;
    Activo:boolean;
    LocalidadesEntity:Localidades;
    PaisesEntity:Paises;
    ProvinciasEntity:Provincias;
}