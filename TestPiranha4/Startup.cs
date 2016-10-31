using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestPiranha4.Startup))]
namespace TestPiranha4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            Piranha.Application.Current.Handlers.Remove("PERMALINK");
            Piranha.Application.Current.Handlers.Add("blog", "PERMALINK",new Piranha.Web.Handlers.PermalinkHandler());
        }
    }
}
