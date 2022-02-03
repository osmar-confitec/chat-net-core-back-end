using SlnDom.Domain.Models.User.Request;
using SlnDom.Domain.Models.User.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Interfaces
{
   public interface IUserApplication : IBaseApplication
    {

        Task<UserLoginResponse> Login(UserLoginRequest userLoginRequest);


    }
}
