using Api.Clases;
using monaguaRules;
using monaguaRules.Entities;
using monaguaRules.Mappers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Api.Controllers
{
    [RoutePrefix("prestadores")]
    public class PrestadoresController : ApiController
    {
        [Route("Admin/activos")]
        [HttpGet]

        public IHttpActionResult activos()
        {
            try
            {
                return Ok(PrestadoresMapper.Instance().GetAll().Where(t => t.Activo).OrderBy(t => t.RazonSocial));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("Admin/todosAdmin")]
        [HttpGet]

        public IHttpActionResult todosAdmin()
        {
            try
            {
                return Ok(PrestadoresMapper.Instance().GetAll().OrderBy(t => t.RazonSocial));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("Admin/borrar")]
        [HttpGet]

        public IHttpActionResult Borrar(int id)
        {
            try
            {
                PrestadoresRules pr = new PrestadoresRules();
                pr.Borrar(id);
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("Admin/activar")]
        [HttpGet]

        public IHttpActionResult Activar(int id)
        {
            try
            {
                PrestadoresRules pr = new PrestadoresRules();
                pr.Activar(id);
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("registrar")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult registrar()
        {
            try
            {

                Prestadores obj = JsonConvert.DeserializeObject<Prestadores>(HttpContext.Current.Request.Unvalidated["obj"]);
                Usuarios u = JsonConvert.DeserializeObject<Usuarios>(HttpContext.Current.Request.Unvalidated["usuario"]);
                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);


                PrestadoresRules pr = new PrestadoresRules();
                Prestadores presta;
                string logo = string.Join(",",Helpers.SubeArchivos("prestadores","",false,HttpContext.Current.Request.Files));
                if (string.IsNullOrEmpty(logo))
                {
                    logo = "nologo.jpg";
                }

                presta = pr.Agregar(obj.RazonSocial,obj.NombreFantasia,obj.Cuit, obj.Email, logo,obj.PrestadorHabilitado, obj.IdLocalidad, obj.IdPais, obj.IdProvincia, obj.Politicas, obj.Telefono);
                if (presta != null)
                {
                    UsuariosRules.Agregar(u.Nombre, u.Apellido, u.Email, u.Telefono, u.Usuario, u.Contra, null, presta.IdPrestador);
                    return Ok(true);
                }
                else
                {
                    return BadRequest("Ocurrio un error");
                }






            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("editar")]
        [HttpPost]
        public IHttpActionResult editar()
        {
            try
            {

                Clientes obj = JsonConvert.DeserializeObject<Clientes>(HttpContext.Current.Request.Unvalidated["obj"]);
                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);
                ClientesRules cr = new ClientesRules();
                cr.Modificar(id, obj.Nombre, obj.Apellido, obj.Email, obj.FechaNacimiento, obj.IdLocalidad, obj.IdPais, obj.IdProvincia, obj.Sexo, obj.Telefono);
                return Ok(true);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("Admin/AgregarEditar")]
        [HttpPost]
        public IHttpActionResult AgregarEditar()
        {
            try
            {

                Usuarios obj = JsonConvert.DeserializeObject<Usuarios>(HttpContext.Current.Request.Unvalidated["obj"]);

                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);


                if (id != 0)
                {
                    UsuariosRules.Modificar(id, obj.Nombre, obj.Apellido, obj.Email, obj.Telefono, obj.Usuario, obj.Contra, null, null);
                }
                else
                {
                    UsuariosRules.Agregar(obj.Nombre, obj.Apellido, obj.Email, obj.Telefono, obj.Usuario, obj.Contra, null, null);
                }


                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }
    }
}
