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
    public interface IProductMovementService
    {
        IDataResult<IEnumerable<ProductMovement>> GetList(int? productId);
        IResult Add(ProductMovement entity);
        IDataResult<IEnumerable<ProductMovement>> GetStockTotals();
    }
}
