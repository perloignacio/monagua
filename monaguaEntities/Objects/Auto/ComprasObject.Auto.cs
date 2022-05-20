
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 20/5/2022 - 04:29 p. m.
// This is a partial class file. The other one is ComprasObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace monaguaRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ComprasObject : BaseObject, IMappeableComprasObject, IUniqueIdentifiable, IEquatable<ComprasObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ComprasObject(): base()
        {

			_IdCompra =  ValuesGenerator.GetInt32;

        }

        /// <summary>
        /// 
        /// </summary>
        public ComprasObject(
			System.Int32 IdCompra): base()
        {

			_IdCompra = IdCompra;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public ComprasObject(
			System.Int32 IdCompra,
			System.Int32 IdCliente,
			System.DateTime Fecha,
			System.Decimal Total,
			System.Boolean Reserva,
			System.Nullable<System.Int32> IdDescuento,
			System.String MercadoPago,
			System.Int32 IdEstadoCompra,
			System.Boolean Activa): base()
        {

			_IdCompra = IdCompra;
			_IdCliente = IdCliente;
			_Fecha = Fecha;
			_Total = Total;
			_Reserva = Reserva;
			_IdDescuento = IdDescuento;
			_MercadoPago = MercadoPago;
			_IdEstadoCompra = IdEstadoCompra;
			_Activa = Activa;

            Initialized();
        }
        

        #endregion

        #region "Events"
        
        
        #endregion

        #region "Fields"

            /// <summary>
/// 
/// </summary>
protected System.Int32 _IdCompra;
/// <summary>
/// 
/// </summary>
protected System.Int32 _IdCliente;
/// <summary>
/// 
/// </summary>
protected System.DateTime _Fecha;
/// <summary>
/// 
/// </summary>
protected System.Decimal _Total;
/// <summary>
/// 
/// </summary>
protected System.Boolean _Reserva;
/// <summary>
///
/// </summary>
protected System.Nullable<System.Int32> _IdDescuento;
/// <summary>
/// 
/// </summary>
protected System.String _MercadoPago;
/// <summary>
/// 
/// </summary>
protected System.Int32 _IdEstadoCompra;
/// <summary>
/// 
/// </summary>
protected System.Boolean _Activa;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdCompra
        {
            get
            {
                return _IdCompra;
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdCliente
        {
            get
            {
                return _IdCliente;
            }
            
            set
            {
                base.PropertyModified();
                _IdCliente = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.DateTime Fecha
        {
            get
            {
                return _Fecha;
            }
            
            set
            {
                base.PropertyModified();
                _Fecha = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Decimal Total
        {
            get
            {
                return _Total;
            }
            
            set
            {
                base.PropertyModified();
                _Total = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Boolean Reserva
        {
            get
            {
                return _Reserva;
            }
            
            set
            {
                base.PropertyModified();
                _Reserva = value;
                
            }
            
        }
        
        /// <summary>
        /// Nullable property
        /// </summary>
        public virtual System.Nullable<System.Int32> IdDescuento
        {
            get
            {
                return _IdDescuento;
            }
            
            set
            {
                base.PropertyModified();
                _IdDescuento = value;                
                
            }
            
        }
                
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String MercadoPago
        {
            get
            {
                return _MercadoPago;
            }
            
            set
            {
                base.PropertyModified();
                _MercadoPago = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdEstadoCompra
        {
            get
            {
                return _IdEstadoCompra;
            }
            
            set
            {
                base.PropertyModified();
                _IdEstadoCompra = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Boolean Activa
        {
            get
            {
                return _Activa;
            }
            
            set
            {
                base.PropertyModified();
                _Activa = value;
                
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
            ComprasObject newObject;
            ComprasObject newOriginalValue;

            newObject = (ComprasObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ComprasObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new ComprasObject OriginalValue()
        {
            return (ComprasObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableComprasObject.HydrateFields(
			System.Int32 IdCompra,
			System.Int32 IdCliente,
			System.DateTime Fecha,
			System.Decimal Total,
			System.Boolean Reserva,
			System.Nullable<System.Int32> IdDescuento,
			System.String MercadoPago,
			System.Int32 IdEstadoCompra,
			System.Boolean Activa)
        {
        _IdCompra = IdCompra;
_IdCliente = IdCliente;
_Fecha = Fecha;
_Total = Total;
_Reserva = Reserva;
_IdDescuento = IdDescuento;
_MercadoPago = MercadoPago;
_IdEstadoCompra = IdEstadoCompra;
_Activa = Activa;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableComprasObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[9];
            _myArray[0] = _IdCompra;
_myArray[1] = _IdCliente;
_myArray[2] = _Fecha;
_myArray[3] = _Total;
_myArray[4] = _Reserva;
if (_IdDescuento.HasValue) _myArray[5] = _IdDescuento.Value;
if (!System.String.IsNullOrEmpty(_MercadoPago)) _myArray[6] = _MercadoPago;
_myArray[7] = _IdEstadoCompra;
_myArray[8] = _Activa;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableComprasObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[9];
            _myArray[0] = _IdCompra;
_myArray[1] = _IdCliente;
_myArray[2] = _Fecha;
_myArray[3] = _Total;
_myArray[4] = _Reserva;
if (_IdDescuento.HasValue) _myArray[5] = _IdDescuento.Value;
if (!System.String.IsNullOrEmpty(_MercadoPago)) _myArray[6] = _MercadoPago;
_myArray[7] = _IdEstadoCompra;
_myArray[8] = _Activa;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableComprasObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdCompra;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableComprasObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            _IdCompra = (System.Int32) parameters[0];

        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            ComprasObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdCompra};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ComprasObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableComprasObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdCompra, 
			System.Int32 IdCliente, 
			System.DateTime Fecha, 
			System.Decimal Total, 
			System.Boolean Reserva, 
			System.Nullable<System.Int32> IdDescuento, 
			System.String MercadoPago, 
			System.Int32 IdEstadoCompra, 
			System.Boolean Activa);

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
    public partial class ComprasObjectList : ObjectList<ComprasObject>
    {
    }
}

namespace monaguaRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ComprasObjectListView
        : ObjectListView<Objects.ComprasObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public ComprasObjectListView(Objects.ComprasObjectList list): base(list)
        {
        }
    }
}


