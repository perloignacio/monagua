using Api.Clases;
using API.Clases;
using MimeKit;
using monaguaRules.Mappers;
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
    [RoutePrefix("contacto")]
    public class ContactosController : ApiController
    {
        [Route("enviar")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult enviar([FromBody] Contacto contacto)
        {
            try
            {
                if(string.IsNullOrEmpty(contacto.Email) || string.IsNullOrEmpty(contacto.Nombre) || string.IsNullOrEmpty(contacto.Apellido) || string.IsNullOrEmpty(contacto.Consulta))
                {
                    throw new Exception("Complete los campos obligatorios");
                }
                string body = String.Empty;
                var path = HttpContext.Current.Server.MapPath("~/Plantillas/consulta.html");
                var fileStream = System.IO.File.OpenRead(path);
                StreamReader reader = new StreamReader(fileStream);
                body = reader.ReadToEnd();
                body = body.Replace("{ubicacionlogo}", ConfiguracionMapper.Instance().GetByClave("UbicacionLogo").Valor);
                body = body.Replace("{nombre}", contacto.Nombre);
                body = body.Replace("{apellido}", contacto.Apellido);
                body = body.Replace("{email}", contacto.Email);
                body = body.Replace("{telefono}", contacto.Telefono);
                body = body.Replace("{consulta}", contacto.Consulta);

                MimeKit.MimeMessage message = new MimeKit.MimeMessage();
                BodyBuilder cuerpo = new BodyBuilder();

                cuerpo.HtmlBody = body;
                message.Subject = "Consulta " + contacto.Apellido;
                message.Body = cuerpo.ToMessageBody();
                message.From.Add(new MailboxAddress("", "hola@monagua.com.ar"));
                message.To.Add(new MailboxAddress("",ConfiguracionMapper.Instance().GetByClave("EmailConsulta").Valor));
                EnviaMail.Envia(message);
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
