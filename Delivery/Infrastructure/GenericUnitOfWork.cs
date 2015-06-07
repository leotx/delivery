﻿using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using Delivery.Infrastructure.Conventions;
using Delivery.Infrastructure.Entities;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace Delivery.Infrastructure
{
    public class GenericUnitOfWork : IDisposable, IGenericUnitOfWork    
    {
        public ISession Session { get; private set; }
        public ITransaction Transaction { get; }

        public GenericUnitOfWork(string connectionString)
        {
            var sessionFactory = Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(c => c.FromConnectionStringWithKey(connectionString)))
                .Mappings(val => val.AutoMappings.Add(AutoMap.AssemblyOf<Entity>(new Config())))
                .BuildSessionFactory();

            Session = sessionFactory.OpenSession();
            Transaction = Session.BeginTransaction(IsolationLevel.ReadCommitted);
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

        public void Dispose()
        {
            Session?.Dispose();
            Transaction?.Dispose();
        }
    }
}