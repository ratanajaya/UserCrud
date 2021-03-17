using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserCrudAPI.BL;

namespace UserCrudAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private IAuthorizationManager authorizationManager;

        public UserController(IAuthorizationManager authorizationManager) {
            this.authorizationManager = authorizationManager;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(UserFormVm userForm) {
            bool result = await authorizationManager.RegisterUser(userForm);
            string message = result ? "Register succeed" : "Register failed";

            return Ok(message);
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(UserFormVm userForm) {
            bool result = await authorizationManager.AuthenticateUser(userForm);
            string message = result ? "Sign in succeed" : "Sign in failed";

            return Ok(message);
        }
    }
}
