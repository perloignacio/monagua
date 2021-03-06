using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web;
using System.Web.Http;
using Api.Clases;
using monaguaRules;
using monaguaRules.Entities;
using monaguaRules.Mappers;
using Newtonsoft.Json;

namespace Api.Controllers
{
    [RoutePrefix("actividades")]
    public class ActividadesController : ApiController
    {

        [Route("getHorarios")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult getHorarios(int idactividad)
        {
            try
            {
                ActividadesRules Arules = new ActividadesRules();
                

                return Ok(Arules.ConfiguraHorarios(idactividad,false));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("modificarHorario")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult modificarHorario()
        {
            try
            {
                ActividadesHorarios obj = JsonConvert.DeserializeObject<ActividadesHorarios>(HttpContext.Current.Request.Unvalidated["obj"]);
                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);

                ActividadesRules Arules = new ActividadesRules();
                Arules.ModificarHorario(id, obj.IdTipoRepeticion,obj.Capacidad, obj.FechaInicio, obj.HoraDesde, obj.HoraHasta);

                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("modificarUnHorario")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult ModificarUnHorario()
        {
            try
            {
                ActividadesHorarios obj = JsonConvert.DeserializeObject<ActividadesHorarios>(HttpContext.Current.Request.Unvalidated["obj"]);
                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);

                ActividadesRules Arules = new ActividadesRules();
                Arules.ModificarUnHorario(id, obj.Capacidad,obj.FechaInicio, obj.HoraDesde, obj.HoraHasta);

                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("modificarSiguientesHorario")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult ModificarSiguientesHorario()
        {
            try
            {
                ActividadesHorarios obj = JsonConvert.DeserializeObject<ActividadesHorarios>(HttpContext.Current.Request.Unvalidated["obj"]);
                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);
                string sfin = HttpContext.Current.Request.Unvalidated["fin"];

                ActividadesRules Arules = new ActividadesRules();
                Arules.ModificarSiguientes(id,DateTime.Parse(sfin), obj.IdTipoRepeticion,obj.Capacidad.Value, obj.FechaInicio, obj.HoraDesde, obj.HoraHasta);

                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }


        [Route("borrarHorario")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult borrarHorario()
        {
            try
            {
                ActividadesHorarios obj = JsonConvert.DeserializeObject<ActividadesHorarios>(HttpContext.Current.Request.Unvalidated["obj"]);
                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);

                ActividadesRules Arules = new ActividadesRules();
                Arules.BorrarHorario(id);

                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("borrarUnHorario")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult borrarUnHorario()
        {
            try
            {
                ActividadesHorarios obj = JsonConvert.DeserializeObject<ActividadesHorarios>(HttpContext.Current.Request.Unvalidated["obj"]);
                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);

                ActividadesRules Arules = new ActividadesRules();
                Arules.BorrarUnHorario(id,obj.FechaInicio);

                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("borrarSiguientesHorario")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult borrarSiguientesHorario()
        {
            try
            {
                ActividadesHorarios obj = JsonConvert.DeserializeObject<ActividadesHorarios>(HttpContext.Current.Request.Unvalidated["obj"]);
                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);
                string sfin = HttpContext.Current.Request.Unvalidated["fin"];

                ActividadesRules Arules = new ActividadesRules();
                Arules.BorrarSiguientes(id,DateTime.Parse(sfin));

                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("agregarHorario")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult agregarHorario()
        {
            try
            {

                ActividadesHorarios obj = JsonConvert.DeserializeObject<ActividadesHorarios>(HttpContext.Current.Request.Unvalidated["obj"]);

                
                ActividadesRules Arules = new ActividadesRules();
                Arules.AgregarHorario(obj.IdActividad, obj.IdTipoRepeticion, obj.FechaInicio, obj.HoraDesde, obj.HoraHasta, obj.FechaFin, obj.Capacidad);

                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("AgregarEditar")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult AgregarEditar()
        {
            try
            {

                Actividades obj = JsonConvert.DeserializeObject<Actividades>(HttpContext.Current.Request.Unvalidated["obj"]);

                int id = JsonConvert.DeserializeObject<int>(HttpContext.Current.Request.Unvalidated["id"]);
                var identity = Thread.CurrentPrincipal.Identity;
                Usuarios u = UsuariosMapper.Instance().GetOne(Convert.ToInt32(identity.Name));

                Actividades aux;
                ActividadesRules Arules = new ActividadesRules();
                if (id != 0)
                {
                    aux = ActividadesMapper.Instance().GetOne(id);
                    string fotos = string.Join(",", Helpers.SubeArchivos("actividades", aux.Fotos, false, HttpContext.Current.Request.Files));
                    Arules.Modificar(id, obj.Nombre,obj.DescripcionCorta,obj.Descripcion,obj.Precio,obj.Duracion,obj.IdCategoria,u.PrestadoresEntity.IdPrestador,fotos,obj.Video,obj.Ubicacion,obj.Mapa,obj.PrecioOferta,obj.Mascotas,obj.PersonasCapacidadRed,obj.DietasEspeciales,obj.Idiomas,obj.Dificultad,obj.QueIncluye,obj.QueNoIncluye);
                }
                else
                {
                    string fotos = string.Join(",", Helpers.SubeArchivos("actividades", "", false, HttpContext.Current.Request.Files));
                    aux=Arules.Agregar(obj.Nombre, obj.DescripcionCorta, obj.Descripcion, obj.Precio, obj.Duracion, obj.IdCategoria, u.PrestadoresEntity.IdPrestador, fotos, obj.Video, obj.Ubicacion, obj.Mapa, obj.PrecioOferta, obj.Mascotas, obj.PersonasCapacidadRed, obj.DietasEspeciales, obj.Idiomas, obj.Dificultad, obj.QueIncluye, obj.QueNoIncluye);
                }


                return Ok(aux);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }


        [Route("Activas")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetActivas()
        {
            try
            {

                List<Actividades> lac=new List<Actividades>();
                lac = ActividadesMapper.Instance().GetAll().Where(a => a.Activa).ToList();

                return Ok(lac);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("Ficha")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Ficha(int id)
        {
            try
            {

                Actividades ac = ActividadesMapper.Instance().GetOne(id);
                if (ac != null)
                {
                    if (ac.Activa)
                    {
                        ActividadesRules acR = new ActividadesRules();
                        ac.Horarios=acR.ConfiguraHorarios(ac.IdActividad,true);
                        return Ok(ac);
                    }
                    else
                    {
                        return BadRequest("Actividad inexistente");
                    }
                    
                }
                else
                {
                    return BadRequest("Actividad inexistente");
                }


            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }


    }
}
