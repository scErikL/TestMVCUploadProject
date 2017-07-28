using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMVCUploadProject.Startup))]
namespace TestMVCUploadProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
