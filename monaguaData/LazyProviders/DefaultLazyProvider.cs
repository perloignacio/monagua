
        
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 18/7/2022 - 04:08 p. m.
// You can edit this file as your wish.
//------------------------------------------------------------------------------

using System;
using Cooperator.Framework.Data;
using Cooperator.Framework.Core;
using Cooperator.Framework.Core.LazyLoad;
using monaguaRules.Entities;


using monaguaRules.Objects;


using monaguaRules.Gateways;


using monaguaRules.Mappers;


using System.Collections.Generic;

namespace monaguaRules.LazyProviders
{
    /// <summary>
    /// 
    /// </summary>
    public class DefaultLazyProvider: ILazyProvider
    {
        private static Object thisLock = new Object();
        private static Dictionary<string, IGenericGateway> _mappersCache;
        private static Dictionary<string, IGenericGateway> MappersCache
        {
            get
            {
                lock (thisLock)
                {
                    if (DefaultLazyProvider._mappersCache == null)
                    {
                        DefaultLazyProvider._mappersCache = new Dictionary<string, IGenericGateway>();
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.Actividades", monaguaRules.Mappers.ActividadesMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.ActividadesObject", monaguaRules.Gateways.ActividadesGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.ActividadesHorarios", monaguaRules.Mappers.ActividadesHorariosMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.ActividadesHorariosObject", monaguaRules.Gateways.ActividadesHorariosGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.ActividadesHorariosExcepcion", monaguaRules.Mappers.ActividadesHorariosExcepcionMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.ActividadesHorariosExcepcionObject", monaguaRules.Gateways.ActividadesHorariosExcepcionGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.Calificaciones", monaguaRules.Mappers.CalificacionesMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.CalificacionesObject", monaguaRules.Gateways.CalificacionesGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.Categorias", monaguaRules.Mappers.CategoriasMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.CategoriasObject", monaguaRules.Gateways.CategoriasGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.Clientes", monaguaRules.Mappers.ClientesMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.ClientesObject", monaguaRules.Gateways.ClientesGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.Compras", monaguaRules.Mappers.ComprasMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.ComprasObject", monaguaRules.Gateways.ComprasGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.ComprasDetalle", monaguaRules.Mappers.ComprasDetalleMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.ComprasDetalleObject", monaguaRules.Gateways.ComprasDetalleGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.Configuracion", monaguaRules.Mappers.ConfiguracionMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.ConfiguracionObject", monaguaRules.Gateways.ConfiguracionGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.Descuentos", monaguaRules.Mappers.DescuentosMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.DescuentosObject", monaguaRules.Gateways.DescuentosGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.EstadosCompra", monaguaRules.Mappers.EstadosCompraMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.EstadosCompraObject", monaguaRules.Gateways.EstadosCompraGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.Favoritos", monaguaRules.Mappers.FavoritosMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.FavoritosObject", monaguaRules.Gateways.FavoritosGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.Localidades", monaguaRules.Mappers.LocalidadesMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.LocalidadesObject", monaguaRules.Gateways.LocalidadesGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.Mensajes", monaguaRules.Mappers.MensajesMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.MensajesObject", monaguaRules.Gateways.MensajesGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.Paises", monaguaRules.Mappers.PaisesMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.PaisesObject", monaguaRules.Gateways.PaisesGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.Prestadores", monaguaRules.Mappers.PrestadoresMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.PrestadoresObject", monaguaRules.Gateways.PrestadoresGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.Provincias", monaguaRules.Mappers.ProvinciasMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.ProvinciasObject", monaguaRules.Gateways.ProvinciasGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.TipoRepeticiones", monaguaRules.Mappers.TipoRepeticionesMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.TipoRepeticionesObject", monaguaRules.Gateways.TipoRepeticionesGateway.Instance());
                    
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Entities.Usuarios", monaguaRules.Mappers.UsuariosMapper.Instance());
                        
                        DefaultLazyProvider._mappersCache.Add("monaguaRules.Objects.UsuariosObject", monaguaRules.Gateways.UsuariosGateway.Instance());
                    
                    }
                }
                return DefaultLazyProvider._mappersCache;
            }
        }    


        /// <summary>
        /// Get associated entity for this entity
        /// </summary>
        public IUniqueIdentifiable GetEntity(System.Type child, IUniqueIdentifiable indentifier)
        {
            IGenericGateway genericGateway = DefaultLazyProvider.MappersCache[child.FullName];
            return genericGateway.GetOne(indentifier) as IUniqueIdentifiable;
        }

        /// <summary>
        /// Get collection based in the parent entity
        /// </summary>
        public object GetList(System.Type child, IUniqueIdentifiable parent)
        {
            IGenericGateway genericGateway = DefaultLazyProvider.MappersCache[child.FullName];
            return genericGateway.GetByParent(parent);
        }
    }
}


