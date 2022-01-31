using LogBase.Core.DataAccessLayer;
using LogBase.Entities.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBase.DataAccess.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
