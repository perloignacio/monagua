
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 6/7/2022 - 04:37 p. m.
// This is a partial class file. The other one is DescuentosEntity.cs
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
    public partial class Descuentos : Objects.DescuentosObject, IMappeableDescuentos, IEquatable<Descuentos>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public Descuentos()
            :base()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        public Descuentos(
			System.Int32 IdDescuento)
            : base()
        {

			_IdDescuento = IdDescuento;

            
            Initialized();
        }

        

        /// <summary>
        /// 
        /// </summary>
        public Descuentos(
			System.Int32 IdDescuento,
			System.String Nombre,
			System.String Codigo,
			System.Nullable<System.Decimal> Porcentaje,
			System.Nullable<System.Decimal> Monto,
			System.Nullable<System.Int32> Stock,
			System.Nullable<System.DateTime> FechaDesde,
			System.Nullable<System.DateTime> FechaHasta,
			System.Boolean Activo)
            : base()
        {

			_IdDescuento = IdDescuento;
			_Nombre = Nombre;
			_Codigo = Codigo;
			_Porcentaje = Porcentaje;
			_Monto = Monto;
			_Stock = Stock;
			_FechaDesde = FechaDesde;
			_FechaHasta = FechaHasta;
			_Activo = Activo;

            
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
        public new Descuentos OriginalValue()
        {
            return (Descuentos)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            Descuentos newObject;            
            

            newObject = (Descuentos)this.MemberwiseClone();
            // Entities
            
            // Colections
            
            // OriginalValue
            Descuentos newOriginalValue;
            if (base._OriginalValue != null)
            {
                newOriginalValue = (Descuentos)this.OriginalValue().MemberwiseClone();
                // Entities
                
                // Colections
                            
                newObject._OriginalValue = newOriginalValue;

            }
            return newObject;            
        }



        /// <summary>
        /// 
        /// </summary>
        void IMappeableDescuentos.CompleteEntity()
        {
        
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeableDescuentos.SetFKValuesForChilds(Descuentos entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Descuentos other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableDescuentos
    {
        /// <summary>
        /// 
        /// </summary>
        void CompleteEntity();
        
        /// <summary>
        /// 
        /// </summary>
        void SetFKValuesForChilds(Descuentos entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class DescuentosList : ObjectList<Descuentos>
    {
    }
}
namespace monaguaRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class DescuentosListView
        : ObjectListView<Entities.Descuentos>
    {
        /// <summary>
        /// 
        /// </summary>
        public DescuentosListView(Entities.DescuentosList list): base(list)
        {
        }
    }
}


