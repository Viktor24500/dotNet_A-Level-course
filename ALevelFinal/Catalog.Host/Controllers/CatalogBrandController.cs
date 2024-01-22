using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogBrandController : ControllerBase
    {
        private readonly ILogger<CatalogBrandController> _logger;

        public CatalogBrandController(ILogger<CatalogBrandController> logger)
        {
            logger = _logger;
        }
    }
}
