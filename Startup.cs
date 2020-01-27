using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(km956216_MIS4200_.Startup))]
namespace km956216_MIS4200_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
