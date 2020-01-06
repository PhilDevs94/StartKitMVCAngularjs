using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.OData.Edm;
using StartMVCAngularJS.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace StartMVCAngularJS.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var builder = new ODataConventionModelBuilder();
            config.MapHttpAttributeRoutes();
            config.Count().Filter().OrderBy().Expand().Select().MaxTop(null);

            builder.EntitySet<PersonViewModel>("Person"); 
            builder.EntitySet<TaskViewModel>("Task");

            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            IEdmModel model = builder.GetEdmModel();
            config.MapODataServiceRoute("odata", "odata", model);
        }
    }
}
