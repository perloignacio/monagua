using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using monaguaRules.Entities;
using monaguaRules.Mappers;
namespace monaguaRules
{
    public  class DescuentosRules
    {
        public  void Agregar(string nombre, string codigo, decimal? monto, decimal? porcentaje, int? stock, DateTime? desde, DateTime? hasta)
        {
            validar(nombre, codigo, monto, porcentaje, desde, hasta);
            Descuentos d = new Descuentos();
            d.Nombre = nombre;
            d.Codigo=codigo;
            if (monto.HasValue)
            {
                d.Monto = monto.Value;
                d.Porcentaje = null;
            }
            if (porcentaje.HasValue)
            {
                d.Monto = null;
                d.Porcentaje = porcentaje.Value;
            }
            if (stock.HasValue)
            {
                d.Stock = stock.Value;
            }
            if(desde.HasValue && hasta.HasValue)
            {
                d.FechaDesde= desde.Value;
                d.FechaHasta = hasta.Value;
            }
            d.Activo = true;
            DescuentosMapper.Instance().Insert(d);
        }

        public  void Modificar(int id,string nombre, string codigo, decimal? monto, decimal? porcentaje, int? stock, DateTime? desde, DateTime? hasta)
        {
            validar(nombre, codigo, monto, porcentaje, desde, hasta);
            Descuentos d = DescuentosMapper.Instance().GetOne(id);
            if (d == null)
            {
                throw new Exception("No se encuentra el descuento");
            }

            d.Nombre = nombre;
            d.Codigo = codigo;
            if (monto.HasValue)
            {
                d.Monto = monto.Value;
                d.Porcentaje = null;
            }
            if (porcentaje.HasValue)
            {
                d.Monto = null;
                d.Porcentaje = porcentaje.Value;
            }
            if (stock.HasValue)
            {
                d.Stock = stock.Value;
            }
            if (desde.HasValue && hasta.HasValue)
            {
                d.FechaDesde = desde.Value;
                d.FechaHasta = hasta.Value;
            }
            DescuentosMapper.Instance().Save(d);
        }

        public  void Activar(int id)
        {
            
            Descuentos d = DescuentosMapper.Instance().GetOne(id);
            if (d == null)
            {
                throw new Exception("No se encuentra el descuento");
            }

            d.Activo = true;
            DescuentosMapper.Instance().Save(d);
        }

        public  void Borrar(int id)
        {

            Descuentos d = DescuentosMapper.Instance().GetOne(id);
            if (d == null)
            {
                throw new Exception("No se encuentra el descuento");
            }

            d.Activo = false;
            DescuentosMapper.Instance().Save(d);
        }
        public  void validar(string nombre, string codigo, decimal? monto, decimal? porcentaje,  DateTime? desde, DateTime? hasta)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("Ingrese el nombre");
            }
            if (string.IsNullOrEmpty(codigo))
            {
                throw new Exception("Ingrese el codigo");
            }
            if(!monto.HasValue && !porcentaje.HasValue)
            {
                throw new Exception("Debe ingresar o un monto o un porcentaje");
            }

            if (monto.HasValue && porcentaje.HasValue)
            {
                throw new Exception("Debe ingresar o un monto o un porcentaje");
            }
            if(desde.HasValue && !hasta.HasValue)
            {
                throw new Exception("Debe ingresar un rango de vigencia valido");
            }
            if (!desde.HasValue && hasta.HasValue)
            {
                throw new Exception("Debe ingresar un rango de vigencia valido");
            }

        }
    }
}
