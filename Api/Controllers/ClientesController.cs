using API.Clases;
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
    [RoutePrefix("clientes")]
    public class ClientesController : ApiController
    {
        [Route("Admin/activos")]
        [HttpGet]

        public IHttpActionResult activos()
        {
            try
            {
                return Ok(ClientesMapper.Instance().GetAll().Where(t => t.Activo).OrderBy(t => t.Apellido));
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
                return Ok(ClientesMapper.Instance().GetAll().OrderBy(t => t.Apellido));
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
                ClientesRules cr = new ClientesRules();
                cr.Borrar(id);
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
                ClientesRules cr = new ClientesRules();
                cr.Activar(id);
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

                Clientes obj = JsonConvert.DeserializeObject<Clientes>(HttpContext.Current.Request.Unvalidated["obj"]);
                Usuarios u = JsonConvert.DeserializeObject<Usuarios>(HttpContext.Current.Request.Unvalidated["usuario"]);
                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);
                ClientesRules cr =new  ClientesRules();
                Clientes cli;
                cli=cr.Agregar(obj.Nombre, obj.Apellido, obj.Email, obj.FechaNacimiento, obj.IdLocalidad, obj.IdPais, obj.IdProvincia, obj.Novedades, obj.Politicas, obj.Sexo, obj.Telefono);
                if (cli != null)
                {
                    UsuariosRules.Agregar(u.Nombre, u.Apellido, u.Email, u.Telefono, u.Usuario, u.Contra,cli.IdCliente, null);
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
                cr.Modificar(id,obj.Nombre, obj.Apellido, obj.Email, obj.FechaNacimiento, obj.IdLocalidad, obj.IdPais, obj.IdProvincia,obj.Sexo, obj.Telefono);
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
