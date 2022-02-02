using LogBase.Business.Abstract;
using LogBase.Business.Constants;
using LogBase.Core.Utilities.Results;
using LogBase.DataAccess.Abstract;
using LogBase.Entities.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogBase.Business.Concrete
{
    public class ProductMovementManager : IProductMovementService
    {
        IProductMovementRepository _productMovementRepository;
        public ProductMovementManager(IProductMovementRepository productMovementRepository)
        {
            _productMovementRepository = productMovementRepository;
        }

        public IResult Add(ProductMovement entity)
        {
            _productMovementRepository.Add(entity);
            return new SuccessResult(Messages.ProductMovementAdded);
        }

        public IDataResult<IEnumerable<ProductMovement>> GetList(int? productId)
        {
            if (productId!=null)
            {
                return new SuccessDataResult<IEnumerable<ProductMovement>>(_productMovementRepository.GetList(x => x.ProductId == productId).OrderByDescending(x => x.CreatedDate), Messages.ProductMovementListed);
            }
            return new SuccessDataResult<IEnumerable<ProductMovement>>(_productMovementRepository.GetList().OrderByDescending(x => x.CreatedDate));
        }

        public IDataResult<IEnumerable<ProductMovement>> GetStockTotals()
        {
            throw new NotImplementedException();
        }
    }
}
