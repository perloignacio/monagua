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
using System.Threading;
using System.Web;
using System.Web.Http;

namespace Api.Controllers
{
    [RoutePrefix("prestadores")]
    public class PrestadoresController : ApiController
    {
        [Route("Admin/activos")]
        [HttpGet]
        [AllowAnonymous]
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
        [AllowAnonymous]
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
        [AllowAnonymous]
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
        [AllowAnonymous]
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
                    UsuariosRules uRules = new UsuariosRules();
                    uRules.Agregar(u.Nombre, u.Apellido, u.Email, u.Telefono, u.Usuario, u.Contra, null, presta.IdPrestador);
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

                Prestadores obj = JsonConvert.DeserializeObject<Prestadores>(HttpContext.Current.Request.Unvalidated["obj"]);
                var identity = Thread.CurrentPrincipal.Identity;
                Usuarios u = UsuariosMapper.Instance().GetOne(Convert.ToInt32(identity.Name));
                int id = u.PrestadoresEntity.IdPrestador;

                PrestadoresRules pr = new PrestadoresRules();
                string logoActual = "";
                if (HttpContext.Current.Request.Files.Count <= 0)
                {
                    logoActual = obj.Logo;
                }

                string logo = string.Join(",", Helpers.SubeArchivos("prestadores",logoActual, false, HttpContext.Current.Request.Files));
                pr.Modificar(id,obj.RazonSocial,obj.NombreFantasia,obj.Cuit,obj.Email,logo,obj.IdLocalidad,obj.IdPais,obj.IdProvincia,obj.Telefono);
                Prestadores res = PrestadoresMapper.Instance().GetOne(id);
                return Ok(res);
                

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
                UsuariosRules uRules = new UsuariosRules();

                if (id != 0)
                {
                    uRules.Modificar(id, obj.Nombre, obj.Apellido, obj.Email, obj.Telefono, obj.Usuario, obj.Contra, null, null);
                }
                else
                {
                    uRules.Agregar(obj.Nombre, obj.Apellido, obj.Email, obj.Telefono, obj.Usuario, obj.Contra, null, null);
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
