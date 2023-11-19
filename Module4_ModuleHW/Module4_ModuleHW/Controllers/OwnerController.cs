using Microsoft.AspNetCore.Mvc;
using Module4_ModuleHW.Configurations;
using Module4_ModuleHW.DTO;
using Module4_ModuleHW.Repositories;

namespace Module4_ModuleHW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly AppDBContext _context;

        public OwnerController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Owner>>> GetOwners()
        {
            var repo = new GenerRepository(_context);
            var models = await repo.GetAll<Owner>();

            return Ok(models);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Owner>> GetOwner(int id)
        {
            var repo = new GenerRepository(_context);
            var models = await repo.GetOne<Owner>(id);

            return Ok(models);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOwner(Owner owner)
        {
            var repo = new GenerRepository(_context);
            await repo.Update<Owner>(owner);

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Owner>> PostOwner(Owner owner)
        {
            var repo = new GenerRepository(_context);
            await repo.Create<Owner>(owner);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOwner(int id)
        {
            if (_context.Owner == null)
            {
                return NotFound();
            }
            var owner = await GetOwner(id);
            if (owner == null)
            {
                return NotFound();
            }

            var repo = new GenerRepository(_context);
            await repo.Delete<Owner>(id);

            return NoContent();
        }
    }
}
