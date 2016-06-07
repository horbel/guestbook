using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Guestbook.Startup))]
namespace Guestbook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
