
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 18/7/2022 - 04:08 p. m.
// This is a partial class file. The other one is LocalidadesGateway.cs
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

    public partial class LocalidadesGateway : BaseGateway<LocalidadesObject, LocalidadesObjectList>, IGenericGateway
    {

        #region "Singleton"

        static LocalidadesGateway _instance;

        private LocalidadesGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static LocalidadesGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new LocalidadesGateway();
                else {
                    LocalidadesGateway inst = HttpContext.Current.Items["monaguaRules.LocalidadesGatewaySingleton"] as LocalidadesGateway;
                    if (inst == null) {
                        inst = new LocalidadesGateway();
                        HttpContext.Current.Items.Add("monaguaRules.LocalidadesGatewaySingleton", inst);
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
            get { return "Localidades"; }
        }

        protected override string RuleName
        {
            get {return typeof(LocalidadesGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, LocalidadesObject entity)
        {
            
            IMappeableLocalidadesObject Localidades = (IMappeableLocalidadesObject)entity;
            Localidades.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetString(2),
reader.GetInt32(3));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(LocalidadesObject entity)
        {

            IMappeableLocalidadesObject Localidades = (IMappeableLocalidadesObject)entity;
            return Localidades.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(LocalidadesObject entity)
        {

            IMappeableLocalidadesObject Localidades = (IMappeableLocalidadesObject)entity;
            return Localidades.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(LocalidadesObject entity)
        {

            IMappeableLocalidadesObject Localidades = (IMappeableLocalidadesObject)entity;
            return Localidades.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(LocalidadesObject row, object[] parameters)
        {
            ((IMappeableLocalidadesObject) row).UpdateObjectFromOutputParams(parameters);
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
        /// Get a LocalidadesObject by execute a SQL Query Text
        /// </summary>
        public LocalidadesObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a LocalidadesObjectList by execute a SQL Query Text
        /// </summary>
        public LocalidadesObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a LocalidadesObject by calling a Stored Procedure
        /// </summary>
        public LocalidadesObject GetOne(System.Int32 IdLocalidad)
        {
            return base.GetOne(new LocalidadesObject(IdLocalidad));
        }


        // GetBy Objects and Params
            


        

        /// <summary>
        /// Get a LocalidadesObjectList by calling a Stored Procedure
        /// </summary>
        public LocalidadesObjectList GetByProvincias(DbTransaction transaction,System.Int32 IdProvincia)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Localidades_GetByProvincias", IdProvincia);
        }

        /// <summary>
        /// Get a LocalidadesObjectList by calling a Stored Procedure
        /// </summary>
        public LocalidadesObjectList GetByProvincias(DbTransaction transaction, IUniqueIdentifiable Provincias)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Localidades_GetByProvincias", Provincias.Identifier());
        }

    

        

        /// <summary>
        /// Get a LocalidadesObjectList by calling a Stored Procedure
        /// </summary>
        public LocalidadesObjectList GetByProvincias(System.Int32 IdProvincia)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Localidades_GetByProvincias", IdProvincia);
        }

        /// <summary>
        /// Get a LocalidadesObjectList by calling a Stored Procedure
        /// </summary>
        public LocalidadesObjectList GetByProvincias(IUniqueIdentifiable Provincias)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Localidades_GetByProvincias", Provincias.Identifier());
        }

    

        /// <summary>
        /// Delete Localidades
        /// </summary>
        public void Delete(System.Int32 IdLocalidad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Localidades_Delete", IdLocalidad);
        }

        /// <summary>
        /// Delete Localidades
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdLocalidad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Localidades_Delete", IdLocalidad);
        }

            

        

        /// <summary>
        /// Delete Localidades by Provincias
        /// </summary>
        public void DeleteByProvincias(System.Int32 IdProvincia)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Localidades_DeleteByProvincias", IdProvincia);
        }

        /// <summary>
        /// Delete Localidades by Provincias
        /// </summary>
        public void DeleteByProvincias(DbTransaction transaction, System.Int32 IdProvincia)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Localidades_DeleteByProvincias", IdProvincia);
        }

        /// <summary>
        /// Delete Localidades by Provincias
        /// </summary>
        public void DeleteByProvincias(IUniqueIdentifiable Provincias)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Localidades_DeleteByProvincias", Provincias.Identifier());
        }

        /// <summary>
        /// Delete Localidades by Provincias
        /// </summary>
        public void DeleteByProvincias(DbTransaction transaction, IUniqueIdentifiable Provincias)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Localidades_DeleteByProvincias", Provincias.Identifier());
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








