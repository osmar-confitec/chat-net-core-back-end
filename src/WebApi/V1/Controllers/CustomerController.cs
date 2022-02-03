using App.Interfaces;
using CrossCutting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SlnDom.Domain.Models.Customer.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Controllers;

namespace WebApi.V1.Controllers
{

    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/customer")]
    public class CustomerController : MainController
    {

        readonly ICustomerApplication _customerApplication;
        public CustomerController(LNotifications notifications, ICustomerApplication customerApplication) 
            : base(notifications)
        {
            _customerApplication = customerApplication;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] CustomerGetRequest customerGetRequest)
            => await ExecControllerAsync(() => _customerApplication.Get(customerGetRequest));


        [HttpGet("allExcept")]
        public async Task<IActionResult> GetAllExcept([FromQuery] Guid id )
          => await ExecControllerAsync(() => _customerApplication.GetAllExcept(id));


        [HttpPut]
        public async Task<IActionResult> Put([FromBody] CustomerUpdateRequest customerUpdateRequest)
            => await ExecControllerAsync(() => _customerApplication.Put(customerUpdateRequest));

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CustomerInsertRequest customerInsertRequest)
         => await ExecControllerAsync(() => _customerApplication.Post(customerInsertRequest));


    }
}
