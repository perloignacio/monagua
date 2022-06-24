using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using monaguaRules.Entities;
using monaguaRules.Mappers;
namespace monaguaRules
{
    public  class CategoriasRules
    {
        public  void Agregar(string nombre)
        {
            validar(nombre);
            Categorias c=new Categorias();
            c.Nombre = nombre;
            c.Activa = true;
            CategoriasMapper.Instance().Insert(c);
        }

        public  void Modificar(int id,string nombre)
        {
            validar(nombre);
            Categorias c = CategoriasMapper.Instance().GetOne(id);
            if (c == null)
            {
                throw new Exception("No se encuentra la categoria");
            }

            c.Nombre = nombre;
            CategoriasMapper.Instance().Save(c);
        }

        public  void Activar(int id)
        {
            
            Categorias c = CategoriasMapper.Instance().GetOne(id);
            if (c == null)
            {
                throw new Exception("No se encuentra la categoria");
            }

           
            c.Activa = true;
            CategoriasMapper.Instance().Save(c);
        }

        public  void Borrar(int id)
        {

            Categorias c = CategoriasMapper.Instance().GetOne(id);
            if (c == null)
            {
                throw new Exception("No se encuentra la categoria");
            }


            c.Activa = false;
            CategoriasMapper.Instance().Save(c);
        }

        public  void validar(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("Debe indicar un nombre");
            }
        }
    }
}
