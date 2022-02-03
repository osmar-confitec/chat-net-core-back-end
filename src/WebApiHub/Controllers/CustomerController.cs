using Microsoft.AspNet.SignalR.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHub.HubConfig;
using WebApiHub.Models;

namespace WebApiHub.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        readonly IHubContext<HubCustomer>  _hubCustomerContext ;

        
        public CustomerController( IHubContext<HubCustomer> hubCustomerContext)
        {
            _hubCustomerContext = hubCustomerContext;
        }


        [HttpPost]
        public async Task<IActionResult> SendNewCustomer(CustomerHub customerHub)
        {
              await _hubCustomerContext.Clients.All.SendAsync("receive-message-new-customer",
                    JsonConvert.SerializeObject(customerHub, new JsonSerializerSettings
                {
                    ContractResolver = new DefaultContractResolver
                    {
                        NamingStrategy = new CamelCaseNamingStrategy()
                    },
                    Formatting = Formatting.Indented
                }));

            return Ok(null);


        }

    }
}
