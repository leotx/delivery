using System;
using Delivery.Infrastructure.Conventions;
using Delivery.Infrastructure.Entities;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Delivery.Infrastructure
{
    public class GenericUnitOfWork : IDisposable
    {
        public ISessionFactory Factory { get; set; }
        public ITransaction Transaction { get; set; }

        public GenericUnitOfWork(string connectionString)
        {
            Factory = Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(c => c.FromConnectionStringWithKey(connectionString)))
                .Mappings(val => val.AutoMappings.Add(AutoMap.AssemblyOf<Entity>(new Config())))
                .BuildSessionFactory();

            var openSession = Factory.OpenSession();
            Transaction = openSession.BeginTransaction();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}