using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using monaguaRules.Entities;
using monaguaRules.Mappers;
namespace monaguaRules
{
    public  class CalificacionesRules
    {
        public  void Agregar(int IdCompraDetalle, int calificacion, string comentario,int idcliente)
        {
            validar(IdCompraDetalle, calificacion, comentario, idcliente);
            Calificaciones c = new Calificaciones();
            c.Calificacion = calificacion;
            c.Comentario = comentario;
            c.Fecha = DateTime.Now;
            c.IdCompraDetalle = IdCompraDetalle;
            CalificacionesMapper.Instance().Insert(c);
        }

        public  void Responder(int IdCalificacion,string respuesta,int idprestador)
        {

            Calificaciones c = CalificacionesMapper.Instance().GetOne(IdCalificacion);
            if (c == null)
            {
                throw new Exception("No se encuentra la calificacion");
            }
            if (c.ComprasDetalleEntity.ActividadesEntity.IdPrestador != idprestador)
            {
                throw new Exception("No puede responder esta calificación");
            }
            if (c.FechaRespuesta.HasValue)
            {
                throw new Exception("Ya respondio esta califificación");
            }
            c.Respuesta=respuesta;
            c.FechaRespuesta = DateTime.Now;
            CalificacionesMapper.Instance().Save(c);
        }

        public  void validar(int IdCompraDetalle, int calificacion, string comentario,int idcliente)
        {
            ComprasDetalle cd=ComprasDetalleMapper.Instance().GetOne(IdCompraDetalle);
            if (cd == null)
            {
                throw new Exception("No se encuentra la compra");
            }
            if (cd.ComprasEntity.IdCliente != idcliente)
            {
                throw new Exception("No puede realizar comentarios en esta compra");
            }
            if (!cd.ComprasEntity.Activa)
            {
                throw new Exception("No puede realizar comentarios en esta compra");
            }
            if(calificacion<0 || calificacion > 5)
            {
                throw new Exception("La calificacion tiene que estar entre 0 y 5");
            }
            if (string.IsNullOrEmpty(comentario))
            {
                throw new Exception("Ingrese un comentario");
            }

            CalificacionesList clist = CalificacionesMapper.Instance().GetCalificacionesByCliente(idcliente);
            if (clist.Find(c => c.IdCompraDetalle == IdCompraDetalle) != null)
            {
                throw new Exception("Ya realizo una calificación");
            }

        }
    }
}
