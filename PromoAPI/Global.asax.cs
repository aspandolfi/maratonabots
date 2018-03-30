using PromoAPI.App_Start;
using System.Web.Http;

namespace PromoAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            SimpleInjectorInitializer.Initialize();
        }
    }
}
