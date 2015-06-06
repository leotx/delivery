using Delivery.Infrastructure.Conventions;
using Delivery.Infrastructure.Entities;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Owin.Cors;
using Owin;

namespace Delivery
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
        }
    }
}