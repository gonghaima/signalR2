using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

//[assembly: OwinStartup(typeof(SignalR2.StockTicker.Startup))]

namespace SignalR2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }

        public static void ConfigureSignalR(IAppBuilder app)
        {
            // For more information on how to configure your application using OWIN startup, visit http://go.microsoft.com/fwlink/?LinkID=316888

            app.MapSignalR();
        }

    }
}
