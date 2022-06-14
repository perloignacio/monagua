
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 10/6/2022 - 05:08 p. m.
// This is a partial class file. The other one is ActividadesHorariosGateway.cs
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

    public partial class ActividadesHorariosGateway : BaseGateway<ActividadesHorariosObject, ActividadesHorariosObjectList>, IGenericGateway
    {

        #region "Singleton"

        static ActividadesHorariosGateway _instance;

        private ActividadesHorariosGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static ActividadesHorariosGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ActividadesHorariosGateway();
                else {
                    ActividadesHorariosGateway inst = HttpContext.Current.Items["monaguaRules.ActividadesHorariosGatewaySingleton"] as ActividadesHorariosGateway;
                    if (inst == null) {
                        inst = new ActividadesHorariosGateway();
                        HttpContext.Current.Items.Add("monaguaRules.ActividadesHorariosGatewaySingleton", inst);
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
            get { return "ActividadesHorarios"; }
        }

        protected override string RuleName
        {
            get {return typeof(ActividadesHorariosGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ActividadesHorariosObject entity)
        {
            
            IMappeableActividadesHorariosObject ActividadesHorarios = (IMappeableActividadesHorariosObject)entity;
            ActividadesHorarios.HydrateFields(
            reader.GetInt32(0),
reader.GetInt32(1),
reader.GetInt32(2),
reader.GetDateTime(3),
reader.GetDateTime(4),
reader.GetBoolean(5),
(reader.IsDBNull(6)) ? new System.Nullable<System.Int32>() : reader.GetInt32(6));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(ActividadesHorariosObject entity)
        {

            IMappeableActividadesHorariosObject ActividadesHorarios = (IMappeableActividadesHorariosObject)entity;
            return ActividadesHorarios.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(ActividadesHorariosObject entity)
        {

            IMappeableActividadesHorariosObject ActividadesHorarios = (IMappeableActividadesHorariosObject)entity;
            return ActividadesHorarios.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(ActividadesHorariosObject entity)
        {

            IMappeableActividadesHorariosObject ActividadesHorarios = (IMappeableActividadesHorariosObject)entity;
            return ActividadesHorarios.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ActividadesHorariosObject row, object[] parameters)
        {
            ((IMappeableActividadesHorariosObject) row).UpdateObjectFromOutputParams(parameters);
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
        /// Get a ActividadesHorariosObject by execute a SQL Query Text
        /// </summary>
        public ActividadesHorariosObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ActividadesHorariosObjectList by execute a SQL Query Text
        /// </summary>
        public ActividadesHorariosObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a ActividadesHorariosObject by calling a Stored Procedure
        /// </summary>
        public ActividadesHorariosObject GetOne(System.Int32 IdHorario)
        {
            return base.GetOne(new ActividadesHorariosObject(IdHorario));
        }


        // GetBy Objects and Params
            


        

        /// <summary>
        /// Get a ActividadesHorariosObjectList by calling a Stored Procedure
        /// </summary>
        public ActividadesHorariosObjectList GetByActividades(DbTransaction transaction,System.Int32 IdActividad)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ActividadesHorarios_GetByActividades", IdActividad);
        }

        /// <summary>
        /// Get a ActividadesHorariosObjectList by calling a Stored Procedure
        /// </summary>
        public ActividadesHorariosObjectList GetByActividades(DbTransaction transaction, IUniqueIdentifiable Actividades)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ActividadesHorarios_GetByActividades", Actividades.Identifier());
        }

    

        

        /// <summary>
        /// Get a ActividadesHorariosObjectList by calling a Stored Procedure
        /// </summary>
        public ActividadesHorariosObjectList GetByActividades(System.Int32 IdActividad)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ActividadesHorarios_GetByActividades", IdActividad);
        }

        /// <summary>
        /// Get a ActividadesHorariosObjectList by calling a Stored Procedure
        /// </summary>
        public ActividadesHorariosObjectList GetByActividades(IUniqueIdentifiable Actividades)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ActividadesHorarios_GetByActividades", Actividades.Identifier());
        }

    

        /// <summary>
        /// Delete ActividadesHorarios
        /// </summary>
        public void Delete(System.Int32 IdHorario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ActividadesHorarios_Delete", IdHorario);
        }

        /// <summary>
        /// Delete ActividadesHorarios
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdHorario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ActividadesHorarios_Delete", IdHorario);
        }

            

        

        /// <summary>
        /// Delete ActividadesHorarios by Actividades
        /// </summary>
        public void DeleteByActividades(System.Int32 IdActividad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ActividadesHorarios_DeleteByActividades", IdActividad);
        }

        /// <summary>
        /// Delete ActividadesHorarios by Actividades
        /// </summary>
        public void DeleteByActividades(DbTransaction transaction, System.Int32 IdActividad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ActividadesHorarios_DeleteByActividades", IdActividad);
        }

        /// <summary>
        /// Delete ActividadesHorarios by Actividades
        /// </summary>
        public void DeleteByActividades(IUniqueIdentifiable Actividades)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ActividadesHorarios_DeleteByActividades", Actividades.Identifier());
        }

        /// <summary>
        /// Delete ActividadesHorarios by Actividades
        /// </summary>
        public void DeleteByActividades(DbTransaction transaction, IUniqueIdentifiable Actividades)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ActividadesHorarios_DeleteByActividades", Actividades.Identifier());
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








