using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using System.Web.Optimization;
using System.Web.Routing;
using Owin;
[assembly: OwinStartup(typeof(SignalRChat.Startup))]
namespace SignalRChat
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            string connectionString = "Endpoint=sb://signalrimagehub.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=3EFkMMz73I2YG0qqjNWrf0PNHhct7qamqWlKZT1f+tU=";
            GlobalHost.DependencyResolver.UseServiceBus(connectionString, "Chat");
            
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
            
        }
    }
}