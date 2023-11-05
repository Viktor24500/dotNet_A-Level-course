using Microsoft.AspNetCore.Mvc;

namespace Module4_HW1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserByID(int id)
        {
            var user = await _userService.GetUserById(id);
            if (user == null) 
            {
                return NotFound();
            }
            
            return Ok(user);
        }

        [HttpPost] //create
        public async Task<IActionResult> CreateUser(User user)
        {
            await _userService.CreateUser(user);
            return CreatedAtAction(user.Name, user.Id);
        }

        [HttpPut("{id}")] //update full
        public async Task<IActionResult> UpdateUser(int id, User user)
        {
            var userUpdate = _userService.UpdateUser(id, user);
            if (userUpdate == null)
            {
                return NotFound();
            }
            return Ok(userUpdate);
        }

        public async Task<IActionResult> UpdateUserPartial(int id,
            [FromBody] Microsoft.AspNetCore.JsonPatch.JsonPatchDocument<User> patchDocument)
        {
            var existingUser = await _userService.GetUserById(id);

            if (existingUser == null)
            {
                return NotFound(new { message = "User not found" });
            }

            var patchedUser = new User();
            patchDocument.ApplyTo(patchedUser);

            if (string.IsNullOrEmpty(patchedUser.Name))
            {
                ModelState.AddModelError("Name", "Name is required");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedUser = await _userService.UpdateUserPartial(id, patchedUser);

            return Ok(updatedUser);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var deleted = await _userService.DeleteUser(id);

            if (!deleted)
            {
                return NotFound(new { message = "User not found" });
            }

            return NoContent();
        }
    }
}