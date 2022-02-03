using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHub.Models
{
    public class SendMessageCustomerViewModel
    {

        public  string Message { get; set; }

        public Guid CustomerId { get; set; }

        public CustomerHub CustomerSendId { get; set; }

         


    }
}
