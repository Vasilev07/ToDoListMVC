using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoListMVC.Startup))]
namespace ToDoListMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
