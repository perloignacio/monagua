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
        [AllowAnonymous]
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
        [AllowAnonymous]
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
        [AllowAnonymous]
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
                    UsuariosRules uRules = new UsuariosRules();
                    int idusuario=uRules.Agregar(u.Nombre, u.Apellido, u.Email, u.Telefono, u.Usuario, u.Contra,cli.IdCliente, null);
                    mailRegistro(idusuario);
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

        private void mailRegistro(int idusuario) {
            string body = String.Empty;
            Usuarios u=UsuariosMapper.Instance().GetOne(idusuario);
            var path = HttpContext.Current.Server.MapPath("~/Plantillas/nuevoUsuario.html");
            var fileStream = System.IO.File.OpenRead(path);
            StreamReader reader = new StreamReader(fileStream);
            body = reader.ReadToEnd();
            body = body.Replace("{domain}", ConfiguracionMapper.Instance().GetByClave("Dominio").Valor);
            body = body.Replace("{ubicacionlogo}", "img/logo-servet-home.png");
            string nombre = "";
            string email = "";
            if (u.ClientesEntity != null)
            {
                nombre = u.ClientesEntity.Nombre;
                email = u.ClientesEntity.Email;
            }
            else
            {
                nombre = u.PrestadoresEntity.RazonSocial;
                email = u.PrestadoresEntity.Email;
            }
            body = body.Replace("{nombre}", nombre);
            body = body.Replace("{email_recuperar}", ConfiguracionMapper.Instance().GetByClave("MailInstitucional").Valor);

            MimeKit.MimeMessage message = new MimeKit.MimeMessage();
            BodyBuilder cuerpo = new BodyBuilder();





            cuerpo.HtmlBody = body;
            message.Subject = "Bienvenido a Monagua";
            message.Body = cuerpo.ToMessageBody();
            message.From.Add(new MailboxAddress("", ConfiguracionMapper.Instance().GetByClave("MailInstitucional").Valor));
            message.To.Add(new MailboxAddress("", email));
            EnviaMail.Envia(message);
        }

        [Route("editar")]
        [HttpPost]
        public IHttpActionResult editar()
        {
            try
            {

                Clientes obj = JsonConvert.DeserializeObject<Clientes>(HttpContext.Current.Request.Unvalidated["obj"]);
                //int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);
                var identity = Thread.CurrentPrincipal.Identity;
                Usuarios u = UsuariosMapper.Instance().GetOne(Convert.ToInt32(identity.Name));
                int id = u.ClientesEntity.IdCliente;

                ClientesRules cr = new ClientesRules();
                cr.Modificar(id,obj.Nombre, obj.Apellido, obj.Email, obj.FechaNacimiento, obj.IdLocalidad, obj.IdPais, obj.IdProvincia,obj.Sexo, obj.Telefono);

                Clientes res = ClientesMapper.Instance().GetOne(id);
                return Ok(res);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("favoritos")]
        [HttpGet]
        public IHttpActionResult favoritos()
        {
            try
            {

                
                //int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);
                var identity = Thread.CurrentPrincipal.Identity;
                Usuarios u = UsuariosMapper.Instance().GetOne(Convert.ToInt32(identity.Name));
                int id = u.ClientesEntity.IdCliente;
                //int id = 3;
                List<Favoritos> favs = FavoritosMapper.Instance().GetByClientes(id).ToList();
                return Ok(favs);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }


        [Route("quitarFavoritos")]
        [HttpGet]
        public IHttpActionResult QuitarFavoritos(int idactividad)
        {
            try
            {


                //int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);
                var identity = Thread.CurrentPrincipal.Identity;
                Usuarios u = UsuariosMapper.Instance().GetOne(Convert.ToInt32(identity.Name));
                int id = u.ClientesEntity.IdCliente;
                //int id = 3;
                FavoritosRules favRules = new FavoritosRules();
                favRules.Borrar(idactividad, id);
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
