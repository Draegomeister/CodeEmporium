using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeEmporium.Startup))]
namespace CodeEmporium
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
