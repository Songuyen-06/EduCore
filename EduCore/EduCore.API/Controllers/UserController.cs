using EduCore.Domain.DTOs;
using EduCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace EduCore.API.Controllers
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
        [HttpGet("getUserById")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpPost("updateUser")]
        public async Task<IActionResult> UpdateUserPartial(int userId, [FromBody] UserDTO userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                await _userService.UpdateUserPartial(userId, userDto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
        [HttpPost("addUser")]
        public async Task<IActionResult> AddUser([FromBody] UserDTO userDto)
        {
            await _userService.AddUser(userDto);
            return Ok();
        }
        [HttpDelete("deleteUser")]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            try
            {
                await _userService.DeleteUser(userId);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
        [HttpGet("TotalUsers")]
        public async Task<IActionResult> GetTotalUsers()
        {
            int totalUsers = await _userService.GetTotalUserCount();
            return Ok(new { totalUsers });
        }
    }
}
