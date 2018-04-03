using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HikeIt.Startup))]
namespace HikeIt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
