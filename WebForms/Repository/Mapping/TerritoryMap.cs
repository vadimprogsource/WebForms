using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebForms.Entities;

namespace WebForms.Repository.Mapping
{
    public class TerritoriesMap : EntityTypeConfiguration<Territory>
    {
        public TerritoriesMap()
        {
            ToTable("Territories");
            HasKey(x => x.TerritoryID);
            Property(x => x.TerritoryID).HasColumnName("TerritoryID");
            Property(x => x.TerritoryName).HasColumnName("Territory");
            Property(x => x.CountryName).HasColumnName("CountryName");
            Property(x => x.CreationDate).HasColumnName("CreationDate");
        }
    }
}
