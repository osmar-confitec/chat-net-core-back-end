using AutoMapper;
using SlnDom.Domain.Models.Customer;
using SlnDom.Domain.Models.Customer.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.AutoMapper
{
   public class RequestToDomainMappingProfile : Profile
    {
        public RequestToDomainMappingProfile()
        {
            CreateMap<CustomerInsertRequest, CustomerDomain>();

            CreateMap<CustomerDomain,  CustomerInsertRequest >();

            //
        }
    }
}
