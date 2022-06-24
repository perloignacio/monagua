using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using monaguaRules.Entities;
using monaguaRules.Mappers;
namespace monaguaRules
{
    public  class ComprasRules
    {
        public enum estadosCompra
        {
            Carrito=1,
            Solicitada=2,
            Abonada=3,
            Cancelada=4
        }
        public  void AgregarCarrito(int idcliente, List<ComprasDetalle> detalle)
        {
            validarCarrito(idcliente, detalle);
            Compras c = new Compras();
            c.Activa = true;
            c.Fecha = DateTime.Now;
            c.IdCliente = idcliente;
            c.Reserva = false;
            c.IdEstadoCompra = (int)estadosCompra.Carrito;
            ComprasMapper.Instance().Insert(c);
            foreach (var item in detalle)
            {
                item.IdCompra = c.IdCompra;
                ComprasDetalleMapper.Instance().Insert(item);
            }
        }

        public  void AgregarCompra(int idcompra,int idcliente, List<ComprasDetalle> detalle,int? iddescuento,bool reserva)
        {
            validarCarrito(idcliente, detalle);
            Compras c = ComprasMapper.Instance().GetOne(idcompra);
            if (c == null)
            {
                throw new Exception("No se encuentra la compra");
            }
            if (c.IdCliente != idcliente)
            {
                throw new Exception("Upp ocurrio un error");
            }
            c.Reserva = reserva;
            if (iddescuento.HasValue)
            {
                c.IdDescuento = iddescuento.Value;
            }
            c.IdEstadoCompra = (int)estadosCompra.Solicitada;
            ComprasMapper.Instance().Save(c);
            ComprasDetalleMapper.Instance().DeleteByCompras(c.IdCompra);
            foreach (var item in detalle)
            {
                item.IdCompra = c.IdCompra;
                ComprasDetalleMapper.Instance().Insert(item);
            }

        }

        public  void ActualizarCarrito(int idcompra, int idcliente, List<ComprasDetalle> detalle)
        {
            validarCarrito(idcliente, detalle);
            Compras c = ComprasMapper.Instance().GetOne(idcompra);
            if (c == null)
            {
                throw new Exception("No se encuentra la compra");
            }
            if (c.IdCliente != idcliente)
            {
                throw new Exception("Upp ocurrio un error");
            }
           
            c.IdEstadoCompra = (int)estadosCompra.Solicitada;
            ComprasMapper.Instance().Save(c);
            ComprasDetalleMapper.Instance().DeleteByCompras(c.IdCompra);
            foreach (var item in detalle)
            {
                item.IdCompra = c.IdCompra;
                ComprasDetalleMapper.Instance().Insert(item);
            }

        }
        public  void validarCarrito(int idcliente, List<ComprasDetalle> detalle)
        {
            if (ClientesMapper.Instance().GetOne(idcliente) == null)
            {
                throw new Exception("No se encuentra el cliente");
            }
            foreach (var item in detalle)
            {
                Actividades acc = ActividadesMapper.Instance().GetOne(item.IdActividad);
                if (acc == null)
                {
                    throw new Exception("No se encuentra la actividad");
                }
                if (acc.Activa)
                {
                    throw new Exception("La actividad no se encuentra activa");
                }

                ActividadesHorarios ah = ActividadesHorariosMapper.Instance().GetOne(item.IdHorarioActividad);
                if (ah == null)
                {
                    throw new Exception("El horario no esta disponible");
                }
                if (!ah.Activa)
                {
                    throw new Exception("El horario no esta disponible");
                }
                

            }
        }
    }
}
