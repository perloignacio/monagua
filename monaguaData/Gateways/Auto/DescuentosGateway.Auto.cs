
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 31/08/2022 - 14:49
// This is a partial class file. The other one is DescuentosGateway.cs
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

    public partial class DescuentosGateway : BaseGateway<DescuentosObject, DescuentosObjectList>, IGenericGateway
    {

        #region "Singleton"

        static DescuentosGateway _instance;

        private DescuentosGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static DescuentosGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new DescuentosGateway();
                else {
                    DescuentosGateway inst = HttpContext.Current.Items["monaguaRules.DescuentosGatewaySingleton"] as DescuentosGateway;
                    if (inst == null) {
                        inst = new DescuentosGateway();
                        HttpContext.Current.Items.Add("monaguaRules.DescuentosGatewaySingleton", inst);
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
            get { return "Descuentos"; }
        }

        protected override string RuleName
        {
            get {return typeof(DescuentosGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, DescuentosObject entity)
        {
            
            IMappeableDescuentosObject Descuentos = (IMappeableDescuentosObject)entity;
            Descuentos.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetString(2),
(reader.IsDBNull(3)) ? new System.Nullable<System.Decimal>() : reader.GetDecimal(3),
(reader.IsDBNull(4)) ? new System.Nullable<System.Decimal>() : reader.GetDecimal(4),
(reader.IsDBNull(5)) ? new System.Nullable<System.Int32>() : reader.GetInt32(5),
(reader.IsDBNull(6)) ? new System.Nullable<System.DateTime>() : reader.GetDateTime(6),
(reader.IsDBNull(7)) ? new System.Nullable<System.DateTime>() : reader.GetDateTime(7),
reader.GetBoolean(8));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(DescuentosObject entity)
        {

            IMappeableDescuentosObject Descuentos = (IMappeableDescuentosObject)entity;
            return Descuentos.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(DescuentosObject entity)
        {

            IMappeableDescuentosObject Descuentos = (IMappeableDescuentosObject)entity;
            return Descuentos.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(DescuentosObject entity)
        {

            IMappeableDescuentosObject Descuentos = (IMappeableDescuentosObject)entity;
            return Descuentos.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(DescuentosObject row, object[] parameters)
        {
            ((IMappeableDescuentosObject) row).UpdateObjectFromOutputParams(parameters);
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
        /// Get a DescuentosObject by execute a SQL Query Text
        /// </summary>
        public DescuentosObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a DescuentosObjectList by execute a SQL Query Text
        /// </summary>
        public DescuentosObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a DescuentosObject by calling a Stored Procedure
        /// </summary>
        public DescuentosObject GetOne(System.Int32 IdDescuento)
        {
            return base.GetOne(new DescuentosObject(IdDescuento));
        }


        // GetBy Objects and Params
            


        

        

        /// <summary>
        /// Delete Descuentos
        /// </summary>
        public void Delete(System.Int32 IdDescuento)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Descuentos_Delete", IdDescuento);
        }

        /// <summary>
        /// Delete Descuentos
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdDescuento)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Descuentos_Delete", IdDescuento);
        }

            

        


        //Database Queries 
        
            

        /// <summary>
        /// 
        /// </summary>
        public DescuentosObject GetByCodigo(System.String codigo) {
            
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Descuentos_GetByCodigo" , codigo);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public DescuentosObject GetByCodigo(DbTransaction transaction , System.String codigo) {
            
            return base.GetObjectByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Descuentos_GetByCodigo" , codigo);
            
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








