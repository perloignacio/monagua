
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 10/6/2022 - 05:08 p. m.
// This is a partial class file. The other one is ProvinciasObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace monaguaRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ProvinciasObject : BaseObject, IMappeableProvinciasObject, IUniqueIdentifiable, IEquatable<ProvinciasObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ProvinciasObject(): base()
        {


        }

        /// <summary>
        /// 
        /// </summary>
        public ProvinciasObject(
			System.Int32 IdProvincia): base()
        {

			_IdProvincia = IdProvincia;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public ProvinciasObject(
			System.Int32 IdProvincia,
			System.String Nombre,
			System.Nullable<System.Int32> IdPais): base()
        {

			_IdProvincia = IdProvincia;
			_Nombre = Nombre;
			_IdPais = IdPais;

            Initialized();
        }
        

        #endregion

        #region "Events"
        
        
        #endregion

        #region "Fields"

            /// <summary>
/// 
/// </summary>
protected System.Int32 _IdProvincia;
/// <summary>
/// 
/// </summary>
protected System.String _Nombre;
/// <summary>
///
/// </summary>
protected System.Nullable<System.Int32> _IdPais;

        #endregion

        #region "Properties"
        
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
        /// Nullable property
        /// </summary>
        public virtual System.Nullable<System.Int32> IdPais
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
            ProvinciasObject newObject;
            ProvinciasObject newOriginalValue;

            newObject = (ProvinciasObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ProvinciasObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new ProvinciasObject OriginalValue()
        {
            return (ProvinciasObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableProvinciasObject.HydrateFields(
			System.Int32 IdProvincia,
			System.String Nombre,
			System.Nullable<System.Int32> IdPais)
        {
        _IdProvincia = IdProvincia;
_Nombre = Nombre;
_IdPais = IdPais;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableProvinciasObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[3];
            _myArray[0] = _IdProvincia;
_myArray[1] = _Nombre;
if (_IdPais.HasValue) _myArray[2] = _IdPais.Value;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableProvinciasObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[4];
            _myArray[0] = _IdProvincia;
_myArray[1] = _Nombre;
if (_IdPais.HasValue) _myArray[2] = _IdPais.Value;
_myArray[3] = this.OriginalValue()._IdProvincia;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableProvinciasObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdProvincia;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableProvinciasObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            
        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            ProvinciasObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdProvincia};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ProvinciasObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableProvinciasObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdProvincia, 
			System.String Nombre, 
			System.Nullable<System.Int32> IdPais);

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
    public partial class ProvinciasObjectList : ObjectList<ProvinciasObject>
    {
    }
}

namespace monaguaRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ProvinciasObjectListView
        : ObjectListView<Objects.ProvinciasObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public ProvinciasObjectListView(Objects.ProvinciasObjectList list): base(list)
        {
        }
    }
}


