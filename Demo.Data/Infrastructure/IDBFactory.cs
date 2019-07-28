using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data.Infrastructure
{
    public interface IDBFactory : IDisposable
    {
        ApplicationDBContext Init();
    }
}
