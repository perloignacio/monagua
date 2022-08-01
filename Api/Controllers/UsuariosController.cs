using Api.Clases;
using API.Clases;
using MimeKit;
using monaguaRules;
using monaguaRules.Entities;
using monaguaRules.Mappers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

        [Route("blanqueo")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult blanqueo()
        {
            objBlanqueo obj = JsonConvert.DeserializeObject<objBlanqueo>(HttpContext.Current.Request.Unvalidated["obj"]);
            int idusuario = Convert.ToInt32(obj.Hash.Split('-')[0]);
            Usuarios u = UsuariosMapper.Instance().GetOne(idusuario);
            if (Encriptar.Encrypt(u.Usuario + u.IdUsuario.ToString(), "S3rv3th0m3") == obj.Hash.Split('-')[1] + "=")
            {
                u.Contra = Encriptar.Encrypt(obj.Contra, "S3rv3th0m3");
                UsuariosMapper.Instance().Save(u);
                return Ok(true);
            }
            else
            {
                return Ok(false);
            }

        }

        [Route("recuperar")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult recuperar(string usuario)
        {

            try
            {
                Usuarios u = UsuariosMapper.Instance().GetByUsuario(usuario);
                if (u != null)
                {
                    string body = String.Empty;
                    var path = HttpContext.Current.Server.MapPath("~/Plantillas/recuperar.html");
                    var fileStream = System.IO.File.OpenRead(path);
                    StreamReader reader = new StreamReader(fileStream);
                    body = reader.ReadToEnd();
                    body = body.Replace("{domain}", ConfiguracionMapper.Instance().GetByClave("Dominio").Valor);
                    body = body.Replace("{hash}", u.IdUsuario.ToString() + "-" + Encriptar.Encrypt(u.Usuario+u.IdUsuario.ToString(), "S3rv3th0m3"));
                    body = body.Replace("{ubicacionlogo}", "img/logo-servet-home.png");
                    body = body.Replace("{nombre}", u.Nombre);
                    body = body.Replace("{email_recuperar}", ConfiguracionMapper.Instance().GetByClave("MailInstitucional").Valor);

                    MimeKit.MimeMessage message = new MimeKit.MimeMessage();
                    BodyBuilder cuerpo = new BodyBuilder();





                    cuerpo.HtmlBody = body;
                    message.Subject = "Recuperar contraseña";
                    message.Body = cuerpo.ToMessageBody();
                    message.From.Add(new MailboxAddress("", ConfiguracionMapper.Instance().GetByClave("MailInstitucional").Valor));
                    message.To.Add(new MailboxAddress("", u.Email));
                    EnviaMail.Envia(message);
                    return Ok(true);
                }
                else
                {
                    return BadRequest("No se puedo realizar la accion");
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
        [AllowAnonymous]
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
        [AllowAnonymous]
        public IHttpActionResult todosAdmin()
        {
            try
            {
                return Ok(UsuariosMapper.Instance().GetAll().Where(t=> t.ClientesEntity == null && t.PrestadoresEntity == null).OrderBy(t => t.Apellido));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("Admin/Borrar")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Borrar(int id)
        {
            try
            {
                UsuariosRules uRules = new UsuariosRules();
                uRules.Borrar(id);
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("Admin/Activar")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Activar(int id)
        {
            try
            {
                UsuariosRules uRules = new UsuariosRules();
                uRules.Activar(id);
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("Admin/AgregarEditar")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar()
        {
            try
            {

                Usuarios obj = JsonConvert.DeserializeObject<Usuarios>(HttpContext.Current.Request.Unvalidated["obj"]);

                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);

                UsuariosRules uRules = new UsuariosRules();
                if (id != 0)
                {
                    uRules.Modificar(id, obj.Nombre, obj.Apellido, obj.Email, obj.Telefono, obj.Usuario, obj.Contra,null,null);
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
