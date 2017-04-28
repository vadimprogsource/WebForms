using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebForms.Services
{
    [DataObject]
    public abstract class ReportingService
    {
        
        [DataObjectMethod(DataObjectMethodType.Select,true)]
        public abstract Array Select(int maximumRows, int startRowIndex);
        public abstract int SelectCount();
    }
}