using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Repository
{
    public interface IRepository <TEntity> where TEntity : class
    {
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> filter = null,
              Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
                  string includeProperties = "");

        IQueryable<TEntity> GetAll(string include = null);

        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where);

        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> where, string[] include = null);

        Task<TEntity> FindByIdAsync(object id);

        void Add(TEntity entity);

        void Delete(object o);

        void Delete(TEntity entityToDelete);

        void Update(TEntity entityToUpdate);
    }
}
