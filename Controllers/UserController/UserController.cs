using Microsoft.AspNetCore.Mvc;
using ProfessionalGYM.DataTransferModel.GymUser;
using ProfessionalGYM.Interfaces.IUser;

namespace ProfessionalGYM.Controllers.UserController
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUser userService;

        public UserController(IUser userService)
        {
            this.userService = userService;
        }
        [HttpPost("CreateUser")]
        // [Authorize]
        public async Task<IActionResult> CreateUser(UserVM user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await userService.CreateUser(user);
            return Ok(result);
        }
    }
}
