using Newtonsoft.Json;
using SlnDom.Domain.Interfaces;
using SlnDom.Domain.Models.Customer;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SlnDom.Domain.Services
{
   public class HttpClientApiHub: IHttpClientApiHub
    {

        readonly HttpClient _httpClient;

        public HttpClientApiHub(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> SendNewCustomer(CustomerDomain customer)
        {
            var customerSend = JsonConvert.SerializeObject(customer);
            var httpContent = new StringContent(customerSend, Encoding.UTF8, "application/json");
            var httpResponseMessage = await _httpClient.PostAsync("/Customer", httpContent);

           // var responseContent = await httpResponseMessage.Content.ReadAsStringAsync();

            return httpResponseMessage.IsSuccessStatusCode;


        }
    }
}
