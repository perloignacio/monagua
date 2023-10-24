using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using monaguaRules.Entities;
using monaguaRules.Mappers;
namespace monaguaRules
{
    public class MensajesRules
    {
        public void Agregar(int idcompraDetalle, string mensaje,int? idcliente,int? idprestador)
        {
            Validar(idcompraDetalle, mensaje,idcliente,idprestador);
            Mensajes m=new Mensajes();
            m.IdCompraDetalle = idcompraDetalle;
            m.Mensaje= mensaje;
            m.Fecha = DateTime.Now;
            m.Activo = true;
            if (idcliente.HasValue)
            {
                m.OrigenCliente = true;
                m.LeidoCliente = true;
                m.LeidoPrestador = false;
            }
            else
            {
                m.OrigenCliente = false;
                m.LeidoCliente = false;
                m.LeidoPrestador = true;
            }
            MensajesMapper.Instance().Insert(m);
        }

        public void MarcarLeido(int idmensaje, int? idcliente, int? idprestador)
        {

            Mensajes m = MensajesMapper.Instance().GetOne(idmensaje);
            if (m == null) {
                throw new Exception("No se encuentra el mensaje");
            }

            if (idcliente.HasValue)
            {
                m.LeidoCliente = true;
                
            }
            else
            {
                m.LeidoPrestador = true;
            }
            MensajesMapper.Instance().Save(m);
        }
        public void Validar(int idcompraDetalle, string mensaje,int? idcliente, int? idprestador)
        {
            ComprasDetalle cd = ComprasDetalleMapper.Instance().GetOne(idcompraDetalle);
            if (cd == null)
            {
                throw new Exception("No se encuentra la compra");
            }
            if (string.IsNullOrEmpty(mensaje))
            {
                throw new Exception("Debe ingresar un mensaje");
            }

            if (idcliente.HasValue)
            {
                if (cd.ComprasEntity.IdCliente != idcliente.Value)
                {
                    throw new Exception("No puede ponerse en contacto con el prestador");
                }
            }

            if (idprestador.HasValue)
            {
                if (cd.ActividadesEntity.IdPrestador != idprestador)
                {
                    throw new Exception("No puede ponerse en contacto con el cliente");
                }
            }
        }
    }
}
