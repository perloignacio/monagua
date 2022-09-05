using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
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
    }
}
