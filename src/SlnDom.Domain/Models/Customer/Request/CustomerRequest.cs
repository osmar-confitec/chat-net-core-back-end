using System;
using System.Collections.Generic;
using System.Text;

namespace SlnDom.Domain.Models.Customer.Request
{
   public abstract class CustomerRequest
    {
        public int Age { get; set; }

        public string Name { get; set; }
    }
}
