
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 6/7/2022 - 04:37 p. m.
// This is a partial class file. The other one is ProvinciasMapper.cs
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
    public partial class ProvinciasMapper : BaseGateway<Provincias, ProvinciasList>, IGenericGateway
    {


        #region "Singleton"

        static ProvinciasMapper _instance;

        private ProvinciasMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ProvinciasMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ProvinciasMapper();
                else {
                    ProvinciasMapper inst = HttpContext.Current.Items["monaguaRules.ProvinciasMapperSingleton"] as ProvinciasMapper;
                    if (inst == null) {
                        inst = new ProvinciasMapper();
                        HttpContext.Current.Items.Add("monaguaRules.ProvinciasMapperSingleton", inst);
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
            
            string[] s ={"IdProvincia"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Provincias);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Provincias"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(ProvinciasMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Provincias entity)
        {
            
            IMappeableProvinciasObject Provincias = (IMappeableProvinciasObject)entity;
            Provincias.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
(reader.IsDBNull(2)) ? new System.Nullable<System.Int32>() : reader.GetInt32(2));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(Provincias entity)
        {

            IMappeableProvinciasObject Provincias = (IMappeableProvinciasObject)entity;
            return Provincias.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(Provincias entity)
        {

            IMappeableProvinciasObject Provincias = (IMappeableProvinciasObject)entity;
            return Provincias.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(Provincias entity)
        {

            IMappeableProvinciasObject Provincias = (IMappeableProvinciasObject)entity;
            return Provincias.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(Provincias entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableProvinciasObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(Provincias entity)
        {
            Objects.PaisesObject PaisesEntity = null; // Lazy load
            ((IMappeableProvincias)entity).CompleteEntity(PaisesEntity);
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
        /// Get a Provincias by execute a SQL Query Text
        /// </summary>
        public Provincias GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ProvinciasList by execute a SQL Query Text
        /// </summary>
        public ProvinciasList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public Provincias GetOne(System.Int32 IdProvincia)
        {
            return base.GetOne(new Provincias(IdProvincia));
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ProvinciasList GetByPaises(DbTransaction transaction, System.Int32 IdPais)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Provincias_GetByPaises", IdPais);
        }

        /// <summary>
        /// 
        /// </summary>
        public ProvinciasList GetByPaises(DbTransaction transaction, IUniqueIdentifiable Paises)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Provincias_GetByPaises", Paises.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ProvinciasList GetByPaises(System.Int32 IdPais)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Provincias_GetByPaises", IdPais);
        }

        /// <summary>
        /// 
        /// </summary>
        public ProvinciasList GetByPaises(IUniqueIdentifiable Paises)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Provincias_GetByPaises", Paises.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdProvincia)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Provincias_Delete", IdProvincia);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdProvincia)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Provincias_Delete", IdProvincia);
        }


        // Delete By Objects and Params
            



        

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByPaises(System.Int32 IdPais)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Provincias_DeleteByPaises", IdPais);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByPaises(DbTransaction transaction, System.Int32 IdPais)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Provincias_DeleteByPaises", IdPais);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByPaises(IUniqueIdentifiable Paises)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Provincias_DeleteByPaises", Paises.Identifier());
        }

        /// <summary>
        /// 
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

namespace monaguaRules.Wrappers
{
    /// <summary>
    /// 
    /// </summary>
    public class ProvinciasMapperWrapper
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
        public monaguaRules.Mappers.ProvinciasMapper Instance()
        {
            return monaguaRules.Mappers.ProvinciasMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a ProvinciasEntity by calling a Stored Procedure
        /// </summary>
        public Entities.Provincias GetOne(System.Int32 IdProvincia) {
            return Instance().GetOne( IdProvincia);
        }

        // GetBy Objects and Params
            

        

        /// <summary>
        /// Get a ProvinciasList by calling a Stored Procedure
        /// </summary>
        public Entities.ProvinciasList GetByPaises(System.Int32 IdPais)
        {
            return Instance().GetByPaises(IdPais);
        }

        /// <summary>
        /// Get a ProvinciasList by calling a Stored Procedure
        /// </summary>
        public Entities.ProvinciasList GetByPaises(IUniqueIdentifiable Paises)
        {
            return Instance().GetByPaises(Paises);
        }

    

       

        /// <summary>
        /// Delete children for Provincias
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, Provincias entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        

        /// <summary>
        /// Delete Provincias by Paises
        /// </summary>
        public void DeleteByPaises(System.Int32 IdPais)
        {
            Instance().DeleteByPaises(IdPais);
        }

        /// <summary>
        /// Delete Provincias by Paises
        /// </summary>
        public void DeleteByPaises(IUniqueIdentifiable Paises)
        {
            Instance().DeleteByPaises(Paises);
        }

    
        /// <summary>
        /// Delete Provincias 
        /// </summary>
        public void Delete(System.Int32 IdProvincia){
            Instance().Delete(IdProvincia);
        }

        /// <summary>
        /// Delete Provincias 
        /// </summary>
        public void Delete(Entities.Provincias entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save Provincias  
        /// </summary>
        public void Save(Entities.Provincias entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Provincias 
        /// </summary>
        public void Insert(Entities.Provincias entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll Provincias 
        /// </summary>
        public Entities.ProvinciasList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save Provincias 
        /// </summary>
        public void Save(System.Int32 IdProvincia, System.String Nombre, System.Int32 IdPais){
            Entities.Provincias entity = Instance().GetOne(IdProvincia);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdProvincia", IdProvincia));

            entity.Nombre = Nombre;
            entity.IdPais = IdPais;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Provincias
        /// </summary>
        public void Insert(System.Int32 IdProvincia, System.String Nombre, System.Int32 IdPais){
            Entities.Provincias entity = new Entities.Provincias();

            entity.IdProvincia = IdProvincia;
            entity.Nombre = Nombre;
            entity.IdPais = IdPais;
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
    public partial class ProvinciasLoader<T> : BaseLoader< T, Provincias, ObjectList<T>>, IGenericGateway where T : Provincias, new()
    {

        #region "Singleton"

        static ProvinciasLoader<T> _instance;

        private ProvinciasLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ProvinciasLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ProvinciasLoader<T>();
                else {
                    ProvinciasLoader<T> inst = HttpContext.Current.Items["monaguaRules.ProvinciasLoaderSingleton"] as ProvinciasLoader<T>;
                    if (inst == null) {
                        inst = new ProvinciasLoader<T>();
                        HttpContext.Current.Items.Add("monaguaRules.ProvinciasLoaderSingleton", inst);
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
            
            string[] s ={"IdProvincia"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Provincias);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Provincias"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Provincias entity)
        {
            
            IMappeableProvinciasObject Provincias = (IMappeableProvinciasObject)entity;
            Provincias.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
(reader.IsDBNull(2)) ? new System.Nullable<System.Int32>() : reader.GetInt32(2));
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
            Objects.PaisesObject PaisesEntity = null; // Lazy load
            ((IMappeableProvincias)entity).CompleteEntity(PaisesEntity);
        }


        



        /// <summary>
        /// Get a Provincias by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ProvinciasList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdProvincia)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Provincias_GetOne", IdProvincia);
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByPaises(DbTransaction transaction, System.Int32 IdPais)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Provincias_GetByPaises", IdPais);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByPaises(DbTransaction transaction, IUniqueIdentifiable Paises)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Provincias_GetByPaises", Paises.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByPaises(System.Int32 IdPais)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Provincias_GetByPaises", IdPais);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByPaises(IUniqueIdentifiable Paises)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Provincias_GetByPaises", Paises.Identifier());
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





