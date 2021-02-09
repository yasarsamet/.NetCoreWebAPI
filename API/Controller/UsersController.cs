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
        /// <summary>
        /// Get All User
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Users> Get()
        {
            return _userService.GetAllUsers();
        }
        /// <summary>
        /// Get All User2
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetList")]
        public List<Users> GetWithRoute()
        {
            return _userService.GetAllUsers();
        }
        /// <summary>
        /// Get By Id User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Users Get(int id)
        {
            return _userService.GetUserById(id);
        }
        /// <summary>
        /// Add the User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public Users UserAdd([FromBody]Users user)
        {
            return _userService.CreateUser(user);
        }
        /// <summary>
        /// Update the User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        public Users UserUpdate([FromBody]Users user)
        {
            return _userService.Update(user);
        }
        /// <summary>
        /// Delete the User
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void UserDelete(int id)
        {
            _userService.Delete(id);
        }

    }
}
