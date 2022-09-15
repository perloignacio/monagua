
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 15/09/2022 - 16:08
// This is a partial class file. The other one is UsuariosGateway.cs
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

    public partial class UsuariosGateway : BaseGateway<UsuariosObject, UsuariosObjectList>, IGenericGateway
    {

        #region "Singleton"

        static UsuariosGateway _instance;

        private UsuariosGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static UsuariosGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new UsuariosGateway();
                else {
                    UsuariosGateway inst = HttpContext.Current.Items["monaguaRules.UsuariosGatewaySingleton"] as UsuariosGateway;
                    if (inst == null) {
                        inst = new UsuariosGateway();
                        HttpContext.Current.Items.Add("monaguaRules.UsuariosGatewaySingleton", inst);
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
            get { return "Usuarios"; }
        }

        protected override string RuleName
        {
            get {return typeof(UsuariosGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, UsuariosObject entity)
        {
            
            IMappeableUsuariosObject Usuarios = (IMappeableUsuariosObject)entity;
            Usuarios.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetString(2),
(reader.IsDBNull(3)) ? "" : reader.GetString(3),
(reader.IsDBNull(4)) ? "" : reader.GetString(4),
(reader.IsDBNull(5)) ? "" : reader.GetString(5),
(reader.IsDBNull(6)) ? new System.Nullable<System.Int32>() : reader.GetInt32(6),
(reader.IsDBNull(7)) ? new System.Nullable<System.Int32>() : reader.GetInt32(7),
reader.GetBoolean(8),
(reader.IsDBNull(9)) ? "" : reader.GetString(9));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(UsuariosObject entity)
        {

            IMappeableUsuariosObject Usuarios = (IMappeableUsuariosObject)entity;
            return Usuarios.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(UsuariosObject entity)
        {

            IMappeableUsuariosObject Usuarios = (IMappeableUsuariosObject)entity;
            return Usuarios.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(UsuariosObject entity)
        {

            IMappeableUsuariosObject Usuarios = (IMappeableUsuariosObject)entity;
            return Usuarios.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(UsuariosObject row, object[] parameters)
        {
            ((IMappeableUsuariosObject) row).UpdateObjectFromOutputParams(parameters);
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
        /// Get a UsuariosObject by execute a SQL Query Text
        /// </summary>
        public UsuariosObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a UsuariosObjectList by execute a SQL Query Text
        /// </summary>
        public UsuariosObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a UsuariosObject by calling a Stored Procedure
        /// </summary>
        public UsuariosObject GetOne(System.Int32 IdUsuario)
        {
            return base.GetOne(new UsuariosObject(IdUsuario));
        }


        // GetBy Objects and Params
            


        

        /// <summary>
        /// Get a UsuariosObjectList by calling a Stored Procedure
        /// </summary>
        public UsuariosObjectList GetByClientes(DbTransaction transaction,System.Int32 IdCliente)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_GetByClientes", IdCliente);
        }

        /// <summary>
        /// Get a UsuariosObjectList by calling a Stored Procedure
        /// </summary>
        public UsuariosObjectList GetByClientes(DbTransaction transaction, IUniqueIdentifiable Clientes)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_GetByClientes", Clientes.Identifier());
        }

    

        /// <summary>
        /// Get a UsuariosObjectList by calling a Stored Procedure
        /// </summary>
        public UsuariosObjectList GetByPrestadores(DbTransaction transaction,System.Int32 IdPrestador)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_GetByPrestadores", IdPrestador);
        }

        /// <summary>
        /// Get a UsuariosObjectList by calling a Stored Procedure
        /// </summary>
        public UsuariosObjectList GetByPrestadores(DbTransaction transaction, IUniqueIdentifiable Prestadores)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_GetByPrestadores", Prestadores.Identifier());
        }

    

        

        /// <summary>
        /// Get a UsuariosObjectList by calling a Stored Procedure
        /// </summary>
        public UsuariosObjectList GetByClientes(System.Int32 IdCliente)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_GetByClientes", IdCliente);
        }

        /// <summary>
        /// Get a UsuariosObjectList by calling a Stored Procedure
        /// </summary>
        public UsuariosObjectList GetByClientes(IUniqueIdentifiable Clientes)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_GetByClientes", Clientes.Identifier());
        }

    

        /// <summary>
        /// Get a UsuariosObjectList by calling a Stored Procedure
        /// </summary>
        public UsuariosObjectList GetByPrestadores(System.Int32 IdPrestador)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_GetByPrestadores", IdPrestador);
        }

        /// <summary>
        /// Get a UsuariosObjectList by calling a Stored Procedure
        /// </summary>
        public UsuariosObjectList GetByPrestadores(IUniqueIdentifiable Prestadores)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_GetByPrestadores", Prestadores.Identifier());
        }

    

        /// <summary>
        /// Delete Usuarios
        /// </summary>
        public void Delete(System.Int32 IdUsuario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Usuarios_Delete", IdUsuario);
        }

        /// <summary>
        /// Delete Usuarios
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdUsuario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_Delete", IdUsuario);
        }

            

        

        /// <summary>
        /// Delete Usuarios by Clientes
        /// </summary>
        public void DeleteByClientes(System.Int32 IdCliente)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Usuarios_DeleteByClientes", IdCliente);
        }

        /// <summary>
        /// Delete Usuarios by Clientes
        /// </summary>
        public void DeleteByClientes(DbTransaction transaction, System.Int32 IdCliente)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_DeleteByClientes", IdCliente);
        }

        /// <summary>
        /// Delete Usuarios by Clientes
        /// </summary>
        public void DeleteByClientes(IUniqueIdentifiable Clientes)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Usuarios_DeleteByClientes", Clientes.Identifier());
        }

        /// <summary>
        /// Delete Usuarios by Clientes
        /// </summary>
        public void DeleteByClientes(DbTransaction transaction, IUniqueIdentifiable Clientes)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_DeleteByClientes", Clientes.Identifier());
        }


    

        /// <summary>
        /// Delete Usuarios by Prestadores
        /// </summary>
        public void DeleteByPrestadores(System.Int32 IdPrestador)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Usuarios_DeleteByPrestadores", IdPrestador);
        }

        /// <summary>
        /// Delete Usuarios by Prestadores
        /// </summary>
        public void DeleteByPrestadores(DbTransaction transaction, System.Int32 IdPrestador)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_DeleteByPrestadores", IdPrestador);
        }

        /// <summary>
        /// Delete Usuarios by Prestadores
        /// </summary>
        public void DeleteByPrestadores(IUniqueIdentifiable Prestadores)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Usuarios_DeleteByPrestadores", Prestadores.Identifier());
        }

        /// <summary>
        /// Delete Usuarios by Prestadores
        /// </summary>
        public void DeleteByPrestadores(DbTransaction transaction, IUniqueIdentifiable Prestadores)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_DeleteByPrestadores", Prestadores.Identifier());
        }


    


        //Database Queries 
        
            

        /// <summary>
        /// 
        /// </summary>
        public UsuariosObject GetByUsuario(System.String usuario) {
            
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_GetByUsuario" , usuario);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public UsuariosObject GetByUsuario(DbTransaction transaction , System.String usuario) {
            
            return base.GetObjectByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_GetByUsuario" , usuario);
            
        }


        
            

        /// <summary>
        /// 
        /// </summary>
        public UsuariosObject Login(System.String usuario, System.String contra) {
            
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_Login" , usuario, contra);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public UsuariosObject Login(DbTransaction transaction , System.String usuario, System.String contra) {
            
            return base.GetObjectByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_Login" , usuario, contra);
            
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








