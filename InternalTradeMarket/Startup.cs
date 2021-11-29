using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InternalTradeMarket.Startup))]
namespace InternalTradeMarket
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
