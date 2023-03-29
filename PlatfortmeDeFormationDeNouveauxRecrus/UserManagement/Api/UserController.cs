using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities.SignInRequest;
using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.UserServices;
using System.Runtime.InteropServices;

namespace PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Api
{
    [Route("User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {

            _userService = userService;

        }



        [HttpPost]
       // [Authorize(Roles ="Admin")]
        [Route("AddUser")]
        public IActionResult AddUser([FromBody] UserForm userForm)
        {

            User dbuser = new User();
            dbuser = _userService.AddUser(userForm);

            return Ok(dbuser);

        }



        [HttpPut]
        [Route("/addRoles")]
        public IActionResult AddRoles([FromBody] List<string> roles, int userId)
        {
            User dbuser = _userService.AddRoles(roles, userId);
            return Ok(dbuser);
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] SignIn signIn)
        {
            if (_userService.SignIn(signIn) == "wrong password")
            {
                return BadRequest("wrong password");
            }
            if (_userService.SignIn(signIn) == "wrong userName")
            {
                return BadRequest("wrong userName");
            }

           
            return Ok(new
            {
                token = _userService.SignIn(signIn),
                message = "Login successed !!"
            });

        }

        [HttpGet]
       // [Authorize(Roles = "Admin")]
        [Route("GetAllUsers")]

        public IActionResult GetAllUsers()
        {
            return Ok(_userService.GetUserById());
        }

        [HttpGet]
        // [Authorize(Roles = "Admin")]
        [Route("GetUserById/{id}")]

        public IActionResult GetUserById([FromRouteAttribute] int id)
        {
            return Ok(_userService.GetUserById(id));
        }

        [HttpGet]
        // [Authorize(Roles = "Admin")]
        [Route("GetUsersCount")]

        public IActionResult GetUsersCount()
        {
            return Ok(_userService.GetUsersCount());
        }

        [HttpDelete]
        [Route("DeleteUser/id")]

        public IActionResult RemoveUser(int id)
        {
            return Ok(_userService.RemoveUser(id));

        }




        }
    }
