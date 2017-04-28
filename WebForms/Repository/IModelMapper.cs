using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebForms.Repository
{
    public interface IModelMapper
    {
        void Map(DbModelBuilder modelBuilder);
    }
}
