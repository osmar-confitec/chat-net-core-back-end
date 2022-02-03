using CrossCutting;
using SlnDom.Domain.Interfaces;
using SlnDom.Domain.Models.User;
using SlnDom.Domain.Models.User.Request;
using SlnDom.Domain.Models.User.Response;
using SlnDom.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnDom.Domain.Services
{
    public class UserServices : BaseServiceEntity<UserDomain>, IUserServices
    {
        public UserServices(IUserRepository iBaseRepository, LNotifications lNotifications) 
            : base(iBaseRepository, lNotifications)
        {



        }

        public async Task<UserLoginResponse> Login(UserLoginRequest userLoginRequest)
        {
            var logResponse = new UserLoginResponse();


            var hash =  Security.CalculaHash(userLoginRequest.Password);
            var userSearch =  (await _iBaseRepository.
                                     _repositoryConsult.
                                     SearchAsync(x => x.Name == userLoginRequest.User && x.Password == hash)).
                                     FirstOrDefault();

            if (userSearch != null)
            {

                logResponse.Token = 
                    Security.GenerateJwt(new List<string>(),new List<System.Security.Claims.Claim>(),userSearch.Id.ToString(),userSearch.Email);


            }
            return logResponse;

        }
    }
}
