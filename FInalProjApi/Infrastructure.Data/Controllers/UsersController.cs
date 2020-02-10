using System;
using AutoMapper;
using Infrastructure.Data.Dtos;
using Infrastructure.Data.Models;
using Infrastructure.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Data.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IService<User> _userService;

        private readonly IMapper _mapper;

        public UsersController(IMapper mapper, IService<User> userService)
        {
            _mapper = mapper;
            _userService = userService;
        }
        
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _userService.GetAll();
            //var userDto = _mapper.Map<List<UserDto>>(user);
            return Ok(users);
        }
        
        [HttpPost("add")]
        public IActionResult AddUser(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            _userService.Add(user);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteUser([FromRoute] int id)
        {
            _userService.Delete(id);
            return Ok();
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateUser(UserDto userDto, [FromRoute] int id)
        {
            var user = _mapper.Map<User>(userDto);
            user.Id = id;
            _userService.Update(user);
            return Ok();
        }

    }
}