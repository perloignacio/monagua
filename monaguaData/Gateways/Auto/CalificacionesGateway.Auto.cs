
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 22/11/2022 - 11:25
// This is a partial class file. The other one is CalificacionesGateway.cs
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

    public partial class CalificacionesGateway : BaseGateway<CalificacionesObject, CalificacionesObjectList>, IGenericGateway
    {

        #region "Singleton"

        static CalificacionesGateway _instance;

        private CalificacionesGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static CalificacionesGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new CalificacionesGateway();
                else {
                    CalificacionesGateway inst = HttpContext.Current.Items["monaguaRules.CalificacionesGatewaySingleton"] as CalificacionesGateway;
                    if (inst == null) {
                        inst = new CalificacionesGateway();
                        HttpContext.Current.Items.Add("monaguaRules.CalificacionesGatewaySingleton", inst);
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
            get { return "Calificaciones"; }
        }

        protected override string RuleName
        {
            get {return typeof(CalificacionesGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, CalificacionesObject entity)
        {
            
            IMappeableCalificacionesObject Calificaciones = (IMappeableCalificacionesObject)entity;
            Calificaciones.HydrateFields(
            reader.GetInt32(0),
reader.GetDateTime(1),
reader.GetInt32(2),
reader.GetInt32(3),
reader.GetString(4),
(reader.IsDBNull(5)) ? "" : reader.GetString(5),
(reader.IsDBNull(6)) ? new System.Nullable<System.DateTime>() : reader.GetDateTime(6));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(CalificacionesObject entity)
        {

            IMappeableCalificacionesObject Calificaciones = (IMappeableCalificacionesObject)entity;
            return Calificaciones.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(CalificacionesObject entity)
        {

            IMappeableCalificacionesObject Calificaciones = (IMappeableCalificacionesObject)entity;
            return Calificaciones.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(CalificacionesObject entity)
        {

            IMappeableCalificacionesObject Calificaciones = (IMappeableCalificacionesObject)entity;
            return Calificaciones.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(CalificacionesObject row, object[] parameters)
        {
            ((IMappeableCalificacionesObject) row).UpdateObjectFromOutputParams(parameters);
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
        /// Get a CalificacionesObject by execute a SQL Query Text
        /// </summary>
        public CalificacionesObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a CalificacionesObjectList by execute a SQL Query Text
        /// </summary>
        public CalificacionesObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a CalificacionesObject by calling a Stored Procedure
        /// </summary>
        public CalificacionesObject GetOne(System.Int32 IdCalificacion)
        {
            return base.GetOne(new CalificacionesObject(IdCalificacion));
        }


        // GetBy Objects and Params
            


        

        /// <summary>
        /// Get a CalificacionesObjectList by calling a Stored Procedure
        /// </summary>
        public CalificacionesObjectList GetByComprasDetalle(DbTransaction transaction,System.Int32 IdCompraDetalle)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Calificaciones_GetByComprasDetalle", IdCompraDetalle);
        }

        /// <summary>
        /// Get a CalificacionesObjectList by calling a Stored Procedure
        /// </summary>
        public CalificacionesObjectList GetByComprasDetalle(DbTransaction transaction, IUniqueIdentifiable ComprasDetalle)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Calificaciones_GetByComprasDetalle", ComprasDetalle.Identifier());
        }

    

        

        /// <summary>
        /// Get a CalificacionesObjectList by calling a Stored Procedure
        /// </summary>
        public CalificacionesObjectList GetByComprasDetalle(System.Int32 IdCompraDetalle)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Calificaciones_GetByComprasDetalle", IdCompraDetalle);
        }

        /// <summary>
        /// Get a CalificacionesObjectList by calling a Stored Procedure
        /// </summary>
        public CalificacionesObjectList GetByComprasDetalle(IUniqueIdentifiable ComprasDetalle)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Calificaciones_GetByComprasDetalle", ComprasDetalle.Identifier());
        }

    

        /// <summary>
        /// Delete Calificaciones
        /// </summary>
        public void Delete(System.Int32 IdCalificacion)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Calificaciones_Delete", IdCalificacion);
        }

        /// <summary>
        /// Delete Calificaciones
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdCalificacion)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Calificaciones_Delete", IdCalificacion);
        }

            

        

        /// <summary>
        /// Delete Calificaciones by ComprasDetalle
        /// </summary>
        public void DeleteByComprasDetalle(System.Int32 IdCompraDetalle)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Calificaciones_DeleteByComprasDetalle", IdCompraDetalle);
        }

        /// <summary>
        /// Delete Calificaciones by ComprasDetalle
        /// </summary>
        public void DeleteByComprasDetalle(DbTransaction transaction, System.Int32 IdCompraDetalle)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Calificaciones_DeleteByComprasDetalle", IdCompraDetalle);
        }

        /// <summary>
        /// Delete Calificaciones by ComprasDetalle
        /// </summary>
        public void DeleteByComprasDetalle(IUniqueIdentifiable ComprasDetalle)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Calificaciones_DeleteByComprasDetalle", ComprasDetalle.Identifier());
        }

        /// <summary>
        /// Delete Calificaciones by ComprasDetalle
        /// </summary>
        public void DeleteByComprasDetalle(DbTransaction transaction, IUniqueIdentifiable ComprasDetalle)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Calificaciones_DeleteByComprasDetalle", ComprasDetalle.Identifier());
        }


    


        //Database Queries 
        
            

        /// <summary>
        /// 
        /// </summary>
        public CalificacionesObjectList GetCalificacionesByCliente(System.Int32 idcliente) {
            
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Calificaciones_GetCalificacionesByCliente" , idcliente);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public CalificacionesObjectList GetCalificacionesByCliente(DbTransaction transaction , System.Int32 idcliente) {
            
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Calificaciones_GetCalificacionesByCliente" , idcliente);
            
        }


        
            

        /// <summary>
        /// 
        /// </summary>
        public CalificacionesObjectList GetCalificacionesByActividad(System.Int32 idactividad) {
            
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Calificaciones_GetCalificacionesByActividad" , idactividad);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public CalificacionesObjectList GetCalificacionesByActividad(DbTransaction transaction , System.Int32 idactividad) {
            
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Calificaciones_GetCalificacionesByActividad" , idactividad);
            
        }


        



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








