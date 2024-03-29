
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 29/08/2022 - 17:38
// This is a partial class file. The other one is SlidesEntity.Auto.cs
// You can edit this file as your wish.
//------------------------------------------------------------------------------

using System;
using Cooperator.Framework.Core.Exceptions;

namespace monaguaRules.Entities
{
    /// <summary>
    /// This class represents the Slides entity.
    /// </summary>
    [Serializable]
    public partial class Slides
        // : IValidable
    {
        // /// <summary>
        // /// When IValidable is implemented, this method is invoked by Gateway before Insert or Update to validate Object.
        // /// </summary>
        // public void Validate()
        // {
        //     //Example:
        //     if (string.IsNullOrEmpty(this.Name)) throw new RuleValidationException("Name can't be null");
        // }
    }

    /// <summary>
    /// This class represents a collection of Slides entity.
    /// </summary>
    public partial class SlidesList
    {
         // /// <summary>
         // /// Returns a typed Dataset based on its content.
         // /// </summary>
         //public override System.Data.DataSet ToDataSet()
         //{
         //    YOUR_TYPED_DATASET MyDataSet = new YOUR_TYPED_DATASET();
         //    ObjectListHelper<Slides, SlidesList> Exporter = new ObjectListHelper<Slides, SlidesList>();
         //    Exporter.FillDataSet(MyDataSet, this);
         //    return MyDataSet;
         //}
    }
}

namespace monaguaRules.Views
{
    /// <summary>
    /// This class represents a view of an collection of Slides entities.
    /// </summary>
    public partial class SlidesListView
    {
    }
}


