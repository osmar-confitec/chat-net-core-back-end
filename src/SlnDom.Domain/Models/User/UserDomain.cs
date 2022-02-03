using System;
using System.Collections.Generic;
using System.Text;

namespace SlnDom.Domain.Models.User
{
  public class UserDomain : EntityDataBase
    {


        public string Name { get; set; }

        public string Password { get; set; }


        public string Email { get; set; }


    }
}
 