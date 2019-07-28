using Demo.Data.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data.Repository
{
   public abstract class RepositoryBase<T> where T : class
    {
        #region Properties
        private ApplicationDBContext dataContext;
        private readonly DbSet<T> dbSet;

        protected IDBFactory DBFactory
        {
            get;
            //private get;
        }

        protected ApplicationDBContext DBContext
        {
            get { return dataContext ?? (dataContext = DBFactory.Init()); }
        }
        #endregion

        protected RepositoryBase(IDBFactory dbFactory)
        {
            DBFactory = dbFactory;
            dbSet = DBContext.Set<T>();
        }
    }

}
