using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForms.Entities
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectTitle { get; set; }
        public int CountryID { get; set; }
        public DateTime CreationDate { get; set; }
        public Country Country { get; set; }
  
    }
}