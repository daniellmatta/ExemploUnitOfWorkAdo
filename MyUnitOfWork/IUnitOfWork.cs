using System;

namespace MyUnitOfWork
{
    public interface IUnitOfWork
    {
        void Dispose();
        void SaveChanges();
        System.Data.IDbTransaction Transaction { get; }
    }
}
