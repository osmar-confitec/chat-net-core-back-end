using SlnDom.Domain.Models.Customer;
using SlnDom.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public class CustomerRepository : BaseRepository<CustomerDomain>, ICustomerRepository
    {
        public CustomerRepository(IUnitOfWork _unitOfWork) 
            : base(_unitOfWork)
        {
        }
    }
}
