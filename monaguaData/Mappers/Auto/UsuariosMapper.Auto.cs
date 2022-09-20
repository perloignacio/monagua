
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 15/09/2022 - 16:08
// This is a partial class file. The other one is UsuariosMapper.cs
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
    public partial class UsuariosMapper : BaseGateway<Usuarios, UsuariosList>, IGenericGateway
    {


        #region "Singleton"

        static UsuariosMapper _instance;

        private UsuariosMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static UsuariosMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new UsuariosMapper();
                else {
                    UsuariosMapper inst = HttpContext.Current.Items["monaguaRules.UsuariosMapperSingleton"] as UsuariosMapper;
                    if (inst == null) {
                        inst = new UsuariosMapper();
                        HttpContext.Current.Items.Add("monaguaRules.UsuariosMapperSingleton", inst);
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
            
            string[] s ={"IdUsuario"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Usuarios);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Usuarios"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(UsuariosMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Usuarios entity)
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
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(Usuarios entity)
        {

            IMappeableUsuariosObject Usuarios = (IMappeableUsuariosObject)entity;
            return Usuarios.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(Usuarios entity)
        {

            IMappeableUsuariosObject Usuarios = (IMappeableUsuariosObject)entity;
            return Usuarios.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(Usuarios entity)
        {

            IMappeableUsuariosObject Usuarios = (IMappeableUsuariosObject)entity;
            return Usuarios.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(Usuarios entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableUsuariosObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(Usuarios entity)
        {
            Entities.Clientes ClientesEntity = null; // Lazy load
Entities.Prestadores PrestadoresEntity = null; // Lazy load
            ((IMappeableUsuarios)entity).CompleteEntity(ClientesEntity, PrestadoresEntity);
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
        /// Get a Usuarios by execute a SQL Query Text
        /// </summary>
        public Usuarios GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a UsuariosList by execute a SQL Query Text
        /// </summary>
        public UsuariosList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public Usuarios GetOne(System.Int32 IdUsuario)
        {
            return base.GetOne(new Usuarios(IdUsuario));
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public UsuariosList GetByClientes(DbTransaction transaction, System.Int32 IdCliente)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_GetByClientes", IdCliente);
        }

        /// <summary>
        /// 
        /// </summary>
        public UsuariosList GetByClientes(DbTransaction transaction, IUniqueIdentifiable Clientes)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_GetByClientes", Clientes.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public UsuariosList GetByPrestadores(DbTransaction transaction, System.Int32 IdPrestador)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_GetByPrestadores", IdPrestador);
        }

        /// <summary>
        /// 
        /// </summary>
        public UsuariosList GetByPrestadores(DbTransaction transaction, IUniqueIdentifiable Prestadores)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_GetByPrestadores", Prestadores.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public UsuariosList GetByClientes(System.Int32 IdCliente)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_GetByClientes", IdCliente);
        }

        /// <summary>
        /// 
        /// </summary>
        public UsuariosList GetByClientes(IUniqueIdentifiable Clientes)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_GetByClientes", Clientes.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public UsuariosList GetByPrestadores(System.Int32 IdPrestador)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_GetByPrestadores", IdPrestador);
        }

        /// <summary>
        /// 
        /// </summary>
        public UsuariosList GetByPrestadores(IUniqueIdentifiable Prestadores)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_GetByPrestadores", Prestadores.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdUsuario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Usuarios_Delete", IdUsuario);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdUsuario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_Delete", IdUsuario);
        }


        // Delete By Objects and Params
            



        

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByClientes(System.Int32 IdCliente)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Usuarios_DeleteByClientes", IdCliente);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByClientes(DbTransaction transaction, System.Int32 IdCliente)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_DeleteByClientes", IdCliente);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByClientes(IUniqueIdentifiable Clientes)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Usuarios_DeleteByClientes", Clientes.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByClientes(DbTransaction transaction, IUniqueIdentifiable Clientes)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_DeleteByClientes", Clientes.Identifier());
        }


    

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByPrestadores(System.Int32 IdPrestador)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Usuarios_DeleteByPrestadores", IdPrestador);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByPrestadores(DbTransaction transaction, System.Int32 IdPrestador)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_DeleteByPrestadores", IdPrestador);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByPrestadores(IUniqueIdentifiable Prestadores)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Usuarios_DeleteByPrestadores", Prestadores.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByPrestadores(DbTransaction transaction, IUniqueIdentifiable Prestadores)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_DeleteByPrestadores", Prestadores.Identifier());
        }


    


        //Database Queries 
        
            

        /// <summary>
        /// 
        /// </summary>
        public Usuarios GetByUsuario(System.String usuario) {
            
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_GetByUsuario" , usuario);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public Usuarios GetByUsuario(DbTransaction transaction , System.String usuario) {
            
            return base.GetObjectByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_GetByUsuario" , usuario);
            
        }


        
            

        /// <summary>
        /// 
        /// </summary>
        public Usuarios Login(System.String usuario, System.String contra) {
            
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_Login" , usuario, contra);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public Usuarios Login(DbTransaction transaction , System.String usuario, System.String contra) {
            
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

namespace monaguaRules.Wrappers
{
    /// <summary>
    /// 
    /// </summary>
    public class UsuariosMapperWrapper
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
        public monaguaRules.Mappers.UsuariosMapper Instance()
        {
            return monaguaRules.Mappers.UsuariosMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a UsuariosEntity by calling a Stored Procedure
        /// </summary>
        public Entities.Usuarios GetOne(System.Int32 IdUsuario) {
            return Instance().GetOne( IdUsuario);
        }

        // GetBy Objects and Params
            

        

        /// <summary>
        /// Get a UsuariosList by calling a Stored Procedure
        /// </summary>
        public Entities.UsuariosList GetByClientes(System.Int32 IdCliente)
        {
            return Instance().GetByClientes(IdCliente);
        }

        /// <summary>
        /// Get a UsuariosList by calling a Stored Procedure
        /// </summary>
        public Entities.UsuariosList GetByClientes(IUniqueIdentifiable Clientes)
        {
            return Instance().GetByClientes(Clientes);
        }

    

        /// <summary>
        /// Get a UsuariosList by calling a Stored Procedure
        /// </summary>
        public Entities.UsuariosList GetByPrestadores(System.Int32 IdPrestador)
        {
            return Instance().GetByPrestadores(IdPrestador);
        }

        /// <summary>
        /// Get a UsuariosList by calling a Stored Procedure
        /// </summary>
        public Entities.UsuariosList GetByPrestadores(IUniqueIdentifiable Prestadores)
        {
            return Instance().GetByPrestadores(Prestadores);
        }

    

       

        /// <summary>
        /// Delete children for Usuarios
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, Usuarios entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        

        /// <summary>
        /// Delete Usuarios by Clientes
        /// </summary>
        public void DeleteByClientes(System.Int32 IdCliente)
        {
            Instance().DeleteByClientes(IdCliente);
        }

        /// <summary>
        /// Delete Usuarios by Clientes
        /// </summary>
        public void DeleteByClientes(IUniqueIdentifiable Clientes)
        {
            Instance().DeleteByClientes(Clientes);
        }

    

        /// <summary>
        /// Delete Usuarios by Prestadores
        /// </summary>
        public void DeleteByPrestadores(System.Int32 IdPrestador)
        {
            Instance().DeleteByPrestadores(IdPrestador);
        }

        /// <summary>
        /// Delete Usuarios by Prestadores
        /// </summary>
        public void DeleteByPrestadores(IUniqueIdentifiable Prestadores)
        {
            Instance().DeleteByPrestadores(Prestadores);
        }

    
        /// <summary>
        /// Delete Usuarios 
        /// </summary>
        public void Delete(System.Int32 IdUsuario){
            Instance().Delete(IdUsuario);
        }

        /// <summary>
        /// Delete Usuarios 
        /// </summary>
        public void Delete(Entities.Usuarios entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save Usuarios  
        /// </summary>
        public void Save(Entities.Usuarios entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Usuarios 
        /// </summary>
        public void Insert(Entities.Usuarios entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll Usuarios 
        /// </summary>
        public Entities.UsuariosList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save Usuarios 
        /// </summary>
        public void Save(System.Int32 IdUsuario, System.String Usuario, System.String Contra, System.String Nombre, System.String Apellido, System.String Email, System.Int32 IdCliente, System.Int32 IdPrestador, System.Boolean Activo, System.String Telefono){
            Entities.Usuarios entity = Instance().GetOne(IdUsuario);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdUsuario", IdUsuario));

            entity.Usuario = Usuario;
            entity.Contra = Contra;
            entity.Nombre = Nombre;
            entity.Apellido = Apellido;
            entity.Email = Email;
            entity.IdCliente = IdCliente;
            entity.IdPrestador = IdPrestador;
            entity.Activo = Activo;
            entity.Telefono = Telefono;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Usuarios
        /// </summary>
        public void Insert(System.String Usuario, System.String Contra, System.String Nombre, System.String Apellido, System.String Email, System.Int32 IdCliente, System.Int32 IdPrestador, System.Boolean Activo, System.String Telefono){
            Entities.Usuarios entity = new Entities.Usuarios();

            entity.Usuario = Usuario;
            entity.Contra = Contra;
            entity.Nombre = Nombre;
            entity.Apellido = Apellido;
            entity.Email = Email;
            entity.IdCliente = IdCliente;
            entity.IdPrestador = IdPrestador;
            entity.Activo = Activo;
            entity.Telefono = Telefono;
            Instance().Insert(entity);
        }


        //Database Queries 
        
            
        /// <summary>
        /// 
        /// </summary>
        public Usuarios GetByUsuario(System.String usuario) {
            
                return Instance().GetByUsuario( usuario);
        }


        
            
        /// <summary>
        /// 
        /// </summary>
        public Usuarios Login(System.String usuario, System.String contra) {
            
                return Instance().Login( usuario, contra);
        }


        


    }
}





namespace monaguaRules.Loaders
{

    /// <summary>
    /// 
    /// </summary>
    public partial class UsuariosLoader<T> : BaseLoader< T, Usuarios, ObjectList<T>>, IGenericGateway where T : Usuarios, new()
    {

        #region "Singleton"

        static UsuariosLoader<T> _instance;

        private UsuariosLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static UsuariosLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new UsuariosLoader<T>();
                else {
                    UsuariosLoader<T> inst = HttpContext.Current.Items["monaguaRules.UsuariosLoaderSingleton"] as UsuariosLoader<T>;
                    if (inst == null) {
                        inst = new UsuariosLoader<T>();
                        HttpContext.Current.Items.Add("monaguaRules.UsuariosLoaderSingleton", inst);
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
            
            string[] s ={"IdUsuario"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Usuarios);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Usuarios"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Usuarios entity)
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
Entities.Prestadores PrestadoresEntity = null; // Lazy load
            ((IMappeableUsuarios)entity).CompleteEntity(ClientesEntity, PrestadoresEntity);
        }


        



        /// <summary>
        /// Get a Usuarios by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a UsuariosList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdUsuario)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_GetOne", IdUsuario);
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByClientes(DbTransaction transaction, System.Int32 IdCliente)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_GetByClientes", IdCliente);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByClientes(DbTransaction transaction, IUniqueIdentifiable Clientes)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_GetByClientes", Clientes.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByPrestadores(DbTransaction transaction, System.Int32 IdPrestador)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_GetByPrestadores", IdPrestador);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByPrestadores(DbTransaction transaction, IUniqueIdentifiable Prestadores)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_GetByPrestadores", Prestadores.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByClientes(System.Int32 IdCliente)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_GetByClientes", IdCliente);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByClientes(IUniqueIdentifiable Clientes)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_GetByClientes", Clientes.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByPrestadores(System.Int32 IdPrestador)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_GetByPrestadores", IdPrestador);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByPrestadores(IUniqueIdentifiable Prestadores)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_GetByPrestadores", Prestadores.Identifier());
        }

    

        //Database Queries 
        
            
        /// <summary>
        /// 
        /// </summary>
        public T GetByUsuario(System.String usuario) {
            
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_GetByUsuario" , usuario);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public T GetByUsuario(DbTransaction transaction , System.String usuario) {
            
            return base.GetObjectByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Usuarios_GetByUsuario" , usuario);
            
        }

        
            
        /// <summary>
        /// 
        /// </summary>
        public T Login(System.String usuario, System.String contra) {
            
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Usuarios_Login" , usuario, contra);
            
        }

        
        /// <summary>
        /// 
        /// </summary>
        public T Login(DbTransaction transaction , System.String usuario, System.String contra) {
            
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





