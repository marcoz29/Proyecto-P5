﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_P5.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Proyecto_P5Entities : DbContext
    {
        public Proyecto_P5Entities()
            : base("name=Proyecto_P5Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<spListarCategoria_Result> spListarCategoria()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spListarCategoria_Result>("spListarCategoria");
        }
    
        public virtual int spCrearCategoria(string nombre, string descripcion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCrearCategoria", nombreParameter, descripcionParameter);
        }
    
        public virtual ObjectResult<spConsultarCategoriaId_Result> spConsultarCategoriaId(Nullable<int> idCategoria)
        {
            var idCategoriaParameter = idCategoria.HasValue ?
                new ObjectParameter("idCategoria", idCategoria) :
                new ObjectParameter("idCategoria", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spConsultarCategoriaId_Result>("spConsultarCategoriaId", idCategoriaParameter);
        }
    
        public virtual int spEditarCategoria(Nullable<int> idCategoria, string nombre, string descripcion)
        {
            var idCategoriaParameter = idCategoria.HasValue ?
                new ObjectParameter("IdCategoria", idCategoria) :
                new ObjectParameter("IdCategoria", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditarCategoria", idCategoriaParameter, nombreParameter, descripcionParameter);
        }
    
        public virtual ObjectResult<spListarMarca_Producto_Result> spListarMarca_Producto()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spListarMarca_Producto_Result>("spListarMarca_Producto");
        }
    
        public virtual int spCrearMarca_Producto(string nombre, string descripcion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCrearMarca_Producto", nombreParameter, descripcionParameter);
        }
    
        public virtual ObjectResult<spConsultarMarca_ProductoId_Result> spConsultarMarca_ProductoId(Nullable<int> idMarca)
        {
            var idMarcaParameter = idMarca.HasValue ?
                new ObjectParameter("idMarca", idMarca) :
                new ObjectParameter("idMarca", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spConsultarMarca_ProductoId_Result>("spConsultarMarca_ProductoId", idMarcaParameter);
        }
    
        public virtual int spEditarMarca_Producto(Nullable<int> idMarca, string nombre, string descripcion)
        {
            var idMarcaParameter = idMarca.HasValue ?
                new ObjectParameter("IdMarca", idMarca) :
                new ObjectParameter("IdMarca", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spEditarMarca_Producto", idMarcaParameter, nombreParameter, descripcionParameter);
        }
    }
}