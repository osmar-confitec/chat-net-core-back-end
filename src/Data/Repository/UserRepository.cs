using SlnDom.Domain.Models.User;
using SlnDom.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class UserRepository : BaseRepository<UserDomain>, IUserRepository
    {
        public UserRepository(IUnitOfWork _unitOfWork) 
            : base(_unitOfWork)
        {



        }
    }
}
