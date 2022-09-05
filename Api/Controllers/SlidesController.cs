using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Api.Clases;
using monaguaRules;
using monaguaRules.Entities;
using monaguaRules.Mappers;
using Newtonsoft.Json;
namespace Api.Controllers
{
    [RoutePrefix("slides")]
    public class SlidesController : ApiController
    {
        [Route("todos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult todas()
        {
            try
            {
                return Ok(SlidesMapper.Instance().GetAll().Where(t => t.Activo).OrderBy(t => t.Orden));
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
                return Ok(SlidesMapper.Instance().GetAll().Where(t => t.Activo).OrderBy(t => t.Orden));
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
                return Ok(SlidesMapper.Instance().GetAll().OrderBy(t => t.Orden));
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

                SlidesRules sRules = new SlidesRules();
                sRules.Borrar(id);
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
                SlidesRules sRules = new SlidesRules();
                sRules.Activar(id);
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

                Slides obj = JsonConvert.DeserializeObject<Slides>(HttpContext.Current.Request.Unvalidated["obj"]);
                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);
                string icono = string.Join(",", Helpers.SubeArchivos("slides", "", false, HttpContext.Current.Request.Files));
                if (string.IsNullOrEmpty(icono))
                {
                    icono = "nologo.jpg";
                }

                SlidesRules sRules = new SlidesRules();
                if (id != 0)
                {
                    sRules.Modificar(id,obj.Titulo,obj.Descripcion,icono,obj.Link,obj.Orden);
                }
                else
                {
                    sRules.Agregar(obj.Titulo, obj.Descripcion,icono, obj.Link, obj.Orden);
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
