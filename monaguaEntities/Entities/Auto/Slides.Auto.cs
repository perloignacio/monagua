
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 08/09/2022 - 16:50
// This is a partial class file. The other one is SlidesEntity.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using monaguaRules.Objects;



using Cooperator.Framework.Core;
using Cooperator.Framework.Core.LazyLoad;
using System;

namespace monaguaRules.Entities
{

    /// <summary>
    /// 
    /// </summary>
    public partial class Slides : Objects.SlidesObject, IMappeableSlides, IEquatable<Slides>, ICloneable
    {

        #region "Ctor"

        /// <summary>
        /// 
        /// </summary>
        public Slides()
            :base()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        public Slides(
			System.Int32 IdSlide)
            : base()
        {

			_IdSlide = IdSlide;

            
            Initialized();
        }

        

        /// <summary>
        /// 
        /// </summary>
        public Slides(
			System.Int32 IdSlide,
			System.String Titulo,
			System.String Descripcion,
			System.String Foto,
			System.String Link,
			System.Int32 Orden,
			System.Boolean Activo)
            : base()
        {

			_IdSlide = IdSlide;
			_Titulo = Titulo;
			_Descripcion = Descripcion;
			_Foto = Foto;
			_Link = Link;
			_Orden = Orden;
			_Activo = Activo;

            
            Initialized();
        }
        
        #endregion

        #region "Fields"

        
        #endregion

        #region "Properties"
        
        #endregion

        /// <summary>
        /// Returns de original value of entity since was created or restored.
        /// </summary>
        public new Slides OriginalValue()
        {
            return (Slides)base.OriginalValue();
        }

        /// <summary>
        /// 
        /// </summary>
        object ICloneable.Clone()
        {
            Slides newObject;            
            

            newObject = (Slides)this.MemberwiseClone();
            // Entities
            
            // Colections
            
            // OriginalValue
            Slides newOriginalValue;
            if (base._OriginalValue != null)
            {
                newOriginalValue = (Slides)this.OriginalValue().MemberwiseClone();
                // Entities
                
                // Colections
                            
                newObject._OriginalValue = newOriginalValue;

            }
            return newObject;            
        }



        /// <summary>
        /// 
        /// </summary>
        void IMappeableSlides.CompleteEntity()
        {
        
        }
        

        /// <summary>
        /// 
        /// </summary>
        void IMappeableSlides.SetFKValuesForChilds(Slides entity)
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Slides other)
        {
            return UniqueIdentifierHelper.IsSameObject((IUniqueIdentifiable)this, (IUniqueIdentifiable)other);
        } 

    }

    /// <summary>
    /// 
    /// </summary>
    public interface IMappeableSlides
    {
        /// <summary>
        /// 
        /// </summary>
        void CompleteEntity();
        
        /// <summary>
        /// 
        /// </summary>
        void SetFKValuesForChilds(Slides entity);
    }

        /// <summary>
        /// 
        /// </summary>
    public partial class SlidesList : ObjectList<Slides>
    {
    }
}
namespace monaguaRules.Views
{
        /// <summary>
        /// 
        /// </summary>
    public partial class SlidesListView
        : ObjectListView<Entities.Slides>
    {
        /// <summary>
        /// 
        /// </summary>
        public SlidesListView(Entities.SlidesList list): base(list)
        {
        }
    }
}


