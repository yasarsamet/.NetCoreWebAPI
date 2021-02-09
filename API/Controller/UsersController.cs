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
        [Route("[action]")]
        public IActionResult Get()
        {
            var users = _userService.GetAllUsers();
            return Ok(users); //200 + data 
        }        
        /// <summary>
        /// Get By Id User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet()]
        [Route("[action]/{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetUserById(id);
            if (user != null)
            {
                return Ok(user); // 200+ data 
            }
            else
            {
                return NotFound(); // 404 Not Found 
            }            
        }
        /// <summary>
        /// Add the User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public IActionResult UserAdd([FromBody]Users user)
        {               
                var AddUser = _userService.CreateUser(user);
                return RedirectToAction("Get", AddUser.Id);
        }
        /// <summary>
        /// Update the User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("[action]")]
        public IActionResult UserUpdate([FromBody]Users user)
        {
            if (_userService.GetUserById(user.Id)!=null)
            {
                var UpdateUser = _userService.Update(user);
                return Ok(UpdateUser);
            }
            return NotFound();
        }
        /// <summary>
        /// Delete the User
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        [Route("[action]/{id}")]
        public IActionResult UserDelete(int id)
        {
            if (_userService.GetUserById(id)!=null)
            {
                _userService.Delete(id);
                return Ok();
            }
            return NotFound();
        }

    }
}
