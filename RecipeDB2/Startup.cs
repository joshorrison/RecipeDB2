using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecipeDB2.Startup))]
namespace RecipeDB2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
