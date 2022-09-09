using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
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
    }
}
