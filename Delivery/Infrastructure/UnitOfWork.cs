using System;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Infrastructure
{
    public class UnitOfWork : GenericUnitOfWork, IUnitOfWork
    {
        private Dictionary<Type, object> _repositories;

        public UnitOfWork(Dictionary<Type, object> repositories) : base("defaultConnection")
        {
            _repositories = repositories;
        }

        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            return new GenericRepository<TEntity>(Session);
        }
    }
}