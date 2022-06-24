
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 22/6/2022 - 05:03 p. m.
// This is a partial class file. The other one is ActividadesHorariosExcepcionGateway.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using System;
using monaguaRules.Objects;
using Cooperator.Framework.Data;
using Cooperator.Framework.Data.Exceptions;
using Cooperator.Framework.Core;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Web;




namespace monaguaRules.Gateways
{

    public partial class ActividadesHorariosExcepcionGateway : BaseGateway<ActividadesHorariosExcepcionObject, ActividadesHorariosExcepcionObjectList>, IGenericGateway
    {

        #region "Singleton"

        static ActividadesHorariosExcepcionGateway _instance;

        private ActividadesHorariosExcepcionGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static ActividadesHorariosExcepcionGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ActividadesHorariosExcepcionGateway();
                else {
                    ActividadesHorariosExcepcionGateway inst = HttpContext.Current.Items["monaguaRules.ActividadesHorariosExcepcionGatewaySingleton"] as ActividadesHorariosExcepcionGateway;
                    if (inst == null) {
                        inst = new ActividadesHorariosExcepcionGateway();
                        HttpContext.Current.Items.Add("monaguaRules.ActividadesHorariosExcepcionGatewaySingleton", inst);
                    }
                    return inst;
                }
            }
            return _instance;
        }

        #endregion

        /// <summary>
        /// Return the mapped table name
        /// </summary>
        protected override string TableName
        {
            get { return "ActividadesHorariosExcepcion"; }
        }

        protected override string RuleName
        {
            get {return typeof(ActividadesHorariosExcepcionGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ActividadesHorariosExcepcionObject entity)
        {
            
            IMappeableActividadesHorariosExcepcionObject ActividadesHorariosExcepcion = (IMappeableActividadesHorariosExcepcionObject)entity;
            ActividadesHorariosExcepcion.HydrateFields(
            reader.GetInt32(0),
reader.GetInt32(1),
(reader.IsDBNull(2)) ? new System.Nullable<System.DateTime>() : reader.GetDateTime(2),
(reader.IsDBNull(3)) ? new System.Nullable<System.DateTime>() : reader.GetDateTime(3),
(reader.IsDBNull(4)) ? new System.Nullable<System.Int32>() : reader.GetInt32(4),
reader.GetBoolean(5),
(reader.IsDBNull(6)) ? new System.Nullable<System.DateTime>() : reader.GetDateTime(6));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(ActividadesHorariosExcepcionObject entity)
        {

            IMappeableActividadesHorariosExcepcionObject ActividadesHorariosExcepcion = (IMappeableActividadesHorariosExcepcionObject)entity;
            return ActividadesHorariosExcepcion.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(ActividadesHorariosExcepcionObject entity)
        {

            IMappeableActividadesHorariosExcepcionObject ActividadesHorariosExcepcion = (IMappeableActividadesHorariosExcepcionObject)entity;
            return ActividadesHorariosExcepcion.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(ActividadesHorariosExcepcionObject entity)
        {

            IMappeableActividadesHorariosExcepcionObject ActividadesHorariosExcepcion = (IMappeableActividadesHorariosExcepcionObject)entity;
            return ActividadesHorariosExcepcion.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ActividadesHorariosExcepcionObject row, object[] parameters)
        {
            ((IMappeableActividadesHorariosExcepcionObject) row).UpdateObjectFromOutputParams(parameters);
            ((IObject)row).State = ObjectState.Restored;
        }

        /// <summary>
        /// StoredProceduresPrefix, for example: coop_
        /// </summary>
        protected override string StoredProceduresPrefix()
        {
            return "coop_";
        }


        /// <summary>
        /// Get a ActividadesHorariosExcepcionObject by execute a SQL Query Text
        /// </summary>
        public ActividadesHorariosExcepcionObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ActividadesHorariosExcepcionObjectList by execute a SQL Query Text
        /// </summary>
        public ActividadesHorariosExcepcionObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a ActividadesHorariosExcepcionObject by calling a Stored Procedure
        /// </summary>
        public ActividadesHorariosExcepcionObject GetOne(System.Int32 IdActividadHorarioExcepcion)
        {
            return base.GetOne(new ActividadesHorariosExcepcionObject(IdActividadHorarioExcepcion));
        }


        // GetBy Objects and Params
            


        

        /// <summary>
        /// Get a ActividadesHorariosExcepcionObjectList by calling a Stored Procedure
        /// </summary>
        public ActividadesHorariosExcepcionObjectList GetByActividadesHorarios(DbTransaction transaction,System.Int32 IdHorario)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ActividadesHorariosExcepcion_GetByActividadesHorarios", IdHorario);
        }

        /// <summary>
        /// Get a ActividadesHorariosExcepcionObjectList by calling a Stored Procedure
        /// </summary>
        public ActividadesHorariosExcepcionObjectList GetByActividadesHorarios(DbTransaction transaction, IUniqueIdentifiable ActividadesHorarios)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ActividadesHorariosExcepcion_GetByActividadesHorarios", ActividadesHorarios.Identifier());
        }

    

        

        /// <summary>
        /// Get a ActividadesHorariosExcepcionObjectList by calling a Stored Procedure
        /// </summary>
        public ActividadesHorariosExcepcionObjectList GetByActividadesHorarios(System.Int32 IdHorario)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ActividadesHorariosExcepcion_GetByActividadesHorarios", IdHorario);
        }

        /// <summary>
        /// Get a ActividadesHorariosExcepcionObjectList by calling a Stored Procedure
        /// </summary>
        public ActividadesHorariosExcepcionObjectList GetByActividadesHorarios(IUniqueIdentifiable ActividadesHorarios)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ActividadesHorariosExcepcion_GetByActividadesHorarios", ActividadesHorarios.Identifier());
        }

    

        /// <summary>
        /// Delete ActividadesHorariosExcepcion
        /// </summary>
        public void Delete(System.Int32 IdActividadHorarioExcepcion)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ActividadesHorariosExcepcion_Delete", IdActividadHorarioExcepcion);
        }

        /// <summary>
        /// Delete ActividadesHorariosExcepcion
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdActividadHorarioExcepcion)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ActividadesHorariosExcepcion_Delete", IdActividadHorarioExcepcion);
        }

            

        

        /// <summary>
        /// Delete ActividadesHorariosExcepcion by ActividadesHorarios
        /// </summary>
        public void DeleteByActividadesHorarios(System.Int32 IdHorario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ActividadesHorariosExcepcion_DeleteByActividadesHorarios", IdHorario);
        }

        /// <summary>
        /// Delete ActividadesHorariosExcepcion by ActividadesHorarios
        /// </summary>
        public void DeleteByActividadesHorarios(DbTransaction transaction, System.Int32 IdHorario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ActividadesHorariosExcepcion_DeleteByActividadesHorarios", IdHorario);
        }

        /// <summary>
        /// Delete ActividadesHorariosExcepcion by ActividadesHorarios
        /// </summary>
        public void DeleteByActividadesHorarios(IUniqueIdentifiable ActividadesHorarios)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ActividadesHorariosExcepcion_DeleteByActividadesHorarios", ActividadesHorarios.Identifier());
        }

        /// <summary>
        /// Delete ActividadesHorariosExcepcion by ActividadesHorarios
        /// </summary>
        public void DeleteByActividadesHorarios(DbTransaction transaction, IUniqueIdentifiable ActividadesHorarios)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ActividadesHorariosExcepcion_DeleteByActividadesHorarios", ActividadesHorarios.Identifier());
        }


    


        //Database Queries 
        



        #region IGenericGateway

        object IGenericGateway.GetOne(IUniqueIdentifiable identifier)
        {
            return base.GetOne(identifier);
        }

        object IGenericGateway.GetAll()
        {
            return base.GetAll();
        }

        object IGenericGateway.GetByParent(IUniqueIdentifiable parentEntity)
        {
            return base.GetByParent(parentEntity);
        }

        #endregion


    }

}







