
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 20/5/2022 - 04:29 p. m.
// This is a partial class file. The other one is ComprasDetalleGateway.cs
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

    public partial class ComprasDetalleGateway : BaseGateway<ComprasDetalleObject, ComprasDetalleObjectList>, IGenericGateway
    {

        #region "Singleton"

        static ComprasDetalleGateway _instance;

        private ComprasDetalleGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static ComprasDetalleGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ComprasDetalleGateway();
                else {
                    ComprasDetalleGateway inst = HttpContext.Current.Items["monaguaRules.ComprasDetalleGatewaySingleton"] as ComprasDetalleGateway;
                    if (inst == null) {
                        inst = new ComprasDetalleGateway();
                        HttpContext.Current.Items.Add("monaguaRules.ComprasDetalleGatewaySingleton", inst);
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
            get { return "ComprasDetalle"; }
        }

        protected override string RuleName
        {
            get {return typeof(ComprasDetalleGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ComprasDetalleObject entity)
        {
            
            IMappeableComprasDetalleObject ComprasDetalle = (IMappeableComprasDetalleObject)entity;
            ComprasDetalle.HydrateFields(
            reader.GetInt32(0),
reader.GetInt32(1),
reader.GetInt32(2),
reader.GetInt32(3),
reader.GetInt32(4));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(ComprasDetalleObject entity)
        {

            IMappeableComprasDetalleObject ComprasDetalle = (IMappeableComprasDetalleObject)entity;
            return ComprasDetalle.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(ComprasDetalleObject entity)
        {

            IMappeableComprasDetalleObject ComprasDetalle = (IMappeableComprasDetalleObject)entity;
            return ComprasDetalle.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(ComprasDetalleObject entity)
        {

            IMappeableComprasDetalleObject ComprasDetalle = (IMappeableComprasDetalleObject)entity;
            return ComprasDetalle.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ComprasDetalleObject row, object[] parameters)
        {
            ((IMappeableComprasDetalleObject) row).UpdateObjectFromOutputParams(parameters);
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
        /// Get a ComprasDetalleObject by execute a SQL Query Text
        /// </summary>
        public ComprasDetalleObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ComprasDetalleObjectList by execute a SQL Query Text
        /// </summary>
        public ComprasDetalleObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a ComprasDetalleObject by calling a Stored Procedure
        /// </summary>
        public ComprasDetalleObject GetOne(System.Int32 IdCompraDetalle)
        {
            return base.GetOne(new ComprasDetalleObject(IdCompraDetalle));
        }


        // GetBy Objects and Params
            


        

        /// <summary>
        /// Get a ComprasDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasDetalleObjectList GetByActividades(DbTransaction transaction,System.Int32 IdActividad)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ComprasDetalle_GetByActividades", IdActividad);
        }

        /// <summary>
        /// Get a ComprasDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasDetalleObjectList GetByActividades(DbTransaction transaction, IUniqueIdentifiable Actividades)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ComprasDetalle_GetByActividades", Actividades.Identifier());
        }

    

        /// <summary>
        /// Get a ComprasDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasDetalleObjectList GetByCompras(DbTransaction transaction,System.Int32 IdCompra)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ComprasDetalle_GetByCompras", IdCompra);
        }

        /// <summary>
        /// Get a ComprasDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasDetalleObjectList GetByCompras(DbTransaction transaction, IUniqueIdentifiable Compras)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ComprasDetalle_GetByCompras", Compras.Identifier());
        }

    

        

        /// <summary>
        /// Get a ComprasDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasDetalleObjectList GetByActividades(System.Int32 IdActividad)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ComprasDetalle_GetByActividades", IdActividad);
        }

        /// <summary>
        /// Get a ComprasDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasDetalleObjectList GetByActividades(IUniqueIdentifiable Actividades)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ComprasDetalle_GetByActividades", Actividades.Identifier());
        }

    

        /// <summary>
        /// Get a ComprasDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasDetalleObjectList GetByCompras(System.Int32 IdCompra)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ComprasDetalle_GetByCompras", IdCompra);
        }

        /// <summary>
        /// Get a ComprasDetalleObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasDetalleObjectList GetByCompras(IUniqueIdentifiable Compras)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ComprasDetalle_GetByCompras", Compras.Identifier());
        }

    

        /// <summary>
        /// Delete ComprasDetalle
        /// </summary>
        public void Delete(System.Int32 IdCompraDetalle)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ComprasDetalle_Delete", IdCompraDetalle);
        }

        /// <summary>
        /// Delete ComprasDetalle
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdCompraDetalle)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ComprasDetalle_Delete", IdCompraDetalle);
        }

            

        

        /// <summary>
        /// Delete ComprasDetalle by Actividades
        /// </summary>
        public void DeleteByActividades(System.Int32 IdActividad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ComprasDetalle_DeleteByActividades", IdActividad);
        }

        /// <summary>
        /// Delete ComprasDetalle by Actividades
        /// </summary>
        public void DeleteByActividades(DbTransaction transaction, System.Int32 IdActividad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ComprasDetalle_DeleteByActividades", IdActividad);
        }

        /// <summary>
        /// Delete ComprasDetalle by Actividades
        /// </summary>
        public void DeleteByActividades(IUniqueIdentifiable Actividades)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ComprasDetalle_DeleteByActividades", Actividades.Identifier());
        }

        /// <summary>
        /// Delete ComprasDetalle by Actividades
        /// </summary>
        public void DeleteByActividades(DbTransaction transaction, IUniqueIdentifiable Actividades)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ComprasDetalle_DeleteByActividades", Actividades.Identifier());
        }


    

        /// <summary>
        /// Delete ComprasDetalle by Compras
        /// </summary>
        public void DeleteByCompras(System.Int32 IdCompra)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ComprasDetalle_DeleteByCompras", IdCompra);
        }

        /// <summary>
        /// Delete ComprasDetalle by Compras
        /// </summary>
        public void DeleteByCompras(DbTransaction transaction, System.Int32 IdCompra)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ComprasDetalle_DeleteByCompras", IdCompra);
        }

        /// <summary>
        /// Delete ComprasDetalle by Compras
        /// </summary>
        public void DeleteByCompras(IUniqueIdentifiable Compras)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ComprasDetalle_DeleteByCompras", Compras.Identifier());
        }

        /// <summary>
        /// Delete ComprasDetalle by Compras
        /// </summary>
        public void DeleteByCompras(DbTransaction transaction, IUniqueIdentifiable Compras)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ComprasDetalle_DeleteByCompras", Compras.Identifier());
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








