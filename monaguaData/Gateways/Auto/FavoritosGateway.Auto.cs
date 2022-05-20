
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 20/5/2022 - 04:29 p. m.
// This is a partial class file. The other one is FavoritosGateway.cs
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

    public partial class FavoritosGateway : BaseGateway<FavoritosObject, FavoritosObjectList>, IGenericGateway
    {

        #region "Singleton"

        static FavoritosGateway _instance;

        private FavoritosGateway()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        
        
        public static FavoritosGateway Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new FavoritosGateway();
                else {
                    FavoritosGateway inst = HttpContext.Current.Items["monaguaRules.FavoritosGatewaySingleton"] as FavoritosGateway;
                    if (inst == null) {
                        inst = new FavoritosGateway();
                        HttpContext.Current.Items.Add("monaguaRules.FavoritosGatewaySingleton", inst);
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
            get { return "Favoritos"; }
        }

        protected override string RuleName
        {
            get {return typeof(FavoritosGateway).FullName;}
        }


        

        /// <summary>
        /// Assign properties values based on DataReader
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, FavoritosObject entity)
        {
            
            IMappeableFavoritosObject Favoritos = (IMappeableFavoritosObject)entity;
            Favoritos.HydrateFields(
            reader.GetInt32(0),
reader.GetDateTime(1),
reader.GetInt32(2),
reader.GetInt32(3));
            ((IObject)entity).State = ObjectState.Restored;
        }

        /// <summary>
        /// Get field values to call insertion stored procedure
        /// </summary>
        protected override object[] GetFieldsForInsert(FavoritosObject entity)
        {

            IMappeableFavoritosObject Favoritos = (IMappeableFavoritosObject)entity;
            return Favoritos.GetFieldsForInsert();
        }

        /// <summary>
        /// Get field values to call update stored procedure
        /// </summary>
        protected override object[] GetFieldsForUpdate(FavoritosObject entity)
        {

            IMappeableFavoritosObject Favoritos = (IMappeableFavoritosObject)entity;
            return Favoritos.GetFieldsForUpdate();
        }

        /// <summary>
        /// Get field values to call deletion stored procedure
        /// </summary>
        protected override object[] GetFieldsForDelete(FavoritosObject entity)
        {

            IMappeableFavoritosObject Favoritos = (IMappeableFavoritosObject)entity;
            return Favoritos.GetFieldsForDelete();
        }

        /// <summary>
        /// Raised after insert and update. Update properties from Output parameters
        /// </summary>
        protected override void UpdateObjectFromOutputParams(FavoritosObject row, object[] parameters)
        {
            ((IMappeableFavoritosObject) row).UpdateObjectFromOutputParams(parameters);
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
        /// Get a FavoritosObject by execute a SQL Query Text
        /// </summary>
        public FavoritosObject GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a FavoritosObjectList by execute a SQL Query Text
        /// </summary>
        public FavoritosObjectList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// Get a FavoritosObject by calling a Stored Procedure
        /// </summary>
        public FavoritosObject GetOne(System.Int32 IdFavorito)
        {
            return base.GetOne(new FavoritosObject(IdFavorito));
        }


        // GetBy Objects and Params
            


        

        /// <summary>
        /// Get a FavoritosObjectList by calling a Stored Procedure
        /// </summary>
        public FavoritosObjectList GetByActividades(DbTransaction transaction,System.Int32 IdActividad)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Favoritos_GetByActividades", IdActividad);
        }

        /// <summary>
        /// Get a FavoritosObjectList by calling a Stored Procedure
        /// </summary>
        public FavoritosObjectList GetByActividades(DbTransaction transaction, IUniqueIdentifiable Actividades)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Favoritos_GetByActividades", Actividades.Identifier());
        }

    

        /// <summary>
        /// Get a FavoritosObjectList by calling a Stored Procedure
        /// </summary>
        public FavoritosObjectList GetByClientes(DbTransaction transaction,System.Int32 IdCliente)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Favoritos_GetByClientes", IdCliente);
        }

        /// <summary>
        /// Get a FavoritosObjectList by calling a Stored Procedure
        /// </summary>
        public FavoritosObjectList GetByClientes(DbTransaction transaction, IUniqueIdentifiable Clientes)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Favoritos_GetByClientes", Clientes.Identifier());
        }

    

        

        /// <summary>
        /// Get a FavoritosObjectList by calling a Stored Procedure
        /// </summary>
        public FavoritosObjectList GetByActividades(System.Int32 IdActividad)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Favoritos_GetByActividades", IdActividad);
        }

        /// <summary>
        /// Get a FavoritosObjectList by calling a Stored Procedure
        /// </summary>
        public FavoritosObjectList GetByActividades(IUniqueIdentifiable Actividades)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Favoritos_GetByActividades", Actividades.Identifier());
        }

    

        /// <summary>
        /// Get a FavoritosObjectList by calling a Stored Procedure
        /// </summary>
        public FavoritosObjectList GetByClientes(System.Int32 IdCliente)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Favoritos_GetByClientes", IdCliente);
        }

        /// <summary>
        /// Get a FavoritosObjectList by calling a Stored Procedure
        /// </summary>
        public FavoritosObjectList GetByClientes(IUniqueIdentifiable Clientes)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Favoritos_GetByClientes", Clientes.Identifier());
        }

    

        /// <summary>
        /// Delete Favoritos
        /// </summary>
        public void Delete(System.Int32 IdFavorito)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Favoritos_Delete", IdFavorito);
        }

        /// <summary>
        /// Delete Favoritos
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdFavorito)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Favoritos_Delete", IdFavorito);
        }

            

        

        /// <summary>
        /// Delete Favoritos by Actividades
        /// </summary>
        public void DeleteByActividades(System.Int32 IdActividad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Favoritos_DeleteByActividades", IdActividad);
        }

        /// <summary>
        /// Delete Favoritos by Actividades
        /// </summary>
        public void DeleteByActividades(DbTransaction transaction, System.Int32 IdActividad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Favoritos_DeleteByActividades", IdActividad);
        }

        /// <summary>
        /// Delete Favoritos by Actividades
        /// </summary>
        public void DeleteByActividades(IUniqueIdentifiable Actividades)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Favoritos_DeleteByActividades", Actividades.Identifier());
        }

        /// <summary>
        /// Delete Favoritos by Actividades
        /// </summary>
        public void DeleteByActividades(DbTransaction transaction, IUniqueIdentifiable Actividades)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Favoritos_DeleteByActividades", Actividades.Identifier());
        }


    

        /// <summary>
        /// Delete Favoritos by Clientes
        /// </summary>
        public void DeleteByClientes(System.Int32 IdCliente)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Favoritos_DeleteByClientes", IdCliente);
        }

        /// <summary>
        /// Delete Favoritos by Clientes
        /// </summary>
        public void DeleteByClientes(DbTransaction transaction, System.Int32 IdCliente)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Favoritos_DeleteByClientes", IdCliente);
        }

        /// <summary>
        /// Delete Favoritos by Clientes
        /// </summary>
        public void DeleteByClientes(IUniqueIdentifiable Clientes)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Favoritos_DeleteByClientes", Clientes.Identifier());
        }

        /// <summary>
        /// Delete Favoritos by Clientes
        /// </summary>
        public void DeleteByClientes(DbTransaction transaction, IUniqueIdentifiable Clientes)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Favoritos_DeleteByClientes", Clientes.Identifier());
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








