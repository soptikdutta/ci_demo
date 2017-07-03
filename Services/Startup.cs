﻿using System.Web.Http;
using Owin;

namespace Services
{
    public static class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public static void ConfigureApp(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            //HttpConfiguration config = new HttpConfiguration();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //appBuilder.UseWebApi(config);

            HttpConfiguration config = new HttpConfiguration();

            //config.Filters.Add(new LogRequest());
            //RegisterExceptionFilter(config);

            config.MapHttpAttributeRoutes();

            //SwaggerConfig.Register(config);
            //app.UseCors(CorsOptions.AllowAll);

            //config.MessageHandlers.Insert(0, new CompressionHandler());
            appBuilder.UseWebApi(config);
        }
    }
}
