using CasePan.Data;
using CasePan.Dto;
using CasePan.Models;
using CasePan.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CasePan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // Injecting the IUserService to handle business logic
        private readonly IUserService _userService;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // Endpoint to retrieve all users
        [HttpGet("GetAllUsers")]
        public async Task<ActionResult<ResponseModel<List<UserModel>>>> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();
            return Ok(users);
        }

        // Endpoint to retrieve a user by their unique ID
        [HttpGet("GetUserById/{idUser}")]
        public async Task<ActionResult<ResponseModel<UserModel>>> GetUserById(Guid idUser)
        {
            var user = await _userService.GetUserById(idUser);
            return Ok(user);
        }

        // Endpoint to save a new user
        [HttpPost("SaveUser")]
        public async Task<ActionResult<ResponseModel<List<UserModel>>>> SaveUser([FromBody] CreateUserDTO userDto)
        {
            var user = await _userService.SaveUser(userDto);
            return Ok(user);
        }

        // Endpoint to update an existing user's information
        [HttpPut("EditUser")]
        public async Task<ActionResult<ResponseModel<UserModel>>> EditUser([FromBody] EditUserDto editUser)
        {
            var users = await _userService.EditUser(editUser);
            return Ok(users);
        }

        // Endpoint to delete a user by their unique ID
        [HttpDelete("DeleteUser")]
        public async Task<ActionResult<ResponseModel<UserModel>>> DeleteUser(Guid idUser)
        {
            var users = await _userService.DeleteUser(idUser);
            return Ok(users);
        }
    }
}