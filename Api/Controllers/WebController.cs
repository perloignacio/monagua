using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using monaguaRules;
using monaguaRules.Entities;
using monaguaRules.Mappers;
namespace Api.Clases
{   
    [RoutePrefix("web")]
    public class WebController : ApiController
    {
        [Route("paises")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Paises()
        {
            try
            {
                
                return Ok(PaisesMapper.Instance().GetAll().OrderBy(p=>p.Nombre));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("provincias")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Provincias(int idpais)
        {
            try
            {

                return Ok(ProvinciasMapper.Instance().GetAll().Where(p=>p.IdPais==idpais).OrderBy(p => p.Nombre));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }


        [Route("localidades")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult Localidades(int idprovincia)
        {
            try
            {

                return Ok(LocalidadesMapper.Instance().GetAll().Where(l => l.IdProvincia == idprovincia).OrderBy(l => l.Nombre));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }

        [Route("provinciasLocalidades")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult provinciasLocalidades(int idprovincia)
        {
            try
            {
                ProvinciasList lista = ProvinciasMapper.Instance().GetAll();
                foreach (var item in lista)
                {
                    item.localidades = LocalidadesMapper.Instance().GetByProvincias(item.IdProvincia).OrderBy(l => l.Nombre).ToList();
                }

                return Ok(lista);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }


        }
    }
}
