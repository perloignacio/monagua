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
        public Compras AgregarCarrito(Compras c)
        {
            validarCarrito(c.IdCliente, c.Detalle);
            
           
            c.Activa = true;
            c.Fecha = DateTime.Now;
            if (c.IdCliente.HasValue)
            {
                c.IdCliente = c.IdCliente.Value;
            }
            c.Reserva = c.Reserva;
            c.IdEstadoCompra = (int)estadosCompra.Carrito;
            ComprasMapper.Instance().Insert(c);
            foreach (var item in c.Detalle)
            {
                item.IdCompra = c.IdCompra;
                ComprasDetalleMapper.Instance().Insert(item);
            }
            c.IdObjeto = c.IdCompra;
            return c;
        }

        public Compras AgregarItem(Compras c)
        {
            validarCarrito(c.IdCliente, c.Detalle);

            c = new Compras();
            if (c.IdCliente.HasValue)
            {
                c.IdCliente = c.IdCliente.Value;
            }
            c.Reserva = c.Reserva;
            c.IdEstadoCompra = (int)estadosCompra.Carrito;
            ComprasMapper.Instance().Save(c);
            ComprasDetalleMapper.Instance().DeleteByCompras(c.IdCompra);
            foreach (var item in c.Detalle)
            {
                item.IdCompra = c.IdCompra;
                ComprasDetalleMapper.Instance().Insert(item);
                c.Detalle.Add(item);
            }
            c.IdObjeto = c.IdCompra;
            return c;
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
        public  void validarCarrito(int? idcliente, List<ComprasDetalle> detalle)
        {
            if (idcliente.HasValue)
            {
                if (ClientesMapper.Instance().GetOne(idcliente.Value) == null)
                {
                    throw new Exception("No se encuentra el cliente");
                }
            }
            
            foreach (var item in detalle)
            {
                Actividades acc = ActividadesMapper.Instance().GetOne(item.IdActividad);
                if (acc == null)
                {
                    throw new Exception("No se encuentra la actividad");
                }
                if (!acc.Activa)
                {
                    throw new Exception("La actividad no se encuentra activa");
                }

                

            }
        }
    }
}
