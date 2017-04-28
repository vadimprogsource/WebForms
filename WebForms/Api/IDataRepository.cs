using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForms.Api
{
    public interface IDataRepository
    {
        IQueryable<T> AsQueryable<T>() where T:class;
    }
}