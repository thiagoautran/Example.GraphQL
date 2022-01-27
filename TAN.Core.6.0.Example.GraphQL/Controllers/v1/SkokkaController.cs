using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TAN.Core._6._0.Example.GraphQL.Controllers.v1
{
    [Produces("application/json")]
    [ApiVersion("1")]
    [ApiExplorerSettings(GroupName = "v1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/skokka")]
    public class SkokkaController : ControllerBase
    {
        public SkokkaController()
        {
        }

        [HttpGet]
        [MapToApiVersion("1")]
        public async Task<ContentResult> GetEscortsHtmlAsync()
        {
            return await Task.Run(() => 
            { 
                return new ContentResult 
                {
                    ContentType = "text/html",
                    Content = string.Empty
                };
            });
        }
    }
}