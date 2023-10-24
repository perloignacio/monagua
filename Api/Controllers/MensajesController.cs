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
    [RoutePrefix("mensajes")]
    public class MensajesController : ApiController
    {
        [Route("ByCompraDetalle")]
        [HttpGet]
        
        public IHttpActionResult ByCompraDetalle(int id)
        {
            try
            {
                var identity = Thread.CurrentPrincipal.Identity;
                Usuarios u = UsuariosMapper.Instance().GetOne(Convert.ToInt32(identity.Name));
                int? idcliente = null;
                int? idprestador = null;
                if (u.ClientesEntity != null)
                {
                    idcliente = u.ClientesEntity.IdCliente;
                }
                if (u.PrestadoresEntity != null)
                {
                    idprestador = u.PrestadoresEntity.IdPrestador;
                }
                MensajesRules MR = new MensajesRules();
               
                List<Mensajes> lista = MensajesMapper.Instance().GetByComprasDetalle(id).Where(m => m.Activo).OrderBy(m => m.Fecha).ToList() ;
                foreach (var item in lista)
                {
                    if (idcliente.HasValue)
                    {
                        if (!item.LeidoCliente)
                        {
                            MR.MarcarLeido(item.IdMensaje, idcliente, idprestador);
                        }
                    }
                    if (idprestador.HasValue)
                    {
                        if (!item.LeidoPrestador)
                        {
                            MR.MarcarLeido(item.IdMensaje, idcliente, idprestador);
                        }
                    }
                }
                return Ok(lista);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("NoLeidos")]
        [HttpGet]

        public IHttpActionResult NoLeidos(int id)
        {
            try
            {
                var identity = Thread.CurrentPrincipal.Identity;
                Usuarios u = UsuariosMapper.Instance().GetOne(Convert.ToInt32(identity.Name));
                int? idcliente = null;
                int? idprestador = null;
                if (u.ClientesEntity != null)
                {
                    idcliente = u.ClientesEntity.IdCliente;
                }
                if (u.PrestadoresEntity != null)
                {
                    idprestador = u.PrestadoresEntity.IdPrestador;
                }

                List<Mensajes> lista = MensajesMapper.Instance().GetByComprasDetalle(id).Where(m => m.Activo).OrderBy(m => m.Fecha).ToList();
                int cant = 0;
               
                foreach (var item in lista)
                {
                    if (idcliente.HasValue)
                    {
                        if (!item.LeidoCliente)
                        {
                            cant++;
                        }
                    }
                    if (idprestador.HasValue)
                    {
                        if (!item.LeidoPrestador)
                        {
                            cant++;
                        }
                    }
                }
                return Ok(cant);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [Route("Agregar")]
        [HttpPost]

        public IHttpActionResult Agregar(Mensajes m)
        {
            try
            {
                var identity = Thread.CurrentPrincipal.Identity;
                Usuarios u = UsuariosMapper.Instance().GetOne(Convert.ToInt32(identity.Name));
                int? idcliente = null;
                int? idprestador = null;
                if (u.ClientesEntity != null)
                {
                    idcliente = u.ClientesEntity.IdCliente;
                }
                if (u.PrestadoresEntity != null)
                {
                    idprestador = u.PrestadoresEntity.IdPrestador;
                }
                MensajesRules MR = new MensajesRules();
                MR.Agregar(m.IdCompraDetalle, m.Mensaje, idcliente, idprestador);
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }



        [Route("MarcarLeido")]
        [HttpGet]

        public IHttpActionResult MarcarLeido(int idmensaje)
        {
            try
            {
                var identity = Thread.CurrentPrincipal.Identity;
                Usuarios u = UsuariosMapper.Instance().GetOne(Convert.ToInt32(identity.Name));
                int? idcliente = null;
                int? idprestador = null;
                if (u.ClientesEntity != null)
                {
                    idcliente = u.ClientesEntity.IdCliente;
                }
                if (u.PrestadoresEntity != null)
                {
                    idprestador = u.PrestadoresEntity.IdPrestador;
                }
                MensajesRules MR = new MensajesRules();
                MR.MarcarLeido(idmensaje, idcliente, idprestador);
                return Ok(true);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        
    }
}
