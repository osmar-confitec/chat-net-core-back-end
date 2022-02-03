using SlnDom.Domain.Models.Customer.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlnDom.Domain.Models.Customer.Response
{
   public class CustomerGetResponse
    {

        public IEnumerable<CustomerGetDto> CustomerGetDtos  { get; set; }

        public CustomerGetResponse()
        {
            CustomerGetDtos = new List<CustomerGetDto>();
        }

    }
}
