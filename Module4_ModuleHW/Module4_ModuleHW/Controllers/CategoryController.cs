using Microsoft.AspNetCore.Mvc;
using Module4_ModuleHW.Configurations;
using Module4_ModuleHW.DTO;
using Module4_ModuleHW.Repositories;

namespace Module4_ModuleHW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly AppDBContext _context;

        public CategoryController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategory()
        {
            var repo = new GenerRepository(_context);
            var Category = await repo.GetAll<Category>();

            return Ok(Category);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var repo = new GenerRepository(_context);
            var category = await repo.GetOne<Category>(id);

            return Ok(category);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(Category category)
        {
            var repo = new GenerRepository(_context);
            await repo.Update<Category>(category);

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            var repo = new GenerRepository(_context);
            await repo.Create<Category>(category);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            if (_context.Category == null)
            {
                return NotFound();
            }
            var category = await GetCategory(id);
            if (category == null)
            {
                return NotFound();
            }

            var repo = new GenerRepository(_context);
            await repo.Delete<Category>(id);

            return NoContent();
        }
    }
}
