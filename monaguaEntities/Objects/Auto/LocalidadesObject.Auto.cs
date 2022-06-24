
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 22/6/2022 - 05:03 p. m.
// This is a partial class file. The other one is LocalidadesObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace monaguaRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class LocalidadesObject : BaseObject, IMappeableLocalidadesObject, IUniqueIdentifiable, IEquatable<LocalidadesObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public LocalidadesObject(): base()
        {


        }

        /// <summary>
        /// 
        /// </summary>
        public LocalidadesObject(
			System.Int32 IdLocalidad): base()
        {

			_IdLocalidad = IdLocalidad;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public LocalidadesObject(
			System.Int32 IdLocalidad,
			System.String Nombre,
			System.String Cp,
			System.Int32 IdProvincia): base()
        {

			_IdLocalidad = IdLocalidad;
			_Nombre = Nombre;
			_Cp = Cp;
			_IdProvincia = IdProvincia;

            Initialized();
        }
        

        #endregion

        #region "Events"
        
        
        #endregion

        #region "Fields"

            /// <summary>
/// 
/// </summary>
protected System.Int32 _IdLocalidad;
/// <summary>
/// 
/// </summary>
protected System.String _Nombre;
/// <summary>
/// 
/// </summary>
protected System.String _Cp;
/// <summary>
/// 
/// </summary>
protected System.Int32 _IdProvincia;

        #endregion

        #region "Properties"
        
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
        public virtual System.String Cp
        {
            get
            {
                return _Cp;
            }
            
            set
            {
                base.PropertyModified();
                _Cp = value;
                
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
            LocalidadesObject newObject;
            LocalidadesObject newOriginalValue;

            newObject = (LocalidadesObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (LocalidadesObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new LocalidadesObject OriginalValue()
        {
            return (LocalidadesObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableLocalidadesObject.HydrateFields(
			System.Int32 IdLocalidad,
			System.String Nombre,
			System.String Cp,
			System.Int32 IdProvincia)
        {
        _IdLocalidad = IdLocalidad;
_Nombre = Nombre;
_Cp = Cp;
_IdProvincia = IdProvincia;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableLocalidadesObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[4];
            _myArray[0] = _IdLocalidad;
_myArray[1] = _Nombre;
_myArray[2] = _Cp;
_myArray[3] = _IdProvincia;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableLocalidadesObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[5];
            _myArray[0] = _IdLocalidad;
_myArray[1] = _Nombre;
_myArray[2] = _Cp;
_myArray[3] = _IdProvincia;
_myArray[4] = this.OriginalValue()._IdLocalidad;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableLocalidadesObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdLocalidad;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableLocalidadesObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            
        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            LocalidadesObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdLocalidad};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(LocalidadesObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableLocalidadesObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdLocalidad, 
			System.String Nombre, 
			System.String Cp, 
			System.Int32 IdProvincia);

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
    public partial class LocalidadesObjectList : ObjectList<LocalidadesObject>
    {
    }
}

namespace monaguaRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class LocalidadesObjectListView
        : ObjectListView<Objects.LocalidadesObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public LocalidadesObjectListView(Objects.LocalidadesObjectList list): base(list)
        {
        }
    }
}


