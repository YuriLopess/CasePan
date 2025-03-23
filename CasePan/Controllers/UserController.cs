using CasePan.Data;
using CasePan.Models;
using CasePan.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasePan.Controllers
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

        [HttpGet("GetAllUsers")]
        public async Task<ActionResult<ResponseModel<List<UserModel>>>> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("GetUserById/{idUser}")]
        public async Task<ActionResult<ResponseModel<UserModel>>> GetUserById(Guid idUser)
        {
            var user = await _userService.GetUserById(idUser);
            return Ok(user);
        }

        [HttpPost("SaveUser")]
        public async Task<ActionResult<ResponseModel<UserModel>>> SaveUser([FromBody] CreateUserDTO userDto)
        {
            var user = await _userService.SaveUser(userDto);
            return Ok(user);
        }

    }
}
