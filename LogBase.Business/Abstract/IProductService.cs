using LogBase.Core.Utilities.Results;
using LogBase.Entities.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogBase.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<IEnumerable<Product>> GetList(int? CategoryId);
        IResult Add(Product entity);
        IResult Update(Product entity);
        IResult Delete(int id);
    }
}
