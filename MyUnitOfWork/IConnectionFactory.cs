using System;
using System.Data;

namespace MyUnitOfWork
{
    public interface IConnectionFactory
    {
        IDbConnection Create();
    }
}
