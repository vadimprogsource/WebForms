using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebForms.Api;
using WebForms.Entities;

namespace WebForms.Repository
{
    public class DataRepository :DbContext ,  IDataRepository 
    {
        public IQueryable<T> AsQueryable<T>() where T : class
        {
            return Set<T>();
        }


        public DataRepository(string connectionString) : base(connectionString)
        {
            Database.SetInitializer<DataRepository>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
        }
    }
}