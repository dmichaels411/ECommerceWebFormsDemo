using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ECommerceWebFormsDemo.Startup))]
namespace ECommerceWebFormsDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
