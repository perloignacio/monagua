
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 6/7/2022 - 04:37 p. m.
// This is a partial class file. The other one is PaisesMapper.cs
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
    public partial class PaisesMapper : BaseGateway<Paises, PaisesList>, IGenericGateway
    {


        #region "Singleton"

        static PaisesMapper _instance;

        private PaisesMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static PaisesMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new PaisesMapper();
                else {
                    PaisesMapper inst = HttpContext.Current.Items["monaguaRules.PaisesMapperSingleton"] as PaisesMapper;
                    if (inst == null) {
                        inst = new PaisesMapper();
                        HttpContext.Current.Items.Add("monaguaRules.PaisesMapperSingleton", inst);
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
            
            string[] s ={"IdPais"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Paises);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Paises"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(PaisesMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Paises entity)
        {
            
            IMappeablePaisesObject Paises = (IMappeablePaisesObject)entity;
            Paises.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(Paises entity)
        {

            IMappeablePaisesObject Paises = (IMappeablePaisesObject)entity;
            return Paises.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(Paises entity)
        {

            IMappeablePaisesObject Paises = (IMappeablePaisesObject)entity;
            return Paises.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(Paises entity)
        {

            IMappeablePaisesObject Paises = (IMappeablePaisesObject)entity;
            return Paises.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(Paises entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeablePaisesObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(Paises entity)
        {
            
            ((IMappeablePaises)entity).CompleteEntity();
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
        /// Get a Paises by execute a SQL Query Text
        /// </summary>
        public Paises GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a PaisesList by execute a SQL Query Text
        /// </summary>
        public PaisesList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public Paises GetOne(System.Int32 IdPais)
        {
            return base.GetOne(new Paises(IdPais));
        }


        // GetOne By Objects and Params
            


        


        

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdPais)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Paises_Delete", IdPais);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdPais)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Paises_Delete", IdPais);
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
    public class PaisesMapperWrapper
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
        public monaguaRules.Mappers.PaisesMapper Instance()
        {
            return monaguaRules.Mappers.PaisesMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a PaisesEntity by calling a Stored Procedure
        /// </summary>
        public Entities.Paises GetOne(System.Int32 IdPais) {
            return Instance().GetOne( IdPais);
        }

        // GetBy Objects and Params
            

        

       

        /// <summary>
        /// Delete children for Paises
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, Paises entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        
        /// <summary>
        /// Delete Paises 
        /// </summary>
        public void Delete(System.Int32 IdPais){
            Instance().Delete(IdPais);
        }

        /// <summary>
        /// Delete Paises 
        /// </summary>
        public void Delete(Entities.Paises entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save Paises  
        /// </summary>
        public void Save(Entities.Paises entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Paises 
        /// </summary>
        public void Insert(Entities.Paises entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll Paises 
        /// </summary>
        public Entities.PaisesList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save Paises 
        /// </summary>
        public void Save(System.Int32 IdPais, System.String Nombre){
            Entities.Paises entity = Instance().GetOne(IdPais);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdPais", IdPais));

            entity.Nombre = Nombre;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Paises
        /// </summary>
        public void Insert(System.Int32 IdPais, System.String Nombre){
            Entities.Paises entity = new Entities.Paises();

            entity.IdPais = IdPais;
            entity.Nombre = Nombre;
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
    public partial class PaisesLoader<T> : BaseLoader< T, Paises, ObjectList<T>>, IGenericGateway where T : Paises, new()
    {

        #region "Singleton"

        static PaisesLoader<T> _instance;

        private PaisesLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static PaisesLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new PaisesLoader<T>();
                else {
                    PaisesLoader<T> inst = HttpContext.Current.Items["monaguaRules.PaisesLoaderSingleton"] as PaisesLoader<T>;
                    if (inst == null) {
                        inst = new PaisesLoader<T>();
                        HttpContext.Current.Items.Add("monaguaRules.PaisesLoaderSingleton", inst);
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
            
            string[] s ={"IdPais"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Paises);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Paises"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Paises entity)
        {
            
            IMappeablePaisesObject Paises = (IMappeablePaisesObject)entity;
            Paises.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1));
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
            
            ((IMappeablePaises)entity).CompleteEntity();
        }


        



        /// <summary>
        /// Get a Paises by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a PaisesList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdPais)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Paises_GetOne", IdPais);
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





