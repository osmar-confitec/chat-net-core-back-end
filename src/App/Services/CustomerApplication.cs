using App.Interfaces;
using AutoMapper;
using CrossCutting;
using Microsoft.EntityFrameworkCore;
using SlnDom.Domain.Interfaces;
using SlnDom.Domain.Models.Customer;
using SlnDom.Domain.Models.Customer.Dto;
using SlnDom.Domain.Models.Customer.Request;
using SlnDom.Domain.Models.Customer.Response;
using SlnDom.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class CustomerApplication : BaseApplication, ICustomerApplication
    {

        readonly IBaseConsultRepository<CustomerDomain> _baseConsultRepository;
        readonly IMapper _mapper;
        readonly ICustomerServices _customerServices;
        public CustomerApplication(IUnitOfWork _unitOfWork,
                                   IMapper mapper,
                                   ICustomerServices customerServices,
                                   LNotifications _LNotifications)
            : base(_unitOfWork, _LNotifications)
        {
            _baseConsultRepository = UnitOfWork.GetRepository<CustomerDomain>();
            _mapper = mapper;
            _customerServices = customerServices;
        }

        public async Task ActiveDeactive(Guid Id)
        {
            await _customerServices.ActiveDeactive(Id);
            await UnitOfWork.CommitAsync();
        }

        public async Task<CustomerGetResponse> Get(CustomerGetRequest customerGetRequest)
        {
            var query = _baseConsultRepository.GetQueryable();
            if (!string.IsNullOrEmpty(customerGetRequest.Name))
                query = query.Where(x => x.Name.Contains(customerGetRequest.Name));

            return new CustomerGetResponse
            {
                CustomerGetDtos = (await query.ToListAsync()).Select(x => _mapper.Map<CustomerGetDto>(x))
            };
        }

        public async Task<CustomerGetResponse> GetAllExcept(Guid Id)
        {
            var listExcept = await _baseConsultRepository.SearchAsync(x => x.Id != Id);
            return new CustomerGetResponse
            {
                CustomerGetDtos = listExcept.Select(x => _mapper.Map<CustomerGetDto>(x))
            };
        }

        public async Task<CustomerInsertRequest> Post(CustomerInsertRequest customerUpdateRequest)
        {
            var custumer = await _customerServices.Post(customerUpdateRequest);
            await UnitOfWork.CommitAsync();
            return custumer;
        }

        public async Task<CustomerUpdateRequest> Put(CustomerUpdateRequest customerUpdateRequest)
        {
            var custumer = await _customerServices.Put(customerUpdateRequest);
            await UnitOfWork.CommitAsync();
            return custumer;
        }
    }
}
