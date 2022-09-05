using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using monaguaRules.Entities;
using monaguaRules.Mappers;
namespace monaguaRules
{
    public class SlidesRules
    {
        public void Agregar(string titulo,string descripcion,string foto,string link,int orden)
        {
            validar(titulo,descripcion,foto);
            Slides s = new Slides();
            s.Titulo = titulo;
            s.Descripcion = descripcion;
            s.Foto = foto;
            if (!string.IsNullOrEmpty(link))
            {
                s.Link = link;
            }
            s.Orden = orden;
            s.Activo = true;
            SlidesMapper.Instance().Insert(s);
        }

        public void Modificar(int id, string titulo, string descripcion, string foto, string link, int orden)
        {
            validar(titulo, descripcion, foto);
            Slides s = SlidesMapper.Instance().GetOne(id);
            if (s == null)
            {
                throw new Exception("No se encuentra el slide");
            }

            s.Titulo = titulo;
            s.Descripcion = descripcion;
            s.Foto = foto;
            if (!string.IsNullOrEmpty(link))
            {
                s.Link = link;
            }
            s.Orden = orden;
            
            SlidesMapper.Instance().Save(s);

           
        }

        public void Activar(int id)
        {

            Slides s = SlidesMapper.Instance().GetOne(id);
            if (s == null)
            {
                throw new Exception("No se encuentra el slide");
            }


            s.Activo = true;
            SlidesMapper.Instance().Save(s);
        }

        public void Borrar(int id)
        {

            Slides s = SlidesMapper.Instance().GetOne(id);
            if (s == null)
            {
                throw new Exception("No se encuentra el slide");
            }


            s.Activo = false;
            SlidesMapper.Instance().Save(s);
        }

        public void validar(string titulo, string descripcion, string foto)
        {
            if (string.IsNullOrEmpty(titulo))
            {
                throw new Exception("Debe indicar un título");
            }
            if (string.IsNullOrEmpty(descripcion))
            {
                throw new Exception("Debe indicar una descripción");
            }
            if (string.IsNullOrEmpty(foto))
            {
                throw new Exception("Debe indicar una foto");
            }
        }
    }
}
