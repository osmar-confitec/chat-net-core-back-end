using SlnDom.Domain.Models.Customer.Request;
using SlnDom.Domain.Models.Customer.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Interfaces
{
  public  interface ICustomerApplication: IBaseApplication
    {

        Task<CustomerGetResponse> Get(CustomerGetRequest customerGetRequest);

        Task<CustomerGetResponse> GetAllExcept(Guid Id);


        Task<CustomerUpdateRequest> Put(CustomerUpdateRequest customerUpdateRequest);

        Task<CustomerInsertRequest> Post(CustomerInsertRequest customerUpdateRequest);

        Task ActiveDeactive(Guid Id);
    }
}
