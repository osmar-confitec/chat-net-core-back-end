using SlnDom.Domain.Models.Customer;
using SlnDom.Domain.Models.Customer.Request;
using SlnDom.Domain.Models.Customer.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SlnDom.Domain.Interfaces
{
   public interface ICustomerServices:IBaseService<CustomerDomain> 
    {


        Task<CustomerUpdateRequest> Put(CustomerUpdateRequest customerUpdateRequest);

        Task<CustomerInsertRequest> Post(CustomerInsertRequest customerUpdateRequest);

        Task ActiveDeactive(Guid Id);
    }
}
