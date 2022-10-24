using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TianLi_Version_Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GenshinImpactTianLiController : ControllerBase
    {
        private readonly ILogger<GenshinImpactTianLiController> _logger;

        public GenshinImpactTianLiController(ILogger<GenshinImpactTianLiController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        [Route("Version/Latest")]
        public IActionResult GetLatestVersion()
        {
            return Ok(new GenshinImpactTianLi());
        }
    }
}
