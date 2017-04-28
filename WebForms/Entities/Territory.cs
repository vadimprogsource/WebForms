using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForms.Entities
{
    public class Territory
    {
        public int TerritoryID { get; set; }
        public string TerritoryName { get; set; }
        public string CountryName { get; set; }
        public DateTime CreationDate { get; set; }
    }


}