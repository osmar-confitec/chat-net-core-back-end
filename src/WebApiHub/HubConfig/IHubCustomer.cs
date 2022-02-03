using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHub.HubConfig
{
   public interface IHubCustomer
    {

        Task sendMessageCustomer(string message);
        Task sendMessageNewCustomer(string message);
        Task addCustomer(string message);
    }
}
