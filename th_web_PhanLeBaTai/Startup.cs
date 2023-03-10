using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(th_web_PhanLeBaTai.Startup))]
namespace th_web_PhanLeBaTai
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
