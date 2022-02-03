using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiHub.Models;

namespace WebApiHub.HubConfig
{
    [Authorize]
    public class HubCustomer : Hub
    {
       public static ConcurrentDictionary<string, CustomerHub> 
                                                listCustomer = new ConcurrentDictionary<string, CustomerHub>();

      

        public async Task sendMessageCustomer(string message)
        {
            var model = JsonConvert.DeserializeObject<SendMessageCustomerViewModel>(message);
            var customerSearch = listCustomer.FirstOrDefault(x => x.Value.Id == model.CustomerId);
            if (!customerSearch.Equals(default(KeyValuePair<string, CustomerHub>)))
                await Clients.Client(customerSearch.Key)
                    .SendAsync("receive-message", JsonConvert.SerializeObject(model, new JsonSerializerSettings
                {
                    ContractResolver = new DefaultContractResolver
                    {
                        NamingStrategy = new CamelCaseNamingStrategy()
                    },
                    Formatting  = Formatting.Indented
                }));
        }


        public async Task sendMessageNewCustomer(string message)
        {
            var customerHub = JsonConvert.DeserializeObject<CustomerHub>(message);
            if (customerHub != null)
                await Clients.All.SendAsync("receive-message-new-customer",
                    JsonConvert.SerializeObject(customerHub, new JsonSerializerSettings
                {
                    ContractResolver = new DefaultContractResolver
                    {
                        NamingStrategy = new CamelCaseNamingStrategy()
                    },
                    Formatting = Formatting.Indented
                }));
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            listCustomer.Remove(Context.ConnectionId, out CustomerHub removed);
            await Clients.All.SendAsync("allConecteds", string.Join("|", listCustomer.Select(x => x.Value.Id.ToString())));
        }


        public async Task addCustomer(string message)
        {
            var model = JsonConvert.DeserializeObject<CustomerHub>(message);
            var customerSearched = listCustomer.FirstOrDefault(x => x.Value.Id == model.Id);
            if (!customerSearched.Equals(default(KeyValuePair<string, CustomerHub>)))
            {
                listCustomer.Remove(customerSearched.Key, out CustomerHub removed);

            }
            listCustomer.TryAdd(Context.ConnectionId, model);

            await Clients.All.SendAsync("allConecteds", string.Join("|", listCustomer.Select(x => x.Value.Id.ToString())));
        }

    }
}
