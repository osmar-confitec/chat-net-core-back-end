using App.Interfaces;
using CrossCutting;
using SlnDom.Domain.Interfaces;
using SlnDom.Domain.Models.User.Request;
using SlnDom.Domain.Models.User.Response;
using SlnDom.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class UserApplication : BaseApplication, IUserApplication
    {

        readonly IUserServices _userServices;
        public UserApplication(IUserServices userServices, IUnitOfWork _unitOfWork, LNotifications _LNotifications) 
            : base(_unitOfWork, _LNotifications)
        {

            _userServices = userServices;
        }

        public async Task<UserLoginResponse> Login(UserLoginRequest userLoginRequest)
         => await _userServices.Login(userLoginRequest);
    }
}
