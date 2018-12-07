using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlObjetos.MVC.Startup))]
namespace ControlObjetos.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
