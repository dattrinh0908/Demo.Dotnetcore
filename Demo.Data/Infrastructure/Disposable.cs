using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool IsDisposed;

         public Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if(!IsDisposed && disposing)
            {
                DisposeCore();
            }
        }
        protected virtual void DisposeCore()
        {

        }
    }
}
