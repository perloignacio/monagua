
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 08/09/2022 - 16:50
// This is a partial class file. The other one is CategoriasObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace monaguaRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CategoriasObject : BaseObject, IMappeableCategoriasObject, IUniqueIdentifiable, IEquatable<CategoriasObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public CategoriasObject(): base()
        {

			_IdCategoria =  ValuesGenerator.GetInt32;

        }

        /// <summary>
        /// 
        /// </summary>
        public CategoriasObject(
			System.Int32 IdCategoria): base()
        {

			_IdCategoria = IdCategoria;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public CategoriasObject(
			System.Int32 IdCategoria,
			System.String Nombre,
			System.Boolean Activa,
			System.String Icono): base()
        {

			_IdCategoria = IdCategoria;
			_Nombre = Nombre;
			_Activa = Activa;
			_Icono = Icono;

            Initialized();
        }
        

        #endregion

        #region "Events"
        
        
        #endregion

        #region "Fields"

            /// <summary>
/// 
/// </summary>
protected System.Int32 _IdCategoria;
/// <summary>
/// 
/// </summary>
protected System.String _Nombre;
/// <summary>
/// 
/// </summary>
protected System.Boolean _Activa;
/// <summary>
/// 
/// </summary>
protected System.String _Icono;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdCategoria
        {
            get
            {
                return _IdCategoria;
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
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Icono
        {
            get
            {
                return _Icono;
            }
            
            set
            {
                base.PropertyModified();
                _Icono = value;
                
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
            CategoriasObject newObject;
            CategoriasObject newOriginalValue;

            newObject = (CategoriasObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (CategoriasObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new CategoriasObject OriginalValue()
        {
            return (CategoriasObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableCategoriasObject.HydrateFields(
			System.Int32 IdCategoria,
			System.String Nombre,
			System.Boolean Activa,
			System.String Icono)
        {
        _IdCategoria = IdCategoria;
_Nombre = Nombre;
_Activa = Activa;
_Icono = Icono;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableCategoriasObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[4];
            _myArray[0] = _IdCategoria;
_myArray[1] = _Nombre;
_myArray[2] = _Activa;
_myArray[3] = _Icono;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableCategoriasObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[4];
            _myArray[0] = _IdCategoria;
_myArray[1] = _Nombre;
_myArray[2] = _Activa;
_myArray[3] = _Icono;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableCategoriasObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdCategoria;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableCategoriasObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            _IdCategoria = (System.Int32) parameters[0];

        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            CategoriasObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdCategoria};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(CategoriasObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableCategoriasObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdCategoria, 
			System.String Nombre, 
			System.Boolean Activa, 
			System.String Icono);

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
    public partial class CategoriasObjectList : ObjectList<CategoriasObject>
    {
    }
}

namespace monaguaRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CategoriasObjectListView
        : ObjectListView<Objects.CategoriasObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public CategoriasObjectListView(Objects.CategoriasObjectList list): base(list)
        {
        }
    }
}


