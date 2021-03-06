
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 6/7/2022 - 04:37 p. m.
// This is a partial class file. The other one is PrestadoresObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace monaguaRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PrestadoresObject : BaseObject, IMappeablePrestadoresObject, IUniqueIdentifiable, IEquatable<PrestadoresObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public PrestadoresObject(): base()
        {

			_IdPrestador =  ValuesGenerator.GetInt32;

        }

        /// <summary>
        /// 
        /// </summary>
        public PrestadoresObject(
			System.Int32 IdPrestador): base()
        {

			_IdPrestador = IdPrestador;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public PrestadoresObject(
			System.Int32 IdPrestador,
			System.String RazonSocial,
			System.String NombreFantasia,
			System.String Cuit,
			System.Int32 IdPais,
			System.Int32 IdProvincia,
			System.Int32 IdLocalidad,
			System.String Email,
			System.String Logo,
			System.DateTime FechaRegistro,
			System.Boolean PrestadorHabilitado,
			System.Boolean Politicas,
			System.Boolean Activo,
			System.String Telefono): base()
        {

			_IdPrestador = IdPrestador;
			_RazonSocial = RazonSocial;
			_NombreFantasia = NombreFantasia;
			_Cuit = Cuit;
			_IdPais = IdPais;
			_IdProvincia = IdProvincia;
			_IdLocalidad = IdLocalidad;
			_Email = Email;
			_Logo = Logo;
			_FechaRegistro = FechaRegistro;
			_PrestadorHabilitado = PrestadorHabilitado;
			_Politicas = Politicas;
			_Activo = Activo;
			_Telefono = Telefono;

            Initialized();
        }
        

        #endregion

        #region "Events"
        
        
        #endregion

        #region "Fields"

            /// <summary>
/// 
/// </summary>
protected System.Int32 _IdPrestador;
/// <summary>
/// 
/// </summary>
protected System.String _RazonSocial;
/// <summary>
/// 
/// </summary>
protected System.String _NombreFantasia;
/// <summary>
/// 
/// </summary>
protected System.String _Cuit;
/// <summary>
/// 
/// </summary>
protected System.Int32 _IdPais;
/// <summary>
/// 
/// </summary>
protected System.Int32 _IdProvincia;
/// <summary>
/// 
/// </summary>
protected System.Int32 _IdLocalidad;
/// <summary>
/// 
/// </summary>
protected System.String _Email;
/// <summary>
/// 
/// </summary>
protected System.String _Logo;
/// <summary>
/// 
/// </summary>
protected System.DateTime _FechaRegistro;
/// <summary>
/// 
/// </summary>
protected System.Boolean _PrestadorHabilitado;
/// <summary>
/// 
/// </summary>
protected System.Boolean _Politicas;
/// <summary>
/// 
/// </summary>
protected System.Boolean _Activo;
/// <summary>
/// 
/// </summary>
protected System.String _Telefono;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdPrestador
        {
            get
            {
                return _IdPrestador;
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String RazonSocial
        {
            get
            {
                return _RazonSocial;
            }
            
            set
            {
                base.PropertyModified();
                _RazonSocial = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String NombreFantasia
        {
            get
            {
                return _NombreFantasia;
            }
            
            set
            {
                base.PropertyModified();
                _NombreFantasia = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Cuit
        {
            get
            {
                return _Cuit;
            }
            
            set
            {
                base.PropertyModified();
                _Cuit = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdPais
        {
            get
            {
                return _IdPais;
            }
            
            set
            {
                base.PropertyModified();
                _IdPais = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdProvincia
        {
            get
            {
                return _IdProvincia;
            }
            
            set
            {
                base.PropertyModified();
                _IdProvincia = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdLocalidad
        {
            get
            {
                return _IdLocalidad;
            }
            
            set
            {
                base.PropertyModified();
                _IdLocalidad = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Email
        {
            get
            {
                return _Email;
            }
            
            set
            {
                base.PropertyModified();
                _Email = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Logo
        {
            get
            {
                return _Logo;
            }
            
            set
            {
                base.PropertyModified();
                _Logo = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.DateTime FechaRegistro
        {
            get
            {
                return _FechaRegistro;
            }
            
            set
            {
                base.PropertyModified();
                _FechaRegistro = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Boolean PrestadorHabilitado
        {
            get
            {
                return _PrestadorHabilitado;
            }
            
            set
            {
                base.PropertyModified();
                _PrestadorHabilitado = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Boolean Politicas
        {
            get
            {
                return _Politicas;
            }
            
            set
            {
                base.PropertyModified();
                _Politicas = value;
                
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
        public virtual System.String Telefono
        {
            get
            {
                return _Telefono;
            }
            
            set
            {
                base.PropertyModified();
                _Telefono = value;
                
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
            PrestadoresObject newObject;
            PrestadoresObject newOriginalValue;

            newObject = (PrestadoresObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (PrestadoresObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new PrestadoresObject OriginalValue()
        {
            return (PrestadoresObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeablePrestadoresObject.HydrateFields(
			System.Int32 IdPrestador,
			System.String RazonSocial,
			System.String NombreFantasia,
			System.String Cuit,
			System.Int32 IdPais,
			System.Int32 IdProvincia,
			System.Int32 IdLocalidad,
			System.String Email,
			System.String Logo,
			System.DateTime FechaRegistro,
			System.Boolean PrestadorHabilitado,
			System.Boolean Politicas,
			System.Boolean Activo,
			System.String Telefono)
        {
        _IdPrestador = IdPrestador;
_RazonSocial = RazonSocial;
_NombreFantasia = NombreFantasia;
_Cuit = Cuit;
_IdPais = IdPais;
_IdProvincia = IdProvincia;
_IdLocalidad = IdLocalidad;
_Email = Email;
_Logo = Logo;
_FechaRegistro = FechaRegistro;
_PrestadorHabilitado = PrestadorHabilitado;
_Politicas = Politicas;
_Activo = Activo;
_Telefono = Telefono;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeablePrestadoresObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[14];
            _myArray[0] = _IdPrestador;
_myArray[1] = _RazonSocial;
if (!System.String.IsNullOrEmpty(_NombreFantasia)) _myArray[2] = _NombreFantasia;
_myArray[3] = _Cuit;
_myArray[4] = _IdPais;
_myArray[5] = _IdProvincia;
_myArray[6] = _IdLocalidad;
_myArray[7] = _Email;
_myArray[8] = _Logo;
_myArray[9] = _FechaRegistro;
_myArray[10] = _PrestadorHabilitado;
_myArray[11] = _Politicas;
_myArray[12] = _Activo;
_myArray[13] = _Telefono;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeablePrestadoresObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[14];
            _myArray[0] = _IdPrestador;
_myArray[1] = _RazonSocial;
if (!System.String.IsNullOrEmpty(_NombreFantasia)) _myArray[2] = _NombreFantasia;
_myArray[3] = _Cuit;
_myArray[4] = _IdPais;
_myArray[5] = _IdProvincia;
_myArray[6] = _IdLocalidad;
_myArray[7] = _Email;
_myArray[8] = _Logo;
_myArray[9] = _FechaRegistro;
_myArray[10] = _PrestadorHabilitado;
_myArray[11] = _Politicas;
_myArray[12] = _Activo;
_myArray[13] = _Telefono;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeablePrestadoresObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdPrestador;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeablePrestadoresObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            _IdPrestador = (System.Int32) parameters[0];

        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            PrestadoresObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdPrestador};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(PrestadoresObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeablePrestadoresObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdPrestador, 
			System.String RazonSocial, 
			System.String NombreFantasia, 
			System.String Cuit, 
			System.Int32 IdPais, 
			System.Int32 IdProvincia, 
			System.Int32 IdLocalidad, 
			System.String Email, 
			System.String Logo, 
			System.DateTime FechaRegistro, 
			System.Boolean PrestadorHabilitado, 
			System.Boolean Politicas, 
			System.Boolean Activo, 
			System.String Telefono);

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
    public partial class PrestadoresObjectList : ObjectList<PrestadoresObject>
    {
    }
}

namespace monaguaRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PrestadoresObjectListView
        : ObjectListView<Objects.PrestadoresObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public PrestadoresObjectListView(Objects.PrestadoresObjectList list): base(list)
        {
        }
    }
}


