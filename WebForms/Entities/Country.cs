using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForms.Entities
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public int TerritoryID { get; set; }
        public DateTime CreationDate { get; set; }
        public Territory Territory { get; set; }
    }
}