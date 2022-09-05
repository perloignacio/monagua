
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 31/08/2022 - 14:49
// This is a partial class file. The other one is PreguntasFrecuentesMapper.cs
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
    public partial class PreguntasFrecuentesMapper : BaseGateway<PreguntasFrecuentes, PreguntasFrecuentesList>, IGenericGateway
    {


        #region "Singleton"

        static PreguntasFrecuentesMapper _instance;

        private PreguntasFrecuentesMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static PreguntasFrecuentesMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new PreguntasFrecuentesMapper();
                else {
                    PreguntasFrecuentesMapper inst = HttpContext.Current.Items["monaguaRules.PreguntasFrecuentesMapperSingleton"] as PreguntasFrecuentesMapper;
                    if (inst == null) {
                        inst = new PreguntasFrecuentesMapper();
                        HttpContext.Current.Items.Add("monaguaRules.PreguntasFrecuentesMapperSingleton", inst);
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
            
            string[] s ={"IdPregunta"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(PreguntasFrecuentes);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "PreguntasFrecuentes"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(PreguntasFrecuentesMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, PreguntasFrecuentes entity)
        {
            
            IMappeablePreguntasFrecuentesObject PreguntasFrecuentes = (IMappeablePreguntasFrecuentesObject)entity;
            PreguntasFrecuentes.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetString(2),
reader.GetInt32(3),
reader.GetBoolean(4));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(PreguntasFrecuentes entity)
        {

            IMappeablePreguntasFrecuentesObject PreguntasFrecuentes = (IMappeablePreguntasFrecuentesObject)entity;
            return PreguntasFrecuentes.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(PreguntasFrecuentes entity)
        {

            IMappeablePreguntasFrecuentesObject PreguntasFrecuentes = (IMappeablePreguntasFrecuentesObject)entity;
            return PreguntasFrecuentes.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(PreguntasFrecuentes entity)
        {

            IMappeablePreguntasFrecuentesObject PreguntasFrecuentes = (IMappeablePreguntasFrecuentesObject)entity;
            return PreguntasFrecuentes.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(PreguntasFrecuentes entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeablePreguntasFrecuentesObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(PreguntasFrecuentes entity)
        {
            
            ((IMappeablePreguntasFrecuentes)entity).CompleteEntity();
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
        /// Get a PreguntasFrecuentes by execute a SQL Query Text
        /// </summary>
        public PreguntasFrecuentes GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a PreguntasFrecuentesList by execute a SQL Query Text
        /// </summary>
        public PreguntasFrecuentesList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public PreguntasFrecuentes GetOne(System.Int32 IdPregunta)
        {
            return base.GetOne(new PreguntasFrecuentes(IdPregunta));
        }


        // GetOne By Objects and Params
            


        


        

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdPregunta)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "PreguntasFrecuentes_Delete", IdPregunta);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdPregunta)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "PreguntasFrecuentes_Delete", IdPregunta);
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
    public class PreguntasFrecuentesMapperWrapper
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
        public monaguaRules.Mappers.PreguntasFrecuentesMapper Instance()
        {
            return monaguaRules.Mappers.PreguntasFrecuentesMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a PreguntasFrecuentesEntity by calling a Stored Procedure
        /// </summary>
        public Entities.PreguntasFrecuentes GetOne(System.Int32 IdPregunta) {
            return Instance().GetOne( IdPregunta);
        }

        // GetBy Objects and Params
            

        

       

        /// <summary>
        /// Delete children for PreguntasFrecuentes
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, PreguntasFrecuentes entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        
        /// <summary>
        /// Delete PreguntasFrecuentes 
        /// </summary>
        public void Delete(System.Int32 IdPregunta){
            Instance().Delete(IdPregunta);
        }

        /// <summary>
        /// Delete PreguntasFrecuentes 
        /// </summary>
        public void Delete(Entities.PreguntasFrecuentes entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save PreguntasFrecuentes  
        /// </summary>
        public void Save(Entities.PreguntasFrecuentes entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert PreguntasFrecuentes 
        /// </summary>
        public void Insert(Entities.PreguntasFrecuentes entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll PreguntasFrecuentes 
        /// </summary>
        public Entities.PreguntasFrecuentesList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save PreguntasFrecuentes 
        /// </summary>
        public void Save(System.Int32 IdPregunta, System.String Pregunta, System.String Respuesta, System.Int32 Orden, System.Boolean Activa){
            Entities.PreguntasFrecuentes entity = Instance().GetOne(IdPregunta);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdPregunta", IdPregunta));

            entity.Pregunta = Pregunta;
            entity.Respuesta = Respuesta;
            entity.Orden = Orden;
            entity.Activa = Activa;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert PreguntasFrecuentes
        /// </summary>
        public void Insert(System.String Pregunta, System.String Respuesta, System.Int32 Orden, System.Boolean Activa){
            Entities.PreguntasFrecuentes entity = new Entities.PreguntasFrecuentes();

            entity.Pregunta = Pregunta;
            entity.Respuesta = Respuesta;
            entity.Orden = Orden;
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
    public partial class PreguntasFrecuentesLoader<T> : BaseLoader< T, PreguntasFrecuentes, ObjectList<T>>, IGenericGateway where T : PreguntasFrecuentes, new()
    {

        #region "Singleton"

        static PreguntasFrecuentesLoader<T> _instance;

        private PreguntasFrecuentesLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static PreguntasFrecuentesLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new PreguntasFrecuentesLoader<T>();
                else {
                    PreguntasFrecuentesLoader<T> inst = HttpContext.Current.Items["monaguaRules.PreguntasFrecuentesLoaderSingleton"] as PreguntasFrecuentesLoader<T>;
                    if (inst == null) {
                        inst = new PreguntasFrecuentesLoader<T>();
                        HttpContext.Current.Items.Add("monaguaRules.PreguntasFrecuentesLoaderSingleton", inst);
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
            
            string[] s ={"IdPregunta"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(PreguntasFrecuentes);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "PreguntasFrecuentes"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, PreguntasFrecuentes entity)
        {
            
            IMappeablePreguntasFrecuentesObject PreguntasFrecuentes = (IMappeablePreguntasFrecuentesObject)entity;
            PreguntasFrecuentes.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetString(2),
reader.GetInt32(3),
reader.GetBoolean(4));
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
            
            ((IMappeablePreguntasFrecuentes)entity).CompleteEntity();
        }


        



        /// <summary>
        /// Get a PreguntasFrecuentes by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a PreguntasFrecuentesList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdPregunta)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "PreguntasFrecuentes_GetOne", IdPregunta);
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




