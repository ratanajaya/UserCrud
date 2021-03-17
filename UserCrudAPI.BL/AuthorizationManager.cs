using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace UserCrudAPI.BL
{
    public class AuthorizationManager : IAuthorizationManager
    {
        UserManager<IdentityUser> userManager;
        SignInManager<IdentityUser> signInManager;

        public AuthorizationManager(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager) {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<bool> RegisterUser(UserFormVm userForm) {
            var user = new IdentityUser {
                UserName = userForm.Username,
            };

            var result = await userManager.CreateAsync(user, userForm.Password);
            
            return result.Succeeded;
        }

        public async Task<bool> AuthenticateUser(UserFormVm userForm) {
            var user = await userManager.FindByNameAsync(userForm.Username);
            if(user != null) {
                var result = await signInManager.CheckPasswordSignInAsync(user, userForm.Password, false);

                return result.Succeeded;
            }
            return false;
        }
    }
}
