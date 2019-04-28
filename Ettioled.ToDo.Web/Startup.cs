using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ettioled.ToDo.Web.Startup))]
namespace Ettioled.ToDo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
