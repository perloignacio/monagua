
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 18/7/2022 - 04:08 p. m.
// This is a partial class file. The other one is TipoRepeticionesEntity.cs
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
    public partial class TipoRepeticiones : Objects.TipoRepeticionesObject, IMappeableTipoRepeticiones, IEquatable<TipoRepeticiones>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public TipoRepeticiones()
            :base()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        public TipoRepeticiones(
			System.Int32 IdTipoRepeticion)
            : base()
        {

			_IdTipoRepeticion = IdTipoRepeticion;

            
            Initialized();
        }

        

        /// <summary>
        /// 
        /// </summary>
        public TipoRepeticiones(
			System.Int32 IdTipoRepeticion,
			System.String Nombre,
			System.Boolean Activa)
            : base()
        {

			_IdTipoRepeticion = IdTipoRepeticion;
			_Nombre = Nombre;
			_Activa = Activa;

            
            Initialized();
        }
        
        #endregion

        #region "Fields"

        
        #endregion

        #region "Properties"
        
        #endregion

        /// <summary>
        /// Returns de original value of entity since was created or restored.
        /// </summary>
        public new TipoRepeticiones OriginalValue()
        {
            return (TipoRepeticiones)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            TipoRepeticiones newObject;            
            

            newObject = (TipoRepeticiones)this.MemberwiseClone();
            // Entities
            
            // Colections
            
            // OriginalValue
            TipoRepeticiones newOriginalValue;
            if (base._OriginalValue != null)
            {
                newOriginalValue = (TipoRepeticiones)this.OriginalValue().MemberwiseClone();
                // Entities
                
                // Colections
                            
                newObject._OriginalValue = newOriginalValue;

            }
            return newObject;            
        }



        /// <summary>
        /// 
        /// </summary>
        void IMappeableTipoRepeticiones.CompleteEntity()
        {
        
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeableTipoRepeticiones.SetFKValuesForChilds(TipoRepeticiones entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(TipoRepeticiones other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableTipoRepeticiones
    {
        /// <summary>
        /// 
        /// </summary>
        void CompleteEntity();
        
        /// <summary>
        /// 
        /// </summary>
        void SetFKValuesForChilds(TipoRepeticiones entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class TipoRepeticionesList : ObjectList<TipoRepeticiones>
    {
    }
}
namespace monaguaRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class TipoRepeticionesListView
        : ObjectListView<Entities.TipoRepeticiones>
    {
        /// <summary>
        /// 
        /// </summary>
        public TipoRepeticionesListView(Entities.TipoRepeticionesList list): base(list)
        {
        }
    }
}


