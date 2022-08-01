
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 18/7/2022 - 04:08 p. m.
// This is a partial class file. The other one is ActividadesHorariosExcepcionEntity.cs
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
    public partial class ActividadesHorariosExcepcion : Objects.ActividadesHorariosExcepcionObject, IMappeableActividadesHorariosExcepcion, IEquatable<ActividadesHorariosExcepcion>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ActividadesHorariosExcepcion()
            :base()
        {
            if (_ActividadesHorariosEntity == null) _ActividadesHorariosEntity = new Entities.ActividadesHorarios();

        }

        /// <summary>
        /// 
        /// </summary>
        public ActividadesHorariosExcepcion(
			System.Int32 IdActividadHorarioExcepcion)
            : base()
        {

			_IdActividadHorarioExcepcion = IdActividadHorarioExcepcion;

            if (_ActividadesHorariosEntity == null) _ActividadesHorariosEntity = new Entities.ActividadesHorarios();

            Initialized();
        }

        

        /// <summary>
        /// 
        /// </summary>
        public ActividadesHorariosExcepcion(
			System.Int32 IdActividadHorarioExcepcion,
			System.Int32 IdHorario,
			System.Nullable<System.DateTime> HoraDesde,
			System.Nullable<System.DateTime> HoraHasta,
			System.Nullable<System.Int32> Capacidad,
			System.Boolean Eliminar,
			System.Nullable<System.DateTime> Fecha)
            : base()
        {

			_IdActividadHorarioExcepcion = IdActividadHorarioExcepcion;
			_IdHorario = IdHorario;
			_HoraDesde = HoraDesde;
			_HoraHasta = HoraHasta;
			_Capacidad = Capacidad;
			_Eliminar = Eliminar;
			_Fecha = Fecha;

            if (_ActividadesHorariosEntity == null) _ActividadesHorariosEntity = new Entities.ActividadesHorarios();

            Initialized();
        }
        
        #endregion

        #region "Fields"

        /// <summary>
/// 
/// </summary>
protected Entities.ActividadesHorarios _ActividadesHorariosEntity;

        #endregion

        #region "Properties"
        
bool _ActividadesHorariosEntityFetched;

        /// <summary>
        /// 
        /// </summary>
        public virtual Entities.ActividadesHorarios ActividadesHorariosEntity
        {
            get
            {
                if (_ActividadesHorariosEntity== null  && ! _ActividadesHorariosEntityFetched ) {
_ActividadesHorariosEntityFetched = true;
Entities.ActividadesHorarios _ActividadesHorariosEntityTemp = new Entities.ActividadesHorarios(this.IdHorario); 
ILazyProvider lazyProvider = LazyProviderFactory.Get(typeof(Entities.ActividadesHorarios));
 _ActividadesHorariosEntity = lazyProvider.GetEntity(typeof(Entities.ActividadesHorarios), _ActividadesHorariosEntityTemp) as Entities.ActividadesHorarios;
}

                return _ActividadesHorariosEntity;
            }
            set
            {
                base.PropertyModified();
                _ActividadesHorariosEntity = value;
                if (value != null) {
   _IdHorario = value.IdHorario;

} else {
   _IdHorario = System.Int32.MinValue;

}

            }
        }
        
        #endregion

        /// <summary>
        /// Returns de original value of entity since was created or restored.
        /// </summary>
        public new ActividadesHorariosExcepcion OriginalValue()
        {
            return (ActividadesHorariosExcepcion)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            ActividadesHorariosExcepcion newObject;            
            

            newObject = (ActividadesHorariosExcepcion)this.MemberwiseClone();
            // Entities
                         
            if (this._ActividadesHorariosEntity != null)
            {
                newObject._ActividadesHorariosEntity = (Entities.ActividadesHorarios)((ICloneable)this._ActividadesHorariosEntity).Clone();
            }
            
            // Colections
            
            // OriginalValue
            ActividadesHorariosExcepcion newOriginalValue;
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ActividadesHorariosExcepcion)this.OriginalValue().MemberwiseClone();
                // Entities
                             
                if (this.OriginalValue()._ActividadesHorariosEntity != null)
                {
                    newOriginalValue._ActividadesHorariosEntity = (Entities.ActividadesHorarios)((ICloneable)this.OriginalValue()._ActividadesHorariosEntity).Clone();
                }
                
                // Colections
                            
                newObject._OriginalValue = newOriginalValue;

            }
            return newObject;            
        }



        /// <summary>
        /// 
        /// </summary>
        void IMappeableActividadesHorariosExcepcion.CompleteEntity(Entities.ActividadesHorarios ActividadesHorariosEntity)
        {
        _ActividadesHorariosEntity = ActividadesHorariosEntity;
        }
        
        bool IMappeableActividadesHorariosExcepcion.IsActividadesHorariosEntityNull()
        {
            return (_ActividadesHorariosEntity == null);
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeableActividadesHorariosExcepcion.SetFKValuesForChilds(ActividadesHorariosExcepcion entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ActividadesHorariosExcepcion other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableActividadesHorariosExcepcion
    {
        /// <summary>
        /// 
        /// </summary>
        void CompleteEntity(Entities.ActividadesHorarios ActividadesHorariosEntity);
        
        /// <summary>
        /// 
        /// </summary>
        bool IsActividadesHorariosEntityNull();
        
        /// <summary>
        /// 
        /// </summary>
        void SetFKValuesForChilds(ActividadesHorariosExcepcion entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class ActividadesHorariosExcepcionList : ObjectList<ActividadesHorariosExcepcion>
    {
    }
}
namespace monaguaRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class ActividadesHorariosExcepcionListView
        : ObjectListView<Entities.ActividadesHorariosExcepcion>
    {
        /// <summary>
        /// 
        /// </summary>
        public ActividadesHorariosExcepcionListView(Entities.ActividadesHorariosExcepcionList list): base(list)
        {
        }
    }
}


