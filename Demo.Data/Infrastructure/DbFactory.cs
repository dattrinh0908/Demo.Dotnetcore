using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data.Infrastructure
{
    public class DbFactory : Disposable, IDBFactory
    {
        ApplicationDBContext DbContext;
        public ApplicationDBContext Init()
        {
            return DbContext ?? (DbContext = new ApplicationDBContext());
        }
        protected override void DisposeCore()
        {
          if( DbContext != null)
            {
                DbContext.Dispose();
            }
        }
    }
}
