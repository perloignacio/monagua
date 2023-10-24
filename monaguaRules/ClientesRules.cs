using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using monaguaRules.Entities;
using monaguaRules.Mappers;
namespace monaguaRules
{
    public class ClientesRules
    {
        public Clientes Agregar(string nombre,string apellido,string email,DateTime? fechnac,int? idlocalidad,int? idpais,int? idprovincia,bool novedades,bool politicas,string sexo,string telefono)
        {
            validar(nombre,apellido,email,idlocalidad,idpais,idprovincia,politicas,"agregar");

            var clientes = new Clientes();
            clientes.Nombre = nombre;
            clientes.Activo = true;
            clientes.Apellido = apellido;
            clientes.Email = email;
            if (fechnac.HasValue)
            {
                clientes.FechaNacimiento = fechnac.Value;
            }
            
            clientes.FechaRegistro = DateTime.Now;
            if (idlocalidad.HasValue)
            {
                clientes.IdLocalidad = idlocalidad;
            }

            if (idpais.HasValue)
            {
                clientes.IdPais = idpais;
            }

            if (idprovincia.HasValue)
            {
                clientes.IdProvincia = idprovincia;
            }
            
            clientes.Novedades = novedades;
            clientes.Politicas = politicas;
            clientes.Sexo = sexo;
            clientes.Telefono = telefono;

            ClientesMapper.Instance().Insert(clientes);
            return clientes;
        }

        public void Modificar(int idcliente,string nombre, string apellido, string email, DateTime? fechnac, int? idlocalidad, int? idpais, int? idprovincia, string sexo, string telefono)
        {
            validar(nombre, apellido, email, idlocalidad, idpais, idprovincia, true,"modificar");

            var clientes = new Clientes();
            clientes = ClientesMapper.Instance().GetOne(idcliente);
            if (clientes == null)
            {
                throw new Exception("No se encuentra el cliente");
            }
            clientes.Nombre = nombre;
            clientes.Apellido = apellido;
            clientes.Email = email;
            if (fechnac.HasValue)
            {
                clientes.FechaNacimiento = fechnac.Value;
            }

            
            if (idlocalidad.HasValue)
            {
                clientes.IdLocalidad = idlocalidad;
            }

            if (idpais.HasValue)
            {
                clientes.IdPais = idpais;
            }

            if (idprovincia.HasValue)
            {
                clientes.IdProvincia = idprovincia;
            }

            clientes.Sexo = sexo;
            clientes.Telefono = telefono;

            ClientesMapper.Instance().Save(clientes);

        }

        public void Borrar(int idcliente)
        {
            

            var clientes = new Clientes();
            clientes = ClientesMapper.Instance().GetOne(idcliente);
            if (clientes == null)
            {
                throw new Exception("No se encuentra el cliente");
            }
            clientes.Activo = false;

            ClientesMapper.Instance().Save(clientes);

        }

        public void Activar(int idcliente)
        {


            var clientes = new Clientes();
            clientes = ClientesMapper.Instance().GetOne(idcliente);
            if (clientes == null)
            {
                throw new Exception("No se encuentra el cliente");
            }
            clientes.Activo = true;

            ClientesMapper.Instance().Save(clientes);

        }
        public void validar(string nombre, string apellido, string email, int? idlocalidad, int? idpais, int? idprovincia, bool politicas,string accion)
        {
            if (accion == "agregar")
            {
                Usuarios u = UsuariosMapper.Instance().GetByUsuario(email);
                if (u != null)
                {
                    throw new Exception("Ya existe un usuario creado con ese email");
                }
            }

            if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("Ingrese el nombre");
            }
            if (string.IsNullOrEmpty(apellido))
            {
                throw new Exception("Ingrese el apellido");
            }
            if (string.IsNullOrEmpty(email))
            {
                throw new Exception("Ingrese el email");
            }
            if (idpais.HasValue)
            {
                if (PaisesMapper.Instance().GetOne(idpais.Value) == null)
                {
                    throw new Exception("No se encuentra el pais");
                }
            }
            if (idprovincia.HasValue)
            {
                if (ProvinciasMapper.Instance().GetOne(idprovincia.Value) == null)
                {
                    throw new Exception("No se encuentra la provincia");
                }
            }
            if (idlocalidad.HasValue)
            {
                if (LocalidadesMapper.Instance().GetOne(idlocalidad.Value) == null)
                {
                    throw new Exception("No se encuentra la localidad");
                }
            }

            if (idlocalidad.HasValue)
            {
                if (LocalidadesMapper.Instance().GetOne(idlocalidad.Value) == null)
                {
                    throw new Exception("No se encuentra la localidad");
                }
            }
            if (!politicas)
            {
                throw new Exception("Debe aceptar los terminos y condiciones");
            }
        }
    }
}
