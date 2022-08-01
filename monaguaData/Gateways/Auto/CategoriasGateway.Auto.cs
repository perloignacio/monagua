
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 18/7/2022 - 04:08 p. m.
// This is a partial class file. The other one is CategoriasGateway.cs
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

    public partial class CategoriasGateway : BaseGateway<CategoriasObject, CategoriasObjectList>, IGenericGateway
    {

        #region "Singleton"

        static CategoriasGateway _instance;

        private CategoriasGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static CategoriasGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new CategoriasGateway();
                else {
                    CategoriasGateway inst = HttpContext.Current.Items["monaguaRules.CategoriasGatewaySingleton"] as CategoriasGateway;
                    if (inst == null) {
                        inst = new CategoriasGateway();
                        HttpContext.Current.Items.Add("monaguaRules.CategoriasGatewaySingleton", inst);
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
            get { return "Categorias"; }
        }

        protected override string RuleName
        {
            get {return typeof(CategoriasGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, CategoriasObject entity)
        {
            
            IMappeableCategoriasObject Categorias = (IMappeableCategoriasObject)entity;
            Categorias.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetBoolean(2));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(CategoriasObject entity)
        {

            IMappeableCategoriasObject Categorias = (IMappeableCategoriasObject)entity;
            return Categorias.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(CategoriasObject entity)
        {

            IMappeableCategoriasObject Categorias = (IMappeableCategoriasObject)entity;
            return Categorias.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(CategoriasObject entity)
        {

            IMappeableCategoriasObject Categorias = (IMappeableCategoriasObject)entity;
            return Categorias.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(CategoriasObject row, object[] parameters)
        {
            ((IMappeableCategoriasObject) row).UpdateObjectFromOutputParams(parameters);
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
        /// Get a CategoriasObject by execute a SQL Query Text
        /// </summary>
        public CategoriasObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a CategoriasObjectList by execute a SQL Query Text
        /// </summary>
        public CategoriasObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a CategoriasObject by calling a Stored Procedure
        /// </summary>
        public CategoriasObject GetOne(System.Int32 IdCategoria)
        {
            return base.GetOne(new CategoriasObject(IdCategoria));
        }


        // GetBy Objects and Params
            


        

        

        /// <summary>
        /// Delete Categorias
        /// </summary>
        public void Delete(System.Int32 IdCategoria)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Categorias_Delete", IdCategoria);
        }

        /// <summary>
        /// Delete Categorias
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdCategoria)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Categorias_Delete", IdCategoria);
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








