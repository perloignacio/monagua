
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 31/08/2022 - 14:49
// This is a partial class file. The other one is PreguntasFrecuentesEntity.Auto.cs
// You can edit this file as your wish.
//------------------------------------------------------------------------------

using System;
using Cooperator.Framework.Core.Exceptions;

namespace monaguaRules.Entities
{
    /// <summary>
    /// This class represents the PreguntasFrecuentes entity.
    /// </summary>
    [Serializable]
    public partial class PreguntasFrecuentes
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
    /// This class represents a collection of PreguntasFrecuentes entity.
    /// </summary>
    public partial class PreguntasFrecuentesList
    {
         // /// <summary>
         // /// Returns a typed Dataset based on its content.
         // /// </summary>
         //public override System.Data.DataSet ToDataSet()
         //{
         //    YOUR_TYPED_DATASET MyDataSet = new YOUR_TYPED_DATASET();
         //    ObjectListHelper<PreguntasFrecuentes, PreguntasFrecuentesList> Exporter = new ObjectListHelper<PreguntasFrecuentes, PreguntasFrecuentesList>();
         //    Exporter.FillDataSet(MyDataSet, this);
         //    return MyDataSet;
         //}
    }
}

namespace monaguaRules.Views
{
    /// <summary>
    /// This class represents a view of an collection of PreguntasFrecuentes entities.
    /// </summary>
    public partial class PreguntasFrecuentesListView
    {
    }
}


