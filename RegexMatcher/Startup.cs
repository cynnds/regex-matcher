using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RegexMatcher.Startup))]
namespace RegexMatcher
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
