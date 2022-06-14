
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 10/6/2022 - 05:08 p. m.
// This is a partial class file. The other one is ClientesMapper.cs
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
    public partial class ClientesMapper : BaseGateway<Clientes, ClientesList>, IGenericGateway
    {


        #region "Singleton"

        static ClientesMapper _instance;

        private ClientesMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ClientesMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ClientesMapper();
                else {
                    ClientesMapper inst = HttpContext.Current.Items["monaguaRules.ClientesMapperSingleton"] as ClientesMapper;
                    if (inst == null) {
                        inst = new ClientesMapper();
                        HttpContext.Current.Items.Add("monaguaRules.ClientesMapperSingleton", inst);
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
            
            string[] s ={"IdCliente"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Clientes);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Clientes"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(ClientesMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Clientes entity)
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
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(Clientes entity)
        {

            IMappeableClientesObject Clientes = (IMappeableClientesObject)entity;
            return Clientes.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(Clientes entity)
        {

            IMappeableClientesObject Clientes = (IMappeableClientesObject)entity;
            return Clientes.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(Clientes entity)
        {

            IMappeableClientesObject Clientes = (IMappeableClientesObject)entity;
            return Clientes.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(Clientes entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableClientesObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(Clientes entity)
        {
            Entities.Localidades LocalidadesEntity = null; // Lazy load
Entities.Paises PaisesEntity = null; // Lazy load
Entities.Provincias ProvinciasEntity = null; // Lazy load
            ((IMappeableClientes)entity).CompleteEntity(LocalidadesEntity, PaisesEntity, ProvinciasEntity);
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
        /// Get a Clientes by execute a SQL Query Text
        /// </summary>
        public Clientes GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ClientesList by execute a SQL Query Text
        /// </summary>
        public ClientesList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public Clientes GetOne(System.Int32 IdCliente)
        {
            return base.GetOne(new Clientes(IdCliente));
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ClientesList GetByLocalidades(DbTransaction transaction, System.Int32 IdLocalidad)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByLocalidades", IdLocalidad);
        }

        /// <summary>
        /// 
        /// </summary>
        public ClientesList GetByLocalidades(DbTransaction transaction, IUniqueIdentifiable Localidades)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByLocalidades", Localidades.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ClientesList GetByPaises(DbTransaction transaction, System.Int32 IdPais)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByPaises", IdPais);
        }

        /// <summary>
        /// 
        /// </summary>
        public ClientesList GetByPaises(DbTransaction transaction, IUniqueIdentifiable Paises)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByPaises", Paises.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ClientesList GetByProvincias(DbTransaction transaction, System.Int32 IdProvincia)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByProvincias", IdProvincia);
        }

        /// <summary>
        /// 
        /// </summary>
        public ClientesList GetByProvincias(DbTransaction transaction, IUniqueIdentifiable Provincias)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByProvincias", Provincias.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ClientesList GetByLocalidades(System.Int32 IdLocalidad)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByLocalidades", IdLocalidad);
        }

        /// <summary>
        /// 
        /// </summary>
        public ClientesList GetByLocalidades(IUniqueIdentifiable Localidades)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByLocalidades", Localidades.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ClientesList GetByPaises(System.Int32 IdPais)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByPaises", IdPais);
        }

        /// <summary>
        /// 
        /// </summary>
        public ClientesList GetByPaises(IUniqueIdentifiable Paises)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByPaises", Paises.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ClientesList GetByProvincias(System.Int32 IdProvincia)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByProvincias", IdProvincia);
        }

        /// <summary>
        /// 
        /// </summary>
        public ClientesList GetByProvincias(IUniqueIdentifiable Provincias)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByProvincias", Provincias.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdCliente)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_Delete", IdCliente);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdCliente)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_Delete", IdCliente);
        }


        // Delete By Objects and Params
            



        

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByLocalidades(System.Int32 IdLocalidad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_DeleteByLocalidades", IdLocalidad);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByLocalidades(DbTransaction transaction, System.Int32 IdLocalidad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_DeleteByLocalidades", IdLocalidad);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByLocalidades(IUniqueIdentifiable Localidades)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_DeleteByLocalidades", Localidades.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByLocalidades(DbTransaction transaction, IUniqueIdentifiable Localidades)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_DeleteByLocalidades", Localidades.Identifier());
        }


    

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByPaises(System.Int32 IdPais)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_DeleteByPaises", IdPais);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByPaises(DbTransaction transaction, System.Int32 IdPais)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_DeleteByPaises", IdPais);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByPaises(IUniqueIdentifiable Paises)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_DeleteByPaises", Paises.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByPaises(DbTransaction transaction, IUniqueIdentifiable Paises)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_DeleteByPaises", Paises.Identifier());
        }


    

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByProvincias(System.Int32 IdProvincia)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_DeleteByProvincias", IdProvincia);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByProvincias(DbTransaction transaction, System.Int32 IdProvincia)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_DeleteByProvincias", IdProvincia);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByProvincias(IUniqueIdentifiable Provincias)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Clientes_DeleteByProvincias", Provincias.Identifier());
        }

        /// <summary>
        /// 
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

