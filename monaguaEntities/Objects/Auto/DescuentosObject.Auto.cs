
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 10/6/2022 - 05:08 p. m.
// This is a partial class file. The other one is DescuentosObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace monaguaRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescuentosObject : BaseObject, IMappeableDescuentosObject, IUniqueIdentifiable, IEquatable<DescuentosObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public DescuentosObject(): base()
        {

			_IdDescuento =  ValuesGenerator.GetInt32;

        }

        /// <summary>
        /// 
        /// </summary>
        public DescuentosObject(
			System.Int32 IdDescuento): base()
        {

			_IdDescuento = IdDescuento;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public DescuentosObject(
			System.Int32 IdDescuento,
			System.String Nombre,
			System.String Codigo,
			System.Nullable<System.Decimal> Porcentaje,
			System.Nullable<System.Decimal> Monto,
			System.Nullable<System.Int32> Stock,
			System.Nullable<System.DateTime> FechaDesde,
			System.Nullable<System.DateTime> FechaHasta,
			System.Boolean Activo): base()
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

        #region "Events"
        
        
        #endregion

        #region "Fields"

            /// <summary>
/// 
/// </summary>
protected System.Int32 _IdDescuento;
/// <summary>
/// 
/// </summary>
protected System.String _Nombre;
/// <summary>
/// 
/// </summary>
protected System.String _Codigo;
/// <summary>
///
/// </summary>
protected System.Nullable<System.Decimal> _Porcentaje;
/// <summary>
///
/// </summary>
protected System.Nullable<System.Decimal> _Monto;
/// <summary>
///
/// </summary>
protected System.Nullable<System.Int32> _Stock;
/// <summary>
///
/// </summary>
protected System.Nullable<System.DateTime> _FechaDesde;
/// <summary>
///
/// </summary>
protected System.Nullable<System.DateTime> _FechaHasta;
/// <summary>
/// 
/// </summary>
protected System.Boolean _Activo;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdDescuento
        {
            get
            {
                return _IdDescuento;
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
        public virtual System.String Codigo
        {
            get
            {
                return _Codigo;
            }
            
            set
            {
                base.PropertyModified();
                _Codigo = value;
                
            }
            
        }
        
        /// <summary>
        /// Nullable property
        /// </summary>
        public virtual System.Nullable<System.Decimal> Porcentaje
        {
            get
            {
                return _Porcentaje;
            }
            
            set
            {
                base.PropertyModified();
                _Porcentaje = value;                
                
            }
            
        }
                
        /// <summary>
        /// Nullable property
        /// </summary>
        public virtual System.Nullable<System.Decimal> Monto
        {
            get
            {
                return _Monto;
            }
            
            set
            {
                base.PropertyModified();
                _Monto = value;                
                
            }
            
        }
                
        /// <summary>
        /// Nullable property
        /// </summary>
        public virtual System.Nullable<System.Int32> Stock
        {
            get
            {
                return _Stock;
            }
            
            set
            {
                base.PropertyModified();
                _Stock = value;                
                
            }
            
        }
                
        /// <summary>
        /// Nullable property
        /// </summary>
        public virtual System.Nullable<System.DateTime> FechaDesde
        {
            get
            {
                return _FechaDesde;
            }
            
            set
            {
                base.PropertyModified();
                _FechaDesde = value;                
                
            }
            
        }
                
        /// <summary>
        /// Nullable property
        /// </summary>
        public virtual System.Nullable<System.DateTime> FechaHasta
        {
            get
            {
                return _FechaHasta;
            }
            
            set
            {
                base.PropertyModified();
                _FechaHasta = value;                
                
            }
            
        }
                
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Boolean Activo
        {
            get
            {
                return _Activo;
            }
            
            set
            {
                base.PropertyModified();
                _Activo = value;
                
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
            DescuentosObject newObject;
            DescuentosObject newOriginalValue;

            newObject = (DescuentosObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (DescuentosObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new DescuentosObject OriginalValue()
        {
            return (DescuentosObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableDescuentosObject.HydrateFields(
			System.Int32 IdDescuento,
			System.String Nombre,
			System.String Codigo,
			System.Nullable<System.Decimal> Porcentaje,
			System.Nullable<System.Decimal> Monto,
			System.Nullable<System.Int32> Stock,
			System.Nullable<System.DateTime> FechaDesde,
			System.Nullable<System.DateTime> FechaHasta,
			System.Boolean Activo)
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
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableDescuentosObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[9];
            _myArray[0] = _IdDescuento;
_myArray[1] = _Nombre;
_myArray[2] = _Codigo;
if (_Porcentaje.HasValue) _myArray[3] = _Porcentaje.Value;
if (_Monto.HasValue) _myArray[4] = _Monto.Value;
if (_Stock.HasValue) _myArray[5] = _Stock.Value;
if (_FechaDesde.HasValue) _myArray[6] = _FechaDesde.Value;
if (_FechaHasta.HasValue) _myArray[7] = _FechaHasta.Value;
_myArray[8] = _Activo;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableDescuentosObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[9];
            _myArray[0] = _IdDescuento;
_myArray[1] = _Nombre;
_myArray[2] = _Codigo;
if (_Porcentaje.HasValue) _myArray[3] = _Porcentaje.Value;
if (_Monto.HasValue) _myArray[4] = _Monto.Value;
if (_Stock.HasValue) _myArray[5] = _Stock.Value;
if (_FechaDesde.HasValue) _myArray[6] = _FechaDesde.Value;
if (_FechaHasta.HasValue) _myArray[7] = _FechaHasta.Value;
_myArray[8] = _Activo;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableDescuentosObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdDescuento;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableDescuentosObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            _IdDescuento = (System.Int32) parameters[0];

        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            DescuentosObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdDescuento};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(DescuentosObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableDescuentosObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdDescuento, 
			System.String Nombre, 
			System.String Codigo, 
			System.Nullable<System.Decimal> Porcentaje, 
			System.Nullable<System.Decimal> Monto, 
			System.Nullable<System.Int32> Stock, 
			System.Nullable<System.DateTime> FechaDesde, 
			System.Nullable<System.DateTime> FechaHasta, 
			System.Boolean Activo);

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
    public partial class DescuentosObjectList : ObjectList<DescuentosObject>
    {
    }
}

namespace monaguaRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescuentosObjectListView
        : ObjectListView<Objects.DescuentosObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public DescuentosObjectListView(Objects.DescuentosObjectList list): base(list)
        {
        }
    }
}


