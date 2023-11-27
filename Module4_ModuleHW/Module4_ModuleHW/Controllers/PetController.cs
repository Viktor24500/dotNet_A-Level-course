using Microsoft.AspNetCore.Mvc;
using Module4_ModuleHW.Configurations;
using Module4_ModuleHW.DTO;
using Module4_ModuleHW.Repositories;

namespace Module4_ModuleHW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly AppDBContext _context;

        public PetController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pet>>> GetPet()
        {
            var repo = new GenerRepository(_context);
            var models = await repo.GetAll<Pet>();

            return Ok(models);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pet>> GetPet(int id)
        {
            var repo = new GenerRepository(_context);
            var models = await repo.GetOne<Pet>(id);

            return Ok(models);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPet(Pet pet)
        {
            var repo = new GenerRepository(_context);
            await repo.Update<Pet>(pet);

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Pet>> PostPet(Pet pet)
        {
            var repo = new GenerRepository(_context);
            await repo.Create<Pet>(pet);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePet(int id)
        {
            if (_context.Pet == null)
            {
                return NotFound();
            }
            var pet = await GetPet(id);
            if (pet == null)
            {
                return NotFound();
            }
            var repo = new GenerRepository(_context);
            await repo.Delete<Pet>(id);

            return NoContent();
        }
    }
}
