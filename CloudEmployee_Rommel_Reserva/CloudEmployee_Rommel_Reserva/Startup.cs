using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CloudEmployee_Rommel_Reserva.Startup))]
namespace CloudEmployee_Rommel_Reserva
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
