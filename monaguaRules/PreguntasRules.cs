using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using monaguaRules.Entities;
using monaguaRules.Mappers;
namespace monaguaRules
{
    public class PreguntasRules
    {
        public void Agregar(string pregunta, string respuesta, int orden)
        {
            validar(pregunta, respuesta);
            PreguntasFrecuentes p = new PreguntasFrecuentes();
            p.Pregunta = pregunta;
            p.Respuesta = respuesta;
            p.Orden = orden;
            p.Activa = true;
            PreguntasFrecuentesMapper.Instance().Insert(p);
        }

        public void Modificar(int id, string pregunta, string respuesta, int orden)
        {
            validar(pregunta, respuesta);
            PreguntasFrecuentes p = PreguntasFrecuentesMapper.Instance().GetOne(id);
            if (p == null)
            {
                throw new Exception("No se encuentra la pregunta");
            }
            p.Pregunta = pregunta;
            p.Respuesta = respuesta;
            p.Orden = orden;
            

            PreguntasFrecuentesMapper.Instance().Save(p);


        }

        public void Activar(int id)
        {

            PreguntasFrecuentes p = PreguntasFrecuentesMapper.Instance().GetOne(id);
            if (p == null)
            {
                throw new Exception("No se encuentra la pregunta");
            }


            p.Activa = true;
            PreguntasFrecuentesMapper.Instance().Save(p);
        }

        public void Borrar(int id)
        {

            PreguntasFrecuentes p = PreguntasFrecuentesMapper.Instance().GetOne(id);
            if (p == null)
            {
                throw new Exception("No se encuentra la pregunta");
            }


            p.Activa = false;
            PreguntasFrecuentesMapper.Instance().Save(p);
        }

        public void validar(string pregunta, string respuesta)
        {
            if (string.IsNullOrEmpty(pregunta))
            {
                throw new Exception("Debe indicar un título de la pregunta");
            }
            if (string.IsNullOrEmpty(respuesta))
            {
                throw new Exception("Debe indicar una respuesta a la pregunta");
            }
            
        }
    }
}
