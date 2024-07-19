using CourseServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace CourseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getListUser")]
        [EnableQuery]
        public async Task<IActionResult> Get()
        {
            var listUser = await _userService.GetListUser();
            return Ok(listUser);
        }
    }
}
