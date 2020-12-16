using Microsoft.AspNetCore.Builder;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRWerbService.Startup))]

namespace SignalRWerbService
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}
