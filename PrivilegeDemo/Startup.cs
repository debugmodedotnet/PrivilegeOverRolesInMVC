using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrivilegeDemo.Startup))]
namespace PrivilegeDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
