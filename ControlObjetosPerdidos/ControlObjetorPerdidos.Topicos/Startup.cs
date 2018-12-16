using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlObjetorPerdidos.Topicos.Startup))]
namespace ControlObjetorPerdidos.Topicos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
