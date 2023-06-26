using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnjaliArtGalleryProject.Startup))]
namespace AnjaliArtGalleryProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
