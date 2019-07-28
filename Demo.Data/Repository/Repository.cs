using Demo.Data.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private IDBFactory _dbFactory;
        private ApplicationDBContext _dbContext;
        private DbSet<T> _dbSet;

        public Repository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        protected Repository(IDBFactory dbFactory)
        {
            _dbFactory = dbFactory;
            _dbSet = _dbContext.Set<T>();
        }

        //protected ApplicationDBContext DBContext
        //{
        //    get { return dataContext ?? (dataContext = DbFactory.Init()); }
        //}

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(object o)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entityToDelete)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public Task<T> FindByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> where, string[] include = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(string include = null)
        {
            throw new NotImplementedException();
        }

        public void Update(T entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
