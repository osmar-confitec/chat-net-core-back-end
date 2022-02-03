using AutoMapper;
using SlnDom.Domain.Models.Customer;
using SlnDom.Domain.Models.Customer.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.AutoMapper
{
   public class DomainToDtoMappingProfile: Profile
    {

        public DomainToDtoMappingProfile()
        {

            CreateMap<CustomerDomain, CustomerGetDto>();

        }

    }
}
