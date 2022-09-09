
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 08/09/2022 - 16:50
// This is a partial class file. The other one is EstadosCompraEntity.cs
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
    public partial class EstadosCompra : Objects.EstadosCompraObject, IMappeableEstadosCompra, IEquatable<EstadosCompra>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public EstadosCompra()
            :base()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        public EstadosCompra(
			System.Int32 IdEstadoCompra)
            : base()
        {

			_IdEstadoCompra = IdEstadoCompra;

            
            Initialized();
        }

        

        /// <summary>
        /// 
        /// </summary>
        public EstadosCompra(
			System.Int32 IdEstadoCompra,
			System.String Nombre,
			System.Int32 Orden)
            : base()
        {

			_IdEstadoCompra = IdEstadoCompra;
			_Nombre = Nombre;
			_Orden = Orden;

            
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
        public new EstadosCompra OriginalValue()
        {
            return (EstadosCompra)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            EstadosCompra newObject;            
            

            newObject = (EstadosCompra)this.MemberwiseClone();
            // Entities
            
            // Colections
            
            // OriginalValue
            EstadosCompra newOriginalValue;
            if (base._OriginalValue != null)
            {
                newOriginalValue = (EstadosCompra)this.OriginalValue().MemberwiseClone();
                // Entities
                
                // Colections
                            
                newObject._OriginalValue = newOriginalValue;

            }
            return newObject;            
        }



        /// <summary>
        /// 
        /// </summary>
        void IMappeableEstadosCompra.CompleteEntity()
        {
        
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeableEstadosCompra.SetFKValuesForChilds(EstadosCompra entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(EstadosCompra other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableEstadosCompra
    {
        /// <summary>
        /// 
        /// </summary>
        void CompleteEntity();
        
        /// <summary>
        /// 
        /// </summary>
        void SetFKValuesForChilds(EstadosCompra entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class EstadosCompraList : ObjectList<EstadosCompra>
    {
    }
}
namespace monaguaRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class EstadosCompraListView
        : ObjectListView<Entities.EstadosCompra>
    {
        /// <summary>
        /// 
        /// </summary>
        public EstadosCompraListView(Entities.EstadosCompraList list): base(list)
        {
        }
    }
}


