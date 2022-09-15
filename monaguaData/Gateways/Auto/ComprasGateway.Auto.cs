
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 15/09/2022 - 16:08
// This is a partial class file. The other one is ComprasGateway.cs
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

    public partial class ComprasGateway : BaseGateway<ComprasObject, ComprasObjectList>, IGenericGateway
    {

        #region "Singleton"

        static ComprasGateway _instance;

        private ComprasGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static ComprasGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ComprasGateway();
                else {
                    ComprasGateway inst = HttpContext.Current.Items["monaguaRules.ComprasGatewaySingleton"] as ComprasGateway;
                    if (inst == null) {
                        inst = new ComprasGateway();
                        HttpContext.Current.Items.Add("monaguaRules.ComprasGatewaySingleton", inst);
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
            get { return "Compras"; }
        }

        protected override string RuleName
        {
            get {return typeof(ComprasGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ComprasObject entity)
        {
            
            IMappeableComprasObject Compras = (IMappeableComprasObject)entity;
            Compras.HydrateFields(
            reader.GetInt32(0),
(reader.IsDBNull(1)) ? new System.Nullable<System.Int32>() : reader.GetInt32(1),
reader.GetDateTime(2),
reader.GetBoolean(3),
(reader.IsDBNull(4)) ? new System.Nullable<System.Int32>() : reader.GetInt32(4),
(reader.IsDBNull(5)) ? "" : reader.GetString(5),
reader.GetInt32(6),
reader.GetBoolean(7),
(reader.IsDBNull(8)) ? "" : reader.GetString(8),
(reader.IsDBNull(9)) ? new System.Nullable<System.Decimal>() : reader.GetDecimal(9));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(ComprasObject entity)
        {

            IMappeableComprasObject Compras = (IMappeableComprasObject)entity;
            return Compras.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(ComprasObject entity)
        {

            IMappeableComprasObject Compras = (IMappeableComprasObject)entity;
            return Compras.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(ComprasObject entity)
        {

            IMappeableComprasObject Compras = (IMappeableComprasObject)entity;
            return Compras.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ComprasObject row, object[] parameters)
        {
            ((IMappeableComprasObject) row).UpdateObjectFromOutputParams(parameters);
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
        /// Get a ComprasObject by execute a SQL Query Text
        /// </summary>
        public ComprasObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ComprasObjectList by execute a SQL Query Text
        /// </summary>
        public ComprasObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a ComprasObject by calling a Stored Procedure
        /// </summary>
        public ComprasObject GetOne(System.Int32 IdCompra)
        {
            return base.GetOne(new ComprasObject(IdCompra));
        }


        // GetBy Objects and Params
            


        

        /// <summary>
        /// Get a ComprasObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasObjectList GetByClientes(DbTransaction transaction,System.Int32 IdCliente)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByClientes", IdCliente);
        }

        /// <summary>
        /// Get a ComprasObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasObjectList GetByClientes(DbTransaction transaction, IUniqueIdentifiable Clientes)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByClientes", Clientes.Identifier());
        }

    

        /// <summary>
        /// Get a ComprasObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasObjectList GetByDescuentos(DbTransaction transaction,System.Int32 IdDescuento)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByDescuentos", IdDescuento);
        }

        /// <summary>
        /// Get a ComprasObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasObjectList GetByDescuentos(DbTransaction transaction, IUniqueIdentifiable Descuentos)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByDescuentos", Descuentos.Identifier());
        }

    

        /// <summary>
        /// Get a ComprasObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasObjectList GetByEstadosCompra(DbTransaction transaction,System.Int32 IdEstadoCompra)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByEstadosCompra", IdEstadoCompra);
        }

        /// <summary>
        /// Get a ComprasObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasObjectList GetByEstadosCompra(DbTransaction transaction, IUniqueIdentifiable EstadosCompra)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByEstadosCompra", EstadosCompra.Identifier());
        }

    

        

        /// <summary>
        /// Get a ComprasObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasObjectList GetByClientes(System.Int32 IdCliente)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByClientes", IdCliente);
        }

        /// <summary>
        /// Get a ComprasObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasObjectList GetByClientes(IUniqueIdentifiable Clientes)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByClientes", Clientes.Identifier());
        }

    

        /// <summary>
        /// Get a ComprasObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasObjectList GetByDescuentos(System.Int32 IdDescuento)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByDescuentos", IdDescuento);
        }

        /// <summary>
        /// Get a ComprasObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasObjectList GetByDescuentos(IUniqueIdentifiable Descuentos)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByDescuentos", Descuentos.Identifier());
        }

    

        /// <summary>
        /// Get a ComprasObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasObjectList GetByEstadosCompra(System.Int32 IdEstadoCompra)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByEstadosCompra", IdEstadoCompra);
        }

        /// <summary>
        /// Get a ComprasObjectList by calling a Stored Procedure
        /// </summary>
        public ComprasObjectList GetByEstadosCompra(IUniqueIdentifiable EstadosCompra)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByEstadosCompra", EstadosCompra.Identifier());
        }

    

        /// <summary>
        /// Delete Compras
        /// </summary>
        public void Delete(System.Int32 IdCompra)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Compras_Delete", IdCompra);
        }

        /// <summary>
        /// Delete Compras
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdCompra)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_Delete", IdCompra);
        }

            

        

        /// <summary>
        /// Delete Compras by Clientes
        /// </summary>
        public void DeleteByClientes(System.Int32 IdCliente)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Compras_DeleteByClientes", IdCliente);
        }

        /// <summary>
        /// Delete Compras by Clientes
        /// </summary>
        public void DeleteByClientes(DbTransaction transaction, System.Int32 IdCliente)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_DeleteByClientes", IdCliente);
        }

        /// <summary>
        /// Delete Compras by Clientes
        /// </summary>
        public void DeleteByClientes(IUniqueIdentifiable Clientes)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Compras_DeleteByClientes", Clientes.Identifier());
        }

        /// <summary>
        /// Delete Compras by Clientes
        /// </summary>
        public void DeleteByClientes(DbTransaction transaction, IUniqueIdentifiable Clientes)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_DeleteByClientes", Clientes.Identifier());
        }


    

        /// <summary>
        /// Delete Compras by Descuentos
        /// </summary>
        public void DeleteByDescuentos(System.Int32 IdDescuento)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Compras_DeleteByDescuentos", IdDescuento);
        }

        /// <summary>
        /// Delete Compras by Descuentos
        /// </summary>
        public void DeleteByDescuentos(DbTransaction transaction, System.Int32 IdDescuento)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_DeleteByDescuentos", IdDescuento);
        }

        /// <summary>
        /// Delete Compras by Descuentos
        /// </summary>
        public void DeleteByDescuentos(IUniqueIdentifiable Descuentos)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Compras_DeleteByDescuentos", Descuentos.Identifier());
        }

        /// <summary>
        /// Delete Compras by Descuentos
        /// </summary>
        public void DeleteByDescuentos(DbTransaction transaction, IUniqueIdentifiable Descuentos)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_DeleteByDescuentos", Descuentos.Identifier());
        }


    

        /// <summary>
        /// Delete Compras by EstadosCompra
        /// </summary>
        public void DeleteByEstadosCompra(System.Int32 IdEstadoCompra)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Compras_DeleteByEstadosCompra", IdEstadoCompra);
        }

        /// <summary>
        /// Delete Compras by EstadosCompra
        /// </summary>
        public void DeleteByEstadosCompra(DbTransaction transaction, System.Int32 IdEstadoCompra)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_DeleteByEstadosCompra", IdEstadoCompra);
        }

        /// <summary>
        /// Delete Compras by EstadosCompra
        /// </summary>
        public void DeleteByEstadosCompra(IUniqueIdentifiable EstadosCompra)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Compras_DeleteByEstadosCompra", EstadosCompra.Identifier());
        }

        /// <summary>
        /// Delete Compras by EstadosCompra
        /// </summary>
        public void DeleteByEstadosCompra(DbTransaction transaction, IUniqueIdentifiable EstadosCompra)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_DeleteByEstadosCompra", EstadosCompra.Identifier());
        }


    


        //Database Queries 
        
            

        /// <summary>
        /// 
        /// </summary>
        public ComprasObjectList GetByCodigo(System.String codigo) {
            
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByCodigo" , codigo);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public ComprasObjectList GetByCodigo(DbTransaction transaction , System.String codigo) {
            
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByCodigo" , codigo);
            
        }


        
            

        /// <summary>
        /// 
        /// </summary>
        public ComprasObjectList GetcomprasByCliente(System.Int32 idcliente) {
            
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetcomprasByCliente" , idcliente);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public ComprasObjectList GetcomprasByCliente(DbTransaction transaction , System.Int32 idcliente) {
            
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetcomprasByCliente" , idcliente);
            
        }


        
            

        /// <summary>
        /// 
        /// </summary>
        public ComprasObjectList GetByPrestador(System.Int32 idprestador) {
            
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByPrestador" , idprestador);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public ComprasObjectList GetByPrestador(DbTransaction transaction , System.Int32 idprestador) {
            
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByPrestador" , idprestador);
            
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








