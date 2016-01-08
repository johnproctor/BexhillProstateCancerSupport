using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BPCS.Startup))]
namespace BPCS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
