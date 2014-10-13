using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrivelegeDemo.Startup))]
namespace PrivelegeDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
