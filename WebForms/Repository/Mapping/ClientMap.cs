using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebForms.Entities;

namespace WebForms.Repository.Mapping
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {
        public ClientMap()
        {
            ToTable("Clients");
            Property(x => x.ClientID).HasColumnName("ClientID");
            Property(x => x.ClientName).HasColumnName("ClientName");
            Property(x => x.CountryID).HasColumnName("CountryID");
            Property(x => x.CreationDate).HasColumnName("CreationDate");
            HasKey(x => x.ClientID);

            HasRequired(x => x.Country).WithMany().HasForeignKey(x => x.CountryID);
        }
    }
}