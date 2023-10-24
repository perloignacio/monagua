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

                string logo = "";
                string certi = "";
                var files = HttpContext.Current.Request.Files;
                var logos = new List<HttpPostedFile>();
                var certis = new List<HttpPostedFile>();

                for (int i = 0; i < files.Count; i++)
                {
                    if (files.GetKey(i)== "Archivos[]")
                    {
                        logos.Add(files[i]);
                    }
                    if (files.GetKey(i) == "Certi[]")
                    {
                        certis.Add(files[i]);
                    }
                }
                if (logos.Count > 0)
                {
                    for (int i = 0; i <= logos.Count - 1; i++)
                    {

                        
                        string extension = Path.GetExtension(logos[i].FileName);
                        var postedFile = logos[i];
                        string fechahora = i.ToString() + "_" + DateTime.Now.ToString("ddmmyyyyhhssff") + extension;

                        var filePath = HttpContext.Current.Server.MapPath("~/assets/prestadores/" + fechahora);

                        postedFile.SaveAs(filePath);
                        logo = fechahora;
                    }

                }

                if (certis.Count > 0)
                {
                    for (int i = 0; i <= certis.Count - 1; i++)
                    {


                        string extension = Path.GetExtension(certis[i].FileName);
                        var postedFile = certis[i];
                        string fechahora = i.ToString() + "_" + DateTime.Now.ToString("ddmmyyyyhhssff") + extension;

                        var filePath = HttpContext.Current.Server.MapPath("~/assets/certificaciones/" + fechahora);

                        postedFile.SaveAs(filePath);
                        certi = fechahora;
                    }

                }


                if (string.IsNullOrEmpty(logo))
                {
                    logo = "nologo.jpg";
                }

                presta = pr.Agregar(obj.RazonSocial,obj.NombreFantasia,obj.Cuit, obj.Email, logo,obj.PrestadorHabilitado, obj.IdLocalidad, obj.IdPais, obj.IdProvincia, obj.Politicas, obj.Telefono,certi);
                if (presta != null)
                {
                    UsuariosRules uRules = new UsuariosRules();
                    uRules.Agregar(u.Nombre, u.Apellido, u.Email, u.Telefono, u.Usuario, u.Contra, null, presta.IdPrestador);
                    MailRegistro(presta);
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

        private void MailRegistro(Prestadores presta)
        {
           
                
                string body = String.Empty;
                var path = HttpContext.Current.Server.MapPath("~/Plantillas/registro.html");
                var fileStream = System.IO.File.OpenRead(path);
                StreamReader reader = new StreamReader(fileStream);
                body = reader.ReadToEnd();
                body = body.Replace("{ubicacionlogo}", ConfiguracionMapper.Instance().GetByClave("UbicacionLogo").Valor);
                body = body.Replace("{razon}", presta.RazonSocial);
                body = body.Replace("{fantasia}", presta.NombreFantasia);
                body = body.Replace("{email}", presta.Email);
                body = body.Replace("{telefono}", presta.Telefono);
                body = body.Replace("{cuit}", presta.Cuit);

                MimeKit.MimeMessage message = new MimeKit.MimeMessage();
                BodyBuilder cuerpo = new BodyBuilder();

                cuerpo.HtmlBody = body;
                message.Subject = "Registros " + presta.RazonSocial;
                message.Body = cuerpo.ToMessageBody();
                message.From.Add(new MailboxAddress("", "hola@monagua.com.ar"));
                message.To.Add(new MailboxAddress("", ConfiguracionMapper.Instance().GetByClave("EmailRegistroPrestador").Valor));
                EnviaMail.Envia(message);
                
            
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
