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
    [RoutePrefix("cupones")]
    public class CuponesController : ApiController
    {
        [Route("Admin/activos")]
        [HttpGet]

        public IHttpActionResult activos()
        {
            try
            {
                return Ok(DescuentosMapper.Instance().GetAll().Where(t => t.Activo).OrderBy(t => t.Nombre));
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
                return Ok(DescuentosMapper.Instance().GetAll().OrderBy(t => t.Nombre));
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
                DescuentosRules dRules = new DescuentosRules();
                dRules.Borrar(id);
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
                DescuentosRules dRules = new DescuentosRules();

                dRules.Activar(id);
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

                Descuentos obj = JsonConvert.DeserializeObject<Descuentos>(HttpContext.Current.Request.Unvalidated["obj"]);

                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);

                DescuentosRules dRules = new DescuentosRules();
                if (id != 0)
                {
                    dRules.Modificar(id, obj.Nombre,obj.Codigo,obj.Monto,obj.Porcentaje,obj.Stock,obj.FechaDesde,obj.FechaHasta);
                }
                else
                {
                    dRules.Agregar(obj.Nombre, obj.Codigo, obj.Monto, obj.Porcentaje, obj.Stock, obj.FechaDesde, obj.FechaHasta);
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
