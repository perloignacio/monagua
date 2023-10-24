using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web;
using System.Web.Http;
using API.Clases;
using MimeKit;
using monaguaRules;
using monaguaRules.Entities;
using monaguaRules.Mappers;

namespace Api.Controllers
{
    [RoutePrefix("calificaciones")]
    public class CalificacionesController : ApiController
    {
        [Route("byActividad")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult getComentarios(int idactividad,string orden)
        {
            try
            {
                CalificacionesList cl = CalificacionesMapper.Instance().GetCalificacionesByActividad(idactividad);
                switch (orden)
                {
                    case "positivas":
                        return Ok(cl.OrderByDescending(c => c.Calificacion));
                    case "negativas":
                        return Ok(cl.OrderBy(c => c.Calificacion));
                    case "nuevas":
                        return Ok(cl.OrderByDescending(c => c.Fecha));
                    case "viejas":
                        return Ok(cl.OrderBy(c => c.Fecha));
                    default:
                        return Ok(cl.OrderByDescending(c => c.Calificacion));
                }
                
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("byCompra")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult getComentariosByCompra(int idcompradetalle)
        {
            try
            {
                CalificacionesList cl = CalificacionesMapper.Instance().GetByComprasDetalle(idcompradetalle);

                if (cl.Count > 0)
                {
                    return Ok(cl[0]);
                }
                else
                {
                    return Ok();
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("responder")]
        [HttpGet]
        
        public IHttpActionResult responder(int idcalificacion, string respuesta)
        {
            try
            {
                var identity = Thread.CurrentPrincipal.Identity;
                Usuarios u = UsuariosMapper.Instance().GetOne(Convert.ToInt32(identity.Name));

                CalificacionesRules cr = new CalificacionesRules();
                cr.Responder(idcalificacion, respuesta, u.PrestadoresEntity.IdPrestador);
                enviarMailRespuesta(idcalificacion);
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("comentar")]
        [HttpGet]

        public IHttpActionResult comentar(string comentario,int calificacion,int idcompradetalle)
        {
            try
            {
                var identity = Thread.CurrentPrincipal.Identity;
                Usuarios u = UsuariosMapper.Instance().GetOne(Convert.ToInt32(identity.Name));

                CalificacionesRules cr = new CalificacionesRules();
                int id=cr.Agregar(idcompradetalle,calificacion,comentario,u.ClientesEntity.IdCliente);
                enviarMailCalificacion(id);
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }
        private void enviarMailRespuesta(int idcalificacion)
        {
            try
            {

            
                string body = String.Empty;
                var path = HttpContext.Current.Server.MapPath("~/Plantillas/respuestaComentario.html");
                var fileStream = System.IO.File.OpenRead(path);
                StreamReader reader = new StreamReader(fileStream);
                Calificaciones c = CalificacionesMapper.Instance().GetOne(idcalificacion);
                if (c != null){
                    body = reader.ReadToEnd();
                    body = body.Replace("{ubicacionlogo}", ConfiguracionMapper.Instance().GetByClave("UbicacionLogo").Valor);
                    body = body.Replace("{nombre}", c.ComprasDetalleEntity.ComprasEntity.ClientesEntity.Nombre);
                    body = body.Replace("{Fantasia}", c.ComprasDetalleEntity.ActividadesEntity.PrestadoresEntity.NombreFantasia);
                    body = body.Replace("{comentario}", c.Respuesta);
                    MimeKit.MimeMessage message = new MimeKit.MimeMessage();
                    BodyBuilder cuerpo = new BodyBuilder();

                    cuerpo.HtmlBody = body;
                    message.Subject = "Respuesta de " + c.ComprasDetalleEntity.ActividadesEntity.PrestadoresEntity.NombreFantasia;
                    message.Body = cuerpo.ToMessageBody();
                    message.From.Add(new MailboxAddress("", "hola@monagua.com.ar"));
                    message.To.Add(new MailboxAddress("", c.ComprasDetalleEntity.ComprasEntity.ClientesEntity.Email));
                    EnviaMail.Envia(message);
                }
            }
            catch (Exception ex)
            {

                
            }

        }

        private void enviarMailCalificacion(int idcalificacion)
        {
            try
            {


                string body = String.Empty;
                var path = HttpContext.Current.Server.MapPath("~/Plantillas/nuevoComentario.html");
                var fileStream = System.IO.File.OpenRead(path);
                StreamReader reader = new StreamReader(fileStream);
                Calificaciones c = CalificacionesMapper.Instance().GetOne(idcalificacion);
                if (c != null)
                {
                    body = reader.ReadToEnd();
                    body = body.Replace("{ubicacionlogo}", ConfiguracionMapper.Instance().GetByClave("UbicacionLogo").Valor);
                    body = body.Replace("{nombre}", c.ComprasDetalleEntity.ComprasEntity.ClientesEntity.Nombre);
                    body = body.Replace("{Fantasia}", c.ComprasDetalleEntity.ActividadesEntity.PrestadoresEntity.NombreFantasia);
                    body = body.Replace("{comentario}", c.Comentario);
                    body = body.Replace("{calificacion}", c.Calificacion.ToString());
                    MimeKit.MimeMessage message = new MimeKit.MimeMessage();
                    BodyBuilder cuerpo = new BodyBuilder();

                    cuerpo.HtmlBody = body;
                    message.Subject = "Nuevo comentario de " + c.ComprasDetalleEntity.ComprasEntity.ClientesEntity.Nombre;
                    message.Body = cuerpo.ToMessageBody();
                    message.From.Add(new MailboxAddress("", "hola@monagua.com.ar"));
                    message.To.Add(new MailboxAddress("", c.ComprasDetalleEntity.ActividadesEntity.PrestadoresEntity.Email));
                    EnviaMail.Envia(message);
                }
            }
            catch (Exception ex)
            {


            }

        }

    }
}
