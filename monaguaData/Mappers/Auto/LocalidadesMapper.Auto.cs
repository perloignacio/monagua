
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 18/7/2022 - 04:08 p. m.
// This is a partial class file. The other one is LocalidadesMapper.cs
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
    public partial class LocalidadesMapper : BaseGateway<Localidades, LocalidadesList>, IGenericGateway
    {


        #region "Singleton"

        static LocalidadesMapper _instance;

        private LocalidadesMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static LocalidadesMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new LocalidadesMapper();
                else {
                    LocalidadesMapper inst = HttpContext.Current.Items["monaguaRules.LocalidadesMapperSingleton"] as LocalidadesMapper;
                    if (inst == null) {
                        inst = new LocalidadesMapper();
                        HttpContext.Current.Items.Add("monaguaRules.LocalidadesMapperSingleton", inst);
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
            
            string[] s ={"IdLocalidad"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Localidades);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Localidades"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(LocalidadesMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Localidades entity)
        {
            
            IMappeableLocalidadesObject Localidades = (IMappeableLocalidadesObject)entity;
            Localidades.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetString(2),
reader.GetInt32(3));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(Localidades entity)
        {

            IMappeableLocalidadesObject Localidades = (IMappeableLocalidadesObject)entity;
            return Localidades.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(Localidades entity)
        {

            IMappeableLocalidadesObject Localidades = (IMappeableLocalidadesObject)entity;
            return Localidades.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(Localidades entity)
        {

            IMappeableLocalidadesObject Localidades = (IMappeableLocalidadesObject)entity;
            return Localidades.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(Localidades entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableLocalidadesObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(Localidades entity)
        {
            Entities.Provincias ProvinciasEntity = null; // Lazy load
            ((IMappeableLocalidades)entity).CompleteEntity(ProvinciasEntity);
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
        /// Get a Localidades by execute a SQL Query Text
        /// </summary>
        public Localidades GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a LocalidadesList by execute a SQL Query Text
        /// </summary>
        public LocalidadesList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public Localidades GetOne(System.Int32 IdLocalidad)
        {
            return base.GetOne(new Localidades(IdLocalidad));
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public LocalidadesList GetByProvincias(DbTransaction transaction, System.Int32 IdProvincia)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Localidades_GetByProvincias", IdProvincia);
        }

        /// <summary>
        /// 
        /// </summary>
        public LocalidadesList GetByProvincias(DbTransaction transaction, IUniqueIdentifiable Provincias)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Localidades_GetByProvincias", Provincias.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public LocalidadesList GetByProvincias(System.Int32 IdProvincia)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Localidades_GetByProvincias", IdProvincia);
        }

        /// <summary>
        /// 
        /// </summary>
        public LocalidadesList GetByProvincias(IUniqueIdentifiable Provincias)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Localidades_GetByProvincias", Provincias.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdLocalidad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Localidades_Delete", IdLocalidad);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdLocalidad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Localidades_Delete", IdLocalidad);
        }


        // Delete By Objects and Params
            



        

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByProvincias(System.Int32 IdProvincia)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Localidades_DeleteByProvincias", IdProvincia);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByProvincias(DbTransaction transaction, System.Int32 IdProvincia)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Localidades_DeleteByProvincias", IdProvincia);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByProvincias(IUniqueIdentifiable Provincias)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Localidades_DeleteByProvincias", Provincias.Identifier());
        }

        /// <summary>
        /// 
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

namespace monaguaRules.Wrappers
{
    /// <summary>
    /// 
    /// </summary>
    public class LocalidadesMapperWrapper
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
        public monaguaRules.Mappers.LocalidadesMapper Instance()
        {
            return monaguaRules.Mappers.LocalidadesMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a LocalidadesEntity by calling a Stored Procedure
        /// </summary>
        public Entities.Localidades GetOne(System.Int32 IdLocalidad) {
            return Instance().GetOne( IdLocalidad);
        }

        // GetBy Objects and Params
            

        

        /// <summary>
        /// Get a LocalidadesList by calling a Stored Procedure
        /// </summary>
        public Entities.LocalidadesList GetByProvincias(System.Int32 IdProvincia)
        {
            return Instance().GetByProvincias(IdProvincia);
        }

        /// <summary>
        /// Get a LocalidadesList by calling a Stored Procedure
        /// </summary>
        public Entities.LocalidadesList GetByProvincias(IUniqueIdentifiable Provincias)
        {
            return Instance().GetByProvincias(Provincias);
        }

    

       

        /// <summary>
        /// Delete children for Localidades
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, Localidades entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        

        /// <summary>
        /// Delete Localidades by Provincias
        /// </summary>
        public void DeleteByProvincias(System.Int32 IdProvincia)
        {
            Instance().DeleteByProvincias(IdProvincia);
        }

        /// <summary>
        /// Delete Localidades by Provincias
        /// </summary>
        public void DeleteByProvincias(IUniqueIdentifiable Provincias)
        {
            Instance().DeleteByProvincias(Provincias);
        }

    
        /// <summary>
        /// Delete Localidades 
        /// </summary>
        public void Delete(System.Int32 IdLocalidad){
            Instance().Delete(IdLocalidad);
        }

        /// <summary>
        /// Delete Localidades 
        /// </summary>
        public void Delete(Entities.Localidades entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save Localidades  
        /// </summary>
        public void Save(Entities.Localidades entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Localidades 
        /// </summary>
        public void Insert(Entities.Localidades entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll Localidades 
        /// </summary>
        public Entities.LocalidadesList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save Localidades 
        /// </summary>
        public void Save(System.Int32 IdLocalidad, System.String Nombre, System.String Cp, System.Int32 IdProvincia){
            Entities.Localidades entity = Instance().GetOne(IdLocalidad);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdLocalidad", IdLocalidad));

            entity.Nombre = Nombre;
            entity.Cp = Cp;
            entity.IdProvincia = IdProvincia;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Localidades
        /// </summary>
        public void Insert(System.Int32 IdLocalidad, System.String Nombre, System.String Cp, System.Int32 IdProvincia){
            Entities.Localidades entity = new Entities.Localidades();

            entity.IdLocalidad = IdLocalidad;
            entity.Nombre = Nombre;
            entity.Cp = Cp;
            entity.IdProvincia = IdProvincia;
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
    public partial class LocalidadesLoader<T> : BaseLoader< T, Localidades, ObjectList<T>>, IGenericGateway where T : Localidades, new()
    {

        #region "Singleton"

        static LocalidadesLoader<T> _instance;

        private LocalidadesLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static LocalidadesLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new LocalidadesLoader<T>();
                else {
                    LocalidadesLoader<T> inst = HttpContext.Current.Items["monaguaRules.LocalidadesLoaderSingleton"] as LocalidadesLoader<T>;
                    if (inst == null) {
                        inst = new LocalidadesLoader<T>();
                        HttpContext.Current.Items.Add("monaguaRules.LocalidadesLoaderSingleton", inst);
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
            
            string[] s ={"IdLocalidad"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Localidades);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Localidades"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Localidades entity)
        {
            
            IMappeableLocalidadesObject Localidades = (IMappeableLocalidadesObject)entity;
            Localidades.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetString(2),
reader.GetInt32(3));
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
            Entities.Provincias ProvinciasEntity = null; // Lazy load
            ((IMappeableLocalidades)entity).CompleteEntity(ProvinciasEntity);
        }


        



        /// <summary>
        /// Get a Localidades by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a LocalidadesList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdLocalidad)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Localidades_GetOne", IdLocalidad);
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByProvincias(DbTransaction transaction, System.Int32 IdProvincia)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Localidades_GetByProvincias", IdProvincia);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByProvincias(DbTransaction transaction, IUniqueIdentifiable Provincias)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Localidades_GetByProvincias", Provincias.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByProvincias(System.Int32 IdProvincia)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Localidades_GetByProvincias", IdProvincia);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByProvincias(IUniqueIdentifiable Provincias)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Localidades_GetByProvincias", Provincias.Identifier());
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





