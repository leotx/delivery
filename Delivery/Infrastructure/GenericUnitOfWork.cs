using System;
using System.Data;
using NHibernate;

namespace Delivery.Infrastructure
{
    public class GenericUnitOfWork : IDisposable, IGenericUnitOfWork
    {
        protected GenericUnitOfWork(string connectionString)
        {
            var sessionFactory = DeliveryConfiguration.Configuration(connectionString).BuildSessionFactory();

            Session = sessionFactory.OpenSession();
            Transaction = Session.BeginTransaction(IsolationLevel.ReadCommitted);
        }

        public ISession Session { get; }
        private ITransaction Transaction { get; }

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
    }
}