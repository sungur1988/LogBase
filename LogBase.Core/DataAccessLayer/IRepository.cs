using LogBase.Core.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogBase.Core.DataAccessLayer
{
    public interface IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
