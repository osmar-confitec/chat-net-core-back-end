using SlnDom.Domain.Models.User.Request;
using SlnDom.Domain.Models.User.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SlnDom.Domain.Interfaces
{
   public interface IUserServices
    {

        Task<UserLoginResponse> Login(UserLoginRequest userLoginRequest);

    }
}
