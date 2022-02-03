using System;
using System.Collections.Generic;
using System.Text;

namespace SlnDom.Domain.Models.Customer.Dto
{
   public class CustomerGetDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
