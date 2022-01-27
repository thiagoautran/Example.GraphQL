using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace TAN.Core._5._0.Skokka.Api.Controllers.v1
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
            return new ContentResult 
            {
                ContentType = "text/html",
                Content = string.Empty
            };
        }
    }
}