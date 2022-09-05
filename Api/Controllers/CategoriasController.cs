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
    [RoutePrefix("categorias")]
    public class CategoriasController : ApiController
    {
        [Route("Admin/activos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult activos()
        {
            try
            {
                return Ok(CategoriasMapper.Instance().GetAll().Where(t => t.Activa).OrderBy(t => t.Nombre));
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
                return Ok(CategoriasMapper.Instance().GetAll().OrderBy(t => t.Nombre));
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

                CategoriasRules Crules = new CategoriasRules();
                Crules.Borrar(id);
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
                CategoriasRules Crules = new CategoriasRules();
                Crules.Activar(id);
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

                Categorias obj = JsonConvert.DeserializeObject<Categorias>(HttpContext.Current.Request.Unvalidated["obj"]);
                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);
                string icono = string.Join(",", Helpers.SubeArchivos("categorias", "", false, HttpContext.Current.Request.Files));
                if (string.IsNullOrEmpty(icono))
                {
                    icono = "nologo.jpg";
                }

                CategoriasRules Crules = new CategoriasRules();
                if (id != 0)
                {
                    Crules.Modificar(id, obj.Nombre,icono);
                }
                else
                {
                    Crules.Agregar(obj.Nombre,icono);
                }


                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("todas")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult todas()
        {
            try
            {
                return Ok(CategoriasMapper.Instance().GetAll().Where(t => t.Activa).OrderBy(t => t.Nombre));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
