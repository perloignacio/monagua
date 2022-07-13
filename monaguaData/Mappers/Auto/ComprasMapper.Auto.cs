
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 6/7/2022 - 04:37 p. m.
// This is a partial class file. The other one is ComprasMapper.cs
// You should not modifiy this file, please edit the other partial class file.
//------------------------------------------------------------------------------

using System;
using monaguaRules.Entities;
using monaguaRules.Objects;
using Cooperator.Framework.Data;
using Cooperator.Framework.Data.Exceptions;
using Cooperator.Framework.Core;
using System.Data.Common;
using System.Reflection;
using System.Web;
using System.Data;

namespace monaguaRules.Mappers
{

    
    /// <summary>
    /// 
    /// </summary>
    public partial class ComprasMapper : BaseGateway<Compras, ComprasList>, IGenericGateway
    {


        #region "Singleton"

        static ComprasMapper _instance;

        private ComprasMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComprasMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ComprasMapper();
                else {
                    ComprasMapper inst = HttpContext.Current.Items["monaguaRules.ComprasMapperSingleton"] as ComprasMapper;
                    if (inst == null) {
                        inst = new ComprasMapper();
                        HttpContext.Current.Items.Add("monaguaRules.ComprasMapperSingleton", inst);
                    }
                    return inst;
                }
            }
            return _instance;
        }


        #endregion

        /// <summary>
        /// 
        /// </summary>
        public string[] GetPKPropertiesNames()
        {
            
            string[] s ={"IdCompra"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Compras);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Compras"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(ComprasMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Compras entity)
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
(reader.IsDBNull(8)) ? "" : reader.GetString(8));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(Compras entity)
        {

            IMappeableComprasObject Compras = (IMappeableComprasObject)entity;
            return Compras.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(Compras entity)
        {

            IMappeableComprasObject Compras = (IMappeableComprasObject)entity;
            return Compras.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(Compras entity)
        {

            IMappeableComprasObject Compras = (IMappeableComprasObject)entity;
            return Compras.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(Compras entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableComprasObject) entity).UpdateObjectFromOutputParams(parameters);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string StoredProceduresPrefix()
        {
            return "coop_";
        }


        


        

        /// <summary>
        /// Complete the aggregations for this entity. 
        /// </summary>
        protected override void CompleteEntity(Compras entity)
        {
            Entities.Clientes ClientesEntity = null; // Lazy load
Entities.Descuentos DescuentosEntity = null; // Lazy load
Entities.EstadosCompra EstadosCompraEntity = null; // Lazy load
            ((IMappeableCompras)entity).CompleteEntity(ClientesEntity, DescuentosEntity, EstadosCompraEntity);
        }


        # region CRUD Operations
        

        # endregion

        /// <summary>
        /// Delete children for this entity
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, IUniqueIdentifiable entity)
        {
                        
        }


          





        /// <summary>
        /// Get a Compras by execute a SQL Query Text
        /// </summary>
        public Compras GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ComprasList by execute a SQL Query Text
        /// </summary>
        public ComprasList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public Compras GetOne(System.Int32 IdCompra)
        {
            return base.GetOne(new Compras(IdCompra));
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ComprasList GetByClientes(DbTransaction transaction, System.Int32 IdCliente)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByClientes", IdCliente);
        }

        /// <summary>
        /// 
        /// </summary>
        public ComprasList GetByClientes(DbTransaction transaction, IUniqueIdentifiable Clientes)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByClientes", Clientes.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ComprasList GetByDescuentos(DbTransaction transaction, System.Int32 IdDescuento)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByDescuentos", IdDescuento);
        }

        /// <summary>
        /// 
        /// </summary>
        public ComprasList GetByDescuentos(DbTransaction transaction, IUniqueIdentifiable Descuentos)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByDescuentos", Descuentos.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ComprasList GetByEstadosCompra(DbTransaction transaction, System.Int32 IdEstadoCompra)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByEstadosCompra", IdEstadoCompra);
        }

        /// <summary>
        /// 
        /// </summary>
        public ComprasList GetByEstadosCompra(DbTransaction transaction, IUniqueIdentifiable EstadosCompra)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByEstadosCompra", EstadosCompra.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ComprasList GetByClientes(System.Int32 IdCliente)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByClientes", IdCliente);
        }

        /// <summary>
        /// 
        /// </summary>
        public ComprasList GetByClientes(IUniqueIdentifiable Clientes)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByClientes", Clientes.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ComprasList GetByDescuentos(System.Int32 IdDescuento)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByDescuentos", IdDescuento);
        }

        /// <summary>
        /// 
        /// </summary>
        public ComprasList GetByDescuentos(IUniqueIdentifiable Descuentos)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByDescuentos", Descuentos.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ComprasList GetByEstadosCompra(System.Int32 IdEstadoCompra)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByEstadosCompra", IdEstadoCompra);
        }

        /// <summary>
        /// 
        /// </summary>
        public ComprasList GetByEstadosCompra(IUniqueIdentifiable EstadosCompra)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByEstadosCompra", EstadosCompra.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdCompra)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Compras_Delete", IdCompra);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdCompra)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_Delete", IdCompra);
        }


        // Delete By Objects and Params
            



        

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByClientes(System.Int32 IdCliente)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Compras_DeleteByClientes", IdCliente);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByClientes(DbTransaction transaction, System.Int32 IdCliente)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_DeleteByClientes", IdCliente);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByClientes(IUniqueIdentifiable Clientes)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Compras_DeleteByClientes", Clientes.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByClientes(DbTransaction transaction, IUniqueIdentifiable Clientes)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_DeleteByClientes", Clientes.Identifier());
        }


    

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByDescuentos(System.Int32 IdDescuento)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Compras_DeleteByDescuentos", IdDescuento);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByDescuentos(DbTransaction transaction, System.Int32 IdDescuento)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_DeleteByDescuentos", IdDescuento);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByDescuentos(IUniqueIdentifiable Descuentos)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Compras_DeleteByDescuentos", Descuentos.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByDescuentos(DbTransaction transaction, IUniqueIdentifiable Descuentos)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_DeleteByDescuentos", Descuentos.Identifier());
        }


    

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByEstadosCompra(System.Int32 IdEstadoCompra)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Compras_DeleteByEstadosCompra", IdEstadoCompra);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByEstadosCompra(DbTransaction transaction, System.Int32 IdEstadoCompra)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_DeleteByEstadosCompra", IdEstadoCompra);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByEstadosCompra(IUniqueIdentifiable EstadosCompra)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Compras_DeleteByEstadosCompra", EstadosCompra.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByEstadosCompra(DbTransaction transaction, IUniqueIdentifiable EstadosCompra)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_DeleteByEstadosCompra", EstadosCompra.Identifier());
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

