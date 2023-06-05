using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace HCLTech.SMACR.Filters;

public class CustomSwaggerFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        string[] filteredUrls = new string[]
        {
            "/api/abp/",
            "/api/setting-management",
            "/api/feature-management/",
            "/api/permission-management",
            "/api/identity/roles",
            "/api/multi-tenancy",
            "/api/identity/",
            "/api/account/"
        }
        ;
        swaggerDoc.Paths
            .Where(x => 
            { 
                foreach (string url in filteredUrls)
                {
                    if (x.Key.ToLowerInvariant().Contains(url))
                      return true;
                }
                return false;
            })
            .ToList().ForEach(x => swaggerDoc.Paths.Remove(x.Key));
    }
}

