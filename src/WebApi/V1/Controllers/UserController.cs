using App.Interfaces;
using CrossCutting;
using Microsoft.AspNetCore.Mvc;
using SlnDom.Domain.Models.User.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{

    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/user")]

    public class UserController : MainController
    {

        readonly IUserApplication _userApplication;
        public UserController(IUserApplication userApplication, LNotifications notifications) 
            : base(notifications)
        {

            _userApplication = userApplication;

        }


        [HttpGet]
        public async Task<IActionResult> Login([FromQuery] UserLoginRequest userLoginRequest)
        {
            return Ok(await _userApplication.Login(userLoginRequest));
        
        }
    }
}
