using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace MrMohande3Khademi.SwaggerConfig
{
    public class HeaderConfig : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "TokenAccess",
                In =  ParameterLocation.Header,
                //Type = "string",
                Required = false
            });
        }
    }
}
