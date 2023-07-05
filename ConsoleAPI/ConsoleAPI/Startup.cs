using Owin;
using System.Web.Http;

namespace ConsoleAPI
{
    class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration CONFIG = new HttpConfiguration();
            CONFIG.EnableCors();

            CONFIG.Routes.MapHttpRoute(
                name: "UpdatePrice",
                routeTemplate: "api/{controller}/{id}/{page}/{sale_price}/{list_price}",
                defaults: null
            );

            CONFIG.Routes.MapHttpRoute(
                name: "UpdateStock",
                routeTemplate: "api/{controller}/{id}/{page}/{quantity}",
                defaults: null
            );

            CONFIG.Routes.MapHttpRoute(
                name: "PublicacionesVentas",
                routeTemplate: "api/{controller}/{page}/{size}/{sort}/{status}/{cart_id}/{company_id}/{search}/{from}/{to}",
                defaults:  default
            );

            CONFIG.Routes.MapHttpRoute(
                name: "PublicacionesParametros1",
                routeTemplate: "api/{controller}/{page}/{size}/{status}/{sort}/{paused}/{brand_id}/{search}/{category_id}",
                defaults: default
            );

            CONFIG.Routes.MapHttpRoute(
                 name: "PublicacionesParametros2",
                 routeTemplate: "api/{controller}/{page}/{size}/{status}/{sort}/{paused}/{brand_id}",
                 defaults: default
             );

            CONFIG.Routes.MapHttpRoute(
                name: "EnviosIds",
                routeTemplate: "api/{controller}/{ids}/{name}",
                defaults: default
            );

            CONFIG.Routes.MapHttpRoute(
                name: "UnParametro",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );



            appBuilder.UseWebApi(CONFIG);
        }
    }
}
