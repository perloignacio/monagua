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
    [RoutePrefix("usuarios")]
    public class UsuariosController : ApiController
    {
        [Route("login")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult login(string usuario, string contra)
        {
            try
            {
                string pass = Encriptar.Encrypt(contra, "S3rv3th0m3");
                Usuarios u = UsuariosMapper.Instance().Login(usuario, pass);
                if (u != null)
                {
                    u.Token = TokenGenerator.GenerateTokenJwt(u.IdUsuario.ToString());

                    return Ok(u);
                }
                else
                {
                    return BadRequest("Usuario / contraseña incorrectas");
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        

        [Route("checktoken")]
        [HttpGet]

        public IHttpActionResult checktoken()
        {
            try
            {
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("Admin/activos")]
        [HttpGet]

        public IHttpActionResult activos()
        {
            try
            {
                return Ok(UsuariosMapper.Instance().GetAll().Where(t => t.Activo).OrderBy(t => t.Apellido));
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
                return Ok(UsuariosMapper.Instance().GetAll().OrderBy(t => t.Apellido));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("Admin/Borrar")]
        [HttpGet]

        public IHttpActionResult Borrar(int id)
        {
            try
            {
                UsuariosRules.Borrar(id);
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("Admin/Activar")]
        [HttpGet]

        public IHttpActionResult Activar(int id)
        {
            try
            {
                UsuariosRules.Activar(id);
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
                    UsuariosRules.Modificar(id, obj.Nombre, obj.Apellido, obj.Email, obj.Telefono, obj.Usuario, obj.Contra,null,null);
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
