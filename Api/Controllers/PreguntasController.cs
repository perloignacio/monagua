using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using monaguaRules;
using monaguaRules.Entities;
using monaguaRules.Mappers;
using Newtonsoft.Json;

namespace Api.Controllers
{
    [RoutePrefix("preguntas")]
    public class PreguntasController : ApiController
    {
        [Route("todas")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult todas()
        {
            try
            {
                return Ok(PreguntasFrecuentesMapper.Instance().GetAll().Where(t => t.Activa).OrderBy(t => t.Orden));
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
                return Ok(PreguntasFrecuentesMapper.Instance().GetAll().Where(t => t.Activa).OrderBy(t => t.Orden));
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
                return Ok(PreguntasFrecuentesMapper.Instance().GetAll().OrderBy(t => t.Orden));
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

                PreguntasRules prules = new PreguntasRules();
                prules.Borrar(id);
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
                PreguntasRules prules = new PreguntasRules();
                prules.Activar(id);
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

                PreguntasFrecuentes obj = JsonConvert.DeserializeObject<PreguntasFrecuentes>(HttpContext.Current.Request.Unvalidated["obj"]);
                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);


                PreguntasRules prules = new PreguntasRules();
                if (id != 0)
                {
                    prules.Modificar(id, obj.Pregunta,obj.Respuesta,obj.Orden);
                }
                else
                {
                    prules.Agregar(obj.Pregunta, obj.Respuesta, obj.Orden);
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
