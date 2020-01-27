using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kt453316_MIS4200.Startup))]
namespace kt453316_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
