using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using monaguaRules;
using monaguaRules.Entities;
using monaguaRules.Mappers;
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
    }
}
