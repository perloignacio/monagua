
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 31/08/2022 - 14:49
// This is a partial class file. The other one is TipoRepeticionesObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace monaguaRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TipoRepeticionesObject : BaseObject, IMappeableTipoRepeticionesObject, IUniqueIdentifiable, IEquatable<TipoRepeticionesObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public TipoRepeticionesObject(): base()
        {


        }

        /// <summary>
        /// 
        /// </summary>
        public TipoRepeticionesObject(
			System.Int32 IdTipoRepeticion): base()
        {

			_IdTipoRepeticion = IdTipoRepeticion;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public TipoRepeticionesObject(
			System.Int32 IdTipoRepeticion,
			System.String Nombre,
			System.Boolean Activa): base()
        {

			_IdTipoRepeticion = IdTipoRepeticion;
			_Nombre = Nombre;
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
protected System.Int32 _IdTipoRepeticion;
/// <summary>
/// 
/// </summary>
protected System.String _Nombre;
/// <summary>
/// 
/// </summary>
protected System.Boolean _Activa;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdTipoRepeticion
        {
            get
            {
                return _IdTipoRepeticion;
            }
            
            set
            {
                base.PropertyModified();
                _IdTipoRepeticion = value;
                
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
            TipoRepeticionesObject newObject;
            TipoRepeticionesObject newOriginalValue;

            newObject = (TipoRepeticionesObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (TipoRepeticionesObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new TipoRepeticionesObject OriginalValue()
        {
            return (TipoRepeticionesObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableTipoRepeticionesObject.HydrateFields(
			System.Int32 IdTipoRepeticion,
			System.String Nombre,
			System.Boolean Activa)
        {
        _IdTipoRepeticion = IdTipoRepeticion;
_Nombre = Nombre;
_Activa = Activa;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableTipoRepeticionesObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[3];
            _myArray[0] = _IdTipoRepeticion;
_myArray[1] = _Nombre;
_myArray[2] = _Activa;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableTipoRepeticionesObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[4];
            _myArray[0] = _IdTipoRepeticion;
_myArray[1] = _Nombre;
_myArray[2] = _Activa;
_myArray[3] = this.OriginalValue()._IdTipoRepeticion;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableTipoRepeticionesObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdTipoRepeticion;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableTipoRepeticionesObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            
        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            TipoRepeticionesObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdTipoRepeticion};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(TipoRepeticionesObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableTipoRepeticionesObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdTipoRepeticion, 
			System.String Nombre, 
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
    public partial class TipoRepeticionesObjectList : ObjectList<TipoRepeticionesObject>
    {
    }
}

namespace monaguaRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TipoRepeticionesObjectListView
        : ObjectListView<Objects.TipoRepeticionesObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public TipoRepeticionesObjectListView(Objects.TipoRepeticionesObjectList list): base(list)
        {
        }
    }
}