namespace monaguaRules.Wrappers
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientesMapperWrapper
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
        public monaguaRules.Mappers.ClientesMapper Instance()
        {
            return monaguaRules.Mappers.ClientesMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a ClientesEntity by calling a Stored Procedure
        /// </summary>
        public Entities.Clientes GetOne(System.Int32 IdCliente) {
            return Instance().GetOne( IdCliente);
        }

        // GetBy Objects and Params
            

        

        /// <summary>
        /// Get a ClientesList by calling a Stored Procedure
        /// </summary>
        public Entities.ClientesList GetByLocalidades(System.Int32 IdLocalidad)
        {
            return Instance().GetByLocalidades(IdLocalidad);
        }

        /// <summary>
        /// Get a ClientesList by calling a Stored Procedure
        /// </summary>
        public Entities.ClientesList GetByLocalidades(IUniqueIdentifiable Localidades)
        {
            return Instance().GetByLocalidades(Localidades);
        }

    

        /// <summary>
        /// Get a ClientesList by calling a Stored Procedure
        /// </summary>
        public Entities.ClientesList GetByPaises(System.Int32 IdPais)
        {
            return Instance().GetByPaises(IdPais);
        }

        /// <summary>
        /// Get a ClientesList by calling a Stored Procedure
        /// </summary>
        public Entities.ClientesList GetByPaises(IUniqueIdentifiable Paises)
        {
            return Instance().GetByPaises(Paises);
        }

    

        /// <summary>
        /// Get a ClientesList by calling a Stored Procedure
        /// </summary>
        public Entities.ClientesList GetByProvincias(System.Int32 IdProvincia)
        {
            return Instance().GetByProvincias(IdProvincia);
        }

        /// <summary>
        /// Get a ClientesList by calling a Stored Procedure
        /// </summary>
        public Entities.ClientesList GetByProvincias(IUniqueIdentifiable Provincias)
        {
            return Instance().GetByProvincias(Provincias);
        }

    

       

        /// <summary>
        /// Delete children for Clientes
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, Clientes entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        

        /// <summary>
        /// Delete Clientes by Localidades
        /// </summary>
        public void DeleteByLocalidades(System.Int32 IdLocalidad)
        {
            Instance().DeleteByLocalidades(IdLocalidad);
        }

        /// <summary>
        /// Delete Clientes by Localidades
        /// </summary>
        public void DeleteByLocalidades(IUniqueIdentifiable Localidades)
        {
            Instance().DeleteByLocalidades(Localidades);
        }

    

        /// <summary>
        /// Delete Clientes by Paises
        /// </summary>
        public void DeleteByPaises(System.Int32 IdPais)
        {
            Instance().DeleteByPaises(IdPais);
        }

        /// <summary>
        /// Delete Clientes by Paises
        /// </summary>
        public void DeleteByPaises(IUniqueIdentifiable Paises)
        {
            Instance().DeleteByPaises(Paises);
        }

    

        /// <summary>
        /// Delete Clientes by Provincias
        /// </summary>
        public void DeleteByProvincias(System.Int32 IdProvincia)
        {
            Instance().DeleteByProvincias(IdProvincia);
        }

        /// <summary>
        /// Delete Clientes by Provincias
        /// </summary>
        public void DeleteByProvincias(IUniqueIdentifiable Provincias)
        {
            Instance().DeleteByProvincias(Provincias);
        }

    
        /// <summary>
        /// Delete Clientes 
        /// </summary>
        public void Delete(System.Int32 IdCliente){
            Instance().Delete(IdCliente);
        }

        /// <summary>
        /// Delete Clientes 
        /// </summary>
        public void Delete(Entities.Clientes entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save Clientes  
        /// </summary>
        public void Save(Entities.Clientes entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Clientes 
        /// </summary>
        public void Insert(Entities.Clientes entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll Clientes 
        /// </summary>
        public Entities.ClientesList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save Clientes 
        /// </summary>
        public void Save(System.Int32 IdCliente, System.DateTime FechaRegistro, System.String Nombre, System.String Apellido, System.String Email, System.DateTime FechaNacimiento, System.Boolean Novedades, System.Boolean Politicas, System.Int32 IdPais, System.Int32 IdProvincia, System.Int32 IdLocalidad, System.String Sexo, System.Boolean Activo, System.String Telefono){
            Entities.Clientes entity = Instance().GetOne(IdCliente);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdCliente", IdCliente));

            entity.FechaRegistro = FechaRegistro;
            entity.Nombre = Nombre;
            entity.Apellido = Apellido;
            entity.Email = Email;
            entity.FechaNacimiento = FechaNacimiento;
            entity.Novedades = Novedades;
            entity.Politicas = Politicas;
            entity.IdPais = IdPais;
            entity.IdProvincia = IdProvincia;
            entity.IdLocalidad = IdLocalidad;
            entity.Sexo = Sexo;
            entity.Activo = Activo;
            entity.Telefono = Telefono;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Clientes
        /// </summary>
        public void Insert(System.DateTime FechaRegistro, System.String Nombre, System.String Apellido, System.String Email, System.DateTime FechaNacimiento, System.Boolean Novedades, System.Boolean Politicas, System.Int32 IdPais, System.Int32 IdProvincia, System.Int32 IdLocalidad, System.String Sexo, System.Boolean Activo, System.String Telefono){
            Entities.Clientes entity = new Entities.Clientes();

            entity.FechaRegistro = FechaRegistro;
            entity.Nombre = Nombre;
            entity.Apellido = Apellido;
            entity.Email = Email;
            entity.FechaNacimiento = FechaNacimiento;
            entity.Novedades = Novedades;
            entity.Politicas = Politicas;
            entity.IdPais = IdPais;
            entity.IdProvincia = IdProvincia;
            entity.IdLocalidad = IdLocalidad;
            entity.Sexo = Sexo;
            entity.Activo = Activo;
            entity.Telefono = Telefono;
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
    public partial class ClientesLoader<T> : BaseLoader< T, Clientes, ObjectList<T>>, IGenericGateway where T : Clientes, new()
    {

        #region "Singleton"

        static ClientesLoader<T> _instance;

        private ClientesLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ClientesLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ClientesLoader<T>();
                else {
                    ClientesLoader<T> inst = HttpContext.Current.Items["monaguaRules.ClientesLoaderSingleton"] as ClientesLoader<T>;
                    if (inst == null) {
                        inst = new ClientesLoader<T>();
                        HttpContext.Current.Items.Add("monaguaRules.ClientesLoaderSingleton", inst);
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
            
            string[] s ={"IdCliente"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Clientes);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Clientes"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Clientes entity)
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
            Entities.Localidades LocalidadesEntity = null; // Lazy load
Entities.Paises PaisesEntity = null; // Lazy load
Entities.Provincias ProvinciasEntity = null; // Lazy load
            ((IMappeableClientes)entity).CompleteEntity(LocalidadesEntity, PaisesEntity, ProvinciasEntity);
        }


        



        /// <summary>
        /// Get a Clientes by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ClientesList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdCliente)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetOne", IdCliente);
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByLocalidades(DbTransaction transaction, System.Int32 IdLocalidad)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByLocalidades", IdLocalidad);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByLocalidades(DbTransaction transaction, IUniqueIdentifiable Localidades)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByLocalidades", Localidades.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByPaises(DbTransaction transaction, System.Int32 IdPais)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByPaises", IdPais);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByPaises(DbTransaction transaction, IUniqueIdentifiable Paises)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByPaises", Paises.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByProvincias(DbTransaction transaction, System.Int32 IdProvincia)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByProvincias", IdProvincia);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByProvincias(DbTransaction transaction, IUniqueIdentifiable Provincias)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Clientes_GetByProvincias", Provincias.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByLocalidades(System.Int32 IdLocalidad)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByLocalidades", IdLocalidad);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByLocalidades(IUniqueIdentifiable Localidades)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByLocalidades", Localidades.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByPaises(System.Int32 IdPais)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByPaises", IdPais);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByPaises(IUniqueIdentifiable Paises)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByPaises", Paises.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByProvincias(System.Int32 IdProvincia)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByProvincias", IdProvincia);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByProvincias(IUniqueIdentifiable Provincias)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Clientes_GetByProvincias", Provincias.Identifier());
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





