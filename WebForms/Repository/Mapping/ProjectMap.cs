using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebForms.Entities;

namespace WebForms.Repository.Mapping
{
    public class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            ToTable("Projects");
            Property(x => x.ProjectID).HasColumnName("ProjectID");
            Property(x => x.ProjectCode).HasMaxLength(10).HasColumnName("ProjectCode");
            Property(x => x.ProjectTitle).HasColumnName("ProjectTitle");
            Property(x => x.CountryID).HasColumnName("CountryID");
            Property(x => x.CreationDate).HasColumnName("CreationDate");
            HasKey(x => x.ProjectID);

            HasRequired(x => x.Country).WithMany().HasForeignKey(x => x.CountryID);
                
        }
    }
}