using KutuphaneProg.Data.Repositories;
using System;

namespace KutuphaneProg.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;

        int SaveChanges();
    }
}
