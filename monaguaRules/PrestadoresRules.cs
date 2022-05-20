using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using monaguaRules.Entities;
using monaguaRules.Mappers;
namespace monaguaRules
{
    public class PrestadoresRules
    {
        public Prestadores Agregar(string razonsocial, string fantasia, string cuit, string email,string logo, bool prestadorHabilitado, int? idlocalidad, int? idpais, int? idprovincia,bool politicas, string telefono)
        {
            validar(razonsocial, fantasia, email, idlocalidad, idpais, idprovincia, politicas,telefono,logo);

            var pr = new Prestadores();
            pr.NombreFantasia = fantasia;
            pr.Activo = true;
            pr.RazonSocial = razonsocial;
            pr.Email = email;


            pr.FechaRegistro = DateTime.Now;
            if (idlocalidad.HasValue)
            {
                pr.IdLocalidad = idlocalidad.Value;
            }

            if (idpais.HasValue)
            {
                pr.IdPais = idpais.Value;
            }

            if (idprovincia.HasValue)
            {
                pr.IdProvincia = idprovincia.Value;
            }
            pr.PrestadorHabilitado = prestadorHabilitado;
            pr.Logo = logo;
            pr.Politicas = politicas;
            pr.Telefono = telefono;

            PrestadoresMapper.Instance().Insert(pr);
            return pr;
        }

        public void Modificar(int idprestador, string razonsocial, string fantasia, string cuit, string email, string logo, bool prestadorHabilitado, int? idlocalidad, int? idpais, int? idprovincia, bool politicas, string telefono)
        {
            validar(razonsocial, fantasia, email, idlocalidad, idpais, idprovincia, politicas, telefono, logo);

            var pr = new Prestadores();
            pr = PrestadoresMapper.Instance().GetOne(idprestador);
            if (pr == null)
            {
                throw new Exception("No se encuentra el prestador");
            }
            pr.NombreFantasia = fantasia;
            pr.Activo = true;
            pr.RazonSocial = razonsocial;
            pr.Email = email;


            pr.FechaRegistro = DateTime.Now;
            if (idlocalidad.HasValue)
            {
                pr.IdLocalidad = idlocalidad.Value;
            }

            if (idpais.HasValue)
            {
                pr.IdPais = idpais.Value;
            }

            if (idprovincia.HasValue)
            {
                pr.IdProvincia = idprovincia.Value;
            }
            pr.PrestadorHabilitado = prestadorHabilitado;
            pr.Logo = logo;
            pr.Politicas = politicas;
            pr.Telefono = telefono;

            PrestadoresMapper.Instance().Save(pr);

        }

        public void Borrar(int idprestador)
        {


            var pr = new Prestadores();
            pr = PrestadoresMapper.Instance().GetOne(idprestador);
            if (pr == null)
            {
                throw new Exception("No se encuentra el prestador");
            }
            pr.Activo = false;

            PrestadoresMapper.Instance().Save(pr);

        }

        public void Activar(int idprestador)
        {


            var pr = new Prestadores();
            pr = PrestadoresMapper.Instance().GetOne(idprestador);
            if (pr == null)
            {
                throw new Exception("No se encuentra el prestador");
            }
            pr.Activo = true;

            PrestadoresMapper.Instance().Save(pr);

        }
        public void validar(string nombre, string apellido, string email, int? idlocalidad, int? idpais, int? idprovincia, bool politicas, string telefono, string logo)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("Ingrese el nombre");
            }
            if (string.IsNullOrEmpty(apellido))
            {
                throw new Exception("Ingrese el apellido");
            }
            if (string.IsNullOrEmpty(telefono))
            {
                throw new Exception("Ingrese el telefono");
            }
            if (string.IsNullOrEmpty(logo))
            {
                throw new Exception("Ingrese el logo");
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
