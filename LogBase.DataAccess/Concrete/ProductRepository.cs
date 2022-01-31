using LogBase.DataAccess.Abstract;
using LogBase.Entities.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBase.DataAccess.Concrete
{
    public class ProductRepository : BaseRepository<Product> , IProductRepository
    {
        public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
