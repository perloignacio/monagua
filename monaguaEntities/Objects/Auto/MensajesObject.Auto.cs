
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 10/6/2022 - 05:08 p. m.
// This is a partial class file. The other one is MensajesObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace monaguaRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MensajesObject : BaseObject, IMappeableMensajesObject, IUniqueIdentifiable, IEquatable<MensajesObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public MensajesObject(): base()
        {

			_IdMensaje =  ValuesGenerator.GetInt32;

        }

        /// <summary>
        /// 
        /// </summary>
        public MensajesObject(
			System.Int32 IdMensaje): base()
        {

			_IdMensaje = IdMensaje;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public MensajesObject(
			System.Int32 IdMensaje,
			System.DateTime Fecha,
			System.String Mensaje,
			System.Boolean LeidoPrestador,
			System.Boolean LeidoCliente,
			System.Boolean OrigenCliente,
			System.Boolean Activo,
			System.Int32 IdCompraDetalle): base()
        {

			_IdMensaje = IdMensaje;
			_Fecha = Fecha;
			_Mensaje = Mensaje;
			_LeidoPrestador = LeidoPrestador;
			_LeidoCliente = LeidoCliente;
			_OrigenCliente = OrigenCliente;
			_Activo = Activo;
			_IdCompraDetalle = IdCompraDetalle;

            Initialized();
        }
        

        #endregion

        #region "Events"
        
        
        #endregion

        #region "Fields"

            /// <summary>
/// 
/// </summary>
protected System.Int32 _IdMensaje;
/// <summary>
/// 
/// </summary>
protected System.DateTime _Fecha;
/// <summary>
/// 
/// </summary>
protected System.String _Mensaje;
/// <summary>
/// 
/// </summary>
protected System.Boolean _LeidoPrestador;
/// <summary>
/// 
/// </summary>
protected System.Boolean _LeidoCliente;
/// <summary>
/// 
/// </summary>
protected System.Boolean _OrigenCliente;
/// <summary>
/// 
/// </summary>
protected System.Boolean _Activo;
/// <summary>
/// 
/// </summary>
protected System.Int32 _IdCompraDetalle;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdMensaje
        {
            get
            {
                return _IdMensaje;
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
        public virtual System.String Mensaje
        {
            get
            {
                return _Mensaje;
            }
            
            set
            {
                base.PropertyModified();
                _Mensaje = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Boolean LeidoPrestador
        {
            get
            {
                return _LeidoPrestador;
            }
            
            set
            {
                base.PropertyModified();
                _LeidoPrestador = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Boolean LeidoCliente
        {
            get
            {
                return _LeidoCliente;
            }
            
            set
            {
                base.PropertyModified();
                _LeidoCliente = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Boolean OrigenCliente
        {
            get
            {
                return _OrigenCliente;
            }
            
            set
            {
                base.PropertyModified();
                _OrigenCliente = value;
                
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
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdCompraDetalle
        {
            get
            {
                return _IdCompraDetalle;
            }
            
            set
            {
                base.PropertyModified();
                _IdCompraDetalle = value;
                
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
            MensajesObject newObject;
            MensajesObject newOriginalValue;

            newObject = (MensajesObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (MensajesObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new MensajesObject OriginalValue()
        {
            return (MensajesObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableMensajesObject.HydrateFields(
			System.Int32 IdMensaje,
			System.DateTime Fecha,
			System.String Mensaje,
			System.Boolean LeidoPrestador,
			System.Boolean LeidoCliente,
			System.Boolean OrigenCliente,
			System.Boolean Activo,
			System.Int32 IdCompraDetalle)
        {
        _IdMensaje = IdMensaje;
_Fecha = Fecha;
_Mensaje = Mensaje;
_LeidoPrestador = LeidoPrestador;
_LeidoCliente = LeidoCliente;
_OrigenCliente = OrigenCliente;
_Activo = Activo;
_IdCompraDetalle = IdCompraDetalle;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableMensajesObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[8];
            _myArray[0] = _IdMensaje;
_myArray[1] = _Fecha;
_myArray[2] = _Mensaje;
_myArray[3] = _LeidoPrestador;
_myArray[4] = _LeidoCliente;
_myArray[5] = _OrigenCliente;
_myArray[6] = _Activo;
_myArray[7] = _IdCompraDetalle;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableMensajesObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[8];
            _myArray[0] = _IdMensaje;
_myArray[1] = _Fecha;
_myArray[2] = _Mensaje;
_myArray[3] = _LeidoPrestador;
_myArray[4] = _LeidoCliente;
_myArray[5] = _OrigenCliente;
_myArray[6] = _Activo;
_myArray[7] = _IdCompraDetalle;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableMensajesObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdMensaje;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableMensajesObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            _IdMensaje = (System.Int32) parameters[0];

        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            MensajesObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdMensaje};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(MensajesObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableMensajesObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdMensaje, 
			System.DateTime Fecha, 
			System.String Mensaje, 
			System.Boolean LeidoPrestador, 
			System.Boolean LeidoCliente, 
			System.Boolean OrigenCliente, 
			System.Boolean Activo, 
			System.Int32 IdCompraDetalle);

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
    public partial class MensajesObjectList : ObjectList<MensajesObject>
    {
    }
}

namespace monaguaRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MensajesObjectListView
        : ObjectListView<Objects.MensajesObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public MensajesObjectListView(Objects.MensajesObjectList list): base(list)
        {
        }
    }
}


