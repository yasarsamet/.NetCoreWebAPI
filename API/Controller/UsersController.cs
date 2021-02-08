using Business.Abstract;
using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public List<Users> Get()
        {
            return _userService.GetAllUsers();
        }
        [HttpGet("GetList")]
        public List<Users> GetWithRoute()
        {
            return _userService.GetAllUsers();
        }
        [HttpGet("{id}")]
        public Users Get(int id)
        {
            return _userService.GetUserById(id);
        }
        [HttpPost]
        public Users UserAdd([FromBody]Users user)
        {
            return _userService.CreateUser(user);
        }
        [HttpPut]
        public Users UserUpdate([FromBody]Users user)
        {
            return _userService.Update(user);
        }
        [HttpDelete("{id}")]
        public void UserDelete(int id)
        {
            _userService.Delete(id);
        }

    }
}
