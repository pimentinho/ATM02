using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATM02.Startup))]
namespace ATM02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