namespace monaguaRules.Wrappers
{
    /// <summary>
    /// 
    /// </summary>
    public class ComprasMapperWrapper
    {

        /// <summary>
        /// 
        /// </summary>
        public string[] GetPKPropertiesNames()
        {
            return Instance().GetPKPropertiesNames();
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return Instance().GetMappingType();
        }



        /// <summary>
        /// 
        /// </summary>
        public monaguaRules.Mappers.ComprasMapper Instance()
        {
            return monaguaRules.Mappers.ComprasMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a ComprasEntity by calling a Stored Procedure
        /// </summary>
        public Entities.Compras GetOne(System.Int32 IdCompra) {
            return Instance().GetOne( IdCompra);
        }

        // GetBy Objects and Params
            

        

        /// <summary>
        /// Get a ComprasList by calling a Stored Procedure
        /// </summary>
        public Entities.ComprasList GetByClientes(System.Int32 IdCliente)
        {
            return Instance().GetByClientes(IdCliente);
        }

        /// <summary>
        /// Get a ComprasList by calling a Stored Procedure
        /// </summary>
        public Entities.ComprasList GetByClientes(IUniqueIdentifiable Clientes)
        {
            return Instance().GetByClientes(Clientes);
        }

    

        /// <summary>
        /// Get a ComprasList by calling a Stored Procedure
        /// </summary>
        public Entities.ComprasList GetByDescuentos(System.Int32 IdDescuento)
        {
            return Instance().GetByDescuentos(IdDescuento);
        }

        /// <summary>
        /// Get a ComprasList by calling a Stored Procedure
        /// </summary>
        public Entities.ComprasList GetByDescuentos(IUniqueIdentifiable Descuentos)
        {
            return Instance().GetByDescuentos(Descuentos);
        }

    

        /// <summary>
        /// Get a ComprasList by calling a Stored Procedure
        /// </summary>
        public Entities.ComprasList GetByEstadosCompra(System.Int32 IdEstadoCompra)
        {
            return Instance().GetByEstadosCompra(IdEstadoCompra);
        }

        /// <summary>
        /// Get a ComprasList by calling a Stored Procedure
        /// </summary>
        public Entities.ComprasList GetByEstadosCompra(IUniqueIdentifiable EstadosCompra)
        {
            return Instance().GetByEstadosCompra(EstadosCompra);
        }

    

       

        /// <summary>
        /// Delete children for Compras
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, Compras entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        

        /// <summary>
        /// Delete Compras by Clientes
        /// </summary>
        public void DeleteByClientes(System.Int32 IdCliente)
        {
            Instance().DeleteByClientes(IdCliente);
        }

        /// <summary>
        /// Delete Compras by Clientes
        /// </summary>
        public void DeleteByClientes(IUniqueIdentifiable Clientes)
        {
            Instance().DeleteByClientes(Clientes);
        }

    

        /// <summary>
        /// Delete Compras by Descuentos
        /// </summary>
        public void DeleteByDescuentos(System.Int32 IdDescuento)
        {
            Instance().DeleteByDescuentos(IdDescuento);
        }

        /// <summary>
        /// Delete Compras by Descuentos
        /// </summary>
        public void DeleteByDescuentos(IUniqueIdentifiable Descuentos)
        {
            Instance().DeleteByDescuentos(Descuentos);
        }

    

        /// <summary>
        /// Delete Compras by EstadosCompra
        /// </summary>
        public void DeleteByEstadosCompra(System.Int32 IdEstadoCompra)
        {
            Instance().DeleteByEstadosCompra(IdEstadoCompra);
        }

        /// <summary>
        /// Delete Compras by EstadosCompra
        /// </summary>
        public void DeleteByEstadosCompra(IUniqueIdentifiable EstadosCompra)
        {
            Instance().DeleteByEstadosCompra(EstadosCompra);
        }

    
        /// <summary>
        /// Delete Compras 
        /// </summary>
        public void Delete(System.Int32 IdCompra){
            Instance().Delete(IdCompra);
        }

        /// <summary>
        /// Delete Compras 
        /// </summary>
        public void Delete(Entities.Compras entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save Compras  
        /// </summary>
        public void Save(Entities.Compras entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Compras 
        /// </summary>
        public void Insert(Entities.Compras entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll Compras 
        /// </summary>
        public Entities.ComprasList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save Compras 
        /// </summary>
        public void Save(System.Int32 IdCompra, System.Int32 IdCliente, System.DateTime Fecha, System.Boolean Reserva, System.Int32 IdDescuento, System.String MercadoPago, System.Int32 IdEstadoCompra, System.Boolean Activa, System.String Comentarios){
            Entities.Compras entity = Instance().GetOne(IdCompra);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdCompra", IdCompra));

            entity.IdCliente = IdCliente;
            entity.Fecha = Fecha;
            entity.Reserva = Reserva;
            entity.IdDescuento = IdDescuento;
            entity.MercadoPago = MercadoPago;
            entity.IdEstadoCompra = IdEstadoCompra;
            entity.Activa = Activa;
            entity.Comentarios = Comentarios;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Compras
        /// </summary>
        public void Insert(System.Int32 IdCliente, System.DateTime Fecha, System.Boolean Reserva, System.Int32 IdDescuento, System.String MercadoPago, System.Int32 IdEstadoCompra, System.Boolean Activa, System.String Comentarios){
            Entities.Compras entity = new Entities.Compras();

            entity.IdCliente = IdCliente;
            entity.Fecha = Fecha;
            entity.Reserva = Reserva;
            entity.IdDescuento = IdDescuento;
            entity.MercadoPago = MercadoPago;
            entity.IdEstadoCompra = IdEstadoCompra;
            entity.Activa = Activa;
            entity.Comentarios = Comentarios;
            Instance().Insert(entity);
        }


        //Database Queries 
        


    }
}





namespace monaguaRules.Loaders
{

    /// <summary>
    /// 
    /// </summary>
    public partial class ComprasLoader<T> : BaseLoader< T, Compras, ObjectList<T>>, IGenericGateway where T : Compras, new()
    {

        #region "Singleton"

        static ComprasLoader<T> _instance;

        private ComprasLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ComprasLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ComprasLoader<T>();
                else {
                    ComprasLoader<T> inst = HttpContext.Current.Items["monaguaRules.ComprasLoaderSingleton"] as ComprasLoader<T>;
                    if (inst == null) {
                        inst = new ComprasLoader<T>();
                        HttpContext.Current.Items.Add("monaguaRules.ComprasLoaderSingleton", inst);
                    }
                    return inst;
                }
            }
            return _instance;
        }


        #endregion

        /// <summary>
        /// 
        /// </summary>
        public string[] GetPKPropertiesNames()
        {
            
            string[] s ={"IdCompra"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Compras);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Compras"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Compras entity)
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
(reader.IsDBNull(8)) ? "" : reader.GetString(8));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string StoredProceduresPrefix()
        {
            return "coop_";
        }


        
    

        

        /// <summary>
        /// Complete the aggregations for this entity. 
        /// </summary>
        protected override void CompleteEntity(T entity)
        {
            Entities.Clientes ClientesEntity = null; // Lazy load
Entities.Descuentos DescuentosEntity = null; // Lazy load
Entities.EstadosCompra EstadosCompraEntity = null; // Lazy load
            ((IMappeableCompras)entity).CompleteEntity(ClientesEntity, DescuentosEntity, EstadosCompraEntity);
        }


        



        /// <summary>
        /// Get a Compras by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ComprasList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdCompra)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetOne", IdCompra);
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByClientes(DbTransaction transaction, System.Int32 IdCliente)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByClientes", IdCliente);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByClientes(DbTransaction transaction, IUniqueIdentifiable Clientes)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByClientes", Clientes.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByDescuentos(DbTransaction transaction, System.Int32 IdDescuento)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByDescuentos", IdDescuento);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByDescuentos(DbTransaction transaction, IUniqueIdentifiable Descuentos)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByDescuentos", Descuentos.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByEstadosCompra(DbTransaction transaction, System.Int32 IdEstadoCompra)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByEstadosCompra", IdEstadoCompra);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByEstadosCompra(DbTransaction transaction, IUniqueIdentifiable EstadosCompra)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Compras_GetByEstadosCompra", EstadosCompra.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByClientes(System.Int32 IdCliente)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByClientes", IdCliente);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByClientes(IUniqueIdentifiable Clientes)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByClientes", Clientes.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByDescuentos(System.Int32 IdDescuento)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByDescuentos", IdDescuento);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByDescuentos(IUniqueIdentifiable Descuentos)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByDescuentos", Descuentos.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByEstadosCompra(System.Int32 IdEstadoCompra)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByEstadosCompra", IdEstadoCompra);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByEstadosCompra(IUniqueIdentifiable EstadosCompra)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Compras_GetByEstadosCompra", EstadosCompra.Identifier());
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





