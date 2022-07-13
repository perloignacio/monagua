using monaguaRules;
using monaguaRules.Entities;
using monaguaRules.Mappers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web;
using System.Web.Http;

namespace Api.Controllers
{
    [RoutePrefix("compras")]
    public class ComprasController : ApiController
    {
        [Route("validar")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult validar([FromBody] ComprasDetalle obj)
        {
            try
            {
                ActividadesRules acRules=new ActividadesRules();
                List<ActividadesHorarios> lista = acRules.ConfiguraHorarios(obj.IdActividad,true);
                ActividadesHorarios ac;
                ac=lista.Find(h=>h.FechaInicio==obj.FechaHora);
                if (ac == null)
                {
                    var error = new { estado = "Error", mensaje = "No se encuentra el horario" };
                    return Ok(error);
                }
                if (!ac.ActividadesEntity.Activa )
                {
                    var error = new { estado = "Error", mensaje = "La actividad no se encuentra activa" };
                    return Ok(error);
                }
                if (obj.Cantidad > ac.Capacidad)
                {
                    var error = new { estado = "Error", mensaje = "No disponemos de ese cupo, el maximo es " + ac.Capacidad };
                    return Ok(error);
                }

                if (obj.Cantidad ==0)
                {
                    var error = new { estado = "Error", mensaje = "Debe indicar la cantidad de personas"};
                    return Ok(error);
                }

                var ok = new { estado = "OK", mensaje = "" };
                return Ok(ok);





            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("agregar")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult agregar([FromBody] Compras obj)
        {
            try
            {
                ComprasRules cRules =new ComprasRules();
                if (obj.IdObjeto == 0)
                {
                    return Ok(cRules.AgregarCarrito(obj));
                }
                else
                {
                    return Ok(cRules.AgregarItem(obj));
                }
                

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

    }
}
