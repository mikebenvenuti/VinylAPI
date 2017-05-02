using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using AirVinyl.Model;
using System.Web.Http.Cors;

namespace AirVinyl.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            

            config.MapODataServiceRoute("ODataRoute", "odata", GetEdmModel());
            var cors = new EnableCorsAttribute("http://localhost:63342", "*", "*");
            config.EnableCors(cors);
            config.Count().Filter().OrderBy().Expand().Select().MaxTop(null); 
            config.EnsureInitialized();


        }
        private static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
         
            builder.Namespace = "AirVinyl";
            builder.ContainerName = "AirVinylContainer";

            builder.EntitySet<Person>("People");
            builder.EntitySet<VinylRecord>("VinylRecords");
            builder.EntitySet<CONFIG>("Config");
            builder.EntitySet<TICKET>("Ticket");

            return builder.GetEdmModel();

        }
    }
}
