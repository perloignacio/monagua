using API.Clases;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
            var cors = new EnableCorsAttribute(ConfigurationManager.AppSettings["urlFront"], "*", "*") { SupportsCredentials = true };
            config.EnableCors(cors);

            // Rutas de API web
            config.MapHttpAttributeRoutes();
            config.MessageHandlers.Add(new TokenValidationHandler());
            config.Filters.Add(new AuthorizationFilter());
        }
    }
}
