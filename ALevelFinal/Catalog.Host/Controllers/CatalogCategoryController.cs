using Catalog.Host.Service;
using Catalog.Host.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogCategoryController : ControllerBase
    {
        private readonly ILogger<CatalogCategoryController> _logger;
        private readonly ICatalogCategoryService _catalogCategoryService;

        public CatalogCategoryController(ILogger<CatalogCategoryController> logger, CatalogCategoryService catalogCategoryService)
        {
            _logger = logger;
            _catalogCategoryService = catalogCategoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var result = _catalogCategoryService.GetCategories();
            return Ok(result);
        }
    }
}
