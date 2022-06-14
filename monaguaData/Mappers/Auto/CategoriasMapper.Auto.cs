
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 10/6/2022 - 05:08 p. m.
// This is a partial class file. The other one is CategoriasMapper.cs
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
    public partial class CategoriasMapper : BaseGateway<Categorias, CategoriasList>, IGenericGateway
    {


        #region "Singleton"

        static CategoriasMapper _instance;

        private CategoriasMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static CategoriasMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new CategoriasMapper();
                else {
                    CategoriasMapper inst = HttpContext.Current.Items["monaguaRules.CategoriasMapperSingleton"] as CategoriasMapper;
                    if (inst == null) {
                        inst = new CategoriasMapper();
                        HttpContext.Current.Items.Add("monaguaRules.CategoriasMapperSingleton", inst);
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
            
            string[] s ={"IdCategoria"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Categorias);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Categorias"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(CategoriasMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Categorias entity)
        {
            
            IMappeableCategoriasObject Categorias = (IMappeableCategoriasObject)entity;
            Categorias.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetBoolean(2));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(Categorias entity)
        {

            IMappeableCategoriasObject Categorias = (IMappeableCategoriasObject)entity;
            return Categorias.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(Categorias entity)
        {

            IMappeableCategoriasObject Categorias = (IMappeableCategoriasObject)entity;
            return Categorias.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(Categorias entity)
        {

            IMappeableCategoriasObject Categorias = (IMappeableCategoriasObject)entity;
            return Categorias.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(Categorias entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableCategoriasObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(Categorias entity)
        {
            
            ((IMappeableCategorias)entity).CompleteEntity();
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
        /// Get a Categorias by execute a SQL Query Text
        /// </summary>
        public Categorias GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a CategoriasList by execute a SQL Query Text
        /// </summary>
        public CategoriasList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public Categorias GetOne(System.Int32 IdCategoria)
        {
            return base.GetOne(new Categorias(IdCategoria));
        }


        // GetOne By Objects and Params
            


        


        

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdCategoria)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Categorias_Delete", IdCategoria);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdCategoria)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Categorias_Delete", IdCategoria);
        }


        // Delete By Objects and Params
            



        


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
    public class CategoriasMapperWrapper
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
        public monaguaRules.Mappers.CategoriasMapper Instance()
        {
            return monaguaRules.Mappers.CategoriasMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a CategoriasEntity by calling a Stored Procedure
        /// </summary>
        public Entities.Categorias GetOne(System.Int32 IdCategoria) {
            return Instance().GetOne( IdCategoria);
        }

        // GetBy Objects and Params
            

        

       

        /// <summary>
        /// Delete children for Categorias
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, Categorias entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        
        /// <summary>
        /// Delete Categorias 
        /// </summary>
        public void Delete(System.Int32 IdCategoria){
            Instance().Delete(IdCategoria);
        }

        /// <summary>
        /// Delete Categorias 
        /// </summary>
        public void Delete(Entities.Categorias entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save Categorias  
        /// </summary>
        public void Save(Entities.Categorias entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Categorias 
        /// </summary>
        public void Insert(Entities.Categorias entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll Categorias 
        /// </summary>
        public Entities.CategoriasList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save Categorias 
        /// </summary>
        public void Save(System.Int32 IdCategoria, System.String Nombre, System.Boolean Activa){
            Entities.Categorias entity = Instance().GetOne(IdCategoria);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdCategoria", IdCategoria));

            entity.Nombre = Nombre;
            entity.Activa = Activa;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Categorias
        /// </summary>
        public void Insert(System.String Nombre, System.Boolean Activa){
            Entities.Categorias entity = new Entities.Categorias();

            entity.Nombre = Nombre;
            entity.Activa = Activa;
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
    public partial class CategoriasLoader<T> : BaseLoader< T, Categorias, ObjectList<T>>, IGenericGateway where T : Categorias, new()
    {

        #region "Singleton"

        static CategoriasLoader<T> _instance;

        private CategoriasLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static CategoriasLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new CategoriasLoader<T>();
                else {
                    CategoriasLoader<T> inst = HttpContext.Current.Items["monaguaRules.CategoriasLoaderSingleton"] as CategoriasLoader<T>;
                    if (inst == null) {
                        inst = new CategoriasLoader<T>();
                        HttpContext.Current.Items.Add("monaguaRules.CategoriasLoaderSingleton", inst);
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
            
            string[] s ={"IdCategoria"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Categorias);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Categorias"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Categorias entity)
        {
            
            IMappeableCategoriasObject Categorias = (IMappeableCategoriasObject)entity;
            Categorias.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetBoolean(2));
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
            
            ((IMappeableCategorias)entity).CompleteEntity();
        }


        



        /// <summary>
        /// Get a Categorias by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a CategoriasList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdCategoria)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Categorias_GetOne", IdCategoria);
        }


        // GetOne By Objects and Params
            


        


        

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





