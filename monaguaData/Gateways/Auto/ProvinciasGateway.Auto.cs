
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 18/7/2022 - 04:08 p. m.
// This is a partial class file. The other one is ProvinciasGateway.cs
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

    public partial class ProvinciasGateway : BaseGateway<ProvinciasObject, ProvinciasObjectList>, IGenericGateway
    {

        #region "Singleton"

        static ProvinciasGateway _instance;

        private ProvinciasGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static ProvinciasGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ProvinciasGateway();
                else {
                    ProvinciasGateway inst = HttpContext.Current.Items["monaguaRules.ProvinciasGatewaySingleton"] as ProvinciasGateway;
                    if (inst == null) {
                        inst = new ProvinciasGateway();
                        HttpContext.Current.Items.Add("monaguaRules.ProvinciasGatewaySingleton", inst);
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
            get { return "Provincias"; }
        }

        protected override string RuleName
        {
            get {return typeof(ProvinciasGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ProvinciasObject entity)
        {
            
            IMappeableProvinciasObject Provincias = (IMappeableProvinciasObject)entity;
            Provincias.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
(reader.IsDBNull(2)) ? new System.Nullable<System.Int32>() : reader.GetInt32(2));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(ProvinciasObject entity)
        {

            IMappeableProvinciasObject Provincias = (IMappeableProvinciasObject)entity;
            return Provincias.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(ProvinciasObject entity)
        {

            IMappeableProvinciasObject Provincias = (IMappeableProvinciasObject)entity;
            return Provincias.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(ProvinciasObject entity)
        {

            IMappeableProvinciasObject Provincias = (IMappeableProvinciasObject)entity;
            return Provincias.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ProvinciasObject row, object[] parameters)
        {
            ((IMappeableProvinciasObject) row).UpdateObjectFromOutputParams(parameters);
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
        /// Get a ProvinciasObject by execute a SQL Query Text
        /// </summary>
        public ProvinciasObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ProvinciasObjectList by execute a SQL Query Text
        /// </summary>
        public ProvinciasObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a ProvinciasObject by calling a Stored Procedure
        /// </summary>
        public ProvinciasObject GetOne(System.Int32 IdProvincia)
        {
            return base.GetOne(new ProvinciasObject(IdProvincia));
        }


        // GetBy Objects and Params
            


        

        /// <summary>
        /// Get a ProvinciasObjectList by calling a Stored Procedure
        /// </summary>
        public ProvinciasObjectList GetByPaises(DbTransaction transaction,System.Int32 IdPais)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Provincias_GetByPaises", IdPais);
        }

        /// <summary>
        /// Get a ProvinciasObjectList by calling a Stored Procedure
        /// </summary>
        public ProvinciasObjectList GetByPaises(DbTransaction transaction, IUniqueIdentifiable Paises)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Provincias_GetByPaises", Paises.Identifier());
        }

    

        

        /// <summary>
        /// Get a ProvinciasObjectList by calling a Stored Procedure
        /// </summary>
        public ProvinciasObjectList GetByPaises(System.Int32 IdPais)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Provincias_GetByPaises", IdPais);
        }

        /// <summary>
        /// Get a ProvinciasObjectList by calling a Stored Procedure
        /// </summary>
        public ProvinciasObjectList GetByPaises(IUniqueIdentifiable Paises)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Provincias_GetByPaises", Paises.Identifier());
        }

    

        /// <summary>
        /// Delete Provincias
        /// </summary>
        public void Delete(System.Int32 IdProvincia)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Provincias_Delete", IdProvincia);
        }

        /// <summary>
        /// Delete Provincias
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdProvincia)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Provincias_Delete", IdProvincia);
        }

            

        

        /// <summary>
        /// Delete Provincias by Paises
        /// </summary>
        public void DeleteByPaises(System.Int32 IdPais)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Provincias_DeleteByPaises", IdPais);
        }

        /// <summary>
        /// Delete Provincias by Paises
        /// </summary>
        public void DeleteByPaises(DbTransaction transaction, System.Int32 IdPais)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Provincias_DeleteByPaises", IdPais);
        }

        /// <summary>
        /// Delete Provincias by Paises
        /// </summary>
        public void DeleteByPaises(IUniqueIdentifiable Paises)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Provincias_DeleteByPaises", Paises.Identifier());
        }

        /// <summary>
        /// Delete Provincias by Paises
        /// </summary>
        public void DeleteByPaises(DbTransaction transaction, IUniqueIdentifiable Paises)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Provincias_DeleteByPaises", Paises.Identifier());
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








