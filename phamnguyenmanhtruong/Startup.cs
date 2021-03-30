using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(phamnguyenmanhtruong.Startup))]
namespace phamnguyenmanhtruong
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
