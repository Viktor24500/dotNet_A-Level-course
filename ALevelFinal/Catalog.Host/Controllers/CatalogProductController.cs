using Catalog.Host.Data.Entities;
using Catalog.Host.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogProductController : ControllerBase
    {
        private readonly ILogger<CatalogProductController> _logger;
        private readonly ICatalogProductService _catalogProductService;

        public CatalogProductController(ILogger<CatalogProductController> logger, ICatalogProductService catalogProductService)
        {
            _logger = logger;
            _catalogProductService = catalogProductService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductByCategory(Category category)
        {
            var result = await _catalogProductService.GetProductByCategory(category);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductByID(int id)
        {
            var result = await _catalogProductService.GetProductByID(id);
            return Ok(result);
        }
    }
}
