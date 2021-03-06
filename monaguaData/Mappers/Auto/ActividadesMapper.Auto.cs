
        
//------------------------------------------------------------------------------
// This file was generated by Cooperator Modeler, version 1.3.2.0
// Created: 6/7/2022 - 04:37 p. m.
// This is a partial class file. The other one is ActividadesMapper.cs
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
    public partial class ActividadesMapper : BaseGateway<Actividades, ActividadesList>, IGenericGateway
    {


        #region "Singleton"

        static ActividadesMapper _instance;

        private ActividadesMapper()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ActividadesMapper Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ActividadesMapper();
                else {
                    ActividadesMapper inst = HttpContext.Current.Items["monaguaRules.ActividadesMapperSingleton"] as ActividadesMapper;
                    if (inst == null) {
                        inst = new ActividadesMapper();
                        HttpContext.Current.Items.Add("monaguaRules.ActividadesMapperSingleton", inst);
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
            
            string[] s ={"IdActividad"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Actividades);
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Actividades"; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override string RuleName
        {
            get {return typeof(ActividadesMapper).FullName;}
        }


        

        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Actividades entity)
        {
            
            IMappeableActividadesObject Actividades = (IMappeableActividadesObject)entity;
            Actividades.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetString(2),
reader.GetString(3),
(reader.IsDBNull(4)) ? "" : reader.GetString(4),
(reader.IsDBNull(5)) ? "" : reader.GetString(5),
(reader.IsDBNull(6)) ? "" : reader.GetString(6),
reader.GetDecimal(7),
(reader.IsDBNull(8)) ? new System.Nullable<System.Decimal>() : reader.GetDecimal(8),
reader.GetBoolean(9),
reader.GetBoolean(10),
reader.GetBoolean(11),
(reader.IsDBNull(12)) ? "" : reader.GetString(12),
(reader.IsDBNull(13)) ? "" : reader.GetString(13),
(reader.IsDBNull(14)) ? "" : reader.GetString(14),
(reader.IsDBNull(15)) ? "" : reader.GetString(15),
reader.GetDecimal(16),
reader.GetInt32(17),
reader.GetInt32(18),
reader.GetBoolean(19),
(reader.IsDBNull(20)) ? "" : reader.GetString(20));
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForInsert(Actividades entity)
        {

            IMappeableActividadesObject Actividades = (IMappeableActividadesObject)entity;
            return Actividades.GetFieldsForInsert();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForUpdate(Actividades entity)
        {

            IMappeableActividadesObject Actividades = (IMappeableActividadesObject)entity;
            return Actividades.GetFieldsForUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        protected override object[] GetFieldsForDelete(Actividades entity)
        {

            IMappeableActividadesObject Actividades = (IMappeableActividadesObject)entity;
            return Actividades.GetFieldsForDelete();
        }


        /// <summary>
        /// Raised after insert and update
        /// </summary>
        protected override void UpdateObjectFromOutputParams(Actividades entity, object[] parameters)
        {
            // Update properties from Output parameters
            ((IMappeableActividadesObject) entity).UpdateObjectFromOutputParams(parameters);
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
        protected override void CompleteEntity(Actividades entity)
        {
            Entities.Categorias CategoriasEntity = null; // Lazy load
Entities.Prestadores PrestadoresEntity = null; // Lazy load
            ((IMappeableActividades)entity).CompleteEntity(CategoriasEntity, PrestadoresEntity);
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
        /// Get a Actividades by execute a SQL Query Text
        /// </summary>
        public Actividades GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ActividadesList by execute a SQL Query Text
        /// </summary>
        public ActividadesList GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }


        /// <summary>
        /// 
        /// </summary>
        public Actividades GetOne(System.Int32 IdActividad)
        {
            return base.GetOne(new Actividades(IdActividad));
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ActividadesList GetByCategorias(DbTransaction transaction, System.Int32 IdCategoria)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Actividades_GetByCategorias", IdCategoria);
        }

        /// <summary>
        /// 
        /// </summary>
        public ActividadesList GetByCategorias(DbTransaction transaction, IUniqueIdentifiable Categorias)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Actividades_GetByCategorias", Categorias.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ActividadesList GetByPrestadores(DbTransaction transaction, System.Int32 IdPrestador)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Actividades_GetByPrestadores", IdPrestador);
        }

        /// <summary>
        /// 
        /// </summary>
        public ActividadesList GetByPrestadores(DbTransaction transaction, IUniqueIdentifiable Prestadores)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Actividades_GetByPrestadores", Prestadores.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ActividadesList GetByCategorias(System.Int32 IdCategoria)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Actividades_GetByCategorias", IdCategoria);
        }

        /// <summary>
        /// 
        /// </summary>
        public ActividadesList GetByCategorias(IUniqueIdentifiable Categorias)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Actividades_GetByCategorias", Categorias.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ActividadesList GetByPrestadores(System.Int32 IdPrestador)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Actividades_GetByPrestadores", IdPrestador);
        }

        /// <summary>
        /// 
        /// </summary>
        public ActividadesList GetByPrestadores(IUniqueIdentifiable Prestadores)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Actividades_GetByPrestadores", Prestadores.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public void Delete(System.Int32 IdActividad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Actividades_Delete", IdActividad);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Delete(DbTransaction transaction, System.Int32 IdActividad)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Actividades_Delete", IdActividad);
        }


        // Delete By Objects and Params
            



        

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByCategorias(System.Int32 IdCategoria)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Actividades_DeleteByCategorias", IdCategoria);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByCategorias(DbTransaction transaction, System.Int32 IdCategoria)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Actividades_DeleteByCategorias", IdCategoria);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByCategorias(IUniqueIdentifiable Categorias)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Actividades_DeleteByCategorias", Categorias.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByCategorias(DbTransaction transaction, IUniqueIdentifiable Categorias)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Actividades_DeleteByCategorias", Categorias.Identifier());
        }


    

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByPrestadores(System.Int32 IdPrestador)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Actividades_DeleteByPrestadores", IdPrestador);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByPrestadores(DbTransaction transaction, System.Int32 IdPrestador)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Actividades_DeleteByPrestadores", IdPrestador);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DeleteByPrestadores(IUniqueIdentifiable Prestadores)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(StoredProceduresPrefix() + "Actividades_DeleteByPrestadores", Prestadores.Identifier());
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteByPrestadores(DbTransaction transaction, IUniqueIdentifiable Prestadores)
        {
            base.DataBaseHelper.ExecuteNoQueryByStoredProcedure(transaction, StoredProceduresPrefix() + "Actividades_DeleteByPrestadores", Prestadores.Identifier());
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
    public class ActividadesMapperWrapper
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
        public monaguaRules.Mappers.ActividadesMapper Instance()
        {
            return monaguaRules.Mappers.ActividadesMapper.Instance(); 
        }
        
        /// <summary>
        /// Get a ActividadesEntity by calling a Stored Procedure
        /// </summary>
        public Entities.Actividades GetOne(System.Int32 IdActividad) {
            return Instance().GetOne( IdActividad);
        }

        // GetBy Objects and Params
            

        

        /// <summary>
        /// Get a ActividadesList by calling a Stored Procedure
        /// </summary>
        public Entities.ActividadesList GetByCategorias(System.Int32 IdCategoria)
        {
            return Instance().GetByCategorias(IdCategoria);
        }

        /// <summary>
        /// Get a ActividadesList by calling a Stored Procedure
        /// </summary>
        public Entities.ActividadesList GetByCategorias(IUniqueIdentifiable Categorias)
        {
            return Instance().GetByCategorias(Categorias);
        }

    

        /// <summary>
        /// Get a ActividadesList by calling a Stored Procedure
        /// </summary>
        public Entities.ActividadesList GetByPrestadores(System.Int32 IdPrestador)
        {
            return Instance().GetByPrestadores(IdPrestador);
        }

        /// <summary>
        /// Get a ActividadesList by calling a Stored Procedure
        /// </summary>
        public Entities.ActividadesList GetByPrestadores(IUniqueIdentifiable Prestadores)
        {
            return Instance().GetByPrestadores(Prestadores);
        }

    

       

        /// <summary>
        /// Delete children for Actividades
        /// </summary>
        public void DeleteChildren(DbTransaction transaction, Actividades entity)
        {
            Instance().DeleteChildren(transaction, entity);
        }

        

            

        

        /// <summary>
        /// Delete Actividades by Categorias
        /// </summary>
        public void DeleteByCategorias(System.Int32 IdCategoria)
        {
            Instance().DeleteByCategorias(IdCategoria);
        }

        /// <summary>
        /// Delete Actividades by Categorias
        /// </summary>
        public void DeleteByCategorias(IUniqueIdentifiable Categorias)
        {
            Instance().DeleteByCategorias(Categorias);
        }

    

        /// <summary>
        /// Delete Actividades by Prestadores
        /// </summary>
        public void DeleteByPrestadores(System.Int32 IdPrestador)
        {
            Instance().DeleteByPrestadores(IdPrestador);
        }

        /// <summary>
        /// Delete Actividades by Prestadores
        /// </summary>
        public void DeleteByPrestadores(IUniqueIdentifiable Prestadores)
        {
            Instance().DeleteByPrestadores(Prestadores);
        }

    
        /// <summary>
        /// Delete Actividades 
        /// </summary>
        public void Delete(System.Int32 IdActividad){
            Instance().Delete(IdActividad);
        }

        /// <summary>
        /// Delete Actividades 
        /// </summary>
        public void Delete(Entities.Actividades entity ){
            Instance().Delete(entity);
        }

        /// <summary>
        /// Save Actividades  
        /// </summary>
        public void Save(Entities.Actividades entity){
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Actividades 
        /// </summary>
        public void Insert(Entities.Actividades entity){
            Instance().Insert(entity);
        }

        /// <summary>
        /// GetAll Actividades 
        /// </summary>
        public Entities.ActividadesList GetAll(){  
            return Instance().GetAll();
        }

        /// <summary>
        /// Save Actividades 
        /// </summary>
        public void Save(System.Int32 IdActividad, System.String Nombre, System.String DescripcionCorta, System.String Descripcion, System.String Fotos, System.String Video, System.String Ubicacion, System.Decimal Precio, System.Decimal PrecioOferta, System.Boolean Mascotas, System.Boolean PersonasCapacidadRed, System.Boolean DietasEspeciales, System.String Idiomas, System.String Dificultad, System.String QueIncluye, System.String QueNoIncluye, System.Decimal Duracion, System.Int32 IdCategoria, System.Int32 IdPrestador, System.Boolean Activa, System.String Mapa){
            Entities.Actividades entity = Instance().GetOne(IdActividad);
            if (entity == null)
                throw new ApplicationException(String.Format("Entity not found. IUniqueIdentifiable Values: {0} = {1}", "IdActividad", IdActividad));

            entity.Nombre = Nombre;
            entity.DescripcionCorta = DescripcionCorta;
            entity.Descripcion = Descripcion;
            entity.Fotos = Fotos;
            entity.Video = Video;
            entity.Ubicacion = Ubicacion;
            entity.Precio = Precio;
            entity.PrecioOferta = PrecioOferta;
            entity.Mascotas = Mascotas;
            entity.PersonasCapacidadRed = PersonasCapacidadRed;
            entity.DietasEspeciales = DietasEspeciales;
            entity.Idiomas = Idiomas;
            entity.Dificultad = Dificultad;
            entity.QueIncluye = QueIncluye;
            entity.QueNoIncluye = QueNoIncluye;
            entity.Duracion = Duracion;
            entity.IdCategoria = IdCategoria;
            entity.IdPrestador = IdPrestador;
            entity.Activa = Activa;
            entity.Mapa = Mapa;
            Instance().Save(entity);
        }

        /// <summary>
        /// Insert Actividades
        /// </summary>
        public void Insert(System.String Nombre, System.String DescripcionCorta, System.String Descripcion, System.String Fotos, System.String Video, System.String Ubicacion, System.Decimal Precio, System.Decimal PrecioOferta, System.Boolean Mascotas, System.Boolean PersonasCapacidadRed, System.Boolean DietasEspeciales, System.String Idiomas, System.String Dificultad, System.String QueIncluye, System.String QueNoIncluye, System.Decimal Duracion, System.Int32 IdCategoria, System.Int32 IdPrestador, System.Boolean Activa, System.String Mapa){
            Entities.Actividades entity = new Entities.Actividades();

            entity.Nombre = Nombre;
            entity.DescripcionCorta = DescripcionCorta;
            entity.Descripcion = Descripcion;
            entity.Fotos = Fotos;
            entity.Video = Video;
            entity.Ubicacion = Ubicacion;
            entity.Precio = Precio;
            entity.PrecioOferta = PrecioOferta;
            entity.Mascotas = Mascotas;
            entity.PersonasCapacidadRed = PersonasCapacidadRed;
            entity.DietasEspeciales = DietasEspeciales;
            entity.Idiomas = Idiomas;
            entity.Dificultad = Dificultad;
            entity.QueIncluye = QueIncluye;
            entity.QueNoIncluye = QueNoIncluye;
            entity.Duracion = Duracion;
            entity.IdCategoria = IdCategoria;
            entity.IdPrestador = IdPrestador;
            entity.Activa = Activa;
            entity.Mapa = Mapa;
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
    public partial class ActividadesLoader<T> : BaseLoader< T, Actividades, ObjectList<T>>, IGenericGateway where T : Actividades, new()
    {

        #region "Singleton"

        static ActividadesLoader<T> _instance;

        private ActividadesLoader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public static ActividadesLoader<T> Instance() {
            if (_instance == null) {
                if (HttpContext.Current == null) 
                    _instance = new ActividadesLoader<T>();
                else {
                    ActividadesLoader<T> inst = HttpContext.Current.Items["monaguaRules.ActividadesLoaderSingleton"] as ActividadesLoader<T>;
                    if (inst == null) {
                        inst = new ActividadesLoader<T>();
                        HttpContext.Current.Items.Add("monaguaRules.ActividadesLoaderSingleton", inst);
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
            
            string[] s ={"IdActividad"};
            return s;
        }
        /// <summary>
        /// 
        /// </summary>
        public Type GetMappingType()
        {
            return typeof(Actividades);
        }


        /// <summary>
        /// 
        /// </summary>
        protected override string TableName
        {
            get { return "Actividades"; }
        }

        
        
        /// <summary>
        /// 
        /// </summary>
        protected override void HydrateFields(DbDataReader reader, Actividades entity)
        {
            
            IMappeableActividadesObject Actividades = (IMappeableActividadesObject)entity;
            Actividades.HydrateFields(
            reader.GetInt32(0),
reader.GetString(1),
reader.GetString(2),
reader.GetString(3),
(reader.IsDBNull(4)) ? "" : reader.GetString(4),
(reader.IsDBNull(5)) ? "" : reader.GetString(5),
(reader.IsDBNull(6)) ? "" : reader.GetString(6),
reader.GetDecimal(7),
(reader.IsDBNull(8)) ? new System.Nullable<System.Decimal>() : reader.GetDecimal(8),
reader.GetBoolean(9),
reader.GetBoolean(10),
reader.GetBoolean(11),
(reader.IsDBNull(12)) ? "" : reader.GetString(12),
(reader.IsDBNull(13)) ? "" : reader.GetString(13),
(reader.IsDBNull(14)) ? "" : reader.GetString(14),
(reader.IsDBNull(15)) ? "" : reader.GetString(15),
reader.GetDecimal(16),
reader.GetInt32(17),
reader.GetInt32(18),
reader.GetBoolean(19),
(reader.IsDBNull(20)) ? "" : reader.GetString(20));
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
            Entities.Categorias CategoriasEntity = null; // Lazy load
Entities.Prestadores PrestadoresEntity = null; // Lazy load
            ((IMappeableActividades)entity).CompleteEntity(CategoriasEntity, PrestadoresEntity);
        }


        



        /// <summary>
        /// Get a Actividades by execute a SQL Query Text
        /// </summary>
        public T GetOneBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectBySQLText(sqlQueryText);
        }

        /// <summary>
        /// Get a ActividadesList by execute a SQL Query Text
        /// </summary>
        public ObjectList<T> GetBySQLQuery(string sqlQueryText)
        {
            return base.GetObjectListBySQLText(sqlQueryText);
        }

        /// <summary>
        /// GetOne By Params
        /// </summary>
        public T GetOne(System.Int32 IdActividad)
        {
            return base.GetObjectByAnyStoredProcedure(StoredProceduresPrefix() + "Actividades_GetOne", IdActividad);
        }


        // GetOne By Objects and Params
            


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByCategorias(DbTransaction transaction, System.Int32 IdCategoria)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Actividades_GetByCategorias", IdCategoria);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByCategorias(DbTransaction transaction, IUniqueIdentifiable Categorias)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Actividades_GetByCategorias", Categorias.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByPrestadores(DbTransaction transaction, System.Int32 IdPrestador)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Actividades_GetByPrestadores", IdPrestador);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByPrestadores(DbTransaction transaction, IUniqueIdentifiable Prestadores)
        {
            return base.GetObjectListByAnyStoredProcedure(transaction, StoredProceduresPrefix() + "Actividades_GetByPrestadores", Prestadores.Identifier());
        }

    


        

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByCategorias(System.Int32 IdCategoria)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Actividades_GetByCategorias", IdCategoria);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByCategorias(IUniqueIdentifiable Categorias)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Actividades_GetByCategorias", Categorias.Identifier());
        }

    

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByPrestadores(System.Int32 IdPrestador)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Actividades_GetByPrestadores", IdPrestador);
        }

        /// <summary>
        /// 
        /// </summary>
        public ObjectList<T> GetByPrestadores(IUniqueIdentifiable Prestadores)
        {
            return base.GetObjectListByAnyStoredProcedure(StoredProceduresPrefix() + "Actividades_GetByPrestadores", Prestadores.Identifier());
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





