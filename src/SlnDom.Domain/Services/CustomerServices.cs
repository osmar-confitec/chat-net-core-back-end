using AutoMapper;
using CrossCutting;
using SlnDom.Domain.Interfaces;
using SlnDom.Domain.Models.Customer;
using SlnDom.Domain.Models.Customer.Request;
using SlnDom.Domain.Models.Customer.Response;
using SlnDom.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnDom.Domain.Services
{
    public class CustomerServices : BaseServiceEntity<CustomerDomain>, ICustomerServices

    {

        
        readonly IMapper _mapper;
        readonly IHttpClientApiHub _httpClientApiHub;
        public CustomerServices(ICustomerRepository iBaseRepository,
                                IMapper mapper,
                                IHttpClientApiHub httpClientApiHub, 
                                    LNotifications lNotifications) 
            : base(iBaseRepository, lNotifications)
        {

            _mapper = mapper;
            _httpClientApiHub = httpClientApiHub;
        }

        public async Task ActiveDeactive(Guid Id)
        {
            var customer = (await _iBaseRepository._repositoryConsult.SearchAsync(x => x.Id == Id)).FirstOrDefault();
            if (customer != null)
                customer.Active = !customer.Active;
        }

     
        public async Task<CustomerInsertRequest> Post(CustomerInsertRequest customerUpdateRequest)
        {
            var customerAdded = _mapper.Map<CustomerDomain>(customerUpdateRequest);
            await  AddAsync(customerAdded);
            await _httpClientApiHub.SendNewCustomer(customerAdded);
            return _mapper.Map<CustomerInsertRequest>(customerAdded);
        }

        public async Task<CustomerUpdateRequest> Put(CustomerUpdateRequest customerUpdateRequest)
        {
            await Task.Run(() => {
                var customerUpated = _mapper.Map<CustomerDomain>(customerUpdateRequest);
                Update(customerUpated);
                return customerUpdateRequest;
            });
            return null;
        }
    }
}
