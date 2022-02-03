using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHub.Models
{
    public class CustomerHub
    {

        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }


        public CustomerHub()
        {
            
        }

        public override string ToString()
        {
            return $" Nome: {Name}, Idade: {Age} ";
        }

    }
}
