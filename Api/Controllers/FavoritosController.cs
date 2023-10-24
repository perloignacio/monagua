using monaguaRules;
using monaguaRules.Entities;
using monaguaRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace Api.Controllers
{
    [RoutePrefix("favoritos")]
    public class FavoritosController : ApiController
    {
        [Route("Admin/favoritos")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult agrupados()
        {
            try
            {
                dsMonagua ds=new dsMonagua();
                dsMonaguaTableAdapters.FavoritosTableAdapter ta=new dsMonaguaTableAdapters.FavoritosTableAdapter();
                ta.Fill(ds.Favoritos);
                return Ok(ds.Favoritos);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("Admin/detalle")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult detalle(int idactividad,DateTime? desde, DateTime? hasta, int? idcliente)
        {
            try
            {
                List<Favoritos> flist = FavoritosMapper.Instance().GetByActividades(idactividad);
                if (idcliente.HasValue)
                {
                    flist=flist.Where(f => f.IdCliente == idcliente).ToList();
                }

                if (desde.HasValue && hasta.HasValue)
                {
                    flist = flist.Where(f => f.Fecha>=desde.Value && f.Fecha<=hasta.Value).ToList();
                }
                return Ok(flist);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("Agregar")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Agregar(int id)
        {
            try
            {
                var identity = Thread.CurrentPrincipal.Identity;
                Usuarios u = UsuariosMapper.Instance().GetOne(Convert.ToInt32(identity.Name));
                FavoritosRules favRules = new FavoritosRules();
                favRules.Agregar(id, u.IdCliente.Value);
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
