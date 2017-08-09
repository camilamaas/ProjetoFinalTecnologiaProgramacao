using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoFinalFaculdade.Startup))]
namespace ProjetoFinalFaculdade
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
