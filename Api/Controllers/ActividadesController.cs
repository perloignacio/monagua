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
using Newtonsoft.Json.Linq;

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
                string algo = null;

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
                foreach (var item in lac)
                {
                    CalificacionesList cl=CalificacionesMapper.Instance().GetCalificacionesByActividad(item.IdActividad);
                    decimal acu = 0;
                    foreach (var cali in cl)
                    {
                        acu += cali.Calificacion;
                    }
                    if (acu != 0)
                    {
                        item.Calificacion = acu / cl.Count;
                    }
                    else
                    {
                        item.Calificacion = 0;
                    }
                    item.cantCalificaciones = cl.Count();

                }
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
                        CalificacionesList cl = CalificacionesMapper.Instance().GetCalificacionesByActividad(ac.IdActividad);
                        decimal acu = 0;
                        foreach (var cali in cl)
                        {
                            acu += cali.Calificacion;
                        }
                        if (acu != 0)
                        {
                            ac.Calificacion = acu / cl.Count;
                        }
                        else
                        {
                            ac.Calificacion = 0;
                        }
                        ac.cantCalificaciones = cl.Count();
                        ac.calificacionesList = cl.OrderByDescending(c=>c.Calificacion).ToList();
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

        [Route("byCategoria")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult byCategoria(int idcategoria)
        {
            try
            {

                List<Actividades> lac = new List<Actividades>();
                lac = ActividadesMapper.Instance().GetAll().Where(a => a.Activa && a.IdCategoria==idcategoria).ToList();
                foreach (var item in lac)
                {
                    CalificacionesList cl = CalificacionesMapper.Instance().GetCalificacionesByActividad(item.IdActividad);
                    decimal acu = 0;
                    foreach (var cali in cl)
                    {
                        acu += cali.Calificacion;
                    }
                    if (acu != 0)
                    {
                        item.Calificacion = acu / cl.Count;
                    }
                    else
                    {
                        item.Calificacion = 0;
                    }
                    item.cantCalificaciones = cl.Count();

                }
                return Ok(lac);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("filtrar")]
        [HttpPost]
        [AllowAnonymous]
        public IHttpActionResult filtrar(int pagina,string orden)
        {
            try
            {
                List<object> filtros=JsonConvert.DeserializeObject<List<object>>(HttpContext.Current.Request.Unvalidated["filtros"]);
                ActividadesRules acR = new ActividadesRules();

                listadoActividades result = new listadoActividades();
                List<Actividades> lac = new List<Actividades>();
                List<Categorias> lcat = new List<Categorias>();
                List<Provincias> lprov = new List<Provincias>();
                List<Prestadores> lpresta = new List<Prestadores>();

                int? ubicacion= null;
                int? categoria = null;
                int? prestador = null;
                int? duracion = null;
                int? capacidad = null;
                int? mascotas = null;
                int? dietas = null;
                int? promo = null;
                string dificultad = "";
                string idiomas = "";
                DateTime? fecha = null;
                foreach (var item in filtros)
                {
                    JObject json = JObject.Parse(JsonConvert.SerializeObject(item));
                    if (json["tipo"].ToString()=="ubicacion") {
                        ubicacion = int.Parse(json["value"].ToString());
                    }
                    if (json["tipo"].ToString() == "categoria")
                    {
                        categoria = int.Parse(json["value"].ToString());
                    }
                    if (json["tipo"].ToString() == "prestador")
                    {
                        prestador = int.Parse(json["value"].ToString());
                    }
                    if (json["tipo"].ToString() == "duracion")
                    {
                        duracion = int.Parse(json["value"].ToString());
                    }

                    if (json["tipo"].ToString() == "mascotas")
                    {
                        mascotas = int.Parse(json["value"].ToString());
                    }

                    if (json["tipo"].ToString() == "capacidades reducidas")
                    {
                        capacidad = int.Parse(json["value"].ToString());
                    }

                    if (json["tipo"].ToString() == "dificultad")
                    {
                        dificultad = json["value"].ToString();
                    }

                    if (json["tipo"].ToString() == "idiomas")
                    {
                        idiomas = json["value"].ToString();
                    }
                    if (json["tipo"].ToString() == "dietas")
                    {
                        dietas = int.Parse(json["value"].ToString());
                    }
                    if (json["tipo"].ToString() == "promo")
                    {
                        promo = int.Parse(json["value"].ToString());
                    }
                    if (json["tipo"].ToString() == "fecha")
                    {
                        fecha = DateTime.Parse(json["value"].ToString());
                    }


                }

                dsMonagua ds = new dsMonagua();
                dsMonaguaTableAdapters.filtrarActividadesTableAdapter ta = new dsMonaguaTableAdapters.filtrarActividadesTableAdapter();
                ta.Fill(ds.filtrarActividades,categoria, ubicacion, duracion, prestador, mascotas, capacidad,dietas, promo, idiomas,dificultad);

                int porpagina = 5;

                double paginas = (double) ds.filtrarActividades.Rows.Count / porpagina;
                result.cantPaginas = Convert.ToInt32(Math.Ceiling(paginas));
                foreach (dsMonagua.filtrarActividadesRow item in ds.filtrarActividades.AsEnumerable().Skip(pagina * porpagina).Take(porpagina))
                {

                    Actividades ac = ActividadesMapper.Instance().GetOne(item.IdActividad);
                    lcat.Add(new Categorias(item.IdCategoria, item.categoria, true, ""));
                    lprov.Add(new Provincias(item.IdProvincia, item.Provincia, null));
                    lpresta.Add(new Prestadores(item.IdPrestador, item.RazonSocial, item.NombreFantasia, "", 1, 1, 1, "", "", DateTime.Now, true, true, true, ""));
                    CalificacionesList cl = CalificacionesMapper.Instance().GetCalificacionesByActividad(ac.IdActividad);
                    decimal acu = 0;
                    foreach (var cali in cl)
                    {
                        acu += cali.Calificacion;
                    }

                    if (acu != 0)
                    {
                        ac.Calificacion = acu / cl.Count;
                    }
                    else
                    {
                        ac.Calificacion = 0;
                    }
                    ac.cantCalificaciones = cl.Count();
                    ac.Horarios = acR.ConfiguraHorarios(ac.IdActividad, true);
                    lac.Add(ac);

                }
               



                result.provincias = lprov.GroupBy(p=>p.Nombre).Select(p=>p.First()).ToList();
                result.categorias = lcat.GroupBy(c => c.Nombre).Select(c => c.First()).ToList();
                result.actividades = lac;
                result.prestadores=lpresta.GroupBy(c => c.NombreFantasia).Select(c => c.First()).ToList();
                result.duracion = lac.Select(a => a.Duracion).Distinct().OrderBy(d=>d).ToList();
                result.dificultades= lac.Select(a => a.Dificultad).Distinct().OrderBy(d => d).ToList();
                result.idiomas= lac.Select(a => a.Idiomas).Distinct().OrderBy(d => d).ToList();

                if (fecha.HasValue)
                {
                    result.actividades = result.actividades.Where(a => a.Horarios.Any(h => h.FechaInicio.Date == fecha.Value.Date)).ToList();
                }

                switch (orden)
                {
                    case "menor":
                        result.actividades = result.actividades.OrderBy(a => a.Precio).ToList();
                        break;
                    case "mayor":
                        result.actividades = result.actividades.OrderByDescending(a => a.Precio).ToList();
                        break;
                    case "nuevas":
                        result.actividades = result.actividades.OrderByDescending(a => a.IdActividad).ToList();
                        break;
                    case "viejas":
                        result.actividades = result.actividades.OrderBy(a => a.IdActividad).ToList();
                        break;
                    case "positivas":
                        result.actividades = result.actividades.OrderByDescending(a => a.Calificacion).ToList();
                        break;
                    case "negativas":
                        result.actividades = result.actividades.OrderBy(a => a.Calificacion).ToList();
                        break;


                    default:
                        break;
                }




                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        
    }
}
