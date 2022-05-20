import { Actividades } from "./Actividades.model";
import { Clientes } from "./Clientes.model";

export class Favoritos{
    IdFavorito:number;
    Fecha:Date;
    IdCliente:number;
    IdActividad:number;
    ActividadesEntity:Actividades;
    ClientesEntity:Clientes;
}