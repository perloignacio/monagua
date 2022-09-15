
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 15/09/2022 - 16:08
// This is a partial class file. The other one is ComprasDetalleEntity.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using monaguaRules.Objects;



using Cooperator.Framework.Core;
using Cooperator.Framework.Core.LazyLoad;
using System;

namespace monaguaRules.Entities
{

    /// <summary>
    /// 
    /// </summary>
    public partial class ComprasDetalle : Objects.ComprasDetalleObject, IMappeableComprasDetalle, IEquatable<ComprasDetalle>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ComprasDetalle()
            :base()
        {
            if (_ActividadesEntity == null) _ActividadesEntity = new Entities.Actividades();
if (_ComprasEntity == null) _ComprasEntity = new Entities.Compras();

        }

        /// <summary>
        /// 
        /// </summary>
        public ComprasDetalle(
			System.Int32 IdCompraDetalle)
            : base()
        {

			_IdCompraDetalle = IdCompraDetalle;

            if (_ActividadesEntity == null) _ActividadesEntity = new Entities.Actividades();
if (_ComprasEntity == null) _ComprasEntity = new Entities.Compras();

            Initialized();
        }

        

        /// <summary>
        /// 
        /// </summary>
        public ComprasDetalle(
			System.Int32 IdCompraDetalle,
			System.Int32 IdCompra,
			System.Int32 IdActividad,
			System.Int32 Cantidad,
			System.DateTime FechaHora,
			System.Nullable<System.Decimal> MontoActividad)
            : base()
        {

			_IdCompraDetalle = IdCompraDetalle;
			_IdCompra = IdCompra;
			_IdActividad = IdActividad;
			_Cantidad = Cantidad;
			_FechaHora = FechaHora;
			_MontoActividad = MontoActividad;

            if (_ActividadesEntity == null) _ActividadesEntity = new Entities.Actividades();
if (_ComprasEntity == null) _ComprasEntity = new Entities.Compras();

            Initialized();
        }
        
        #endregion

        #region "Fields"

        /// <summary>
/// 
/// </summary>
protected Entities.Actividades _ActividadesEntity;
/// <summary>
/// 
/// </summary>
protected Entities.Compras _ComprasEntity;

        #endregion

        #region "Properties"
        
bool _ActividadesEntityFetched;

        /// <summary>
        /// 
        /// </summary>
        public virtual Entities.Actividades ActividadesEntity
        {
            get
            {
                if (_ActividadesEntity== null  && ! _ActividadesEntityFetched ) {
_ActividadesEntityFetched = true;
Entities.Actividades _ActividadesEntityTemp = new Entities.Actividades(this.IdActividad); 
ILazyProvider lazyProvider = LazyProviderFactory.Get(typeof(Entities.Actividades));
 _ActividadesEntity = lazyProvider.GetEntity(typeof(Entities.Actividades), _ActividadesEntityTemp) as Entities.Actividades;
}

                return _ActividadesEntity;
            }
            set
            {
                base.PropertyModified();
                _ActividadesEntity = value;
                if (value != null) {
   _IdActividad = value.IdActividad;

} else {
   _IdActividad = System.Int32.MinValue;

}

            }
        }
        
bool _ComprasEntityFetched;

        /// <summary>
        /// 
        /// </summary>
        public virtual Entities.Compras ComprasEntity
        {
            get
            {
                if (_ComprasEntity== null  && ! _ComprasEntityFetched ) {
_ComprasEntityFetched = true;
Entities.Compras _ComprasEntityTemp = new Entities.Compras(this.IdCompra); 
ILazyProvider lazyProvider = LazyProviderFactory.Get(typeof(Entities.Compras));
 _ComprasEntity = lazyProvider.GetEntity(typeof(Entities.Compras), _ComprasEntityTemp) as Entities.Compras;
}

                return _ComprasEntity;
            }
            set
            {
                base.PropertyModified();
                _ComprasEntity = value;
                if (value != null) {
   _IdCompra = value.IdCompra;

} else {
   _IdCompra = System.Int32.MinValue;

}

            }
        }
        
        #endregion

        /// <summary>
        /// Returns de original value of entity since was created or restored.
        /// </summary>
        public new ComprasDetalle OriginalValue()
        {
            return (ComprasDetalle)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            ComprasDetalle newObject;            
            

            newObject = (ComprasDetalle)this.MemberwiseClone();
            // Entities
                         
            if (this._ActividadesEntity != null)
            {
                newObject._ActividadesEntity = (Entities.Actividades)((ICloneable)this._ActividadesEntity).Clone();
            }
                         
            if (this._ComprasEntity != null)
            {
                newObject._ComprasEntity = (Entities.Compras)((ICloneable)this._ComprasEntity).Clone();
            }
            
            // Colections
            
            // OriginalValue
            ComprasDetalle newOriginalValue;
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ComprasDetalle)this.OriginalValue().MemberwiseClone();
                // Entities
                             
                if (this.OriginalValue()._ActividadesEntity != null)
                {
                    newOriginalValue._ActividadesEntity = (Entities.Actividades)((ICloneable)this.OriginalValue()._ActividadesEntity).Clone();
                }
                             
                if (this.OriginalValue()._ComprasEntity != null)
                {
                    newOriginalValue._ComprasEntity = (Entities.Compras)((ICloneable)this.OriginalValue()._ComprasEntity).Clone();
                }
                
                // Colections
                            
                newObject._OriginalValue = newOriginalValue;

            }
            return newObject;            
        }



        /// <summary>
        /// 
        /// </summary>
        void IMappeableComprasDetalle.CompleteEntity(Entities.Actividades ActividadesEntity, Entities.Compras ComprasEntity)
        {
        _ActividadesEntity = ActividadesEntity;
_ComprasEntity = ComprasEntity;
        }
        
        bool IMappeableComprasDetalle.IsActividadesEntityNull()
        {
            return (_ActividadesEntity == null);
        }
        
        bool IMappeableComprasDetalle.IsComprasEntityNull()
        {
            return (_ComprasEntity == null);
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeableComprasDetalle.SetFKValuesForChilds(ComprasDetalle entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ComprasDetalle other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableComprasDetalle
    {
        /// <summary>
        /// 
        /// </summary>
        void CompleteEntity(Entities.Actividades ActividadesEntity, Entities.Compras ComprasEntity);
        
        /// <summary>
        /// 
        /// </summary>
        bool IsActividadesEntityNull();
        
        /// <summary>
        /// 
        /// </summary>
        bool IsComprasEntityNull();
        
        /// <summary>
        /// 
        /// </summary>
        void SetFKValuesForChilds(ComprasDetalle entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class ComprasDetalleList : ObjectList<ComprasDetalle>
    {
    }
}
namespace monaguaRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class ComprasDetalleListView
        : ObjectListView<Entities.ComprasDetalle>
    {
        /// <summary>
        /// 
        /// </summary>
        public ComprasDetalleListView(Entities.ComprasDetalleList list): base(list)
        {
        }
    }
}


