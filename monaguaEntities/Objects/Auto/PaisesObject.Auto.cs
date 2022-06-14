
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 10/6/2022 - 05:08 p. m.
// This is a partial class file. The other one is PaisesObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace monaguaRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PaisesObject : BaseObject, IMappeablePaisesObject, IUniqueIdentifiable, IEquatable<PaisesObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public PaisesObject(): base()
        {


        }

        /// <summary>
        /// 
        /// </summary>
        public PaisesObject(
			System.Int32 IdPais): base()
        {

			_IdPais = IdPais;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public PaisesObject(
			System.Int32 IdPais,
			System.String Nombre): base()
        {

			_IdPais = IdPais;
			_Nombre = Nombre;

            Initialized();
        }
        

        #endregion

        #region "Events"
        
        
        #endregion

        #region "Fields"

            /// <summary>
/// 
/// </summary>
protected System.Int32 _IdPais;
/// <summary>
/// 
/// </summary>
protected System.String _Nombre;

        #endregion

        #region "Properties"
        
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
            PaisesObject newObject;
            PaisesObject newOriginalValue;

            newObject = (PaisesObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (PaisesObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new PaisesObject OriginalValue()
        {
            return (PaisesObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeablePaisesObject.HydrateFields(
			System.Int32 IdPais,
			System.String Nombre)
        {
        _IdPais = IdPais;
_Nombre = Nombre;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeablePaisesObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[2];
            _myArray[0] = _IdPais;
_myArray[1] = _Nombre;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeablePaisesObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[3];
            _myArray[0] = _IdPais;
_myArray[1] = _Nombre;
_myArray[2] = this.OriginalValue()._IdPais;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeablePaisesObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdPais;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeablePaisesObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            
        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            PaisesObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdPais};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(PaisesObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeablePaisesObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdPais, 
			System.String Nombre);

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
    public partial class PaisesObjectList : ObjectList<PaisesObject>
    {
    }
}

namespace monaguaRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PaisesObjectListView
        : ObjectListView<Objects.PaisesObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public PaisesObjectListView(Objects.PaisesObjectList list): base(list)
        {
        }
    }
}


