
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 18/5/2022 - 06:05 p. m.
// This is a partial class file. The other one is MensajesEntity.Auto.cs
// You can edit this file as your wish.
//------------------------------------------------------------------------------

using System;
using Cooperator.Framework.Core.Exceptions;

namespace monaguaRules.Entities
{
    /// <summary>
    /// This class represents the Mensajes entity.
    /// </summary>
    [Serializable]
    public partial class Mensajes
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
    /// This class represents a collection of Mensajes entity.
    /// </summary>
    public partial class MensajesList
    {
         // /// <summary>
         // /// Returns a typed Dataset based on its content.
         // /// </summary>
         //public override System.Data.DataSet ToDataSet()
         //{
         //    YOUR_TYPED_DATASET MyDataSet = new YOUR_TYPED_DATASET();
         //    ObjectListHelper<Mensajes, MensajesList> Exporter = new ObjectListHelper<Mensajes, MensajesList>();
         //    Exporter.FillDataSet(MyDataSet, this);
         //    return MyDataSet;
         //}
    }
}

namespace monaguaRules.Views
{
    /// <summary>
    /// This class represents a view of an collection of Mensajes entities.
    /// </summary>
    public partial class MensajesListView
    {
    }
}


