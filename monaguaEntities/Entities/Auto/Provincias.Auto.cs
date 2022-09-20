
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 15/09/2022 - 16:08
// This is a partial class file. The other one is ProvinciasEntity.cs
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
    public partial class Provincias : Objects.ProvinciasObject, IMappeableProvincias, IEquatable<Provincias>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public Provincias()
            :base()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        public Provincias(
			System.Int32 IdProvincia)
            : base()
        {

			_IdProvincia = IdProvincia;

            
            Initialized();
        }

        

        /// <summary>
        /// 
        /// </summary>
        public Provincias(
			System.Int32 IdProvincia,
			System.String Nombre,
			System.Nullable<System.Int32> IdPais)
            : base()
        {

			_IdProvincia = IdProvincia;
			_Nombre = Nombre;
			_IdPais = IdPais;

            
            Initialized();
        }
        
        #endregion

        #region "Fields"

        /// <summary>
/// 
/// </summary>
protected Objects.PaisesObject _PaisesEntity;

        #endregion

        #region "Properties"
        
bool _PaisesEntityFetched;

        /// <summary>
        /// 
        /// </summary>
        public virtual Objects.PaisesObject PaisesEntity
        {
            get
            {
                if (_PaisesEntity== null  && this.IdPais.HasValue && ! _PaisesEntityFetched ) {
_PaisesEntityFetched = true;
Objects.PaisesObject _PaisesEntityTemp = new Objects.PaisesObject(this.IdPais.Value); 
ILazyProvider lazyProvider = LazyProviderFactory.Get(typeof(Objects.PaisesObject));
 _PaisesEntity = lazyProvider.GetEntity(typeof(Objects.PaisesObject), _PaisesEntityTemp) as Objects.PaisesObject;
}

                return _PaisesEntity;
            }
            set
            {
                base.PropertyModified();
                _PaisesEntity = value;
                if (value != null) {
   _IdPais = value.IdPais;

} else {
   _IdPais = null;

}

            }
        }
        
        #endregion

        /// <summary>
        /// Returns de original value of entity since was created or restored.
        /// </summary>
        public new Provincias OriginalValue()
        {
            return (Provincias)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            Provincias newObject;            
            

            newObject = (Provincias)this.MemberwiseClone();
            // Entities
                         
            if (this._PaisesEntity != null)
            {
                newObject._PaisesEntity = (Objects.PaisesObject)((ICloneable)this._PaisesEntity).Clone();
            }
            
            // Colections
            
            // OriginalValue
            Provincias newOriginalValue;
            if (base._OriginalValue != null)
            {
                newOriginalValue = (Provincias)this.OriginalValue().MemberwiseClone();
                // Entities
                             
                if (this.OriginalValue()._PaisesEntity != null)
                {
                    newOriginalValue._PaisesEntity = (Objects.PaisesObject)((ICloneable)this.OriginalValue()._PaisesEntity).Clone();
                }
                
                // Colections
                            
                newObject._OriginalValue = newOriginalValue;

            }
            return newObject;            
        }



        /// <summary>
        /// 
        /// </summary>
        void IMappeableProvincias.CompleteEntity(Objects.PaisesObject PaisesEntity)
        {
        _PaisesEntity = PaisesEntity;
        }
        
        bool IMappeableProvincias.IsPaisesEntityNull()
        {
            return (_PaisesEntity == null);
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeableProvincias.SetFKValuesForChilds(Provincias entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Provincias other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableProvincias
    {
        /// <summary>
        /// 
        /// </summary>
        void CompleteEntity(Objects.PaisesObject PaisesEntity);
        
        /// <summary>
        /// 
        /// </summary>
        bool IsPaisesEntityNull();
        
        /// <summary>
        /// 
        /// </summary>
        void SetFKValuesForChilds(Provincias entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class ProvinciasList : ObjectList<Provincias>
    {
    }
}
namespace monaguaRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class ProvinciasListView
        : ObjectListView<Entities.Provincias>
    {
        /// <summary>
        /// 
        /// </summary>
        public ProvinciasListView(Entities.ProvinciasList list): base(list)
        {
        }
    }
}


