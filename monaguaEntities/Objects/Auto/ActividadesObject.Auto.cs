
        
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 10/6/2022 - 05:08 p. m.
// This is a partial class file. The other one is ActividadesObject.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using Cooperator.Framework.Core;
using System;

namespace monaguaRules.Objects
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ActividadesObject : BaseObject, IMappeableActividadesObject, IUniqueIdentifiable, IEquatable<ActividadesObject>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public ActividadesObject(): base()
        {

			_IdActividad =  ValuesGenerator.GetInt32;

        }

        /// <summary>
        /// 
        /// </summary>
        public ActividadesObject(
			System.Int32 IdActividad): base()
        {

			_IdActividad = IdActividad;

            Initialized();
        }

        
        /// <summary>
        /// 
        /// </summary>
        public ActividadesObject(
			System.Int32 IdActividad,
			System.String Nombre,
			System.String DescripcionCorta,
			System.String Descripcion,
			System.String Fotos,
			System.String Video,
			System.Nullable<System.Int64> Lat,
			System.Nullable<System.Int64> Lng,
			System.String Ubicacion,
			System.Decimal Precio,
			System.Nullable<System.Decimal> PrecioOferta,
			System.Nullable<System.Boolean> Mascotas,
			System.Nullable<System.Boolean> PersonasCapacidadRed,
			System.Nullable<System.Boolean> DietasEspeciales,
			System.String Idiomas,
			System.String Dificultad,
			System.String QueIncluye,
			System.String QueNoIncluye,
			System.Int32 Duracion,
			System.Int32 IdCategoria,
			System.Int32 IdPrestador,
			System.Boolean Activa): base()
        {

			_IdActividad = IdActividad;
			_Nombre = Nombre;
			_DescripcionCorta = DescripcionCorta;
			_Descripcion = Descripcion;
			_Fotos = Fotos;
			_Video = Video;
			_Lat = Lat;
			_Lng = Lng;
			_Ubicacion = Ubicacion;
			_Precio = Precio;
			_PrecioOferta = PrecioOferta;
			_Mascotas = Mascotas;
			_PersonasCapacidadRed = PersonasCapacidadRed;
			_DietasEspeciales = DietasEspeciales;
			_Idiomas = Idiomas;
			_Dificultad = Dificultad;
			_QueIncluye = QueIncluye;
			_QueNoIncluye = QueNoIncluye;
			_Duracion = Duracion;
			_IdCategoria = IdCategoria;
			_IdPrestador = IdPrestador;
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
protected System.Int32 _IdActividad;
/// <summary>
/// 
/// </summary>
protected System.String _Nombre;
/// <summary>
/// 
/// </summary>
protected System.String _DescripcionCorta;
/// <summary>
/// 
/// </summary>
protected System.String _Descripcion;
/// <summary>
/// 
/// </summary>
protected System.String _Fotos;
/// <summary>
/// 
/// </summary>
protected System.String _Video;
/// <summary>
///
/// </summary>
protected System.Nullable<System.Int64> _Lat;
/// <summary>
///
/// </summary>
protected System.Nullable<System.Int64> _Lng;
/// <summary>
/// 
/// </summary>
protected System.String _Ubicacion;
/// <summary>
/// 
/// </summary>
protected System.Decimal _Precio;
/// <summary>
///
/// </summary>
protected System.Nullable<System.Decimal> _PrecioOferta;
/// <summary>
///
/// </summary>
protected System.Nullable<System.Boolean> _Mascotas;
/// <summary>
///
/// </summary>
protected System.Nullable<System.Boolean> _PersonasCapacidadRed;
/// <summary>
///
/// </summary>
protected System.Nullable<System.Boolean> _DietasEspeciales;
/// <summary>
/// 
/// </summary>
protected System.String _Idiomas;
/// <summary>
/// 
/// </summary>
protected System.String _Dificultad;
/// <summary>
/// 
/// </summary>
protected System.String _QueIncluye;
/// <summary>
/// 
/// </summary>
protected System.String _QueNoIncluye;
/// <summary>
/// 
/// </summary>
protected System.Int32 _Duracion;
/// <summary>
/// 
/// </summary>
protected System.Int32 _IdCategoria;
/// <summary>
/// 
/// </summary>
protected System.Int32 _IdPrestador;
/// <summary>
/// 
/// </summary>
protected System.Boolean _Activa;

        #endregion

        #region "Properties"
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdActividad
        {
            get
            {
                return _IdActividad;
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
        public virtual System.String DescripcionCorta
        {
            get
            {
                return _DescripcionCorta;
            }
            
            set
            {
                base.PropertyModified();
                _DescripcionCorta = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Descripcion
        {
            get
            {
                return _Descripcion;
            }
            
            set
            {
                base.PropertyModified();
                _Descripcion = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Fotos
        {
            get
            {
                return _Fotos;
            }
            
            set
            {
                base.PropertyModified();
                _Fotos = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Video
        {
            get
            {
                return _Video;
            }
            
            set
            {
                base.PropertyModified();
                _Video = value;
                
            }
            
        }
        
        /// <summary>
        /// Nullable property
        /// </summary>
        public virtual System.Nullable<System.Int64> Lat
        {
            get
            {
                return _Lat;
            }
            
            set
            {
                base.PropertyModified();
                _Lat = value;                
                
            }
            
        }
                
        /// <summary>
        /// Nullable property
        /// </summary>
        public virtual System.Nullable<System.Int64> Lng
        {
            get
            {
                return _Lng;
            }
            
            set
            {
                base.PropertyModified();
                _Lng = value;                
                
            }
            
        }
                
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Ubicacion
        {
            get
            {
                return _Ubicacion;
            }
            
            set
            {
                base.PropertyModified();
                _Ubicacion = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Decimal Precio
        {
            get
            {
                return _Precio;
            }
            
            set
            {
                base.PropertyModified();
                _Precio = value;
                
            }
            
        }
        
        /// <summary>
        /// Nullable property
        /// </summary>
        public virtual System.Nullable<System.Decimal> PrecioOferta
        {
            get
            {
                return _PrecioOferta;
            }
            
            set
            {
                base.PropertyModified();
                _PrecioOferta = value;                
                
            }
            
        }
                
        /// <summary>
        /// Nullable property
        /// </summary>
        public virtual System.Nullable<System.Boolean> Mascotas
        {
            get
            {
                return _Mascotas;
            }
            
            set
            {
                base.PropertyModified();
                _Mascotas = value;                
                
            }
            
        }
                
        /// <summary>
        /// Nullable property
        /// </summary>
        public virtual System.Nullable<System.Boolean> PersonasCapacidadRed
        {
            get
            {
                return _PersonasCapacidadRed;
            }
            
            set
            {
                base.PropertyModified();
                _PersonasCapacidadRed = value;                
                
            }
            
        }
                
        /// <summary>
        /// Nullable property
        /// </summary>
        public virtual System.Nullable<System.Boolean> DietasEspeciales
        {
            get
            {
                return _DietasEspeciales;
            }
            
            set
            {
                base.PropertyModified();
                _DietasEspeciales = value;                
                
            }
            
        }
                
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Idiomas
        {
            get
            {
                return _Idiomas;
            }
            
            set
            {
                base.PropertyModified();
                _Idiomas = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String Dificultad
        {
            get
            {
                return _Dificultad;
            }
            
            set
            {
                base.PropertyModified();
                _Dificultad = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String QueIncluye
        {
            get
            {
                return _QueIncluye;
            }
            
            set
            {
                base.PropertyModified();
                _QueIncluye = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.String QueNoIncluye
        {
            get
            {
                return _QueNoIncluye;
            }
            
            set
            {
                base.PropertyModified();
                _QueNoIncluye = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 Duracion
        {
            get
            {
                return _Duracion;
            }
            
            set
            {
                base.PropertyModified();
                _Duracion = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdCategoria
        {
            get
            {
                return _IdCategoria;
            }
            
            set
            {
                base.PropertyModified();
                _IdCategoria = value;
                
            }
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public virtual System.Int32 IdPrestador
        {
            get
            {
                return _IdPrestador;
            }
            
            set
            {
                base.PropertyModified();
                _IdPrestador = value;
                
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
            ActividadesObject newObject;
            ActividadesObject newOriginalValue;

            newObject = (ActividadesObject) this.MemberwiseClone();
            if (base._OriginalValue != null)
            {
                newOriginalValue = (ActividadesObject)this.OriginalValue().MemberwiseClone();
                newObject._OriginalValue = newOriginalValue;
            }
            return newObject;
        }


        /// <summary>
        /// Returns de original value of object since was created or restored.
        /// </summary>
        public new ActividadesObject OriginalValue()
        {
            return (ActividadesObject)base.OriginalValue();
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableActividadesObject.HydrateFields(
			System.Int32 IdActividad,
			System.String Nombre,
			System.String DescripcionCorta,
			System.String Descripcion,
			System.String Fotos,
			System.String Video,
			System.Nullable<System.Int64> Lat,
			System.Nullable<System.Int64> Lng,
			System.String Ubicacion,
			System.Decimal Precio,
			System.Nullable<System.Decimal> PrecioOferta,
			System.Nullable<System.Boolean> Mascotas,
			System.Nullable<System.Boolean> PersonasCapacidadRed,
			System.Nullable<System.Boolean> DietasEspeciales,
			System.String Idiomas,
			System.String Dificultad,
			System.String QueIncluye,
			System.String QueNoIncluye,
			System.Int32 Duracion,
			System.Int32 IdCategoria,
			System.Int32 IdPrestador,
			System.Boolean Activa)
        {
        _IdActividad = IdActividad;
_Nombre = Nombre;
_DescripcionCorta = DescripcionCorta;
_Descripcion = Descripcion;
_Fotos = Fotos;
_Video = Video;
_Lat = Lat;
_Lng = Lng;
_Ubicacion = Ubicacion;
_Precio = Precio;
_PrecioOferta = PrecioOferta;
_Mascotas = Mascotas;
_PersonasCapacidadRed = PersonasCapacidadRed;
_DietasEspeciales = DietasEspeciales;
_Idiomas = Idiomas;
_Dificultad = Dificultad;
_QueIncluye = QueIncluye;
_QueNoIncluye = QueNoIncluye;
_Duracion = Duracion;
_IdCategoria = IdCategoria;
_IdPrestador = IdPrestador;
_Activa = Activa;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableActividadesObject.GetFieldsForInsert()
        {
            object[] _myArray = new object[22];
            _myArray[0] = _IdActividad;
_myArray[1] = _Nombre;
_myArray[2] = _DescripcionCorta;
_myArray[3] = _Descripcion;
if (!System.String.IsNullOrEmpty(_Fotos)) _myArray[4] = _Fotos;
if (!System.String.IsNullOrEmpty(_Video)) _myArray[5] = _Video;
if (_Lat.HasValue) _myArray[6] = _Lat.Value;
if (_Lng.HasValue) _myArray[7] = _Lng.Value;
if (!System.String.IsNullOrEmpty(_Ubicacion)) _myArray[8] = _Ubicacion;
_myArray[9] = _Precio;
if (_PrecioOferta.HasValue) _myArray[10] = _PrecioOferta.Value;
if (_Mascotas.HasValue) _myArray[11] = _Mascotas.Value;
if (_PersonasCapacidadRed.HasValue) _myArray[12] = _PersonasCapacidadRed.Value;
if (_DietasEspeciales.HasValue) _myArray[13] = _DietasEspeciales.Value;
if (!System.String.IsNullOrEmpty(_Idiomas)) _myArray[14] = _Idiomas;
if (!System.String.IsNullOrEmpty(_Dificultad)) _myArray[15] = _Dificultad;
if (!System.String.IsNullOrEmpty(_QueIncluye)) _myArray[16] = _QueIncluye;
if (!System.String.IsNullOrEmpty(_QueNoIncluye)) _myArray[17] = _QueNoIncluye;
_myArray[18] = _Duracion;
_myArray[19] = _IdCategoria;
_myArray[20] = _IdPrestador;
_myArray[21] = _Activa;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableActividadesObject.GetFieldsForUpdate()
        {
            
            object[] _myArray = new object[22];
            _myArray[0] = _IdActividad;
_myArray[1] = _Nombre;
_myArray[2] = _DescripcionCorta;
_myArray[3] = _Descripcion;
if (!System.String.IsNullOrEmpty(_Fotos)) _myArray[4] = _Fotos;
if (!System.String.IsNullOrEmpty(_Video)) _myArray[5] = _Video;
if (_Lat.HasValue) _myArray[6] = _Lat.Value;
if (_Lng.HasValue) _myArray[7] = _Lng.Value;
if (!System.String.IsNullOrEmpty(_Ubicacion)) _myArray[8] = _Ubicacion;
_myArray[9] = _Precio;
if (_PrecioOferta.HasValue) _myArray[10] = _PrecioOferta.Value;
if (_Mascotas.HasValue) _myArray[11] = _Mascotas.Value;
if (_PersonasCapacidadRed.HasValue) _myArray[12] = _PersonasCapacidadRed.Value;
if (_DietasEspeciales.HasValue) _myArray[13] = _DietasEspeciales.Value;
if (!System.String.IsNullOrEmpty(_Idiomas)) _myArray[14] = _Idiomas;
if (!System.String.IsNullOrEmpty(_Dificultad)) _myArray[15] = _Dificultad;
if (!System.String.IsNullOrEmpty(_QueIncluye)) _myArray[16] = _QueIncluye;
if (!System.String.IsNullOrEmpty(_QueNoIncluye)) _myArray[17] = _QueNoIncluye;
_myArray[18] = _Duracion;
_myArray[19] = _IdCategoria;
_myArray[20] = _IdPrestador;
_myArray[21] = _Activa;

            return _myArray;
        }

        /// <summary>
        /// 
        /// </summary>
        object[] IMappeableActividadesObject.GetFieldsForDelete()
        {
            
            object[] _myArray = new object[1];
            _myArray[0] = _IdActividad;

            return _myArray;
        }


        /// <summary>
        /// 
        /// </summary>
        void IMappeableActividadesObject.UpdateObjectFromOutputParams(object[] parameters){
            // Update properties from Output parameters
            _IdActividad = (System.Int32) parameters[0];

        }


        /// <summary>
        /// 
        /// </summary>
        object[] IUniqueIdentifiable.Identifier()
        {
            ActividadesObject o = null;
            if (ObjectStateHelper.IsModified(this))
                o = this.OriginalValue();
            else
                o = this;

            return new object[]
            {o.IdActividad};
        }


        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ActividadesObject other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableActividadesObject
    {
        /// <summary>
        /// 
        /// </summary>
        void HydrateFields(System.Int32 IdActividad, 
			System.String Nombre, 
			System.String DescripcionCorta, 
			System.String Descripcion, 
			System.String Fotos, 
			System.String Video, 
			System.Nullable<System.Int64> Lat, 
			System.Nullable<System.Int64> Lng, 
			System.String Ubicacion, 
			System.Decimal Precio, 
			System.Nullable<System.Decimal> PrecioOferta, 
			System.Nullable<System.Boolean> Mascotas, 
			System.Nullable<System.Boolean> PersonasCapacidadRed, 
			System.Nullable<System.Boolean> DietasEspeciales, 
			System.String Idiomas, 
			System.String Dificultad, 
			System.String QueIncluye, 
			System.String QueNoIncluye, 
			System.Int32 Duracion, 
			System.Int32 IdCategoria, 
			System.Int32 IdPrestador, 
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
    public partial class ActividadesObjectList : ObjectList<ActividadesObject>
    {
    }
}

namespace monaguaRules.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ActividadesObjectListView
        : ObjectListView<Objects.ActividadesObject>
    {
        /// <summary>
        /// 
        /// </summary>
        public ActividadesObjectListView(Objects.ActividadesObjectList list): base(list)
        {
        }
    }
}


