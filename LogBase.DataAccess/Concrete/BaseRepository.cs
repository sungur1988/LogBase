using LogBase.Core.DataAccessLayer;
using LogBase.Core.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LogBase.DataAccess.Concrete
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        protected AppDbContext _appDbContext;
        private DbSet<TEntity> _dbSet;


        public BaseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var deletedEntity = _dbSet.Find(id);
            if (deletedEntity !=null)
            {
                _dbSet.Remove(deletedEntity);
                _appDbContext.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.SingleOrDefault(filter);
        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? _dbSet.ToList()
                : _dbSet.Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
            _appDbContext.SaveChanges();
        }
    }
}
