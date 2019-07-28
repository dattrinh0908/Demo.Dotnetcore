using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();
        private IDBFactory _dbFactory;
        private ApplicationDBContext _dbContext;
        public UnitOfWork(IDBFactory dbFactory)
        {
            this._dbFactory = dbFactory;
        }


        public Dictionary<Type, object> Repositories
        {
            get { return _repositories; }
            set { Repositories = value; }
        }

        public IRepository<T> Repository<T>() where T : class
        {
            if (Repositories.Keys.Contains(typeof(T)))
            {
                return Repositories[typeof(T)] as IRepository<T>;
            }

            IRepository<T> repo = new Repository<T>(_dbContext);
            Repositories.Add(typeof(T), repo);
            return repo;
        }

      
        public ApplicationDBContext DbContext
        {
            get { return _dbContext ?? (_dbContext = _dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
