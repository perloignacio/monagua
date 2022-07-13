using monaguaRules.Entities;
using monaguaRules.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monaguaRules
{
    public  class FavoritosRules
    {
        public void Agregar(int idactividad, int idusuario)
        {
            validar(idactividad,idusuario);
            Favoritos fav = FavoritosMapper.Instance().GetByClientes(idusuario).Where(f => f.IdActividad == idactividad).FirstOrDefault();
            if (fav != null)
            {
                throw new Exception("La actividad ya se encuentra en favoritos");
            }
            else
            {
                fav = new Favoritos();
            }
            
            fav.Fecha = DateTime.Now;
            fav.IdActividad = idactividad;
            fav.IdCliente = idusuario;
            FavoritosMapper.Instance().Insert(fav);

        }

        public void Borrar(int idactividad, int idusuario)
        {

            Favoritos fav=FavoritosMapper.Instance().GetByActividades(idactividad).Where(f=>f.IdCliente==idusuario).FirstOrDefault();
            if (fav != null)
            {
                FavoritosMapper.Instance().Delete(fav);
            }
            else
            {
                throw new Exception("No se encuentra la actividad");
            }
            

        }
        public void validar(int idactividad, int idusuario)
        {
            if(ActividadesMapper.Instance().GetOne(idactividad)==null)
            {
                throw new Exception("No se encuentra la actividad");
            }

            if (UsuariosMapper.Instance().GetOne(idusuario) == null)
            {
                throw new Exception("No se encuentra el usuario");
            }
        }
    }
}
