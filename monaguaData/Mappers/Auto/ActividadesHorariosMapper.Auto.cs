
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 10/6/2022 - 05:08 p. m.
// This is a partial class file. The other one is ActividadesHorariosMapper.cs
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
    public partial class ActividadesHorariosMapper : BaseGateway<ActividadesHorarios, ActividadesHorariosList>, IGenericGateway
    {


        #region "Singleton"

        static ActividadesHorariosMapper _instance;

        private ActividadesHorariosMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ActividadesHorariosMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ActividadesHorariosMapper();
                else {
                    ActividadesHorariosMapper inst = HttpContext.Current.Items["monaguaRules.ActividadesHorariosMapperSingleton"] as ActividadesHorariosMapper;
                    if (inst == null) {
                        inst = new ActividadesHorariosMapper();
                        HttpContext.Current.Items.Add("monaguaRules.ActividadesHorariosMapperSingleton", inst);
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
            
            string[] s ={"IdHorario"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(ActividadesHorarios);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "ActividadesHorarios"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(ActividadesHorariosMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ActividadesHorarios entity)
        {
            
            IMappeableActividadesHorariosObject ActividadesHorarios = (IMappeableActividadesHorariosObject)entity;
            ActividadesHorarios.HydrateFields(
            reader.GetInt32(0),
reader.GetInt32(1),
reader.GetInt32(2),
reader.GetDateTime(3),
reader.GetDateTime(4),
reader.GetBoolean(5),
(reader.IsDBNull(6)) ? new System.Nullable<System.Int32>() : reader.GetInt32(6));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(ActividadesHorarios entity)
        {

            IMappeableActividadesHorariosObject ActividadesHorarios = (IMappeableActividadesHorariosObject)entity;
            return ActividadesHorarios.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(ActividadesHorarios entity)
        {

            IMappeableActividadesHorariosObject ActividadesHorarios = (IMappeableActividadesHorariosObject)entity;
            return ActividadesHorarios.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(ActividadesHorarios entity)
        {

            IMappeableActividadesHorariosObject ActividadesHorarios = (IMappeableActividadesHorariosObject)entity;
            return ActividadesHorarios.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(ActividadesHorarios entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableActividadesHorariosObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(ActividadesHorarios entity)
        {
            Entities.Actividades ActividadesEntity = null; // Lazy load
            ((IMappeableActividadesHorarios)entity).CompleteEntity(ActividadesEntity);
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
        /// Get a ActividadesHorarios by execute a SQL Query Text
        /// </summary>
        public ActividadesHorarios GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ActividadesHorariosList by execute a SQL Query Text
        /// </summary>
        public ActividadesHorariosList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public ActividadesHorarios GetOne(System.Int32 IdHorario)
        {
            return base.GetOne(new ActividadesHorarios(IdHorario));
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ActividadesHorariosList GetByActividades(DbTransaction transaction, System.Int32 IdActividad)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ActividadesHorarios_GetByActividades", IdActividad);
        }

        /// <summary>
        /// 
        /// </summary>
        public ActividadesHorariosList GetByActividades(DbTransaction transaction, IUniqueIdentifiable Actividades)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ActividadesHorarios_GetByActividades", Actividades.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ActividadesHorariosList GetByActividades(System.Int32 IdActividad)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ActividadesHorarios_GetByActividades", IdActividad);
        }

        /// <summary>
        /// 
        /// </summary>
        public ActividadesHorariosList GetByActividades(IUniqueIdentifiable Actividades)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ActividadesHorarios_GetByActividades", Actividades.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdHorario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ActividadesHorarios_Delete", IdHorario);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdHorario)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ActividadesHorarios_Delete", IdHorario);
        }


        // Delete By Objects and Params
            



        

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByActividades(System.Int32 IdActividad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ActividadesHorarios_DeleteByActividades", IdActividad);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByActividades(DbTransaction transaction, System.Int32 IdActividad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ActividadesHorarios_DeleteByActividades", IdActividad);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByActividades(IUniqueIdentifiable Actividades)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "ActividadesHorarios_DeleteByActividades", Actividades.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByActividades(DbTransaction transaction, IUniqueIdentifiable Actividades)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "ActividadesHorarios_DeleteByActividades", Actividades.Identifier());
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
    public class ActividadesHorariosMapperWrapper
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
        public monaguaRules.Mappers.ActividadesHorariosMapper Instance()
        {
            return monaguaRules.Mappers.ActividadesHorariosMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a ActividadesHorariosEntity by calling a Stored Procedure
        /// </summary>
        public Entities.ActividadesHorarios GetOne(System.Int32 IdHorario) {
            return Instance().GetOne( IdHorario);
        }

        // GetBy Objects and Params
            

        

        /// <summary>
        /// Get a ActividadesHorariosList by calling a Stored Procedure
        /// </summary>
        public Entities.ActividadesHorariosList GetByActividades(System.Int32 IdActividad)
        {
            return Instance().GetByActividades(IdActividad);
        }

        /// <summary>
        /// Get a ActividadesHorariosList by calling a Stored Procedure
        /// </summary>
        public Entities.ActividadesHorariosList GetByActividades(IUniqueIdentifiable Actividades)
        {
            return Instance().GetByActividades(Actividades);
        }

    

       

        /// <summary>
        /// Delete children for ActividadesHorarios
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, ActividadesHorarios entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        

        /// <summary>
        /// Delete ActividadesHorarios by Actividades
        /// </summary>
        public void DeleteByActividades(System.Int32 IdActividad)
        {
            Instance().DeleteByActividades(IdActividad);
        }

        /// <summary>
        /// Delete ActividadesHorarios by Actividades
        /// </summary>
        public void DeleteByActividades(IUniqueIdentifiable Actividades)
        {
            Instance().DeleteByActividades(Actividades);
        }

    
        /// <summary>
        /// Delete ActividadesHorarios 
        /// </summary>
        public void Delete(System.Int32 IdHorario){
            Instance().Delete(IdHorario);
        }

        /// <summary>
        /// Delete ActividadesHorarios 
        /// </summary>
        public void Delete(Entities.ActividadesHorarios entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save ActividadesHorarios  
        /// </summary>
        public void Save(Entities.ActividadesHorarios entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert ActividadesHorarios 
        /// </summary>
        public void Insert(Entities.ActividadesHorarios entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll ActividadesHorarios 
        /// </summary>
        public Entities.ActividadesHorariosList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save ActividadesHorarios 
        /// </summary>
        public void Save(System.Int32 IdHorario, System.Int32 IdActividad, System.Int32 Tipo, System.DateTime FechaHoraDesde, System.DateTime FechaHoraHasta, System.Boolean Activa, System.Int32 Capacidad){
            Entities.ActividadesHorarios entity = Instance().GetOne(IdHorario);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdHorario", IdHorario));

            entity.IdActividad = IdActividad;
            entity.Tipo = Tipo;
            entity.FechaHoraDesde = FechaHoraDesde;
            entity.FechaHoraHasta = FechaHoraHasta;
            entity.Activa = Activa;
            entity.Capacidad = Capacidad;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert ActividadesHorarios
        /// </summary>
        public void Insert(System.Int32 IdActividad, System.Int32 Tipo, System.DateTime FechaHoraDesde, System.DateTime FechaHoraHasta, System.Boolean Activa, System.Int32 Capacidad){
            Entities.ActividadesHorarios entity = new Entities.ActividadesHorarios();

            entity.IdActividad = IdActividad;
            entity.Tipo = Tipo;
            entity.FechaHoraDesde = FechaHoraDesde;
            entity.FechaHoraHasta = FechaHoraHasta;
            entity.Activa = Activa;
            entity.Capacidad = Capacidad;
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
    public partial class ActividadesHorariosLoader<T> : BaseLoader< T, ActividadesHorarios, ObjectList<T>>, IGenericGateway where T : ActividadesHorarios, new()
    {

        #region "Singleton"

        static ActividadesHorariosLoader<T> _instance;

        private ActividadesHorariosLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ActividadesHorariosLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ActividadesHorariosLoader<T>();
                else {
                    ActividadesHorariosLoader<T> inst = HttpContext.Current.Items["monaguaRules.ActividadesHorariosLoaderSingleton"] as ActividadesHorariosLoader<T>;
                    if (inst == null) {
                        inst = new ActividadesHorariosLoader<T>();
                        HttpContext.Current.Items.Add("monaguaRules.ActividadesHorariosLoaderSingleton", inst);
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
            
            string[] s ={"IdHorario"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(ActividadesHorarios);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "ActividadesHorarios"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, ActividadesHorarios entity)
        {
            
            IMappeableActividadesHorariosObject ActividadesHorarios = (IMappeableActividadesHorariosObject)entity;
            ActividadesHorarios.HydrateFields(
            reader.GetInt32(0),
reader.GetInt32(1),
reader.GetInt32(2),
reader.GetDateTime(3),
reader.GetDateTime(4),
reader.GetBoolean(5),
(reader.IsDBNull(6)) ? new System.Nullable<System.Int32>() : reader.GetInt32(6));
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
            Entities.Actividades ActividadesEntity = null; // Lazy load
            ((IMappeableActividadesHorarios)entity).CompleteEntity(ActividadesEntity);
        }


        



        /// <summary>
        /// Get a ActividadesHorarios by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ActividadesHorariosList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdHorario)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "ActividadesHorarios_GetOne", IdHorario);
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByActividades(DbTransaction transaction, System.Int32 IdActividad)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ActividadesHorarios_GetByActividades", IdActividad);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByActividades(DbTransaction transaction, IUniqueIdentifiable Actividades)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "ActividadesHorarios_GetByActividades", Actividades.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByActividades(System.Int32 IdActividad)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ActividadesHorarios_GetByActividades", IdActividad);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByActividades(IUniqueIdentifiable Actividades)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "ActividadesHorarios_GetByActividades", Actividades.Identifier());
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





