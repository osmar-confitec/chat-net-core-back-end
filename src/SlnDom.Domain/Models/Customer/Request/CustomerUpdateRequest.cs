using System;
using System.Collections.Generic;
using System.Text;

namespace SlnDom.Domain.Models.Customer.Request
{
    public class CustomerUpdateRequest: CustomerRequest
    {
        public Guid Id { get; set; }
    }
}
