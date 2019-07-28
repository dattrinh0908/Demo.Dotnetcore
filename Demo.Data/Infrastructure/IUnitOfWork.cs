using Microsoft.EntityFrameworkCore;

namespace Demo.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        //DbContext Context { get; }
        void Commit();

    }
}