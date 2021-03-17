using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserCrudAPI.BL
{
    public interface IAuthorizationManager
    {
        Task<bool> RegisterUser(UserFormVm userForm);
        Task<bool> AuthenticateUser(UserFormVm userForm);
    }
}
