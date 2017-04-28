using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebForms.Entities;

namespace WebForms.Repository.Mapping
{
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            ToTable("Countries");
            Property(x => x.CountryID   ).HasColumnName("CountryID");
            Property(x => x.CountryName ).HasColumnName("Country");
            Property(x => x.TerritoryID ).HasColumnName("TerritoryID");
            Property(x => x.CreationDate).HasColumnName("CreationDate");
            HasKey(x => x.CountryID);

            HasRequired(x => x.Territory).WithMany().HasForeignKey(x => x.TerritoryID);
        }
    }
}