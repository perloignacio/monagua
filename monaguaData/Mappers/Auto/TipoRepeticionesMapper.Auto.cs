
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 22/6/2022 - 05:03 p. m.
// This is a partial class file. The other one is TipoRepeticionesMapper.cs
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
    public partial class TipoRepeticionesMapper : BaseGateway<TipoRepeticiones, TipoRepeticionesList>, IGenericGateway
    {


        #region "Singleton"

        static TipoRepeticionesMapper _instance;

        private TipoRepeticionesMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static TipoRepeticionesMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new TipoRepeticionesMapper();
                else {
                    TipoRepeticionesMapper inst = HttpContext.Current.Items["monaguaRules.TipoRepeticionesMapperSingleton"] as TipoRepeticionesMapper;
                    if (inst == null) {
                        inst = new TipoRepeticionesMapper();
                        HttpContext.Current.Items.Add("monaguaRules.TipoRepeticionesMapperSingleton", inst);
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
            
            string[] s ={"IdTipoRepeticion"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(TipoRepeticiones);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "TipoRepeticiones"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(TipoRepeticionesMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, TipoRepeticiones entity)
        {
            
            IMappeableTipoRepeticionesObject TipoRepeticiones = (IMappeableTipoRepeticionesObject)entity;
            TipoRepeticiones.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetBoolean(2));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(TipoRepeticiones entity)
        {

            IMappeableTipoRepeticionesObject TipoRepeticiones = (IMappeableTipoRepeticionesObject)entity;
            return TipoRepeticiones.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(TipoRepeticiones entity)
        {

            IMappeableTipoRepeticionesObject TipoRepeticiones = (IMappeableTipoRepeticionesObject)entity;
            return TipoRepeticiones.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(TipoRepeticiones entity)
        {

            IMappeableTipoRepeticionesObject TipoRepeticiones = (IMappeableTipoRepeticionesObject)entity;
            return TipoRepeticiones.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(TipoRepeticiones entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableTipoRepeticionesObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(TipoRepeticiones entity)
        {
            
            ((IMappeableTipoRepeticiones)entity).CompleteEntity();
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
        /// Get a TipoRepeticiones by execute a SQL Query Text
        /// </summary>
        public TipoRepeticiones GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a TipoRepeticionesList by execute a SQL Query Text
        /// </summary>
        public TipoRepeticionesList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public TipoRepeticiones GetOne(System.Int32 IdTipoRepeticion)
        {
            return base.GetOne(new TipoRepeticiones(IdTipoRepeticion));
        }


        // GetOne By Objects and Params
            


        


        

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdTipoRepeticion)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "TipoRepeticiones_Delete", IdTipoRepeticion);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdTipoRepeticion)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "TipoRepeticiones_Delete", IdTipoRepeticion);
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
    public class TipoRepeticionesMapperWrapper
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
        public monaguaRules.Mappers.TipoRepeticionesMapper Instance()
        {
            return monaguaRules.Mappers.TipoRepeticionesMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a TipoRepeticionesEntity by calling a Stored Procedure
        /// </summary>
        public Entities.TipoRepeticiones GetOne(System.Int32 IdTipoRepeticion) {
            return Instance().GetOne( IdTipoRepeticion);
        }

        // GetBy Objects and Params
            

        

       

        /// <summary>
        /// Delete children for TipoRepeticiones
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, TipoRepeticiones entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        
        /// <summary>
        /// Delete TipoRepeticiones 
        /// </summary>
        public void Delete(System.Int32 IdTipoRepeticion){
            Instance().Delete(IdTipoRepeticion);
        }

        /// <summary>
        /// Delete TipoRepeticiones 
        /// </summary>
        public void Delete(Entities.TipoRepeticiones entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save TipoRepeticiones  
        /// </summary>
        public void Save(Entities.TipoRepeticiones entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert TipoRepeticiones 
        /// </summary>
        public void Insert(Entities.TipoRepeticiones entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll TipoRepeticiones 
        /// </summary>
        public Entities.TipoRepeticionesList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save TipoRepeticiones 
        /// </summary>
        public void Save(System.Int32 IdTipoRepeticion, System.String Nombre, System.Boolean Activa){
            Entities.TipoRepeticiones entity = Instance().GetOne(IdTipoRepeticion);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdTipoRepeticion", IdTipoRepeticion));

            entity.Nombre = Nombre;
            entity.Activa = Activa;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert TipoRepeticiones
        /// </summary>
        public void Insert(System.Int32 IdTipoRepeticion, System.String Nombre, System.Boolean Activa){
            Entities.TipoRepeticiones entity = new Entities.TipoRepeticiones();

            entity.IdTipoRepeticion = IdTipoRepeticion;
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
    public partial class TipoRepeticionesLoader<T> : BaseLoader< T, TipoRepeticiones, ObjectList<T>>, IGenericGateway where T : TipoRepeticiones, new()
    {

        #region "Singleton"

        static TipoRepeticionesLoader<T> _instance;

        private TipoRepeticionesLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static TipoRepeticionesLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new TipoRepeticionesLoader<T>();
                else {
                    TipoRepeticionesLoader<T> inst = HttpContext.Current.Items["monaguaRules.TipoRepeticionesLoaderSingleton"] as TipoRepeticionesLoader<T>;
                    if (inst == null) {
                        inst = new TipoRepeticionesLoader<T>();
                        HttpContext.Current.Items.Add("monaguaRules.TipoRepeticionesLoaderSingleton", inst);
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
            
            string[] s ={"IdTipoRepeticion"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(TipoRepeticiones);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "TipoRepeticiones"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, TipoRepeticiones entity)
        {
            
            IMappeableTipoRepeticionesObject TipoRepeticiones = (IMappeableTipoRepeticionesObject)entity;
            TipoRepeticiones.HydrateFields(
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
            
            ((IMappeableTipoRepeticiones)entity).CompleteEntity();
        }


        



        /// <summary>
        /// Get a TipoRepeticiones by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a TipoRepeticionesList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdTipoRepeticion)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "TipoRepeticiones_GetOne", IdTipoRepeticion);
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




