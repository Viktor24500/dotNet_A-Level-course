using Microsoft.AspNetCore.Mvc;
using Module4_ModuleHW.Configurations;
using Module4_ModuleHW.DTO;
using Module4_ModuleHW.Repositories;

namespace Module4_ModuleHW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly AppDBContext _context;

        public LocationController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocation()
        {
            var repo = new GenerRepository(_context);
            var models = await repo.GetAll<Location>();

            return Ok(models);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetLocation(int id)
        {
            var repo = new GenerRepository(_context);
            var model = await repo.GetOne<Location>(id);

            return Ok(model);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocation(Location location)
        {
            var repo = new GenerRepository(_context);
            await repo.Update<Location>(location);

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Location>> PostLocation(Location location)
        {
            var repo = new GenerRepository(_context);
            await repo.Create<Location>(location);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocation(int id)
        {
            if (_context.Location == null)
            {
                return NotFound();
            }
            var location = await GetLocation(id);
            if (location == null)
            {
                return NotFound();
            }

            var repo = new GenerRepository(_context);
            await repo.Delete<Location>(id);

            return NoContent();
        }
    }
}
