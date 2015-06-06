using Microsoft.Owin.Hosting;

namespace Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpLocalHost = "http://localhost:9090";
            using (WebApp.Start<Startup>(httpLocalHost))
            {
                System.Console.WriteLine("Listening on " + httpLocalHost);
                System.Console.WriteLine("Press [enter] to quit...");
                System.Console.ReadLine();
            }
        }
    }
}
