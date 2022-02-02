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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogBase.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [ValidationAspect(typeof(CategoryValidator))]
        public IResult Add(Category entity)
        {
            _categoryRepository.Add(entity);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(int id)
        {
            _categoryRepository.Delete(id);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        public IDataResult<IEnumerable<Category>> GetList()
        {
            return new SuccessDataResult<IEnumerable<Category>>(_categoryRepository.GetList(),Messages.CategoryListed);
        }

        public IResult Update(Category entity)
        {
            _categoryRepository.Update(entity);
            return new SuccessResult(Messages.CategoryUpdated); 
        }
    }
}
