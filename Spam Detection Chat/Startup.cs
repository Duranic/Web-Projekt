using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Spam_Detection_Chat.Startup))]
namespace Spam_Detection_Chat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
