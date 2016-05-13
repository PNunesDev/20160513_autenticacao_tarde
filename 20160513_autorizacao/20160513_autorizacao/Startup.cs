using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_20160513_autorizacao.Startup))]
namespace _20160513_autorizacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
