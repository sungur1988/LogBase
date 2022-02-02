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
    public interface ICategoryService
    {
        IDataResult<IEnumerable<Category>> GetList();
        IResult Add(Category entity);
        IResult Update(Category entity);
        IResult Delete(int id);
    }
}
