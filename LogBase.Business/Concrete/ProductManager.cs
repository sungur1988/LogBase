using LogBase.Business.Abstract;
using LogBase.Business.Constants;
using LogBase.Business.ValidationRules.FluentValidation;
using LogBase.Core.Aspects.Autofac.Validation;
using LogBase.Core.Utilities.Results;
using LogBase.DataAccess.Abstract;
using LogBase.Entities.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBase.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product entity)
        {
            _productRepository.Add(entity);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(int id)
        {
            _productRepository.Delete(id);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<IEnumerable<Product>> GetList(int? CategoryId)
        {
            var data = CategoryId == null
                ? _productRepository.GetList()
                : _productRepository.GetList(x => x.CategoryId == CategoryId);
            return new SuccessDataResult<IEnumerable<Product>>(data, Messages.ProductListed);
        }
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Update(Product entity)
        {
            _productRepository.Update(entity);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
