using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForms.Entities
{
    public class Client
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public int CountryID { get; set; }
        public DateTime CreationDate { get; set; }

        public Country Country { get; set; }
    }
}