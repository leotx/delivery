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