using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryIdentity.Startup))]
namespace TryIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
