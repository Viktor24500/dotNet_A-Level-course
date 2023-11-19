using Microsoft.AspNetCore.Mvc;
using Module4_ModuleHW.Configurations;
using Module4_ModuleHW.DTO;
using Module4_ModuleHW.Repositories;

namespace Module4_ModuleHW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreedController : ControllerBase
    {
        private readonly AppDBContext _context;

        public BreedController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Breed>>> GetBreed()
        {
            var repo = new GenerRepository(_context);
            var Breed = await repo.GetAll<Breed>();

            return Ok(Breed);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Breed>> GetBreed(int id)
        {
            var repo = new GenerRepository(_context);
            var breed = await repo.GetOne<Breed>(id);

            return Ok(breed);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBreed(Breed breed)
        {
            var repo = new GenerRepository(_context);
            await repo.Update<Breed>(breed);

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Breed>> PostBreed(Breed breed)
        {
            var repo = new GenerRepository(_context);
            await repo.Create<Breed>(breed);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBreed(int id)
        {
            if (_context.Breed == null)
            {
                return NotFound();
            }
            var breed = await GetBreed(id);
            if (breed == null)
            {
                return NotFound();
            }

            var repo = new GenerRepository(_context);
            await repo.Delete<Breed>(id);

            return NoContent();
        }
    }
}
