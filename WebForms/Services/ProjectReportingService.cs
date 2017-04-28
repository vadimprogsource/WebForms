using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Web;
using WebForms.Api;
using WebForms.Entities;
using WebForms.Repository;

namespace WebForms.Services
{
    public class ProjectReportingService : ReportingService
    {
        private IDataRepository repository = new DataRepository(ConfigurationManager.ConnectionStrings["Repository"].ConnectionString);

        public override Array Select(int maximumRows, int startRowIndex)
        {


            var cli = repository.AsQueryable<Client>();


            var proj = repository.AsQueryable<Project>()
                      .OrderBy(x => x.Country.Territory.TerritoryName)
                      .OrderBy(x => x.Country.CountryName)
                      .OrderBy(x => x.ProjectCode)
                      .Join(cli, x => x.CountryID, x => x.CountryID, (x, y) => new
                      {
                          Territory = x.Country.Territory.TerritoryName,
                          Country   = x.Country.CountryName,
                          x.ProjectCode,
                          x.ProjectTitle,
                          ClientName = y.ClientName
                      })
                      .ToArray();




            return proj;


        }

        public override int SelectCount()
        {
            return 1;
        }
    }
}