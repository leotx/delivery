using System;
using Microsoft.Owin.Hosting;
using NHibernate.Tool.hbm2ddl;

namespace Delivery
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string httpLocalHost = "http://localhost:9090";

            using (WebApp.Start<Startup>(httpLocalHost))
            {
                CreateDatabase();
                Console.WriteLine("Listening on " + httpLocalHost);
                Console.WriteLine("Press [enter] to quit...");
                Console.ReadLine();
            }
        }

        private static void CreateDatabase()
        {
            var fluentConfiguration = DeliveryConfiguration.Configuration();
            var exportDatabase = new SchemaExport(fluentConfiguration.BuildConfiguration());
            exportDatabase.Execute(true, true, false);
        }
    }
}