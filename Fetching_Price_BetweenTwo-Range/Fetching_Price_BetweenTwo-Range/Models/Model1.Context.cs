﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fetching_Price_BetweenTwo_Range.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class fetching_records_with_priceEntities : DbContext
    {
        public fetching_records_with_priceEntities()
            : base("name=fetching_records_with_priceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_product> tbl_product { get; set; }
    
        public virtual ObjectResult<pro_details_Result> pro_details(Nullable<int> start, Nullable<int> end)
        {
            var startParameter = start.HasValue ?
                new ObjectParameter("start", start) :
                new ObjectParameter("start", typeof(int));
    
            var endParameter = end.HasValue ?
                new ObjectParameter("end", end) :
                new ObjectParameter("end", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pro_details_Result>("pro_details", startParameter, endParameter);
        }
    
        public virtual ObjectResult<tbl_product> GetFunctionPro(Nullable<int> start, Nullable<int> end)
        {
            var startParameter = start.HasValue ?
                new ObjectParameter("start", start) :
                new ObjectParameter("start", typeof(int));
    
            var endParameter = end.HasValue ?
                new ObjectParameter("end", end) :
                new ObjectParameter("end", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tbl_product>("GetFunctionPro", startParameter, endParameter);
        }
    
        public virtual ObjectResult<tbl_product> GetFunctionPro(Nullable<int> start, Nullable<int> end, MergeOption mergeOption)
        {
            var startParameter = start.HasValue ?
                new ObjectParameter("start", start) :
                new ObjectParameter("start", typeof(int));
    
            var endParameter = end.HasValue ?
                new ObjectParameter("end", end) :
                new ObjectParameter("end", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tbl_product>("GetFunctionPro", mergeOption, startParameter, endParameter);
        }
    }
}