import { Clientes } from "./Clientes.model";
import { Prestadores } from "./Prestadores.model";

export class Usuarios{
    IdUsuario:number;
    Usuario:string;
    Contra:string;
    Nombre:string;
    Apellido:string;
    Email:string;
    IdCliente:number;
    IdPrestador:number;
    Activo:boolean;
    Token:string;
    ClientesEntity?:Clientes;
    PrestadoresEntity?:Prestadores;
}