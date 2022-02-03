using SlnDom.Domain.Models.Customer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SlnDom.Domain.Interfaces
{
   public interface IHttpClientApiHub
    {

        Task<bool> SendNewCustomer(CustomerDomain customer);

    }
}
