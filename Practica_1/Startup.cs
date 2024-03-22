using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practica_1.Startup))]
namespace Practica_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
