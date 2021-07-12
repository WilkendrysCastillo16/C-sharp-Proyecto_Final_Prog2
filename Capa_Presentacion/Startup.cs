using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Capa_Presentacion.Startup))]
namespace Capa_Presentacion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
