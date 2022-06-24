
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 22/6/2022 - 05:03 p. m.
// This is a partial class file. The other one is PaisesEntity.cs
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
    public partial class Paises : Objects.PaisesObject, IMappeablePaises, IEquatable<Paises>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public Paises()
            :base()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        public Paises(
			System.Int32 IdPais)
            : base()
        {

			_IdPais = IdPais;

            
            Initialized();
        }

        

        /// <summary>
        /// 
        /// </summary>
        public Paises(
			System.Int32 IdPais,
			System.String Nombre)
            : base()
        {

			_IdPais = IdPais;
			_Nombre = Nombre;

            
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
        public new Paises OriginalValue()
        {
            return (Paises)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            Paises newObject;            
            

            newObject = (Paises)this.MemberwiseClone();
            // Entities
            
            // Colections
            
            // OriginalValue
            Paises newOriginalValue;
            if (base._OriginalValue != null)
            {
                newOriginalValue = (Paises)this.OriginalValue().MemberwiseClone();
                // Entities
                
                // Colections
                            
                newObject._OriginalValue = newOriginalValue;

            }
            return newObject;            
        }



        /// <summary>
        /// 
        /// </summary>
        void IMappeablePaises.CompleteEntity()
        {
        
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeablePaises.SetFKValuesForChilds(Paises entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Paises other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeablePaises
    {
        /// <summary>
        /// 
        /// </summary>
        void CompleteEntity();
        
        /// <summary>
        /// 
        /// </summary>
        void SetFKValuesForChilds(Paises entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class PaisesList : ObjectList<Paises>
    {
    }
}
namespace monaguaRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class PaisesListView
        : ObjectListView<Entities.Paises>
    {
        /// <summary>
        /// 
        /// </summary>
        public PaisesListView(Entities.PaisesList list): base(list)
        {
        }
    }
}


