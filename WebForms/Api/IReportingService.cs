using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForms.Api
{
    public interface IReportingService<T>
    {
        IEnumerable<T> GenerateReport();
    }
}