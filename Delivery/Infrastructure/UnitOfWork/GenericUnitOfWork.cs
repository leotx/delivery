using System;
using System.Data;
using Delivery.Infrastructure.Repository;
using NHibernate;

namespace Delivery.Infrastructure.UnitOfWork
{
    public class GenericUnitOfWork : IDisposable, IGenericUnitOfWork
    {
        public ISession Session { get; }
        private ITransaction Transaction { get; }

        protected GenericUnitOfWork(string connectionString)
        {
            var sessionFactory = DeliveryConfiguration.Configuration(connectionString).BuildSessionFactory();

            Session = sessionFactory.OpenSession();
            Transaction = Session.BeginTransaction(IsolationLevel.ReadCommitted);
        }

        public void Dispose()
        {
            Session?.Dispose();
            Transaction?.Dispose();
        }

        public void Commit()
        {
            if (Transaction != null && Transaction.IsActive)
            {
                Transaction.Commit();
            }
        }

        public void Rollback()
        {
            if (Transaction != null && Transaction.IsActive)
            {
                Transaction.Rollback();
            }
        }

        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            return new GenericRepository<TEntity>(Session);
        }
    }
}