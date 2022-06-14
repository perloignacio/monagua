using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using monaguaRules.Entities;
using monaguaRules.Mappers;
namespace monaguaRules
{
    public class UsuariosRules
    {
        public static void Agregar(string nombre, string apellido, string email, string telefono, string usuario, string contra, int? idcliente, int? idprestador)
        {
            validar(usuario, contra, idcliente,idprestador, "Agregar");
            Usuarios u = new Usuarios();
            u.Apellido = apellido;
            u.Activo = true;
            u.Contra = Encriptar.Encrypt(contra, "S3rv3th0m3");
            u.Email = email;
            u.Telefono = telefono;
            u.Nombre = nombre;
            u.Usuario = usuario;
            if (idcliente.HasValue)
            {
                if (ClientesMapper.Instance().GetOne(idcliente.Value) == null)
                {
                    throw new Exception("No se encuentra el cliente");
                }
                u.IdCliente = idcliente.Value;
                u.IdPrestador = null;
            }

            if (idprestador.HasValue)
            {
                if (PrestadoresMapper.Instance().GetOne(idprestador.Value) == null)
                {
                    throw new Exception("No se encuentra el prestador");
                }
                u.IdPrestador = idprestador.Value;
                u.IdCliente = null;
            }

            UsuariosMapper.Instance().Insert(u);

        }

        public static void Modificar(int idusuario, string nombre, string apellido, string email, string telefono, string usuario, string contra, int? idcliente, int? idprestador)
        {
            validar(usuario, contra,idcliente,idprestador, "Modificar");
            Usuarios u = UsuariosMapper.Instance().GetOne(idusuario);
            if (u == null)
            {
                throw new Exception("No se encuentra el usuario");
            }
            u.Apellido = apellido;

            if (!string.IsNullOrEmpty(contra))
            {
                u.Contra = Encriptar.Encrypt(contra, "S3rv3th0m3");
            }
            u.Email = email;
            u.Nombre = nombre;
            u.Telefono = telefono;
           
            if (u.Usuario != usuario)
            {
                Usuarios aux = UsuariosMapper.Instance().GetByUsuario(usuario);
                if (aux != null)
                {
                    throw new Exception("Ya existe un usuario con ese nombre");
                }
            }
            u.Usuario = usuario;
            UsuariosMapper.Instance().Save(u);

        }

        public static void Borrar(int idusuario)
        {

            Usuarios u = UsuariosMapper.Instance().GetOne(idusuario);
            if (u == null)
            {
                throw new Exception("No se encuentra el usuario");
            }
            u.Activo = false;
            UsuariosMapper.Instance().Save(u);

        }

        public static void Activar(int idusuario)
        {

            Usuarios u = UsuariosMapper.Instance().GetOne(idusuario);
            if (u == null)
            {
                throw new Exception("No se encuentra el usuario");
            }
            u.Activo = true;
            UsuariosMapper.Instance().Save(u);

        }

        public static void validar( string usuario, string contra, int? idcliente,int? idprestador, string operacion)
        {
            
            if (string.IsNullOrEmpty(usuario))
            {
                throw new Exception("Ingrese el usuario");
            }

            if (idcliente.HasValue)
            {
                Clientes c = ClientesMapper.Instance().GetOne(idcliente.Value);
                if (c == null)
                {
                    throw new Exception("No se encuentra el cliente");
                }

            }

            if (idprestador.HasValue)
            {
                Prestadores p = PrestadoresMapper.Instance().GetOne(idprestador.Value);
                if (p == null)
                {
                    throw new Exception("No se encuentra el prestador");
                }

            }

            if (operacion == "Agregar")
            {
                if (string.IsNullOrEmpty(contra))
                {
                    throw new Exception("Ingrese el contra");
                }

                Usuarios u = UsuariosMapper.Instance().GetByUsuario(usuario);
                if (u != null)
                {
                    throw new Exception("Ya existe un usuario con ese nombre");
                }
            }

        }
    }
}
