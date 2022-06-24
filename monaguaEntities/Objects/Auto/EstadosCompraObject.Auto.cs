
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 22/6/2022 - 05:03 p. m.
// This is a partial class file. The other one is EstadosCompraObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace monaguaRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EstadosCompraObject : BaseObject, IMappeableEstadosCompraObject, IUniqueIdentifiable, IEquatable<EstadosCompraObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public EstadosCompraObject(): base()
        {


        }

        /// <summary>
        /// 
        /// </summary>
        public EstadosCompraObject(
			System.Int32 IdEstadoCompra): base()
        {

			_IdEstadoCompra = IdEstadoCompra;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public EstadosCompraObject(
			System.Int32 IdEstadoCompra,
			System.String Nombre,
			System.Int32 Orden): base()
        {

			_IdEstadoCompra = IdEstadoCompra;
			_Nombre = Nombre;
			_Orden = Orden;

            Initialized();
        }
        

        #endregion

        #region "Events"
        
        
        #endregion

        #region "Fields"

            /// <summary>
/// 
/// </summary>
protected System.Int32 _IdEstadoCompra;
/// <summary>
/// 
/// </summary>
protected System.String _Nombre;
/// <summary>
/// 
/// </summary>
protected System.Int32 _Orden;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdEstadoCompra
        {
            get
            {
                return _IdEstadoCompra;
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            
            set
            {
                base.PropertyModified();
                _Nombre = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 Orden
        {
            get
            {
                return _Orden;
            }
            
            set
            {
                base.PropertyModified();
                _Orden = value;
                
            }
            
        }
        
        #endregion

        
            
                
        /// <summary>
        /// 
        /// </summary>
        protected override void SetOriginalValue()
        {
            base._OriginalValue = (IObject) this.MemberwiseClone();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            EstadosCompraObject newObject;
            EstadosCompraObject newOriginalValue;

            newObject = (EstadosCompraObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (EstadosCompraObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new EstadosCompraObject OriginalValue()
        {
            return (EstadosCompraObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableEstadosCompraObject.HydrateFields(
			System.Int32 IdEstadoCompra,
			System.String Nombre,
			System.Int32 Orden)
        {
        _IdEstadoCompra = IdEstadoCompra;
_Nombre = Nombre;
_Orden = Orden;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableEstadosCompraObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[3];
            _myArray[0] = _IdEstadoCompra;
_myArray[1] = _Nombre;
_myArray[2] = _Orden;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableEstadosCompraObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[4];
            _myArray[0] = _IdEstadoCompra;
_myArray[1] = _Nombre;
_myArray[2] = _Orden;
_myArray[3] = this.OriginalValue()._IdEstadoCompra;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableEstadosCompraObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdEstadoCompra;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableEstadosCompraObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            
        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            EstadosCompraObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdEstadoCompra};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(EstadosCompraObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableEstadosCompraObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdEstadoCompra, 
			System.String Nombre, 
			System.Int32 Orden);

        /// <summary>
        /// 
        /// </summary>
        object[] GetFieldsForInsert();

        /// <summary>
        /// 
        /// </summary>
        object[] GetFieldsForUpdate();

        /// <summary>
        /// 
        /// </summary>
        object[] GetFieldsForDelete();

        /// <summary>
        /// 
        /// </summary>
        void UpdateObjectFromOutputParams(object[] parameters);
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class EstadosCompraObjectList : ObjectList<EstadosCompraObject>
    {
    }
}

namespace monaguaRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EstadosCompraObjectListView
        : ObjectListView<Objects.EstadosCompraObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public EstadosCompraObjectListView(Objects.EstadosCompraObjectList list): base(list)
        {
        }
    }
}


