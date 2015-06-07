using Delivery.Infrastructure.Conventions;
using Delivery.Infrastructure.Entities;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace Delivery
{
    public static class DeliveryConfiguration
    {
        public static FluentConfiguration Configuration(string connectionString = "defaultConnection")
        {
            var factory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(c => c.FromConnectionStringWithKey("defaultConnection")))
                .Mappings(val => val.AutoMappings.Add(AutoMap.AssemblyOf<Entity>(new AutomapConfiguration())));

            return factory;
        }
    }
}