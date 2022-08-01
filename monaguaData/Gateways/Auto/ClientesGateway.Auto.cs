
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 18/7/2022 - 04:08 p. m.
// This is a partial class file. The other one is ClientesGateway.cs
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

    public partial class ClientesGateway : BaseGateway<ClientesObject, ClientesObjectList>, IGenericGateway
    {

        #region "Singleton"

        static ClientesGateway _instance;

        private ClientesGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static ClientesGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ClientesGateway();
                else {
                    ClientesGateway inst = HttpContext.Current.Items["monaguaRules.ClientesGatewaySingleton"] as ClientesGateway;
                    if (inst == null) {
                        inst = new ClientesGateway();
                        HttpContext.Current.Items.Add("monaguaRules.ClientesGatewaySingleton", inst);
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
            get { return "Clientes"; }
        }

        protected override string RuleName
        {
            get {return typeof(ClientesGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ClientesObject entity)
        {
            
            IMappeableClientesObject Clientes = (IMappeableClientesObject)entity;
            Clientes.HydrateFields(
            reader.GetInt32(0),
reader.GetDateTime(1),
reader.GetString(2),
(reader.IsDBNull(3)) ? "" : reader.GetString(3),
reader.GetString(4),
reader.GetDateTime(5),
reader.GetBoolean(6),
reader.GetBoolean(7),
(reader.IsDBNull(8)) ? new System.Nullable<System.Int32>() : reader.GetInt32(8),
(reader.IsDBNull(9)) ? new System.Nullable<System.Int32>() : reader.GetInt32(9),
(reader.IsDBNull(10)) ? new System.Nullable<System.Int32>() : reader.GetInt32(10),
(reader.IsDBNull(11)) ? "" : reader.GetString(11),
reader.GetBoolean(12),
(reader.IsDBNull(13)) ? "" : reader.GetString(13));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(ClientesObject entity)
        {

            IMappeableClientesObject Clientes = (IMappeableClientesObject)entity;
            return Clientes.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(ClientesObject entity)
        {

            IMappeableClientesObject Clientes = (IMappeableClientesObject)entity;
            return Clientes.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(ClientesObject entity)
        {

            IMappeableClientesObject Clientes = (IMappeableClientesObject)entity;
            return Clientes.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ClientesObject row, object[] parameters)
        {
            ((IMappeableClientesObject) row).UpdateObjectFromOutputParams(parameters);
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
        /// Get a ClientesObject by execute a SQL Query Text
        /// </summary>
        public ClientesObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ClientesObjectList by execute a SQL Query Text
        /// </summary>
        public ClientesObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a ClientesObject by calling a Stored Procedure
        /// </summary>
        public ClientesObject GetOne(System.Int32 IdCliente)
        {
            return base.GetOne(new ClientesObject(IdCliente));
        }


        // GetBy Objects and Params
            


        

        /// <summary>
        /// Get a ClientesObjectList by calling a Stored Procedure
        /// </summary>
        public ClientesObjectList GetByLocalidades(DbTransaction transaction,System.Int32 IdLocalidad)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByLocalidades", IdLocalidad);
        }

        /// <summary>
        /// Get a ClientesObjectList by calling a Stored Procedure
        /// </summary>
        public ClientesObjectList GetByLocalidades(DbTransaction transaction, IUniqueIdentifiable Localidades)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByLocalidades", Localidades.Identifier());
        }

    

        /// <summary>
        /// Get a ClientesObjectList by calling a Stored Procedure
        /// </summary>
        public ClientesObjectList GetByPaises(DbTransaction transaction,System.Int32 IdPais)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByPaises", IdPais);
        }

        /// <summary>
        /// Get a ClientesObjectList by calling a Stored Procedure
        /// </summary>
        public ClientesObjectList GetByPaises(DbTransaction transaction, IUniqueIdentifiable Paises)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByPaises", Paises.Identifier());
        }

    

        /// <summary>
        /// Get a ClientesObjectList by calling a Stored Procedure
        /// </summary>
        public ClientesObjectList GetByProvincias(DbTransaction transaction,System.Int32 IdProvincia)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByProvincias", IdProvincia);
        }

        /// <summary>
        /// Get a ClientesObjectList by calling a Stored Procedure
        /// </summary>
        public ClientesObjectList GetByProvincias(DbTransaction transaction, IUniqueIdentifiable Provincias)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByProvincias", Provincias.Identifier());
        }

    

        

        /// <summary>
        /// Get a ClientesObjectList by calling a Stored Procedure
        /// </summary>
        public ClientesObjectList GetByLocalidades(System.Int32 IdLocalidad)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByLocalidades", IdLocalidad);
        }

        /// <summary>
        /// Get a ClientesObjectList by calling a Stored Procedure
        /// </summary>
        public ClientesObjectList GetByLocalidades(IUniqueIdentifiable Localidades)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByLocalidades", Localidades.Identifier());
        }

    

        /// <summary>
        /// Get a ClientesObjectList by calling a Stored Procedure
        /// </summary>
        public ClientesObjectList GetByPaises(System.Int32 IdPais)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByPaises", IdPais);
        }

        /// <summary>
        /// Get a ClientesObjectList by calling a Stored Procedure
        /// </summary>
        public ClientesObjectList GetByPaises(IUniqueIdentifiable Paises)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByPaises", Paises.Identifier());
        }

    

        /// <summary>
        /// Get a ClientesObjectList by calling a Stored Procedure
        /// </summary>
        public ClientesObjectList GetByProvincias(System.Int32 IdProvincia)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByProvincias", IdProvincia);
        }

        /// <summary>
        /// Get a ClientesObjectList by calling a Stored Procedure
        /// </summary>
        public ClientesObjectList GetByProvincias(IUniqueIdentifiable Provincias)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByProvincias", Provincias.Identifier());
        }

    

        /// <summary>
        /// Delete Clientes
        /// </summary>
        public void Delete(System.Int32 IdCliente)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_Delete", IdCliente);
        }

        /// <summary>
        /// Delete Clientes
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdCliente)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_Delete", IdCliente);
        }

            

        

        /// <summary>
        /// Delete Clientes by Localidades
        /// </summary>
        public void DeleteByLocalidades(System.Int32 IdLocalidad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_DeleteByLocalidades", IdLocalidad);
        }

        /// <summary>
        /// Delete Clientes by Localidades
        /// </summary>
        public void DeleteByLocalidades(DbTransaction transaction, System.Int32 IdLocalidad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_DeleteByLocalidades", IdLocalidad);
        }

        /// <summary>
        /// Delete Clientes by Localidades
        /// </summary>
        public void DeleteByLocalidades(IUniqueIdentifiable Localidades)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_DeleteByLocalidades", Localidades.Identifier());
        }

        /// <summary>
        /// Delete Clientes by Localidades
        /// </summary>
        public void DeleteByLocalidades(DbTransaction transaction, IUniqueIdentifiable Localidades)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_DeleteByLocalidades", Localidades.Identifier());
        }


    

        /// <summary>
        /// Delete Clientes by Paises
        /// </summary>
        public void DeleteByPaises(System.Int32 IdPais)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_DeleteByPaises", IdPais);
        }

        /// <summary>
        /// Delete Clientes by Paises
        /// </summary>
        public void DeleteByPaises(DbTransaction transaction, System.Int32 IdPais)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_DeleteByPaises", IdPais);
        }

        /// <summary>
        /// Delete Clientes by Paises
        /// </summary>
        public void DeleteByPaises(IUniqueIdentifiable Paises)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_DeleteByPaises", Paises.Identifier());
        }

        /// <summary>
        /// Delete Clientes by Paises
        /// </summary>
        public void DeleteByPaises(DbTransaction transaction, IUniqueIdentifiable Paises)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_DeleteByPaises", Paises.Identifier());
        }


    

        /// <summary>
        /// Delete Clientes by Provincias
        /// </summary>
        public void DeleteByProvincias(System.Int32 IdProvincia)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_DeleteByProvincias", IdProvincia);
        }

        /// <summary>
        /// Delete Clientes by Provincias
        /// </summary>
        public void DeleteByProvincias(DbTransaction transaction, System.Int32 IdProvincia)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_DeleteByProvincias", IdProvincia);
        }

        /// <summary>
        /// Delete Clientes by Provincias
        /// </summary>
        public void DeleteByProvincias(IUniqueIdentifiable Provincias)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_DeleteByProvincias", Provincias.Identifier());
        }

        /// <summary>
        /// Delete Clientes by Provincias
        /// </summary>
        public void DeleteByProvincias(DbTransaction transaction, IUniqueIdentifiable Provincias)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_DeleteByProvincias", Provincias.Identifier());
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








